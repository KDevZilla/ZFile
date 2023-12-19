using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZFilesUtils
{
    public partial class FormSearchResult : Form
    {
        public FormSearchResult()
        {
            InitializeComponent();
        }

        private void FormSearchResult_Load(object sender, EventArgs e)
        {
            btnSelectAll.Click += (o, e2) =>
            {
                for (int i = 0; i < this.checkedListFileSearchResult.Items.Count; i++)
                {
                    this.checkedListFileSearchResult.SetItemChecked(i, true);
                }
            };
            btnUnSelectAll.Click += (o, e2) =>
            {
                for (int i = 0; i < this.checkedListFileSearchResult.Items.Count; i++)
                {
                    this.checkedListFileSearchResult.SetItemChecked(i, false );
                }
            };


            btnDelete.Click += BtnDelete_Click;
        }
        public  void SetDataSearchByListFiles(SearchFileResult searchResult)
        {
            int i;
            this.checkedListFileSearchResult.Items.Clear();
            searchResult.FileFound.ForEach(x => this.checkedListFileSearchResult.Items.Add(x));
            searchResult.FileNotFound.ForEach(x => this.txtCannotFound.AppendText(x + Environment.NewLine));
            this.txtCannotFound.Visible = true;
            this.lblCannotFound.Visible = true;
        }
        public void SetDataSearchByPattern(List<string> listFilesFound)
        {
            this.checkedListFileSearchResult.Items.Clear();
            listFilesFound.ForEach(x => this.checkedListFileSearchResult.Items.Add(x));
            this.txtCannotFound.Visible = false;
            this.lblCannotFound.Visible = false;

        }
        private void DisplayDeleteFileResult(List<String> listFile, DeleteFileResult delResult)
        {
            bool isSucceed = false;
            isSucceed = (listFile.Count == delResult.FileDeleted.Count);
            StringBuilder strB = new StringBuilder();
           
            if(isSucceed)
            {
                strB.Append(" Successfull delete file(s) ").Append(delResult.FileDeleted.Count)
                    .Append(Environment.NewLine);
            }
            else
            {
                strB.Append("!!! Has problem when delete file(s)").Append(Environment.NewLine);
            }

            strB.Append("   Number of file deleted ").Append(delResult.FileDeleted.Count).Append(Environment.NewLine);
            delResult.FileDeleted.ForEach(x => strB.Append(x).Append(Environment.NewLine));

            strB.Append(Environment.NewLine);
            strB.Append("   Number of file Cannot deleted ").Append(delResult.FileCannotDeleted.Count).Append(Environment.NewLine);

            if (delResult.FileCannotDeleted.Count > 0)
            {
                strB.Append("!!!!  There is file cannot be deleted.");
                delResult.FileCannotDeleted.ForEach(x => strB.Append(x.FileName)
                .Append(Environment.NewLine)
                .Append(":")
                .Append(x.ExceptionFromDelete.ToString())
                .Append(Environment.NewLine));
                
            }

            this.txtResult.Text = strB.ToString();
            this.tabControl1.SelectedTab = this.tabPageDeleteResult;

        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteFiles delFile = new DeleteFiles();
            List<String> listFile = new List<string>();
            int i;
            for (i = 0; i < this.checkedListFileSearchResult.CheckedItems.Count; i++)
            {
                string fileName = this.checkedListFileSearchResult.CheckedItems[i].ToString ();
                listFile.Add(fileName);
            }
            if(MessageBox.Show ("Do you want to delete these file ?",  "", MessageBoxButtons.OKCancel ) != DialogResult.OK)
            {
                return;
            }
            DeleteFileResult delResult=  delFile.DeleteFile(listFile, ifFileNotExistCountAsError: true);

            DisplayDeleteFileResult(listFile , delResult);

        //    delFile.DeleteFile()
            //throw new NotImplementedException();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

        }
    }
}
