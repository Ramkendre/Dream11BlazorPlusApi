using Dream11Model.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dream11Model.EntityFrameworkContext
{
    public class PlayerPerformaContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=IDTP376;Initial Catalog=PlayerPerforma;user id=sa;password=synerzip;multipleactiveresultsets=True;application name=Dream11");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
       

        }

     
         public DbSet<MatchPlayerPerforma> MatchPlayerPerformas { get; set; }

    }
}
