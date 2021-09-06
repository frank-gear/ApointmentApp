using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Project
{
    public  class AppointmentClass
    {
        public int AppId { get; set; }
        public string Titie { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public int UsrId { get; set; }
        public int CustId { get; set; }
        public string Type { get; set; }


        protected AppointmentClass(int appId, string titie, string start, string end, int usrId, int custId, string type)
        {
            AppId = appId;
            Titie = titie;
            this.Start = start;
            this.End = end;
            UsrId = usrId;
            CustId = custId;
            Type = type;
        }

        protected AppointmentClass()
        {
        }
    }
}
