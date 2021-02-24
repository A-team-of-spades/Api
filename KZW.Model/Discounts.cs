using System;
using System.Collections.Generic;
using System.Text;

namespace KZW.Model
{
    /// <summary>
    /// 优惠券表
    /// </summary>
    public class Discounts
    {
        public int DisId { get; set; }            //优惠券ID	
        public string DisStartTime { get; set; }  //开始时间	
        public string DisEndTime { get; set; }    //结束时间	
        public string DisTitle { get; set; }      //标头显示	
        public double DisReach { get; set; }      //金额达到	
        public double DisMinus { get; set; }      //金额减去	
        public string DisNum { get; set; }        //优惠券编号
    }
}
