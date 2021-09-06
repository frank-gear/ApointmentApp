using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Project
{
    public class UserClass
    {
       public int UsrId { get; set; } 
        public string UsrName { get; set; }
        public string Pass { get; set; }
        public int Act { get; set; }

        public UserClass()
        {
        }

        public UserClass(int usrId, string usrName, string pass, int act)
        {
            UsrId = usrId;
            UsrName = usrName;
            Pass = pass;
            Act = act;
        }
    }
}
