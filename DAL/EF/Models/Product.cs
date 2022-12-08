using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string PName { get; set; }
        [Required]
        public string Desc { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public int Qty { get; set; }
        public int UserId { get; set; }
    }
}
