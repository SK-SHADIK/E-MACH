using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ApplicationLeaveDTO
    {
        public int Id { get; set; }
        public string Reason { get; set; }
        public string Name { get; set; }
        public System.DateTime From { get; set; }
        public System.DateTime To { get; set; }
        public string Status { get; set; }
    }
}
