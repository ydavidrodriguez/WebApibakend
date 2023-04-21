using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class ContextDb : DbContext
    {

        public DbSet<MStudent> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
           
            OptionsBuilder.UseSqlite
                (@"
                   Data Source = Students.db
                ");
        }



    }
}
