

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Core.Entities;
namespace Core.Dbcontex
{
    public class MyDbContex:DbContext
    {
        public MyDbContex(DbContextOptions<MyDbContex> options) : base (options)
        {

        }

        public DbSet<Categories> Categories { get; set; }
        public DbSet<Stores> Stores { get; set; }
        public DbSet<Owners> Owners { get; set; }

    
    }
}
