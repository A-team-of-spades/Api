using System;
using System.Collections.Generic;
using System.Text;
using KZW.IPort;
using KZW.Model;
using Purchase_Sell_Stock.DAL.GetDBHelper;

namespace KZW.DAL
{
    public class MemberDAL : IMember
    {
        DapperDBHelper dapper = new DapperDBHelper();
        public List<Userinfo> Show()
        {
            string sql = $"select * from Userinfo";
            return dapper.GetList<Userinfo>(sql);
        }
    }
}
