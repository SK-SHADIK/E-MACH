using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class EMACHContext : DbContext
    {
        public DbSet <Product> Products { get; set; }
        public DbSet <QuestionAnswer> QuestionAnswers { get; set; }
        public DbSet <Question> Questions { get; set; }
        public DbSet <Admin> Admins { get; set; }
        public DbSet <Fisherman> Fishermens { get; set; }
        public DbSet <Officer> Officers { get; set; }
        public DbSet <Suggestion> Suggestions { get; set; }
        public DbSet <Token> Tokens { get; set; }
        public DbSet <ApplicationLeave> ApplicationLeaves { get; set; }
        public DbSet <AddToCart> AddToCarts { get; set; }
        public DbSet <MyOrder> MyOrders { get; set; }
        public DbSet <OrderDetails> OrderDetails { get; set; }

    }
}
