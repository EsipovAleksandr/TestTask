using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTaskAionys.Model
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Clients> Clientes { get; set; }
        public DbSet<ClientTask> ClientTasks { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
              : base(options)
        {
        }
    }
}
