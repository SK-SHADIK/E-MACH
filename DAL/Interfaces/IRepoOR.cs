using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepoOR<CLASS, ID>
    {
        List<CLASS> AddToCarts(string Name);
    }
}
