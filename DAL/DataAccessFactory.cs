using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Fisherman, int, Fisherman> FishermanDataAccess()
        {
            return new FishermanRepo();
        }
        public static IAuthF<Fisherman, int> FishermanAuthDataAccess()
        {
            return new FishermanRepo();
        }
        public static IRepo<Officer, int, Officer> OfficerDataAccess()
        {
            return new OfficerRepo();
        }
        public static IAuth<Officer, int> OfficerAuthDataAccess()
        {
            return new OfficerRepo();
        }
        public static IRepo<QuestionAnswer, int, QuestionAnswer> QuestionAnswerDataAccess()
        {
            return new QuestionAnswerRepo();
        }
        public static IRepo<Suggestion, int, Suggestion> SuggestionDataAccess()
        {
            return new SuggestionRepo();
        }
        public static IRepo<Product, int, Product> ProductDataAccess()
        {
            return new ProductRepo();
        }
        public static IRepo<Token, string, Token> TokenDataAccess()
        {
            return new TokenRepo();
        }
    }
}
