namespace QuanLyQuanAn_DongPhongNha
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BillInfoOfWareHouse")]
    public partial class BillInfoOfWareHouse
    {
        [Key]
        public int idBillInfoOfWareHouse { get; set; }

        public int? idBillOfWareHouse { get; set; }

        public int? idMaterial { get; set; }

        public int? number { get; set; }

        public int price { get; set; }

        public int totalPrice { get; set; }

        public virtual BillOfWareHouse BillOfWareHouse { get; set; }

        public virtual BillOfWareHouse BillOfWareHouse1 { get; set; }

        public virtual BillOfWareHouse BillOfWareHouse2 { get; set; }

        public virtual Material Material { get; set; }

        public virtual Material Material1 { get; set; }

        public virtual Material Material2 { get; set; }
    }
}
