﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_WebAPI.OOPs
{
    /*
     * 1. OOP Support: 
     * 2. Can't be inherited till it has private constructors
     * 3. Can't be instantiated
     * 4. Can have static fields
     */
    internal class SingletonClass
    {
        private SingletonClass()
        {

        }

        private static SingletonClass _instance;

        public static SingletonClass Instance()
        {
            if (_instance == null)
            {
                _instance = new SingletonClass();
            }

            return _instance;
        }
    }
}
