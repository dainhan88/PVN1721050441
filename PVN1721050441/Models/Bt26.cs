using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PVN1721050441.Models
{
    public partial class Bt26 : DbContext
    {
        public Bt26()
            : base("name=Bt2610DBContext")
        {
        }
        public virtual DbSet<Person> People { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>()
                .Property(e => e.RoleID)
                .IsUnicode(false);
            modelBuilder.Entity<Role>()
                .Property(e => e.RoleName)
                .IsUnicode(true);
        }
    }
}
