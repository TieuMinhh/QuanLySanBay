namespace QL_SANBAY
{
    partial class frmMayBay
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
            System.Windows.Forms.Label mALOAILabel;
            System.Windows.Forms.Label mANHALabel;
            System.Windows.Forms.Label tENLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMayBay));
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
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.mAYBAYGridControl = new DevExpress.XtraGrid.GridControl();
            this.mAYBAYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSSB = new QL_SANBAY.DSSB();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMADANGKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANHA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxNhaChua = new System.Windows.Forms.ComboBox();
            this.cbxLoai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDK = new DevExpress.XtraEditors.TextEdit();
            this.txtMaLoai = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNha = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.mAYBAYTableAdapter = new QL_SANBAY.DSSBTableAdapters.MAYBAYTableAdapter();
            this.tableAdapterManager = new QL_SANBAY.DSSBTableAdapters.TableAdapterManager();
            this.bAOTRITableAdapter = new QL_SANBAY.DSSBTableAdapters.BAOTRITableAdapter();
            this.sOHUUTableAdapter = new QL_SANBAY.DSSBTableAdapters.SOHUUTableAdapter();
            this.sOHUUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAOTRIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            mADANGKYLabel = new System.Windows.Forms.Label();
            mALOAILabel = new System.Windows.Forms.Label();
            mANHALabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAYBAYGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAYBAYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOHUUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAOTRIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mADANGKYLabel
            // 
            mADANGKYLabel.AutoSize = true;
            mADANGKYLabel.Location = new System.Drawing.Point(33, 54);
            mADANGKYLabel.Name = "mADANGKYLabel";
            mADANGKYLabel.Size = new System.Drawing.Size(99, 17);
            mADANGKYLabel.TabIndex = 0;
            mADANGKYLabel.Text = "Mã Đăng Ký :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Loại Máy Bay :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nhà Chứa :";          
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(488, 51);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(99, 17);
            tENLabel.TabIndex = 6;
            tENLabel.Text = "Tên Máy Bay :";
            // 
            // mALOAILabel
            // 
            mALOAILabel.AutoSize = true;
            mALOAILabel.Location = new System.Drawing.Point(488, 102);
            mALOAILabel.Name = "mALOAILabel";
            mALOAILabel.Size = new System.Drawing.Size(99, 17);
            mALOAILabel.TabIndex = 2;
            mALOAILabel.Text = "Mã Loại :";
            // 
            // mANHALabel
            // 
            mANHALabel.AutoSize = true;
            mANHALabel.Location = new System.Drawing.Point(488, 150);
            mANHALabel.Name = "mANHALabel";
            mANHALabel.Size = new System.Drawing.Size(96, 17);
            mANHALabel.TabIndex = 4;
            mANHALabel.Text = "Mã Nhà Chứa :";           
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
            this.barButtonItem3,
            this.btnGhi,
            this.btnHuy,
            this.btnLamMoi,
            this.btnThoat,
            this.btnXoa});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
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
            this.btnXoa.Id = 7;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1149, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 655);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1149, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 655);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1149, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 655);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Xóa";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.mAYBAYGridControl);
            this.panelControl1.Location = new System.Drawing.Point(12, 58);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1125, 326);
            this.panelControl1.TabIndex = 4;
            // 
            // mAYBAYGridControl
            // 
            this.mAYBAYGridControl.DataSource = this.mAYBAYBindingSource;
            this.mAYBAYGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mAYBAYGridControl.Location = new System.Drawing.Point(2, 2);
            this.mAYBAYGridControl.MainView = this.gridView1;
            this.mAYBAYGridControl.MenuManager = this.barManager1;
            this.mAYBAYGridControl.Name = "mAYBAYGridControl";
            this.mAYBAYGridControl.Size = new System.Drawing.Size(1121, 322);
            this.mAYBAYGridControl.TabIndex = 0;
            this.mAYBAYGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // mAYBAYBindingSource
            // 
            this.mAYBAYBindingSource.DataMember = "MAYBAY";
            this.mAYBAYBindingSource.DataSource = this.dSSB;
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
            this.colMALOAI,
            this.colMANHA,
            this.colTEN});
            this.gridView1.GridControl = this.mAYBAYGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMADANGKY
            // 
            this.colMADANGKY.Caption = "Mã Đăng ký";
            this.colMADANGKY.FieldName = "MADANGKY";
            this.colMADANGKY.MinWidth = 25;
            this.colMADANGKY.Name = "colMADANGKY";
            this.colMADANGKY.Visible = true;
            this.colMADANGKY.VisibleIndex = 0;
            this.colMADANGKY.Width = 94;
            // 
            // colMALOAI
            // 
            this.colMALOAI.Caption = "Mã Loại";
            this.colMALOAI.FieldName = "MALOAI";
            this.colMALOAI.MinWidth = 25;
            this.colMALOAI.Name = "colMALOAI";
            this.colMALOAI.Visible = true;
            this.colMALOAI.VisibleIndex = 2;
            this.colMALOAI.Width = 94;
            // 
            // colMANHA
            // 
            this.colMANHA.Caption = "Mã Nhà Chứa";
            this.colMANHA.FieldName = "MANHA";
            this.colMANHA.MinWidth = 25;
            this.colMANHA.Name = "colMANHA";
            this.colMANHA.Visible = true;
            this.colMANHA.VisibleIndex = 3;
            this.colMANHA.Width = 94;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên máy Bay";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 1;
            this.colTEN.Width = 94;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.cbxNhaChua);
            this.panelControl2.Controls.Add(this.cbxLoai);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(mADANGKYLabel);
            this.panelControl2.Controls.Add(this.txtMaDK);
            this.panelControl2.Controls.Add(mALOAILabel);
            this.panelControl2.Controls.Add(this.txtMaLoai);
            this.panelControl2.Controls.Add(mANHALabel);
            this.panelControl2.Controls.Add(this.txtMaNha);
            this.panelControl2.Controls.Add(tENLabel);
            this.panelControl2.Controls.Add(this.txtTen);
            this.panelControl2.Enabled = false;
            this.panelControl2.Location = new System.Drawing.Point(12, 388);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1125, 241);
            this.panelControl2.TabIndex = 5;
           
            // 
            // cbxNhaChua
            // 
            this.cbxNhaChua.FormattingEnabled = true;
            this.cbxNhaChua.Location = new System.Drawing.Point(164, 145);
            this.cbxNhaChua.Name = "cbxNhaChua";
            this.cbxNhaChua.Size = new System.Drawing.Size(251, 24);
            this.cbxNhaChua.TabIndex = 10;
            this.cbxNhaChua.SelectedIndexChanged += new System.EventHandler(this.cbxNhaChua_SelectedIndexChanged);
            // 
            // cbxLoai
            // 
            this.cbxLoai.FormattingEnabled = true;
            this.cbxLoai.Location = new System.Drawing.Point(164, 95);
            this.cbxLoai.Name = "cbxLoai";
            this.cbxLoai.Size = new System.Drawing.Size(251, 24);
            this.cbxLoai.TabIndex = 9;
            this.cbxLoai.SelectedIndexChanged += new System.EventHandler(this.cbxLoai_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "THÔNG TIN CHI TIẾT VỀ HỆ THỐNG CÁC MÁY BAY";
            // 
            // txtMaDK
            // 
            this.txtMaDK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mAYBAYBindingSource, "MADANGKY", true));
            this.txtMaDK.Enabled = false;
            this.txtMaDK.Location = new System.Drawing.Point(164, 48);
            this.txtMaDK.MenuManager = this.barManager1;
            this.txtMaDK.Name = "txtMaDK";
            this.txtMaDK.Size = new System.Drawing.Size(251, 22);
            this.txtMaDK.TabIndex = 1;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mAYBAYBindingSource, "MALOAI", true));
            this.txtMaLoai.Enabled = false;
            this.txtMaLoai.Location = new System.Drawing.Point(620, 96);
            this.txtMaLoai.MenuManager = this.barManager1;
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(118, 22);
            this.txtMaLoai.TabIndex = 3;
            this.txtMaLoai.EditValueChanged += new System.EventHandler(this.txtMaLoai_EditValueChanged);
            // 
            // txtMaNha
            // 
            this.txtMaNha.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mAYBAYBindingSource, "MANHA", true));
            this.txtMaNha.Enabled = false;
            this.txtMaNha.Location = new System.Drawing.Point(620, 144);
            this.txtMaNha.MenuManager = this.barManager1;
            this.txtMaNha.Name = "txtMaNha";
            this.txtMaNha.Size = new System.Drawing.Size(118, 22);
            this.txtMaNha.TabIndex = 5;
            this.txtMaNha.EditValueChanged += new System.EventHandler(this.txtMaNha_EditValueChanged);
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mAYBAYBindingSource, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(620, 46);
            this.txtTen.MenuManager = this.barManager1;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(251, 22);
            this.txtTen.TabIndex = 7;
            // 
            // mAYBAYTableAdapter
            // 
            this.mAYBAYTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.MAYBAYTableAdapter = this.mAYBAYTableAdapter;
            this.tableAdapterManager.NGUOITableAdapter = null;
            this.tableAdapterManager.NHACHUATableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHICONGTableAdapter = null;
            this.tableAdapterManager.SOHUUTableAdapter = this.sOHUUTableAdapter;
            this.tableAdapterManager.UpdateOrder = QL_SANBAY.DSSBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bAOTRITableAdapter
            // 
            this.bAOTRITableAdapter.ClearBeforeFill = true;
            // 
            // sOHUUTableAdapter
            // 
            this.sOHUUTableAdapter.ClearBeforeFill = true;
            // 
            // sOHUUBindingSource
            // 
            this.sOHUUBindingSource.DataMember = "FK_SOHUU_MAYBAY";
            this.sOHUUBindingSource.DataSource = this.mAYBAYBindingSource;
            // 
            // bAOTRIBindingSource
            // 
            this.bAOTRIBindingSource.DataMember = "FK_BAOTRI_MAYBAY";
            this.bAOTRIBindingSource.DataSource = this.mAYBAYBindingSource;
            // 
            // frmMayBay
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 655);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMayBay";
            this.Text = "frmMayBay";
            this.Load += new System.EventHandler(this.frmMayBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAYBAYGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAYBAYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOHUUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAOTRIBindingSource)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.BindingSource mAYBAYBindingSource;
        private DSSB dSSB;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DSSBTableAdapters.MAYBAYTableAdapter mAYBAYTableAdapter;
        private DSSBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxNhaChua;
        private System.Windows.Forms.ComboBox cbxLoai;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtMaDK;
        private DevExpress.XtraEditors.TextEdit txtMaLoai;
        private DevExpress.XtraEditors.TextEdit txtMaNha;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraGrid.GridControl mAYBAYGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMADANGKY;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colMANHA;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DSSBTableAdapters.SOHUUTableAdapter sOHUUTableAdapter;
        private System.Windows.Forms.BindingSource sOHUUBindingSource;
        private DSSBTableAdapters.BAOTRITableAdapter bAOTRITableAdapter;
        private System.Windows.Forms.BindingSource bAOTRIBindingSource;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
    }
}