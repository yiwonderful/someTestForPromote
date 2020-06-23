using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class BaseEntity
    {
        [BsonId]
        [BsonIgnore]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _Id { get; set; }

        /// <summary>
        /// 主键
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime PubTime { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// 是否审核
        /// </summary>
        public bool isChecked { get; set; }

        /// <summary>
        /// 微信用户OpenId
        /// </summary>
        public string OpenId { get; set; }
    }
}
