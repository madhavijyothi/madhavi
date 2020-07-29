using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
 public    class StudentEntity
    {
        public int SID { get; set; }
        public string fname{ get; set; }
        public string sname  { get; set; }
        public string Address { get; set; }
        public  string Email { get; set; }
        public string pincode { get; set; }
        public int  contact { get; set; }
        public string startdate { get; set; }
        public string enddate { get; set; }
        public string  Course { get; set; }
        public string teacher { get; set; }
        public string college { get; set; }
        public double  fees { get; set; }
        public string detail { get; set; }

        public string year { get; set; }
        public double  paid { get; set; }
        public double  remfee { get; set; }
    }
}
