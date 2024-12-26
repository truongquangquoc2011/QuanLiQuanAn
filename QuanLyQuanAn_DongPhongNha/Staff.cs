namespace QuanLyQuanAn_DongPhongNha
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Staff")]
    public partial class Staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staff()
        {
            Account = new HashSet<Account>();
            Account1 = new HashSet<Account>();
            Account2 = new HashSet<Account>();
            AttendanceList = new HashSet<AttendanceList>();
            AttendanceList1 = new HashSet<AttendanceList>();
            AttendanceList2 = new HashSet<AttendanceList>();
        }

        [Key]
        [StringLength(5)]
        public string idStaff { get; set; }

        [Required]
        [StringLength(100)]
        public string nameStaff { get; set; }

        [StringLength(10)]
        public string sex { get; set; }

        public int idPosition { get; set; }

        [Column(TypeName = "date")]
        public DateTime dateOfBirth { get; set; }

        [Required]
        [StringLength(12)]
        public string identityCard { get; set; }

        [Required]
        [StringLength(10)]
        public string phoneNumber { get; set; }

        [Required]
        [StringLength(100)]
        public string address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Account> Account { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Account> Account1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Account> Account2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttendanceList> AttendanceList { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttendanceList> AttendanceList1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttendanceList> AttendanceList2 { get; set; }

        public virtual Position Position { get; set; }

        public virtual Position Position1 { get; set; }

        public virtual Position Position2 { get; set; }
    }
}
