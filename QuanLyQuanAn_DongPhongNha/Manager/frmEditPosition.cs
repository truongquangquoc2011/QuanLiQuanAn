using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn_DongPhongNha.Manager
{
    public partial class frmEditPosition : Form
    {
        QLNHEntities DB = new QLNHEntities();
        public frmEditPosition()
        {
            InitializeComponent();
            load();
        }
        #region Method
        void load()
        {
            loadListPosition();
            columnRatio();
        }
        void setDataGridView(DataGridView dataGrid)
        {
            // fontSize 
            int desiredFontSize = 12;

            // chinh font size cho toàn bộ dgv
            dataGrid.DefaultCellStyle.Font = new Font("Cambria", desiredFontSize);

            // chinh frontSize cho tên cột
            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 15, FontStyle.Bold);

            dataGrid.BorderStyle = BorderStyle.None;
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGrid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGrid.BackgroundColor = Color.White;

            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        public void columnRatio()
        {
            int totalWidth = dgvPosition.Width;
            int column1Width = (int)(totalWidth * 0.2);
            int column2Width = (int)(totalWidth * 0.8);
            dgvPosition.Columns[0].Width = column1Width;
            dgvPosition.Columns[1].Width = column2Width;
        }
        void resetText()
        {
            txtPositionID.Text = string.Empty;
            txtPositionName.Text = string.Empty;
        }
        void loadListPosition()
        {
            int index = 0;
            dgvPosition.Rows.Clear();
            foreach (var item in (from ps in DB.Position select ps).ToList())
            {

                index = dgvPosition.Rows.Add();
                dgvPosition.Rows[index].Cells[0].Value = item.idPosition;
                dgvPosition.Rows[index].Cells[1].Value = item.namePosition;
            }
            lblTotalPosition.Text = "Tổng chức vụ: " + (dgvPosition.Rows.Count - 1);
            setDataGridView(dgvPosition);
        }

        // load theo tên
        void loadListPositionByName(string name)
        {
            int index = 0;
            dgvPosition.Rows.Clear();
            foreach (var item in (from ps in DB.Position where ps.namePosition.Contains(name) select ps).ToList())
            {
                index = dgvPosition.Rows.Add();
                dgvPosition.Rows[index].Cells[0].Value = item.idPosition;
                dgvPosition.Rows[index].Cells[1].Value = item.namePosition;
            }
            int totalRows = dgvPosition.Rows.Count > 0 ? dgvPosition.Rows.Count - 1 : 0;
            lblTotalPosition.Text = "Tổng chức vụ: " + totalRows;
            setDataGridView(dgvPosition);
        }

        //xóa
        void DeletePosition()
        {
            
        }

        //sữa
        void EditPosition()
        {
            
        }
        #endregion

        #region Event

        // thêm chức vụ
        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            string namePosition = txtPositionName.Text;

            if (namePosition != "")
            {
                // kiểm tra thử đã có chưa
                if ((from cv in DB.Position where cv.namePosition == namePosition select cv).FirstOrDefault() != null)
                {
                    msg.Show("Chức vụ bạn vừa thêm đã tồn tại.", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Warning);
                }
                else
                {
                    try
                    {
                        Position positionAdd = new Position() { namePosition = namePosition };
                        DB.Position.Add(positionAdd);
                        if (DB.SaveChanges() > 0)
                        {
                            msg.Show("Thêm chức vụ thành công. ", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                            loadListPosition();
                            resetText();
                        }
                    }
                    catch
                    {
                        msg.Show("Đã có lỗi gì xảy ra khi thêm chức vụ.", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);

                    }
                }
            }
            else
            {
                msg.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm chức vụ.", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Info);
            }
        }

        private void btnDeletePosition_Click(object sender, EventArgs e)
        {
            
        }
        private void btnEditPosition_Click(object sender, EventArgs e)
        {
            
        }
        private void btnShowPosition_Click(object sender, EventArgs e)
        {
            
        }
        private void txtFindPositionByName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvPosition_CellMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indexRow = e.RowIndex;
                DataGridViewRow row = dgvPosition.Rows[indexRow];
                txtPositionID.Text = row.Cells[0].Value.ToString();
                txtPositionName.Text = row.Cells[1].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có dữ liệu hợp lệ để hiển thị. Vui lòng thử lại.",
                    "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
        }

        #endregion

        private void frmEditPosition_Load(object sender, EventArgs e)
        {
        }

        private void txtPositionName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                errorProvider1.SetError(txtPositionName, "Tên chức vụ được nhập chữ cái và khoảng trắng!");
            }
            else
            {
                errorProvider1.SetError(txtPositionName, null);
            }
        }

        private void txtPositionID_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
