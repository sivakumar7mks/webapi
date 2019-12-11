namespace Assign_Ment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeMaster")]
    public partial class EmployeeMaster
    {
        [Key]
        public int employeeId { get; set; }

        [StringLength(200)]
        public string employeeName { get; set; }

        public int? roleId { get; set; }

        public virtual RoleMaster RoleMaster { get; set; }
    }
}
