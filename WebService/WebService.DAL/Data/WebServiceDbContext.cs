using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebService.Domain.Entities;

namespace WebService.DAL.Data
{
    public class WebServiceDbContext: DbContext
    {
        public DbSet<Utilisateur> Utilisateurs { get { return Set<Utilisateur>(); } }

        public WebServiceDbContext(DbContextOptions<WebServiceDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
