using System;
using System.Collections.Generic;
using System.Text;
using KZW.IPort;
using KZW.Model;
using KZW.DAL.DB;
using KZW.Model.New.lj;

namespace KZW.DAL
{
    public class GoodsDAL:IGoods
    {
        DapperDBHelper _db = new DapperDBHelper();

        //查询优惠券1
        public List<Discounts> GetDiscounts1()
        {
            string sql = "select * from Discounts where DisId=1";
            return _db.GetList<Discounts>(sql);
        }

        //查询优惠券2
        public List<Discounts> GetDiscounts2()
        {
            string sql = "select * from Discounts where DisId=2";
            return _db.GetList<Discounts>(sql);
        }

        //查询优惠券3
        public List<Discounts> GetDiscounts3()
        {
            string sql = "select * from Discounts where DisId=3";
            return _db.GetList<Discounts>(sql);
        }

        //查询商品
        public List<GoodsAllModel> GetGoods()
        {
            string sql = "select b.BrandName,a.CommName,a.CommSpeci,a.CommPrice,c.CpicPath " +
                "from Commodity a join Brand b on a.BrandNum = b.BrandNum join CommPic c on a.CommNum = c.CommNum";
            return _db.GetList<GoodsAllModel>(sql);
        }

        public List<GoodsAllModel> GetGoodsDetails()
        {
            string sql = "select b.BrandName,a.CommName,a.CommSpeci,a.CommPrice,a.CommSay,c.CpicPath " +
                "from Commodity a join Brand b on a.BrandNum = b.BrandNum join CommPic c on a.CommNum = c.CommNum";
            return _db.GetList<GoodsAllModel>(sql);
        }

        public List<GoodsAllModel> GetGoodsEvaluate()
        {
            string sql = "select b.UserName,a.EvaSay,a.EvaTime from Evaluate a join Userinfo b on a.UserNum=b.UserNum";
            return _db.GetList<GoodsAllModel>(sql);
        }

        public List<GoodsAllModel> GetAddress()
        {
            string sql = "select a.UserName,a.UserPhone,b.AddresDetail from Userinfo a join Addres b on a.UserNum=b.UserNum";
            return _db.GetList<GoodsAllModel>(sql);
        }

        public int AddGoodsEvaluate(GoodsAllModel good)
        {
            string sql = $"insert into Evaluate values('{good.EvaTime}','{good.EvaSay}','{good.CommNum}','{good.UserNum}','{good.EvaNum}')";
            return _db.ExecuteNonQuery(sql);
        }

        public int AddUsersDis(UsersDis dis)
        {
            string sql = $"insert into Discounts values('{dis.UserNum}','{dis.DisNum}')";
            return _db.ExecuteNonQuery(sql);
        }
    }
}
