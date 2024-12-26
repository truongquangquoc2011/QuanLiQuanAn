using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyQuanAn_DongPhongNha
{
    public partial class QLNHEntities : DbContext
    {
        public QLNHEntities()
            : base("name=QLNHEntities")
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<AttendanceList> AttendanceList { get; set; }
        public virtual DbSet<Bill> Bill { get; set; }
        public virtual DbSet<BillInfo> BillInfo { get; set; }
        public virtual DbSet<BillInfoOfWareHouse> BillInfoOfWareHouse { get; set; }
        public virtual DbSet<BillOfWareHouse> BillOfWareHouse { get; set; }
        public virtual DbSet<Food> Food { get; set; }
        public virtual DbSet<FoodCategory> FoodCategory { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<TableFood> TableFood { get; set; }
        public virtual DbSet<Unit> Unit { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.idStaff)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.Bill)
                .WithOptional(e => e.Account)
                .HasForeignKey(e => e.payerId);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.BillOfWareHouse)
                .WithOptional(e => e.Account)
                .HasForeignKey(e => e.userName);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.BillOfWareHouse1)
                .WithOptional(e => e.Account1)
                .HasForeignKey(e => e.userName);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.BillOfWareHouse2)
                .WithOptional(e => e.Account2)
                .HasForeignKey(e => e.userName);

            modelBuilder.Entity<AttendanceList>()
                .Property(e => e.idStaff)
                .IsUnicode(false);

            modelBuilder.Entity<Bill>()
                .HasMany(e => e.BillInfo)
                .WithRequired(e => e.Bill)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BillOfWareHouse>()
                .HasMany(e => e.BillInfoOfWareHouse)
                .WithOptional(e => e.BillOfWareHouse)
                .HasForeignKey(e => e.idBillOfWareHouse);

            modelBuilder.Entity<BillOfWareHouse>()
                .HasMany(e => e.BillInfoOfWareHouse1)
                .WithOptional(e => e.BillOfWareHouse1)
                .HasForeignKey(e => e.idBillOfWareHouse);

            modelBuilder.Entity<BillOfWareHouse>()
                .HasMany(e => e.BillInfoOfWareHouse2)
                .WithOptional(e => e.BillOfWareHouse2)
                .HasForeignKey(e => e.idBillOfWareHouse);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.BillInfo)
                .WithRequired(e => e.Food)
                .HasForeignKey(e => e.idFood)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.BillInfo1)
                .WithRequired(e => e.Food1)
                .HasForeignKey(e => e.idFood)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.BillInfo2)
                .WithRequired(e => e.Food2)
                .HasForeignKey(e => e.idFood)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FoodCategory>()
                .HasMany(e => e.Food)
                .WithRequired(e => e.FoodCategory)
                .HasForeignKey(e => e.idFC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FoodCategory>()
                .HasMany(e => e.Food1)
                .WithRequired(e => e.FoodCategory1)
                .HasForeignKey(e => e.idFC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FoodCategory>()
                .HasMany(e => e.Food2)
                .WithRequired(e => e.FoodCategory2)
                .HasForeignKey(e => e.idFC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Material>()
                .HasMany(e => e.BillInfoOfWareHouse)
                .WithOptional(e => e.Material)
                .HasForeignKey(e => e.idMaterial);

            modelBuilder.Entity<Material>()
                .HasMany(e => e.BillInfoOfWareHouse1)
                .WithOptional(e => e.Material1)
                .HasForeignKey(e => e.idMaterial);

            modelBuilder.Entity<Material>()
                .HasMany(e => e.BillInfoOfWareHouse2)
                .WithOptional(e => e.Material2)
                .HasForeignKey(e => e.idMaterial);

            modelBuilder.Entity<Position>()
                .HasMany(e => e.Staff)
                .WithRequired(e => e.Position)
                .HasForeignKey(e => e.idPosition)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Position>()
                .HasMany(e => e.Staff1)
                .WithRequired(e => e.Position1)
                .HasForeignKey(e => e.idPosition)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Position>()
                .HasMany(e => e.Staff2)
                .WithRequired(e => e.Position2)
                .HasForeignKey(e => e.idPosition)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.idStaff)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.Account)
                .WithRequired(e => e.Staff)
                .HasForeignKey(e => e.idStaff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.Account1)
                .WithRequired(e => e.Staff1)
                .HasForeignKey(e => e.idStaff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.Account2)
                .WithRequired(e => e.Staff2)
                .HasForeignKey(e => e.idStaff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.AttendanceList)
                .WithOptional(e => e.Staff)
                .HasForeignKey(e => e.idStaff);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.AttendanceList1)
                .WithOptional(e => e.Staff1)
                .HasForeignKey(e => e.idStaff);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.AttendanceList2)
                .WithOptional(e => e.Staff2)
                .HasForeignKey(e => e.idStaff);

            modelBuilder.Entity<TableFood>()
                .HasMany(e => e.Bill)
                .WithRequired(e => e.TableFood)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Unit>()
                .HasMany(e => e.Material)
                .WithOptional(e => e.Unit)
                .HasForeignKey(e => e.idUnit);

            modelBuilder.Entity<Unit>()
                .HasMany(e => e.Material1)
                .WithOptional(e => e.Unit1)
                .HasForeignKey(e => e.idUnit);

            modelBuilder.Entity<Unit>()
                .HasMany(e => e.Material2)
                .WithOptional(e => e.Unit2)
                .HasForeignKey(e => e.idUnit);
        }
    }
}
