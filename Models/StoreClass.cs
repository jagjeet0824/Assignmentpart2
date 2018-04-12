using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace part2.Models
{
    public class StoreClass : DbContext
    {
        public StoreClass()
        {
        }

        //Constructor
        public StoreClass(DbContextOptions<StoreClass>options) : base(options)
        {

        }

        public DbSet<Album> Albums { get; set; }
    }
}
