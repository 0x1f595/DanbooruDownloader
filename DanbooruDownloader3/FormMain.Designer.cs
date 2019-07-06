namespace DanbooruDownloader3
{
    partial class FormMain
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
            if (_pauseEvent != null) _pauseEvent.Dispose();
            if (_shutdownEvent!= null) _shutdownEvent.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbxAutoComplete = new System.Windows.Forms.ListBox();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSearchHelp = new System.Windows.Forms.Button();
            this.btnListCancel = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnGet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkNotRating = new System.Windows.Forms.CheckBox();
            this.cbxRating = new System.Windows.Forms.ComboBox();
            this.cbxProvider = new System.Windows.Forms.ComboBox();
            this.cbxOrder = new System.Windows.Forms.ComboBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkGenerate = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.gbxDanbooru = new System.Windows.Forms.GroupBox();
            this.chkAutoLoadNext = new System.Windows.Forms.CheckBox();
            this.chkAppendList = new System.Windows.Forms.CheckBox();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.chkSaveQuery = new System.Windows.Forms.CheckBox();
            this.chkAutoLoadList = new System.Windows.Forms.CheckBox();
            this.chkLoadPreview = new System.Windows.Forms.CheckBox();
            this.gbxList = new System.Windows.Forms.GroupBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddDownload = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnBrowseListFile = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtListFile = new System.Windows.Forms.TextBox();
            this.dgvList = new DanbooruDownloader3.CustomControl.gfDataGridView();
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colPreview = new System.Windows.Forms.DataGridViewImageColumn();
            this.colProvider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTagsE = new DanbooruDownloader3.CustomControl.TagsColumn();
            this.colUrl = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colMD5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSourceUrl = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colReferer = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxMenuList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.searchByParentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSelectedRowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.reloadThumbnailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.resetColumnOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnClearCompletedDownload = new System.Windows.Forms.Button();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLoadDownloadList = new System.Windows.Forms.Button();
            this.btnSaveDownloadList = new System.Windows.Forms.Button();
            this.btnCancelDownload = new System.Windows.Forms.Button();
            this.btnClearDownloadList = new System.Windows.Forms.Button();
            this.btnPauseDownload = new System.Windows.Forms.Button();
            this.btnDownloadFiles = new System.Windows.Forms.Button();
            this.dgvDownload = new DanbooruDownloader3.CustomControl.gfDataGridView();
            this.colIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPreview2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.colProgress2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProvider2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRating2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTags2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTagsE2 = new DanbooruDownloader3.CustomControl.TagsColumn();
            this.colUrl2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colReferer2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colMD52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuery2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDownloadStart2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxMenuDownload = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resolveFileUrlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSaveFolder = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnLoadList = new System.Windows.Forms.Button();
            this.btnSaveBatchList = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnClearCompleted = new System.Windows.Forms.Button();
            this.btnPauseBatchJob = new System.Windows.Forms.Button();
            this.btnStopBatchJob = new System.Windows.Forms.Button();
            this.btnStartBatchJob = new System.Windows.Forms.Button();
            this.btnAddBatchJob = new System.Windows.Forms.Button();
            this.dgvBatchJob = new DanbooruDownloader3.CustomControl.gfDataGridView();
            this.colBatchId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchTagQuery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchStartPage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchProviders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchSaveFolder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxMenuBatch = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxAbortOnError = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.chkProcessDeletedPost = new System.Windows.Forms.CheckBox();
            this.chkHideBlaclistedImage = new System.Windows.Forms.CheckBox();
            this.chkUseGlobalProviderTags = new System.Windows.Forms.CheckBox();
            this.chkMinimizeTray = new System.Windows.Forms.CheckBox();
            this.chkAutoFocus = new System.Windows.Forms.CheckBox();
            this.chkLogging = new System.Windows.Forms.CheckBox();
            this.chkUseTagColor = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNoFault = new System.Windows.Forms.TextBox();
            this.txtNoCircle = new System.Windows.Forms.TextBox();
            this.txtNoChara = new System.Windows.Forms.TextBox();
            this.txtNoCopyright = new System.Windows.Forms.TextBox();
            this.txtNoArtist = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.chkIgnoreTagsUseRegex = new System.Windows.Forms.CheckBox();
            this.chkBlacklistTagsUseRegex = new System.Windows.Forms.CheckBox();
            this.cbxWriteTag = new System.Windows.Forms.CheckBox();
            this.label31 = new System.Windows.Forms.Label();
            this.chkIsReplaceUnderscoreTag = new System.Windows.Forms.CheckBox();
            this.txtOverFault = new System.Windows.Forms.TextBox();
            this.txtOverCircle = new System.Windows.Forms.TextBox();
            this.txtOverChara = new System.Windows.Forms.TextBox();
            this.txtOverCopyright = new System.Windows.Forms.TextBox();
            this.txtOverArtist = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.chkBlacklistOnlyGeneral = new System.Windows.Forms.CheckBox();
            this.chkIgnoreForGeneralTag = new System.Windows.Forms.CheckBox();
            this.chkReplaceMode = new System.Windows.Forms.CheckBox();
            this.lblColorUnknown = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtIgnoredTags = new System.Windows.Forms.TextBox();
            this.txtAutoCompleteLimit = new System.Windows.Forms.TextBox();
            this.txtCircleTagGrouping = new System.Windows.Forms.TextBox();
            this.txtFaultsTagGrouping = new System.Windows.Forms.TextBox();
            this.txtCharaTagGrouping = new System.Windows.Forms.TextBox();
            this.txtTagReplacement = new System.Windows.Forms.TextBox();
            this.txtCopyTagGrouping = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lblColorBlacklistedTag = new System.Windows.Forms.Label();
            this.chkTagAutoComplete = new System.Windows.Forms.CheckBox();
            this.lblColorFaults = new System.Windows.Forms.Label();
            this.txtArtistTagGrouping = new System.Windows.Forms.TextBox();
            this.lblColorCircle = new System.Windows.Forms.Label();
            this.lblColorChara = new System.Windows.Forms.Label();
            this.lblColorCopy = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtTagBlacklist = new System.Windows.Forms.TextBox();
            this.lblColorArtist = new System.Windows.Forms.Label();
            this.lblColorGeneral = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDateTimeFormat = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.chkWriteDownloadedFileTxt = new System.Windows.Forms.CheckBox();
            this.chkDelayIncludeSkip = new System.Windows.Forms.CheckBox();
            this.txtBatchJobDelay = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.chkSaveFolderWhenExit = new System.Windows.Forms.CheckBox();
            this.btnBrowseDefaultSave = new System.Windows.Forms.Button();
            this.txtDefaultSaveFolder = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cbxImageSize = new System.Windows.Forms.ComboBox();
            this.chkRenameJpeg = new System.Windows.Forms.CheckBox();
            this.txtFilenameLength = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.chkOverwrite = new System.Windows.Forms.CheckBox();
            this.txtFilenameFormat = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkEnableCompression = new System.Windows.Forms.CheckBox();
            this.txtAcceptLanguage = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.chkEnableCookie = new System.Windows.Forms.CheckBox();
            this.btnCookie = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.linkUrl = new System.Windows.Forms.LinkLabel();
            this.chkProxyLogin = new System.Windows.Forms.CheckBox();
            this.txtProxyPassword = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtProxyUsername = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.chkPadUserAgent = new System.Windows.Forms.CheckBox();
            this.txtRetry = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTimeout = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtUserAgent = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.chkUseProxy = new System.Windows.Forms.CheckBox();
            this.txtProxyPort = new System.Windows.Forms.TextBox();
            this.txtProxyAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFilenameHelp = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.ctxMenuLog = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timGifAnimation = new System.Windows.Forms.Timer(this.components);
            this.timLoadNextPage = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsTotalCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tsProgress2 = new System.Windows.Forms.ToolStripProgressBar();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctxMenuSysTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagsColumn1 = new DanbooruDownloader3.CustomControl.TagsColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagsColumn2 = new DanbooruDownloader3.CustomControl.TagsColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.gbxDanbooru.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.gbxList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.ctxMenuList.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDownload)).BeginInit();
            this.ctxMenuDownload.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchJob)).BeginInit();
            this.ctxMenuBatch.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.ctxMenuLog.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.ctxMenuSysTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbxAutoComplete);
            this.tabPage1.Controls.Add(this.gbxSearch);
            this.tabPage1.Controls.Add(this.gbxDanbooru);
            this.tabPage1.Controls.Add(this.gbxList);
            this.tabPage1.Controls.Add(this.dgvList);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbxAutoComplete
            // 
            this.lbxAutoComplete.FormattingEnabled = true;
            resources.ApplyResources(this.lbxAutoComplete, "lbxAutoComplete");
            this.lbxAutoComplete.Name = "lbxAutoComplete";
            this.lbxAutoComplete.DataSourceChanged += new System.EventHandler(this.lbxAutoComplete_DataSourceChanged);
            this.lbxAutoComplete.DoubleClick += new System.EventHandler(this.lbxAutoComplete_DoubleClick);
            this.lbxAutoComplete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbxAutoComplete_KeyDown);
            this.lbxAutoComplete.Leave += new System.EventHandler(this.lbxAutoComplete_Leave);
            // 
            // gbxSearch
            // 
            resources.ApplyResources(this.gbxSearch, "gbxSearch");
            this.gbxSearch.Controls.Add(this.btnPrevPage);
            this.gbxSearch.Controls.Add(this.btnNextPage);
            this.gbxSearch.Controls.Add(this.pbIcon);
            this.gbxSearch.Controls.Add(this.btnEdit);
            this.gbxSearch.Controls.Add(this.btnSearchHelp);
            this.gbxSearch.Controls.Add(this.btnListCancel);
            this.gbxSearch.Controls.Add(this.linkLabel1);
            this.gbxSearch.Controls.Add(this.btnGet);
            this.gbxSearch.Controls.Add(this.label1);
            this.gbxSearch.Controls.Add(this.chkNotRating);
            this.gbxSearch.Controls.Add(this.cbxRating);
            this.gbxSearch.Controls.Add(this.cbxProvider);
            this.gbxSearch.Controls.Add(this.cbxOrder);
            this.gbxSearch.Controls.Add(this.txtSource);
            this.gbxSearch.Controls.Add(this.label8);
            this.gbxSearch.Controls.Add(this.label7);
            this.gbxSearch.Controls.Add(this.label6);
            this.gbxSearch.Controls.Add(this.txtPage);
            this.gbxSearch.Controls.Add(this.label5);
            this.gbxSearch.Controls.Add(this.txtLimit);
            this.gbxSearch.Controls.Add(this.label4);
            this.gbxSearch.Controls.Add(this.txtTags);
            this.gbxSearch.Controls.Add(this.label3);
            this.gbxSearch.Controls.Add(this.chkGenerate);
            this.gbxSearch.Controls.Add(this.label2);
            this.gbxSearch.Controls.Add(this.txtQuery);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.TabStop = false;
            // 
            // btnPrevPage
            // 
            resources.ApplyResources(this.btnPrevPage, "btnPrevPage");
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.UseVisualStyleBackColor = true;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // btnNextPage
            // 
            resources.ApplyResources(this.btnNextPage, "btnNextPage");
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // pbIcon
            // 
            resources.ApplyResources(this.pbIcon, "pbIcon");
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.TabStop = false;
            // 
            // btnEdit
            // 
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSearchHelp
            // 
            resources.ApplyResources(this.btnSearchHelp, "btnSearchHelp");
            this.btnSearchHelp.Name = "btnSearchHelp";
            this.btnSearchHelp.UseVisualStyleBackColor = true;
            this.btnSearchHelp.Click += new System.EventHandler(this.btnSearchHelp_Click);
            // 
            // btnListCancel
            // 
            resources.ApplyResources(this.btnListCancel, "btnListCancel");
            this.btnListCancel.Name = "btnListCancel";
            this.btnListCancel.UseVisualStyleBackColor = true;
            this.btnListCancel.Click += new System.EventHandler(this.btnListCancel_Click);
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnGet
            // 
            resources.ApplyResources(this.btnGet, "btnGet");
            this.btnGet.Name = "btnGet";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // chkNotRating
            // 
            resources.ApplyResources(this.chkNotRating, "chkNotRating");
            this.chkNotRating.Name = "chkNotRating";
            this.chkNotRating.UseVisualStyleBackColor = true;
            this.chkNotRating.CheckedChanged += new System.EventHandler(this.chkRating_CheckedChanged);
            // 
            // cbxRating
            // 
            this.cbxRating.FormattingEnabled = true;
            resources.ApplyResources(this.cbxRating, "cbxRating");
            this.cbxRating.Name = "cbxRating";
            this.cbxRating.SelectedIndexChanged += new System.EventHandler(this.cbxRating_SelectedIndexChanged);
            // 
            // cbxProvider
            // 
            resources.ApplyResources(this.cbxProvider, "cbxProvider");
            this.cbxProvider.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxProvider.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxProvider.FormattingEnabled = true;
            this.cbxProvider.Name = "cbxProvider";
            this.cbxProvider.SelectedIndexChanged += new System.EventHandler(this.cbxProvider_SelectedIndexChanged);
            // 
            // cbxOrder
            // 
            this.cbxOrder.FormattingEnabled = true;
            resources.ApplyResources(this.cbxOrder, "cbxOrder");
            this.cbxOrder.Name = "cbxOrder";
            this.cbxOrder.SelectedIndexChanged += new System.EventHandler(this.cbxOrder_SelectedIndexChanged);
            // 
            // txtSource
            // 
            resources.ApplyResources(this.txtSource, "txtSource");
            this.txtSource.Name = "txtSource";
            this.txtSource.TextChanged += new System.EventHandler(this.txtSource_TextChanged);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
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
            // txtPage
            // 
            resources.ApplyResources(this.txtPage, "txtPage");
            this.txtPage.Name = "txtPage";
            this.txtPage.TextChanged += new System.EventHandler(this.txtPage_TextChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txtLimit
            // 
            resources.ApplyResources(this.txtLimit, "txtLimit");
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.TextChanged += new System.EventHandler(this.txtLimit_TextChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtTags
            // 
            resources.ApplyResources(this.txtTags, "txtTags");
            this.txtTags.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTags.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTags.Name = "txtTags";
            this.txtTags.TextChanged += new System.EventHandler(this.txtTags_TextChanged);
            this.txtTags.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTags_KeyDown);
            this.txtTags.Leave += new System.EventHandler(this.txtTags_Leave);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // chkGenerate
            // 
            resources.ApplyResources(this.chkGenerate, "chkGenerate");
            this.chkGenerate.Checked = true;
            this.chkGenerate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGenerate.Name = "chkGenerate";
            this.chkGenerate.UseVisualStyleBackColor = true;
            this.chkGenerate.CheckedChanged += new System.EventHandler(this.chkGenerate_CheckedChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtQuery
            // 
            resources.ApplyResources(this.txtQuery, "txtQuery");
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.ReadOnly = true;
            this.txtQuery.TextChanged += new System.EventHandler(this.txtQuery_TextChanged);
            // 
            // gbxDanbooru
            // 
            resources.ApplyResources(this.gbxDanbooru, "gbxDanbooru");
            this.gbxDanbooru.Controls.Add(this.chkAutoLoadNext);
            this.gbxDanbooru.Controls.Add(this.chkAppendList);
            this.gbxDanbooru.Controls.Add(this.pbLoading);
            this.gbxDanbooru.Controls.Add(this.chkSaveQuery);
            this.gbxDanbooru.Controls.Add(this.chkAutoLoadList);
            this.gbxDanbooru.Controls.Add(this.chkLoadPreview);
            this.gbxDanbooru.Name = "gbxDanbooru";
            this.gbxDanbooru.TabStop = false;
            // 
            // chkAutoLoadNext
            // 
            resources.ApplyResources(this.chkAutoLoadNext, "chkAutoLoadNext");
            this.chkAutoLoadNext.Checked = global::DanbooruDownloader3.Properties.Settings.Default.AutoLoadNextPage;
            this.chkAutoLoadNext.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoLoadNext.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "AutoLoadNextPage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAutoLoadNext.Name = "chkAutoLoadNext";
            this.chkAutoLoadNext.UseVisualStyleBackColor = true;
            // 
            // chkAppendList
            // 
            resources.ApplyResources(this.chkAppendList, "chkAppendList");
            this.chkAppendList.Checked = global::DanbooruDownloader3.Properties.Settings.Default.AppendList;
            this.chkAppendList.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "AppendList", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAppendList.Name = "chkAppendList";
            this.chkAppendList.UseVisualStyleBackColor = true;
            // 
            // pbLoading
            // 
            resources.ApplyResources(this.pbLoading, "pbLoading");
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.TabStop = false;
            // 
            // chkSaveQuery
            // 
            resources.ApplyResources(this.chkSaveQuery, "chkSaveQuery");
            this.chkSaveQuery.Checked = global::DanbooruDownloader3.Properties.Settings.Default.SaveQuery;
            this.chkSaveQuery.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "SaveQuery", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkSaveQuery.Name = "chkSaveQuery";
            this.chkSaveQuery.UseVisualStyleBackColor = true;
            // 
            // chkAutoLoadList
            // 
            resources.ApplyResources(this.chkAutoLoadList, "chkAutoLoadList");
            this.chkAutoLoadList.Checked = global::DanbooruDownloader3.Properties.Settings.Default.AutoLoadList;
            this.chkAutoLoadList.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "AutoLoadList", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAutoLoadList.Name = "chkAutoLoadList";
            this.chkAutoLoadList.UseVisualStyleBackColor = true;
            // 
            // chkLoadPreview
            // 
            resources.ApplyResources(this.chkLoadPreview, "chkLoadPreview");
            this.chkLoadPreview.Checked = global::DanbooruDownloader3.Properties.Settings.Default.LoadPreview;
            this.chkLoadPreview.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "LoadPreview", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkLoadPreview.Name = "chkLoadPreview";
            this.chkLoadPreview.UseVisualStyleBackColor = true;
            // 
            // gbxList
            // 
            resources.ApplyResources(this.gbxList, "gbxList");
            this.gbxList.Controls.Add(this.btnSelectAll);
            this.gbxList.Controls.Add(this.btnClear);
            this.gbxList.Controls.Add(this.btnAddDownload);
            this.gbxList.Controls.Add(this.btnList);
            this.gbxList.Controls.Add(this.btnBrowseListFile);
            this.gbxList.Controls.Add(this.label9);
            this.gbxList.Controls.Add(this.txtListFile);
            this.gbxList.Name = "gbxList";
            this.gbxList.TabStop = false;
            // 
            // btnSelectAll
            // 
            resources.ApplyResources(this.btnSelectAll, "btnSelectAll");
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddDownload
            // 
            resources.ApplyResources(this.btnAddDownload, "btnAddDownload");
            this.btnAddDownload.Name = "btnAddDownload";
            this.btnAddDownload.UseVisualStyleBackColor = true;
            this.btnAddDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnList
            // 
            resources.ApplyResources(this.btnList, "btnList");
            this.btnList.Name = "btnList";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnBrowseListFile
            // 
            resources.ApplyResources(this.btnBrowseListFile, "btnBrowseListFile");
            this.btnBrowseListFile.Name = "btnBrowseListFile";
            this.btnBrowseListFile.UseVisualStyleBackColor = true;
            this.btnBrowseListFile.Click += new System.EventHandler(this.btnBrowseListFile_Click);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // txtListFile
            // 
            resources.ApplyResources(this.txtListFile, "txtListFile");
            this.txtListFile.Name = "txtListFile";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dgvList, "dgvList");
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumber,
            this.colCheck,
            this.colPreview,
            this.colProvider,
            this.colId,
            this.colRating,
            this.colScore,
            this.colTags,
            this.colTagsE,
            this.colUrl,
            this.colMD5,
            this.colQuery,
            this.colSourceUrl,
            this.colReferer,
            this.colStatus});
            this.dgvList.ContextMenuStrip = this.ctxMenuList;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvList.MaxWidth = 0;
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvList.RowHeadersVisible = false;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvList.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowTemplate.Height = 24;
            this.dgvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellContentClick);
            this.dgvList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvList_CellMouseDown);
            this.dgvList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvList_RowPostPaint);
            this.dgvList.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvList_RowsAdded);
            // 
            // colNumber
            // 
            this.colNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colNumber.FillWeight = 35F;
            this.colNumber.Frozen = true;
            resources.ApplyResources(this.colNumber, "colNumber");
            this.colNumber.Name = "colNumber";
            this.colNumber.ReadOnly = true;
            // 
            // colCheck
            // 
            this.colCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCheck.FillWeight = 25F;
            this.colCheck.Frozen = true;
            resources.ApplyResources(this.colCheck, "colCheck");
            this.colCheck.Name = "colCheck";
            this.colCheck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colPreview
            // 
            this.colPreview.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPreview.DataPropertyName = "ThumbnailImage";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colPreview.DefaultCellStyle = dataGridViewCellStyle3;
            this.colPreview.FillWeight = 200F;
            this.colPreview.Frozen = true;
            resources.ApplyResources(this.colPreview, "colPreview");
            this.colPreview.Image = global::DanbooruDownloader3.Properties.Resources.NOT_AVAILABLE;
            this.colPreview.Name = "colPreview";
            this.colPreview.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colProvider
            // 
            this.colProvider.DataPropertyName = "provider";
            resources.ApplyResources(this.colProvider, "colProvider");
            this.colProvider.Name = "colProvider";
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colId.DataPropertyName = "Id";
            this.colId.FillWeight = 75F;
            resources.ApplyResources(this.colId, "colId");
            this.colId.Name = "colId";
            this.colId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colRating
            // 
            this.colRating.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colRating.DataPropertyName = "Rating";
            this.colRating.FillWeight = 25F;
            resources.ApplyResources(this.colRating, "colRating");
            this.colRating.Name = "colRating";
            // 
            // colScore
            // 
            this.colScore.DataPropertyName = "Score";
            resources.ApplyResources(this.colScore, "colScore");
            this.colScore.Name = "colScore";
            // 
            // colTags
            // 
            this.colTags.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTags.DataPropertyName = "Tags";
            this.colTags.FillWeight = 300F;
            resources.ApplyResources(this.colTags, "colTags");
            this.colTags.Name = "colTags";
            // 
            // colTagsE
            // 
            this.colTagsE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTagsE.DataPropertyName = "TagsEntity";
            this.colTagsE.FillWeight = 300F;
            resources.ApplyResources(this.colTagsE, "colTagsE");
            this.colTagsE.Name = "colTagsE";
            this.colTagsE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTagsE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colUrl
            // 
            this.colUrl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colUrl.DataPropertyName = "FileUrl";
            this.colUrl.FillWeight = 250F;
            resources.ApplyResources(this.colUrl, "colUrl");
            this.colUrl.Name = "colUrl";
            this.colUrl.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colUrl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colMD5
            // 
            this.colMD5.DataPropertyName = "MD5";
            resources.ApplyResources(this.colMD5, "colMD5");
            this.colMD5.Name = "colMD5";
            // 
            // colQuery
            // 
            this.colQuery.DataPropertyName = "Query";
            resources.ApplyResources(this.colQuery, "colQuery");
            this.colQuery.Name = "colQuery";
            // 
            // colSourceUrl
            // 
            this.colSourceUrl.DataPropertyName = "Source";
            resources.ApplyResources(this.colSourceUrl, "colSourceUrl");
            this.colSourceUrl.Name = "colSourceUrl";
            this.colSourceUrl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colReferer
            // 
            this.colReferer.DataPropertyName = "Referer";
            resources.ApplyResources(this.colReferer, "colReferer");
            this.colReferer.Name = "colReferer";
            this.colReferer.ReadOnly = true;
            this.colReferer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            resources.ApplyResources(this.colStatus, "colStatus");
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // ctxMenuList
            // 
            this.ctxMenuList.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMenuList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchByParentToolStripMenuItem,
            this.addSelectedRowsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.reloadThumbnailToolStripMenuItem,
            this.toolStripMenuItem4,
            this.resetColumnOrderToolStripMenuItem});
            this.ctxMenuList.Name = "contextMenuStrip3";
            resources.ApplyResources(this.ctxMenuList, "ctxMenuList");
            // 
            // searchByParentToolStripMenuItem
            // 
            this.searchByParentToolStripMenuItem.Name = "searchByParentToolStripMenuItem";
            resources.ApplyResources(this.searchByParentToolStripMenuItem, "searchByParentToolStripMenuItem");
            this.searchByParentToolStripMenuItem.Click += new System.EventHandler(this.searchByParentToolStripMenuItem_Click);
            // 
            // addSelectedRowsToolStripMenuItem
            // 
            this.addSelectedRowsToolStripMenuItem.Name = "addSelectedRowsToolStripMenuItem";
            resources.ApplyResources(this.addSelectedRowsToolStripMenuItem, "addSelectedRowsToolStripMenuItem");
            this.addSelectedRowsToolStripMenuItem.Click += new System.EventHandler(this.addSelectedRowsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            // 
            // reloadThumbnailToolStripMenuItem
            // 
            this.reloadThumbnailToolStripMenuItem.Name = "reloadThumbnailToolStripMenuItem";
            resources.ApplyResources(this.reloadThumbnailToolStripMenuItem, "reloadThumbnailToolStripMenuItem");
            this.reloadThumbnailToolStripMenuItem.Click += new System.EventHandler(this.reloadThumbnailToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            // 
            // resetColumnOrderToolStripMenuItem
            // 
            this.resetColumnOrderToolStripMenuItem.Name = "resetColumnOrderToolStripMenuItem";
            resources.ApplyResources(this.resetColumnOrderToolStripMenuItem, "resetColumnOrderToolStripMenuItem");
            this.resetColumnOrderToolStripMenuItem.Click += new System.EventHandler(this.resetColumnOrderToolStripMenuItem_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnClearCompletedDownload);
            this.tabPage4.Controls.Add(this.btnBrowseFolder);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.btnLoadDownloadList);
            this.tabPage4.Controls.Add(this.btnSaveDownloadList);
            this.tabPage4.Controls.Add(this.btnCancelDownload);
            this.tabPage4.Controls.Add(this.btnClearDownloadList);
            this.tabPage4.Controls.Add(this.btnPauseDownload);
            this.tabPage4.Controls.Add(this.btnDownloadFiles);
            this.tabPage4.Controls.Add(this.dgvDownload);
            this.tabPage4.Controls.Add(this.txtSaveFolder);
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnClearCompletedDownload
            // 
            resources.ApplyResources(this.btnClearCompletedDownload, "btnClearCompletedDownload");
            this.btnClearCompletedDownload.Name = "btnClearCompletedDownload";
            this.btnClearCompletedDownload.UseVisualStyleBackColor = true;
            this.btnClearCompletedDownload.Click += new System.EventHandler(this.btnClearCompletedDownload_Click);
            // 
            // btnBrowseFolder
            // 
            resources.ApplyResources(this.btnBrowseFolder, "btnBrowseFolder");
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click_1);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // btnLoadDownloadList
            // 
            resources.ApplyResources(this.btnLoadDownloadList, "btnLoadDownloadList");
            this.btnLoadDownloadList.Name = "btnLoadDownloadList";
            this.btnLoadDownloadList.UseVisualStyleBackColor = true;
            this.btnLoadDownloadList.Click += new System.EventHandler(this.btnLoadDownloadList_Click);
            // 
            // btnSaveDownloadList
            // 
            resources.ApplyResources(this.btnSaveDownloadList, "btnSaveDownloadList");
            this.btnSaveDownloadList.Name = "btnSaveDownloadList";
            this.btnSaveDownloadList.UseVisualStyleBackColor = true;
            this.btnSaveDownloadList.Click += new System.EventHandler(this.btnSaveDownloadList_Click);
            // 
            // btnCancelDownload
            // 
            resources.ApplyResources(this.btnCancelDownload, "btnCancelDownload");
            this.btnCancelDownload.Name = "btnCancelDownload";
            this.btnCancelDownload.UseVisualStyleBackColor = true;
            this.btnCancelDownload.Click += new System.EventHandler(this.btnCancelDownload_Click);
            // 
            // btnClearDownloadList
            // 
            resources.ApplyResources(this.btnClearDownloadList, "btnClearDownloadList");
            this.btnClearDownloadList.Name = "btnClearDownloadList";
            this.btnClearDownloadList.UseVisualStyleBackColor = true;
            this.btnClearDownloadList.Click += new System.EventHandler(this.btnClearDownloadList_Click);
            // 
            // btnPauseDownload
            // 
            resources.ApplyResources(this.btnPauseDownload, "btnPauseDownload");
            this.btnPauseDownload.Name = "btnPauseDownload";
            this.btnPauseDownload.UseVisualStyleBackColor = true;
            this.btnPauseDownload.Click += new System.EventHandler(this.btnPauseDownload_Click);
            // 
            // btnDownloadFiles
            // 
            resources.ApplyResources(this.btnDownloadFiles, "btnDownloadFiles");
            this.btnDownloadFiles.Name = "btnDownloadFiles";
            this.btnDownloadFiles.UseVisualStyleBackColor = true;
            this.btnDownloadFiles.Click += new System.EventHandler(this.btnDownloadFiles_Click);
            // 
            // dgvDownload
            // 
            this.dgvDownload.AllowUserToAddRows = false;
            this.dgvDownload.AllowUserToDeleteRows = false;
            this.dgvDownload.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDownload.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            resources.ApplyResources(this.dgvDownload, "dgvDownload");
            this.dgvDownload.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDownload.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDownload.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDownload.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDownload.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIndex,
            this.colPreview2,
            this.colProgress2,
            this.colProvider2,
            this.colId2,
            this.colRating2,
            this.colTags2,
            this.colTagsE2,
            this.colUrl2,
            this.colReferer2,
            this.colMD52,
            this.colQuery2,
            this.colFilename,
            this.colDownloadStart2});
            this.dgvDownload.ContextMenuStrip = this.ctxMenuDownload;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDownload.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDownload.MaxWidth = 0;
            this.dgvDownload.Name = "dgvDownload";
            this.dgvDownload.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDownload.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDownload.RowHeadersVisible = false;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDownload.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDownload.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDownload.RowTemplate.Height = 24;
            this.dgvDownload.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDownload.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDownload_CellContentClick);
            this.dgvDownload.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvDownload_RowsAdded);
            this.dgvDownload.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvDownload_MouseClick);
            // 
            // colIndex
            // 
            this.colIndex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colIndex.FillWeight = 35F;
            this.colIndex.Frozen = true;
            resources.ApplyResources(this.colIndex, "colIndex");
            this.colIndex.Name = "colIndex";
            // 
            // colPreview2
            // 
            this.colPreview2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.colPreview2.DataPropertyName = "ThumbnailImage";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colPreview2.DefaultCellStyle = dataGridViewCellStyle9;
            this.colPreview2.FillWeight = 300F;
            this.colPreview2.Frozen = true;
            resources.ApplyResources(this.colPreview2, "colPreview2");
            this.colPreview2.Image = global::DanbooruDownloader3.Properties.Resources.NOT_AVAILABLE;
            this.colPreview2.Name = "colPreview2";
            // 
            // colProgress2
            // 
            this.colProgress2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colProgress2.DataPropertyName = "Progress";
            this.colProgress2.FillWeight = 200F;
            this.colProgress2.Frozen = true;
            resources.ApplyResources(this.colProgress2, "colProgress2");
            this.colProgress2.Name = "colProgress2";
            this.colProgress2.ReadOnly = true;
            // 
            // colProvider2
            // 
            this.colProvider2.DataPropertyName = "provider";
            this.colProvider2.Frozen = true;
            resources.ApplyResources(this.colProvider2, "colProvider2");
            this.colProvider2.Name = "colProvider2";
            // 
            // colId2
            // 
            this.colId2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colId2.DataPropertyName = "Id";
            this.colId2.FillWeight = 75F;
            resources.ApplyResources(this.colId2, "colId2");
            this.colId2.Name = "colId2";
            this.colId2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colId2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colRating2
            // 
            this.colRating2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colRating2.DataPropertyName = "Rating";
            this.colRating2.FillWeight = 25F;
            resources.ApplyResources(this.colRating2, "colRating2");
            this.colRating2.Name = "colRating2";
            // 
            // colTags2
            // 
            this.colTags2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTags2.DataPropertyName = "Tags";
            this.colTags2.FillWeight = 300F;
            resources.ApplyResources(this.colTags2, "colTags2");
            this.colTags2.Name = "colTags2";
            // 
            // colTagsE2
            // 
            this.colTagsE2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTagsE2.DataPropertyName = "TagsEntity";
            this.colTagsE2.FillWeight = 300F;
            resources.ApplyResources(this.colTagsE2, "colTagsE2");
            this.colTagsE2.Name = "colTagsE2";
            // 
            // colUrl2
            // 
            this.colUrl2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colUrl2.DataPropertyName = "FileUrl";
            this.colUrl2.FillWeight = 200F;
            resources.ApplyResources(this.colUrl2, "colUrl2");
            this.colUrl2.Name = "colUrl2";
            this.colUrl2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colUrl2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colReferer2
            // 
            this.colReferer2.DataPropertyName = "Referer";
            resources.ApplyResources(this.colReferer2, "colReferer2");
            this.colReferer2.Name = "colReferer2";
            this.colReferer2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colReferer2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colMD52
            // 
            this.colMD52.DataPropertyName = "MD5";
            resources.ApplyResources(this.colMD52, "colMD52");
            this.colMD52.Name = "colMD52";
            // 
            // colQuery2
            // 
            this.colQuery2.DataPropertyName = "Query";
            resources.ApplyResources(this.colQuery2, "colQuery2");
            this.colQuery2.Name = "colQuery2";
            // 
            // colFilename
            // 
            this.colFilename.DataPropertyName = "Filename";
            resources.ApplyResources(this.colFilename, "colFilename");
            this.colFilename.Name = "colFilename";
            // 
            // colDownloadStart2
            // 
            resources.ApplyResources(this.colDownloadStart2, "colDownloadStart2");
            this.colDownloadStart2.Name = "colDownloadStart2";
            // 
            // ctxMenuDownload
            // 
            this.ctxMenuDownload.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMenuDownload.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resolveFileUrlToolStripMenuItem,
            this.toolStripMenuItem5,
            this.deleteToolStripMenuItem,
            this.openFileToolStripMenuItem});
            this.ctxMenuDownload.Name = "contextMenuStrip1";
            resources.ApplyResources(this.ctxMenuDownload, "ctxMenuDownload");
            // 
            // resolveFileUrlToolStripMenuItem
            // 
            this.resolveFileUrlToolStripMenuItem.Name = "resolveFileUrlToolStripMenuItem";
            resources.ApplyResources(this.resolveFileUrlToolStripMenuItem, "resolveFileUrlToolStripMenuItem");
            this.resolveFileUrlToolStripMenuItem.Click += new System.EventHandler(this.resolveFileUrlToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            resources.ApplyResources(this.openFileToolStripMenuItem, "openFileToolStripMenuItem");
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // txtSaveFolder
            // 
            resources.ApplyResources(this.txtSaveFolder, "txtSaveFolder");
            this.txtSaveFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "SaveFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtSaveFolder.Name = "txtSaveFolder";
            this.txtSaveFolder.Text = global::DanbooruDownloader3.Properties.Settings.Default.SaveFolder;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnLoadList);
            this.tabPage5.Controls.Add(this.btnSaveBatchList);
            this.tabPage5.Controls.Add(this.btnClearAll);
            this.tabPage5.Controls.Add(this.btnClearCompleted);
            this.tabPage5.Controls.Add(this.btnPauseBatchJob);
            this.tabPage5.Controls.Add(this.btnStopBatchJob);
            this.tabPage5.Controls.Add(this.btnStartBatchJob);
            this.tabPage5.Controls.Add(this.btnAddBatchJob);
            this.tabPage5.Controls.Add(this.dgvBatchJob);
            this.tabPage5.Controls.Add(this.cbxAbortOnError);
            resources.ApplyResources(this.tabPage5, "tabPage5");
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnLoadList
            // 
            resources.ApplyResources(this.btnLoadList, "btnLoadList");
            this.btnLoadList.Name = "btnLoadList";
            this.btnLoadList.UseVisualStyleBackColor = true;
            this.btnLoadList.Click += new System.EventHandler(this.btnLoadList_Click);
            // 
            // btnSaveBatchList
            // 
            resources.ApplyResources(this.btnSaveBatchList, "btnSaveBatchList");
            this.btnSaveBatchList.Name = "btnSaveBatchList";
            this.btnSaveBatchList.UseVisualStyleBackColor = true;
            this.btnSaveBatchList.Click += new System.EventHandler(this.btnSaveBatchList_Click);
            // 
            // btnClearAll
            // 
            resources.ApplyResources(this.btnClearAll, "btnClearAll");
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnClearCompleted
            // 
            resources.ApplyResources(this.btnClearCompleted, "btnClearCompleted");
            this.btnClearCompleted.Name = "btnClearCompleted";
            this.btnClearCompleted.UseVisualStyleBackColor = true;
            this.btnClearCompleted.Click += new System.EventHandler(this.btnClearCompleted_Click);
            // 
            // btnPauseBatchJob
            // 
            resources.ApplyResources(this.btnPauseBatchJob, "btnPauseBatchJob");
            this.btnPauseBatchJob.Name = "btnPauseBatchJob";
            this.btnPauseBatchJob.UseVisualStyleBackColor = true;
            this.btnPauseBatchJob.Click += new System.EventHandler(this.btnPauseBatchJob_Click);
            // 
            // btnStopBatchJob
            // 
            resources.ApplyResources(this.btnStopBatchJob, "btnStopBatchJob");
            this.btnStopBatchJob.Name = "btnStopBatchJob";
            this.btnStopBatchJob.UseVisualStyleBackColor = true;
            this.btnStopBatchJob.Click += new System.EventHandler(this.btnStopBatchJob_Click);
            // 
            // btnStartBatchJob
            // 
            resources.ApplyResources(this.btnStartBatchJob, "btnStartBatchJob");
            this.btnStartBatchJob.Name = "btnStartBatchJob";
            this.btnStartBatchJob.UseVisualStyleBackColor = true;
            this.btnStartBatchJob.Click += new System.EventHandler(this.btnStartBatchJob_Click);
            // 
            // btnAddBatchJob
            // 
            resources.ApplyResources(this.btnAddBatchJob, "btnAddBatchJob");
            this.btnAddBatchJob.Name = "btnAddBatchJob";
            this.btnAddBatchJob.UseVisualStyleBackColor = true;
            this.btnAddBatchJob.Click += new System.EventHandler(this.btnAddBatchJob_Click);
            // 
            // dgvBatchJob
            // 
            this.dgvBatchJob.AllowUserToAddRows = false;
            this.dgvBatchJob.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dgvBatchJob, "dgvBatchJob");
            this.dgvBatchJob.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBatchJob.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvBatchJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBatchJob.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBatchId,
            this.colBatchTagQuery,
            this.colBatchLimit,
            this.colBatchRating,
            this.colBatchStartPage,
            this.colBatchProviders,
            this.colBatchSaveFolder,
            this.colBatchStatus});
            this.dgvBatchJob.ContextMenuStrip = this.ctxMenuBatch;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBatchJob.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvBatchJob.MaxWidth = 0;
            this.dgvBatchJob.Name = "dgvBatchJob";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBatchJob.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvBatchJob.RowHeadersVisible = false;
            this.dgvBatchJob.RowTemplate.Height = 24;
            this.dgvBatchJob.ShowCellErrors = false;
            this.dgvBatchJob.ShowCellToolTips = false;
            this.dgvBatchJob.ShowEditingIcon = false;
            this.dgvBatchJob.ShowRowErrors = false;
            this.dgvBatchJob.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvBatchJob_RowsAdded);
            this.dgvBatchJob.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvBatchJob_MouseDown);
            // 
            // colBatchId
            // 
            this.colBatchId.FillWeight = 50F;
            this.colBatchId.Frozen = true;
            resources.ApplyResources(this.colBatchId, "colBatchId");
            this.colBatchId.Name = "colBatchId";
            this.colBatchId.ReadOnly = true;
            this.colBatchId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colBatchTagQuery
            // 
            this.colBatchTagQuery.DataPropertyName = "TagQuery";
            resources.ApplyResources(this.colBatchTagQuery, "colBatchTagQuery");
            this.colBatchTagQuery.Name = "colBatchTagQuery";
            this.colBatchTagQuery.ReadOnly = true;
            // 
            // colBatchLimit
            // 
            this.colBatchLimit.DataPropertyName = "Limit";
            this.colBatchLimit.FillWeight = 50F;
            resources.ApplyResources(this.colBatchLimit, "colBatchLimit");
            this.colBatchLimit.Name = "colBatchLimit";
            this.colBatchLimit.ReadOnly = true;
            // 
            // colBatchRating
            // 
            this.colBatchRating.DataPropertyName = "Rating";
            this.colBatchRating.FillWeight = 75F;
            resources.ApplyResources(this.colBatchRating, "colBatchRating");
            this.colBatchRating.Name = "colBatchRating";
            // 
            // colBatchStartPage
            // 
            this.colBatchStartPage.DataPropertyName = "StartPage";
            this.colBatchStartPage.FillWeight = 50F;
            resources.ApplyResources(this.colBatchStartPage, "colBatchStartPage");
            this.colBatchStartPage.Name = "colBatchStartPage";
            // 
            // colBatchProviders
            // 
            this.colBatchProviders.DataPropertyName = "ProviderName";
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colBatchProviders.DefaultCellStyle = dataGridViewCellStyle14;
            this.colBatchProviders.FillWeight = 150F;
            resources.ApplyResources(this.colBatchProviders, "colBatchProviders");
            this.colBatchProviders.Name = "colBatchProviders";
            this.colBatchProviders.ReadOnly = true;
            // 
            // colBatchSaveFolder
            // 
            this.colBatchSaveFolder.DataPropertyName = "SaveFolder";
            resources.ApplyResources(this.colBatchSaveFolder, "colBatchSaveFolder");
            this.colBatchSaveFolder.Name = "colBatchSaveFolder";
            this.colBatchSaveFolder.ReadOnly = true;
            // 
            // colBatchStatus
            // 
            this.colBatchStatus.DataPropertyName = "Status";
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colBatchStatus.DefaultCellStyle = dataGridViewCellStyle15;
            this.colBatchStatus.FillWeight = 300F;
            resources.ApplyResources(this.colBatchStatus, "colBatchStatus");
            this.colBatchStatus.Name = "colBatchStatus";
            this.colBatchStatus.ReadOnly = true;
            // 
            // ctxMenuBatch
            // 
            this.ctxMenuBatch.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMenuBatch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem1});
            this.ctxMenuBatch.Name = "contextMenuStrip5";
            resources.ApplyResources(this.ctxMenuBatch, "ctxMenuBatch");
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            resources.ApplyResources(this.deleteToolStripMenuItem1, "deleteToolStripMenuItem1");
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // cbxAbortOnError
            // 
            resources.ApplyResources(this.cbxAbortOnError, "cbxAbortOnError");
            this.cbxAbortOnError.Checked = global::DanbooruDownloader3.Properties.Settings.Default.batchAbortOnError;
            this.cbxAbortOnError.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "batchAbortOnError", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxAbortOnError.Name = "cbxAbortOnError";
            this.cbxAbortOnError.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.btnSaveConfig);
            this.tabPage2.Controls.Add(this.btnUpdate);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.txtFilenameHelp);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox6);
            this.groupBox5.Controls.Add(this.chkProcessDeletedPost);
            this.groupBox5.Controls.Add(this.chkHideBlaclistedImage);
            this.groupBox5.Controls.Add(this.chkUseGlobalProviderTags);
            this.groupBox5.Controls.Add(this.chkMinimizeTray);
            this.groupBox5.Controls.Add(this.chkAutoFocus);
            this.groupBox5.Controls.Add(this.chkLogging);
            this.groupBox5.Controls.Add(this.chkUseTagColor);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // checkBox6
            // 
            resources.ApplyResources(this.checkBox6, "checkBox6");
            this.checkBox6.Checked = global::DanbooruDownloader3.Properties.Settings.Default.ShutdownAfterCompleteBatchJob;
            this.checkBox6.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "ShutdownAfterCompleteBatchJob", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // chkProcessDeletedPost
            // 
            resources.ApplyResources(this.chkProcessDeletedPost, "chkProcessDeletedPost");
            this.chkProcessDeletedPost.Checked = global::DanbooruDownloader3.Properties.Settings.Default.ProcessDeletedPost;
            this.chkProcessDeletedPost.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "ProcessDeletedPost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkProcessDeletedPost.Name = "chkProcessDeletedPost";
            this.chkProcessDeletedPost.UseVisualStyleBackColor = true;
            // 
            // chkHideBlaclistedImage
            // 
            resources.ApplyResources(this.chkHideBlaclistedImage, "chkHideBlaclistedImage");
            this.chkHideBlaclistedImage.Checked = global::DanbooruDownloader3.Properties.Settings.Default.HideBlacklistedImage;
            this.chkHideBlaclistedImage.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "HideBlacklistedImage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkHideBlaclistedImage.Name = "chkHideBlaclistedImage";
            this.chkHideBlaclistedImage.UseVisualStyleBackColor = true;
            // 
            // chkUseGlobalProviderTags
            // 
            resources.ApplyResources(this.chkUseGlobalProviderTags, "chkUseGlobalProviderTags");
            this.chkUseGlobalProviderTags.Checked = global::DanbooruDownloader3.Properties.Settings.Default.UseGlobalProviderTags;
            this.chkUseGlobalProviderTags.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "UseGlobalProviderTags", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkUseGlobalProviderTags.Name = "chkUseGlobalProviderTags";
            this.chkUseGlobalProviderTags.UseVisualStyleBackColor = true;
            // 
            // chkMinimizeTray
            // 
            resources.ApplyResources(this.chkMinimizeTray, "chkMinimizeTray");
            this.chkMinimizeTray.Checked = global::DanbooruDownloader3.Properties.Settings.Default.MinimizeToTray;
            this.chkMinimizeTray.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "MinimizeToTray", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkMinimizeTray.Name = "chkMinimizeTray";
            this.chkMinimizeTray.UseVisualStyleBackColor = true;
            this.chkMinimizeTray.CheckedChanged += new System.EventHandler(this.chkMinimizeTray_CheckedChanged);
            // 
            // chkAutoFocus
            // 
            resources.ApplyResources(this.chkAutoFocus, "chkAutoFocus");
            this.chkAutoFocus.Checked = global::DanbooruDownloader3.Properties.Settings.Default.AutoFocusCurrent;
            this.chkAutoFocus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoFocus.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "AutoFocusCurrent", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAutoFocus.Name = "chkAutoFocus";
            this.chkAutoFocus.UseVisualStyleBackColor = true;
            // 
            // chkLogging
            // 
            resources.ApplyResources(this.chkLogging, "chkLogging");
            this.chkLogging.Checked = global::DanbooruDownloader3.Properties.Settings.Default.EnableLogging;
            this.chkLogging.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLogging.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "EnableLogging", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkLogging.Name = "chkLogging";
            this.chkLogging.UseVisualStyleBackColor = true;
            this.chkLogging.CheckedChanged += new System.EventHandler(this.chkLogging_CheckedChanged);
            // 
            // chkUseTagColor
            // 
            resources.ApplyResources(this.chkUseTagColor, "chkUseTagColor");
            this.chkUseTagColor.Checked = global::DanbooruDownloader3.Properties.Settings.Default.UseColoredTag;
            this.chkUseTagColor.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "UseColoredTag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkUseTagColor.Name = "chkUseTagColor";
            this.chkUseTagColor.UseVisualStyleBackColor = true;
            this.chkUseTagColor.CheckedChanged += new System.EventHandler(this.chkUseTagColor_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.checkBox3);
            this.groupBox4.Controls.Add(this.checkBox4);
            this.groupBox4.Controls.Add(this.checkBox5);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Checked = global::DanbooruDownloader3.Properties.Settings.Default.AutoLoadNextPage;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "AutoLoadNextPage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.Checked = global::DanbooruDownloader3.Properties.Settings.Default.AppendList;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "AppendList", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // checkBox3
            // 
            resources.ApplyResources(this.checkBox3, "checkBox3");
            this.checkBox3.Checked = global::DanbooruDownloader3.Properties.Settings.Default.SaveQuery;
            this.checkBox3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "SaveQuery", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            resources.ApplyResources(this.checkBox4, "checkBox4");
            this.checkBox4.Checked = global::DanbooruDownloader3.Properties.Settings.Default.AutoLoadList;
            this.checkBox4.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "AutoLoadList", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            resources.ApplyResources(this.checkBox5, "checkBox5");
            this.checkBox5.Checked = global::DanbooruDownloader3.Properties.Settings.Default.LoadPreview;
            this.checkBox5.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "LoadPreview", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNoFault);
            this.groupBox2.Controls.Add(this.txtNoCircle);
            this.groupBox2.Controls.Add(this.txtNoChara);
            this.groupBox2.Controls.Add(this.txtNoCopyright);
            this.groupBox2.Controls.Add(this.txtNoArtist);
            this.groupBox2.Controls.Add(this.label33);
            this.groupBox2.Controls.Add(this.chkIgnoreTagsUseRegex);
            this.groupBox2.Controls.Add(this.chkBlacklistTagsUseRegex);
            this.groupBox2.Controls.Add(this.cbxWriteTag);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.chkIsReplaceUnderscoreTag);
            this.groupBox2.Controls.Add(this.txtOverFault);
            this.groupBox2.Controls.Add(this.txtOverCircle);
            this.groupBox2.Controls.Add(this.txtOverChara);
            this.groupBox2.Controls.Add(this.txtOverCopyright);
            this.groupBox2.Controls.Add(this.txtOverArtist);
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.chkBlacklistOnlyGeneral);
            this.groupBox2.Controls.Add(this.chkIgnoreForGeneralTag);
            this.groupBox2.Controls.Add(this.chkReplaceMode);
            this.groupBox2.Controls.Add(this.lblColorUnknown);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.txtIgnoredTags);
            this.groupBox2.Controls.Add(this.txtAutoCompleteLimit);
            this.groupBox2.Controls.Add(this.txtCircleTagGrouping);
            this.groupBox2.Controls.Add(this.txtFaultsTagGrouping);
            this.groupBox2.Controls.Add(this.txtCharaTagGrouping);
            this.groupBox2.Controls.Add(this.txtTagReplacement);
            this.groupBox2.Controls.Add(this.txtCopyTagGrouping);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.lblColorBlacklistedTag);
            this.groupBox2.Controls.Add(this.chkTagAutoComplete);
            this.groupBox2.Controls.Add(this.lblColorFaults);
            this.groupBox2.Controls.Add(this.txtArtistTagGrouping);
            this.groupBox2.Controls.Add(this.lblColorCircle);
            this.groupBox2.Controls.Add(this.lblColorChara);
            this.groupBox2.Controls.Add(this.lblColorCopy);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.txtTagBlacklist);
            this.groupBox2.Controls.Add(this.lblColorArtist);
            this.groupBox2.Controls.Add(this.lblColorGeneral);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // txtNoFault
            // 
            this.txtNoFault.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "tagNoFaultValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtNoFault, "txtNoFault");
            this.txtNoFault.Name = "txtNoFault";
            this.txtNoFault.Text = global::DanbooruDownloader3.Properties.Settings.Default.tagNoFaultValue;
            // 
            // txtNoCircle
            // 
            this.txtNoCircle.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "tagNoCircleValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtNoCircle, "txtNoCircle");
            this.txtNoCircle.Name = "txtNoCircle";
            this.txtNoCircle.Text = global::DanbooruDownloader3.Properties.Settings.Default.tagNoCircleValue;
            // 
            // txtNoChara
            // 
            this.txtNoChara.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "tagNoCharacterValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtNoChara, "txtNoChara");
            this.txtNoChara.Name = "txtNoChara";
            this.txtNoChara.Text = global::DanbooruDownloader3.Properties.Settings.Default.tagNoCharacterValue;
            // 
            // txtNoCopyright
            // 
            this.txtNoCopyright.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "tagNoCopyrightValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtNoCopyright, "txtNoCopyright");
            this.txtNoCopyright.Name = "txtNoCopyright";
            this.txtNoCopyright.Text = global::DanbooruDownloader3.Properties.Settings.Default.tagNoCopyrightValue;
            // 
            // txtNoArtist
            // 
            this.txtNoArtist.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "tagNoArtistValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtNoArtist, "txtNoArtist");
            this.txtNoArtist.Name = "txtNoArtist";
            this.txtNoArtist.Text = global::DanbooruDownloader3.Properties.Settings.Default.tagNoArtistValue;
            // 
            // label33
            // 
            resources.ApplyResources(this.label33, "label33");
            this.label33.Name = "label33";
            // 
            // chkIgnoreTagsUseRegex
            // 
            resources.ApplyResources(this.chkIgnoreTagsUseRegex, "chkIgnoreTagsUseRegex");
            this.chkIgnoreTagsUseRegex.Checked = global::DanbooruDownloader3.Properties.Settings.Default.IgnoreTagsUseRegex;
            this.chkIgnoreTagsUseRegex.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "IgnoreTagsUseRegex", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkIgnoreTagsUseRegex.Name = "chkIgnoreTagsUseRegex";
            this.chkIgnoreTagsUseRegex.UseVisualStyleBackColor = true;
            // 
            // chkBlacklistTagsUseRegex
            // 
            resources.ApplyResources(this.chkBlacklistTagsUseRegex, "chkBlacklistTagsUseRegex");
            this.chkBlacklistTagsUseRegex.Checked = global::DanbooruDownloader3.Properties.Settings.Default.BlacklistTagsUseRegex;
            this.chkBlacklistTagsUseRegex.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "BlacklistTagsUseRegex", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkBlacklistTagsUseRegex.Name = "chkBlacklistTagsUseRegex";
            this.chkBlacklistTagsUseRegex.UseVisualStyleBackColor = true;
            // 
            // cbxWriteTag
            // 
            resources.ApplyResources(this.cbxWriteTag, "cbxWriteTag");
            this.cbxWriteTag.Checked = global::DanbooruDownloader3.Properties.Settings.Default.WriteTagFile;
            this.cbxWriteTag.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "WriteTagFile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxWriteTag.Name = "cbxWriteTag";
            this.cbxWriteTag.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            resources.ApplyResources(this.label31, "label31");
            this.label31.Name = "label31";
            // 
            // chkIsReplaceUnderscoreTag
            // 
            resources.ApplyResources(this.chkIsReplaceUnderscoreTag, "chkIsReplaceUnderscoreTag");
            this.chkIsReplaceUnderscoreTag.Checked = global::DanbooruDownloader3.Properties.Settings.Default.IsReplaceUnderscoreTag;
            this.chkIsReplaceUnderscoreTag.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "IsReplaceUnderscoreTag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkIsReplaceUnderscoreTag.Name = "chkIsReplaceUnderscoreTag";
            this.chkIsReplaceUnderscoreTag.UseVisualStyleBackColor = true;
            // 
            // txtOverFault
            // 
            this.txtOverFault.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "tagOverFaultValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtOverFault, "txtOverFault");
            this.txtOverFault.Name = "txtOverFault";
            this.txtOverFault.Text = global::DanbooruDownloader3.Properties.Settings.Default.tagOverFaultValue;
            // 
            // txtOverCircle
            // 
            this.txtOverCircle.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "tagOverCircleValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtOverCircle, "txtOverCircle");
            this.txtOverCircle.Name = "txtOverCircle";
            this.txtOverCircle.Text = global::DanbooruDownloader3.Properties.Settings.Default.tagOverCircleValue;
            // 
            // txtOverChara
            // 
            this.txtOverChara.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "tagOverCharaValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtOverChara, "txtOverChara");
            this.txtOverChara.Name = "txtOverChara";
            this.txtOverChara.Text = global::DanbooruDownloader3.Properties.Settings.Default.tagOverCharaValue;
            // 
            // txtOverCopyright
            // 
            this.txtOverCopyright.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "tagOverCopyrightValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtOverCopyright, "txtOverCopyright");
            this.txtOverCopyright.Name = "txtOverCopyright";
            this.txtOverCopyright.Text = global::DanbooruDownloader3.Properties.Settings.Default.tagOverCopyrightValue;
            // 
            // txtOverArtist
            // 
            this.txtOverArtist.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "tagOverArtistValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtOverArtist, "txtOverArtist");
            this.txtOverArtist.Name = "txtOverArtist";
            this.txtOverArtist.Text = global::DanbooruDownloader3.Properties.Settings.Default.tagOverArtistValue;
            // 
            // label30
            // 
            resources.ApplyResources(this.label30, "label30");
            this.label30.Name = "label30";
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            // 
            // chkBlacklistOnlyGeneral
            // 
            resources.ApplyResources(this.chkBlacklistOnlyGeneral, "chkBlacklistOnlyGeneral");
            this.chkBlacklistOnlyGeneral.Checked = global::DanbooruDownloader3.Properties.Settings.Default.IsBlacklistOnlyForGeneralTags;
            this.chkBlacklistOnlyGeneral.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "IsBlacklistOnlyForGeneralTags", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkBlacklistOnlyGeneral.Name = "chkBlacklistOnlyGeneral";
            this.chkBlacklistOnlyGeneral.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreForGeneralTag
            // 
            resources.ApplyResources(this.chkIgnoreForGeneralTag, "chkIgnoreForGeneralTag");
            this.chkIgnoreForGeneralTag.Checked = global::DanbooruDownloader3.Properties.Settings.Default.IsIgnoreForGeneralTagOnly;
            this.chkIgnoreForGeneralTag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIgnoreForGeneralTag.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "IsIgnoreForGeneralTagOnly", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkIgnoreForGeneralTag.Name = "chkIgnoreForGeneralTag";
            this.chkIgnoreForGeneralTag.UseVisualStyleBackColor = true;
            // 
            // chkReplaceMode
            // 
            resources.ApplyResources(this.chkReplaceMode, "chkReplaceMode");
            this.chkReplaceMode.Checked = global::DanbooruDownloader3.Properties.Settings.Default.isReplaceMode;
            this.chkReplaceMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReplaceMode.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "isReplaceMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkReplaceMode.Name = "chkReplaceMode";
            this.chkReplaceMode.UseVisualStyleBackColor = true;
            // 
            // lblColorUnknown
            // 
            resources.ApplyResources(this.lblColorUnknown, "lblColorUnknown");
            this.lblColorUnknown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblColorUnknown.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DanbooruDownloader3.Properties.Settings.Default, "ColorUnknown", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblColorUnknown.ForeColor = global::DanbooruDownloader3.Properties.Settings.Default.ColorUnknown;
            this.lblColorUnknown.Name = "lblColorUnknown";
            this.lblColorUnknown.DoubleClick += new System.EventHandler(this.lblColorUnknown_DoubleClick);
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // txtIgnoredTags
            // 
            this.txtIgnoredTags.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "TagIgnored", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtIgnoredTags, "txtIgnoredTags");
            this.txtIgnoredTags.Name = "txtIgnoredTags";
            this.txtIgnoredTags.Text = global::DanbooruDownloader3.Properties.Settings.Default.TagIgnored;
            this.txtIgnoredTags.TextChanged += new System.EventHandler(this.txtIgnoredTags_TextChanged);
            // 
            // txtAutoCompleteLimit
            // 
            this.txtAutoCompleteLimit.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "AutoCompleteLimit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtAutoCompleteLimit, "txtAutoCompleteLimit");
            this.txtAutoCompleteLimit.Name = "txtAutoCompleteLimit";
            this.txtAutoCompleteLimit.Text = global::DanbooruDownloader3.Properties.Settings.Default.AutoCompleteLimit;
            // 
            // txtCircleTagGrouping
            // 
            this.txtCircleTagGrouping.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "TagCircleGrouping", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtCircleTagGrouping, "txtCircleTagGrouping");
            this.txtCircleTagGrouping.Name = "txtCircleTagGrouping";
            this.txtCircleTagGrouping.Text = global::DanbooruDownloader3.Properties.Settings.Default.TagCircleGrouping;
            this.txtCircleTagGrouping.TextChanged += new System.EventHandler(this.txtCircleTagGrouping_TextChanged);
            // 
            // txtFaultsTagGrouping
            // 
            this.txtFaultsTagGrouping.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "TagFaultsGrouping", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtFaultsTagGrouping, "txtFaultsTagGrouping");
            this.txtFaultsTagGrouping.Name = "txtFaultsTagGrouping";
            this.txtFaultsTagGrouping.Text = global::DanbooruDownloader3.Properties.Settings.Default.TagFaultsGrouping;
            this.txtFaultsTagGrouping.TextChanged += new System.EventHandler(this.txtFaultsTagGrouping_TextChanged);
            // 
            // txtCharaTagGrouping
            // 
            this.txtCharaTagGrouping.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "TagCharacterGrouping", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtCharaTagGrouping, "txtCharaTagGrouping");
            this.txtCharaTagGrouping.Name = "txtCharaTagGrouping";
            this.txtCharaTagGrouping.Text = global::DanbooruDownloader3.Properties.Settings.Default.TagCharacterGrouping;
            this.txtCharaTagGrouping.TextChanged += new System.EventHandler(this.txtCharaTagGrouping_TextChanged);
            // 
            // txtTagReplacement
            // 
            this.txtTagReplacement.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "EmptyTagReplacement", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtTagReplacement, "txtTagReplacement");
            this.txtTagReplacement.Name = "txtTagReplacement";
            this.txtTagReplacement.Text = global::DanbooruDownloader3.Properties.Settings.Default.EmptyTagReplacement;
            // 
            // txtCopyTagGrouping
            // 
            this.txtCopyTagGrouping.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "TagCopyrigthGrouping", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtCopyTagGrouping, "txtCopyTagGrouping");
            this.txtCopyTagGrouping.Name = "txtCopyTagGrouping";
            this.txtCopyTagGrouping.Text = global::DanbooruDownloader3.Properties.Settings.Default.TagCopyrigthGrouping;
            this.txtCopyTagGrouping.TextChanged += new System.EventHandler(this.txtCopyTagGrouping_TextChanged);
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // lblColorBlacklistedTag
            // 
            resources.ApplyResources(this.lblColorBlacklistedTag, "lblColorBlacklistedTag");
            this.lblColorBlacklistedTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblColorBlacklistedTag.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DanbooruDownloader3.Properties.Settings.Default, "ColorBlacklistedTag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblColorBlacklistedTag.ForeColor = global::DanbooruDownloader3.Properties.Settings.Default.ColorBlacklistedTag;
            this.lblColorBlacklistedTag.Name = "lblColorBlacklistedTag";
            this.lblColorBlacklistedTag.DoubleClick += new System.EventHandler(this.lblColorBlacklistedTag_DoubleClick);
            // 
            // chkTagAutoComplete
            // 
            resources.ApplyResources(this.chkTagAutoComplete, "chkTagAutoComplete");
            this.chkTagAutoComplete.Checked = global::DanbooruDownloader3.Properties.Settings.Default.TagAutoComplete;
            this.chkTagAutoComplete.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "TagAutoComplete", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkTagAutoComplete.Name = "chkTagAutoComplete";
            this.chkTagAutoComplete.UseVisualStyleBackColor = true;
            // 
            // lblColorFaults
            // 
            resources.ApplyResources(this.lblColorFaults, "lblColorFaults");
            this.lblColorFaults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblColorFaults.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DanbooruDownloader3.Properties.Settings.Default, "ColorFaults", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblColorFaults.ForeColor = global::DanbooruDownloader3.Properties.Settings.Default.ColorFaults;
            this.lblColorFaults.Name = "lblColorFaults";
            this.lblColorFaults.DoubleClick += new System.EventHandler(this.lblColorFaults_DoubleClick);
            // 
            // txtArtistTagGrouping
            // 
            this.txtArtistTagGrouping.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "TagGroupingLimit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtArtistTagGrouping, "txtArtistTagGrouping");
            this.txtArtistTagGrouping.Name = "txtArtistTagGrouping";
            this.txtArtistTagGrouping.Text = global::DanbooruDownloader3.Properties.Settings.Default.TagGroupingLimit;
            this.txtArtistTagGrouping.TextChanged += new System.EventHandler(this.txtArtistTagGrouping_TextChanged);
            // 
            // lblColorCircle
            // 
            resources.ApplyResources(this.lblColorCircle, "lblColorCircle");
            this.lblColorCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblColorCircle.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DanbooruDownloader3.Properties.Settings.Default, "ColorCircle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblColorCircle.ForeColor = global::DanbooruDownloader3.Properties.Settings.Default.ColorCircle;
            this.lblColorCircle.Name = "lblColorCircle";
            this.lblColorCircle.DoubleClick += new System.EventHandler(this.lblColorCircle_DoubleClick);
            // 
            // lblColorChara
            // 
            resources.ApplyResources(this.lblColorChara, "lblColorChara");
            this.lblColorChara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblColorChara.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DanbooruDownloader3.Properties.Settings.Default, "ColorCharacter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblColorChara.ForeColor = global::DanbooruDownloader3.Properties.Settings.Default.ColorCharacter;
            this.lblColorChara.Name = "lblColorChara";
            this.lblColorChara.DoubleClick += new System.EventHandler(this.lblColorChara_DoubleClick);
            // 
            // lblColorCopy
            // 
            resources.ApplyResources(this.lblColorCopy, "lblColorCopy");
            this.lblColorCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblColorCopy.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DanbooruDownloader3.Properties.Settings.Default, "ColorCopyright", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblColorCopy.ForeColor = global::DanbooruDownloader3.Properties.Settings.Default.ColorCopyright;
            this.lblColorCopy.Name = "lblColorCopy";
            this.lblColorCopy.DoubleClick += new System.EventHandler(this.lblColorCopy_DoubleClick);
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            // 
            // txtTagBlacklist
            // 
            this.txtTagBlacklist.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "TagBlacklist", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtTagBlacklist, "txtTagBlacklist");
            this.txtTagBlacklist.Name = "txtTagBlacklist";
            this.txtTagBlacklist.Text = global::DanbooruDownloader3.Properties.Settings.Default.TagBlacklist;
            this.txtTagBlacklist.TextChanged += new System.EventHandler(this.txtTagBlacklist_TextChanged);
            // 
            // lblColorArtist
            // 
            resources.ApplyResources(this.lblColorArtist, "lblColorArtist");
            this.lblColorArtist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblColorArtist.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DanbooruDownloader3.Properties.Settings.Default, "ColorArtist", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblColorArtist.ForeColor = global::DanbooruDownloader3.Properties.Settings.Default.ColorArtist;
            this.lblColorArtist.Name = "lblColorArtist";
            this.lblColorArtist.DoubleClick += new System.EventHandler(this.lblColorArtist_DoubleClick);
            // 
            // lblColorGeneral
            // 
            resources.ApplyResources(this.lblColorGeneral, "lblColorGeneral");
            this.lblColorGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblColorGeneral.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DanbooruDownloader3.Properties.Settings.Default, "ColorGeneral", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblColorGeneral.ForeColor = global::DanbooruDownloader3.Properties.Settings.Default.ColorGeneral;
            this.lblColorGeneral.Name = "lblColorGeneral";
            this.lblColorGeneral.DoubleClick += new System.EventHandler(this.lblColorGeneral_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDateTimeFormat);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.chkWriteDownloadedFileTxt);
            this.groupBox3.Controls.Add(this.chkDelayIncludeSkip);
            this.groupBox3.Controls.Add(this.txtBatchJobDelay);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.chkSaveFolderWhenExit);
            this.groupBox3.Controls.Add(this.btnBrowseDefaultSave);
            this.groupBox3.Controls.Add(this.txtDefaultSaveFolder);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.cbxImageSize);
            this.groupBox3.Controls.Add(this.chkRenameJpeg);
            this.groupBox3.Controls.Add(this.txtFilenameLength);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.chkOverwrite);
            this.groupBox3.Controls.Add(this.txtFilenameFormat);
            this.groupBox3.Controls.Add(this.label13);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // txtDateTimeFormat
            // 
            this.txtDateTimeFormat.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "DateTimeFormat", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtDateTimeFormat, "txtDateTimeFormat");
            this.txtDateTimeFormat.Name = "txtDateTimeFormat";
            this.txtDateTimeFormat.Text = global::DanbooruDownloader3.Properties.Settings.Default.DateTimeFormat;
            // 
            // label32
            // 
            resources.ApplyResources(this.label32, "label32");
            this.label32.Name = "label32";
            // 
            // chkWriteDownloadedFileTxt
            // 
            resources.ApplyResources(this.chkWriteDownloadedFileTxt, "chkWriteDownloadedFileTxt");
            this.chkWriteDownloadedFileTxt.Checked = global::DanbooruDownloader3.Properties.Settings.Default.WriteDownloadedFile;
            this.chkWriteDownloadedFileTxt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWriteDownloadedFileTxt.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "WriteDownloadedFile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkWriteDownloadedFileTxt.Name = "chkWriteDownloadedFileTxt";
            this.chkWriteDownloadedFileTxt.UseVisualStyleBackColor = true;
            // 
            // chkDelayIncludeSkip
            // 
            resources.ApplyResources(this.chkDelayIncludeSkip, "chkDelayIncludeSkip");
            this.chkDelayIncludeSkip.Checked = global::DanbooruDownloader3.Properties.Settings.Default.DelayIncludeSkipped;
            this.chkDelayIncludeSkip.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "DelayIncludeSkipped", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkDelayIncludeSkip.Name = "chkDelayIncludeSkip";
            this.chkDelayIncludeSkip.UseVisualStyleBackColor = true;
            // 
            // txtBatchJobDelay
            // 
            this.txtBatchJobDelay.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "BatchJobDelay", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtBatchJobDelay, "txtBatchJobDelay");
            this.txtBatchJobDelay.Name = "txtBatchJobDelay";
            this.txtBatchJobDelay.Text = global::DanbooruDownloader3.Properties.Settings.Default.BatchJobDelay;
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            // 
            // chkSaveFolderWhenExit
            // 
            resources.ApplyResources(this.chkSaveFolderWhenExit, "chkSaveFolderWhenExit");
            this.chkSaveFolderWhenExit.Checked = global::DanbooruDownloader3.Properties.Settings.Default.SaveFolderWhenExit;
            this.chkSaveFolderWhenExit.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "SaveFolderWhenExit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkSaveFolderWhenExit.Name = "chkSaveFolderWhenExit";
            this.chkSaveFolderWhenExit.UseVisualStyleBackColor = true;
            // 
            // btnBrowseDefaultSave
            // 
            resources.ApplyResources(this.btnBrowseDefaultSave, "btnBrowseDefaultSave");
            this.btnBrowseDefaultSave.Name = "btnBrowseDefaultSave";
            this.btnBrowseDefaultSave.UseVisualStyleBackColor = true;
            this.btnBrowseDefaultSave.Click += new System.EventHandler(this.btnBrowseDefaultSave_Click);
            // 
            // txtDefaultSaveFolder
            // 
            resources.ApplyResources(this.txtDefaultSaveFolder, "txtDefaultSaveFolder");
            this.txtDefaultSaveFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "SaveFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDefaultSaveFolder.Name = "txtDefaultSaveFolder";
            this.txtDefaultSaveFolder.Text = global::DanbooruDownloader3.Properties.Settings.Default.SaveFolder;
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // cbxImageSize
            // 
            this.cbxImageSize.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "ImageSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxImageSize.FormattingEnabled = true;
            this.cbxImageSize.Items.AddRange(new object[] {
            resources.GetString("cbxImageSize.Items"),
            resources.GetString("cbxImageSize.Items1"),
            resources.GetString("cbxImageSize.Items2"),
            resources.GetString("cbxImageSize.Items3")});
            resources.ApplyResources(this.cbxImageSize, "cbxImageSize");
            this.cbxImageSize.Name = "cbxImageSize";
            this.cbxImageSize.Text = global::DanbooruDownloader3.Properties.Settings.Default.ImageSize;
            this.cbxImageSize.TextChanged += new System.EventHandler(this.cbxImageSize_TextChanged);
            // 
            // chkRenameJpeg
            // 
            resources.ApplyResources(this.chkRenameJpeg, "chkRenameJpeg");
            this.chkRenameJpeg.Checked = global::DanbooruDownloader3.Properties.Settings.Default.RenameJpeg;
            this.chkRenameJpeg.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "RenameJpeg", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkRenameJpeg.Name = "chkRenameJpeg";
            this.chkRenameJpeg.UseVisualStyleBackColor = true;
            // 
            // txtFilenameLength
            // 
            this.txtFilenameLength.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "filenameLengthLimit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtFilenameLength, "txtFilenameLength");
            this.txtFilenameLength.Name = "txtFilenameLength";
            this.txtFilenameLength.Text = global::DanbooruDownloader3.Properties.Settings.Default.filenameLengthLimit;
            this.txtFilenameLength.TextChanged += new System.EventHandler(this.txtFilenameLength_TextChanged);
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // chkOverwrite
            // 
            resources.ApplyResources(this.chkOverwrite, "chkOverwrite");
            this.chkOverwrite.Checked = global::DanbooruDownloader3.Properties.Settings.Default.overwrite;
            this.chkOverwrite.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "overwrite", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkOverwrite.Name = "chkOverwrite";
            this.chkOverwrite.UseVisualStyleBackColor = true;
            // 
            // txtFilenameFormat
            // 
            this.txtFilenameFormat.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "filenameFormat", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtFilenameFormat, "txtFilenameFormat");
            this.txtFilenameFormat.Name = "txtFilenameFormat";
            this.txtFilenameFormat.Text = global::DanbooruDownloader3.Properties.Settings.Default.filenameFormat;
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // btnSaveConfig
            // 
            resources.ApplyResources(this.btnSaveConfig, "btnSaveConfig");
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // btnUpdate
            // 
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkEnableCompression);
            this.groupBox1.Controls.Add(this.txtAcceptLanguage);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.chkEnableCookie);
            this.groupBox1.Controls.Add(this.btnCookie);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.txtDelay);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.linkUrl);
            this.groupBox1.Controls.Add(this.chkProxyLogin);
            this.groupBox1.Controls.Add(this.txtProxyPassword);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtProxyUsername);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.chkPadUserAgent);
            this.groupBox1.Controls.Add(this.txtRetry);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtTimeout);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtUserAgent);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.chkUseProxy);
            this.groupBox1.Controls.Add(this.txtProxyPort);
            this.groupBox1.Controls.Add(this.txtProxyAddress);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // chkEnableCompression
            // 
            resources.ApplyResources(this.chkEnableCompression, "chkEnableCompression");
            this.chkEnableCompression.Checked = global::DanbooruDownloader3.Properties.Settings.Default.EnableCompression;
            this.chkEnableCompression.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableCompression.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "EnableCompression", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkEnableCompression.Name = "chkEnableCompression";
            this.chkEnableCompression.UseVisualStyleBackColor = true;
            this.chkEnableCompression.CheckedChanged += new System.EventHandler(this.chkEnableCompression_CheckedChanged);
            // 
            // txtAcceptLanguage
            // 
            this.txtAcceptLanguage.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "AcceptLanguage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtAcceptLanguage, "txtAcceptLanguage");
            this.txtAcceptLanguage.Name = "txtAcceptLanguage";
            this.txtAcceptLanguage.Text = global::DanbooruDownloader3.Properties.Settings.Default.AcceptLanguage;
            this.txtAcceptLanguage.TextChanged += new System.EventHandler(this.txtAcceptLanguage_TextChanged);
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            // 
            // chkEnableCookie
            // 
            resources.ApplyResources(this.chkEnableCookie, "chkEnableCookie");
            this.chkEnableCookie.Checked = global::DanbooruDownloader3.Properties.Settings.Default.enableCookie;
            this.chkEnableCookie.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableCookie.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "enableCookie", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkEnableCookie.Name = "chkEnableCookie";
            this.chkEnableCookie.UseVisualStyleBackColor = true;
            this.chkEnableCookie.CheckedChanged += new System.EventHandler(this.chkEnableCookie_CheckedChanged);
            // 
            // btnCookie
            // 
            resources.ApplyResources(this.btnCookie, "btnCookie");
            this.btnCookie.Name = "btnCookie";
            this.btnCookie.UseVisualStyleBackColor = true;
            this.btnCookie.Click += new System.EventHandler(this.btnCookie_Click);
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // txtDelay
            // 
            this.txtDelay.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "delay", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtDelay, "txtDelay");
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Text = global::DanbooruDownloader3.Properties.Settings.Default.delay;
            this.txtDelay.TextChanged += new System.EventHandler(this.txtDelay_TextChanged);
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // linkUrl
            // 
            resources.ApplyResources(this.linkUrl, "linkUrl");
            this.linkUrl.Name = "linkUrl";
            this.linkUrl.TabStop = true;
            this.linkUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUrl_LinkClicked);
            // 
            // chkProxyLogin
            // 
            resources.ApplyResources(this.chkProxyLogin, "chkProxyLogin");
            this.chkProxyLogin.Checked = global::DanbooruDownloader3.Properties.Settings.Default.UseProxyLogin;
            this.chkProxyLogin.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "UseProxyLogin", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkProxyLogin.Name = "chkProxyLogin";
            this.chkProxyLogin.UseVisualStyleBackColor = true;
            this.chkProxyLogin.CheckedChanged += new System.EventHandler(this.chkProxyLogin_CheckedChanged);
            // 
            // txtProxyPassword
            // 
            this.txtProxyPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "ProxyPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtProxyPassword, "txtProxyPassword");
            this.txtProxyPassword.Name = "txtProxyPassword";
            this.txtProxyPassword.Text = global::DanbooruDownloader3.Properties.Settings.Default.ProxyPassword;
            this.txtProxyPassword.UseSystemPasswordChar = true;
            this.txtProxyPassword.TextChanged += new System.EventHandler(this.txtProxyPassword_TextChanged);
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // txtProxyUsername
            // 
            this.txtProxyUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "ProxyUsername", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtProxyUsername, "txtProxyUsername");
            this.txtProxyUsername.Name = "txtProxyUsername";
            this.txtProxyUsername.Text = global::DanbooruDownloader3.Properties.Settings.Default.ProxyUsername;
            this.txtProxyUsername.TextChanged += new System.EventHandler(this.txtProxyUsername_TextChanged);
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // chkPadUserAgent
            // 
            resources.ApplyResources(this.chkPadUserAgent, "chkPadUserAgent");
            this.chkPadUserAgent.Checked = global::DanbooruDownloader3.Properties.Settings.Default.PadUserAgent;
            this.chkPadUserAgent.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "PadUserAgent", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkPadUserAgent.Name = "chkPadUserAgent";
            this.chkPadUserAgent.UseVisualStyleBackColor = true;
            // 
            // txtRetry
            // 
            this.txtRetry.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "retry", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtRetry, "txtRetry");
            this.txtRetry.Name = "txtRetry";
            this.txtRetry.Text = global::DanbooruDownloader3.Properties.Settings.Default.retry;
            this.txtRetry.TextChanged += new System.EventHandler(this.txtRetry_TextChanged);
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // txtTimeout
            // 
            this.txtTimeout.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "Timeout", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtTimeout, "txtTimeout");
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Text = global::DanbooruDownloader3.Properties.Settings.Default.Timeout;
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // txtUserAgent
            // 
            this.txtUserAgent.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "UserAgent", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtUserAgent, "txtUserAgent");
            this.txtUserAgent.Name = "txtUserAgent";
            this.txtUserAgent.Text = global::DanbooruDownloader3.Properties.Settings.Default.UserAgent;
            this.txtUserAgent.TextChanged += new System.EventHandler(this.txtUserAgent_TextChanged);
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // chkUseProxy
            // 
            resources.ApplyResources(this.chkUseProxy, "chkUseProxy");
            this.chkUseProxy.Checked = global::DanbooruDownloader3.Properties.Settings.Default.UseProxy;
            this.chkUseProxy.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DanbooruDownloader3.Properties.Settings.Default, "UseProxy", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkUseProxy.Name = "chkUseProxy";
            this.chkUseProxy.UseVisualStyleBackColor = true;
            this.chkUseProxy.CheckedChanged += new System.EventHandler(this.chkUseProxy_CheckedChanged);
            // 
            // txtProxyPort
            // 
            this.txtProxyPort.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "ProxyPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtProxyPort, "txtProxyPort");
            this.txtProxyPort.Name = "txtProxyPort";
            this.txtProxyPort.Text = global::DanbooruDownloader3.Properties.Settings.Default.ProxyPort;
            this.txtProxyPort.TextChanged += new System.EventHandler(this.txtProxyPort_TextChanged);
            // 
            // txtProxyAddress
            // 
            this.txtProxyAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DanbooruDownloader3.Properties.Settings.Default, "ProxyAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtProxyAddress, "txtProxyAddress");
            this.txtProxyAddress.Name = "txtProxyAddress";
            this.txtProxyAddress.Text = global::DanbooruDownloader3.Properties.Settings.Default.ProxyAddress;
            this.txtProxyAddress.TextChanged += new System.EventHandler(this.txtProxyAddress_TextChanged);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // txtFilenameHelp
            // 
            resources.ApplyResources(this.txtFilenameHelp, "txtFilenameHelp");
            this.txtFilenameHelp.Name = "txtFilenameHelp";
            this.txtFilenameHelp.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtLog);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.ContextMenuStrip = this.ctxMenuLog;
            resources.ApplyResources(this.txtLog, "txtLog");
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            // 
            // ctxMenuLog
            // 
            this.ctxMenuLog.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMenuLog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.clearLogToolStripMenuItem});
            this.ctxMenuLog.Name = "contextMenuStrip2";
            resources.ApplyResources(this.ctxMenuLog, "ctxMenuLog");
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            resources.ApplyResources(this.copyToolStripMenuItem, "copyToolStripMenuItem");
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // clearLogToolStripMenuItem
            // 
            this.clearLogToolStripMenuItem.Name = "clearLogToolStripMenuItem";
            resources.ApplyResources(this.clearLogToolStripMenuItem, "clearLogToolStripMenuItem");
            this.clearLogToolStripMenuItem.Click += new System.EventHandler(this.clearLogToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // timGifAnimation
            // 
            this.timGifAnimation.Tick += new System.EventHandler(this.timGifAnimation_Tick);
            // 
            // timLoadNextPage
            // 
            this.timLoadNextPage.Interval = 500;
            this.timLoadNextPage.Tick += new System.EventHandler(this.timLoadNextPage_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatus,
            this.tsCount,
            this.tsTotalCount,
            this.tsProgressBar,
            this.tsProgress2});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // tsStatus
            // 
            this.tsStatus.Name = "tsStatus";
            resources.ApplyResources(this.tsStatus, "tsStatus");
            // 
            // tsCount
            // 
            this.tsCount.Name = "tsCount";
            resources.ApplyResources(this.tsCount, "tsCount");
            // 
            // tsTotalCount
            // 
            this.tsTotalCount.Name = "tsTotalCount";
            resources.ApplyResources(this.tsTotalCount, "tsTotalCount");
            // 
            // tsProgressBar
            // 
            this.tsProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsProgressBar.Name = "tsProgressBar";
            resources.ApplyResources(this.tsProgressBar, "tsProgressBar");
            // 
            // tsProgress2
            // 
            this.tsProgress2.Name = "tsProgress2";
            resources.ApplyResources(this.tsProgress2, "tsProgress2");
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.DefaultExt = "xml";
            resources.ApplyResources(this.openFileDialog2, "openFileDialog2");
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.DefaultExt = "xml";
            resources.ApplyResources(this.saveFileDialog2, "saveFileDialog2");
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.ctxMenuSysTray;
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // ctxMenuSysTray
            // 
            this.ctxMenuSysTray.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMenuSysTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.toolStripMenuItem2});
            this.ctxMenuSysTray.Name = "contextMenuStrip4";
            resources.ApplyResources(this.ctxMenuSysTray, "ctxMenuSysTray");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.DataPropertyName = "ThumbnailImage";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewImageColumn1.FillWeight = 150F;
            this.dataGridViewImageColumn1.Frozen = true;
            resources.ApplyResources(this.dataGridViewImageColumn1, "dataGridViewImageColumn1");
            this.dataGridViewImageColumn1.Image = global::DanbooruDownloader3.Properties.Resources.AJAX_LOADING;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.DataPropertyName = "ThumbnailImage";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewImageColumn2.FillWeight = 150F;
            this.dataGridViewImageColumn2.Frozen = true;
            resources.ApplyResources(this.dataGridViewImageColumn2, "dataGridViewImageColumn2");
            this.dataGridViewImageColumn2.Image = global::DanbooruDownloader3.Properties.Resources.NOT_AVAILABLE;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.FillWeight = 35F;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "provider";
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn3.FillWeight = 75F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Rating";
            this.dataGridViewTextBoxColumn4.FillWeight = 25F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Tags";
            this.dataGridViewTextBoxColumn5.FillWeight = 300F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // tagsColumn1
            // 
            this.tagsColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tagsColumn1.DataPropertyName = "TagsEntity";
            this.tagsColumn1.FillWeight = 300F;
            resources.ApplyResources(this.tagsColumn1, "tagsColumn1");
            this.tagsColumn1.Name = "tagsColumn1";
            this.tagsColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tagsColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MD5";
            resources.ApplyResources(this.dataGridViewTextBoxColumn6, "dataGridViewTextBoxColumn6");
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Query";
            resources.ApplyResources(this.dataGridViewTextBoxColumn7, "dataGridViewTextBoxColumn7");
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn8.FillWeight = 35F;
            this.dataGridViewTextBoxColumn8.Frozen = true;
            resources.ApplyResources(this.dataGridViewTextBoxColumn8, "dataGridViewTextBoxColumn8");
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn9.FillWeight = 200F;
            this.dataGridViewTextBoxColumn9.Frozen = true;
            resources.ApplyResources(this.dataGridViewTextBoxColumn9, "dataGridViewTextBoxColumn9");
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "provider";
            this.dataGridViewTextBoxColumn10.Frozen = true;
            resources.ApplyResources(this.dataGridViewTextBoxColumn10, "dataGridViewTextBoxColumn10");
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn11.FillWeight = 75F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn11, "dataGridViewTextBoxColumn11");
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Rating";
            this.dataGridViewTextBoxColumn12.FillWeight = 25F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn12, "dataGridViewTextBoxColumn12");
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Tags";
            this.dataGridViewTextBoxColumn13.FillWeight = 300F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn13, "dataGridViewTextBoxColumn13");
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "MD5";
            resources.ApplyResources(this.dataGridViewTextBoxColumn14, "dataGridViewTextBoxColumn14");
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Query";
            resources.ApplyResources(this.dataGridViewTextBoxColumn15, "dataGridViewTextBoxColumn15");
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Filename";
            this.dataGridViewTextBoxColumn16.FillWeight = 25F;
            this.dataGridViewTextBoxColumn16.Frozen = true;
            resources.ApplyResources(this.dataGridViewTextBoxColumn16, "dataGridViewTextBoxColumn16");
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "SearchTags";
            this.dataGridViewTextBoxColumn17.FillWeight = 25F;
            this.dataGridViewTextBoxColumn17.Frozen = true;
            resources.ApplyResources(this.dataGridViewTextBoxColumn17, "dataGridViewTextBoxColumn17");
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Limit";
            this.dataGridViewTextBoxColumn18.FillWeight = 25F;
            this.dataGridViewTextBoxColumn18.Frozen = true;
            resources.ApplyResources(this.dataGridViewTextBoxColumn18, "dataGridViewTextBoxColumn18");
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "ProviderName";
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn19.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewTextBoxColumn19.FillWeight = 150F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn19, "dataGridViewTextBoxColumn19");
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "SaveFolder";
            this.dataGridViewTextBoxColumn20.FillWeight = 75F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn20, "dataGridViewTextBoxColumn20");
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Status";
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn21.DefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewTextBoxColumn21.FillWeight = 300F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn21, "dataGridViewTextBoxColumn21");
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "ProviderName";
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn22.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridViewTextBoxColumn22.FillWeight = 150F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn22, "dataGridViewTextBoxColumn22");
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "SaveFolder";
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn23.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridViewTextBoxColumn23.FillWeight = 150F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn23, "dataGridViewTextBoxColumn23");
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Status";
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn24.DefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewTextBoxColumn24.FillWeight = 300F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn24, "dataGridViewTextBoxColumn24");
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Status";
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn25.DefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridViewTextBoxColumn25.FillWeight = 300F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn25, "dataGridViewTextBoxColumn25");
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // tagsColumn2
            // 
            this.tagsColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tagsColumn2.DataPropertyName = "TagsEntity";
            this.tagsColumn2.FillWeight = 300F;
            resources.ApplyResources(this.tagsColumn2, "tagsColumn2");
            this.tagsColumn2.Name = "tagsColumn2";
            this.tagsColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tagsColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.gbxDanbooru.ResumeLayout(false);
            this.gbxDanbooru.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.gbxList.ResumeLayout(false);
            this.gbxList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ctxMenuList.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDownload)).EndInit();
            this.ctxMenuDownload.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchJob)).EndInit();
            this.ctxMenuBatch.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ctxMenuLog.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ctxMenuSysTray.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxProvider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.CheckBox chkGenerate;
        private System.Windows.Forms.CheckBox chkNotRating;
        private System.Windows.Forms.ComboBox cbxRating;
        private System.Windows.Forms.ComboBox cbxOrder;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTags;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox gbxList;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnBrowseListFile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtListFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkUseProxy;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtProxyPort;
        private System.Windows.Forms.TextBox txtProxyAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAddDownload;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtFilenameFormat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFilenameHelp;
        private System.Windows.Forms.CheckBox chkOverwrite;
        private System.Windows.Forms.TextBox txtFilenameLength;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Timer timGifAnimation;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Timer timLoadNextPage;
        private System.Windows.Forms.TextBox txtUserAgent;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox chkAutoFocus;
        private System.Windows.Forms.Button btnListCancel;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsCount;
        private System.Windows.Forms.ToolStripStatusLabel tsTotalCount;
        private System.Windows.Forms.ToolStripProgressBar tsProgressBar;
        private System.Windows.Forms.Button btnClearDownloadList;
        private System.Windows.Forms.Button btnPauseDownload;
        private System.Windows.Forms.Button btnDownloadFiles;
        private System.Windows.Forms.Button btnCancelDownload;
        private System.Windows.Forms.Button btnLoadDownloadList;
        private System.Windows.Forms.Button btnSaveDownloadList;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.TextBox txtTimeout;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkMinimizeTray;
        private System.Windows.Forms.Button btnBrowseFolder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSaveFolder;
        private System.Windows.Forms.ContextMenuStrip ctxMenuDownload;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar tsProgress2;
        private System.Windows.Forms.TextBox txtRetry;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox chkPadUserAgent;
        private System.Windows.Forms.ContextMenuStrip ctxMenuLog;
        private System.Windows.Forms.ToolStripMenuItem clearLogToolStripMenuItem;
        private System.Windows.Forms.Button btnSearchHelp;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.ContextMenuStrip ctxMenuList;
        private System.Windows.Forms.ToolStripMenuItem searchByParentToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctxMenuSysTray;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem addSelectedRowsToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnAddBatchJob;
        private System.Windows.Forms.Button btnStartBatchJob;
        private System.Windows.Forms.Button btnStopBatchJob;
        private System.Windows.Forms.CheckBox chkProxyLogin;
        private System.Windows.Forms.TextBox txtProxyPassword;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtProxyUsername;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox cbxAbortOnError;
        private System.Windows.Forms.Button btnPauseBatchJob;
        private System.Windows.Forms.Button btnClearCompleted;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.ContextMenuStrip ctxMenuBatch;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.LinkLabel linkUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DanbooruDownloader3.CustomControl.TagsColumn tagsColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.CheckBox chkUseTagColor;
        private System.Windows.Forms.Label lblColorGeneral;
        private System.Windows.Forms.Label lblColorArtist;
        private System.Windows.Forms.Label lblColorCopy;
        private System.Windows.Forms.Label lblColorChara;
        private System.Windows.Forms.Label lblColorCircle;
        private System.Windows.Forms.Label lblColorFaults;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckBox chkTagAutoComplete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtTagReplacement;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtTagBlacklist;
        private System.Windows.Forms.Label lblColorBlacklistedTag;
        private System.Windows.Forms.CheckBox chkRenameJpeg;
        private DanbooruDownloader3.CustomControl.TagsColumn tagsColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.CheckBox chkLogging;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbxImageSize;
        private System.Windows.Forms.GroupBox gbxDanbooru;
        private System.Windows.Forms.CheckBox chkAutoLoadNext;
        private System.Windows.Forms.CheckBox chkAppendList;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.CheckBox chkSaveQuery;
        private System.Windows.Forms.CheckBox chkAutoLoadList;
        private System.Windows.Forms.CheckBox chkLoadPreview;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Button btnBrowseDefaultSave;
        private System.Windows.Forms.TextBox txtDefaultSaveFolder;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ListBox lbxAutoComplete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.TextBox txtAutoCompleteLimit;
        private System.Windows.Forms.CheckBox chkSaveFolderWhenExit;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem reloadThumbnailToolStripMenuItem;
        private CustomControl.gfDataGridView dgvList;
        private CustomControl.gfDataGridView dgvDownload;
        private CustomControl.gfDataGridView dgvBatchJob;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem resetColumnOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resolveFileUrlToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.TextBox txtArtistTagGrouping;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtCircleTagGrouping;
        private System.Windows.Forms.TextBox txtFaultsTagGrouping;
        private System.Windows.Forms.TextBox txtCharaTagGrouping;
        private System.Windows.Forms.TextBox txtCopyTagGrouping;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtIgnoredTags;
        private System.Windows.Forms.CheckBox chkIgnoreTagsUseRegex;
        private System.Windows.Forms.CheckBox chkBlacklistTagsUseRegex;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnSaveBatchList;
        private System.Windows.Forms.Button btnLoadList;
        private System.Windows.Forms.Button btnClearCompletedDownload;
        private System.Windows.Forms.CheckBox chkEnableCookie;
        private System.Windows.Forms.Button btnCookie;
        private System.Windows.Forms.Label lblColorUnknown;
        private System.Windows.Forms.CheckBox chkUseGlobalProviderTags;
        private System.Windows.Forms.TextBox txtAcceptLanguage;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.CheckBox chkEnableCompression;
        private System.Windows.Forms.CheckBox chkHideBlaclistedImage;
        private System.Windows.Forms.CheckBox chkProcessDeletedPost;
        private System.Windows.Forms.TextBox txtBatchJobDelay;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.CheckBox chkDelayIncludeSkip;
        private System.Windows.Forms.CheckBox chkWriteDownloadedFileTxt;
        private System.Windows.Forms.CheckBox chkReplaceMode;
        private System.Windows.Forms.CheckBox chkIgnoreForGeneralTag;
        private System.Windows.Forms.CheckBox chkBlacklistOnlyGeneral;
        private System.Windows.Forms.TextBox txtOverFault;
        private System.Windows.Forms.TextBox txtOverCircle;
        private System.Windows.Forms.TextBox txtOverChara;
        private System.Windows.Forms.TextBox txtOverCopyright;
        private System.Windows.Forms.TextBox txtOverArtist;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheck;
        private System.Windows.Forms.DataGridViewImageColumn colPreview;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRating;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTags;
        private CustomControl.TagsColumn colTagsE;
        private System.Windows.Forms.DataGridViewLinkColumn colUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMD5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuery;
        private System.Windows.Forms.DataGridViewLinkColumn colSourceUrl;
        private System.Windows.Forms.DataGridViewLinkColumn colReferer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.CheckBox chkIsReplaceUnderscoreTag;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.CheckBox cbxWriteTag;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.TextBox txtDateTimeFormat;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndex;
        private System.Windows.Forms.DataGridViewImageColumn colPreview2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProgress2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProvider2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRating2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTags2;
        private CustomControl.TagsColumn colTagsE2;
        private System.Windows.Forms.DataGridViewLinkColumn colUrl2;
        private System.Windows.Forms.DataGridViewLinkColumn colReferer2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMD52;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuery2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFilename;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDownloadStart2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchTagQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchRating;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchStartPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchProviders;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchSaveFolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchStatus;
        private System.Windows.Forms.TextBox txtNoFault;
        private System.Windows.Forms.TextBox txtNoCircle;
        private System.Windows.Forms.TextBox txtNoChara;
        private System.Windows.Forms.TextBox txtNoCopyright;
        private System.Windows.Forms.TextBox txtNoArtist;
        private System.Windows.Forms.Label label33;
    }
}

