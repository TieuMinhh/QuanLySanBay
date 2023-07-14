namespace QL_SANBAY
{
    partial class frmDoiMatKhau
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
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.txtMatKhauXacNhan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauCu.Location = new System.Drawing.Point(243, 43);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.Size = new System.Drawing.Size(341, 27);
            this.txtMatKhauCu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập Mật Khẩu Cũ : ";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.btnXacNhan);
            this.panelControl1.Controls.Add(this.txtMatKhauXacNhan);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.txtMatKhauMoi);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.txtMatKhauCu);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Location = new System.Drawing.Point(196, 55);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(689, 332);
            this.panelControl1.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(410, 280);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 30);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(300, 280);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(100, 30);
            this.btnXacNhan.TabIndex = 6;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtMatKhauXacNhan
            // 
            this.txtMatKhauXacNhan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauXacNhan.Location = new System.Drawing.Point(243, 213);
            this.txtMatKhauXacNhan.Name = "txtMatKhauXacNhan";
            this.txtMatKhauXacNhan.Size = new System.Drawing.Size(341, 27);
            this.txtMatKhauXacNhan.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Xác Nhận Mật Khẩu :";
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauMoi.Location = new System.Drawing.Point(243, 125);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(341, 27);
            this.txtMatKhauMoi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập Mật Khẩu Mới :";
            // 
            // frmDoiMatKhau
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 575);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmDoiMatKhau";
            this.Text = "DoiMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox txtMatKhauXacNhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXacNhan;
    }
}