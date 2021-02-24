using System;

namespace KZW.Model
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class Userinfo
    {
        public int UserId { get; set; }        //用户ID
        public string UserNum { get; set; }    //用户编号
        public string UserName { get; set; }   //用户名
        public string UserPhone { get; set; }  //用户手机号
        public string UserPwd { get; set; }    //用户密码
        public string UserPic { get; set; }    //用户头像
        public string UserCard { get; set; }   //身份证
        public string UserHome { get; set; }   //家乡
        public string UserSex { get; set; }    //性别
    }
}
