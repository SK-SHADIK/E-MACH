using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    class FishermanRepo : Repo, IRepo<Fisherman, int, Fisherman>, IAuthF<Fisherman, int>
    {
        public Fisherman Add(Fisherman obj)
        {
            db.Fishermens.Add(obj);
            if(db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }
        public Fisherman Fishermans(string Name)
        {
            var obj = db.Fishermens.FirstOrDefault(x => x.Name.Equals(Name));
            return obj;
        }

        public Fisherman Authenticate(string Email, string Pass)
        {
            var obj = db.Fishermens.FirstOrDefault(x => x.Email.Equals(Email) && x.Pass.Equals(Pass));
            return obj;
        }

        public bool Delete(int id)
        {
            var dbFisherman = Get(id);
            db.Fishermens.Remove(dbFisherman);
            return db.SaveChanges() > 0;
        }

        public List<Fisherman> Get()
        {
            return db.Fishermens.ToList();
        }

        public Fisherman Get(int id)
        {
            return db.Fishermens.Find(id);
        }

        public Fisherman Update(Fisherman obj)
        {
            var dbfisherman = Get(obj.Id);
            db.Entry(dbfisherman).CurrentValues.SetValues(obj);
            if(db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }
    }
}
