using AssoSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace AssoSystem.Data
{
    public class AssoSystemContext : IdentityDbContext
    {
        public AssoSystemContext(DbContextOptions<AssoSystemContext> options)
            : base(options)
        {            
        }
        public DbSet<Address> addresses { get; set; } = default!;
        public DbSet<Associate> associates { get; set; } = default!;
    }
}