namespace QuanLyQuanAn_DongPhongNha
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Food")]
    public partial class Food
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Food()
        {
            BillInfo = new HashSet<BillInfo>();
            BillInfo1 = new HashSet<BillInfo>();
            BillInfo2 = new HashSet<BillInfo>();
        }

        [Key]
        public int idFood { get; set; }

        [Required]
        [StringLength(100)]
        public string nameFood { get; set; }

        public int idFC { get; set; }

        public double price { get; set; }

        [StringLength(100)]
        public string imageFood { get; set; }

        [StringLength(10)]
        public string statusFood { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfo> BillInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfo> BillInfo1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfo> BillInfo2 { get; set; }

        public virtual FoodCategory FoodCategory { get; set; }

        public virtual FoodCategory FoodCategory1 { get; set; }

        public virtual FoodCategory FoodCategory2 { get; set; }
    }
}
