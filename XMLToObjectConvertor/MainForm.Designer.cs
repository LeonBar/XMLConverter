namespace XmlConverter
{
    partial class MainForm
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnConvertToObject = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnUpdateSelected = new System.Windows.Forms.Button();
            this.btnUpdateAll = new System.Windows.Forms.Button();
            this.groupBoxDatabase = new System.Windows.Forms.GroupBox();
            this.btnMakeXML = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dbListBox = new System.Windows.Forms.ListBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBoxDatabase.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(12, 12);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(219, 20);
            this.txtFileName.TabIndex = 0;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(237, 10);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Browse";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnConvertToObject
            // 
            this.btnConvertToObject.Location = new System.Drawing.Point(12, 38);
            this.btnConvertToObject.Name = "btnConvertToObject";
            this.btnConvertToObject.Size = new System.Drawing.Size(300, 42);
            this.btnConvertToObject.TabIndex = 2;
            this.btnConvertToObject.Text = "Convert To Object";
            this.btnConvertToObject.UseVisualStyleBackColor = true;
            this.btnConvertToObject.Click += new System.EventHandler(this.btnConvertToObject_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 86);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(300, 160);
            this.listBox.TabIndex = 3;
            // 
            // btnUpdateSelected
            // 
            this.btnUpdateSelected.Enabled = false;
            this.btnUpdateSelected.Location = new System.Drawing.Point(12, 252);
            this.btnUpdateSelected.Name = "btnUpdateSelected";
            this.btnUpdateSelected.Size = new System.Drawing.Size(300, 23);
            this.btnUpdateSelected.TabIndex = 4;
            this.btnUpdateSelected.Text = "Update Selected to Database";
            this.btnUpdateSelected.UseVisualStyleBackColor = true;
            // 
            // btnUpdateAll
            // 
            this.btnUpdateAll.Location = new System.Drawing.Point(12, 281);
            this.btnUpdateAll.Name = "btnUpdateAll";
            this.btnUpdateAll.Size = new System.Drawing.Size(300, 23);
            this.btnUpdateAll.TabIndex = 5;
            this.btnUpdateAll.Text = "Insert all to Database";
            this.btnUpdateAll.UseVisualStyleBackColor = true;
            this.btnUpdateAll.Click += new System.EventHandler(this.btnUpdateAll_Click);
            // 
            // groupBoxDatabase
            // 
            this.groupBoxDatabase.Controls.Add(this.btnMakeXML);
            this.groupBoxDatabase.Controls.Add(this.btnDelete);
            this.groupBoxDatabase.Controls.Add(this.btnEdit);
            this.groupBoxDatabase.Controls.Add(this.dbListBox);
            this.groupBoxDatabase.Controls.Add(this.btnLoad);
            this.groupBoxDatabase.Location = new System.Drawing.Point(318, 10);
            this.groupBoxDatabase.Name = "groupBoxDatabase";
            this.groupBoxDatabase.Size = new System.Drawing.Size(293, 304);
            this.groupBoxDatabase.TabIndex = 6;
            this.groupBoxDatabase.TabStop = false;
            this.groupBoxDatabase.Text = "Database";
            // 
            // btnMakeXML
            // 
            this.btnMakeXML.Location = new System.Drawing.Point(7, 242);
            this.btnMakeXML.Name = "btnMakeXML";
            this.btnMakeXML.Size = new System.Drawing.Size(278, 52);
            this.btnMakeXML.TabIndex = 8;
            this.btnMakeXML.Text = "Convert To XML file";
            this.btnMakeXML.UseVisualStyleBackColor = true;
            this.btnMakeXML.Click += new System.EventHandler(this.btnMakeXML_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(196, 213);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(102, 213);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // dbListBox
            // 
            this.dbListBox.FormattingEnabled = true;
            this.dbListBox.HorizontalScrollbar = true;
            this.dbListBox.Location = new System.Drawing.Point(6, 47);
            this.dbListBox.Name = "dbListBox";
            this.dbListBox.Size = new System.Drawing.Size(279, 160);
            this.dbListBox.TabIndex = 7;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(6, 18);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(279, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Refresh";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(324, 223);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(88, 23);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 318);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.groupBoxDatabase);
            this.Controls.Add(this.btnUpdateAll);
            this.Controls.Add(this.btnUpdateSelected);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnConvertToObject);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.txtFileName);
            this.Name = "MainForm";
            this.Text = "XML To Object Converter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxDatabase.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnConvertToObject;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnUpdateSelected;
        private System.Windows.Forms.Button btnUpdateAll;
        private System.Windows.Forms.GroupBox groupBoxDatabase;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListBox dbListBox;
        private System.Windows.Forms.Button btnMakeXML;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
    }
}

