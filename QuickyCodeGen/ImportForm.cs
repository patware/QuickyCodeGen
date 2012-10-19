using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuickyCodeGen
{
    public partial class ImportForm : Form
    {
        public ImportForm()
        {
            InitializeComponent();
        }

        public DataTable GetData()
        {
            return dataSet1.Tables[0];
        }

        private void uxInputTextBox_TextChanged(object sender, EventArgs e)
        {
            Preview();
        }

        private void uxFieldSeparatorTextBox_TextChanged(object sender, EventArgs e)
        {
            Preview();

        }

        private void uxRowSeparatorTextBox_TextChanged(object sender, EventArgs e)
        {
            Preview();

        }

        private void Preview()
        {
            this.Cursor = Cursors.WaitCursor;

            DataTable table;

            if (dataSet1.Tables.Count == 0)
                table = dataSet1.Tables.Add("import");
            else
                table = dataSet1.Tables[0];

            table.Clear();

            string[] fieldSeparators = uxFieldSeparatorTextBox.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            string[] lines = uxInputTextBox.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            string[] cols;

            if (lines.Length > 0 && fieldSeparators.Length > 0)
            {

                foreach (string r in lines)
                {

                    cols = r.Split(fieldSeparators, StringSplitOptions.None);

                    while (cols.Length > table.Columns.Count)
                    {
                        uxPreviewDataGridView.DataSource = null;
                        table.Columns.Add("C" + (table.Columns.Count + 1));
                    }

                    DataRow row = table.NewRow();

                    row.ItemArray = cols;

                    table.Rows.Add(row);

                }
            }


            uxPreviewDataGridView.DataSource = dataSet1;
            uxPreviewDataGridView.DataMember = table.TableName;
            uxPreviewDataGridView.AutoGenerateColumns = true;
            this.Cursor = Cursors.Default;

        }

        private void ImportForm_Load(object sender, EventArgs e)
        {
            uxPreviewDataGridView.AutoGenerateColumns = true;
        }
    }
}