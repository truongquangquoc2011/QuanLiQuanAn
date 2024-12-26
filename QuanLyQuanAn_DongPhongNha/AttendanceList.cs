namespace QuanLyQuanAn_DongPhongNha
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AttendanceList")]
    public partial class AttendanceList
    {
        public int id { get; set; }

        [StringLength(5)]
        public string idStaff { get; set; }

        public DateTime dateCheckIn { get; set; }

        public virtual Staff Staff { get; set; }

        public virtual Staff Staff1 { get; set; }

        public virtual Staff Staff2 { get; set; }
    }
}
