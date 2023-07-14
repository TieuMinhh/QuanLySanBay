namespace QL_SANBAY
{
    partial class frmNhanVienBaoTri
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
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label mADANGKYLabel;
            System.Windows.Forms.Label mADICHVULabel;
            System.Windows.Forms.Label nGAYLabel;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.bAOTRIGridControl = new DevExpress.XtraGrid.GridControl();
            this.bAOTRIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSSB = new QL_SANBAY.DSSB();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMADANGKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMADICHVU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOGIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOIDUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnGhi = new System.Windows.Forms.Button();
            this.bntThem = new System.Windows.Forms.Button();
            this.txtCMND = new DevExpress.XtraEditors.TextEdit();
            this.cTNHANVIENBAOTRIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaDK = new DevExpress.XtraEditors.TextEdit();
            this.txtMaDV = new DevExpress.XtraEditors.TextEdit();
            this.txtNgay = new DevExpress.XtraEditors.DateEdit();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxNhanVien = new System.Windows.Forms.ComboBox();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.cTNHANVIENBAOTRIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMADANGKY1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMADICHVU1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bAOTRITableAdapter = new QL_SANBAY.DSSBTableAdapters.BAOTRITableAdapter();
            this.tableAdapterManager = new QL_SANBAY.DSSBTableAdapters.TableAdapterManager();
            this.cTNHANVIENBAOTRITableAdapter = new QL_SANBAY.DSSBTableAdapters.CTNHANVIENBAOTRITableAdapter();
            cMNDLabel = new System.Windows.Forms.Label();
            mADANGKYLabel = new System.Windows.Forms.Label();
            mADICHVULabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAOTRIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAOTRIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTNHANVIENBAOTRIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTNHANVIENBAOTRIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(50, 240);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(51, 17);
            cMNDLabel.TabIndex = 11;
            cMNDLabel.Text = "CMND:";
            // 
            // mADANGKYLabel
            // 
            mADANGKYLabel.AutoSize = true;
            mADANGKYLabel.Location = new System.Drawing.Point(32, 40);
            mADANGKYLabel.Name = "mADANGKYLabel";
            mADANGKYLabel.Size = new System.Drawing.Size(87, 17);
            mADANGKYLabel.TabIndex = 13;
            mADANGKYLabel.Text = "Mã Đăng Ký:";
            // 
            // mADICHVULabel
            // 
            mADICHVULabel.AutoSize = true;
            mADICHVULabel.Location = new System.Drawing.Point(32, 90);
            mADICHVULabel.Name = "mADICHVULabel";
            mADICHVULabel.Size = new System.Drawing.Size(81, 17);
            mADICHVULabel.TabIndex = 15;
            mADICHVULabel.Text = "Mã Dịch Vụ:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(50, 140);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(45, 17);
            nGAYLabel.TabIndex = 17;
            nGAYLabel.Text = "Ngày:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.bAOTRIGridControl);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1101, 324);
            this.panelControl1.TabIndex = 0;
            // 
            // bAOTRIGridControl
            // 
            this.bAOTRIGridControl.DataSource = this.bAOTRIBindingSource;
            this.bAOTRIGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bAOTRIGridControl.Location = new System.Drawing.Point(2, 2);
            this.bAOTRIGridControl.MainView = this.gridView1;
            this.bAOTRIGridControl.Name = "bAOTRIGridControl";
            this.bAOTRIGridControl.Size = new System.Drawing.Size(1097, 320);
            this.bAOTRIGridControl.TabIndex = 0;
            this.bAOTRIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bAOTRIBindingSource
            // 
            this.bAOTRIBindingSource.DataMember = "BAOTRI";
            this.bAOTRIBindingSource.DataSource = this.dSSB;
            // 
            // dSSB
            // 
            this.dSSB.DataSetName = "DSSB";
            this.dSSB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMADANGKY,
            this.colMADICHVU,
            this.colNGAY,
            this.colSOGIO,
            this.colNOIDUNG});
            this.gridView1.GridControl = this.bAOTRIGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMADANGKY
            // 
            this.colMADANGKY.FieldName = "MADANGKY";
            this.colMADANGKY.MinWidth = 25;
            this.colMADANGKY.Name = "colMADANGKY";
            this.colMADANGKY.Visible = true;
            this.colMADANGKY.VisibleIndex = 0;
            this.colMADANGKY.Width = 94;
            // 
            // colMADICHVU
            // 
            this.colMADICHVU.FieldName = "MADICHVU";
            this.colMADICHVU.MinWidth = 25;
            this.colMADICHVU.Name = "colMADICHVU";
            this.colMADICHVU.Visible = true;
            this.colMADICHVU.VisibleIndex = 1;
            this.colMADICHVU.Width = 94;
            // 
            // colNGAY
            // 
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 25;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 2;
            this.colNGAY.Width = 94;
            // 
            // colSOGIO
            // 
            this.colSOGIO.FieldName = "SOGIO";
            this.colSOGIO.MinWidth = 25;
            this.colSOGIO.Name = "colSOGIO";
            this.colSOGIO.Visible = true;
            this.colSOGIO.VisibleIndex = 3;
            this.colSOGIO.Width = 94;
            // 
            // colNOIDUNG
            // 
            this.colNOIDUNG.FieldName = "NOIDUNG";
            this.colNOIDUNG.MinWidth = 25;
            this.colNOIDUNG.Name = "colNOIDUNG";
            this.colNOIDUNG.Visible = true;
            this.colNOIDUNG.VisibleIndex = 4;
            this.colNOIDUNG.Width = 94;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnGhi);
            this.panelControl2.Controls.Add(this.bntThem);
            this.panelControl2.Controls.Add(cMNDLabel);
            this.panelControl2.Controls.Add(this.txtCMND);
            this.panelControl2.Controls.Add(mADANGKYLabel);
            this.panelControl2.Controls.Add(this.txtMaDK);
            this.panelControl2.Controls.Add(mADICHVULabel);
            this.panelControl2.Controls.Add(this.txtMaDV);
            this.panelControl2.Controls.Add(nGAYLabel);
            this.panelControl2.Controls.Add(this.txtNgay);
            this.panelControl2.Controls.Add(this.btnHuy);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.cbxNhanVien);
            this.panelControl2.Location = new System.Drawing.Point(12, 367);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(446, 331);
            this.panelControl2.TabIndex = 1;
            // 
            // btnGhi
            // 
            this.btnGhi.Enabled = false;
            this.btnGhi.Location = new System.Drawing.Point(300, 285);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(130, 30);
            this.btnGhi.TabIndex = 20;
            this.btnGhi.Text = "Xác nhận";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // bntThem
            // 
            this.bntThem.Location = new System.Drawing.Point(10, 285);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(130, 30);
            this.bntThem.TabIndex = 19;
            this.bntThem.Text = "Thêm nhân viên";
            this.bntThem.UseVisualStyleBackColor = true;
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // txtCMND
            // 
            this.txtCMND.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTNHANVIENBAOTRIBindingSource, "CMND", true));
            this.txtCMND.Enabled = false;
            this.txtCMND.Location = new System.Drawing.Point(150, 235);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(207, 22);
            this.txtCMND.TabIndex = 12;
            this.txtCMND.EditValueChanged += new System.EventHandler(this.txtCMND_EditValueChanged);
            // 
            // cTNHANVIENBAOTRIBindingSource
            // 
            this.cTNHANVIENBAOTRIBindingSource.DataMember = "FK_CTNHANVIENBAOTRI_BAOTRI1";
            this.cTNHANVIENBAOTRIBindingSource.DataSource = this.bAOTRIBindingSource;
            // 
            // txtMaDK
            // 
            this.txtMaDK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTNHANVIENBAOTRIBindingSource, "MADANGKY", true));
            this.txtMaDK.Enabled = false;
            this.txtMaDK.Location = new System.Drawing.Point(150, 35);
            this.txtMaDK.Name = "txtMaDK";
            this.txtMaDK.Size = new System.Drawing.Size(207, 22);
            this.txtMaDK.TabIndex = 14;
            // 
            // txtMaDV
            // 
            this.txtMaDV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTNHANVIENBAOTRIBindingSource, "MADICHVU", true));
            this.txtMaDV.Enabled = false;
            this.txtMaDV.Location = new System.Drawing.Point(150, 85);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(207, 22);
            this.txtMaDV.TabIndex = 16;
            // 
            // txtNgay
            // 
            this.txtNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTNHANVIENBAOTRIBindingSource, "NGAY", true));
            this.txtNgay.Enabled = false;
            this.txtNgay.Location = new System.Drawing.Point(150, 135);
            this.txtNgay.Name = "txtNgay";
            // 
            // 
            // 
            this.txtNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            // 
            // 
            // 
            this.txtNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Size = new System.Drawing.Size(207, 22);
            this.txtNgay.TabIndex = 18;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(155, 285);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(130, 30);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy nhân viên";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Chọn nhân viên:";
            // 
            // cbxNhanVien
            // 
            this.cbxNhanVien.Enabled = false;
            this.cbxNhanVien.FormattingEnabled = true;
            this.cbxNhanVien.Location = new System.Drawing.Point(150, 185);
            this.cbxNhanVien.Name = "cbxNhanVien";
            this.cbxNhanVien.Size = new System.Drawing.Size(207, 24);
            this.cbxNhanVien.TabIndex = 8;
            this.cbxNhanVien.SelectedIndexChanged += new System.EventHandler(this.cbxNhanVien_SelectedIndexChanged);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.cTNHANVIENBAOTRIGridControl);
            this.panelControl3.Location = new System.Drawing.Point(449, 367);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(664, 327);
            this.panelControl3.TabIndex = 2;
            // 
            // cTNHANVIENBAOTRIGridControl
            // 
            this.cTNHANVIENBAOTRIGridControl.DataSource = this.cTNHANVIENBAOTRIBindingSource;
            this.cTNHANVIENBAOTRIGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cTNHANVIENBAOTRIGridControl.Location = new System.Drawing.Point(2, 2);
            this.cTNHANVIENBAOTRIGridControl.MainView = this.gridView2;
            this.cTNHANVIENBAOTRIGridControl.Name = "cTNHANVIENBAOTRIGridControl";
            this.cTNHANVIENBAOTRIGridControl.Size = new System.Drawing.Size(660, 323);
            this.cTNHANVIENBAOTRIGridControl.TabIndex = 0;
            this.cTNHANVIENBAOTRIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCMND,
            this.colMADANGKY1,
            this.colMADICHVU1,
            this.colNGAY1});
            this.gridView2.GridControl = this.cTNHANVIENBAOTRIGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 25;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 0;
            this.colCMND.Width = 94;
            // 
            // colMADANGKY1
            // 
            this.colMADANGKY1.FieldName = "MADANGKY";
            this.colMADANGKY1.MinWidth = 25;
            this.colMADANGKY1.Name = "colMADANGKY1";
            this.colMADANGKY1.Visible = true;
            this.colMADANGKY1.VisibleIndex = 1;
            this.colMADANGKY1.Width = 94;
            // 
            // colMADICHVU1
            // 
            this.colMADICHVU1.FieldName = "MADICHVU";
            this.colMADICHVU1.MinWidth = 25;
            this.colMADICHVU1.Name = "colMADICHVU1";
            this.colMADICHVU1.Visible = true;
            this.colMADICHVU1.VisibleIndex = 2;
            this.colMADICHVU1.Width = 94;
            // 
            // colNGAY1
            // 
            this.colNGAY1.FieldName = "NGAY";
            this.colNGAY1.MinWidth = 25;
            this.colNGAY1.Name = "colNGAY1";
            this.colNGAY1.Visible = true;
            this.colNGAY1.VisibleIndex = 3;
            this.colNGAY1.Width = 94;
            // 
            // bAOTRITableAdapter
            // 
            this.bAOTRITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAOTRITableAdapter = this.bAOTRITableAdapter;
            this.tableAdapterManager.CHUTableAdapter = null;
            this.tableAdapterManager.CHUYENVETableAdapter = null;
            this.tableAdapterManager.CTNHANVIENBAOTRITableAdapter = this.cTNHANVIENBAOTRITableAdapter;
            this.tableAdapterManager.DICHVUBAOTRITableAdapter = null;
            this.tableAdapterManager.DOANHNGHIEPTableAdapter = null;
            this.tableAdapterManager.LAITableAdapter = null;
            this.tableAdapterManager.LOAITableAdapter = null;
            this.tableAdapterManager.MAYBAYTableAdapter = null;
            this.tableAdapterManager.NGUOITableAdapter = null;
            this.tableAdapterManager.NHACHUATableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHICONGTableAdapter = null;
            this.tableAdapterManager.SOHUUTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QL_SANBAY.DSSBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cTNHANVIENBAOTRITableAdapter
            // 
            this.cTNHANVIENBAOTRITableAdapter.ClearBeforeFill = true;
            // 
            // frmNhanVienBaoTri
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 717);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmNhanVienBaoTri";
            this.Text = "frmNhanVienBaoTri";
            this.Load += new System.EventHandler(this.frmNhanVienBaoTri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAOTRIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAOTRIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTNHANVIENBAOTRIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTNHANVIENBAOTRIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DSSB dSSB;
        private System.Windows.Forms.BindingSource bAOTRIBindingSource;
        private DSSBTableAdapters.BAOTRITableAdapter bAOTRITableAdapter;
        private DSSBTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl bAOTRIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMADANGKY;
        private DevExpress.XtraGrid.Columns.GridColumn colMADICHVU;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colSOGIO;
        private DevExpress.XtraGrid.Columns.GridColumn colNOIDUNG;
        private DSSBTableAdapters.CTNHANVIENBAOTRITableAdapter cTNHANVIENBAOTRITableAdapter;
        private System.Windows.Forms.BindingSource cTNHANVIENBAOTRIBindingSource;
        private System.Windows.Forms.Button bntThem;
        private DevExpress.XtraEditors.TextEdit txtCMND;
        private DevExpress.XtraEditors.TextEdit txtMaDK;
        private DevExpress.XtraEditors.TextEdit txtMaDV;
        private DevExpress.XtraEditors.DateEdit txtNgay;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxNhanVien;
        private DevExpress.XtraGrid.GridControl cTNHANVIENBAOTRIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colMADANGKY1;
        private DevExpress.XtraGrid.Columns.GridColumn colMADICHVU1;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY1;
        private System.Windows.Forms.Button btnGhi;
    }
}