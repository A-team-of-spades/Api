using System;
using System.Data.SqlClient;
using KZW.IPort;
using KZW.Model;
using KZW.DAL;

namespace KZW.BLL
{
    public class ShoppingBLL:IShopping
    {
        //实例化简单工厂模式
        Simple_Factory<ShoppingDAL> _dal = new Simple_Factory<ShoppingDAL>();
    }
}
