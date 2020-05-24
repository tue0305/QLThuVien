namespace QLThuVien
{
    partial class FormSach
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
            this.btTroVe = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.dpNamXB = new System.Windows.Forms.DateTimePicker();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btHuy = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTriGia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btTroVe
            // 
            this.btTroVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btTroVe.ForeColor = System.Drawing.Color.Black;
            this.btTroVe.Location = new System.Drawing.Point(904, 591);
            this.btTroVe.Name = "btTroVe";
            this.btTroVe.Size = new System.Drawing.Size(91, 37);
            this.btTroVe.TabIndex = 7;
            this.btTroVe.Text = "Trở về";
            this.btTroVe.UseVisualStyleBackColor = false;
            this.btTroVe.Click += new System.EventHandler(this.btTroVe_Click);
            // 
            // btLuu
            // 
            this.btLuu.ForeColor = System.Drawing.Color.Black;
            this.btLuu.Location = new System.Drawing.Point(904, 329);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(91, 37);
            this.btLuu.TabIndex = 8;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // dpNamXB
            // 
            this.dpNamXB.CustomFormat = " yyyy";
            this.dpNamXB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpNamXB.Location = new System.Drawing.Point(514, 30);
            this.dpNamXB.Name = "dpNamXB";
            this.dpNamXB.Size = new System.Drawing.Size(135, 22);
            this.dpNamXB.TabIndex = 4;
            // 
            // txtNXB
            // 
            this.txtNXB.Location = new System.Drawing.Point(514, 87);
            this.txtNXB.Multiline = true;
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(194, 64);
            this.txtNXB.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(34, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giá trị:";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(134, 83);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(214, 22);
            this.txtTacGia.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(409, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Năm xuất bản:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(409, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nhà xuất bản:";
            // 
            // btXoa
            // 
            this.btXoa.ForeColor = System.Drawing.Color.Black;
            this.btXoa.Location = new System.Drawing.Point(813, 209);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 37);
            this.btXoa.TabIndex = 9;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.ForeColor = System.Drawing.Color.Black;
            this.btSua.Location = new System.Drawing.Point(813, 152);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 37);
            this.btSua.TabIndex = 10;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.ForeColor = System.Drawing.Color.Black;
            this.btThem.Location = new System.Drawing.Point(813, 92);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 37);
            this.btThem.TabIndex = 11;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // dgvSach
            // 
            this.dgvSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(0, 21);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.RowTemplate.Height = 24;
            this.dgvSach.Size = new System.Drawing.Size(848, 300);
            this.dgvSach.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tác giả:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(134, 33);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(214, 22);
            this.txtTen.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(34, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sách:";
            // 
            // btHuy
            // 
            this.btHuy.ForeColor = System.Drawing.Color.Black;
            this.btHuy.Location = new System.Drawing.Point(904, 393);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(91, 37);
            this.btHuy.TabIndex = 12;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSach);
            this.groupBox2.Location = new System.Drawing.Point(28, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(860, 327);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kho sách";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dpNamXB);
            this.groupBox1.Controls.Add(this.txtNXB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTriGia);
            this.groupBox1.Controls.Add(this.txtTacGia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(28, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 194);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sách";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1006, 64);
            this.label1.TabIndex = 4;
            this.label1.Text = "QUẢN LÝ SÁCH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTriGia
            // 
            this.txtTriGia.Location = new System.Drawing.Point(134, 127);
            this.txtTriGia.Name = "txtTriGia";
            this.txtTriGia.Size = new System.Drawing.Size(214, 22);
            this.txtTriGia.TabIndex = 2;
            // 
            // FormSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 642);
            this.Controls.Add(this.btTroVe);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormSach";
            this.Text = "FormSach";
            this.Load += new System.EventHandler(this.FormSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btTroVe;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.DateTimePicker dpNamXB;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTriGia;
    }
}