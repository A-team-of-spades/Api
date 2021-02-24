using System;
using System.Collections.Generic;
using System.Text;

namespace KZW.Model
{
    /// <summary>
    /// 购物车表
    /// </summary>
    public class Shopping
    {
        public int ShopId { get; set; }         //购物车ID
        public string ShopTime { get; set; }    //添加时间
        public string CommNum { get; set; }     //商品编号
        public string UserNum { get; set; }     //用户编号
        public int ShopSum { get; set; }        //商品数量
    }
}
