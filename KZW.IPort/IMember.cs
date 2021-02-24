using System;
using System.Collections.Generic;
using System.Text;
using KZW.Model;

namespace KZW.IPort
{
    public interface IMember
    {
        List<Userinfo> Show();
    }
}
