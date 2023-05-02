using ProjectDal.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBll.DesignPatterns.SingletonPattern
{
    public class DBTool
    {
        DBTool() { }
        static MyContext _dbInstance;
        public static MyContext DbInstance
        {
            get
            {
                if (_dbInstance == null) _dbInstance = new MyContext();
                return _dbInstance;
            }
        }
    }
}
