using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class SuggestionRepo:Repo, IRepo<Suggestion, int, Suggestion>
    {
        public Suggestion Add(Suggestion obj)
        {
            db.Suggestions.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            var dbSuggestion = Get(id);
            db.Suggestions.Remove(dbSuggestion);
            return db.SaveChanges() > 0;
        }

        public List<Suggestion> Get()
        {
            return db.Suggestions.ToList();
        }

        public Suggestion Get(int id)
        {
            return db.Suggestions.Find(id);
        }

        public Suggestion Update(Suggestion obj)
        {
            var dbSuggestion = Get(obj.Id);
            db.Entry(dbSuggestion).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }
    }
}
