
namespace WMS.View
{
    partial class rfrmMain
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rfrmMain));
            this.grdvPositions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGross = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcDocuments = new DevExpress.XtraGrid.GridControl();
            this.documentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grdvDocuments = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDocument_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colTotalGross = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalNet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbtAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbtEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbtDelete = new DevExpress.XtraBars.BarButtonItem();
            this.rbpAction = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgDocuments = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layout = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdvPositions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdcDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdvPositions
            // 
            this.grdvPositions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName1,
            this.colAmount,
            this.colGross,
            this.colNet});
            this.grdvPositions.GridControl = this.grdcDocuments;
            this.grdvPositions.Name = "grdvPositions";
            this.grdvPositions.OptionsView.ShowGroupPanel = false;
            // 
            // colName1
            // 
            this.colName1.Caption = "Name";
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.OptionsColumn.AllowEdit = false;
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 0;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "Amount";
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.OptionsColumn.AllowEdit = false;
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 1;
            // 
            // colGross
            // 
            this.colGross.Caption = "Gross";
            this.colGross.FieldName = "Gross";
            this.colGross.Name = "colGross";
            this.colGross.OptionsColumn.AllowEdit = false;
            this.colGross.Visible = true;
            this.colGross.VisibleIndex = 3;
            // 
            // colNet
            // 
            this.colNet.Caption = "Net";
            this.colNet.FieldName = "Net";
            this.colNet.Name = "colNet";
            this.colNet.Visible = true;
            this.colNet.VisibleIndex = 2;
            // 
            // grdcDocuments
            // 
            this.grdcDocuments.DataSource = this.documentBindingSource;
            gridLevelNode1.LevelTemplate = this.grdvPositions;
            gridLevelNode1.RelationName = "DocumentPosition";
            this.grdcDocuments.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grdcDocuments.Location = new System.Drawing.Point(12, 12);
            this.grdcDocuments.MainView = this.grdvDocuments;
            this.grdcDocuments.MenuManager = this.ribbon;
            this.grdcDocuments.Name = "grdcDocuments";
            this.grdcDocuments.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.grdcDocuments.Size = new System.Drawing.Size(418, 243);
            this.grdcDocuments.TabIndex = 4;
            this.grdcDocuments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvDocuments,
            this.grdvPositions});
            // 
            // documentBindingSource
            // 
            this.documentBindingSource.DataSource = typeof(WMS.Models.Document);
            // 
            // grdvDocuments
            // 
            this.grdvDocuments.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDocument_ID,
            this.colName,
            this.colClient,
            this.colCreated,
            this.colTotalGross,
            this.colTotalNet});
            this.grdvDocuments.GridControl = this.grdcDocuments;
            this.grdvDocuments.Name = "grdvDocuments";
            this.grdvDocuments.OptionsBehavior.Editable = false;
            this.grdvDocuments.OptionsDetail.ShowDetailTabs = false;
            this.grdvDocuments.OptionsView.ShowGroupPanel = false;
            this.grdvDocuments.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.grdvDocuments_MasterRowEmpty);
            this.grdvDocuments.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.grdvDocuments_MasterRowGetChildList);
            this.grdvDocuments.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.grdvDocuments_MasterRowGetRelationName);
            this.grdvDocuments.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.grdvDocuments_MasterRowGetRelationCount);
            // 
            // colDocument_ID
            // 
            this.colDocument_ID.FieldName = "Document_ID";
            this.colDocument_ID.Name = "colDocument_ID";
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colClient
            // 
            this.colClient.FieldName = "Client";
            this.colClient.Name = "colClient";
            this.colClient.Visible = true;
            this.colClient.VisibleIndex = 1;
            // 
            // colCreated
            // 
            this.colCreated.Caption = "Date";
            this.colCreated.ColumnEdit = this.repositoryItemDateEdit1;
            this.colCreated.FieldName = "Created";
            this.colCreated.Name = "colCreated";
            this.colCreated.Visible = true;
            this.colCreated.VisibleIndex = 2;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // colTotalGross
            // 
            this.colTotalGross.Caption = "Gross";
            this.colTotalGross.FieldName = "TotalGross";
            this.colTotalGross.Name = "colTotalGross";
            this.colTotalGross.Visible = true;
            this.colTotalGross.VisibleIndex = 4;
            // 
            // colTotalNet
            // 
            this.colTotalNet.Caption = "Net";
            this.colTotalNet.FieldName = "TotalNet";
            this.colTotalNet.Name = "colTotalNet";
            this.colTotalNet.Visible = true;
            this.colTotalNet.VisibleIndex = 3;
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.bbtAdd,
            this.bbtEdit,
            this.bbtDelete});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpAction});
            this.ribbon.Size = new System.Drawing.Size(442, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // bbtAdd
            // 
            this.bbtAdd.Caption = "Add";
            this.bbtAdd.Id = 1;
            this.bbtAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtAdd.ImageOptions.Image")));
            this.bbtAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtAdd.ImageOptions.LargeImage")));
            this.bbtAdd.Name = "bbtAdd";
            this.bbtAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtAdd_ItemClick);
            // 
            // bbtEdit
            // 
            this.bbtEdit.Caption = "Edit";
            this.bbtEdit.Id = 2;
            this.bbtEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtEdit.ImageOptions.Image")));
            this.bbtEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtEdit.ImageOptions.LargeImage")));
            this.bbtEdit.Name = "bbtEdit";
            this.bbtEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtEdit_ItemClick);
            // 
            // bbtDelete
            // 
            this.bbtDelete.Caption = "Delete";
            this.bbtDelete.Id = 3;
            this.bbtDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtDelete.ImageOptions.Image")));
            this.bbtDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtDelete.ImageOptions.LargeImage")));
            this.bbtDelete.Name = "bbtDelete";
            this.bbtDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtDelete_ItemClick);
            // 
            // rbpAction
            // 
            this.rbpAction.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgDocuments});
            this.rbpAction.Name = "rbpAction";
            this.rbpAction.Text = "Action";
            // 
            // rpgDocuments
            // 
            this.rpgDocuments.ItemLinks.Add(this.bbtAdd);
            this.rpgDocuments.ItemLinks.Add(this.bbtEdit);
            this.rpgDocuments.ItemLinks.Add(this.bbtDelete);
            this.rpgDocuments.Name = "rpgDocuments";
            this.rpgDocuments.Text = "Invoice";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 425);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(442, 24);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.grdcDocuments);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 158);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layout;
            this.layoutControl1.Size = new System.Drawing.Size(442, 267);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layout
            // 
            this.layout.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layout.GroupBordersVisible = false;
            this.layout.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layout.Name = "layout";
            this.layout.Size = new System.Drawing.Size(442, 267);
            this.layout.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdcDocuments;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(422, 247);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // rfrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 449);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "rfrmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Load += new System.EventHandler(this.rfrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdvPositions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdcDocuments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvDocuments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpAction;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgDocuments;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem bbtAdd;
        private DevExpress.XtraBars.BarButtonItem bbtEdit;
        private DevExpress.XtraBars.BarButtonItem bbtDelete;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl grdcDocuments;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvDocuments;
        private DevExpress.XtraLayout.LayoutControlGroup layout;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource documentBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDocument_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colClient;
        private DevExpress.XtraGrid.Columns.GridColumn colCreated;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalGross;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalNet;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvPositions;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colGross;
        private DevExpress.XtraGrid.Columns.GridColumn colNet;
    }
}