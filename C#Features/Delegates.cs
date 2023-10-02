using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures
{
    public class Delegates
    {
        public delegate void SendNotification(string email);

        public void DoAction(SendNotification callback)
        {
            callback("someone");
        }
    }

    public class Action
    {
        public Action()
        {
            Delegates obj = new Delegates();
            obj.DoAction((email) =>
            {
                // send notification
            });
        }
        
    }
}
