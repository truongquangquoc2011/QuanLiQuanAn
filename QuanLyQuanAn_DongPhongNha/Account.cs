namespace QuanLyQuanAn_DongPhongNha
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Account()
        {
            Bill = new HashSet<Bill>();
            BillOfWareHouse = new HashSet<BillOfWareHouse>();
            BillOfWareHouse1 = new HashSet<BillOfWareHouse>();
            BillOfWareHouse2 = new HashSet<BillOfWareHouse>();
        }

        [Key]
        [StringLength(100)]
        public string userName { get; set; }

        [Required]
        [StringLength(1000)]
        public string passWord { get; set; }

        [Required]
        [StringLength(100)]
        public string displayName { get; set; }

        public int typeAccount { get; set; }

        [Required]
        [StringLength(5)]
        public string idStaff { get; set; }

        public virtual Staff Staff { get; set; }

        public virtual Staff Staff1 { get; set; }

        public virtual Staff Staff2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bill { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillOfWareHouse> BillOfWareHouse { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillOfWareHouse> BillOfWareHouse1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillOfWareHouse> BillOfWareHouse2 { get; set; }
    }
}
