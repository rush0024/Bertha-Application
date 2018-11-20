using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BerthaApplication.Models
{
    public class BerthaContext : DbContext
    {
        public BerthaContext(DbContextOptions<BerthaContext> options)
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<HealthRecords> HealthRecord { get; set; }
        
    }

}
