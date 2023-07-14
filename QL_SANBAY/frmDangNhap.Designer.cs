namespace QL_SANBAY
{
    partial class frmDangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu :";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.Lime;
            this.btnDangNhap.Location = new System.Drawing.Point(264, 190);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(109, 35);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(182, 49);
            this.txtTenDN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(377, 23);
            this.txtTenDN.TabIndex = 4;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Lime;
            this.btnThoat.Location = new System.Drawing.Point(400, 190);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(84, 35);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(580, 119);
            this.btnHienThi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(101, 28);
            this.btnHienThi.TabIndex = 7;
            this.btnHienThi.Text = "Hiện / ẩn";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(182, 123);
            this.txtMK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(377, 23);
            this.txtMK.TabIndex = 5;
            this.txtMK.UseSystemPasswordChar = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.btnHienThi);
            this.panelControl1.Controls.Add(this.btnDangNhap);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.txtTenDN);
            this.panelControl1.Controls.Add(this.txtMK);
            this.panelControl1.Location = new System.Drawing.Point(227, 129);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(738, 284);
            this.panelControl1.TabIndex = 8;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Location = new System.Drawing.Point(227, 57);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(738, 52);
            this.panelControl2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(287, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "ĐĂNG NHẬP";
            // 
            // frmDangNhap
            // 
            this.Appearance.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 503);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmDangNhap";
            this.Text = "frmDangNhap";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.TextBox txtMK;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label3;
    }
}