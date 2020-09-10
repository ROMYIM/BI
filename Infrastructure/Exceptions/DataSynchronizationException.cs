using MongoDB.Driver;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Infrastructure.Exceptions
{
    public class DataSynchronizationException : Exception
    {
        private static readonly Regex LineRegex = new Regex(@"[\d]+", RegexOptions.IgnoreCase);

        private readonly object _id;

        private readonly string _tableName;

        private string _message;

        public DataSynchronizationException(object id, string tableName, Exception ex) : base(default, ex)
        {
            _id = id;
            _tableName = tableName;
        }

        public DataSynchronizationException(IList<string> idRecords, string tableName, Exception ex) : base(default, ex)
        {
            _tableName = tableName;
            if (ex is PostgresException pe)
            {
                var index = -1;

                var where = pe.Data["Where"]?.ToString();
                if (where != null)
                {
                    var whereDetails = where.Split(',');
                    foreach (var detail in whereDetails)
                    {
                        if (detail.AsSpan().Contains("line".AsSpan(), StringComparison.OrdinalIgnoreCase))
                        {
                            var match = LineRegex.Match(detail);
                            index = Convert.ToInt32(match.Value) - 1;
                            break;
                        }

                    }
                }
                else if (pe.Data["Line"] != null)
                {
                    index = Convert.ToInt32(pe.Data["Line"]);
                }

                _id = idRecords[index];
            }
        }

        public override string Message => _message ??= BuildeErrorMessage();

        public override string StackTrace => InnerException.StackTrace;

        protected virtual string BuildeErrorMessage()
        {
            var msgBuilder = new StringBuilder();
            msgBuilder.AppendLine(InnerException.Message);

            if (InnerException is NpgsqlException ne)
            {
                msgBuilder.Append("pg ");
                msgBuilder.Append("table:").Append(_tableName).Append(" ");
                msgBuilder.Append("id:").Append(_id).Append(" ");
                msgBuilder.Append("field:").Append(ne.Data["Where"]).Append(" ");
                msgBuilder.Append("msg:").Append(ne.Message);
            }
            else if (InnerException is MongoException me)
            {
                msgBuilder.Append("mongo ");
                msgBuilder.Append("table:").Append(_tableName).Append(" ");
                msgBuilder.Append("id:").Append(_id).Append(" ");
                msgBuilder.Append("msg:").Append(me.Message);
            }
            else
            {
                msgBuilder.Append("table:").Append(_tableName).Append(" ");
                msgBuilder.Append("id:").Append(_id).Append(" ");
                msgBuilder.Append("msg:").Append(InnerException.Message);
            }

            return msgBuilder.ToString();
        }
    }
}
