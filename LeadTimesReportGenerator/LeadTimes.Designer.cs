namespace LeadTimesReportGenerator
{
    partial class LeadTimes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeadTimes));
            this.splashManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::LeadTimesReportGenerator.LoadingWindow), true, true);
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.appMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.popupControlContainer2 = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.buttonEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.popupControlContainer1 = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.someLabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.someLabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ribbonImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.bbtnOpen = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnMailsync = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnSetFromColumn = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnSetToColumn = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnTrackingDetails = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnTrackingSummary = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnExcelExport = new DevExpress.XtraBars.BarButtonItem();
            this.btnFlagColumn = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnStatusReport = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonImageCollectionLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.homeRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.FileGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.DetailsGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.BulkCompareGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.BulkStatusGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridDataInfo = new DevExpress.XtraGrid.GridControl();
            this.gridDataView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridResults = new DevExpress.XtraGrid.GridControl();
            this.gridResultsView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer2)).BeginInit();
            this.popupControlContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).BeginInit();
            this.popupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultsView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ApplicationButtonDropDownControl = this.appMenu;
            this.ribbonControl.ApplicationButtonText = null;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Images = this.ribbonImageCollection;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.bbtnOpen,
            this.bbtnMailsync,
            this.bbtnSetFromColumn,
            this.bbtnSetToColumn,
            this.bbtnTrackingDetails,
            this.bbtnTrackingSummary,
            this.bbtnExcelExport,
            this.btnFlagColumn,
            this.bbtnStatusReport});
            this.ribbonControl.LargeImages = this.ribbonImageCollectionLarge;
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 71;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.homeRibbonPage});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl.Size = new System.Drawing.Size(1096, 146);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            // 
            // appMenu
            // 
            this.appMenu.BottomPaneControlContainer = this.popupControlContainer2;
            this.appMenu.Name = "appMenu";
            this.appMenu.Ribbon = this.ribbonControl;
            this.appMenu.RightPaneControlContainer = this.popupControlContainer1;
            this.appMenu.ShowRightPane = true;
            // 
            // popupControlContainer2
            // 
            this.popupControlContainer2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.popupControlContainer2.Appearance.Options.UseBackColor = true;
            this.popupControlContainer2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainer2.Controls.Add(this.buttonEdit);
            this.popupControlContainer2.Location = new System.Drawing.Point(238, 289);
            this.popupControlContainer2.Name = "popupControlContainer2";
            this.popupControlContainer2.Ribbon = this.ribbonControl;
            this.popupControlContainer2.Size = new System.Drawing.Size(118, 28);
            this.popupControlContainer2.TabIndex = 3;
            this.popupControlContainer2.Visible = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.EditValue = "Some Text";
            this.buttonEdit.Location = new System.Drawing.Point(3, 5);
            this.buttonEdit.MenuManager = this.ribbonControl;
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit.Size = new System.Drawing.Size(100, 20);
            this.buttonEdit.TabIndex = 0;
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.popupControlContainer1.Appearance.Options.UseBackColor = true;
            this.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainer1.Controls.Add(this.someLabelControl2);
            this.popupControlContainer1.Controls.Add(this.someLabelControl1);
            this.popupControlContainer1.Location = new System.Drawing.Point(111, 197);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Ribbon = this.ribbonControl;
            this.popupControlContainer1.Size = new System.Drawing.Size(76, 70);
            this.popupControlContainer1.TabIndex = 2;
            this.popupControlContainer1.Visible = false;
            // 
            // someLabelControl2
            // 
            this.someLabelControl2.Location = new System.Drawing.Point(3, 57);
            this.someLabelControl2.Name = "someLabelControl2";
            this.someLabelControl2.Size = new System.Drawing.Size(49, 13);
            this.someLabelControl2.TabIndex = 0;
            this.someLabelControl2.Text = "Some Info";
            // 
            // someLabelControl1
            // 
            this.someLabelControl1.Location = new System.Drawing.Point(3, 3);
            this.someLabelControl1.Name = "someLabelControl1";
            this.someLabelControl1.Size = new System.Drawing.Size(49, 13);
            this.someLabelControl1.TabIndex = 0;
            this.someLabelControl1.Text = "Some Info";
            // 
            // ribbonImageCollection
            // 
            this.ribbonImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollection.ImageStream")));
            this.ribbonImageCollection.Images.SetKeyName(0, "Ribbon_New_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(1, "Ribbon_Open_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(2, "Ribbon_Close_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(3, "Ribbon_Find_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(4, "Ribbon_Save_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(5, "Ribbon_SaveAs_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(6, "Ribbon_Exit_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(7, "Ribbon_Content_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(8, "Ribbon_Info_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(9, "Ribbon_Bold_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(10, "Ribbon_Italic_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(11, "Ribbon_Underline_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(12, "Ribbon_AlignLeft_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(13, "Ribbon_AlignCenter_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(14, "Ribbon_AlignRight_16x16.png");
            // 
            // bbtnOpen
            // 
            this.bbtnOpen.Caption = "Open File";
            this.bbtnOpen.Glyph = global::LeadTimesReportGenerator.Properties.Resources.Open;
            this.bbtnOpen.Id = 62;
            this.bbtnOpen.LargeGlyph = global::LeadTimesReportGenerator.Properties.Resources.Open;
            this.bbtnOpen.Name = "bbtnOpen";
            this.bbtnOpen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnOpen_ItemClick);
            // 
            // bbtnMailsync
            // 
            this.bbtnMailsync.Caption = "Comparison Report";
            this.bbtnMailsync.Glyph = global::LeadTimesReportGenerator.Properties.Resources.Parcel;
            this.bbtnMailsync.Id = 63;
            this.bbtnMailsync.LargeGlyph = global::LeadTimesReportGenerator.Properties.Resources.Parcel;
            this.bbtnMailsync.Name = "bbtnMailsync";
            this.bbtnMailsync.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnMailsync_ItemClick);
            // 
            // bbtnSetFromColumn
            // 
            this.bbtnSetFromColumn.Caption = "Set From Tracker Column";
            this.bbtnSetFromColumn.Glyph = global::LeadTimesReportGenerator.Properties.Resources.Column;
            this.bbtnSetFromColumn.Id = 64;
            this.bbtnSetFromColumn.LargeGlyph = global::LeadTimesReportGenerator.Properties.Resources.Column;
            this.bbtnSetFromColumn.Name = "bbtnSetFromColumn";
            this.bbtnSetFromColumn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnSetFromColumn_ItemClick);
            // 
            // bbtnSetToColumn
            // 
            this.bbtnSetToColumn.Caption = "Set To Tracker Column";
            this.bbtnSetToColumn.Glyph = global::LeadTimesReportGenerator.Properties.Resources.Column;
            this.bbtnSetToColumn.Id = 65;
            this.bbtnSetToColumn.LargeGlyph = global::LeadTimesReportGenerator.Properties.Resources.Column;
            this.bbtnSetToColumn.Name = "bbtnSetToColumn";
            this.bbtnSetToColumn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnSetToColumn_ItemClick);
            // 
            // bbtnTrackingDetails
            // 
            this.bbtnTrackingDetails.Caption = "Get Tracking Details";
            this.bbtnTrackingDetails.Glyph = global::LeadTimesReportGenerator.Properties.Resources.Map_Location;
            this.bbtnTrackingDetails.Id = 66;
            this.bbtnTrackingDetails.LargeGlyph = global::LeadTimesReportGenerator.Properties.Resources.Map_Location;
            this.bbtnTrackingDetails.Name = "bbtnTrackingDetails";
            this.bbtnTrackingDetails.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnTrackingDetails_ItemClick);
            // 
            // bbtnTrackingSummary
            // 
            this.bbtnTrackingSummary.Caption = "Get Tracking Summary";
            this.bbtnTrackingSummary.Glyph = global::LeadTimesReportGenerator.Properties.Resources.Location;
            this.bbtnTrackingSummary.Id = 67;
            this.bbtnTrackingSummary.LargeGlyph = global::LeadTimesReportGenerator.Properties.Resources.Location;
            this.bbtnTrackingSummary.Name = "bbtnTrackingSummary";
            this.bbtnTrackingSummary.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnTrackingSummary_ItemClick);
            // 
            // bbtnExcelExport
            // 
            this.bbtnExcelExport.Caption = "Export to Excel";
            this.bbtnExcelExport.Glyph = global::LeadTimesReportGenerator.Properties.Resources.Excel;
            this.bbtnExcelExport.Id = 68;
            this.bbtnExcelExport.LargeGlyph = global::LeadTimesReportGenerator.Properties.Resources.Excel;
            this.bbtnExcelExport.Name = "bbtnExcelExport";
            this.bbtnExcelExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnExcelExport_ItemClick);
            // 
            // btnFlagColumn
            // 
            this.btnFlagColumn.Caption = "FlagColumn";
            this.btnFlagColumn.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnFlagColumn.Glyph = global::LeadTimesReportGenerator.Properties.Resources.Flag_02;
            this.btnFlagColumn.Id = 69;
            this.btnFlagColumn.LargeGlyph = global::LeadTimesReportGenerator.Properties.Resources.Flag_02;
            this.btnFlagColumn.Name = "btnFlagColumn";
            this.btnFlagColumn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFlagColumn_ItemClick);
            // 
            // bbtnStatusReport
            // 
            this.bbtnStatusReport.Caption = "Status Report";
            this.bbtnStatusReport.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbtnStatusReport.Glyph = global::LeadTimesReportGenerator.Properties.Resources.Load_Man;
            this.bbtnStatusReport.Id = 70;
            this.bbtnStatusReport.LargeGlyph = global::LeadTimesReportGenerator.Properties.Resources.Load_Man;
            this.bbtnStatusReport.Name = "bbtnStatusReport";
            this.bbtnStatusReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnStatusReport_ItemClick);
            // 
            // ribbonImageCollectionLarge
            // 
            this.ribbonImageCollectionLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.ribbonImageCollectionLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollectionLarge.ImageStream")));
            this.ribbonImageCollectionLarge.Images.SetKeyName(0, "Ribbon_New_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(1, "Ribbon_Open_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(2, "Ribbon_Close_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(3, "Ribbon_Find_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(4, "Ribbon_Save_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(5, "Ribbon_SaveAs_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(6, "Ribbon_Exit_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(7, "Ribbon_Content_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(8, "Ribbon_Info_32x32.png");
            // 
            // homeRibbonPage
            // 
            this.homeRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.FileGroup,
            this.DetailsGroup,
            this.BulkCompareGroup,
            this.BulkStatusGroup});
            this.homeRibbonPage.Name = "homeRibbonPage";
            this.homeRibbonPage.Text = "Home";
            // 
            // FileGroup
            // 
            this.FileGroup.ItemLinks.Add(this.bbtnOpen);
            this.FileGroup.ItemLinks.Add(this.bbtnExcelExport);
            this.FileGroup.Name = "FileGroup";
            this.FileGroup.Text = "File";
            // 
            // DetailsGroup
            // 
            this.DetailsGroup.ItemLinks.Add(this.bbtnTrackingSummary);
            this.DetailsGroup.ItemLinks.Add(this.bbtnTrackingDetails);
            this.DetailsGroup.Name = "DetailsGroup";
            this.DetailsGroup.Text = "Tracking Details";
            // 
            // BulkCompareGroup
            // 
            this.BulkCompareGroup.ItemLinks.Add(this.bbtnSetFromColumn);
            this.BulkCompareGroup.ItemLinks.Add(this.bbtnSetToColumn);
            this.BulkCompareGroup.ItemLinks.Add(this.bbtnMailsync);
            this.BulkCompareGroup.Name = "BulkCompareGroup";
            this.BulkCompareGroup.Text = "Bulk Compare";
            // 
            // BulkStatusGroup
            // 
            this.BulkStatusGroup.ItemLinks.Add(this.btnFlagColumn);
            this.BulkStatusGroup.ItemLinks.Add(this.bbtnStatusReport);
            this.BulkStatusGroup.Name = "BulkStatusGroup";
            this.BulkStatusGroup.Text = "Bulk Status";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 673);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1096, 27);
            // 
            // gridDataInfo
            // 
            this.gridDataInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDataInfo.Location = new System.Drawing.Point(0, 146);
            this.gridDataInfo.MainView = this.gridDataView;
            this.gridDataInfo.Name = "gridDataInfo";
            this.gridDataInfo.Size = new System.Drawing.Size(1096, 527);
            this.gridDataInfo.TabIndex = 0;
            this.gridDataInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridDataView});
            // 
            // gridDataView
            // 
            this.gridDataView.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridDataView.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridDataView.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridDataView.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gridDataView.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridDataView.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridDataView.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridDataView.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridDataView.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.gridDataView.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.gridDataView.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.gridDataView.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridDataView.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridDataView.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridDataView.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridDataView.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridDataView.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridDataView.Appearance.Empty.Options.UseBackColor = true;
            this.gridDataView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridDataView.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridDataView.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridDataView.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridDataView.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridDataView.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridDataView.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridDataView.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridDataView.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridDataView.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridDataView.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridDataView.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridDataView.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridDataView.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridDataView.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.gridDataView.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridDataView.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridDataView.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridDataView.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridDataView.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridDataView.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridDataView.Appearance.FocusedCell.Options.UseFont = true;
            this.gridDataView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.gridDataView.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridDataView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridDataView.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridDataView.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridDataView.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridDataView.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridDataView.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridDataView.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridDataView.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridDataView.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridDataView.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridDataView.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridDataView.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridDataView.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridDataView.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridDataView.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridDataView.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridDataView.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridDataView.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridDataView.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridDataView.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridDataView.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridDataView.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridDataView.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridDataView.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridDataView.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridDataView.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridDataView.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridDataView.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridDataView.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridDataView.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridDataView.Appearance.GroupRow.Options.UseFont = true;
            this.gridDataView.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridDataView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridDataView.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridDataView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridDataView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridDataView.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridDataView.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridDataView.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridDataView.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridDataView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.gridDataView.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridDataView.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridDataView.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridDataView.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gridDataView.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridDataView.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridDataView.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridDataView.Appearance.OddRow.Options.UseBackColor = true;
            this.gridDataView.Appearance.OddRow.Options.UseForeColor = true;
            this.gridDataView.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.gridDataView.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.gridDataView.Appearance.Preview.Options.UseBackColor = true;
            this.gridDataView.Appearance.Preview.Options.UseForeColor = true;
            this.gridDataView.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridDataView.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridDataView.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridDataView.Appearance.Row.Options.UseBackColor = true;
            this.gridDataView.Appearance.Row.Options.UseFont = true;
            this.gridDataView.Appearance.Row.Options.UseForeColor = true;
            this.gridDataView.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridDataView.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridDataView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.gridDataView.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridDataView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridDataView.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridDataView.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gridDataView.Appearance.VertLine.Options.UseBackColor = true;
            this.gridDataView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gridDataView.GridControl = this.gridDataInfo;
            this.gridDataView.Name = "gridDataView";
            this.gridDataView.OptionsBehavior.Editable = false;
            this.gridDataView.OptionsCustomization.AllowGroup = false;
            this.gridDataView.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridDataView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridDataView.OptionsSelection.UseIndicatorForSelection = false;
            this.gridDataView.OptionsView.ShowGroupPanel = false;
            // 
            // gridResults
            // 
            this.gridResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridResults.Location = new System.Drawing.Point(0, 146);
            this.gridResults.MainView = this.gridResultsView;
            this.gridResults.Name = "gridResults";
            this.gridResults.Size = new System.Drawing.Size(1096, 527);
            this.gridResults.TabIndex = 5;
            this.gridResults.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridResultsView});
            this.gridResults.Visible = false;
            // 
            // gridResultsView
            // 
            this.gridResultsView.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridResultsView.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridResultsView.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridResultsView.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gridResultsView.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridResultsView.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridResultsView.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridResultsView.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridResultsView.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.gridResultsView.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.gridResultsView.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.gridResultsView.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridResultsView.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridResultsView.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridResultsView.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridResultsView.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridResultsView.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridResultsView.Appearance.Empty.Options.UseBackColor = true;
            this.gridResultsView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridResultsView.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridResultsView.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridResultsView.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridResultsView.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridResultsView.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridResultsView.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridResultsView.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridResultsView.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridResultsView.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridResultsView.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridResultsView.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridResultsView.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridResultsView.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridResultsView.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.gridResultsView.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridResultsView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.gridResultsView.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridResultsView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridResultsView.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridResultsView.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridResultsView.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridResultsView.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridResultsView.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridResultsView.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridResultsView.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridResultsView.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridResultsView.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridResultsView.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridResultsView.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridResultsView.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridResultsView.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridResultsView.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridResultsView.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridResultsView.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridResultsView.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridResultsView.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridResultsView.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridResultsView.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridResultsView.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridResultsView.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridResultsView.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridResultsView.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridResultsView.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridResultsView.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridResultsView.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridResultsView.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridResultsView.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridResultsView.Appearance.GroupRow.Options.UseFont = true;
            this.gridResultsView.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridResultsView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridResultsView.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridResultsView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridResultsView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridResultsView.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridResultsView.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridResultsView.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridResultsView.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridResultsView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.gridResultsView.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridResultsView.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridResultsView.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridResultsView.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gridResultsView.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridResultsView.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridResultsView.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridResultsView.Appearance.OddRow.Options.UseBackColor = true;
            this.gridResultsView.Appearance.OddRow.Options.UseForeColor = true;
            this.gridResultsView.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.gridResultsView.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.gridResultsView.Appearance.Preview.Options.UseBackColor = true;
            this.gridResultsView.Appearance.Preview.Options.UseForeColor = true;
            this.gridResultsView.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridResultsView.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridResultsView.Appearance.Row.Options.UseBackColor = true;
            this.gridResultsView.Appearance.Row.Options.UseForeColor = true;
            this.gridResultsView.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridResultsView.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridResultsView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.gridResultsView.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridResultsView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridResultsView.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridResultsView.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gridResultsView.Appearance.VertLine.Options.UseBackColor = true;
            this.gridResultsView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gridResultsView.GridControl = this.gridResults;
            this.gridResultsView.Name = "gridResultsView";
            this.gridResultsView.OptionsBehavior.Editable = false;
            this.gridResultsView.OptionsCustomization.AllowGroup = false;
            this.gridResultsView.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridResultsView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridResultsView.OptionsSelection.UseIndicatorForSelection = false;
            this.gridResultsView.OptionsView.EnableAppearanceEvenRow = true;
            this.gridResultsView.OptionsView.EnableAppearanceOddRow = true;
            this.gridResultsView.OptionsView.ShowGroupPanel = false;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013 Dark Gray";
            // 
            // LeadTimes
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 700);
            this.Controls.Add(this.gridResults);
            this.Controls.Add(this.gridDataInfo);
            this.Controls.Add(this.popupControlContainer1);
            this.Controls.Add(this.popupControlContainer2);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LeadTimes";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "CAS USPS Report Creator";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer2)).EndInit();
            this.popupControlContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).EndInit();
            this.popupControlContainer1.ResumeLayout(false);
            this.popupControlContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage homeRibbonPage;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu appMenu;
        private DevExpress.XtraBars.PopupControlContainer popupControlContainer1;
        private DevExpress.XtraEditors.LabelControl someLabelControl2;
        private DevExpress.XtraEditors.LabelControl someLabelControl1;
        private DevExpress.XtraBars.PopupControlContainer popupControlContainer2;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.Utils.ImageCollection ribbonImageCollection;
        private DevExpress.Utils.ImageCollection ribbonImageCollectionLarge;
        private DevExpress.XtraGrid.GridControl gridDataInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridDataView;
        private DevExpress.XtraBars.BarButtonItem bbtnOpen;
        private DevExpress.XtraBars.BarButtonItem bbtnMailsync;
        private DevExpress.XtraBars.BarButtonItem bbtnSetFromColumn;
        private DevExpress.XtraBars.BarButtonItem bbtnSetToColumn;
        private DevExpress.XtraGrid.GridControl gridResults;
        private DevExpress.XtraGrid.Views.Grid.GridView gridResultsView;
        private DevExpress.XtraBars.BarButtonItem bbtnTrackingDetails;
        private DevExpress.XtraBars.BarButtonItem bbtnTrackingSummary;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup FileGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup BulkCompareGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup DetailsGroup;
        private DevExpress.XtraBars.BarButtonItem bbtnExcelExport;
        private DevExpress.XtraBars.BarButtonItem btnFlagColumn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup BulkStatusGroup;
        private DevExpress.XtraBars.BarButtonItem bbtnStatusReport;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashManager;

    }
}
