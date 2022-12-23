using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class LeaveApplicationDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Reason { get; set; }
        public System.DateTime From { get; set; }
        public System.DateTime Finish { get; set; }
    }
}
