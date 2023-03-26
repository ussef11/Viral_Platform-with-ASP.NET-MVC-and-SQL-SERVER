using Microsoft.EntityFrameworkCore;
using MyProjet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProjet.Data
{
    public class ApplicationDbContext : DbContext
    {
        //ctor twisse tab to see magic

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Users> Users { get; set; }

        public DbSet<Articles> Articles { get; set; }

        public DbSet<Articlesimages> Articlesimages { get; set; }

        public DbSet<Quizzes> Quizzes { get; set; }
        public DbSet<chooseQuizzes> chooseQuizzes { get; set; }




    }
}
