using System;
using System.Collections.Generic;
using System.Text;

namespace KZW.Model.New.lj
{
    public class GoodsAllModel
    {
        /// <summary>
        /// 收货地址表
        /// </summary>
        public int AddresId { get; set; }          //地址ID
        public string UserNum { get; set; }        //用户编号
        public string AddresDetail { get; set; }   //收货详细地址
        public int AddDefault { get; set; }        //是否默认

        /// <summary>
        /// 品牌表
        /// </summary>
        public int BrandId { get; set; }        //品牌ID	
        public string BrandNum { get; set; }    //品牌编号
        public string BrandName { get; set; }   //品牌名称
        public string BrandSay { get; set; }    //品牌简介

        /// <summary>
        /// 商品收藏表
        /// </summary>
        public int CollectId { get; set; }     //收藏ID	
        //public string UserNum { get; set; }    //用户编号
        public string CommNum { get; set; }    //商品编号

        /// <summary>
        /// 商品表
        /// </summary>
        public int CommId { get; set; }          //商品ID	
        public string CommName { get; set; }     //商品名称	
        public string CommSay { get; set; }      //商品简介	
        //public string CommNum { get; set; }      //商品编号	
        public double CommPrice { get; set; }    //商品单价	
       // public string BrandNum { get; set; }     //品牌	
        public string CommTime { get; set; }     //商品上架时间
        public int CommClick { get; set; }       //点击量
        public string CommSpeci { get; set; }    //规格

        /// <summary>
        /// 商品图片表
        /// </summary>
        public int CpicId { get; set; }        //类型ID	
        public string CpicPath { get; set; }   //图片路径
        //public string CommNum { get; set; }    //商品编号

        /// <summary>
        /// 商品类型表
        /// </summary>
        public int CtypeId { get; set; }         //类型ID	
        public string CtypeNum { get; set; }     //类型编号
        public string CtypeName { get; set; }    //类型名称

        /// <summary>
        /// 商品类型关系表
        /// </summary>
        public int CinfoId { get; set; }       //关系ID	
        //public string CtypeNum { get; set; }   //类型编号
        //public string CommNum { get; set; }    //商品编号

        /// <summary>
        /// 优惠券表
        /// </summary>
        public int DisId { get; set; }            //优惠券ID	
        public string DisStartTime { get; set; }  //开始时间	
        public string DisEndTime { get; set; }    //结束时间	
        public string DisTitle { get; set; }      //标头显示	
        public double DisReach { get; set; }      //金额达到	
        public double DisMinus { get; set; }      //金额减去	
        public string DisNum { get; set; }        //优惠券编号

        /// <summary>
        /// 商品评价表
        /// </summary>
        public int EvaId { get; set; }          //评价ID		
        public string EvaTime { get; set; }     //评价时间	
        public string EvaSay { get; set; }      //评价内容	
        //public string CommNum { get; set; }     //评价商品编号
        //public string UserNum { get; set; }     //评价人编号	
        public string EvaNum { get; set; }      //评价编号

        /// <summary>
        /// 订单信息表
        /// </summary>
        public int InforId { get; set; }         //订单信息ID
        public string InforTime { get; set; }    //添加时间	
        //public string CommNum { get; set; }      //商品编号	
        //public string UserNum { get; set; }      //用户编号	
        public int InforType { get; set; }       //订单状态

        /// <summary>
        /// 用户优惠券表
        /// </summary>
        public int UdisId { get; set; }       //用户优惠ID
        //public string UserNum { get; set; }   //用户编号	
        //public string DisNum { get; set; }    //优惠券编号
    }
}
