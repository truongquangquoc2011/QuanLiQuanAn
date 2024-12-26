namespace QuanLyQuanAn_DongPhongNha
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Material")]
    public partial class Material
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Material()
        {
            BillInfoOfWareHouse = new HashSet<BillInfoOfWareHouse>();
            BillInfoOfWareHouse1 = new HashSet<BillInfoOfWareHouse>();
            BillInfoOfWareHouse2 = new HashSet<BillInfoOfWareHouse>();
        }

        [Key]
        public int idMaterial { get; set; }

        [Required]
        [StringLength(100)]
        public string nameMaterial { get; set; }

        public int? idUnit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfoOfWareHouse> BillInfoOfWareHouse { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfoOfWareHouse> BillInfoOfWareHouse1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfoOfWareHouse> BillInfoOfWareHouse2 { get; set; }

        public virtual Unit Unit { get; set; }

        public virtual Unit Unit1 { get; set; }

        public virtual Unit Unit2 { get; set; }
    }
}
