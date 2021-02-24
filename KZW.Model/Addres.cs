using System;
using System.Collections.Generic;
using System.Text;

namespace KZW.Model
{
    /// <summary>
    /// 收货地址表
    /// </summary>
    public class Addres
    {
        public int AddresId { get; set; }          //地址ID
        public string UserNum { get; set; }        //用户编号
        public string AddresDetail { get; set; }   //收货详细地址
        public int AddDefault { get; set; }        //是否默认
    }
}
