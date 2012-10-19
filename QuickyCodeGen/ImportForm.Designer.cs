namespace QuickyCodeGen
{
    partial class ImportForm
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
            this.uxInputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxFieldSeparatorTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataSet1 = new System.Data.DataSet();
            this.uxPreviewDataGridView = new System.Windows.Forms.DataGridView();
            this.uxOkButton = new System.Windows.Forms.Button();
            this.uxCancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxPreviewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uxInputTextBox
            // 
            this.uxInputTextBox.AcceptsReturn = true;
            this.uxInputTextBox.AcceptsTab = true;
            this.uxInputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uxInputTextBox.Location = new System.Drawing.Point(1, 2);
            this.uxInputTextBox.Multiline = true;
            this.uxInputTextBox.Name = "uxInputTextBox";
            this.uxInputTextBox.Size = new System.Drawing.Size(339, 100);
            this.uxInputTextBox.TabIndex = 0;
            this.uxInputTextBox.TextChanged += new System.EventHandler(this.uxInputTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Field Separator";
            // 
            // uxFieldSeparatorTextBox
            // 
            this.uxFieldSeparatorTextBox.AcceptsReturn = true;
            this.uxFieldSeparatorTextBox.AcceptsTab = true;
            this.uxFieldSeparatorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uxFieldSeparatorTextBox.Location = new System.Drawing.Point(90, 108);
            this.uxFieldSeparatorTextBox.Multiline = true;
            this.uxFieldSeparatorTextBox.Name = "uxFieldSeparatorTextBox";
            this.uxFieldSeparatorTextBox.Size = new System.Drawing.Size(250, 54);
            this.uxFieldSeparatorTextBox.TabIndex = 3;
            this.uxFieldSeparatorTextBox.TextChanged += new System.EventHandler(this.uxFieldSeparatorTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preview";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // uxPreviewDataGridView
            // 
            this.uxPreviewDataGridView.AllowUserToAddRows = false;
            this.uxPreviewDataGridView.AllowUserToDeleteRows = false;
            this.uxPreviewDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uxPreviewDataGridView.AutoGenerateColumns = false;
            this.uxPreviewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxPreviewDataGridView.DataSource = this.dataSet1;
            this.uxPreviewDataGridView.Location = new System.Drawing.Point(1, 203);
            this.uxPreviewDataGridView.Name = "uxPreviewDataGridView";
            this.uxPreviewDataGridView.ReadOnly = true;
            this.uxPreviewDataGridView.Size = new System.Drawing.Size(339, 88);
            this.uxPreviewDataGridView.TabIndex = 5;
            // 
            // uxOkButton
            // 
            this.uxOkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uxOkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uxOkButton.Location = new System.Drawing.Point(168, 303);
            this.uxOkButton.Name = "uxOkButton";
            this.uxOkButton.Size = new System.Drawing.Size(75, 23);
            this.uxOkButton.TabIndex = 6;
            this.uxOkButton.Text = "Ok";
            this.uxOkButton.UseVisualStyleBackColor = true;
            // 
            // uxCancelButton
            // 
            this.uxCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uxCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uxCancelButton.Location = new System.Drawing.Point(249, 303);
            this.uxCancelButton.Name = "uxCancelButton";
            this.uxCancelButton.Size = new System.Drawing.Size(75, 23);
            this.uxCancelButton.TabIndex = 6;
            this.uxCancelButton.Text = "Cancel";
            this.uxCancelButton.UseVisualStyleBackColor = true;
            // 
            // ImportForm
            // 
            this.AcceptButton = this.uxOkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.uxCancelButton;
            this.ClientSize = new System.Drawing.Size(349, 342);
            this.Controls.Add(this.uxCancelButton);
            this.Controls.Add(this.uxOkButton);
            this.Controls.Add(this.uxPreviewDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxFieldSeparatorTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxInputTextBox);
            this.MinimumSize = new System.Drawing.Size(315, 361);
            this.Name = "ImportForm";
            this.Text = "ImportForm";
            this.Load += new System.EventHandler(this.ImportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxPreviewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxInputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxFieldSeparatorTextBox;
        private System.Windows.Forms.Label label3;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.DataGridView uxPreviewDataGridView;
        private System.Windows.Forms.Button uxOkButton;
        private System.Windows.Forms.Button uxCancelButton;
    }
}