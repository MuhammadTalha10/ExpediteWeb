using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExpediteWeb.Models;

namespace ExpediteWeb.Data
{
    public class ExpediteWebContext : DbContext
    {
        public ExpediteWebContext (DbContextOptions<ExpediteWebContext> options)
            : base(options)
        {
        }
        //Class name is always singular And Db table name is always plural 
        public DbSet<User> Users { get; set; }
    }
}
