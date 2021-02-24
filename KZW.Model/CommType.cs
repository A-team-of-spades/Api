using System;
using System.Collections.Generic;
using System.Text;

namespace KZW.Model
{
    /// <summary>
    /// 商品类型表
    /// </summary>
    public class CommType
    {
        public int CtypeId { get; set; }         //类型ID	
        public string CtypeNum { get; set; }     //类型编号
        public string CtypeName { get; set; }    //类型名称
    }
}
