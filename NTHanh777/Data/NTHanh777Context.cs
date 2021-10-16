using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NTHanh777.Models;

namespace NTHanh777.Data
{
    public class NTHanh777Context : DbContext
    {
        public NTHanh777Context (DbContextOptions<NTHanh777Context> options)
            : base(options)
        {
        }

        public DbSet<NTHanh777.Models.PersonNT77> PersonNT77 { get; set; }

        public DbSet<NTHanh777.Models.NVN123> NVN123 { get; set; }
    }
}
