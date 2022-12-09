using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class OfficerRepo : Repo, IRepo<Officer, int, Officer>
    {
        public Officer Add(Officer obj)
        {
            db.Officers.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            var dbOfficer = Get(id);
            db.Officers.Remove(dbOfficer);
            return db.SaveChanges() > 0;
        }

        public List<Officer> Get()
        {
            return db.Officers.ToList();
        }

        public Officer Get(int id)
        {
            return db.Officers.Find(id);
        }

        public Officer Update(Officer obj)
        {
            var dbOfficer = Get(obj.Id);
            db.Entry(dbOfficer).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }
    }
}
