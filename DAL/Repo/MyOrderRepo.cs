using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class MyOrderRepo : Repo, IRepo<MyOrder, int, MyOrder>
    {
        public MyOrder Add(MyOrder obj)
        {
            db.MyOrders.Add(obj);
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

        public List<MyOrder> Get()
        {
            return db.MyOrders.ToList();
        }

        public MyOrder Get(int id)
        {
            return db.MyOrders.Find(id);
        }

        public MyOrder Update(MyOrder obj)
        {
            throw new NotImplementedException();
        }
    }
}
