using System;
using System.Collections.Generic;
using System.Text;

namespace KZW.Model
{
    /// <summary>
    /// 商品类型关系表
    /// </summary>
    public class CommTypeInfo
    {
        public int CinfoId { get; set; }       //关系ID	
        public string CtypeNum { get; set; }   //类型编号
        public string CommNum { get; set; }    //商品编号
    }
}
