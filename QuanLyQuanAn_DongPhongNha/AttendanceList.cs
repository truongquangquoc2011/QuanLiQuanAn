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
    
    public partial class AttendanceList
    {
        public int id { get; set; }
        public string idStaff { get; set; }
        public System.DateTime dateCheckIn { get; set; }
    
        public virtual Staff Staff { get; set; }
        public virtual Staff Staff1 { get; set; }
        public virtual Staff Staff2 { get; set; }
    }
}
