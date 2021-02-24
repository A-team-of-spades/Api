using System;
using System.Collections.Generic;
using System.Text;

namespace KZW.Model
{
    /// <summary>
    /// 商品评价表
    /// </summary>
    public class Evaluate
    {
        public int EvaId { get; set; }          //评价ID		
        public string EvaTime { get; set; }     //评价时间	
        public string EvaSay { get; set; }      //评价内容	
        public string CommNum { get; set; }     //评价商品编号
        public string UserNum { get; set; }     //评价人编号	
        public string EvaNum { get; set; }      //评价编号
    }
}
