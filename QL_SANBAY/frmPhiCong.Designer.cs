namespace QL_SANBAY
{
    partial class frmPhiCong
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
            System.Windows.Forms.Label mASOBANGLAILabel;
            System.Windows.Forms.Label nGAYCAPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhiCong));
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
            this.sP_DANHSACH_PHICONGGridControl = new DevExpress.XtraGrid.GridControl();
            this.sP_DANHSACH_PHICONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSSB = new QL_SANBAY.DSSB();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMASOBANGLAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCMND = new DevExpress.XtraEditors.TextEdit();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtMSBangLai = new DevExpress.XtraEditors.TextEdit();
            this.txtNgayCap = new DevExpress.XtraEditors.DateEdit();
            this.sP_DANHSACH_PHICONGTableAdapter = new QL_SANBAY.DSSBTableAdapters.SP_DANHSACH_PHICONGTableAdapter();
            this.tableAdapterManager = new QL_SANBAY.DSSBTableAdapters.TableAdapterManager();
            this.lAITableAdapter = new QL_SANBAY.DSSBTableAdapters.LAITableAdapter();
            this.lAIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            cMNDLabel = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            mASOBANGLAILabel = new System.Windows.Forms.Label();
            nGAYCAPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DANHSACH_PHICONGGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DANHSACH_PHICONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMSBangLai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayCap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(98, 66);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(51, 17);
            cMNDLabel.TabIndex = 0;
            cMNDLabel.Text = "CMND:";
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Location = new System.Drawing.Point(98, 115);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(61, 17);
            hOTENLabel.TabIndex = 2;
            hOTENLabel.Text = "Họ Tên :";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(98, 164);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(43, 17);
            sDTLabel.TabIndex = 4;
            sDTLabel.Text = "SDT :";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(607, 66);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(59, 17);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "Địa Chỉ :";
            // 
            // mASOBANGLAILabel
            // 
            mASOBANGLAILabel.AutoSize = true;
            mASOBANGLAILabel.Location = new System.Drawing.Point(592, 115);
            mASOBANGLAILabel.Name = "mASOBANGLAILabel";
            mASOBANGLAILabel.Size = new System.Drawing.Size(109, 17);
            mASOBANGLAILabel.TabIndex = 8;
            mASOBANGLAILabel.Text = "Mã Số Bằng Lái :";
            // 
            // nGAYCAPLabel
            // 
            nGAYCAPLabel.AutoSize = true;
            nGAYCAPLabel.Location = new System.Drawing.Point(607, 164);
            nGAYCAPLabel.Name = "nGAYCAPLabel";
            nGAYCAPLabel.Size = new System.Drawing.Size(77, 17);
            nGAYCAPLabel.TabIndex = 10;
            nGAYCAPLabel.Text = "Ngày Cấp :";
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
            this.bar1.FloatLocation = new System.Drawing.Point(350, 762);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1146, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 717);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1146, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 717);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1146, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 717);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sP_DANHSACH_PHICONGGridControl);
            this.panelControl1.Location = new System.Drawing.Point(12, 37);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1122, 365);
            this.panelControl1.TabIndex = 4;
            // 
            // sP_DANHSACH_PHICONGGridControl
            // 
            this.sP_DANHSACH_PHICONGGridControl.DataSource = this.sP_DANHSACH_PHICONGBindingSource;
            this.sP_DANHSACH_PHICONGGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_DANHSACH_PHICONGGridControl.Location = new System.Drawing.Point(2, 2);
            this.sP_DANHSACH_PHICONGGridControl.MainView = this.gridView1;
            this.sP_DANHSACH_PHICONGGridControl.MenuManager = this.barManager1;
            this.sP_DANHSACH_PHICONGGridControl.Name = "sP_DANHSACH_PHICONGGridControl";
            this.sP_DANHSACH_PHICONGGridControl.Size = new System.Drawing.Size(1118, 361);
            this.sP_DANHSACH_PHICONGGridControl.TabIndex = 0;
            this.sP_DANHSACH_PHICONGGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sP_DANHSACH_PHICONGBindingSource
            // 
            this.sP_DANHSACH_PHICONGBindingSource.DataMember = "SP_DANHSACH_PHICONG";
            this.sP_DANHSACH_PHICONGBindingSource.DataSource = this.dSSB;
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
            this.colMASOBANGLAI,
            this.colNGAYCAP});
            this.gridView1.GridControl = this.sP_DANHSACH_PHICONGGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 25;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 0;
            this.colCMND.Width = 138;
            // 
            // colHOTEN
            // 
            this.colHOTEN.Caption = "Họ Tên";
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.MinWidth = 25;
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 1;
            this.colHOTEN.Width = 206;
            // 
            // colSDT
            // 
            this.colSDT.Caption = "Số Điện Thoại";
            this.colSDT.FieldName = "SDT";
            this.colSDT.MinWidth = 25;
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 2;
            this.colSDT.Width = 184;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa Chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 238;
            // 
            // colMASOBANGLAI
            // 
            this.colMASOBANGLAI.Caption = "Mã Số Bằng Lái";
            this.colMASOBANGLAI.FieldName = "MASOBANGLAI";
            this.colMASOBANGLAI.MinWidth = 25;
            this.colMASOBANGLAI.Name = "colMASOBANGLAI";
            this.colMASOBANGLAI.Visible = true;
            this.colMASOBANGLAI.VisibleIndex = 4;
            this.colMASOBANGLAI.Width = 189;
            // 
            // colNGAYCAP
            // 
            this.colNGAYCAP.Caption = "Ngày Cấp";
            this.colNGAYCAP.FieldName = "NGAYCAP";
            this.colNGAYCAP.MinWidth = 25;
            this.colNGAYCAP.Name = "colNGAYCAP";
            this.colNGAYCAP.Visible = true;
            this.colNGAYCAP.VisibleIndex = 5;
            this.colNGAYCAP.Width = 133;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(cMNDLabel);
            this.panelControl2.Controls.Add(this.txtCMND);
            this.panelControl2.Controls.Add(hOTENLabel);
            this.panelControl2.Controls.Add(this.txtHoTen);
            this.panelControl2.Controls.Add(sDTLabel);
            this.panelControl2.Controls.Add(this.txtSDT);
            this.panelControl2.Controls.Add(dIACHILabel);
            this.panelControl2.Controls.Add(this.txtDiaChi);
            this.panelControl2.Controls.Add(mASOBANGLAILabel);
            this.panelControl2.Controls.Add(this.txtMSBangLai);
            this.panelControl2.Controls.Add(nGAYCAPLabel);
            this.panelControl2.Controls.Add(this.txtNgayCap);
            this.panelControl2.Enabled = false;
            this.panelControl2.Location = new System.Drawing.Point(12, 408);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1122, 261);
            this.panelControl2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "THÔNG TIN CHI TIẾT DANH SÁCH PHI CÔNG";
            // 
            // txtCMND
            // 
            this.txtCMND.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_DANHSACH_PHICONGBindingSource, "CMND", true));
            this.txtCMND.Enabled = false;
            this.txtCMND.Location = new System.Drawing.Point(194, 65);
            this.txtCMND.MenuManager = this.barManager1;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(250, 22);
            this.txtCMND.TabIndex = 1;
            // 
            // txtHoTen
            // 
            this.txtHoTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_DANHSACH_PHICONGBindingSource, "HOTEN", true));
            this.txtHoTen.Location = new System.Drawing.Point(194, 110);
            this.txtHoTen.MenuManager = this.barManager1;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(250, 22);
            this.txtHoTen.TabIndex = 3;
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_DANHSACH_PHICONGBindingSource, "SDT", true));
            this.txtSDT.Location = new System.Drawing.Point(194, 155);
            this.txtSDT.MenuManager = this.barManager1;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(250, 22);
            this.txtSDT.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_DANHSACH_PHICONGBindingSource, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(709, 65);
            this.txtDiaChi.MenuManager = this.barManager1;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(305, 22);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtMSBangLai
            // 
            this.txtMSBangLai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_DANHSACH_PHICONGBindingSource, "MASOBANGLAI", true));
            this.txtMSBangLai.Location = new System.Drawing.Point(709, 110);
            this.txtMSBangLai.MenuManager = this.barManager1;
            this.txtMSBangLai.Name = "txtMSBangLai";
            this.txtMSBangLai.Size = new System.Drawing.Size(305, 22);
            this.txtMSBangLai.TabIndex = 9;
            // 
            // txtNgayCap
            // 
            this.txtNgayCap.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_DANHSACH_PHICONGBindingSource, "NGAYCAP", true));
            this.txtNgayCap.Location = new System.Drawing.Point(709, 155);
            this.txtNgayCap.MenuManager = this.barManager1;
            this.txtNgayCap.Name = "txtNgayCap";
            // 
            // 
            // 
            this.txtNgayCap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            // 
            // 
            // 
            this.txtNgayCap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayCap.Size = new System.Drawing.Size(305, 22);
            this.txtNgayCap.TabIndex = 11;
            // 
            // sP_DANHSACH_PHICONGTableAdapter
            // 
            this.sP_DANHSACH_PHICONGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAOTRITableAdapter = null;
            this.tableAdapterManager.CHUTableAdapter = null;
            this.tableAdapterManager.CHUYENVETableAdapter = null;
            this.tableAdapterManager.CTNHANVIENBAOTRITableAdapter = null;
            this.tableAdapterManager.DICHVUBAOTRITableAdapter = null;
            this.tableAdapterManager.DOANHNGHIEPTableAdapter = null;
            this.tableAdapterManager.LAITableAdapter = this.lAITableAdapter;
            this.tableAdapterManager.LOAITableAdapter = null;
            this.tableAdapterManager.MAYBAYTableAdapter = null;
            this.tableAdapterManager.NGUOITableAdapter = null;
            this.tableAdapterManager.NHACHUATableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHICONGTableAdapter = null;
            this.tableAdapterManager.SOHUUTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QL_SANBAY.DSSBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lAITableAdapter
            // 
            this.lAITableAdapter.ClearBeforeFill = true;
            // 
            // lAIBindingSource
            // 
            this.lAIBindingSource.DataMember = "FK_SP_DANHSACH_PHICONG_LAI";
            this.lAIBindingSource.DataSource = this.sP_DANHSACH_PHICONGBindingSource;
            // 
            // frmPhiCong
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 717);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhiCong";
            this.Text = "frmPhiCong";
            this.Load += new System.EventHandler(this.frmPhiCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DANHSACH_PHICONGGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DANHSACH_PHICONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMSBangLai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayCap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAIBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource sP_DANHSACH_PHICONGBindingSource;
        private DSSB dSSB;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DSSBTableAdapters.SP_DANHSACH_PHICONGTableAdapter sP_DANHSACH_PHICONGTableAdapter;
        private DSSBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtCMND;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtMSBangLai;
        private DevExpress.XtraEditors.DateEdit txtNgayCap;
        private DevExpress.XtraGrid.GridControl sP_DANHSACH_PHICONGGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMASOBANGLAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYCAP;
        private DSSBTableAdapters.LAITableAdapter lAITableAdapter;
        private System.Windows.Forms.BindingSource lAIBindingSource;
    }
}