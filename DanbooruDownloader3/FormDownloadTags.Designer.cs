namespace DanbooruDownloader3
{
    partial class FormDownloadTags
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDownloadTags));
            this.btnDownload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbxProvider = new System.Windows.Forms.ComboBox();
            this.chkAutoClose = new System.Windows.Forms.CheckBox();
            this.chkBackup = new System.Windows.Forms.CheckBox();
            this.chkMerge = new System.Windows.Forms.CheckBox();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.chkUseLoop = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStartingPage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            resources.ApplyResources(this.btnDownload, "btnDownload");
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtUrl
            // 
            resources.ApplyResources(this.txtUrl, "txtUrl");
            this.txtUrl.Name = "txtUrl";
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // lblStatus
            // 
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.Name = "lblStatus";
            // 
            // cbxProvider
            // 
            this.cbxProvider.FormattingEnabled = true;
            resources.ApplyResources(this.cbxProvider, "cbxProvider");
            this.cbxProvider.Name = "cbxProvider";
            this.cbxProvider.SelectedIndexChanged += new System.EventHandler(this.cbxProvider_SelectedIndexChanged);
            // 
            // chkAutoClose
            // 
            resources.ApplyResources(this.chkAutoClose, "chkAutoClose");
            this.chkAutoClose.Name = "chkAutoClose";
            this.chkAutoClose.UseVisualStyleBackColor = true;
            // 
            // chkBackup
            // 
            resources.ApplyResources(this.chkBackup, "chkBackup");
            this.chkBackup.Name = "chkBackup";
            this.chkBackup.UseVisualStyleBackColor = true;
            // 
            // chkMerge
            // 
            resources.ApplyResources(this.chkMerge, "chkMerge");
            this.chkMerge.Name = "chkMerge";
            this.chkMerge.UseVisualStyleBackColor = true;
            // 
            // pbIcon
            // 
            resources.ApplyResources(this.pbIcon, "pbIcon");
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.TabStop = false;
            // 
            // chkUseLoop
            // 
            resources.ApplyResources(this.chkUseLoop, "chkUseLoop");
            this.chkUseLoop.Name = "chkUseLoop";
            this.chkUseLoop.UseVisualStyleBackColor = true;
            this.chkUseLoop.CheckedChanged += new System.EventHandler(this.chkUseLoop_CheckedChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtStartingPage
            // 
            resources.ApplyResources(this.txtStartingPage, "txtStartingPage");
            this.txtStartingPage.Name = "txtStartingPage";
            // 
            // FormDownloadTags
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtStartingPage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkUseLoop);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.chkMerge);
            this.Controls.Add(this.chkBackup);
            this.Controls.Add(this.chkAutoClose);
            this.Controls.Add(this.cbxProvider);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDownload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormDownloadTags";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDownloadTags_FormClosing);
            this.Load += new System.EventHandler(this.FormDownloadTags_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbxProvider;
        private System.Windows.Forms.CheckBox chkAutoClose;
        private System.Windows.Forms.CheckBox chkBackup;
        private System.Windows.Forms.CheckBox chkMerge;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.CheckBox chkUseLoop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStartingPage;

    }
}