using System;
using System.Collections.Generic;
using System.Text;

namespace KZW.Model
{
    /// <summary>
    /// 种草帖子表
    /// </summary>
    public class Invitation
    {
        public int InvitId { get; set; }        //帖子ID	
        public string InvitNum { get; set; }    //帖子编号
        public string UserNum { get; set; }     //用户编号
        public string InvitTitle { get; set; }  //帖子表头
        public string InvitSay { get; set; }    //帖子信息
        public string InvitTime { get; set; }   //帖子时间
        public int InvitClick { get; set; }     //点击量
    }
}
