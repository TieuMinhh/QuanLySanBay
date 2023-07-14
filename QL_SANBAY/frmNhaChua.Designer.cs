namespace QL_SANBAY
{
    partial class frmNhaChua
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
            System.Windows.Forms.Label mANHALabel;
            System.Windows.Forms.Label sUCCHUALabel;
            System.Windows.Forms.Label vITRILabel;
            System.Windows.Forms.Label tENNHALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaChua));
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
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.nHACHUAGridControl = new DevExpress.XtraGrid.GridControl();
            this.nHACHUABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSSB = new QL_SANBAY.DSSB();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANHA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUCCHUA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVITRI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENNHA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtTenNha = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.mANHATextEdit = new DevExpress.XtraEditors.TextEdit();
            this.txtSucChua = new DevExpress.XtraEditors.TextEdit();
            this.txtViTri = new DevExpress.XtraEditors.TextEdit();
            this.nHACHUATableAdapter = new QL_SANBAY.DSSBTableAdapters.NHACHUATableAdapter();
            this.tableAdapterManager = new QL_SANBAY.DSSBTableAdapters.TableAdapterManager();
            this.mAYBAYTableAdapter = new QL_SANBAY.DSSBTableAdapters.MAYBAYTableAdapter();
            this.mAYBAYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nGUOIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nGUOITableAdapter = new QL_SANBAY.DSSBTableAdapters.NGUOITableAdapter();
            mANHALabel = new System.Windows.Forms.Label();
            sUCCHUALabel = new System.Windows.Forms.Label();
            vITRILabel = new System.Windows.Forms.Label();
            tENNHALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACHUAGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACHUABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mANHATextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSucChua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtViTri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAYBAYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mANHALabel
            // 
            mANHALabel.AutoSize = true;
            mANHALabel.Location = new System.Drawing.Point(85, 67);
            mANHALabel.Name = "mANHALabel";
            mANHALabel.Size = new System.Drawing.Size(99, 17);
            mANHALabel.TabIndex = 0;
            mANHALabel.Text = "Mã Nhà Chứa :";
            // 
            // sUCCHUALabel
            // 
            sUCCHUALabel.AutoSize = true;
            sUCCHUALabel.Location = new System.Drawing.Point(537, 64);
            sUCCHUALabel.Name = "sUCCHUALabel";
            sUCCHUALabel.Size = new System.Drawing.Size(78, 17);
            sUCCHUALabel.TabIndex = 2;
            sUCCHUALabel.Text = "Sức Chứa :";
            // 
            // vITRILabel
            // 
            vITRILabel.AutoSize = true;
            vITRILabel.Location = new System.Drawing.Point(551, 120);
            vITRILabel.Name = "vITRILabel";
            vITRILabel.Size = new System.Drawing.Size(46, 17);
            vITRILabel.TabIndex = 4;
            vITRILabel.Text = "Vị Trí :";
            // 
            // tENNHALabel
            // 
            tENNHALabel.AutoSize = true;
            tENNHALabel.Location = new System.Drawing.Point(78, 120);
            tENNHALabel.Name = "tENNHALabel";
            tENNHALabel.Size = new System.Drawing.Size(105, 17);
            tENNHALabel.TabIndex = 7;
            tENNHALabel.Text = "Tên Nhà Chứa :";
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
            this.btnLamMoi.Caption = "Làm Mới";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1130, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 636);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1130, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 636);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1130, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 636);
            // 
            // bar4
            // 
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Main menu";
            // 
            // bar5
            // 
            this.bar5.BarName = "Main menu";
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar5.OptionsBar.MultiLine = true;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Main menu";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.nHACHUAGridControl);
            this.panelControl1.Location = new System.Drawing.Point(12, 58);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1106, 387);
            this.panelControl1.TabIndex = 4;
            // 
            // nHACHUAGridControl
            // 
            this.nHACHUAGridControl.DataSource = this.nHACHUABindingSource;
            this.nHACHUAGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nHACHUAGridControl.Location = new System.Drawing.Point(2, 2);
            this.nHACHUAGridControl.MainView = this.gridView1;
            this.nHACHUAGridControl.MenuManager = this.barManager1;
            this.nHACHUAGridControl.Name = "nHACHUAGridControl";
            this.nHACHUAGridControl.Size = new System.Drawing.Size(1102, 383);
            this.nHACHUAGridControl.TabIndex = 0;
            this.nHACHUAGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // nHACHUABindingSource
            // 
            this.nHACHUABindingSource.DataMember = "NHACHUA";
            this.nHACHUABindingSource.DataSource = this.dSSB;
            // 
            // dSSB
            // 
            this.dSSB.DataSetName = "DSSB";
            this.dSSB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANHA,
            this.colSUCCHUA,
            this.colVITRI,
            this.colTENNHA});
            this.gridView1.GridControl = this.nHACHUAGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMANHA
            // 
            this.colMANHA.FieldName = "MANHA";
            this.colMANHA.MinWidth = 25;
            this.colMANHA.Name = "colMANHA";
            this.colMANHA.Visible = true;
            this.colMANHA.VisibleIndex = 0;
            this.colMANHA.Width = 94;
            // 
            // colSUCCHUA
            // 
            this.colSUCCHUA.FieldName = "SUCCHUA";
            this.colSUCCHUA.MinWidth = 25;
            this.colSUCCHUA.Name = "colSUCCHUA";
            this.colSUCCHUA.Visible = true;
            this.colSUCCHUA.VisibleIndex = 2;
            this.colSUCCHUA.Width = 94;
            // 
            // colVITRI
            // 
            this.colVITRI.FieldName = "VITRI";
            this.colVITRI.MinWidth = 25;
            this.colVITRI.Name = "colVITRI";
            this.colVITRI.Visible = true;
            this.colVITRI.VisibleIndex = 3;
            this.colVITRI.Width = 94;
            // 
            // colTENNHA
            // 
            this.colTENNHA.FieldName = "TENNHA";
            this.colTENNHA.MinWidth = 25;
            this.colTENNHA.Name = "colTENNHA";
            this.colTENNHA.Visible = true;
            this.colTENNHA.VisibleIndex = 1;
            this.colTENNHA.Width = 94;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(tENNHALabel);
            this.panelControl2.Controls.Add(this.txtTenNha);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(mANHALabel);
            this.panelControl2.Controls.Add(this.mANHATextEdit);
            this.panelControl2.Controls.Add(sUCCHUALabel);
            this.panelControl2.Controls.Add(this.txtSucChua);
            this.panelControl2.Controls.Add(vITRILabel);
            this.panelControl2.Controls.Add(this.txtViTri);
            this.panelControl2.Enabled = false;
            this.panelControl2.Location = new System.Drawing.Point(12, 434);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1106, 175);
            this.panelControl2.TabIndex = 5;
            // 
            // txtTenNha
            // 
            this.txtTenNha.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHACHUABindingSource, "TENNHA", true));
            this.txtTenNha.Location = new System.Drawing.Point(195, 117);
            this.txtTenNha.MenuManager = this.barManager1;
            this.txtTenNha.Name = "txtTenNha";
            this.txtTenNha.Size = new System.Drawing.Size(201, 22);
            this.txtTenNha.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "THÔNG TIN CHI TIẾT DANH SÁCH NHÀ CHỨA MÁY BAY";
            // 
            // mANHATextEdit
            // 
            this.mANHATextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHACHUABindingSource, "MANHA", true));
            this.mANHATextEdit.Enabled = false;
            this.mANHATextEdit.Location = new System.Drawing.Point(195, 64);
            this.mANHATextEdit.MenuManager = this.barManager1;
            this.mANHATextEdit.Name = "mANHATextEdit";
            this.mANHATextEdit.Size = new System.Drawing.Size(201, 22);
            this.mANHATextEdit.TabIndex = 1;
            // 
            // txtSucChua
            // 
            this.txtSucChua.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHACHUABindingSource, "SUCCHUA", true));
            this.txtSucChua.Location = new System.Drawing.Point(645, 61);
            this.txtSucChua.MenuManager = this.barManager1;
            this.txtSucChua.Name = "txtSucChua";
            this.txtSucChua.Size = new System.Drawing.Size(281, 22);
            this.txtSucChua.TabIndex = 3;
            // 
            // txtViTri
            // 
            this.txtViTri.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHACHUABindingSource, "VITRI", true));
            this.txtViTri.Location = new System.Drawing.Point(645, 117);
            this.txtViTri.MenuManager = this.barManager1;
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(281, 22);
            this.txtViTri.TabIndex = 5;
            // 
            // nHACHUATableAdapter
            // 
            this.nHACHUATableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LAITableAdapter = null;
            this.tableAdapterManager.LOAITableAdapter = null;
            this.tableAdapterManager.MAYBAYTableAdapter = this.mAYBAYTableAdapter;
            this.tableAdapterManager.NGUOITableAdapter = null;
            this.tableAdapterManager.NHACHUATableAdapter = this.nHACHUATableAdapter;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHICONGTableAdapter = null;
            this.tableAdapterManager.SOHUUTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QL_SANBAY.DSSBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mAYBAYTableAdapter
            // 
            this.mAYBAYTableAdapter.ClearBeforeFill = true;
            // 
            // mAYBAYBindingSource
            // 
            this.mAYBAYBindingSource.DataMember = "FK_MAYBAY_NHACHUA";
            this.mAYBAYBindingSource.DataSource = this.nHACHUABindingSource;
            // 
            // nGUOIBindingSource
            // 
            this.nGUOIBindingSource.DataMember = "NGUOI";
            this.nGUOIBindingSource.DataSource = this.dSSB;
            // 
            // nGUOITableAdapter
            // 
            this.nGUOITableAdapter.ClearBeforeFill = true;
            // 
            // frmNhaChua
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 636);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhaChua";
            this.Text = "frmNhaChua";
            this.Load += new System.EventHandler(this.frmNhaChua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACHUAGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACHUABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mANHATextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSucChua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtViTri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAYBAYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIBindingSource)).EndInit();
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
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar5;
        private System.Windows.Forms.BindingSource nHACHUABindingSource;
        private DSSB dSSB;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DSSBTableAdapters.NHACHUATableAdapter nHACHUATableAdapter;
        private DSSBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit mANHATextEdit;
        private DevExpress.XtraEditors.TextEdit txtSucChua;
        private DevExpress.XtraEditors.TextEdit txtViTri;
        private DSSBTableAdapters.MAYBAYTableAdapter mAYBAYTableAdapter;
        private System.Windows.Forms.BindingSource mAYBAYBindingSource;
        private DevExpress.XtraGrid.GridControl nHACHUAGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANHA;
        private DevExpress.XtraGrid.Columns.GridColumn colSUCCHUA;
        private DevExpress.XtraGrid.Columns.GridColumn colVITRI;
        private DevExpress.XtraGrid.Columns.GridColumn colTENNHA;
        private System.Windows.Forms.BindingSource nGUOIBindingSource;
        private DSSBTableAdapters.NGUOITableAdapter nGUOITableAdapter;
        private DevExpress.XtraEditors.TextEdit txtTenNha;
    }
}