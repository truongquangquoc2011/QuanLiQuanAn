//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyQuanAn_DongPhongNha
{
    using System;
    using System.Collections.Generic;
    
    public partial class BillOfWareHouse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BillOfWareHouse()
        {
            this.BillInfoOfWareHouse = new HashSet<BillInfoOfWareHouse>();
            this.BillInfoOfWareHouse1 = new HashSet<BillInfoOfWareHouse>();
            this.BillInfoOfWareHouse2 = new HashSet<BillInfoOfWareHouse>();
            this.BillInfoOfWareHouse3 = new HashSet<BillInfoOfWareHouse>();
            this.BillInfoOfWareHouse4 = new HashSet<BillInfoOfWareHouse>();
            this.BillInfoOfWareHouse5 = new HashSet<BillInfoOfWareHouse>();
            this.BillInfoOfWareHouse6 = new HashSet<BillInfoOfWareHouse>();
            this.BillInfoOfWareHouse7 = new HashSet<BillInfoOfWareHouse>();
            this.BillInfoOfWareHouse8 = new HashSet<BillInfoOfWareHouse>();
            this.BillInfoOfWareHouse9 = new HashSet<BillInfoOfWareHouse>();
            this.BillInfoOfWareHouse10 = new HashSet<BillInfoOfWareHouse>();
            this.BillInfoOfWareHouse11 = new HashSet<BillInfoOfWareHouse>();
        }
    
        public int idBillOfWareHouse { get; set; }
        public System.DateTime dateAdded { get; set; }
        public string supplier { get; set; }
        public string note { get; set; }
        public string userName { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Account Account1 { get; set; }
        public virtual Account Account2 { get; set; }
        public virtual Account Account3 { get; set; }
        public virtual Account Account4 { get; set; }
        public virtual Account Account5 { get; set; }
        public virtual Account Account6 { get; set; }
        public virtual Account Account7 { get; set; }
        public virtual Account Account8 { get; set; }
        public virtual Account Account9 { get; set; }
        public virtual Account Account10 { get; set; }
        public virtual Account Account11 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfoOfWareHouse> BillInfoOfWareHouse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfoOfWareHouse> BillInfoOfWareHouse1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfoOfWareHouse> BillInfoOfWareHouse2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfoOfWareHouse> BillInfoOfWareHouse3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfoOfWareHouse> BillInfoOfWareHouse4 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfoOfWareHouse> BillInfoOfWareHouse5 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfoOfWareHouse> BillInfoOfWareHouse6 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfoOfWareHouse> BillInfoOfWareHouse7 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfoOfWareHouse> BillInfoOfWareHouse8 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfoOfWareHouse> BillInfoOfWareHouse9 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfoOfWareHouse> BillInfoOfWareHouse10 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfoOfWareHouse> BillInfoOfWareHouse11 { get; set; }
    }
}