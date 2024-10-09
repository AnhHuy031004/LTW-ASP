using BaiKiemTra03_03.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;
using Contract = BaiKiemTra03_03.Models.Contract;

namespace BaiKiemTra03_03.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
       public DbSet<Contract> Contract { get; set; }
        public DbSet<Customer> Customer { get; set; }
    }
}
