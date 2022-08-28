
namespace WMS.View
{
    partial class rfrmDocumentDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rfrmDocumentDetail));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btAddPositions = new DevExpress.XtraBars.BarButtonItem();
            this.btDeletePosition = new DevExpress.XtraBars.BarButtonItem();
            this.btSave = new DevExpress.XtraBars.BarButtonItem();
            this.rpAction = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgSave = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgItems = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.documentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CreatedDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.TotalGrossTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TotalNetTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DocumentPositionGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGross = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForClient = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCreated = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTotalGross = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTotalNet = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDocumentPosition = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreatedDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreatedDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalGrossTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalNetTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentPositionGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCreated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTotalGross)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTotalNet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDocumentPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btAddPositions,
            this.btDeletePosition,
            this.btSave});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpAction});
            this.ribbon.Size = new System.Drawing.Size(1211, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btAddPositions
            // 
            this.btAddPositions.Caption = "Add";
            this.btAddPositions.Hint = "Add document position";
            this.btAddPositions.Id = 1;
            this.btAddPositions.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btAddPositions.ImageOptions.Image")));
            this.btAddPositions.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btAddPositions.ImageOptions.LargeImage")));
            this.btAddPositions.Name = "btAddPositions";
            this.btAddPositions.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btAddPositions_ItemClick);
            // 
            // btDeletePosition
            // 
            this.btDeletePosition.Caption = "Delete";
            this.btDeletePosition.Id = 2;
            this.btDeletePosition.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btDeletePosition.ImageOptions.Image")));
            this.btDeletePosition.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btDeletePosition.ImageOptions.LargeImage")));
            this.btDeletePosition.Name = "btDeletePosition";
            this.btDeletePosition.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btDeletePosition_ItemClick);
            // 
            // btSave
            // 
            this.btSave.Caption = "Save and close";
            this.btSave.Id = 3;
            this.btSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btSave.ImageOptions.Image")));
            this.btSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btSave.ImageOptions.LargeImage")));
            this.btSave.Name = "btSave";
            this.btSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btSave_ItemClick);
            // 
            // rpAction
            // 
            this.rpAction.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgSave,
            this.rpgItems});
            this.rpAction.Name = "rpAction";
            this.rpAction.Text = "Action";
            // 
            // rpgSave
            // 
            this.rpgSave.ItemLinks.Add(this.btSave);
            this.rpgSave.Name = "rpgSave";
            // 
            // rpgItems
            // 
            this.rpgItems.ItemLinks.Add(this.btAddPositions);
            this.rpgItems.ItemLinks.Add(this.btDeletePosition);
            this.rpgItems.Name = "rpgItems";
            this.rpgItems.Text = "Items";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 838);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1211, 24);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.NameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ClientTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CreatedDateEdit);
            this.dataLayoutControl1.Controls.Add(this.TotalGrossTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TotalNetTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DocumentPositionGridControl);
            this.dataLayoutControl1.DataSource = this.documentBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForTotalGross,
            this.ItemForTotalNet});
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 158);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1211, 680);
            this.dataLayoutControl1.TabIndex = 2;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.documentBindingSource, "Name", true));
            this.NameTextEdit.Location = new System.Drawing.Point(63, 12);
            this.NameTextEdit.MenuManager = this.ribbon;
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Size = new System.Drawing.Size(1136, 20);
            this.NameTextEdit.StyleController = this.dataLayoutControl1;
            this.NameTextEdit.TabIndex = 0;
            // 
            // documentBindingSource
            // 
            this.documentBindingSource.DataSource = typeof(WMS.Models.Document);
            // 
            // ClientTextEdit
            // 
            this.ClientTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.documentBindingSource, "Client", true));
            this.ClientTextEdit.Location = new System.Drawing.Point(63, 36);
            this.ClientTextEdit.MenuManager = this.ribbon;
            this.ClientTextEdit.Name = "ClientTextEdit";
            this.ClientTextEdit.Size = new System.Drawing.Size(1136, 20);
            this.ClientTextEdit.StyleController = this.dataLayoutControl1;
            this.ClientTextEdit.TabIndex = 2;
            // 
            // CreatedDateEdit
            // 
            this.CreatedDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.documentBindingSource, "Created", true));
            this.CreatedDateEdit.EditValue = null;
            this.CreatedDateEdit.Location = new System.Drawing.Point(63, 60);
            this.CreatedDateEdit.MenuManager = this.ribbon;
            this.CreatedDateEdit.Name = "CreatedDateEdit";
            this.CreatedDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.CreatedDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CreatedDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CreatedDateEdit.Size = new System.Drawing.Size(1136, 20);
            this.CreatedDateEdit.StyleController = this.dataLayoutControl1;
            this.CreatedDateEdit.TabIndex = 3;
            // 
            // TotalGrossTextEdit
            // 
            this.TotalGrossTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.documentBindingSource, "TotalGross", true));
            this.TotalGrossTextEdit.Location = new System.Drawing.Point(78, 84);
            this.TotalGrossTextEdit.MenuManager = this.ribbon;
            this.TotalGrossTextEdit.Name = "TotalGrossTextEdit";
            this.TotalGrossTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.TotalGrossTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.TotalGrossTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TotalGrossTextEdit.Properties.Mask.EditMask = "F";
            this.TotalGrossTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TotalGrossTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TotalGrossTextEdit.Properties.ReadOnly = true;
            this.TotalGrossTextEdit.Size = new System.Drawing.Size(1121, 20);
            this.TotalGrossTextEdit.StyleController = this.dataLayoutControl1;
            this.TotalGrossTextEdit.TabIndex = 4;
            // 
            // TotalNetTextEdit
            // 
            this.TotalNetTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.documentBindingSource, "TotalNet", true));
            this.TotalNetTextEdit.Location = new System.Drawing.Point(78, 108);
            this.TotalNetTextEdit.MenuManager = this.ribbon;
            this.TotalNetTextEdit.Name = "TotalNetTextEdit";
            this.TotalNetTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.TotalNetTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.TotalNetTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TotalNetTextEdit.Properties.Mask.EditMask = "F";
            this.TotalNetTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TotalNetTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TotalNetTextEdit.Properties.ReadOnly = true;
            this.TotalNetTextEdit.Size = new System.Drawing.Size(1121, 20);
            this.TotalNetTextEdit.StyleController = this.dataLayoutControl1;
            this.TotalNetTextEdit.TabIndex = 5;
            // 
            // DocumentPositionGridControl
            // 
            this.DocumentPositionGridControl.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.documentBindingSource, "DocumentPosition", true));
            gridLevelNode1.RelationName = "Level1";
            this.DocumentPositionGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.DocumentPositionGridControl.Location = new System.Drawing.Point(12, 84);
            this.DocumentPositionGridControl.MainView = this.gridView1;
            this.DocumentPositionGridControl.MenuManager = this.ribbon;
            this.DocumentPositionGridControl.Name = "DocumentPositionGridControl";
            this.DocumentPositionGridControl.Size = new System.Drawing.Size(1187, 584);
            this.DocumentPositionGridControl.TabIndex = 6;
            this.DocumentPositionGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colAmount,
            this.colNet,
            this.colGross});
            this.gridView1.GridControl = this.DocumentPositionGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "Amount";
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 1;
            // 
            // colNet
            // 
            this.colNet.Caption = "Net";
            this.colNet.FieldName = "Net";
            this.colNet.Name = "colNet";
            this.colNet.Visible = true;
            this.colNet.VisibleIndex = 2;
            // 
            // colGross
            // 
            this.colGross.Caption = "Gross";
            this.colGross.FieldName = "Gross";
            this.colGross.Name = "colGross";
            this.colGross.Visible = true;
            this.colGross.VisibleIndex = 3;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1211, 680);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForName,
            this.ItemForClient,
            this.ItemForCreated,
            this.ItemForDocumentPosition});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1191, 660);
            // 
            // ItemForName
            // 
            this.ItemForName.Control = this.NameTextEdit;
            this.ItemForName.Location = new System.Drawing.Point(0, 0);
            this.ItemForName.Name = "ItemForName";
            this.ItemForName.Size = new System.Drawing.Size(1191, 24);
            this.ItemForName.Text = "Name";
            this.ItemForName.TextSize = new System.Drawing.Size(39, 13);
            // 
            // ItemForClient
            // 
            this.ItemForClient.Control = this.ClientTextEdit;
            this.ItemForClient.Location = new System.Drawing.Point(0, 24);
            this.ItemForClient.Name = "ItemForClient";
            this.ItemForClient.Size = new System.Drawing.Size(1191, 24);
            this.ItemForClient.Text = "Client";
            this.ItemForClient.TextSize = new System.Drawing.Size(39, 13);
            // 
            // ItemForCreated
            // 
            this.ItemForCreated.Control = this.CreatedDateEdit;
            this.ItemForCreated.Location = new System.Drawing.Point(0, 48);
            this.ItemForCreated.Name = "ItemForCreated";
            this.ItemForCreated.Size = new System.Drawing.Size(1191, 24);
            this.ItemForCreated.Text = "Created";
            this.ItemForCreated.TextSize = new System.Drawing.Size(39, 13);
            // 
            // ItemForTotalGross
            // 
            this.ItemForTotalGross.Control = this.TotalGrossTextEdit;
            this.ItemForTotalGross.Location = new System.Drawing.Point(0, 72);
            this.ItemForTotalGross.Name = "ItemForTotalGross";
            this.ItemForTotalGross.Size = new System.Drawing.Size(1191, 24);
            this.ItemForTotalGross.Text = "Total Gross";
            this.ItemForTotalGross.TextSize = new System.Drawing.Size(54, 13);
            // 
            // ItemForTotalNet
            // 
            this.ItemForTotalNet.Control = this.TotalNetTextEdit;
            this.ItemForTotalNet.Location = new System.Drawing.Point(0, 72);
            this.ItemForTotalNet.Name = "ItemForTotalNet";
            this.ItemForTotalNet.Size = new System.Drawing.Size(1191, 48);
            this.ItemForTotalNet.Text = "Total Net";
            this.ItemForTotalNet.TextSize = new System.Drawing.Size(54, 13);
            // 
            // ItemForDocumentPosition
            // 
            this.ItemForDocumentPosition.Control = this.DocumentPositionGridControl;
            this.ItemForDocumentPosition.Location = new System.Drawing.Point(0, 72);
            this.ItemForDocumentPosition.Name = "ItemForDocumentPosition";
            this.ItemForDocumentPosition.Size = new System.Drawing.Size(1191, 588);
            this.ItemForDocumentPosition.StartNewLine = true;
            this.ItemForDocumentPosition.Text = "Document Position";
            this.ItemForDocumentPosition.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForDocumentPosition.TextVisible = false;
            // 
            // rfrmDocumentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 862);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "rfrmDocumentDetail";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Invoice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.rfrmDocumentDetail_FormClosing);
            this.Load += new System.EventHandler(this.rfrmDocumentDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreatedDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreatedDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalGrossTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalNetTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentPositionGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCreated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTotalGross)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTotalNet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDocumentPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpAction;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgItems;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private System.Windows.Forms.BindingSource documentBindingSource;
        private DevExpress.XtraEditors.TextEdit ClientTextEdit;
        private DevExpress.XtraEditors.DateEdit CreatedDateEdit;
        private DevExpress.XtraEditors.TextEdit TotalNetTextEdit;
        private DevExpress.XtraGrid.GridControl DocumentPositionGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForClient;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCreated;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTotalNet;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDocumentPosition;
        private DevExpress.XtraBars.BarButtonItem btAddPositions;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraEditors.TextEdit TotalGrossTextEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colNet;
        private DevExpress.XtraGrid.Columns.GridColumn colGross;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTotalGross;
        private DevExpress.XtraBars.BarButtonItem btDeletePosition;
        private DevExpress.XtraBars.BarButtonItem btSave;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSave;
    }
}