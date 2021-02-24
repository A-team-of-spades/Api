using System;
using System.Collections.Generic;
using System.Text;

namespace KZW.Model
{
    /// <summary>
    /// 品牌馆表
    /// </summary>
    public class Brand
    {
        public int BrandId { get; set; }        //品牌ID	
        public string BrandNum { get; set; }    //品牌编号
        public string BrandName { get; set; }   //品牌名称
        public string BrandSay { get; set; }    //品牌简介
    }
}
