using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    class AdminRepo : Repo, IRepo<Admin, int, Admin>, IAuthA<Admin, int>
    {
        public Admin Add(Admin obj)
        {
            throw new NotImplementedException();
        }

        public Admin Admins(string Name)
        {
            var obj = db.Admins.FirstOrDefault(x => x.Name.Equals(Name));
            return obj;
        }

        public Admin Authenticate(string Email, string Pass)
        {
            var obj = db.Admins.FirstOrDefault(x => x.Email.Equals(Email) && x.Pass.Equals(Pass));
            return obj;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Admin> Get()
        {
            throw new NotImplementedException();
        }

        public Admin Get(int id)
        {
            throw new NotImplementedException();
        }

        public Admin Update(Admin obj)
        {
            var dbadmin = Get(obj.Id);
            db.Entry(dbadmin).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }
    }
}
