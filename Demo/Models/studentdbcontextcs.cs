using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class studentdbcontextcs : DbContext
    {
        public studentdbcontextcs()
        {
        }

        public studentdbcontextcs(DbContextOptions<studentdbcontextcs> options) : base (options){
        
        }
        public DbSet<student> students { get; set; }
        public DbSet<User> User { get; set; }
    }
}
