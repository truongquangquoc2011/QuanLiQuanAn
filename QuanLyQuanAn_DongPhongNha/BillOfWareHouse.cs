namespace QuanLyQuanAn_DongPhongNha
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BillOfWareHouse")]
    public partial class BillOfWareHouse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BillOfWareHouse()
        {
            BillInfoOfWareHouse = new HashSet<BillInfoOfWareHouse>();
            BillInfoOfWareHouse1 = new HashSet<BillInfoOfWareHouse>();
            BillInfoOfWareHouse2 = new HashSet<BillInfoOfWareHouse>();
        }

        [Key]
        public int idBillOfWareHouse { get; set; }

        [Column(TypeName = "date")]
        public DateTime dateAdded { get; set; }

        [Required]
        [StringLength(100)]
        public string supplier { get; set; }

        [StringLength(100)]
        public string note { get; set; }

        [StringLength(100)]
        public string userName { get; set; }

        public virtual Account Account { get; set; }

        public virtual Account Account1 { get; set; }

        public virtual Account Account2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfoOfWareHouse> BillInfoOfWareHouse { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfoOfWareHouse> BillInfoOfWareHouse1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfoOfWareHouse> BillInfoOfWareHouse2 { get; set; }
    }
}
