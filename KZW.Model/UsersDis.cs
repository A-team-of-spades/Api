using System;
using System.Collections.Generic;
using System.Text;

namespace KZW.Model
{
    /// <summary>
    /// 用户优惠券表
    /// </summary>
    public class UsersDis
    {
        public int UdisId { get; set; }       //用户优惠ID
        public string UserNum { get; set; }   //用户编号	
        public string DisNum { get; set; }    //优惠券编号
    }
}
