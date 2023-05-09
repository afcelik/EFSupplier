using EFSupplier.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSupplier.context
{
    public class SupplierContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-OVRMDFF; Database=SuppliersDb; Trusted_Connection=True");
        }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
