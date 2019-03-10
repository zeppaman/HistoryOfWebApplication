using Microsoft.EntityFrameworkCore;
using MvcSample.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcSample.Models
{
    public class Database : DbContext
    {
        public static string DefaultConnection { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {         
            optionsBuilder.UseMySQL(DefaultConnection);
        }

    }
}
