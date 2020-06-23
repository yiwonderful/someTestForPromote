using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Jingqu:BaseEntity
    {
        //[Display(Name = "景区名称*")]
        //[Required(ErrorMessage = "景区名称必填！", AllowEmptyStrings = false)]
        //[StringLength(50, ErrorMessage = "景区名称长度不能超过50个字符")]
        public string Name { get; set; }

        //[Display(Name = "景区介绍*")]
        //[Required(ErrorMessage = "景区介绍必填！", AllowEmptyStrings = false)]
        //[StringLength(3000, ErrorMessage = "景区介绍长度不能超过3000个字符")]
        public string Description { set; get; }

        //[Display(Name = "景区介绍图")]
        //[Required(ErrorMessage = "景区介绍图路径必填！", AllowEmptyStrings = false)]
        public string IntroducePicUrl { set; get; }

        //[Display(Name = "照片集合")]
        //public string[] UrlList { set; get; }


        //[Display(Name = "外部链接图*")]
        //[Required(ErrorMessage = "外部链接图片路径", AllowEmptyStrings = false)]
        public string LinkPicUrl { set; get; }
        /// <summary>
        /// 去过的人数
        /// </summary>
        public int Visited { get; set; }

        /// <summary>
        /// 想去的人数
        /// </summary>
        public int Expected { get; set; }

        //[Display(Name = "门票信息*")]
        //[Required(ErrorMessage = "门票信息必填！", AllowEmptyStrings = false)]
        public string Ticket { get; set; }

        /// <summary>
        /// 售票网点
        /// </summary>
        //[Display(Name = "售票网点")]
        //[DataType(DataType.Url, ErrorMessage = "请输入正确格式的网址")]
        public string TicketPath { set; get; }

        //[Display(Name = "景区地址*")]
        //[Required(ErrorMessage = "景区地址必填！", AllowEmptyStrings = false)]
        public string Address { get; set; }

        //[Display(Name = "交通路线说明*")]
        //[Required(ErrorMessage = "交通路线信息必填！", AllowEmptyStrings = false)]
        public string Traffic { get; set; }

        //[Display(Name = "纬度*")]
        //[Required(ErrorMessage = "纬度必填！", AllowEmptyStrings = false)]
        //[DataType(DataType.Currency, ErrorMessage = "纬度必须是数字！")]
        public double Lat { set; get; }

        //[Display(Name = "经度*")]
        //[Required(ErrorMessage = "经度必填！", AllowEmptyStrings = false)]
        //[DataType(DataType.Currency, ErrorMessage = "经度必须是数字！")]
        public double Lnt { set; get; }

        /// <summary>
        /// 全景的角度
        /// </summary>
        public double Angle { set; get; }

        //[Display(Name = "景区服务电话")]
        //[DataType(DataType.PhoneNumber, ErrorMessage = "电话格式不正确")]
        public string Tel { get; set; }

        /// <summary>
        /// 是否有实时的人数
        /// </summary>
        //[Display(Name = "显示景区实况*")]
        public bool IsRealtimeRS { set; get; }
        //[Display(Name = "景区类型")]
        public string LabelId { set; get; }

        /// <summary>
        /// 排序号
        /// </summary>
        public int OrderIndex { set; get; }

        /// <summary>
        /// 舒适等级（实时）
        /// </summary>
        public string CmfLevel { set; get; }
        /// <summary>
        /// 停车位数量（实时）
        /// </summary>
        public int CarPort { set; get; }

        /// <summary>
        /// 实时在园人数
        /// </summary>
        //[Display(Name = "实时在园人数")]
        public int ActualRs { set; get; }
        /// <summary>
        /// 当天实时人数数据
        /// </summary>
        public string ActualRsToday { set; get; }
        /// <summary>
        /// 昨天人数数据
        /// </summary>

        public string ActualRsYesterday { set; get; }

        //[Display(Name = "最大容纳人数*")]
        public int LimitRs { set; get; }

        /// <summary>
        /// 热力图地址
        /// </summary>
        //[Display(Name = "热力图地址")]
        public string HotGraphPath { set; get; }

        //[Display(Name = "景区级别")]
        public string Level { set; get; }
        //[Display(Name = "是否推荐")]
        public bool IsRecommend { set; get; }

        //[Display(Name = "开放时间说明*")]
        //[Required(ErrorMessage = "请填写均价", AllowEmptyStrings = false)]
        public string OpenCloseRemark { set; get; }

        //[Display(Name = "自驾说明")]
        public string SelfDrivingRemark { set; get; }
        //[Display(Name = "停车说明")]
        public string ParkingRemark { set; get; }

        //[Display(Name = "均价*")]
        //[Required(ErrorMessage = "请填写均价", AllowEmptyStrings = false)]
        //[DataType(DataType.Currency, ErrorMessage = "请填写正确的均价")]
        public decimal AvgPrice { set; get; }



        //[Display(Name = "关键字")]
        /// <summary>
        /// 关键字
        /// </summary>
        public string keyWords { get; set; }
        /// <summary>
        /// 评论数
        /// </summary>
        public int JudgeCount { set; get; }


        public float Star { set; get; }
        public float ZhanPin { set; get; }
        public float Huanjing { set; get; }
        public float Fuwu { set; get; }

        #region
        /// <summary>
        /// 标记的用户
        /// </summary>
        //public UserCheck MarkUser { set; get; }

        //public Judgement[] JudgeList { set; get; }
        /// <summary>
        /// 实况图
        /// </summary>
        public string SktPic { set; get; }
        /// <summary>
        /// 实况人数
        /// </summary>
        public string SkRs { set; get; }

        public string[] AllIntrPics { set; get; }

        /// <summary>
        /// 采集数据id
        /// </summary>
        public string SID { set; get; }
        #endregion
    }
}
