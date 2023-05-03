using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_WebAPI.Design_Patterns
{
    internal sealed class Singleton
    {
        private static Singleton _instance;
        private static readonly object _lockObject = new object();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                lock (_lockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }

                    return _instance;
                }
            }
        }

        public object Cache()
        {
            return new
            {
                data = "Cached data"
            };
        }
    }
}
