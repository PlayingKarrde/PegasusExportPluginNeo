namespace PegasusExportPlugin
{
    partial class frmPegasusExport
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
            this.btnExport = new System.Windows.Forms.Button();
            this.fbdExportFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.txtExportPath = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.chkMetaData = new System.Windows.Forms.CheckBox();
            this.chkApplication = new System.Windows.Forms.CheckBox();
            this.chkAssets = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.lbImagePriority = new System.Windows.Forms.ListBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.radChoose = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbAssetPath = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radAbsoluteAssets = new System.Windows.Forms.RadioButton();
            this.radLinkAssets = new System.Windows.Forms.RadioButton();
            this.radCopyAssets = new System.Windows.Forms.RadioButton();
            this.clbAssetList = new System.Windows.Forms.CheckedListBox();
            this.radAutoChoose = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkSingleExport = new System.Windows.Forms.CheckBox();
            this.dgvPlatforms = new System.Windows.Forms.DataGridView();
            this.colSelected = new PegasusExportPlugin.Controls.DataGridViewHeaderCheckBoxColumn();
            this.colPlatform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMetaData = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colAssets = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colApplication = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewHeaderCheckBoxColumn1 = new PegasusExportPlugin.Controls.DataGridViewHeaderCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkESDE = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvPlaylists = new System.Windows.Forms.DataGridView();
            this.colSelected2 = new PegasusExportPlugin.Controls.DataGridViewHeaderCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.gbApplicationPath = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radAbsoluteApplication = new System.Windows.Forms.RadioButton();
            this.radLinkApplication = new System.Windows.Forms.RadioButton();
            this.radCopyApplication = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.chkOverwriteMeta = new System.Windows.Forms.CheckBox();
            this.chkOverwriteAssets = new System.Windows.Forms.CheckBox();
            this.chkOverwriteRoms = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbAssetPath.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatforms)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylists)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.gbApplicationPath.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(16, 1065);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(1027, 28);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "&Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // txtExportPath
            // 
            this.txtExportPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExportPath.Location = new System.Drawing.Point(120, 15);
            this.txtExportPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtExportPath.Name = "txtExportPath";
            this.txtExportPath.ReadOnly = true;
            this.txtExportPath.Size = new System.Drawing.Size(813, 22);
            this.txtExportPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Export Folder:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(943, 12);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 28);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "&Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(16, 1029);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1027, 28);
            this.progressBar.TabIndex = 4;
            // 
            // chkMetaData
            // 
            this.chkMetaData.AutoSize = true;
            this.chkMetaData.Checked = true;
            this.chkMetaData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMetaData.Location = new System.Drawing.Point(8, 23);
            this.chkMetaData.Margin = new System.Windows.Forms.Padding(4);
            this.chkMetaData.Name = "chkMetaData";
            this.chkMetaData.Size = new System.Drawing.Size(127, 20);
            this.chkMetaData.TabIndex = 5;
            this.chkMetaData.Text = "Export Metadata";
            this.chkMetaData.UseVisualStyleBackColor = true;
            // 
            // chkApplication
            // 
            this.chkApplication.AutoSize = true;
            this.chkApplication.Checked = true;
            this.chkApplication.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkApplication.Location = new System.Drawing.Point(283, 23);
            this.chkApplication.Margin = new System.Windows.Forms.Padding(4);
            this.chkApplication.Name = "chkApplication";
            this.chkApplication.Size = new System.Drawing.Size(99, 20);
            this.chkApplication.TabIndex = 6;
            this.chkApplication.Text = "Export Rom";
            this.chkApplication.UseVisualStyleBackColor = true;
            // 
            // chkAssets
            // 
            this.chkAssets.AutoSize = true;
            this.chkAssets.Checked = true;
            this.chkAssets.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAssets.Location = new System.Drawing.Point(155, 23);
            this.chkAssets.Margin = new System.Windows.Forms.Padding(4);
            this.chkAssets.Name = "chkAssets";
            this.chkAssets.Size = new System.Drawing.Size(111, 20);
            this.chkAssets.TabIndex = 7;
            this.chkAssets.Text = "Export Assets";
            this.chkAssets.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnUp);
            this.groupBox1.Controls.Add(this.lbImagePriority);
            this.groupBox1.Controls.Add(this.btnDown);
            this.groupBox1.Location = new System.Drawing.Point(584, 721);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(281, 242);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Box Art Priority";
            // 
            // btnUp
            // 
            this.btnUp.Enabled = false;
            this.btnUp.Location = new System.Drawing.Point(187, 23);
            this.btnUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(36, 28);
            this.btnUp.TabIndex = 12;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.BtnUp_Click);
            // 
            // lbImagePriority
            // 
            this.lbImagePriority.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbImagePriority.Enabled = false;
            this.lbImagePriority.FormattingEnabled = true;
            this.lbImagePriority.ItemHeight = 16;
            this.lbImagePriority.Items.AddRange(new object[] {
            "Aspect Ratio (MODE)",
            "Smaller File Size",
            "Lossless",
            "Larger File Size"});
            this.lbImagePriority.Location = new System.Drawing.Point(16, 59);
            this.lbImagePriority.Margin = new System.Windows.Forms.Padding(4);
            this.lbImagePriority.Name = "lbImagePriority";
            this.lbImagePriority.Size = new System.Drawing.Size(249, 164);
            this.lbImagePriority.TabIndex = 10;
            // 
            // btnDown
            // 
            this.btnDown.Enabled = false;
            this.btnDown.Location = new System.Drawing.Point(231, 23);
            this.btnDown.Margin = new System.Windows.Forms.Padding(4);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(36, 28);
            this.btnDown.TabIndex = 11;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.BtnDown_Click);
            // 
            // radChoose
            // 
            this.radChoose.AutoSize = true;
            this.radChoose.Enabled = false;
            this.radChoose.Location = new System.Drawing.Point(11, 52);
            this.radChoose.Margin = new System.Windows.Forms.Padding(4);
            this.radChoose.Name = "radChoose";
            this.radChoose.Size = new System.Drawing.Size(116, 20);
            this.radChoose.TabIndex = 10;
            this.radChoose.Text = "Let me choose";
            this.radChoose.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.gbAssetPath);
            this.groupBox2.Controls.Add(this.radLinkAssets);
            this.groupBox2.Controls.Add(this.radCopyAssets);
            this.groupBox2.Controls.Add(this.clbAssetList);
            this.groupBox2.Location = new System.Drawing.Point(12, 721);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(387, 242);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asset Export";
            // 
            // gbAssetPath
            // 
            this.gbAssetPath.Controls.Add(this.radioButton3);
            this.gbAssetPath.Controls.Add(this.radAbsoluteAssets);
            this.gbAssetPath.Location = new System.Drawing.Point(236, 76);
            this.gbAssetPath.Margin = new System.Windows.Forms.Padding(4);
            this.gbAssetPath.Name = "gbAssetPath";
            this.gbAssetPath.Padding = new System.Windows.Forms.Padding(4);
            this.gbAssetPath.Size = new System.Drawing.Size(143, 84);
            this.gbAssetPath.TabIndex = 6;
            this.gbAssetPath.TabStop = false;
            this.gbAssetPath.Text = "Path";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Enabled = false;
            this.radioButton3.Location = new System.Drawing.Point(21, 52);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(78, 20);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.Text = "Relative";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radAbsoluteAssets
            // 
            this.radAbsoluteAssets.AutoSize = true;
            this.radAbsoluteAssets.Checked = true;
            this.radAbsoluteAssets.Enabled = false;
            this.radAbsoluteAssets.Location = new System.Drawing.Point(21, 23);
            this.radAbsoluteAssets.Margin = new System.Windows.Forms.Padding(4);
            this.radAbsoluteAssets.Name = "radAbsoluteAssets";
            this.radAbsoluteAssets.Size = new System.Drawing.Size(81, 20);
            this.radAbsoluteAssets.TabIndex = 4;
            this.radAbsoluteAssets.TabStop = true;
            this.radAbsoluteAssets.Text = "Absolute";
            this.radAbsoluteAssets.UseVisualStyleBackColor = true;
            // 
            // radLinkAssets
            // 
            this.radLinkAssets.AutoSize = true;
            this.radLinkAssets.Location = new System.Drawing.Point(236, 48);
            this.radLinkAssets.Margin = new System.Windows.Forms.Padding(4);
            this.radLinkAssets.Name = "radLinkAssets";
            this.radLinkAssets.Size = new System.Drawing.Size(110, 20);
            this.radLinkAssets.TabIndex = 2;
            this.radLinkAssets.Text = "Link to Assets";
            this.radLinkAssets.UseVisualStyleBackColor = true;
            this.radLinkAssets.CheckedChanged += new System.EventHandler(this.RadLinkAssets_CheckedChanged);
            // 
            // radCopyAssets
            // 
            this.radCopyAssets.AutoSize = true;
            this.radCopyAssets.Checked = true;
            this.radCopyAssets.Location = new System.Drawing.Point(236, 20);
            this.radCopyAssets.Margin = new System.Windows.Forms.Padding(4);
            this.radCopyAssets.Name = "radCopyAssets";
            this.radCopyAssets.Size = new System.Drawing.Size(104, 20);
            this.radCopyAssets.TabIndex = 1;
            this.radCopyAssets.TabStop = true;
            this.radCopyAssets.Text = "Copy Assets";
            this.radCopyAssets.UseVisualStyleBackColor = true;
            // 
            // clbAssetList
            // 
            this.clbAssetList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbAssetList.CheckOnClick = true;
            this.clbAssetList.FormattingEnabled = true;
            this.clbAssetList.Location = new System.Drawing.Point(4, 20);
            this.clbAssetList.Margin = new System.Windows.Forms.Padding(4);
            this.clbAssetList.Name = "clbAssetList";
            this.clbAssetList.Size = new System.Drawing.Size(223, 208);
            this.clbAssetList.TabIndex = 0;
            // 
            // radAutoChoose
            // 
            this.radAutoChoose.AutoSize = true;
            this.radAutoChoose.Checked = true;
            this.radAutoChoose.Location = new System.Drawing.Point(11, 23);
            this.radAutoChoose.Margin = new System.Windows.Forms.Padding(4);
            this.radAutoChoose.Name = "radAutoChoose";
            this.radAutoChoose.Size = new System.Drawing.Size(115, 20);
            this.radAutoChoose.TabIndex = 13;
            this.radAutoChoose.TabStop = true;
            this.radAutoChoose.Text = "Choose for me";
            this.radAutoChoose.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.chkSingleExport);
            this.groupBox3.Controls.Add(this.radAutoChoose);
            this.groupBox3.Controls.Add(this.radChoose);
            this.groupBox3.Location = new System.Drawing.Point(873, 721);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(141, 119);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Duplicate Assets";
            // 
            // chkSingleExport
            // 
            this.chkSingleExport.AutoSize = true;
            this.chkSingleExport.Checked = true;
            this.chkSingleExport.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSingleExport.Location = new System.Drawing.Point(8, 80);
            this.chkSingleExport.Margin = new System.Windows.Forms.Padding(4);
            this.chkSingleExport.Name = "chkSingleExport";
            this.chkSingleExport.Size = new System.Drawing.Size(108, 20);
            this.chkSingleExport.TabIndex = 14;
            this.chkSingleExport.Text = "Single Export";
            this.chkSingleExport.UseVisualStyleBackColor = true;
            // 
            // dgvPlatforms
            // 
            this.dgvPlatforms.AllowUserToAddRows = false;
            this.dgvPlatforms.AllowUserToDeleteRows = false;
            this.dgvPlatforms.AllowUserToResizeRows = false;
            this.dgvPlatforms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlatforms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlatforms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlatforms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelected,
            this.colPlatform,
            this.colMetaData,
            this.colAssets,
            this.colApplication});
            this.dgvPlatforms.Location = new System.Drawing.Point(11, 23);
            this.dgvPlatforms.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPlatforms.Name = "dgvPlatforms";
            this.dgvPlatforms.RowHeadersVisible = false;
            this.dgvPlatforms.RowHeadersWidth = 51;
            this.dgvPlatforms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.ColumnHeaderSelect;
            this.dgvPlatforms.ShowEditingIcon = false;
            this.dgvPlatforms.Size = new System.Drawing.Size(1000, 419);
            this.dgvPlatforms.TabIndex = 13;
            // 
            // colSelected
            // 
            this.colSelected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSelected.DataPropertyName = "Selected";
            this.colSelected.HeaderCheckBox = true;
            this.colSelected.HeaderText = "";
            this.colSelected.MinimumWidth = 40;
            this.colSelected.Name = "colSelected";
            this.colSelected.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSelected.Width = 40;
            // 
            // colPlatform
            // 
            this.colPlatform.DataPropertyName = "Name";
            this.colPlatform.HeaderText = "Platform";
            this.colPlatform.MinimumWidth = 6;
            this.colPlatform.Name = "colPlatform";
            this.colPlatform.ReadOnly = true;
            this.colPlatform.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colMetaData
            // 
            this.colMetaData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colMetaData.DataPropertyName = "ExportMetadata";
            this.colMetaData.HeaderText = "Metadata";
            this.colMetaData.MinimumWidth = 6;
            this.colMetaData.Name = "colMetaData";
            this.colMetaData.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMetaData.Width = 70;
            // 
            // colAssets
            // 
            this.colAssets.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colAssets.DataPropertyName = "ExportAssets";
            this.colAssets.HeaderText = "Assets";
            this.colAssets.MinimumWidth = 6;
            this.colAssets.Name = "colAssets";
            this.colAssets.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAssets.Width = 54;
            // 
            // colApplication
            // 
            this.colApplication.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colApplication.DataPropertyName = "ExportApplication";
            this.colApplication.HeaderText = "Application";
            this.colApplication.MinimumWidth = 6;
            this.colApplication.Name = "colApplication";
            this.colApplication.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colApplication.Width = 80;
            // 
            // dataGridViewHeaderCheckBoxColumn1
            // 
            this.dataGridViewHeaderCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewHeaderCheckBoxColumn1.HeaderCheckBox = true;
            this.dataGridViewHeaderCheckBoxColumn1.HeaderText = "";
            this.dataGridViewHeaderCheckBoxColumn1.MinimumWidth = 20;
            this.dataGridViewHeaderCheckBoxColumn1.Name = "dataGridViewHeaderCheckBoxColumn1";
            this.dataGridViewHeaderCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHeaderCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewHeaderCheckBoxColumn1.Width = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Platform";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dgvPlatforms);
            this.groupBox4.Location = new System.Drawing.Point(4, 65);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1019, 450);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Platform Export Options";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkESDE);
            this.groupBox5.Controls.Add(this.chkMetaData);
            this.groupBox5.Controls.Add(this.chkAssets);
            this.groupBox5.Controls.Add(this.chkApplication);
            this.groupBox5.Location = new System.Drawing.Point(4, 4);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(1019, 54);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Global Override Settings";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.groupBox8);
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(16, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 974);
            this.panel1.TabIndex = 14;
            // 
            // chkESDE
            // 
            this.chkESDE.AutoSize = true;
            this.chkESDE.Checked = true;
            this.chkESDE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkESDE.Location = new System.Drawing.Point(397, 23);
            this.chkESDE.Margin = new System.Windows.Forms.Padding(4);
            this.chkESDE.Name = "chkESDE";
            this.chkESDE.Size = new System.Drawing.Size(119, 20);
            this.chkESDE.TabIndex = 16;
            this.chkESDE.Text = "ES-DE Folders";
            this.chkESDE.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.dgvPlaylists);
            this.groupBox7.Location = new System.Drawing.Point(4, 523);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(1019, 183);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Playlist Export Options";
            // 
            // dgvPlaylists
            // 
            this.dgvPlaylists.AllowUserToAddRows = false;
            this.dgvPlaylists.AllowUserToDeleteRows = false;
            this.dgvPlaylists.AllowUserToResizeRows = false;
            this.dgvPlaylists.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlaylists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlaylists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaylists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelected2,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3});
            this.dgvPlaylists.Location = new System.Drawing.Point(11, 23);
            this.dgvPlaylists.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPlaylists.Name = "dgvPlaylists";
            this.dgvPlaylists.RowHeadersVisible = false;
            this.dgvPlaylists.RowHeadersWidth = 51;
            this.dgvPlaylists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.ColumnHeaderSelect;
            this.dgvPlaylists.ShowEditingIcon = false;
            this.dgvPlaylists.Size = new System.Drawing.Size(1000, 146);
            this.dgvPlaylists.TabIndex = 13;
            // 
            // colSelected2
            // 
            this.colSelected2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSelected2.DataPropertyName = "Selected";
            this.colSelected2.HeaderCheckBox = true;
            this.colSelected2.HeaderText = "";
            this.colSelected2.MinimumWidth = 40;
            this.colSelected2.Name = "colSelected2";
            this.colSelected2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSelected2.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Playlist";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "ExportMetadata";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Metadata";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.Width = 70;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "ExportAssets";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Assets";
            this.dataGridViewCheckBoxColumn2.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn2.Width = 54;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "ExportApplication";
            this.dataGridViewCheckBoxColumn3.HeaderText = "Application";
            this.dataGridViewCheckBoxColumn3.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn3.Width = 80;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox6.Controls.Add(this.gbApplicationPath);
            this.groupBox6.Controls.Add(this.radLinkApplication);
            this.groupBox6.Controls.Add(this.radCopyApplication);
            this.groupBox6.Location = new System.Drawing.Point(407, 721);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(169, 242);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Rom Export";
            // 
            // gbApplicationPath
            // 
            this.gbApplicationPath.Controls.Add(this.radioButton2);
            this.gbApplicationPath.Controls.Add(this.radAbsoluteApplication);
            this.gbApplicationPath.Location = new System.Drawing.Point(8, 76);
            this.gbApplicationPath.Margin = new System.Windows.Forms.Padding(4);
            this.gbApplicationPath.Name = "gbApplicationPath";
            this.gbApplicationPath.Padding = new System.Windows.Forms.Padding(4);
            this.gbApplicationPath.Size = new System.Drawing.Size(153, 84);
            this.gbApplicationPath.TabIndex = 5;
            this.gbApplicationPath.TabStop = false;
            this.gbApplicationPath.Text = "Path";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(21, 52);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 20);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "Relative";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radAbsoluteApplication
            // 
            this.radAbsoluteApplication.AutoSize = true;
            this.radAbsoluteApplication.Checked = true;
            this.radAbsoluteApplication.Enabled = false;
            this.radAbsoluteApplication.Location = new System.Drawing.Point(21, 23);
            this.radAbsoluteApplication.Margin = new System.Windows.Forms.Padding(4);
            this.radAbsoluteApplication.Name = "radAbsoluteApplication";
            this.radAbsoluteApplication.Size = new System.Drawing.Size(84, 20);
            this.radAbsoluteApplication.TabIndex = 4;
            this.radAbsoluteApplication.TabStop = true;
            this.radAbsoluteApplication.Text = "Absolute.";
            this.radAbsoluteApplication.UseVisualStyleBackColor = true;
            // 
            // radLinkApplication
            // 
            this.radLinkApplication.AutoSize = true;
            this.radLinkApplication.Location = new System.Drawing.Point(8, 48);
            this.radLinkApplication.Margin = new System.Windows.Forms.Padding(4);
            this.radLinkApplication.Name = "radLinkApplication";
            this.radLinkApplication.Size = new System.Drawing.Size(98, 20);
            this.radLinkApplication.TabIndex = 4;
            this.radLinkApplication.Text = "Link to Rom";
            this.radLinkApplication.UseVisualStyleBackColor = true;
            this.radLinkApplication.CheckedChanged += new System.EventHandler(this.RadLinkApplication_CheckedChanged);
            // 
            // radCopyApplication
            // 
            this.radCopyApplication.AutoSize = true;
            this.radCopyApplication.Checked = true;
            this.radCopyApplication.Location = new System.Drawing.Point(8, 20);
            this.radCopyApplication.Margin = new System.Windows.Forms.Padding(4);
            this.radCopyApplication.Name = "radCopyApplication";
            this.radCopyApplication.Size = new System.Drawing.Size(92, 20);
            this.radCopyApplication.TabIndex = 3;
            this.radCopyApplication.TabStop = true;
            this.radCopyApplication.Text = "Copy Rom";
            this.radCopyApplication.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.chkOverwriteRoms);
            this.groupBox8.Controls.Add(this.chkOverwriteAssets);
            this.groupBox8.Controls.Add(this.chkOverwriteMeta);
            this.groupBox8.Location = new System.Drawing.Point(873, 851);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox8.Size = new System.Drawing.Size(141, 112);
            this.groupBox8.TabIndex = 15;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Overwrite";
            // 
            // chkOverwriteMeta
            // 
            this.chkOverwriteMeta.AutoSize = true;
            this.chkOverwriteMeta.Checked = true;
            this.chkOverwriteMeta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOverwriteMeta.Location = new System.Drawing.Point(8, 23);
            this.chkOverwriteMeta.Margin = new System.Windows.Forms.Padding(4);
            this.chkOverwriteMeta.Name = "chkOverwriteMeta";
            this.chkOverwriteMeta.Size = new System.Drawing.Size(86, 20);
            this.chkOverwriteMeta.TabIndex = 14;
            this.chkOverwriteMeta.Text = "Metadata";
            this.chkOverwriteMeta.UseVisualStyleBackColor = true;
            // 
            // chkOverwriteAssets
            // 
            this.chkOverwriteAssets.AutoSize = true;
            this.chkOverwriteAssets.Checked = true;
            this.chkOverwriteAssets.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOverwriteAssets.Location = new System.Drawing.Point(8, 51);
            this.chkOverwriteAssets.Margin = new System.Windows.Forms.Padding(4);
            this.chkOverwriteAssets.Name = "chkOverwriteAssets";
            this.chkOverwriteAssets.Size = new System.Drawing.Size(70, 20);
            this.chkOverwriteAssets.TabIndex = 15;
            this.chkOverwriteAssets.Text = "Assets";
            this.chkOverwriteAssets.UseVisualStyleBackColor = true;
            // 
            // chkOverwriteRoms
            // 
            this.chkOverwriteRoms.AutoSize = true;
            this.chkOverwriteRoms.Checked = true;
            this.chkOverwriteRoms.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOverwriteRoms.Location = new System.Drawing.Point(8, 79);
            this.chkOverwriteRoms.Margin = new System.Windows.Forms.Padding(4);
            this.chkOverwriteRoms.Name = "chkOverwriteRoms";
            this.chkOverwriteRoms.Size = new System.Drawing.Size(65, 20);
            this.chkOverwriteRoms.TabIndex = 16;
            this.chkOverwriteRoms.Text = "Roms";
            this.chkOverwriteRoms.UseVisualStyleBackColor = true;
            // 
            // frmPegasusExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 1108);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExportPath);
            this.Controls.Add(this.btnExport);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(679, 358);
            this.Name = "frmPegasusExport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pegasus Export";
            this.Load += new System.EventHandler(this.FrmPegasusExport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbAssetPath.ResumeLayout(false);
            this.gbAssetPath.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatforms)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylists)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.gbApplicationPath.ResumeLayout(false);
            this.gbApplicationPath.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.FolderBrowserDialog fbdExportFolder;
        private System.Windows.Forms.MaskedTextBox txtExportPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox chkMetaData;
        private System.Windows.Forms.CheckBox chkApplication;
        private System.Windows.Forms.CheckBox chkAssets;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbImagePriority;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.RadioButton radChoose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox clbAssetList;
        private System.Windows.Forms.RadioButton radAutoChoose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvPlatforms;
        private Controls.DataGridViewHeaderCheckBoxColumn dataGridViewHeaderCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radLinkAssets;
        private System.Windows.Forms.RadioButton radCopyAssets;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radLinkApplication;
        private System.Windows.Forms.RadioButton radCopyApplication;
        private System.Windows.Forms.GroupBox gbAssetPath;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radAbsoluteAssets;
        private System.Windows.Forms.GroupBox gbApplicationPath;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radAbsoluteApplication;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dgvPlaylists;
        private System.Windows.Forms.CheckBox chkSingleExport;
        private Controls.DataGridViewHeaderCheckBoxColumn colSelected2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.CheckBox chkESDE;
        private Controls.DataGridViewHeaderCheckBoxColumn colSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlatform;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colMetaData;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAssets;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colApplication;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox chkOverwriteMeta;
        private System.Windows.Forms.CheckBox chkOverwriteRoms;
        private System.Windows.Forms.CheckBox chkOverwriteAssets;
    }
}