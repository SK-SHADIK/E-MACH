using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class Repo
    {
        protected EMACHContext db;
        internal Repo()
        {
            db = new EMACHContext();
        }
    }
}
