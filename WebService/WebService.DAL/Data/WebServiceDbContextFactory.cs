using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService.DAL.Data
{
    public class WebServiceDbContextFactory: IDesignTimeDbContextFactory<WebServiceDbContext>
    {
        public WebServiceDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<WebServiceDbContext>();
            optionsBuilder.UseSqlite("Data Source=webservice.db");

            return new WebServiceDbContext(optionsBuilder.Options);
        }
    }
}
