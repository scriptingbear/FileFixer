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

        private void txtPreview_SelectionChanged(object sender, EventArgs e)
        {
            int line = txtPreview.GetLineFromCharIndex(txtPreview.SelectionStart);
            int column = txtPreview.SelectionStart - 
                txtPreview.GetFirstCharIndexFromLine(line); 
            
            lblColumn.Text = $"{column}";
            

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

            /* Puts data into invisible staging control, which has a single 
             * column, and then the code scans the staging control, writing
             * each record to a field in the dgvExport control
             */ 
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
                }
       
            }//for (int i = 0; i <= columnPositions.Count - 2; i++)

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
            {
                lstColumnPositions.Items.RemoveAt(lstColumnPositions.SelectedIndex);

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
                text = Regex.Replace(text, @"(\n){3,}", Environment.NewLine + Environment.NewLine, RegexOptions.Multiline);
                txtPreview.Text = text;
                txtPreview.SelectionStart = 0;
            }
            
        }

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

            //don't check the final row in grid; it's the new row which is empty
            for (int i = 0; i < dgvExport.Rows.Count - 1; i++)
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
                    dgvExport.Columns[cboField.Text].Selected = true;
                }
            }
        }
    }
}
