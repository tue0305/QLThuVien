namespace QLThuVien
{
    partial class btFormSach
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btFormDocGia = new System.Windows.Forms.Button();
            this.btFormNhanVien = new System.Windows.Forms.Button();
            this.btFormMuonTra = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btFormDocGia);
            this.groupBox1.Controls.Add(this.btFormNhanVien);
            this.groupBox1.Controls.Add(this.btFormMuonTra);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(41, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 444);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu Chính";
            // 
            // btFormDocGia
            // 
            this.btFormDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFormDocGia.Location = new System.Drawing.Point(62, 237);
            this.btFormDocGia.Name = "btFormDocGia";
            this.btFormDocGia.Size = new System.Drawing.Size(244, 168);
            this.btFormDocGia.TabIndex = 0;
            this.btFormDocGia.Text = "Quản lý đọc giả";
            this.btFormDocGia.UseVisualStyleBackColor = true;
            // 
            // btFormNhanVien
            // 
            this.btFormNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFormNhanVien.Location = new System.Drawing.Point(62, 36);
            this.btFormNhanVien.Name = "btFormNhanVien";
            this.btFormNhanVien.Size = new System.Drawing.Size(244, 168);
            this.btFormNhanVien.TabIndex = 0;
            this.btFormNhanVien.Text = "Quản lý nhân viên";
            this.btFormNhanVien.UseVisualStyleBackColor = true;
            // 
            // btFormMuonTra
            // 
            this.btFormMuonTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFormMuonTra.Location = new System.Drawing.Point(449, 237);
            this.btFormMuonTra.Name = "btFormMuonTra";
            this.btFormMuonTra.Size = new System.Drawing.Size(244, 168);
            this.btFormMuonTra.TabIndex = 0;
            this.btFormMuonTra.Text = "Quản lý mượn trả";
            this.btFormMuonTra.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(449, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 168);
            this.button1.TabIndex = 0;
            this.button1.Text = "Quản lý sách";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(904, 64);
            this.label1.TabIndex = 5;
            this.label1.Text = "QUẢN LÝ THƯ VIỆN:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btThoat.Location = new System.Drawing.Point(794, 503);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(94, 36);
            this.btThoat.TabIndex = 0;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btFormSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btThoat);
            this.Name = "btFormSach";
            this.Text = "FormMainMenu";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btFormDocGia;
        private System.Windows.Forms.Button btFormNhanVien;
        private System.Windows.Forms.Button btFormMuonTra;
        private System.Windows.Forms.Button btThoat;
    }
}