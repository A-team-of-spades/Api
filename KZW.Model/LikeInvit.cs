using System;
using System.Collections.Generic;
using System.Text;

namespace KZW.Model
{
    /// <summary>
    /// 帖子喜欢表
    /// </summary>
    public class LikeInvit
    {
        public int LikeId { get; set; }       //帖子ID	
        public string InvitNum { get; set; }  //帖子编号
        public string UserNum { get; set; }   //用户编号
    }
}
