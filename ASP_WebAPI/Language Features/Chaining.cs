using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_WebAPI.Language_Features
{
    internal class Chaining
    {
        public List<string> list = new List<string>();

        public Chaining AddName()
        {
            list.Add("Rudra");
            return this;
        }

        public Chaining AddAge()
        {
            list.Add("22");
            return this;
        }
    }
}
