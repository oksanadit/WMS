using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Windows.Forms;
using WMS.Models;

namespace WMS.View
{
    public partial class rfrmDocumentDetail : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Property
        public Document Document { get; set; }
        private WMSEntities DBWMSContext { get { return WMSContext.Inst; } }
        #endregion
        #region Constructor
        public rfrmDocumentDetail()
        {
            InitializeComponent();
        }
        #endregion
        #region Events
        private void rfrmDocumentDetail_Load(object sender, EventArgs e)
        {
            documentBindingSource.DataSource = Document;
        }

        private void btAddPositions_ItemClick(object sender, ItemClickEventArgs e)
        {
            DocumentPosition item = new DocumentPosition();
            item.Created = DateTime.UtcNow;

            Document.DocumentPosition.Add(item);
            RefreshView();
        }

        private void btDeletePosition_ItemClick(object sender, ItemClickEventArgs e)
        {
            var row = gridView1.GetFocusedRow() as DocumentPosition;
            if (row == null)
                return;

            row.Deleted = true;
            Document.DocumentPosition.Remove(row);

            if (row.ID_Position > 0)
            {
                DBWMSContext.DocumentPosition.Remove(row);
            }
            RefreshView();
        }

        private void btSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Save())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void rfrmDocumentDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel)
            {
                var dr = XtraMessageBox.Show("Save changes?", "Form closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    if (Save())
                    {

                        this.DialogResult = DialogResult.OK;
                    }              
                }
                else
                {

                    foreach (var entity in DBWMSContext.ChangeTracker.Entries())
                    {
                        if(entity.State == System.Data.Entity.EntityState.Added)
                        {
                            entity.State = System.Data.Entity.EntityState.Deleted;
                        }
                        entity.Reload();

                    }
                }
            }

        }
        #endregion
        #region Methods
        private bool Save()
        { 
            if (string.IsNullOrWhiteSpace(Document.Client) || string.IsNullOrWhiteSpace(Document.Name) || Document.DocumentPosition.Any(x=> x.Name == null))
            {
                var dr = XtraMessageBox.Show("Complete the data (Name, Client)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            if (Document.ID_Document == 0)
            {
                DBWMSContext.Document.Add(Document);
                DBWMSContext.SaveChanges();
                AddEvent(Document, "ADD");
            }
            else
            {
                AddEvent(Document, "EDIT");
            }

            DBWMSContext.SaveChanges();

            return true;
        }

        private void RefreshView()
        {
            documentBindingSource.Clear();
            documentBindingSource.DataSource = new Document();
            documentBindingSource.DataSource = Document as Document;
        }

        private void AddEvent(Document document, string kind )
        {
            var settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            };

            string jsonString = JsonConvert.SerializeObject(document, settings);
            DBWMSContext.EventLog.Add(new EventLog {Type = kind,  Description = jsonString, CreatedDate = DateTime.UtcNow, ID_Document = document.ID_Document });
        }
        #endregion
    }
}