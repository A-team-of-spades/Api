using System;
using System.Collections.Generic;
using System.Text;
using KZW.Model;

namespace KZW.IPort
{
    public interface IShopping
    {
        List<SelAll> GetShopping(string num);
        List<CommPic> GetPics(string num);
        int AddInform(Information In);
        int EditInform(int type, int id);
    }
}
