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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnEditFieldName = new System.Windows.Forms.Button();
            this.btnToUpper = new System.Windows.Forms.Button();
            this.colSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPreview
            // 
            this.txtPreview.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreview.Location = new System.Drawing.Point(12, 68);
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.Size = new System.Drawing.Size(1167, 168);
            this.txtPreview.TabIndex = 1;
            this.txtPreview.Text = "";
            this.txtPreview.WordWrap = false;
            this.txtPreview.SelectionChanged += new System.EventHandler(this.txtPreview_SelectionChanged);
            // 
            // lblColumn
            // 
            this.lblColumn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblColumn.Location = new System.Drawing.Point(657, 30);
            this.lblColumn.Name = "lblColumn";
            this.lblColumn.Size = new System.Drawing.Size(38, 20);
            this.lblColumn.TabIndex = 2;
            this.lblColumn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblColumn, "Currenrt column position (0-based)");
            // 
            // dgvExport
            // 
            this.dgvExport.AllowUserToAddRows = false;
            this.dgvExport.AllowUserToResizeRows = false;
            this.dgvExport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelect});
            this.dgvExport.Location = new System.Drawing.Point(12, 301);
            this.dgvExport.Name = "dgvExport";
            this.dgvExport.Size = new System.Drawing.Size(1173, 284);
            this.dgvExport.TabIndex = 0;
            // 
            // btnLoadRawData
            // 
            this.btnLoadRawData.Location = new System.Drawing.Point(1092, 25);
            this.btnLoadRawData.Name = "btnLoadRawData";
            this.btnLoadRawData.Size = new System.Drawing.Size(75, 23);
            this.btnLoadRawData.TabIndex = 5;
            this.btnLoadRawData.Text = "Transform";
            this.toolTip1.SetToolTip(this.btnLoadRawData, "Transform loaded file for export to CSV file");
            this.btnLoadRawData.UseVisualStyleBackColor = true;
            this.btnLoadRawData.Click += new System.EventHandler(this.btnLoadRawData_Click);
            // 
            // lstColumnPositions
            // 
            this.lstColumnPositions.ColumnWidth = 15;
            this.lstColumnPositions.FormattingEnabled = true;
            this.lstColumnPositions.HorizontalScrollbar = true;
            this.lstColumnPositions.Location = new System.Drawing.Point(802, 33);
            this.lstColumnPositions.MultiColumn = true;
            this.lstColumnPositions.Name = "lstColumnPositions";
            this.lstColumnPositions.Size = new System.Drawing.Size(132, 17);
            this.lstColumnPositions.TabIndex = 6;
            this.toolTip1.SetToolTip(this.lstColumnPositions, "File will be \"sliced\" according to these column positions");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(709, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Column Positions";
            // 
            // btnAddColPos
            // 
            this.btnAddColPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddColPos.Location = new System.Drawing.Point(940, 30);
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
            this.btnDeleteColPos.Location = new System.Drawing.Point(987, 30);
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
            this.label2.Location = new System.Drawing.Point(609, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Column";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(6, 27);
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
            this.chkAll.Location = new System.Drawing.Point(64, 278);
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
            this.btnTrim.Location = new System.Drawing.Point(533, 274);
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
            this.btnClean.Location = new System.Drawing.Point(614, 274);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 14;
            this.btnClean.Text = "Clean";
            this.toolTip1.SetToolTip(this.btnClean, "Remove punctuation from  selected fields\r\n");
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // cboField
            // 
            this.cboField.FormattingEnabled = true;
            this.cboField.Location = new System.Drawing.Point(71, 7);
            this.cboField.Name = "cboField";
            this.cboField.Size = new System.Drawing.Size(121, 21);
            this.cboField.TabIndex = 15;
            this.toolTip1.SetToolTip(this.cboField, "Select export field to modify");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Select Field";
            this.toolTip1.SetToolTip(this.label3, "Select field upon which formatting operation will be performed");
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(382, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(211, 20);
            this.txtSearch.TabIndex = 17;
            this.toolTip1.SetToolTip(this.txtSearch, "Search for text by pressing Enter key");
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Find";
            // 
            // lblFileName
            // 
            this.lblFileName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFileName.Location = new System.Drawing.Point(151, 31);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(174, 19);
            this.lblFileName.TabIndex = 19;
            this.toolTip1.SetToolTip(this.lblFileName, "File currently loaded");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Viewing";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteColPos);
            this.groupBox1.Controls.Add(this.btnAddColPos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lstColumnPositions);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblFileName);
            this.groupBox1.Controls.Add(this.btnLoadRawData);
            this.groupBox1.Controls.Add(this.btnOpenFile);
            this.groupBox1.Controls.Add(this.lblColumn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1173, 250);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source File";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1104, 268);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 22;
            this.btnExport.Text = "Export";
            this.toolTip1.SetToolTip(this.btnExport, "Export data in grid to CSV file");
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnEditFieldName
            // 
            this.btnEditFieldName.Location = new System.Drawing.Point(198, 7);
            this.btnEditFieldName.Name = "btnEditFieldName";
            this.btnEditFieldName.Size = new System.Drawing.Size(75, 23);
            this.btnEditFieldName.TabIndex = 23;
            this.btnEditFieldName.Text = "Edit";
            this.toolTip1.SetToolTip(this.btnEditFieldName, "Edit name of selected field");
            this.btnEditFieldName.UseVisualStyleBackColor = true;
            this.btnEditFieldName.Click += new System.EventHandler(this.btnEditFieldName_Click);
            // 
            // btnToUpper
            // 
            this.btnToUpper.Location = new System.Drawing.Point(452, 274);
            this.btnToUpper.Name = "btnToUpper";
            this.btnToUpper.Size = new System.Drawing.Size(75, 23);
            this.btnToUpper.TabIndex = 24;
            this.btnToUpper.Text = "Upper";
            this.toolTip1.SetToolTip(this.btnToUpper, "Convert values in selected field to UPPER CASE");
            this.btnToUpper.UseVisualStyleBackColor = true;
            this.btnToUpper.Click += new System.EventHandler(this.btnToUpper_Click);
            // 
            // colSelect
            // 
            this.colSelect.Frozen = true;
            this.colSelect.HeaderText = "Select";
            this.colSelect.Name = "colSelect";
            this.colSelect.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colSelect.Width = 62;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnEditFieldName);
            this.panel1.Controls.Add(this.cboField);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(140, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 31);
            this.panel1.TabIndex = 25;
            // 
            // frmFileFixer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 597);
            this.Controls.Add(this.btnToUpper);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnTrim);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.dgvExport);
            this.Controls.Add(this.txtPreview);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmFileFixer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Fixer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnEditFieldName;
        private System.Windows.Forms.Button btnToUpper;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

