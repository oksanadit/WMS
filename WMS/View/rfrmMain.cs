using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Windows.Forms;
using WMS.Models;

namespace WMS.View
{
    public partial class rfrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
    #region const
    private const string const_RelationName = "DocumentPosition";
        #endregion

        #region Property
        public Document CurrentDocument { get { return documentBindingSource.Current as Document; } }

        private WMSEntities DBWMSContext { get { return WMSContext.Inst; } }
        #endregion
        #region constructor
        public rfrmMain()
        {
            InitializeComponent();
        }
        #endregion
        #region Events
        private void bbtEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (CurrentDocument == null)
                return;
            using(rfrmDocumentDetail view = new rfrmDocumentDetail())
            {

                view.Document = CurrentDocument;
                
                var dr = view.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    int focusedRow = grdvDocuments.FocusedRowHandle;

                    RefreshView();

                    grdvDocuments.FocusedRowHandle = focusedRow;
                    grdvDocuments.SelectRow(focusedRow);
                    grdvDocuments.Focus();
                }

            }


        }

        private void bbtAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            Document newDoc = new Document();

            using (rfrmDocumentDetail view = new rfrmDocumentDetail())
            {
                view.Document = newDoc;
                var dr = view.ShowDialog();
                if(dr == DialogResult.OK)
                {
                    RefreshView();
                }
            }

        }

        private void bbtDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (CurrentDocument == null)
                return;
            var dr = XtraMessageBox.Show($"Do you want to delete invoce {CurrentDocument?.Name}? ", "Deleting invoce", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                    if (CurrentDocument.DocumentPosition.Count > 0)
                    {
                        foreach (var p in CurrentDocument.DocumentPosition.ToList())
                        {
                            DBWMSContext.DocumentPosition.Remove(p);
                        }

                    }
                    DBWMSContext.Document.Remove(CurrentDocument);

                    AddEvent(CurrentDocument, "DELETE");

                    DBWMSContext.SaveChanges();

                    documentBindingSource.RemoveCurrent();
               
            }
        }

        private void rfrmMain_Load(object sender, EventArgs e)
        {
            documentBindingSource.DataSource = DBWMSContext.Document.ToList();
        }

        private void grdvDocuments_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            GridView view = sender as GridView;
            Document doc = view.GetRow(e.RowHandle) as Document;
            if (doc != null)
            {
                e.ChildList = doc.DocumentPosition.ToList();
            }
        }

        private void grdvDocuments_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void grdvDocuments_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = const_RelationName;
        }

        private void grdvDocuments_MasterRowEmpty(object sender, MasterRowEmptyEventArgs e)
        {
            GridView view = sender as GridView;
            Document doc = view.GetRow(e.RowHandle) as Document;
            if (doc != null)
            {
                e.IsEmpty = !doc.DocumentPosition.Any();
            }
        }
        #endregion
        #region Method
        private void RefreshView()
        {
            
            documentBindingSource.Clear();
            documentBindingSource.DataSource = DBWMSContext.Document.ToList();
        }

        private void AddEvent(Document document, string kind)
        {
            var settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            };

            string jsonString = JsonConvert.SerializeObject(document, settings);
            DBWMSContext.EventLog.Add(new EventLog { Type = kind, Description = jsonString, CreatedDate = DateTime.UtcNow, ID_Document = document.ID_Document });
        }

        #endregion

    }
}