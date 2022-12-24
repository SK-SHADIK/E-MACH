using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class ApplicationLeaveRepo : Repo, IRepo<ApplicationLeave, int, ApplicationLeave>
    {
        public ApplicationLeave Add(ApplicationLeave obj)
        {
            db.ApplicationLeaves.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            var dbQA = Get(id);
            db.ApplicationLeaves.Remove(dbQA);
            return db.SaveChanges() > 0;
        }

        public List<ApplicationLeave> Get()
        {
            return db.ApplicationLeaves.ToList();
        }

        public ApplicationLeave Get(int id)
        {
            return db.ApplicationLeaves.Find(id);
        }

        public ApplicationLeave Update(ApplicationLeave obj)
        {
            var dbLA = Get(obj.Id);
            db.Entry(dbLA).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }
    }
}
