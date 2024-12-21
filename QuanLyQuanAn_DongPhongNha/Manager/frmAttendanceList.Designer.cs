namespace QuanLyQuanAn_DongPhongNha.Manager
{
    partial class frmAttendanceList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvAttendanceList = new System.Windows.Forms.DataGridView();
            this.dgv_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.lblTimeSheetsList = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnTimeSheetsList = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.btnFindStaff = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.txtIdentityCard = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceList)).BeginInit();
            this.pnTimeSheetsList.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAttendanceList
            // 
            this.dgvAttendanceList.AllowUserToAddRows = false;
            this.dgvAttendanceList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAttendanceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendanceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_id,
            this.dgv_name,
            this.dgv_datetime});
            this.dgvAttendanceList.Location = new System.Drawing.Point(0, 102);
            this.dgvAttendanceList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAttendanceList.Name = "dgvAttendanceList";
            this.dgvAttendanceList.ReadOnly = true;
            this.dgvAttendanceList.RowHeadersWidth = 81;
            this.dgvAttendanceList.RowTemplate.Height = 24;
            this.dgvAttendanceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendanceList.Size = new System.Drawing.Size(836, 809);
            this.dgvAttendanceList.TabIndex = 21;
            // 
            // dgv_id
            // 
            this.dgv_id.HeaderText = "Mã nhân viên";
            this.dgv_id.MinimumWidth = 6;
            this.dgv_id.Name = "dgv_id";
            this.dgv_id.ReadOnly = true;
            this.dgv_id.Width = 150;
            // 
            // dgv_name
            // 
            this.dgv_name.HeaderText = "Tên nhân viên";
            this.dgv_name.MinimumWidth = 6;
            this.dgv_name.Name = "dgv_name";
            this.dgv_name.ReadOnly = true;
            this.dgv_name.Width = 250;
            // 
            // dgv_datetime
            // 
            this.dgv_datetime.HeaderText = "Ngày điểm danh";
            this.dgv_datetime.MinimumWidth = 6;
            this.dgv_datetime.Name = "dgv_datetime";
            this.dgv_datetime.ReadOnly = true;
            this.dgv_datetime.Width = 300;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Location = new System.Drawing.Point(260, 722);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(214, 63);
            this.btnCheckIn.TabIndex = 4;
            this.btnCheckIn.Text = "Điểm danh";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(76, 579);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Địa Chỉ  :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(76, 530);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "SĐT :";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffID.Location = new System.Drawing.Point(224, 162);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(221, 25);
            this.txtStaffID.TabIndex = 2;
            this.txtStaffID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStaffID_KeyPress);
            // 
            // lblTimeSheetsList
            // 
            this.lblTimeSheetsList.AutoSize = true;
            this.lblTimeSheetsList.Font = new System.Drawing.Font("Cambria", 19.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTimeSheetsList.ForeColor = System.Drawing.Color.Black;
            this.lblTimeSheetsList.Location = new System.Drawing.Point(197, 24);
            this.lblTimeSheetsList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeSheetsList.Name = "lblTimeSheetsList";
            this.lblTimeSheetsList.Size = new System.Drawing.Size(349, 40);
            this.lblTimeSheetsList.TabIndex = 18;
            this.lblTimeSheetsList.Text = "Danh sách chấm công";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(76, 488);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "CCCD :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(76, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ngày Sinh :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(76, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Chức Vụ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(76, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Giới Tính :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(76, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã NV :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(111, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thông Tin Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(194, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chấm công";
            // 
            // pnTimeSheetsList
            // 
            this.pnTimeSheetsList.BackColor = System.Drawing.SystemColors.Menu;
            this.pnTimeSheetsList.Controls.Add(this.lblTimeSheetsList);
            this.pnTimeSheetsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTimeSheetsList.Location = new System.Drawing.Point(0, 0);
            this.pnTimeSheetsList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnTimeSheetsList.Name = "pnTimeSheetsList";
            this.pnTimeSheetsList.Size = new System.Drawing.Size(836, 89);
            this.pnTimeSheetsList.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(76, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ Tên :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.rtbAddress);
            this.panel1.Controls.Add(this.txtPhoneNumber);
            this.panel1.Controls.Add(this.txtIdentityCard);
            this.panel1.Controls.Add(this.txtDateOfBirth);
            this.panel1.Controls.Add(this.txtPosition);
            this.panel1.Controls.Add(this.txtSex);
            this.panel1.Controls.Add(this.txtStaffName);
            this.panel1.Controls.Add(this.btnFindStaff);
            this.panel1.Controls.Add(this.btnCheckIn);
            this.panel1.Controls.Add(this.txtStaffID);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(878, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 911);
            this.panel1.TabIndex = 20;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(224, 317);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(280, 22);
            this.txtStaffName.TabIndex = 7;
            this.txtStaffName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStaffName_KeyPress);
            // 
            // btnFindStaff
            // 
            this.btnFindStaff.Image = global::QuanLyQuanAn_DongPhongNha.Properties.Resources.Screenshot_2024_12_21_033255;
            this.btnFindStaff.Location = new System.Drawing.Point(494, 148);
            this.btnFindStaff.Name = "btnFindStaff";
            this.btnFindStaff.Size = new System.Drawing.Size(76, 69);
            this.btnFindStaff.TabIndex = 5;
            this.btnFindStaff.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(224, 359);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(142, 22);
            this.txtSex.TabIndex = 8;
            this.txtSex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSex_KeyPress);
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(224, 401);
            this.txtPosition.Multiline = true;
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(280, 22);
            this.txtPosition.TabIndex = 9;
            this.txtPosition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPosition_KeyPress);
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Location = new System.Drawing.Point(224, 445);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(280, 22);
            this.txtDateOfBirth.TabIndex = 10;
            this.txtDateOfBirth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDateOfBirth_KeyPress);
            // 
            // txtIdentityCard
            // 
            this.txtIdentityCard.Location = new System.Drawing.Point(224, 486);
            this.txtIdentityCard.Name = "txtIdentityCard";
            this.txtIdentityCard.Size = new System.Drawing.Size(280, 22);
            this.txtIdentityCard.TabIndex = 11;
            this.txtIdentityCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentityCard_KeyPress);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(224, 528);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(280, 22);
            this.txtPhoneNumber.TabIndex = 12;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // rtbAddress
            // 
            this.rtbAddress.Location = new System.Drawing.Point(224, 579);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(280, 90);
            this.rtbAddress.TabIndex = 13;
            this.rtbAddress.Text = "";
            this.rtbAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbAddress_KeyPress);
            // 
            // frmAttendanceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 911);
            this.Controls.Add(this.dgvAttendanceList);
            this.Controls.Add(this.pnTimeSheetsList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAttendanceList";
            this.Text = "frmAttendanceList";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceList)).EndInit();
            this.pnTimeSheetsList.ResumeLayout(false);
            this.pnTimeSheetsList.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAttendanceList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_datetime;
        private System.Windows.Forms.Button btnFindStaff;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label lblTimeSheetsList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnTimeSheetsList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtIdentityCard;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.RichTextBox rtbAddress;
    }
}