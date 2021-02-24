using System;
using System.Collections.Generic;
using System.Text;

namespace KZW.Model
{
    /// <summary>
    /// 地址表
    /// </summary>
    public class Area
    {
        public int AreaId { get; set; }       //地址Id
        public int PId { get; set; }          //父ID
        public string AreaName { get; set; }  //地址名
    }
}
