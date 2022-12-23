using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Question
    {
        public int Id { get; set; }
        [Required]
        public string Ques { get; set; }
    }
}
