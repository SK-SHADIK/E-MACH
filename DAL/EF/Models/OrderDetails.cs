using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public int OId { get; set; }
        public int PId { get; set; }
        public int PQty { get; set; }
        public string Tprice { get; set; }
        public string UName { get; set; }
        public string PName { get; set; }
        public string Status { get; set; }
    }
}
