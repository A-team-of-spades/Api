using System;
using System.Collections.Generic;
using System.Text;
using KZW.IPort;
using KZW.Model;
using KZW.DAL;
using KZW.Model.New.lj;

namespace KZW.BLL
{
    public class GoodsBLL:IGoods
    {
        //实例化简单工厂模式
        Simple_Factory<GoodsDAL> _factory = new Simple_Factory<GoodsDAL>();

        public List<Discounts> GetDiscounts1()
        {
            return _factory.CreateInstance().GetDiscounts1();
        }

        public List<Discounts> GetDiscounts2()
        {
            return _factory.CreateInstance().GetDiscounts2();
        }

        public List<Discounts> GetDiscounts3()
        {
            return _factory.CreateInstance().GetDiscounts3();
        }

        public List<GoodsAllModel> GetGoods()
        {
            return _factory.CreateInstance().GetGoods();
        }

        public List<GoodsAllModel> GetGoodsDetails()
        {
            return _factory.CreateInstance().GetGoodsDetails();
        }

        public List<GoodsAllModel> GetGoodsEvaluate()
        {
            return _factory.CreateInstance().GetGoodsEvaluate();
        }

        public List<GoodsAllModel> GetAddress()
        {
            return _factory.CreateInstance().GetAddress();
        }

        public int AddGoodsEvaluate(GoodsAllModel good)
        {
            return _factory.CreateInstance().AddGoodsEvaluate(good);
        }

        public int AddUsersDis(UsersDis dis)
        {
            return _factory.CreateInstance().AddUsersDis(dis);
        }
    }
}
