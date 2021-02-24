using System;
using System.Collections.Generic;
using System.Text;

namespace KZW.Model
{
    /// <summary>
    /// 商品图片表
    /// </summary>
    public class CommPic
    {
        public int CpicId { get; set; }        //类型ID	
        public string CpicPath { get; set; }   //图片路径
        public string CommNum { get; set; }    //商品编号
    }
}
