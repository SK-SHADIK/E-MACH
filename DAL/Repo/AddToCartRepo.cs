using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class AddToCartRepo : Repo, IRepo<AddToCart, int, AddToCart>, IRepoOR<AddToCart, string>
    {
        public AddToCart Add(AddToCart obj)
        {
            db.AddToCarts.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public List<AddToCart> AddToCarts(string Name)
        {
            
            return new List<AddToCart>();
        }

        public bool Delete(int id)
        {
            var dbAddToCart = Get(id);
            db.AddToCarts.Remove(dbAddToCart);
            return db.SaveChanges() > 0;
        }

        public List<AddToCart> Get()
        {
            return db.AddToCarts.ToList();
        }

        public AddToCart Get(int id)
        {
            return db.AddToCarts.Find(id);
        }

        public AddToCart Update(AddToCart obj)
        {
            var dbfisherman = Get(obj.Id);
            db.Entry(dbfisherman).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }
    }
}
