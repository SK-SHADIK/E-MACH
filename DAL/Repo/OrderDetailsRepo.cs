using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    class OrderDetailsRepo : Repo, IRepo<OrderDetails, int, OrderDetails>
    {
        public OrderDetails Add(OrderDetails obj)
        {
            db.OrderDetails.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderDetails> Get()
        {
            return db.OrderDetails.ToList();
        }

        public OrderDetails Get(int id)
        {
            return db.OrderDetails.Find(id);
        }

        public OrderDetails Update(OrderDetails obj)
        {
            throw new NotImplementedException();
        }
    }
}
