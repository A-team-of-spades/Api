using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KZW.BLL
{
    public class Simple_Factory<T> where T:new()
    {
        //实现一个方法，根据字符串，返回不同的CRUD实例
        private static T _instance;
        public T CreateInstance()
        {
            if (_instance == null)
            {
                _instance = new T();
            }
            return _instance;
        }
    }
}
