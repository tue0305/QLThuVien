namespace QuanLyThuVien
{
    partial class FormNV : FormNV
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
            this.lbQLNV = new System.Windows.Forms.Label();
            this.gbThongTinNV = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.dpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBangCap = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.gbThongTinNV.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            //this.SuspendLayout();
            // 
            // lbQLNV
            // 
            this.lbQLNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbQLNV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbQLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQLNV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbQLNV.Location = new System.Drawing.Point(-1, -1);
            this.lbQLNV.Name = "lbQLNV";
            this.lbQLNV.Size = new System.Drawing.Size(1039, 58);
            this.lbQLNV.TabIndex = 0;
            this.lbQLNV.Text = "QUẢN LÝ NHÂN VIÊN";
            this.lbQLNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbThongTinNV
            // 
            this.gbThongTinNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbThongTinNV.Controls.Add(this.cbBangCap);
            this.gbThongTinNV.Controls.Add(this.btLuu);
            this.gbThongTinNV.Controls.Add(this.btHuy);
            this.gbThongTinNV.Controls.Add(this.dpNgaySinh);
            this.gbThongTinNV.Controls.Add(this.label5);
            this.gbThongTinNV.Controls.Add(this.btXoa);
            this.gbThongTinNV.Controls.Add(this.txtSDT);
            this.gbThongTinNV.Controls.Add(this.btSua);
            this.gbThongTinNV.Controls.Add(this.label4);
            this.gbThongTinNV.Controls.Add(this.btThem);
            this.gbThongTinNV.Controls.Add(this.txtDiaChi);
            this.gbThongTinNV.Controls.Add(this.label3);
            this.gbThongTinNV.Controls.Add(this.label2);
            this.gbThongTinNV.Controls.Add(this.txtHoTen);
            this.gbThongTinNV.Controls.Add(this.label1);
            this.gbThongTinNV.Location = new System.Drawing.Point(86, 79);
            this.gbThongTinNV.Name = "gbThongTinNV";
            this.gbThongTinNV.Size = new System.Drawing.Size(840, 236);
            this.gbThongTinNV.TabIndex = 1;
            this.gbThongTinNV.TabStop = false;
            this.gbThongTinNV.Text = "Thông tin chi tiết";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(115, 37);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(252, 22);
            this.txtHoTen.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa Chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(506, 86);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(258, 65);
            this.txtDiaChi.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Điên thoại:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(506, 37);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(258, 22);
            this.txtSDT.TabIndex = 1;
            // 
            // dpNgaySinh
            // 
            this.dpNgaySinh.Location = new System.Drawing.Point(115, 84);
            this.dpNgaySinh.MaxDate = new System.DateTime(2002, 12, 31, 0, 0, 0, 0);
            this.dpNgaySinh.Name = "dpNgaySinh";
            this.dpNgaySinh.Size = new System.Drawing.Size(252, 22);
            this.dpNgaySinh.TabIndex = 2;
            this.dpNgaySinh.Value = new System.DateTime(2002, 12, 31, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bằng cấp:";
            // 
            // cbBangCap
            // 
            this.cbBangCap.FormattingEnabled = true;
            this.cbBangCap.Location = new System.Drawing.Point(115, 125);
            this.cbBangCap.Name = "cbBangCap";
            this.cbBangCap.Size = new System.Drawing.Size(252, 24);
            this.cbBangCap.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNV);
            this.groupBox1.Location = new System.Drawing.Point(86, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 240);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chung";
            // 
            // dgvNV
            // 
            this.dgvNV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvNV.Location = new System.Drawing.Point(3, 18);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.RowHeadersWidth = 51;
            this.dgvNV.RowTemplate.Height = 24;
            this.dgvNV.Size = new System.Drawing.Size(831, 219);
            this.dgvNV.TabIndex = 0;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(115, 180);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 36);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(200, 180);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 36);
            this.btSua.TabIndex = 2;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(292, 180);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 36);
            this.btXoa.TabIndex = 2;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(506, 180);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 36);
            this.btLuu.TabIndex = 2;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(587, 180);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(75, 36);
            this.btHuy.TabIndex = 2;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.LightCoral;
            this.btBack.Location = new System.Drawing.Point(932, 79);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 36);
            this.btBack.TabIndex = 2;
            this.btBack.Text = "Trở về";
            this.btBack.UseVisualStyleBackColor = false;
            // 
            // FormNV
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.ClientSize = new System.Drawing.Size(1041, 590);
            //this.Controls.Add(this.btBack);
            //this.Controls.Add(this.groupBox1);
            //this.Controls.Add(this.gbThongTinNV);
            //this.Controls.Add(this.lbQLNV);
            //this.MaximizeBox = false;
            //this.Name = "FormNV";
            //this.Text = "Quản lý nhân viên";
            //this.Load += new System.EventHandler(this.Form1_Load);
            //this.gbThongTinNV.ResumeLayout(false);
            //this.gbThongTinNV.PerformLayout();
            //this.groupBox1.ResumeLayout(false);
            //((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            //this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbQLNV;
        private System.Windows.Forms.GroupBox gbThongTinNV;
        private System.Windows.Forms.DateTimePicker dpNgaySinh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBangCap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btBack;
    }
}

