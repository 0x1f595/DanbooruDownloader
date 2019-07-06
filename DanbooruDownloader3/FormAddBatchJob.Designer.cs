namespace DanbooruDownloader3
{
    partial class FormAddBatchJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddBatchJob));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTagQuery = new System.Windows.Forms.TextBox();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlProvider = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkNotRating = new System.Windows.Forms.CheckBox();
            this.cbxRating = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.txtFilenameFormat = new System.Windows.Forms.TextBox();
            this.chkIsExclude = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtTagQuery
            // 
            resources.ApplyResources(this.txtTagQuery, "txtTagQuery");
            this.txtTagQuery.Name = "txtTagQuery";
            // 
            // txtLimit
            // 
            resources.ApplyResources(this.txtLimit, "txtLimit");
            this.txtLimit.Name = "txtLimit";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // pnlProvider
            // 
            resources.ApplyResources(this.pnlProvider, "pnlProvider");
            this.pnlProvider.Name = "pnlProvider";
            this.pnlProvider.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pnlProvider_ControlAdded);
            // 
            // btnSelectAll
            // 
            resources.ApplyResources(this.btnSelectAll, "btnSelectAll");
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtPage
            // 
            resources.ApplyResources(this.txtPage, "txtPage");
            this.txtPage.Name = "txtPage";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // chkNotRating
            // 
            resources.ApplyResources(this.chkNotRating, "chkNotRating");
            this.chkNotRating.Name = "chkNotRating";
            this.chkNotRating.UseVisualStyleBackColor = true;
            // 
            // cbxRating
            // 
            this.cbxRating.FormattingEnabled = true;
            resources.ApplyResources(this.cbxRating, "cbxRating");
            this.cbxRating.Name = "cbxRating";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // txtFilter
            // 
            resources.ApplyResources(this.txtFilter, "txtFilter");
            this.txtFilter.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "filterExtensions", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Text = global::DanbooruDownloader3.Properties.Settings.Default.filterExtensions;
            // 
            // txtFilenameFormat
            // 
            resources.ApplyResources(this.txtFilenameFormat, "txtFilenameFormat");
            this.txtFilenameFormat.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "filenameFormat", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtFilenameFormat.Name = "txtFilenameFormat";
            this.txtFilenameFormat.Text = global::DanbooruDownloader3.Properties.Settings.Default.filenameFormat;
            // 
            // chkIsExclude
            // 
            resources.ApplyResources(this.chkIsExclude, "chkIsExclude");
            this.chkIsExclude.Name = "chkIsExclude";
            this.chkIsExclude.UseVisualStyleBackColor = true;
            // 
            // FormAddBatchJob
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkIsExclude);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.chkNotRating);
            this.Controls.Add(this.cbxRating);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFilenameFormat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pnlProvider);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTagQuery);
            this.Controls.Add(this.label1);
            this.Name = "FormAddBatchJob";
            this.Load += new System.EventHandler(this.FormAddBatchJob_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTagQuery;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel pnlProvider;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilenameFormat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkNotRating;
        private System.Windows.Forms.ComboBox cbxRating;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkIsExclude;
    }
}