using System;
using System.Collections.Generic;
using System.Text;

namespace KZW.Model
{
    /// <summary>
    /// 商品表
    /// </summary>
    public class Commodity
    {
        public int CommId { get; set; }          //商品ID	
        public string CommName { get; set; }     //商品名称	
        public string CommSay { get; set; }      //商品简介	
        public string CommNum { get; set; }      //商品编号	
        public double CommPrice { get; set; }    //商品单价	
        public string BrandNum { get; set; }     //品牌	
        public string CommTime { get; set; }     //商品上架时间
        public int CommClick { get; set; }       //点击量
        public string CommSpeci { get; set; }    //规格
    }
}
