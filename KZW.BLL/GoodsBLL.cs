using System;
using System.Collections.Generic;
using System.Text;
using KZW.IPort;
using KZW.Model;
using KZW.DAL;

namespace KZW.BLL
{
    public class GoodsBLL:IGoods
    {
        //实例化简单工厂模式
        Simple_Factory<GoodsDAL> _dal = new Simple_Factory<GoodsDAL>();
    }
}
