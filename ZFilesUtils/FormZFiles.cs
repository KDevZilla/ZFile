using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZFilesUtils
{
    public partial class FormZFiles : Form
    {
        public FormZFiles()
        {
            InitializeComponent();
        }

        private void btnSearchByPattern_Click(object sender, EventArgs e)
        {
            try
            {
                SearchFile search = new SearchFile();
                List<String> listFiles = search.SearchByPattern(this.txtPath.Text, this.txtPattern.Text);
                FormSearchResult f = new FormSearchResult();
                f.SetDataSearchByPattern(listFiles);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FormZFiles_Load(object sender, EventArgs e)
        {
            //Please run program withou Visual Studio to see the result
            //Drag drop has the problem when you run from Visual Studio
            this.txtListofthefiles.AllowDrop = true;
            this.txtListofthefiles.DragDrop += (o, e2) =>
            {
                if (e2.Data.GetDataPresent(DataFormats.FileDrop))
                    e2.Effect = DragDropEffects.Copy;
                else
                    e2.Effect = DragDropEffects.None;
            };
            this.txtListofthefiles.DragEnter += (o, e2) =>
            {
                if (e2.Data.GetDataPresent(DataFormats.FileDrop))
                    e2.Effect = DragDropEffects.Copy;
                else
                    e2.Effect = DragDropEffects.None;
            };
            this.txtListofthefiles.DragOver += (o, e2) =>
            {
                string[] files = (string[])e2.Data.GetData(DataFormats.FileDrop);
                if (files != null && files.Length != 0)
                {
                    using (StreamReader reader = new StreamReader(files[0]))
                    {
                        this.txtListofthefiles.Text = reader.ReadToEnd();
                        reader.Close();
                        reader.Dispose();
                    }
                }
            };

            String listofFilesSample = @"D:\Test\File001.txt" + Environment.NewLine
                + @"D:\Test\File002.txt" + Environment.NewLine;

            Utils.MakeTextBoxShowSampleValue(this.txtPath, @"D:\MyFiles\001\");
            Utils.MakeTextBoxShowSampleValue(this.txtPattern, @"*.txt");
            Utils.MakeTextBoxShowSampleValue(this.txtListofthefiles, listofFilesSample);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SearchFile search = new SearchFile();
                // List<String> listFiles = search.SearchByPattern(this.txtPath.Text, this.txtPattern.Text);
                List<String> listOfFileToSearch = new List<string>();

                String listoffileText = this.txtListofthefiles.Text;
                var listofFileToSearch = listoffileText
                                    .Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                                    .ToList();

                var searchResult = search.SearchListOfFiles(listofFileToSearch);
                FormSearchResult f = new FormSearchResult();
                f.SetDataSearchByListFiles (searchResult);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
