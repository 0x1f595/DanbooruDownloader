namespace DanbooruDownloader3
{
    partial class FormCookie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCookie));
            this.dgvCookie = new System.Windows.Forms.DataGridView();
            this.SiteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CookieNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CookieValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCookie)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCookie
            // 
            resources.ApplyResources(this.dgvCookie, "dgvCookie");
            this.dgvCookie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCookie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCookie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SiteColumn,
            this.CookieNameColumn,
            this.CookieValueColumn});
            this.dgvCookie.Name = "dgvCookie";
            // 
            // SiteColumn
            // 
            this.SiteColumn.DataPropertyName = "Domain";
            resources.ApplyResources(this.SiteColumn, "SiteColumn");
            this.SiteColumn.Name = "SiteColumn";
            // 
            // CookieNameColumn
            // 
            this.CookieNameColumn.DataPropertyName = "Name";
            resources.ApplyResources(this.CookieNameColumn, "CookieNameColumn");
            this.CookieNameColumn.Name = "CookieNameColumn";
            // 
            // CookieValueColumn
            // 
            this.CookieValueColumn.DataPropertyName = "Value";
            resources.ApplyResources(this.CookieValueColumn, "CookieValueColumn");
            this.CookieValueColumn.Name = "CookieValueColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Domain";
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Value";
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // FormCookie
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCookie);
            this.Name = "FormCookie";
            this.Load += new System.EventHandler(this.FormCookie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCookie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCookie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CookieNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CookieValueColumn;
    }
}