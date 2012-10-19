using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Deployment.Application;

namespace QuickyCodeGen
{
    public partial class MainForm : Form, IMainView
    {
        private MainFormPresenter _presenter;
        private ImportForm form;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _presenter = new MainFormPresenter(this);
            _presenter.GenerateSample();

            form = new ImportForm();
            
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;

                uxVersionToolStripStatusLabel.Text = ad.CurrentVersion.ToString();
            }
            else
                uxVersionToolStripStatusLabel.Text = Application.ProductVersion;

            
        }



        private void uxCheckForUpdateToolStripStatusLabel_Click(object sender, EventArgs e)
        {
            UpdateForm form = new UpdateForm();
            form.StartPosition = FormStartPosition.CenterParent;

            form.ShowDialog();
        }


        #region IMainView Members

        void IMainView.SendData(DataTable table)
        {
            uxMainDataGridView.DataSource = null;
            uxMainDataGridView.DataSource = table;

            StringBuilder sb = new StringBuilder();
            foreach (DataColumn col in table.Columns)
            {
                sb.AppendLine(col.ColumnName);
            }
            uxColumnListTextBox.Text = sb.ToString();

        }

        #endregion

        #region IMainView Members


        void IMainView.ShowCompilationResult(string result)
        {
            uxOutputTextBox.Text = result;
        }

 
        void IMainView.TemplateChanged(string template)
        {
            uxInputTextBox.Text = template;
        }

        #endregion
    }
}