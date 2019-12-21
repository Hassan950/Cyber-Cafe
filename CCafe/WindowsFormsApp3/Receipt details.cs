using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCafe
{
    public class Receipt_details
    {
        public string employeeid { get; set; }
        public string date { get; set; }
        public string room_no { get; set; }
        public string gamename { get; set; }
        public string customerid { get; set; }
        public string starttime { get; set; }
        public string endtime { get; set; }
        public string TimeSpent { get; set; }
        public string MoneyPerHour { get; set; }
        public string Tax { get; set; }
        public string Discount { get; set; }
        public string TotalMoney { get; set; }
    }
}
