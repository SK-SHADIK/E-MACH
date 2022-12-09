using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string PName { get; set; }
        public string Desc { get; set; }
        public float Price { get; set; }
        public int Qty { get; set; }
        public int UserId { get; set; }
    }
}
