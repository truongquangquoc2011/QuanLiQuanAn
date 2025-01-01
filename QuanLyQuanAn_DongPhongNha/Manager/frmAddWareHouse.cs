using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn_DongPhongNha.Manager
{
    public partial class frmAddWareHouse : Form
    {
        QLNHEntities db = new QLNHEntities();
        private Account loginAccount;
        public frmAddWareHouse(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
            Load();
        }
        #region Method      
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }
        public void Load()
        {
            loadComboboxUnit();
            loadComboboxMaterial();
            loadMaterialList();
            loadListUnit();
            loadDetailOfBill();
        }
        private void loadComboboxUnit()
        {
            List<Unit> listUnit = (from u in db.Unit select u).ToList();
            cmbUnit.DataSource = listUnit;
            cmbUnit.DisplayMember = "nameUnit";
        }
        private void loadComboboxMaterial()
        {
            List<Material> listMaterial = (from m in db.Material select m).ToList();
            cmbMaterialName.DataSource = listMaterial;
            cmbMaterialName.DisplayMember = "nameMaterial";
        }
        private void loadMaterialList()
        {
            int n = 0;
            dgvMaterialList.Rows.Clear();
            List<Material> materials = (from m in db.Material select m).ToList();
            foreach (var item in materials)
            {
                n = dgvMaterialList.Rows.Add();
                dgvMaterialList.Rows[n].Cells[0].Value = item.idMaterial;
                dgvMaterialList.Rows[n].Cells[1].Value = item.nameMaterial;
                //dgvMaterialList.Rows[n].Cells[2].Value = item.Unit.nameUnit;
                string cellValue = (item.Unit != null && item.Unit.nameUnit != null)
                    ? item.Unit.nameUnit
                    : string.Empty;

                dgvMaterialList.Rows[n].Cells[2].Value = cellValue;

            }
            dgvMaterialList.BorderStyle = BorderStyle.None;
            dgvMaterialList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvMaterialList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMaterialList.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvMaterialList.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvMaterialList.BackgroundColor = Color.White;

            dgvMaterialList.EnableHeadersVisualStyles = false;
            dgvMaterialList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMaterialList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvMaterialList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void loadListUnit()
        {
            int n = 0;
            dgvUnitList.Rows.Clear();
            List<Unit> unitList = (from u in db.Unit select u).ToList();
            foreach (var item in unitList)
            {
                n = dgvUnitList.Rows.Add();
                dgvUnitList.Rows[n].Cells[0].Value = item.idUnit;
                dgvUnitList.Rows[n].Cells[1].Value = item.nameUnit;
            }

            dgvUnitList.BorderStyle = BorderStyle.None;
            dgvUnitList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvUnitList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUnitList.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvUnitList.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvUnitList.BackgroundColor = Color.White;

            dgvUnitList.EnableHeadersVisualStyles = false;
            dgvUnitList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUnitList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvUnitList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void loadDetailOfBill()
        {

            var billMax = db.BillOfWareHouse.OrderByDescending(x => x.idBillOfWareHouse).FirstOrDefault();
            int idBillOfWareHouse = 1;
            if (billMax != null)
            {
                idBillOfWareHouse = billMax.idBillOfWareHouse + 1;
            }
            txtIdBillOfWareHouse.Text = idBillOfWareHouse.ToString();
            txtDate.Text = DateTime.Today.ToString().Split(' ')[0];
        }
        #endregion


        private void btnEditMaterial_Click(object sender, EventArgs e)
        {

        }
    }
}
