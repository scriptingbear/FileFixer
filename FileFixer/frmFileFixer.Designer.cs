namespace FileFixer
{
    partial class frmFileFixer
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
            this.txtPreview = new System.Windows.Forms.RichTextBox();
            this.lblColumn = new System.Windows.Forms.Label();
            this.dgvExport = new System.Windows.Forms.DataGridView();
            this.colExport = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnLoadRawData = new System.Windows.Forms.Button();
            this.lstColumnPositions = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddColPos = new System.Windows.Forms.Button();
            this.btnDeleteColPos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.btnTrim = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.cboField = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblFileName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExport)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPreview
            // 
            this.txtPreview.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreview.Location = new System.Drawing.Point(163, 38);
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.Size = new System.Drawing.Size(1022, 168);
            this.txtPreview.TabIndex = 1;
            this.txtPreview.Text = "";
            this.txtPreview.WordWrap = false;
            this.txtPreview.SelectionChanged += new System.EventHandler(this.txtPreview_SelectionChanged);
            // 
            // lblColumn
            // 
            this.lblColumn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColumn.Location = new System.Drawing.Point(215, 9);
            this.lblColumn.Name = "lblColumn";
            this.lblColumn.Size = new System.Drawing.Size(38, 20);
            this.lblColumn.TabIndex = 2;
            // 
            // dgvExport
            // 
            this.dgvExport.AllowUserToAddRows = false;
            this.dgvExport.AllowUserToDeleteRows = false;
            this.dgvExport.AllowUserToResizeRows = false;
            this.dgvExport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colExport});
            this.dgvExport.Location = new System.Drawing.Point(163, 248);
            this.dgvExport.Name = "dgvExport";
            this.dgvExport.Size = new System.Drawing.Size(1022, 258);
            this.dgvExport.TabIndex = 0;
            // 
            // colExport
            // 
            this.colExport.Frozen = true;
            this.colExport.HeaderText = "Select";
            this.colExport.Name = "colExport";
            this.colExport.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colExport.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colExport.Width = 62;
            // 
            // btnLoadRawData
            // 
            this.btnLoadRawData.Location = new System.Drawing.Point(12, 86);
            this.btnLoadRawData.Name = "btnLoadRawData";
            this.btnLoadRawData.Size = new System.Drawing.Size(75, 23);
            this.btnLoadRawData.TabIndex = 5;
            this.btnLoadRawData.Text = "Load";
            this.btnLoadRawData.UseVisualStyleBackColor = true;
            this.btnLoadRawData.Click += new System.EventHandler(this.btnLoadRawData_Click);
            // 
            // lstColumnPositions
            // 
            this.lstColumnPositions.FormattingEnabled = true;
            this.lstColumnPositions.Location = new System.Drawing.Point(12, 24);
            this.lstColumnPositions.Name = "lstColumnPositions";
            this.lstColumnPositions.Size = new System.Drawing.Size(54, 56);
            this.lstColumnPositions.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Column Positions";
            // 
            // btnAddColPos
            // 
            this.btnAddColPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddColPos.Location = new System.Drawing.Point(72, 34);
            this.btnAddColPos.Name = "btnAddColPos";
            this.btnAddColPos.Size = new System.Drawing.Size(41, 20);
            this.btnAddColPos.TabIndex = 8;
            this.btnAddColPos.Text = "Add";
            this.btnAddColPos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnAddColPos, "Add current column position");
            this.btnAddColPos.UseVisualStyleBackColor = true;
            this.btnAddColPos.Click += new System.EventHandler(this.btnAddColPos_Click);
            // 
            // btnDeleteColPos
            // 
            this.btnDeleteColPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteColPos.Location = new System.Drawing.Point(72, 60);
            this.btnDeleteColPos.Name = "btnDeleteColPos";
            this.btnDeleteColPos.Size = new System.Drawing.Size(41, 20);
            this.btnDeleteColPos.TabIndex = 9;
            this.btnDeleteColPos.Text = "Del";
            this.btnDeleteColPos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnDeleteColPos, "Remove selected column position");
            this.btnDeleteColPos.UseVisualStyleBackColor = true;
            this.btnDeleteColPos.Click += new System.EventHandler(this.btnDeleteColPos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Column";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(1106, 9);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 11;
            this.btnOpenFile.Text = "Open File...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(215, 225);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(70, 17);
            this.chkAll.TabIndex = 12;
            this.chkAll.Text = "Select All";
            this.toolTip1.SetToolTip(this.chkAll, "Select/deselect all export records");
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // btnTrim
            // 
            this.btnTrim.Location = new System.Drawing.Point(542, 219);
            this.btnTrim.Name = "btnTrim";
            this.btnTrim.Size = new System.Drawing.Size(75, 23);
            this.btnTrim.TabIndex = 13;
            this.btnTrim.Text = "Trim";
            this.toolTip1.SetToolTip(this.btnTrim, "Trim selected fields of excess whitespace");
            this.btnTrim.UseVisualStyleBackColor = true;
            this.btnTrim.Click += new System.EventHandler(this.btnTrim_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(623, 219);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 14;
            this.btnClean.Text = "Clean";
            this.toolTip1.SetToolTip(this.btnClean, "Remove punctuation from  selected fields\r\n");
            this.btnClean.UseVisualStyleBackColor = true;
            // 
            // cboField
            // 
            this.cboField.FormattingEnabled = true;
            this.cboField.Location = new System.Drawing.Point(394, 219);
            this.cboField.Name = "cboField";
            this.cboField.Size = new System.Drawing.Size(121, 21);
            this.cboField.TabIndex = 15;
            this.toolTip1.SetToolTip(this.cboField, "Select export field to modify");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Select Fields";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(354, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(211, 20);
            this.txtSearch.TabIndex = 17;
            this.toolTip1.SetToolTip(this.txtSearch, "Search for text by pressing Enter key");
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Find";
            // 
            // lblFileName
            // 
            this.lblFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFileName.Location = new System.Drawing.Point(690, 11);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(353, 19);
            this.lblFileName.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(629, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Viewing";
            // 
            // frmFileFixer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 518);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboField);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnTrim);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.dgvExport);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteColPos);
            this.Controls.Add(this.btnAddColPos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstColumnPositions);
            this.Controls.Add(this.btnLoadRawData);
            this.Controls.Add(this.lblColumn);
            this.Controls.Add(this.txtPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmFileFixer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Fixer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtPreview;
        private System.Windows.Forms.Label lblColumn;
        private System.Windows.Forms.DataGridView dgvExport;
        private System.Windows.Forms.Button btnLoadRawData;
        private System.Windows.Forms.ListBox lstColumnPositions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddColPos;
        private System.Windows.Forms.Button btnDeleteColPos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colExport;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.Button btnTrim;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.ComboBox cboField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label label5;
    }
}

