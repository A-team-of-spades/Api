using KZW.Model;
using System;
using System.Collections.Generic;
using System.Text;
using KZW.Model.New.lj;

namespace KZW.IPort
{
    public interface IGoods
    {
        //查询优惠券
        List<Discounts> GetDiscounts();
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
