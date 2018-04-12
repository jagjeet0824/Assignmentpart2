using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Models;

namespace part2.Models
{
    public class CategoryModel : DbContext
    {
        // constructor
        public CategoryModel(DbContextOptions<CategoryModel> options) : base(options)
        {

        }
        public DbSet<planes> Category { get; set; }
        public DbSet<Assignment.Models.Category> Category_1 { get; set; }

    }
}

   
   