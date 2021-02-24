using System;
using System.Collections.Generic;
using System.Text;
using KZW.IPort;
using KZW.Model;
using KZW.DAL;

namespace KZW.BLL
{
    public class PersonageBLL:IPersonage
    {
        //实例化简单工厂模式
        Simple_Factory<PersonageDAL> _dal = new Simple_Factory<PersonageDAL>();
    }
}
