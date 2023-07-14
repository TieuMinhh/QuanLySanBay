namespace QL_SANBAY
{
    partial class frmChiTietNhanVienBaoTri
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
            this.label6 = new System.Windows.Forms.Label();
            this.lbCMND = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbHoten = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label7 = new System.Windows.Forms.Label();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.CTNhanVienBaoTriGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTNhanVienBaoTriGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.lbCMND);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.lbHoten);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1097, 73);
            this.panelControl1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(910, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "NHÂN VIÊN";
            // 
            // lbCMND
            // 
            this.lbCMND.AutoSize = true;
            this.lbCMND.Location = new System.Drawing.Point(165, 34);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(42, 17);
            this.lbCMND.TabIndex = 4;
            this.lbCMND.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Họ Tên :";
            // 
            // lbHoten
            // 
            this.lbHoten.AutoSize = true;
            this.lbHoten.Location = new System.Drawing.Point(500, 34);
            this.lbHoten.Name = "lbHoten";
            this.lbHoten.Size = new System.Drawing.Size(42, 17);
            this.lbHoten.TabIndex = 2;
            this.lbHoten.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(809, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chức Vụ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CMND :";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label7);
            this.panelControl2.Location = new System.Drawing.Point(12, 108);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1097, 49);
            this.panelControl2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(390, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(350, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "DANH SÁCH CHI TIẾT BẢO TRÌ CỦA NHÂN VIÊN";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.CTNhanVienBaoTriGridControl);
            this.panelControl3.Location = new System.Drawing.Point(12, 181);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1097, 398);
            this.panelControl3.TabIndex = 2;
            // 
            // CTNhanVienBaoTriGridControl
            // 
            this.CTNhanVienBaoTriGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CTNhanVienBaoTriGridControl.Location = new System.Drawing.Point(2, 2);
            this.CTNhanVienBaoTriGridControl.MainView = this.gridView1;
            this.CTNhanVienBaoTriGridControl.Name = "CTNhanVienBaoTriGridControl";
            this.CTNhanVienBaoTriGridControl.Size = new System.Drawing.Size(1093, 394);
            this.CTNhanVienBaoTriGridControl.TabIndex = 0;
            this.CTNhanVienBaoTriGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.CTNhanVienBaoTriGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // frmChiTietNhanVienBaoTri
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 610);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmChiTietNhanVienBaoTri";
            this.Text = "frmChiTietNhanVienBaoTri";
            this.Load += new System.EventHandler(this.frmChiTietNhanVienBaoTri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTNhanVienBaoTriGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbCMND;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbHoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl CTNhanVienBaoTriGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}