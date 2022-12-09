using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class QuestionAnswerRepo : Repo, IRepo<QuestionAnswer, int, QuestionAnswer>
    {
        public QuestionAnswer Add(QuestionAnswer obj)
        {
            db.QuestionAnswers.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            var dbQA = Get(id);
            db.QuestionAnswers.Remove(dbQA);
            return db.SaveChanges() > 0;
        }

        public List<QuestionAnswer> Get()
        {
            return db.QuestionAnswers.ToList();
        }

        public QuestionAnswer Get(int id)
        {
            return db.QuestionAnswers.Find(id);
        }

        public QuestionAnswer Update(QuestionAnswer obj)
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
