namespace ParsPack
{
    partial class FrmMain
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NextPageButton = new System.Windows.Forms.Button();
            this.PreviousPageButton = new System.Windows.Forms.Button();
            this.DGdata = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CreateDb = new System.Windows.Forms.ToolStripButton();
            this.ClearDb = new System.Windows.Forms.ToolStripButton();
            this.fillFromAPI = new System.Windows.Forms.ToolStripButton();
            this.FillFromLocalDB = new System.Windows.Forms.ToolStripButton();
            this.AddNewRecord = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateDb,
            this.ClearDb,
            this.fillFromAPI,
            this.FillFromLocalDB,
            this.AddNewRecord});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(782, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 64);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(105, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(240, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NextPageButton);
            this.groupBox2.Controls.Add(this.PreviousPageButton);
            this.groupBox2.Controls.Add(this.DGdata);
            this.groupBox2.Location = new System.Drawing.Point(12, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(758, 366);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List";
            // 
            // NextPageButton
            // 
            this.NextPageButton.Location = new System.Drawing.Point(635, 322);
            this.NextPageButton.Name = "NextPageButton";
            this.NextPageButton.Size = new System.Drawing.Size(117, 38);
            this.NextPageButton.TabIndex = 3;
            this.NextPageButton.Text = "Next Page";
            this.NextPageButton.UseVisualStyleBackColor = true;
            this.NextPageButton.Click += new System.EventHandler(this.NextPageButton_Click);
            // 
            // PreviousPageButton
            // 
            this.PreviousPageButton.Location = new System.Drawing.Point(6, 322);
            this.PreviousPageButton.Name = "PreviousPageButton";
            this.PreviousPageButton.Size = new System.Drawing.Size(117, 38);
            this.PreviousPageButton.TabIndex = 2;
            this.PreviousPageButton.Text = "Previous Page";
            this.PreviousPageButton.UseVisualStyleBackColor = true;
            this.PreviousPageButton.Click += new System.EventHandler(this.PreviousPageButton_Click);
            // 
            // DGdata
            // 
            this.DGdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGdata.Location = new System.Drawing.Point(6, 28);
            this.DGdata.Name = "DGdata";
            this.DGdata.RowHeadersWidth = 51;
            this.DGdata.RowTemplate.Height = 24;
            this.DGdata.Size = new System.Drawing.Size(746, 288);
            this.DGdata.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ParsPack.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(10, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 42);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // CreateDb
            // 
            this.CreateDb.Image = global::ParsPack.Properties.Resources.datapng;
            this.CreateDb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateDb.Name = "CreateDb";
            this.CreateDb.Size = new System.Drawing.Size(143, 28);
            this.CreateDb.Text = "Create Database";
            this.CreateDb.Click += new System.EventHandler(this.CreateDb_Click);
            // 
            // ClearDb
            // 
            this.ClearDb.Image = global::ParsPack.Properties.Resources.cleardb;
            this.ClearDb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearDb.Name = "ClearDb";
            this.ClearDb.Size = new System.Drawing.Size(106, 28);
            this.ClearDb.Text = "Clear Table";
            this.ClearDb.Click += new System.EventHandler(this.ClearDb_Click);
            // 
            // fillFromAPI
            // 
            this.fillFromAPI.Image = global::ParsPack.Properties.Resources.dataView;
            this.fillFromAPI.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillFromAPI.Name = "fillFromAPI";
            this.fillFromAPI.Size = new System.Drawing.Size(116, 28);
            this.fillFromAPI.Text = "Fill From API";
            this.fillFromAPI.Click += new System.EventHandler(this.fillFromAPI_Click);
            // 
            // FillFromLocalDB
            // 
            this.FillFromLocalDB.Image = global::ParsPack.Properties.Resources.dataView;
            this.FillFromLocalDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FillFromLocalDB.Name = "FillFromLocalDB";
            this.FillFromLocalDB.Size = new System.Drawing.Size(149, 28);
            this.FillFromLocalDB.Text = "Fill From LocalDB";
            this.FillFromLocalDB.Click += new System.EventHandler(this.FillFromLocalDB_Click);
            // 
            // AddNewRecord
            // 
            this.AddNewRecord.Image = global::ParsPack.Properties.Resources.add;
            this.AddNewRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddNewRecord.Name = "AddNewRecord";
            this.AddNewRecord.Size = new System.Drawing.Size(146, 28);
            this.AddNewRecord.Text = "Add New Record";
            this.AddNewRecord.Click += new System.EventHandler(this.AddNewRecord_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 482);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Pars Pack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGdata;
        private System.Windows.Forms.Button NextPageButton;
        private System.Windows.Forms.Button PreviousPageButton;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ToolStripButton CreateDb;
        private System.Windows.Forms.ToolStripButton ClearDb;
        private System.Windows.Forms.ToolStripButton fillFromAPI;
        private System.Windows.Forms.ToolStripButton FillFromLocalDB;
        private System.Windows.Forms.ToolStripButton AddNewRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

