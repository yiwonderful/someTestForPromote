using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Judgement:BaseEntity
    {
        /// <summary>
        /// 评论用户名称
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 头像url
        /// </summary>
        public string IconUrl { set; get; }
        /// <summary>
        /// 评论对象（具体景点）
        /// </summary>
        public string JudgeTargetId { get; set; }

        /// <summary>
        /// 评论时间
        /// </summary>
        //[MongoDB.Bson.Serialization.Attributes.BsonDateTimeOptions(Kind = System.DateTimeKind.Local)]
        public System.DateTime JudgeTime { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 引用图片数组
        /// </summary>
        public string[] PicUrls { get; set; }
        /// <summary>
        /// 来源信息
        /// </summary>
        public string OriginInfo { set; get; }

        /// <summary>
        /// 采集数据id
        /// </summary>
        public string SID { set; get; }
        /// <summary>
        /// 星评
        /// </summary>
        public float Star { get; set; }


        /// <summary>
        /// 经度
        /// </summary>
        public double Lon { get; set; }
        /// <summary>
        /// 纬度
        /// </summary>
        public double Lat { get; set; }

        //#region 连接查询
        //public Jingqu Jingqu { get; set; }
        //#endregion
    }
}
