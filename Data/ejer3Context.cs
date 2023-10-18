using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ejer3.Models;

namespace ejer3.Data
{
    public class ejer3Context : DbContext
    {
        public ejer3Context (DbContextOptions<ejer3Context> options)
            : base(options)
        {
        }

        public DbSet<ejer3.Models.Burger> Burger { get; set; } = default!;
        public DbSet<ejer3.Models.Promo> Promo { get; set; } 
    }
}
