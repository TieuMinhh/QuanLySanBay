namespace QL_SANBAY
{
    partial class frmTaoTaiKhoan
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxHoTen = new System.Windows.Forms.ComboBox();
            this.cbxDoiTuong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.btnXacNhan);
            this.panelControl1.Controls.Add(this.txtCMND);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.cbxHoTen);
            this.panelControl1.Controls.Add(this.cbxDoiTuong);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.txtMatKhau);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.txtTenTK);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Location = new System.Drawing.Point(174, 56);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(790, 441);
            this.panelControl1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(640, 398);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 30);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(522, 398);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(100, 30);
            this.btnXacNhan.TabIndex = 10;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtCMND
            // 
            this.txtCMND.Enabled = false;
            this.txtCMND.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(237, 346);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(300, 27);
            this.txtCMND.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "CMND :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Họ Tên :";
            // 
            // cbxHoTen
            // 
            this.cbxHoTen.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxHoTen.FormattingEnabled = true;
            this.cbxHoTen.Location = new System.Drawing.Point(237, 279);
            this.cbxHoTen.Name = "cbxHoTen";
            this.cbxHoTen.Size = new System.Drawing.Size(300, 27);
            this.cbxHoTen.TabIndex = 6;
            this.cbxHoTen.SelectedIndexChanged += new System.EventHandler(this.cbxHoTen_SelectedIndexChanged);
            // 
            // cbxDoiTuong
            // 
            this.cbxDoiTuong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDoiTuong.FormattingEnabled = true;
            this.cbxDoiTuong.Items.AddRange(new object[] {
            "Chủ máy bay",
            "Phi công",
            "Nhân viên"});
            this.cbxDoiTuong.Location = new System.Drawing.Point(238, 209);
            this.cbxDoiTuong.Name = "cbxDoiTuong";
            this.cbxDoiTuong.Size = new System.Drawing.Size(300, 27);
            this.cbxDoiTuong.TabIndex = 5;
            this.cbxDoiTuong.SelectedIndexChanged += new System.EventHandler(this.cbxDoiTuong_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đối Tượng :";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(237, 127);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(300, 27);
            this.txtMatKhau.TabIndex = 3;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật Khẩu :";
            // 
            // txtTenTK
            // 
            this.txtTenTK.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTK.Location = new System.Drawing.Point(237, 56);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(300, 27);
            this.txtTenTK.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Tài Khoản :";
            // 
            // frmTaoTaiKhoan
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 648);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmTaoTaiKhoan";
            this.Text = "frmTaoTaiKhoan";
            this.Load += new System.EventHandler(this.frmTaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxHoTen;
        private System.Windows.Forms.ComboBox cbxDoiTuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXacNhan;
    }
}