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
    
    public partial class BillInfo
    {
        public int idBillInfo { get; set; }
        public int idBill { get; set; }
        public int idFood { get; set; }
        public int countFood { get; set; }
    
        public virtual Bill Bill { get; set; }
        public virtual Food Food { get; set; }
        public virtual Food Food1 { get; set; }
        public virtual Food Food2 { get; set; }
        public virtual Food Food3 { get; set; }
        public virtual Food Food4 { get; set; }
        public virtual Food Food5 { get; set; }
    }
}
