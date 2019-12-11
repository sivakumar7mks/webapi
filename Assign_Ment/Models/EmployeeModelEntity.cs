namespace Assign_Ment.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EmployeeModelEntity : DbContext
    {
        public EmployeeModelEntity()
            : base("name=EmployeeModelEntity")
        {
        }

        public virtual DbSet<EmployeeMaster> EmployeeMasters { get; set; }
        public virtual DbSet<RoleMaster> RoleMasters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeMaster>()
                .Property(e => e.employeeName)
                .IsUnicode(false);

            modelBuilder.Entity<RoleMaster>()
                .Property(e => e.roleName)
                .IsUnicode(false);
        }
    }
}
