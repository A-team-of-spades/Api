using System;
using System.Collections.Generic;
using System.Text;
using KZW.IPort;
using KZW.Model;
using KZW.DAL;

namespace KZW.BLL
{
    public class MemberBLL : IMember
    {
        //MemberDAL md = new MemberDAL();
        //实例化简单工厂模式
        Simple_Factory<MemberDAL> _dal = new Simple_Factory<MemberDAL>();

        
    }
}
