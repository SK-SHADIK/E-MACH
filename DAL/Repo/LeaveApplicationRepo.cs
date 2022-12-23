using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    class LeaveApplicationRepo : Repo, IRepo<LeaveApplication, int, LeaveApplication>
    {
        public LeaveApplication Add(LeaveApplication obj)
        {
            db.LeaveApplications.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            var dbLeaveApplication = Get(id);
            db.LeaveApplications.Remove(dbLeaveApplication);
            return db.SaveChanges() > 0;
        }

        public List<LeaveApplication> Get()
        {
            return db.LeaveApplications.ToList();
        }

        public LeaveApplication Get(int id)
        {
            return db.LeaveApplications.Find(id);
        }

        public LeaveApplication Update(LeaveApplication obj)
        {
            var dbLeaveApplication = Get(obj.Id);
            db.Entry(dbLeaveApplication).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }
    }
}
