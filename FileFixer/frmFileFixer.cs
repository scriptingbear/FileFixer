using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace FileFixer
{
    public partial class frmFileFixer : Form
    {
        List<int> columnPositions = new List<int>();

        public frmFileFixer()
        {
            InitializeComponent();
        }

        private void UpdateColumnPosition()
        {
            int line = txtPreview.GetLineFromCharIndex(txtPreview.SelectionStart);
            int column = txtPreview.SelectionStart -
                txtPreview.GetFirstCharIndexFromLine(line);

            lblColumn.Text = $"{column}";
        }//UpdateColumnPosition()

        private void txtPreview_SelectionChanged(object sender, EventArgs e)
        {
            UpdateColumnPosition();

        }//txtPreview_SelectionChange()

        private void btnLoadRawData_Click(object sender, EventArgs e)
        {
            List<string> exportRecord = new List<string>();
           
            if (dgvExport.RowCount > 0)
            {
                dgvExport.Rows.Clear();
            }

            //remove all columns except Select
            while (dgvExport.ColumnCount > 1)
            {
                dgvExport.Columns.RemoveAt(1);
            }

            
            if ((txtPreview.Text == string.Empty) || (lstColumnPositions.Items.Count == 0))
            {
                return;
            }

  
            for (int i = 0; i <= columnPositions.Count - 1; i++)
            {
                //load a "column" of the file at a time into the DataViewGrid
 
                foreach (var line in txtPreview.Lines)
                {
                    var start = columnPositions[i];
                    int len = 0;
                    string labelLine = "";

                    try { 
                    if (line.Length > 0)
                    {
                        if (i < columnPositions.Count - 1)
                        {
                            len = columnPositions[i + 1] - start;
                            labelLine = line.Substring(start, len);
                        }
                        else
                        {
                            labelLine = line.Substring(start);
                        }
                        //dgvStaging.Rows.Add(labelLine);
                        exportRecord.Add(labelLine);

                    }
                    else
                    {
                        //end of a block, time to write a record to dgvExport
                        LoadStagedData(exportRecord);
                        //reset list that holds the individual lines of this block of data
                        exportRecord.Clear();
                    }//(line.Length > 0)

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                }//foreach (var line in txtPreview.Lines)

                //last block, write to dgvExport
                if (exportRecord.Count() > 0)
                {
                    LoadStagedData(exportRecord);
                    //reset list that holds the individual lines of this block of data
                    exportRecord.Clear();
                }//(exportRecord.Count() > 0)
            }//for (int i = 0; i <= columnPositions.Count - 2; i++)

            //sort by Field 1 in ascending order to expose any blank rows
            dgvExport.Sort(dgvExport.Columns[1], System.ComponentModel.ListSortDirection.Ascending);

            MessageBox.Show("Select empty rows in data grid and delete them before exporting data to a file.","File Fixer",
                       MessageBoxButtons.OK,MessageBoxIcon.Information);

        }//btnLoadRawData_Click()

        /// <summary>
        /// Ensure dgvExport has enough columns for the export record.
        /// Then create a DataGridViewRow object, add cells to it, populate
        /// the cells and then add the object to dgvExport
        /// </summary>
        private void LoadStagedData(List<string> data)
        {
            /* Before writing block to dgvExport, add columns to that control
             * as necessary, not counting the Select column
            */
            int exportColumnCount = dgvExport.ColumnCount - 1;
            if (data.Count() > exportColumnCount)
            {
                for (int fieldCount = 0; fieldCount < (data.Count() - exportColumnCount); fieldCount++)
                {
                    /* When adding a new column name must take into account how many columns already exist
                     * E.g. if dgvExport has Field1, Field2, and Field3 and now we want to add a new column
                     * it should be named Field4, which means we must include the value of exportColumnCount
                     * in determing the header for the new column
                     */ 
                    dgvExport.Columns.Add($"Field{exportColumnCount + fieldCount + 1}", $"Field{exportColumnCount + fieldCount + 1}");
                }

            }//(exportRecord.Count() < exportColumnCount)

            DataGridViewRow dataGridViewRow = new DataGridViewRow();
            dataGridViewRow.CreateCells(dgvExport);
            dataGridViewRow.Cells[0].Value = false;
            for (int i = 0; i <= (data.Count() - 1); i++)
            {
                dataGridViewRow.Cells[i + 1].Value = data[i];
            }

            dgvExport.Rows.Add(dataGridViewRow);

            //populate field name dropdown
            cboField.Items.Clear();
            cboField.Items.Add("All");
            for (int i = 1; i <= dgvExport.ColumnCount - 1; i++)
            {
                cboField.Items.Add(dgvExport.Columns[i].HeaderText);
            }
        }//LoadStagedData()

       

        private void btnDeleteColPos_Click(object sender, EventArgs e)
        {
            if (lstColumnPositions.SelectedItems != null)
                /* Since DataSource has been set for this control the Items collection is immutable
                 * Must update the underlying datasource, which is the columnPositions list object
                 */ 
            {
                columnPositions.RemoveAt(lstColumnPositions.SelectedIndex);
                lstColumnPositions.DataSource = null;
                lstColumnPositions.DataSource = columnPositions;

            }//(lstColumnPositions.SelectedItems != null)
        }//btnDeleteColPos_Click()

        private void btnAddColPos_Click(object sender, EventArgs e)
        {
            
           int colPos = 0;

           if ((lblColumn.Text != string.Empty) && (int.TryParse(lblColumn.Text, out colPos)))
            {
                if (!columnPositions.Contains(colPos))
                {
                    columnPositions.Add(colPos);
                    columnPositions.Sort();
                    lstColumnPositions.DataSource = null;
                    lstColumnPositions.DataSource = columnPositions;

                }//(!columnPositions.Contains(colPos))
            }//((lblColumn.Text != string.Empty) && (int.TryParse(lblColumn.Text, out colPos)))


        }//btnAddColPos_Click

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            var filePath = "";
            var text = "";

            //remove any existing column positions
            lstColumnPositions.DataSource = null;
            columnPositions.Clear();

            openFileDialog1.Title = "Select plain text label file";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "Label Files (*.txt; *.tab; *.dat)|*.txt; *.tab; *.dat";
            openFileDialog1.DefaultExt = ".txt";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                lblFileName.Text = Path.GetFileName(filePath);

                //must specify that file being loaded is ASCII and not RTF
                txtPreview.LoadFile(filePath, RichTextBoxStreamType.PlainText);
                /* Code uses blank lines as delimiters between blocks.
                 * If file has more than one blank line between blocks
                 * dgvExport will have excess blank records, which we don't want or need
                 * Use Regex to clean excess "\n" from the RichTextBox control
                 */
                text = txtPreview.Text;
                //get rid of any lines that consist only of whitespace
                text = Regex.Replace(text, @"^\s+$", Environment.NewLine, RegexOptions.Multiline);

                //convert tabs to spaces
                text = Regex.Replace(text, @"\t", new String(' ', 5), RegexOptions.Multiline);

                
                //get rid of excess newlines
                text = Regex.Replace(text, @"(\n|\r\n|\r){3,}",  Environment.NewLine + Environment.NewLine, RegexOptions.Multiline);
                txtPreview.Text = text;
                txtPreview.SelectionStart = 0;
                txtPreview.Focus();
                txtPreview.ScrollToCaret();
                UpdateColumnPosition();

            }//(openFileDialog1.ShowDialog() == DialogResult.OK)

        }//btnOpenFile_Click()

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtSearch.Text == string.Empty)
            {
                return;
            }

            if (e.KeyCode == Keys.Enter)
            {
                var location = txtPreview.Find(txtSearch.Text);
                if (location != -1)
                {
                    txtPreview.SelectionStart = location;
                    txtPreview.ScrollToCaret();

                }
            }

        }//txtSearch_KeyDown

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (dgvExport.RowCount == 0)
            {
                return;
            }

            
            for (int i = 0; i < dgvExport.Rows.Count; i++)
            {
                dgvExport.Rows[i].Cells[0].Value = chkAll.Checked; 
            }
            chkAll.Text =  (chkAll.Checked) ?   "Deselect All" : "Select All";
            
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            if (cboField.SelectedIndex != -1)
            {
                if (cboField.Text != "All")
                {
                    for (int i = 0; i < dgvExport.RowCount; i++)
                    {

                        if (dgvExport.Rows[i].Cells[cboField.Text].Value != null)
                        {
                            string temp = dgvExport.Rows[i].Cells[cboField.Text].Value.ToString();
                            dgvExport.Rows[i].Cells[cboField.Text].Value = temp.Trim();
                        }
                    }//(int i = 0; i < dgvExport.RowCount; i++)
                }
                else
                {
                    for (int i = 0; i < dgvExport.RowCount; i++)
                    {
                        for (int j = 1; j < dgvExport.ColumnCount; j++)
                        {
                            if (dgvExport.Rows[i].Cells[j].Value != null)
                            {
                                string temp = dgvExport.Rows[i].Cells[j].Value.ToString();
                                dgvExport.Rows[i].Cells[j].Value = temp.Trim();
                            }
                        }
                    }//(int i = 0; i < dgvExport.RowCount; i++)

                }//(cboField.Text != "All")
            }//(cboField.SelectedIndex != -1)
        }//btnTrim_Click



        private void btnClean_Click(object sender, EventArgs e)
        {
            if (cboField.SelectedIndex != -1)
            {
                if (cboField.Text != "All")
                {
                    for (int i = 0; i < dgvExport.RowCount; i++)
                    {

                        if (dgvExport.Rows[i].Cells[cboField.Text].Value != null)
                        {
                            string temp = dgvExport.Rows[i].Cells[cboField.Text].Value.ToString();
                            dgvExport.Rows[i].Cells[cboField.Text].Value = Regex.Replace(temp, @"[^\w -]", "");
                        }
                    }//(int i = 0; i < dgvExport.RowCount; i++)
                }
                else
                {
                    for (int i = 0; i < dgvExport.RowCount; i++)
                    {
                        for (int j = 1; j < dgvExport.ColumnCount; j++)
                        {
                            if (dgvExport.Rows[i].Cells[j].Value != null)
                            {
                                string temp = dgvExport.Rows[i].Cells[j].Value.ToString();
                                dgvExport.Rows[i].Cells[j].Value = Regex.Replace(temp, @"[^\w -]", "");
                            }
                        }
                    }//(int i = 0; i < dgvExport.RowCount; i++)

                }//(cboField.Text != "All")
            }//(cboField.SelectedIndex != -1)
        }//btnClean_Click

        private void btnEditFieldName_Click(object sender, EventArgs e)
        {
            if (cboField.SelectedIndex != -1)
            {
                if (cboField.Text != "All") {
                    var newName = Microsoft.VisualBasic.Interaction.InputBox("Enter new name of field", "File Fixer", cboField.Text);
                    newName = newName.Trim();
                    if (newName != string.Empty)
                    {
                        //can't allow "," in header name since that's the delimiter for csv files
                        if (newName.Contains(","))
                        {
                            MessageBox.Show("Field name cannot contain a comma.", "File Fixer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }


                        dgvExport.Columns[cboField.Text].HeaderText = newName;
                        dgvExport.Columns[cboField.Text].Name = newName;
                        cboField.Items[cboField.SelectedIndex] = newName;
                    } 
                    else
                    {
                        MessageBox.Show("Invaild field name", "File Fixer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }//(cboField.Text != "All")


            }//(cboField.SelectedIndex != -1)
        }//btnEditFieldName_Click

        private void btnToUpper_Click(object sender, EventArgs e)
        {
            if (cboField.SelectedIndex != -1)
            {
                if (cboField.Text != "All")
                {
                    for (int i = 0; i < dgvExport.RowCount; i++)
                    {

                        if (dgvExport.Rows[i].Cells[cboField.Text].Value != null)
                        {
                            string temp = dgvExport.Rows[i].Cells[cboField.Text].Value.ToString().ToUpper();
                            dgvExport.Rows[i].Cells[cboField.Text].Value = temp;
                        }
                    }//(int i = 0; i < dgvExport.RowCount; i++)
                }
                else
                {
                    for (int i = 0; i < dgvExport.RowCount; i++)
                    {
                        for (int j = 1; j < dgvExport.ColumnCount; j++)
                        {
                            if (dgvExport.Rows[i].Cells[j].Value != null)
                            {
                                string temp = dgvExport.Rows[i].Cells[j].Value.ToString().ToUpper();
                                dgvExport.Rows[i].Cells[j].Value = temp;
                            }
                        }//(int j = 1; j < dgvExport.ColumnCount; j++)
                    }//(int i = 0; i < dgvExport.RowCount; i++)

                }//(cboField.Text != "All")
            }//(cboField.SelectedIndex != -1)

        }//btnToUpper_Click()


        /// <summary>
        /// Exports selected records in the DataGridView control to csv format
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e)
        {
            var filePath = "";
            var output = "";
            

            if (dgvExport.RowCount == 0)
            {
                return;
            }

            /* Can't use Linq to query a DataGridView object but we can
             * use the GetRowCount() method to count up which records
             * have been selected for export. But that method works
             * for records highlighted by the user, not records
             * for which the Select column has been checked
             */ 

            var selectedRecordCount = 0;

            //may come in handy later but can't use to determine which records should be exported
            //selectedRecordCount = dgvExport.Rows.GetRowCount(DataGridViewElementStates.Selected);

            
            for (int i = 0; i < dgvExport.RowCount; i++)
            {
                if((bool)dgvExport.Rows[i].Cells["colSelect"].Value)
                {
                    selectedRecordCount += 1;
                }
            }//(int i = 0; i < dgvExport.RowCount; i++)
            

            if (MessageBox.Show($"About to export {selectedRecordCount} records. Continue?",
                                "File Fixer",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                //write header to output variable
                for (int j = 1; j < dgvExport.ColumnCount; j++)
                {
                    output += dgvExport.Columns[j].HeaderText + ",";
                }//(int j = 1; j < dgvExport.ColumnCount; j++)

                 //strip off final ","
                output = output.TrimEnd(',');
                output += Environment.NewLine;

                //write records in csv format
                for (int i = 0; i < dgvExport.RowCount; i++)
                {
                    if ((bool)dgvExport.Rows[i].Cells["colSelect"].Value)
                    {
                        for (int j = 1; j < dgvExport.ColumnCount; j++)
                        {
                            if (dgvExport.Rows[i].Cells[j].Value != null)
                            {
                                output += dgvExport.Rows[i].Cells[j].Value.ToString() + ",";
                            }
                            else
                            {
                                output += string.Empty + ",";
                            }//(dgvExport.Rows[i].Cells[j].Value != null)
                        }//(int j = 1; j < dgvExport.ColumnCount; j++)

                        //strip off final ","
                        output = output.TrimEnd(',');
                        output += Environment.NewLine;
                    }//((bool)dgvExport.Rows[i].Cells["colSelect"].Value)

                }//(int i = 0; i < dgvExport.RowCount; i++)

                // MessageBox.Show(output);
                saveFileDialog1.Title = "Export selected records to file";
                saveFileDialog1.FileName = Path.GetFileNameWithoutExtension(lblFileName.Text) + ".csv";
                saveFileDialog1.Filter = "Export files (*.csv)|*.csv";
                saveFileDialog1.OverwritePrompt = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog1.FileName;
                    File.WriteAllText(filePath, output);
                    MessageBox.Show("Records have been exported to specified file.", "File Fixer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }//(saveFileDialog1.ShowDialog() == DialogResult.OK)


            } else
            {
                //MessageBox.Show("Nay!");
            }




        }
    }//frmFileFixer
}//FileFixer
