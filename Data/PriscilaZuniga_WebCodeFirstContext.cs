using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PriscilaZuniga_WebCodeFirst.Models;

namespace WebCodeFirst.Data
{
    public class PriscilaZuniga_WebCodeFirstContext : DbContext
    {
        public PriscilaZuniga_WebCodeFirstContext (DbContextOptions<PriscilaZuniga_WebCodeFirstContext> options)
            : base(options)
        {
        }

        public DbSet<PriscilaZuniga_WebCodeFirst.Models.Burger> Burger { get; set; } = default!;
    }
}
