using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Project
{
    public class AdminUserClass : UserClass
    {
        public AdminUserClass(int usrId, string usrName, string pass, int act) : base(usrId, usrName, pass, act)
        {
        }
    }
}
