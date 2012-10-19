namespace QuickyCodeGen
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.uxImportTextLinkLabel = new System.Windows.Forms.LinkLabel();
            this.uxUpdateColumnListLinkLabel = new System.Windows.Forms.LinkLabel();
            this.uxColumnListTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.uxInputTextBox = new System.Windows.Forms.TextBox();
            this.uxOutputTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.uxVersionToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.uxCheckForUpdateToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.uxQueuedUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.uxUpdateBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.uxMainDataGridView = new System.Windows.Forms.DataGridView();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxMainDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(836, 436);
            this.splitContainer1.SplitterDistance = 278;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.uxImportTextLinkLabel);
            this.splitContainer2.Panel1.Controls.Add(this.uxUpdateColumnListLinkLabel);
            this.splitContainer2.Panel1.Controls.Add(this.uxColumnListTextBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.uxMainDataGridView);
            this.splitContainer2.Size = new System.Drawing.Size(278, 436);
            this.splitContainer2.SplitterDistance = 143;
            this.splitContainer2.TabIndex = 0;
            // 
            // uxImportTextLinkLabel
            // 
            this.uxImportTextLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uxImportTextLinkLabel.AutoSize = true;
            this.uxImportTextLinkLabel.Location = new System.Drawing.Point(11, 129);
            this.uxImportTextLinkLabel.Name = "uxImportTextLinkLabel";
            this.uxImportTextLinkLabel.Size = new System.Drawing.Size(60, 13);
            this.uxImportTextLinkLabel.TabIndex = 2;
            this.uxImportTextLinkLabel.TabStop = true;
            this.uxImportTextLinkLabel.Text = "Import Text";
            
            // 
            // uxUpdateColumnListLinkLabel
            // 
            this.uxUpdateColumnListLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uxUpdateColumnListLinkLabel.AutoSize = true;
            this.uxUpdateColumnListLinkLabel.Location = new System.Drawing.Point(176, 129);
            this.uxUpdateColumnListLinkLabel.Name = "uxUpdateColumnListLinkLabel";
            this.uxUpdateColumnListLinkLabel.Size = new System.Drawing.Size(99, 13);
            this.uxUpdateColumnListLinkLabel.TabIndex = 1;
            this.uxUpdateColumnListLinkLabel.TabStop = true;
            this.uxUpdateColumnListLinkLabel.Text = "Update Column List";
            
            // 
            // uxColumnListTextBox
            // 
            this.uxColumnListTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uxColumnListTextBox.Location = new System.Drawing.Point(3, 3);
            this.uxColumnListTextBox.Multiline = true;
            this.uxColumnListTextBox.Name = "uxColumnListTextBox";
            this.uxColumnListTextBox.Size = new System.Drawing.Size(272, 123);
            this.uxColumnListTextBox.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.uxInputTextBox);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.uxOutputTextBox);
            this.splitContainer3.Size = new System.Drawing.Size(554, 436);
            this.splitContainer3.SplitterDistance = 287;
            this.splitContainer3.TabIndex = 0;
            // 
            // uxInputTextBox
            // 
            this.uxInputTextBox.AcceptsTab = true;
            this.uxInputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxInputTextBox.Location = new System.Drawing.Point(0, 0);
            this.uxInputTextBox.Multiline = true;
            this.uxInputTextBox.Name = "uxInputTextBox";
            this.uxInputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.uxInputTextBox.Size = new System.Drawing.Size(554, 287);
            this.uxInputTextBox.TabIndex = 0;
            
            // 
            // uxOutputTextBox
            // 
            this.uxOutputTextBox.AcceptsTab = true;
            this.uxOutputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxOutputTextBox.Location = new System.Drawing.Point(0, 0);
            this.uxOutputTextBox.Multiline = true;
            this.uxOutputTextBox.Name = "uxOutputTextBox";
            this.uxOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.uxOutputTextBox.Size = new System.Drawing.Size(554, 145);
            this.uxOutputTextBox.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxVersionToolStripStatusLabel,
            this.uxCheckForUpdateToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(836, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // uxVersionToolStripStatusLabel
            // 
            this.uxVersionToolStripStatusLabel.Name = "uxVersionToolStripStatusLabel";
            this.uxVersionToolStripStatusLabel.Size = new System.Drawing.Size(46, 17);
            this.uxVersionToolStripStatusLabel.Text = "Version";
            // 
            // uxCheckForUpdateToolStripStatusLabel
            // 
            this.uxCheckForUpdateToolStripStatusLabel.IsLink = true;
            this.uxCheckForUpdateToolStripStatusLabel.Name = "uxCheckForUpdateToolStripStatusLabel";
            this.uxCheckForUpdateToolStripStatusLabel.Size = new System.Drawing.Size(98, 17);
            this.uxCheckForUpdateToolStripStatusLabel.Text = "Check for update";
            this.uxCheckForUpdateToolStripStatusLabel.Click += new System.EventHandler(this.uxCheckForUpdateToolStripStatusLabel_Click);
            // 
            // uxQueuedUpdateTimer
            // 
            this.uxQueuedUpdateTimer.Enabled = true;
            
            // 
            // uxUpdateBackgroundWorker
            // 
            
            // 
            // uxMainDataGridView
            // 
            this.uxMainDataGridView.AllowUserToOrderColumns = true;
            this.uxMainDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.uxMainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxMainDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxMainDataGridView.Location = new System.Drawing.Point(0, 0);
            this.uxMainDataGridView.Name = "uxMainDataGridView";
            this.uxMainDataGridView.Size = new System.Drawing.Size(278, 289);
            this.uxMainDataGridView.TabIndex = 0;
            
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 461);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "QuickyCodeGen - by Patware";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            this.splitContainer3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxMainDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TextBox uxInputTextBox;
        private System.Windows.Forms.TextBox uxOutputTextBox;
        private System.Windows.Forms.LinkLabel uxUpdateColumnListLinkLabel;
        private System.Windows.Forms.TextBox uxColumnListTextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel uxVersionToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel uxCheckForUpdateToolStripStatusLabel;
        private System.Windows.Forms.LinkLabel uxImportTextLinkLabel;
        private System.Windows.Forms.Timer uxQueuedUpdateTimer;
        private System.ComponentModel.BackgroundWorker uxUpdateBackgroundWorker;
        private System.Windows.Forms.DataGridView uxMainDataGridView;
    }
}

