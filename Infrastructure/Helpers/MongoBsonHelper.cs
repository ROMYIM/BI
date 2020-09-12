using Core.Extensions.Encode;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Infrastructure.Helpers
{
    public static class MongoBsonHelper
    {
        /// <summary>
        /// BsonValue类型转换
        /// </summary>
        /// <param name="element">文档节点</param>
        /// <param name="valueType">pg表实体属性的类型</param>
        /// <returns>文档节点值转换pg表实体对应属性类型的值</returns>
        public static object GetValue(this BsonElement element, Type valueType)
        {
            if (valueType == null) return null;
            if (element.Value.IsBsonNull) return null;

            var bsonValue = element.Value;
            object tempValue = null;

            if ((bsonValue.IsBsonArray || bsonValue.IsBsonDocument) && bsonValue.IsString)
                return bsonValue.ToJson();

            switch (bsonValue.BsonType)
            {
                case BsonType.EndOfDocument:
                    break;
                case BsonType.Binary:
                    if (element.Name == "_id")
                        return bsonValue.AsGuid.ToString();
                    break;
                case BsonType.Undefined:
                    break;
                case BsonType.RegularExpression:
                    break;
                case BsonType.JavaScript:
                    break;
                case BsonType.Symbol:
                    break;
                case BsonType.JavaScriptWithScope:
                    break;
                case BsonType.MinKey:
                    break;
                case BsonType.MaxKey:
                    break;
                case BsonType.Null:
                    break;

                case BsonType.Document:
                    break;


                case BsonType.Double:
                    tempValue = bsonValue.AsDouble;
                    if (valueType.IsNullableType(tempValue.GetType())) 
                        return bsonValue.AsNullableDouble;
                    break;

                case BsonType.String:
                    tempValue = bsonValue.AsString.ToUTF8();
                    break;

                case BsonType.Array:
                    tempValue = bsonValue.ToJson();
                    break;

                case BsonType.ObjectId:
                    tempValue = bsonValue.AsString;
                    break;

                case BsonType.Boolean:
                    tempValue = bsonValue.AsBoolean;
                    if (valueType.IsNullableType(tempValue.GetType()))
                        return bsonValue.AsNullableBoolean;
                    break;

                case BsonType.DateTime:
                    tempValue = bsonValue.ToLocalTime();
                    if (valueType.IsNullableType(tempValue.GetType()))
                        return bsonValue.ToNullableLocalTime();
                    break;
                
                case BsonType.Int32:
                    tempValue = bsonValue.AsInt32;
                    if (valueType.IsNullableType(tempValue.GetType()))
                        return bsonValue.AsNullableInt32;
                    break;
                    
                case BsonType.Timestamp:
                    tempValue = bsonValue.ToLocalTime();
                    if (valueType.IsNullableType(tempValue.GetType()))
                        return bsonValue.ToNullableLocalTime();
                    break;

                case BsonType.Int64:
                    tempValue = bsonValue.AsInt64;
                    if (valueType.IsNullableType(tempValue.GetType()))
                        return bsonValue.AsNullableInt64;
                    break;

                case BsonType.Decimal128:
                    tempValue = bsonValue.AsDecimal;
                    if (valueType.IsNullableType(tempValue.GetType()))
                        return bsonValue.AsNullableDecimal;
                    break;
                
                default:
                    break;
            }

            if (tempValue == null 
                || tempValue.GetType() == valueType
                || valueType.IsNullableType(tempValue.GetType())) 
                return tempValue;

            if (tempValue.GetType() != valueType 
                ) 
                tempValue =  Convert.ChangeType(tempValue, valueType);
            return tempValue;

            //if (valueType == typeof(int)) return bsonValue.AsInt32;
            //if (valueType == typeof(int?)) return bsonValue.AsNullableInt32;

            //if (valueType == typeof(long)) return bsonValue.AsInt64;
            //if (valueType == typeof(long?)) return bsonValue.AsNullableInt64;

            //if (valueType == typeof(bool)) return bsonValue.AsBoolean;
            //if (valueType == typeof(bool?)) return bsonValue.AsNullableBoolean;

            //if (valueType == typeof(string) && bsonValue.IsString) return bsonValue.AsString;

            //if (valueType == typeof(DateTime)) return bsonValue.ToLocalTime();
            //if (valueType == typeof(DateTime?)) return bsonValue.ToNullableLocalTime();

            //if (valueType == typeof(double)) return bsonValue.AsDouble;
            //if (valueType == typeof(double?)) return bsonValue.AsNullableDouble;


        }

        public static T As<T>(this BsonValue bsonValue)
        {
            if (bsonValue == null) return default;

            var valueType = typeof(T);
            object tempValue = null;
            NullableConverter converter;
            switch (bsonValue.BsonType)
            {
                case BsonType.Double:
                    tempValue = bsonValue.AsDouble;
                    if (valueType.IsNullableType(typeof(double)))
                        tempValue = bsonValue.AsNullableDouble;
                    else if (valueType.IsNullableType(typeof(float)))
                    {
                        converter = new NullableConverter(typeof(float));
                        tempValue = converter.ConvertTo(tempValue, valueType);
                    }
                    else if (valueType.IsNullableType(typeof(long)))
                    {
                        converter = new NullableConverter(typeof(long));
                        tempValue = converter.ConvertTo(tempValue, valueType);
                    }
                    else if (valueType.IsNullableType(typeof(int)))
                    {
                        converter = new NullableConverter(typeof(int));
                        tempValue = converter.ConvertTo(tempValue, valueType);
                    }
                    break;

                case BsonType.String:
                    tempValue = bsonValue.AsString.ToUTF8();
                    break;

                case BsonType.ObjectId:
                    tempValue = bsonValue.AsString;
                    break;

                case BsonType.Boolean:
                    tempValue = bsonValue.AsBoolean;
                    if (valueType.IsNullableType(tempValue.GetType()))
                        tempValue = bsonValue.AsNullableBoolean;
                    break;

                case BsonType.DateTime:
                    tempValue = bsonValue.ToLocalTime();
                    if (valueType.IsNullableType(tempValue.GetType()))
                        tempValue = bsonValue.ToNullableLocalTime();
                    break;

                case BsonType.Int32:
                    tempValue = bsonValue.AsInt32;
                    if (valueType.IsNullableType(tempValue.GetType()))
                        tempValue = bsonValue.AsNullableInt32;
                    break;

                case BsonType.Timestamp:
                    tempValue = bsonValue.ToLocalTime();
                    if (valueType.IsNullableType(tempValue.GetType()))
                        tempValue = bsonValue.ToNullableLocalTime();
                    break;

                case BsonType.Int64:
                    tempValue = bsonValue.AsInt64;
                    if (valueType.IsNullableType(tempValue.GetType()))
                        tempValue = bsonValue.AsNullableInt64;
                    else if (valueType.IsNullableType(typeof(int)))
                    {
                        converter = new NullableConverter(typeof(int));
                        tempValue = converter.ConvertTo(tempValue, valueType);
                    }
                    break;

                case BsonType.Decimal128:
                    tempValue = bsonValue.AsDecimal;
                    if (valueType.IsNullableType(tempValue.GetType()))
                        tempValue = bsonValue.AsNullableDecimal;
                    break;
                default:
                    break;
            }

            return (T)Convert.ChangeType(tempValue, valueType);
        }

        /// <summary>
        /// 判断目标类型是否是指定类型的可空类型。
        /// 如果指定类型类型为空，则只判断目标类型是否是可空类型<see cref="Nullable{T}"/>
        /// </summary>
        /// <param name="theType">目标类型</param>
        /// <param name="gengericTypeParameter">指定类型</param>
        /// <returns></returns>
        public static bool IsNullableType(this Type theType, Type gengericTypeParameter = default)
        {
            if (theType.IsGenericType && theType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                if (gengericTypeParameter == default) return true;
                return theType.GetGenericArguments()[0] == gengericTypeParameter;
            }
            return false;
        }
    }
}
