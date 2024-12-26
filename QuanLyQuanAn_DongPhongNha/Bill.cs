namespace QuanLyQuanAn_DongPhongNha
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bill")]
    public partial class Bill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bill()
        {
            BillInfo = new HashSet<BillInfo>();
        }

        [Key]
        public int idBill { get; set; }

        public DateTime dateCheckIn { get; set; }

        public DateTime? dateCheckOut { get; set; }

        public int idTable { get; set; }

        public int statusBill { get; set; }

        public int? discount { get; set; }

        public double? totalPrice { get; set; }

        [StringLength(100)]
        public string payerId { get; set; }

        public virtual Account Account { get; set; }

        public virtual TableFood TableFood { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfo> BillInfo { get; set; }
    }
}
