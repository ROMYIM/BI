using Core.DataBase.Mongo.DbAccessor;
using Core.DataBase.Mongo.Models;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace Core.DataBase.Mongo
{
    public class MongoDbContext
    {
        /// <summary>
        /// 连接设置
        /// </summary>
        private readonly MongoCollectionSettings _collectionSettings;

        /// <summary>
        /// 选项配置
        /// </summary>
        private readonly MongoDbOptions _options;

        /// <summary>
        /// MongoDB数据库
        /// </summary>
        private readonly IMongoDatabase _database;

        /// <summary>
        /// MongoDB数据库
        /// </summary>
        //private _database MongoDb { get; set; }

        /// <summary>
        /// MongoDB客户端
        /// </summary>
        private readonly MongoClient _client;

        /// <summary>
        /// 表名字典
        /// </summary>
        private static readonly ConcurrentDictionary<Type, string> TableNameDic =
            new ConcurrentDictionary<Type, string>();

        /// <summary>
        /// MongoClient字典，实际上是连接池字典
        /// </summary>
        //private static readonly ConcurrentDictionary<string, MongoClient> Clients =
        //    new ConcurrentDictionary<string, MongoClient>();

        //private static readonly object LockObj = new object();

        /// <summary>
        /// 获取表名
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private static string GetTableName(Type type)
        {
            return TableNameDic.GetOrAdd(type, key =>
            {
                var attrs = Attribute.GetCustomAttributes(type);
                var tableAttr = attrs.OfType<TableAttribute>().FirstOrDefault();
                var tableName = tableAttr == null ? type.Name : tableAttr.Name;
                return tableName;
            });
        }

        public MongoDatabase Database { get => _client.GetServer().GetDatabase(_options.Database); }

        /// <summary>
        /// 构造函数。依赖注入选线参数
        /// </summary>
        /// <param name="options"></param>
        public MongoDbContext(IOptions<MongoDbOptions> options)
        {
            //InitMember(connectionString.ConnectionString, connectionString.Database);
            _collectionSettings = new MongoCollectionSettings
            {
                AssignIdOnInsert = true,
                WriteConcern = WriteConcern.WMajority
               
            };
            

            _options = options.Value;
            _client = new MongoClient(new MongoUrl(_options.ConnectionString));
            _database = _client.GetDatabase(_options.Database);

            if (!_options.Master)
                _collectionSettings.ReadPreference = new ReadPreference(ReadPreferenceMode.SecondaryPreferred);
            else
               _collectionSettings.ReadPreference = new ReadPreference(ReadPreferenceMode.PrimaryPreferred);

        }

        /// <summary>
        /// 获取某个表的文档集合
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <returns>文档集合</returns>
        public MongoCollection<BsonDocument> Collection(string tableName)
        {
            return Database.GetCollection(tableName, _collectionSettings);
        }

        /// <summary>
        /// 获取某个表的文档集合
        /// </summary>
        /// <param name="mongoDtoType">dto类型</param>
        /// <returns>文档集合</returns>
        public MongoCollection<BsonDocument> Collection(Type mongoDtoType)
        {
            var tableAttribute = mongoDtoType.GetCustomAttribute<TableAttribute>();
            var tableName = tableAttribute?.Name ?? mongoDtoType.Name;
            return Collection(tableName);
        }

        /// <summary>
        /// 返回查询结果
        /// </summary>
        /// <param name="filter"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public List<T> Find<T>(Expression<Func<T, bool>> filter) where T : class, new()
        {
            return _database.GetCollection<T>(GetTableName(typeof(T)), _collectionSettings).Find(filter).ToList();
        }

        /// <summary>
        /// 返回单个查询结果
        /// </summary>
        /// <param name="filter"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T FirstOrDefault<T>(Expression<Func<T, bool>> filter) where T : class, new()
        {
            return _database.GetCollection<T>(GetTableName(typeof(T)), _collectionSettings).Find(filter)
                .FirstOrDefault();
        }

        /// <summary>
        /// 根据条件进行计数
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="where"></param>
        /// <returns></returns>
        public long Count<T>(Expression<Func<T, bool>> where) where T : class, new()
        {
            if (where == null)
                throw new ArgumentNullException(nameof(where));
            var theCollection = _database.GetCollection<T>(GetTableName(typeof(T)), _collectionSettings);
            return theCollection.CountDocuments(where);
        }

        /// <summary>
        /// 返回查询对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public IQueryable<T> GetQueryable<T>() where T : class, new()
        {
            return _database.GetCollection<T>(GetTableName(typeof(T)), _collectionSettings).AsQueryable();
        }

        /// <summary>
        /// 添加一个实体，要求存在实体类型到数据库表的映射
        /// </summary>
        /// <param name="entity"></param>
        public void Add<T>(T entity) where T : class
        {
            _database.GetCollection<T>(GetTableName(typeof(T)), _collectionSettings).InsertOne(entity);
        }

        /// <summary>
        /// 添加多个同类型的实体
        /// </summary>
        /// <param name="entities"></param>
        public void AddRange<T>(IEnumerable<T> entities) where T : class, new()
        {
            _database.GetCollection<T>(GetTableName(typeof(T)), _collectionSettings).InsertMany(entities);
        }

        /// <summary>
        /// 根据条件删除数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="where"></param>
        /// <returns></returns>
        public long Delete<T>(Expression<Func<T, bool>> where) where T : class, new()
        {
            if (where == null)
                throw new ArgumentNullException(nameof(where));

            var deleteWhere = TranslateWhere(where);

            var theCollection = _database.GetCollection<T>(GetTableName(typeof(T)), _collectionSettings);
            var result = theCollection.DeleteMany(deleteWhere);

            return result.DeletedCount;
        }

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public long Delete<T>(T entity) where T : class, new()
        {
            return _database.GetCollection<T>(GetTableName(typeof(T)), _collectionSettings)
                .DeleteOne(GetJsonFilterDefintion(entity)).DeletedCount;
        }

        /// <summary>
        /// 根据条件更新
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="update"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public long Update<T>(Expression<Func<T>> update, Expression<Func<T, bool>> where) where T : class, new()
        {
            if (null == update)
                return 0;

            if (where == null)
                throw new ArgumentNullException(nameof(where));

            var updateWhere = TranslateWhere(where);
            var updateSet = TranslateUpdate(update);

            var theCollection = _database.GetCollection<T>(GetTableName(typeof(T)), _collectionSettings);
            var result = theCollection.UpdateMany(updateWhere, updateSet);

            return result.ModifiedCount;
        }

        /// <summary>
        /// 更新一个实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public long Update<T>(T entity)
        {
            if (null == entity)
                return 0;

            var collection = _database.GetCollection<T>(GetTableName(typeof(T)), _collectionSettings);

            var filter = GetJsonFilterDefintion(entity);

            if (entity is MongoDbBasePo basePo)
                basePo.UtcModifyTime = DateTime.UtcNow;

            var versionPo = entity as MongoDbVersionPo;
            if (versionPo != null)
                versionPo.DataVersion++;

            var result = collection.UpdateOne(filter,
                new BsonDocumentUpdateDefinition<T>(new BsonDocument { { "$set", entity.ToBsonDocument() } }));

            if (result.ModifiedCount == 0 && versionPo != null)
                versionPo.DataVersion--;

            return result.ModifiedCount;
        }

        /// <summary>
        /// 组装Json Filter Defintion
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns>返回id：value</returns>
        private static JsonFilterDefinition<T> GetJsonFilterDefintion<T>(T entity)
        {
            var propertyInfo = entity.GetType().GetProperty("Id");
            if (propertyInfo == null) throw new NullReferenceException("主键名必须为Id。");

            var value = propertyInfo.GetValue(entity, null);
            var idDefinition = $"\"_id\":{ValueJson(value, propertyInfo.PropertyType)}";

            var versionDefinition = entity is MongoDbVersionPo versionPo && versionPo.DataVersion != 0 ? $",\"DataVersion\":{versionPo.DataVersion}" : null;

            return new JsonFilterDefinition<T>($"{{{idDefinition}{versionDefinition}}}");
        }

        /// <summary>
        /// 获取值的Json内容
        /// </summary>
        /// <param name="value"></param>
        /// <param name="valueType"></param>
        /// <returns></returns>
        private static string ValueJson(object value, Type valueType)
        {
            if (IsDigitType(valueType))
                return value.ToString();
            else if (valueType == typeof(Guid))
                return $"BinData(3,\"{Convert.ToBase64String(((Guid)value).ToByteArray())}\")";
            else
                return $"\"{value}\"";
        }

        /// <summary>
        /// 是否是整数类型
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private static bool IsDigitType(Type type)
        {
            return type == Types.Int32 || type == Types.Int64 ||
                          type == Types.Int16 || type == Types.UInt32;
        }

        /// <summary>
        /// 翻译Where部分的Lambda表达式。得到独立的Where部分，用来拼装带Where的删除和更新。
        /// </summary>
        /// <typeparam name="T">使用条件的类型参数。</typeparam>
        /// <param name="where">Where条件表达式。</param>
        /// <returns>翻译结果。</returns>
        private BsonDocument TranslateWhere<T>(Expression<Func<T, bool>> where) where T : class, new()
        {
            BsonDocument theWhereDocument;
            var collection = _database.GetCollection<T>(GetTableName(typeof(T))) as MongoCollection<T>;

            try
            {
                var theQurePv = new MongoQueryProvider(collection);

                var queryWhere = collection.AsQueryable().Where(where);
                var mongoQuery = queryWhere;

                var translatedQuery = MongoQueryTranslator.Translate(theQurePv, mongoQuery?.Expression);
                var selectQuery = translatedQuery as SelectQuery;
                theWhereDocument = selectQuery?.BuildQuery().ToBsonDocument();
            }
            catch (Exception ex)
            {
                throw new Exception("where条件未能正确解析", ex);
            }

            return theWhereDocument;
        }

        /// <summary>
        /// 翻译Update部分的Lambda表达式。得到要更新的属性或字段。
        /// </summary>
        /// <typeparam name="T">使用条件的类型参数。</typeparam>
        /// <param name="update">Update表达式。</param>
        /// <returns>翻译结果。</returns>
        private static BsonDocument TranslateUpdate<T>(Expression<Func<T>> update) where T : new()
        {
            if (update.NodeType != ExpressionType.Lambda) throw new Exception("参数Update不是正确的Lambda表达式");
            var updatebody = update.Body as MemberInitExpression;
            var analysiser = new InitExpresPropAnalysiser();
            var updatedPropList = analysiser.Analysiser(updatebody);

            var mongoUpdate = new UpdateBuilder();
            foreach (var membVal in updatedPropList)
                mongoUpdate.SetWrapped(membVal.MemberRoute, membVal.Value);

            return mongoUpdate.ToBsonDocument();
        }
    }
}
