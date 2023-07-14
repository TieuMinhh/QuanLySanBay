namespace QL_SANBAY
{
    partial class frmBaoTri
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
            System.Windows.Forms.Label mADANGKYLabel;
            System.Windows.Forms.Label mADICHVULabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label sOGIOLabel;
            System.Windows.Forms.Label nOIDUNGLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoTri));
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxDichVu = new System.Windows.Forms.ComboBox();
            this.cbxMayBay = new System.Windows.Forms.ComboBox();
            this.txtMaDK = new DevExpress.XtraEditors.TextEdit();
            this.txtMaDV = new DevExpress.XtraEditors.TextEdit();
            this.txtNgay = new DevExpress.XtraEditors.DateEdit();
            this.txtSoGio = new DevExpress.XtraEditors.TextEdit();
            this.txtNoiDung = new DevExpress.XtraEditors.TextEdit();
            this.bAOTRITableAdapter = new QL_SANBAY.DSSBTableAdapters.BAOTRITableAdapter();
            this.tableAdapterManager = new QL_SANBAY.DSSBTableAdapters.TableAdapterManager();
            this.cTNHANVIENBAOTRIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTNHANVIENBAOTRITableAdapter = new QL_SANBAY.DSSBTableAdapters.CTNHANVIENBAOTRITableAdapter();
            mADANGKYLabel = new System.Windows.Forms.Label();
            mADICHVULabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            sOGIOLabel = new System.Windows.Forms.Label();
            nOIDUNGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAOTRIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAOTRIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoGio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTNHANVIENBAOTRIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mADANGKYLabel
            // 
            mADANGKYLabel.AutoSize = true;
            mADANGKYLabel.Location = new System.Drawing.Point(450, 80);
            mADANGKYLabel.Name = "mADANGKYLabel";
            mADANGKYLabel.Size = new System.Drawing.Size(87, 17);
            mADANGKYLabel.TabIndex = 0;
            mADANGKYLabel.Text = "Mã Đăng Ký:";
            // 
            // mADICHVULabel
            // 
            mADICHVULabel.AutoSize = true;
            mADICHVULabel.Location = new System.Drawing.Point(450, 130);
            mADICHVULabel.Name = "mADICHVULabel";
            mADICHVULabel.Size = new System.Drawing.Size(81, 17);
            mADICHVULabel.TabIndex = 2;
            mADICHVULabel.Text = "Mã Dịch Vụ:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(703, 80);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(45, 17);
            nGAYLabel.TabIndex = 4;
            nGAYLabel.Text = "Ngày:";
            // 
            // sOGIOLabel
            // 
            sOGIOLabel.AutoSize = true;
            sOGIOLabel.Location = new System.Drawing.Point(703, 130);
            sOGIOLabel.Name = "sOGIOLabel";
            sOGIOLabel.Size = new System.Drawing.Size(52, 17);
            sOGIOLabel.TabIndex = 6;
            sOGIOLabel.Text = "Số Giờ:";
            // 
            // nOIDUNGLabel
            // 
            nOIDUNGLabel.AutoSize = true;
            nOIDUNGLabel.Location = new System.Drawing.Point(300, 185);
            nOIDUNGLabel.Name = "nOIDUNGLabel";
            nOIDUNGLabel.Size = new System.Drawing.Size(116, 17);
            nOIDUNGLabel.TabIndex = 8;
            nOIDUNGLabel.Text = "Nội Dung Bảo Trì:";
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
            this.bar1.FloatLocation = new System.Drawing.Point(341, 781);
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
            this.btnGhi.Caption = "Xác Nhận";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1171, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 665);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1171, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 665);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1171, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 665);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.bAOTRIGridControl);
            this.panelControl1.Location = new System.Drawing.Point(12, 37);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1147, 321);
            this.panelControl1.TabIndex = 4;
            // 
            // bAOTRIGridControl
            // 
            this.bAOTRIGridControl.DataSource = this.bAOTRIBindingSource;
            this.bAOTRIGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bAOTRIGridControl.Location = new System.Drawing.Point(2, 2);
            this.bAOTRIGridControl.MainView = this.gridView1;
            this.bAOTRIGridControl.MenuManager = this.barManager1;
            this.bAOTRIGridControl.Name = "bAOTRIGridControl";
            this.bAOTRIGridControl.Size = new System.Drawing.Size(1143, 317);
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
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.cbxDichVu);
            this.panelControl2.Controls.Add(this.cbxMayBay);
            this.panelControl2.Controls.Add(mADANGKYLabel);
            this.panelControl2.Controls.Add(this.txtMaDK);
            this.panelControl2.Controls.Add(mADICHVULabel);
            this.panelControl2.Controls.Add(this.txtMaDV);
            this.panelControl2.Controls.Add(nGAYLabel);
            this.panelControl2.Controls.Add(this.txtNgay);
            this.panelControl2.Controls.Add(sOGIOLabel);
            this.panelControl2.Controls.Add(this.txtSoGio);
            this.panelControl2.Controls.Add(nOIDUNGLabel);
            this.panelControl2.Controls.Add(this.txtNoiDung);
            this.panelControl2.Enabled = false;
            this.panelControl2.Location = new System.Drawing.Point(12, 376);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1147, 241);
            this.panelControl2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(479, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "CHI TIẾT BẢO TRÌ MÁY BAY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên Dịch Vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên Máy Bay :";
            // 
            // cbxDichVu
            // 
            this.cbxDichVu.FormattingEnabled = true;
            this.cbxDichVu.Location = new System.Drawing.Point(178, 125);
            this.cbxDichVu.Name = "cbxDichVu";
            this.cbxDichVu.Size = new System.Drawing.Size(210, 24);
            this.cbxDichVu.TabIndex = 11;
            this.cbxDichVu.SelectedIndexChanged += new System.EventHandler(this.cbxDichVu_SelectedIndexChanged);
            // 
            // cbxMayBay
            // 
            this.cbxMayBay.FormattingEnabled = true;
            this.cbxMayBay.Location = new System.Drawing.Point(178, 75);
            this.cbxMayBay.Name = "cbxMayBay";
            this.cbxMayBay.Size = new System.Drawing.Size(210, 24);
            this.cbxMayBay.TabIndex = 10;
            this.cbxMayBay.SelectedIndexChanged += new System.EventHandler(this.cbxMayBay_SelectedIndexChanged);
            // 
            // txtMaDK
            // 
            this.txtMaDK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bAOTRIBindingSource, "MADANGKY", true));
            this.txtMaDK.Enabled = false;
            this.txtMaDK.Location = new System.Drawing.Point(560, 75);
            this.txtMaDK.MenuManager = this.barManager1;
            this.txtMaDK.Name = "txtMaDK";
            this.txtMaDK.Size = new System.Drawing.Size(90, 22);
            this.txtMaDK.TabIndex = 1;
            this.txtMaDK.EditValueChanged += new System.EventHandler(this.txtMaDK_EditValueChanged);
            // 
            // txtMaDV
            // 
            this.txtMaDV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bAOTRIBindingSource, "MADICHVU", true));
            this.txtMaDV.Enabled = false;
            this.txtMaDV.Location = new System.Drawing.Point(560, 125);
            this.txtMaDV.MenuManager = this.barManager1;
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(90, 22);
            this.txtMaDV.TabIndex = 3;
            this.txtMaDV.EditValueChanged += new System.EventHandler(this.txtMaDV_EditValueChanged);
            // 
            // txtNgay
            // 
            this.txtNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bAOTRIBindingSource, "NGAY", true));
            this.txtNgay.Location = new System.Drawing.Point(785, 75);
            this.txtNgay.MenuManager = this.barManager1;
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
            this.txtNgay.Size = new System.Drawing.Size(148, 22);
            this.txtNgay.TabIndex = 5;
            // 
            // txtSoGio
            // 
            this.txtSoGio.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bAOTRIBindingSource, "SOGIO", true));
            this.txtSoGio.Location = new System.Drawing.Point(785, 125);
            this.txtSoGio.MenuManager = this.barManager1;
            this.txtSoGio.Name = "txtSoGio";
            this.txtSoGio.Size = new System.Drawing.Size(148, 22);
            this.txtSoGio.TabIndex = 7;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bAOTRIBindingSource, "NOIDUNG", true));
            this.txtNoiDung.Location = new System.Drawing.Point(450, 180);
            this.txtNoiDung.MenuManager = this.barManager1;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(400, 22);
            this.txtNoiDung.TabIndex = 9;
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
            // cTNHANVIENBAOTRIBindingSource
            // 
            this.cTNHANVIENBAOTRIBindingSource.DataMember = "FK_CTNHANVIENBAOTRI_BAOTRI1";
            this.cTNHANVIENBAOTRIBindingSource.DataSource = this.bAOTRIBindingSource;
            // 
            // cTNHANVIENBAOTRITableAdapter
            // 
            this.cTNHANVIENBAOTRITableAdapter.ClearBeforeFill = true;
            // 
            // frmBaoTri
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 665);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBaoTri";
            this.Text = "frmBaoTri";
            this.Load += new System.EventHandler(this.frmBaoTri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAOTRIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAOTRIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoGio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDung.Properties)).EndInit();
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
        private System.Windows.Forms.BindingSource bAOTRIBindingSource;
        private DSSB dSSB;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DSSBTableAdapters.BAOTRITableAdapter bAOTRITableAdapter;
        private DSSBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxDichVu;
        private System.Windows.Forms.ComboBox cbxMayBay;
        private DevExpress.XtraEditors.TextEdit txtMaDK;
        private DevExpress.XtraEditors.TextEdit txtMaDV;
        private DevExpress.XtraEditors.DateEdit txtNgay;
        private DevExpress.XtraEditors.TextEdit txtSoGio;
        private DevExpress.XtraEditors.TextEdit txtNoiDung;
        private DevExpress.XtraGrid.GridControl bAOTRIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMADANGKY;
        private DevExpress.XtraGrid.Columns.GridColumn colMADICHVU;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colSOGIO;
        private DevExpress.XtraGrid.Columns.GridColumn colNOIDUNG;
        private System.Windows.Forms.BindingSource cTNHANVIENBAOTRIBindingSource;
        private DSSBTableAdapters.CTNHANVIENBAOTRITableAdapter cTNHANVIENBAOTRITableAdapter;
    }
}