namespace QL_SANBAY
{
    partial class frmNhanVien
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
            System.Windows.Forms.Label hOTENLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label lUONGLabel;
            System.Windows.Forms.Label cALAMLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sP_DANHSACH_NHANVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.sP_DANHSACH_NHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSSB = new QL_SANBAY.DSSB();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCALAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtCMND = new DevExpress.XtraEditors.TextEdit();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtLuong = new DevExpress.XtraEditors.TextEdit();
            this.txtCaLam = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.sP_DANHSACH_NHANVIENTableAdapter = new QL_SANBAY.DSSBTableAdapters.SP_DANHSACH_NHANVIENTableAdapter();
            this.tableAdapterManager = new QL_SANBAY.DSSBTableAdapters.TableAdapterManager();
            this.cHUYENVEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHUYENVETableAdapter = new QL_SANBAY.DSSBTableAdapters.CHUYENVETableAdapter();
            this.cTNHANVIENBAOTRIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTNHANVIENBAOTRITableAdapter = new QL_SANBAY.DSSBTableAdapters.CTNHANVIENBAOTRITableAdapter();
            cMNDLabel = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            lUONGLabel = new System.Windows.Forms.Label();
            cALAMLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DANHSACH_NHANVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DANHSACH_NHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaLam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENVEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTNHANVIENBAOTRIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(98, 70);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(51, 17);
            cMNDLabel.TabIndex = 1;
            cMNDLabel.Text = "CMND:";
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Location = new System.Drawing.Point(98, 116);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(58, 17);
            hOTENLabel.TabIndex = 3;
            hOTENLabel.Text = "Họ tên :";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(98, 162);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(43, 17);
            sDTLabel.TabIndex = 5;
            sDTLabel.Text = "SDT :";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(621, 65);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(57, 17);
            dIACHILabel.TabIndex = 7;
            dIACHILabel.Text = "Địa chỉ :";
            // 
            // lUONGLabel
            // 
            lUONGLabel.AutoSize = true;
            lUONGLabel.Location = new System.Drawing.Point(621, 115);
            lUONGLabel.Name = "lUONGLabel";
            lUONGLabel.Size = new System.Drawing.Size(57, 17);
            lUONGLabel.TabIndex = 9;
            lUONGLabel.Text = "Lương :";
            // 
            // cALAMLabel
            // 
            cALAMLabel.AutoSize = true;
            cALAMLabel.Location = new System.Drawing.Point(621, 163);
            cALAMLabel.Name = "cALAMLabel";
            cALAMLabel.Size = new System.Drawing.Size(58, 17);
            cALAMLabel.TabIndex = 11;
            cALAMLabel.Text = "Ca làm :";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnGhi,
            this.btnHuy,
            this.btnLamMoi,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar1.FloatLocation = new System.Drawing.Point(358, 791);
            this.bar1.Offset = 1;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Xác nhận";
            this.btnGhi.Enabled = false;
            this.btnGhi.Id = 3;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Enabled = false;
            this.btnHuy.Id = 4;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.LargeImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm mới";
            this.btnLamMoi.Id = 5;
            this.btnLamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.Image")));
            this.btnLamMoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.LargeImage")));
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLamMoi_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 6;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1166, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 766);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1166, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 766);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1166, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 766);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sP_DANHSACH_NHANVIENGridControl);
            this.panelControl1.Location = new System.Drawing.Point(12, 37);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1142, 468);
            this.panelControl1.TabIndex = 4;
            // 
            // sP_DANHSACH_NHANVIENGridControl
            // 
            this.sP_DANHSACH_NHANVIENGridControl.DataSource = this.sP_DANHSACH_NHANVIENBindingSource;
            this.sP_DANHSACH_NHANVIENGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_DANHSACH_NHANVIENGridControl.Location = new System.Drawing.Point(2, 2);
            this.sP_DANHSACH_NHANVIENGridControl.MainView = this.gridView1;
            this.sP_DANHSACH_NHANVIENGridControl.MenuManager = this.barManager1;
            this.sP_DANHSACH_NHANVIENGridControl.Name = "sP_DANHSACH_NHANVIENGridControl";
            this.sP_DANHSACH_NHANVIENGridControl.Size = new System.Drawing.Size(1138, 464);
            this.sP_DANHSACH_NHANVIENGridControl.TabIndex = 0;
            this.sP_DANHSACH_NHANVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sP_DANHSACH_NHANVIENBindingSource
            // 
            this.sP_DANHSACH_NHANVIENBindingSource.DataMember = "SP_DANHSACH_NHANVIEN";
            this.sP_DANHSACH_NHANVIENBindingSource.DataSource = this.dSSB;
            // 
            // dSSB
            // 
            this.dSSB.DataSetName = "DSSB";
            this.dSSB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCMND,
            this.colHOTEN,
            this.colSDT,
            this.colDIACHI,
            this.colLUONG,
            this.colCALAM});
            this.gridView1.GridControl = this.sP_DANHSACH_NHANVIENGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 25;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 0;
            this.colCMND.Width = 133;
            // 
            // colHOTEN
            // 
            this.colHOTEN.Caption = "Họ tên";
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.MinWidth = 25;
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 1;
            this.colHOTEN.Width = 250;
            // 
            // colSDT
            // 
            this.colSDT.Caption = "Số điện thoại";
            this.colSDT.FieldName = "SDT";
            this.colSDT.MinWidth = 25;
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 2;
            this.colSDT.Width = 94;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 260;
            // 
            // colLUONG
            // 
            this.colLUONG.Caption = "Lương";
            this.colLUONG.FieldName = "LUONG";
            this.colLUONG.MinWidth = 25;
            this.colLUONG.Name = "colLUONG";
            this.colLUONG.Visible = true;
            this.colLUONG.VisibleIndex = 4;
            this.colLUONG.Width = 168;
            // 
            // colCALAM
            // 
            this.colCALAM.Caption = "Ca làm";
            this.colCALAM.FieldName = "CALAM";
            this.colCALAM.MinWidth = 25;
            this.colCALAM.Name = "colCALAM";
            this.colCALAM.Visible = true;
            this.colCALAM.VisibleIndex = 5;
            this.colCALAM.Width = 94;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(cMNDLabel);
            this.panelControl2.Controls.Add(this.txtCMND);
            this.panelControl2.Controls.Add(hOTENLabel);
            this.panelControl2.Controls.Add(this.txtHoTen);
            this.panelControl2.Controls.Add(sDTLabel);
            this.panelControl2.Controls.Add(this.txtSDT);
            this.panelControl2.Controls.Add(dIACHILabel);
            this.panelControl2.Controls.Add(this.txtDiaChi);
            this.panelControl2.Controls.Add(lUONGLabel);
            this.panelControl2.Controls.Add(this.txtLuong);
            this.panelControl2.Controls.Add(cALAMLabel);
            this.panelControl2.Controls.Add(this.txtCaLam);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Enabled = false;
            this.panelControl2.Location = new System.Drawing.Point(12, 456);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1140, 269);
            this.panelControl2.TabIndex = 5;
            // 
            // txtCMND
            // 
            this.txtCMND.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_DANHSACH_NHANVIENBindingSource, "CMND", true));
            this.txtCMND.Enabled = false;
            this.txtCMND.Location = new System.Drawing.Point(180, 65);
            this.txtCMND.MenuManager = this.barManager1;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(340, 22);
            this.txtCMND.TabIndex = 2;
            // 
            // txtHoTen
            // 
            this.txtHoTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_DANHSACH_NHANVIENBindingSource, "HOTEN", true));
            this.txtHoTen.Location = new System.Drawing.Point(180, 114);
            this.txtHoTen.MenuManager = this.barManager1;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(340, 22);
            this.txtHoTen.TabIndex = 4;
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_DANHSACH_NHANVIENBindingSource, "SDT", true));
            this.txtSDT.Location = new System.Drawing.Point(180, 163);
            this.txtSDT.MenuManager = this.barManager1;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(340, 22);
            this.txtSDT.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_DANHSACH_NHANVIENBindingSource, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(700, 65);
            this.txtDiaChi.MenuManager = this.barManager1;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(340, 22);
            this.txtDiaChi.TabIndex = 8;
            // 
            // txtLuong
            // 
            this.txtLuong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_DANHSACH_NHANVIENBindingSource, "LUONG", true));
            this.txtLuong.Location = new System.Drawing.Point(700, 114);
            this.txtLuong.MenuManager = this.barManager1;
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(340, 22);
            this.txtLuong.TabIndex = 10;
            // 
            // txtCaLam
            // 
            this.txtCaLam.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_DANHSACH_NHANVIENBindingSource, "CALAM", true));
            this.txtCaLam.Location = new System.Drawing.Point(700, 163);
            this.txtCaLam.MenuManager = this.barManager1;
            this.txtCaLam.Name = "txtCaLam";
            this.txtCaLam.Size = new System.Drawing.Size(340, 22);
            this.txtCaLam.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(460, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN CHI TIẾT NHÂN VIÊN";
            // 
            // sP_DANHSACH_NHANVIENTableAdapter
            // 
            this.sP_DANHSACH_NHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAOTRITableAdapter = null;
            this.tableAdapterManager.CHUTableAdapter = null;
            this.tableAdapterManager.CHUYENVETableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CTNHANVIENBAOTRITableAdapter = null;
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
            // cHUYENVEBindingSource
            // 
            this.cHUYENVEBindingSource.DataMember = "FK_SP_DANHSACH_NHANVIEN_CHUYENVE";
            this.cHUYENVEBindingSource.DataSource = this.sP_DANHSACH_NHANVIENBindingSource;
            // 
            // cHUYENVETableAdapter
            // 
            this.cHUYENVETableAdapter.ClearBeforeFill = true;
            // 
            // cTNHANVIENBAOTRIBindingSource
            // 
            this.cTNHANVIENBAOTRIBindingSource.DataMember = "FK_SP_DANHSACH_NHANVIEN_CTNHANVIENBAOTRI";
            this.cTNHANVIENBAOTRIBindingSource.DataSource = this.sP_DANHSACH_NHANVIENBindingSource;
            // 
            // cTNHANVIENBAOTRITableAdapter
            // 
            this.cTNHANVIENBAOTRITableAdapter.ClearBeforeFill = true;
            // 
            // frmNhanVien
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 766);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DANHSACH_NHANVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DANHSACH_NHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaLam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENVEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTNHANVIENBAOTRIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource sP_DANHSACH_NHANVIENBindingSource;
        private DSSB dSSB;
        private DSSBTableAdapters.SP_DANHSACH_NHANVIENTableAdapter sP_DANHSACH_NHANVIENTableAdapter;
        private DSSBTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit txtCMND;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtLuong;
        private DevExpress.XtraEditors.TextEdit txtCaLam;
        private DevExpress.XtraGrid.GridControl sP_DANHSACH_NHANVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colCALAM;
        private System.Windows.Forms.BindingSource cHUYENVEBindingSource;
        private DSSBTableAdapters.CHUYENVETableAdapter cHUYENVETableAdapter;
        private System.Windows.Forms.BindingSource cTNHANVIENBAOTRIBindingSource;
        private DSSBTableAdapters.CTNHANVIENBAOTRITableAdapter cTNHANVIENBAOTRITableAdapter;
    }
}