using System;
using System.Collections.Generic;
using System.Text;
using KZW.IPort;
using KZW.Model;
using KZW.DAL.DB;

namespace KZW.DAL
{
    public class ShoppingDAL : IShopping
    {
        DapperDBHelper db = new DapperDBHelper();
        /// <summary>
        /// 获取购物车商品
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public List<SelAll> GetShopping(string num)
        {
            string sql = $"select * from Shopping a join  Commodity b on a.CommNum=b.CommNum where a.CommNum='{num}'";
            List<SelAll> list = db.GetList<SelAll>(sql);
            return list;
        }
        /// <summary>
        /// 获取商品上的图片
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public List<CommPic> GetPics(string num)
        {
            string sql = $"select * from CommPic where CommNum='{num}'";
            List<CommPic> list = db.GetList<CommPic>(sql);
            return list;
        }
        /// <summary>
        /// 初始化添加订单信息
        /// </summary>
        /// <param name="In"></param>
        /// <returns></returns>
        public int AddInform(Information In)
        {
            string sql = $"insert into Information values({In.InforId},'GETDATE()','{In.CommNum}','{In.UserNum}',3)";
            return db.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 修改订单状态
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public int EditInform(int type, int id)
        {
            string sql = $"update Information set InforType='{type}' where InforId={id}";
            return db.ExecuteNonQuery(sql);
        }
    }
}
