using System;
using System.Collections.Generic;
using System.Text;

namespace KZW.Model
{
    public class SelAll
    {
        public int ShopId { get; set; }         //购物车ID
        public string ShopTime { get; set; }    //添加时间
        public string CommNum { get; set; }     //商品编号
        public string UserNum { get; set; }     //用户编号
        public int ShopSum { get; set; }        //商品数量
        public int CommId { get; set; }          //商品ID	
        public string CommName { get; set; }     //商品名称	
        public string CommSay { get; set; }      //商品简介	
        public double CommPrice { get; set; }    //商品单价	
        public string BrandNum { get; set; }     //品牌	
        public string CommTime { get; set; }     //商品上架时间
        public int CommClick { get; set; }       //点击量
        public string CommSpeci { get; set; }    //规格
        public string CpicPath { get; set; }   //图片路径
    }
}
