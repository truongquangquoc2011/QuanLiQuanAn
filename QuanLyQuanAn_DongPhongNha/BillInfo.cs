namespace QuanLyQuanAn_DongPhongNha
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BillInfo")]
    public partial class BillInfo
    {
        [Key]
        public int idBillInfo { get; set; }

        public int idBill { get; set; }

        public int idFood { get; set; }

        public int countFood { get; set; }

        public virtual Bill Bill { get; set; }

        public virtual Food Food { get; set; }

        public virtual Food Food1 { get; set; }

        public virtual Food Food2 { get; set; }
    }
}
