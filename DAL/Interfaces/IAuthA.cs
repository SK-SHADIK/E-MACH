using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IAuthA<CLASS, ID>
    {
        CLASS Authenticate(string Email, string Pass);
        CLASS Admins(string Name);
    }
}
