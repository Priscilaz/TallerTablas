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

        //Esta clase representa la base de datos
        public PriscilaZuniga_WebCodeFirstContext (DbContextOptions<PriscilaZuniga_WebCodeFirstContext> options)
            : base(options)
        {
        }

        public DbSet<PriscilaZuniga_WebCodeFirst.Models.Burger> Burger { get; set; } = default!;
        public DbSet<PriscilaZuniga_WebCodeFirst.Models.Promo> Promo { get; set; } = default!;
    }
}
