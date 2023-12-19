namespace ZFilesUtils
{
    partial class FormSearchResult
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
            this.checkedListFileSearchResult = new System.Windows.Forms.CheckedListBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnUnSelectAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSearchResult = new System.Windows.Forms.TabPage();
            this.tabPageDeleteResult = new System.Windows.Forms.TabPage();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.txtCannotFound = new System.Windows.Forms.TextBox();
            this.lblCannotFound = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageSearchResult.SuspendLayout();
            this.tabPageDeleteResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListFileSearchResult
            // 
            this.checkedListFileSearchResult.FormattingEnabled = true;
            this.checkedListFileSearchResult.Location = new System.Drawing.Point(6, 56);
            this.checkedListFileSearchResult.Name = "checkedListFileSearchResult";
            this.checkedListFileSearchResult.Size = new System.Drawing.Size(960, 244);
            this.checkedListFileSearchResult.TabIndex = 1;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(6, 15);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(110, 35);
            this.btnSelectAll.TabIndex = 2;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            // 
            // btnUnSelectAll
            // 
            this.btnUnSelectAll.Location = new System.Drawing.Point(122, 15);
            this.btnUnSelectAll.Name = "btnUnSelectAll";
            this.btnUnSelectAll.Size = new System.Drawing.Size(110, 35);
            this.btnUnSelectAll.TabIndex = 3;
            this.btnUnSelectAll.Text = "UnSelect All";
            this.btnUnSelectAll.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(6, 450);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 35);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSearchResult);
            this.tabControl1.Controls.Add(this.tabPageDeleteResult);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 533);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPageSearchResult
            // 
            this.tabPageSearchResult.Controls.Add(this.lblCannotFound);
            this.tabPageSearchResult.Controls.Add(this.txtCannotFound);
            this.tabPageSearchResult.Controls.Add(this.btnSelectAll);
            this.tabPageSearchResult.Controls.Add(this.btnDelete);
            this.tabPageSearchResult.Controls.Add(this.checkedListFileSearchResult);
            this.tabPageSearchResult.Controls.Add(this.btnUnSelectAll);
            this.tabPageSearchResult.Location = new System.Drawing.Point(4, 30);
            this.tabPageSearchResult.Name = "tabPageSearchResult";
            this.tabPageSearchResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchResult.Size = new System.Drawing.Size(976, 499);
            this.tabPageSearchResult.TabIndex = 0;
            this.tabPageSearchResult.Text = "Search Result";
            this.tabPageSearchResult.UseVisualStyleBackColor = true;
            // 
            // tabPageDeleteResult
            // 
            this.tabPageDeleteResult.Controls.Add(this.btnCopyToClipboard);
            this.tabPageDeleteResult.Controls.Add(this.txtResult);
            this.tabPageDeleteResult.Location = new System.Drawing.Point(4, 30);
            this.tabPageDeleteResult.Name = "tabPageDeleteResult";
            this.tabPageDeleteResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDeleteResult.Size = new System.Drawing.Size(976, 499);
            this.tabPageDeleteResult.TabIndex = 1;
            this.tabPageDeleteResult.Text = "Delete Result";
            this.tabPageDeleteResult.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(6, 17);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(962, 415);
            this.txtResult.TabIndex = 0;
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Location = new System.Drawing.Point(802, 438);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(166, 35);
            this.btnCopyToClipboard.TabIndex = 3;
            this.btnCopyToClipboard.Text = "Copy to Clipboard";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            // 
            // txtCannotFound
            // 
            this.txtCannotFound.Location = new System.Drawing.Point(7, 328);
            this.txtCannotFound.Multiline = true;
            this.txtCannotFound.Name = "txtCannotFound";
            this.txtCannotFound.ReadOnly = true;
            this.txtCannotFound.Size = new System.Drawing.Size(962, 116);
            this.txtCannotFound.TabIndex = 5;
            // 
            // lblCannotFound
            // 
            this.lblCannotFound.AutoSize = true;
            this.lblCannotFound.Location = new System.Drawing.Point(6, 304);
            this.lblCannotFound.Name = "lblCannotFound";
            this.lblCannotFound.Size = new System.Drawing.Size(298, 21);
            this.lblCannotFound.TabIndex = 6;
            this.lblCannotFound.Text = "List of file does not found from searching:";
            // 
            // FormSearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 559);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormSearchResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search Result";
            this.Load += new System.EventHandler(this.FormSearchResult_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageSearchResult.ResumeLayout(false);
            this.tabPageSearchResult.PerformLayout();
            this.tabPageDeleteResult.ResumeLayout(false);
            this.tabPageDeleteResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListFileSearchResult;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnUnSelectAll;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSearchResult;
        private System.Windows.Forms.TabPage tabPageDeleteResult;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblCannotFound;
        private System.Windows.Forms.TextBox txtCannotFound;
    }
}