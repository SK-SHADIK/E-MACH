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
        public DbSet <Admin> Admins { get; set; }
        public DbSet <Fisherman> Fishermens { get; set; }
        public DbSet <Officer> Officers { get; set; }
        public DbSet <Suggestion> Suggestions { get; set; }
        public DbSet <LeaveApplication> LeaveApplications { get; set; }

    }
}
