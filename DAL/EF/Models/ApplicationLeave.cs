using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class ApplicationLeave
    {
        public int Id { get; set; }
        [Required]
        public string Reason { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public System.DateTime From { get; set; }
        [Required]
        public System.DateTime To { get; set; }
        public string Status { get; set; }
    }
}
