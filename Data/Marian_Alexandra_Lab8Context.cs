using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Marian_Alexandra_Lab8.Models;

namespace Marian_Alexandra_Lab8.Data
{
    public class Marian_Alexandra_Lab8Context : DbContext
    {
        public Marian_Alexandra_Lab8Context (DbContextOptions<Marian_Alexandra_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Marian_Alexandra_Lab8.Models.Book> Book { get; set; }

        public DbSet<Marian_Alexandra_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Marian_Alexandra_Lab8.Models.Category> Category { get; set; }
    }
}
