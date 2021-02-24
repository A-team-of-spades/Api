using System;
using System.Collections.Generic;
using System.Text;

namespace KZW.Model
{
    /// <summary>
    /// 商品收藏表
    /// </summary>
    public class Collect
    {
        public int CollectId { get; set; }     //收藏ID	
        public string UserNum { get; set; }    //用户编号
        public string CommNum { get; set; }    //商品编号
    }
}
