using System;
using System.Data.SqlClient;
using KZW.IPort;
using KZW.Model;
using KZW.DAL;
using System.Collections.Generic;

namespace KZW.BLL
{
    public class ShoppingBLL:IShopping
    {
        //实例化简单工厂模式
        Simple_Factory<ShoppingDAL> _dal = new Simple_Factory<ShoppingDAL>();
        public int AddInform(Information In)
        {
            return _dal.CreateInstance().AddInform(In);
        }
        public List<SelAll> ChaShopping(string num, int id)
        {
            return _dal.CreateInstance().ChaShopping(num, id);
        }
        public int EditInform(int type, int id)
        {
            return _dal.CreateInstance().EditInform(type, id);
        }

        public int EditShopping(int sum, int id)
        {
            return _dal.CreateInstance().EditShopping(sum, id);
        }

        public List<Addres> GetAddres()
        {
            return _dal.CreateInstance().GetAddres();
        }

        public List<CommPic> GetPics(string num)
        {
            return _dal.CreateInstance().GetPics(num);
        }

        public List<SelAll> GetShopping(string num)
        {
            return _dal.CreateInstance().GetShopping(num);
        }

    }
}
