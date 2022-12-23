using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class QuestionRepo : Repo, IRepo<Question, int, Question>
    {
        public Question Add(Question obj)
        {
            db.Questions.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            var dbQA = Get(id);
            db.Questions.Remove(dbQA);
            return db.SaveChanges() > 0;
        }

        public List<Question> Get()
        {
            return db.Questions.ToList();
        }

        public Question Get(int id)
        {
            return db.Questions.Find(id);
        }

        public Question Update(Question obj)
        {
            var dbQA = Get(obj.Id);
            db.Entry(dbQA).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }
    }
}
