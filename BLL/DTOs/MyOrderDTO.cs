using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class MyOrderDTO
    {
        public int Id { get; set; }
        public string OId { get; set; }
        public string UName { get; set; }
        public string TPrice { get; set; }
        public string PayType { get; set; }
        public string OStatus { get; set; }
    }
}
