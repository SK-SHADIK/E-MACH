using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AddToCartDTO
    {
        public int Id { get; set; }
        public int PId { get; set; }
        public int PQty { get; set; }
        public string Tprice { get; set; }
        public string UName { get; set; }
        public string PName { get; set; }
    }
}
