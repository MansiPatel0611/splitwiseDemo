using Microsoft.EntityFrameworkCore;
using SplitwiseDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplitwiseDemo.Data
{
    public class SystemDBContext : DbContext
    {
        public SystemDBContext(DbContextOptions<SystemDBContext> options) : base(options)
        {

        }
        public DbSet<User> users { get; set; }
        public DbSet<Currency> currencies { get; set; }
        public DbSet<Language> languages { get; set; }
        public DbSet<Timezone> timezones { get; set; }
        public DbSet<Group> groups { get; set; }
        public DbSet<GroupMember> groupmembers { get; set; }
        public DbSet<Bill> bills { get; set; }
        public DbSet<Payer> payers { get; set; }
        public DbSet<SharedWith> sharedwiths { get; set; }
        public DbSet<Settelments> settelments { get; set; }
    }
}
