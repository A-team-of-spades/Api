using System;
using System.Collections.Generic;
using System.Text;

namespace KZW.Model
{
    /// <summary>
    /// 订单信息表
    /// </summary>
    public class Information
    {
        public int InforId { get; set; }         //订单信息ID
        public string InforTime { get; set; }    //添加时间	
        public string CommNum { get; set; }      //商品编号	
        public string UserNum { get; set; }      //用户编号	
        public int InforType { get; set; }       //订单状态
    }
}
