using KZW.Model;
using System;
using System.Collections.Generic;
using System.Text;
using KZW.Model.New.lj;

namespace KZW.IPort
{
    public interface IGoods
    {
        //查询优惠券1
        List<Discounts> GetDiscounts1();
        //查询优惠券2
        List<Discounts> GetDiscounts2();
        //查询优惠券3
        List<Discounts> GetDiscounts3();
        //查询商品
        List<GoodsAllModel> GetGoods();
        //查询商品详情
        List<GoodsAllModel> GetGoodsDetails();
        //查询商品评价信息
        List<GoodsAllModel> GetGoodsEvaluate();
        //获取收获地址
        List<GoodsAllModel> GetAddress();
        //添加商品评价
        int AddGoodsEvaluate(GoodsAllModel good);
        //添加用户优惠券
        int AddUsersDis(UsersDis dis);
    }
}
