namespace Ordisoftware.TweetsInspector
{
  partial class MainForm
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if ( disposing && ( components != null ) )
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.Label LabelConsumerBackUrl;
      System.Windows.Forms.Label LabelConsumerKey;
      System.Windows.Forms.Label LabelConsumerSecret;
      System.Windows.Forms.Label LabelStartupConnectAction;
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      this.ActionOpenMessages = new System.Windows.Forms.Button();
      this.OpenFileDialogJS = new System.Windows.Forms.OpenFileDialog();
      this.EditUser1 = new System.Windows.Forms.TextBox();
      this.EditUser2 = new System.Windows.Forms.TextBox();
      this.EditMessagesCleaned = new System.Windows.Forms.TextBox();
      this.EditMessagesSource = new System.Windows.Forms.TextBox();
      this.TabControl = new System.Windows.Forms.TabControl();
      this.TabPageTweets = new System.Windows.Forms.TabPage();
      this.SplitContainerMain = new System.Windows.Forms.SplitContainer();
      this.TweetsControl = new Ordisoftware.TweetsInspector.TweetsControl();
      this.panel1 = new System.Windows.Forms.Panel();
      this.DataGridViewUsers = new System.Windows.Forms.DataGridView();
      this.ColumnUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnUserCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.UsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.PanelFilterUsers = new System.Windows.Forms.Panel();
      this.EditFilterUsers = new System.Windows.Forms.TextBox();
      this.ActionFilterUsersClear = new System.Windows.Forms.Button();
      this.PanelTweetsTop = new System.Windows.Forms.Panel();
      this.ActionCheckOnlineDestroyed = new System.Windows.Forms.Button();
      this.EditSingleClickUserFilter = new System.Windows.Forms.CheckBox();
      this.ActionDelete = new System.Windows.Forms.Button();
      this.EditSearchInMessage = new System.Windows.Forms.CheckBox();
      this.EditSearchInRecipients = new System.Windows.Forms.CheckBox();
      this.ActionGetLikes = new System.Windows.Forms.Button();
      this.ActionSelectAll = new System.Windows.Forms.Button();
      this.ActionSelectNone = new System.Windows.Forms.Button();
      this.ActionFilterClear = new System.Windows.Forms.Button();
      this.EditDeleteOnlyLocal = new System.Windows.Forms.CheckBox();
      this.EditSearch = new System.Windows.Forms.TextBox();
      this.ActionConnect = new System.Windows.Forms.Button();
      this.ActionLoadFromJS = new System.Windows.Forms.Button();
      this.ActionSaveToCSV = new System.Windows.Forms.Button();
      this.TabPageDestroyed = new System.Windows.Forms.TabPage();
      this.ListTweetsTrash = new Ordisoftware.TweetsInspector.ListTweets();
      this.TabPageMessages = new System.Windows.Forms.TabPage();
      this.TabPageUsers = new System.Windows.Forms.TabPage();
      this.EditUsers = new Ordisoftware.Core.RichTextBoxEx();
      this.ActionGetFellowing = new System.Windows.Forms.Button();
      this.ActionGetMutes = new System.Windows.Forms.Button();
      this.ActionGetBlocks = new System.Windows.Forms.Button();
      this.ActionGetFollowers = new System.Windows.Forms.Button();
      this.TabPageSettings = new System.Windows.Forms.TabPage();
      this.SelectStartupConnectAction = new System.Windows.Forms.ComboBox();
      this.SettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.EditConsumerSecret = new System.Windows.Forms.TextBox();
      this.EditConsumerKey = new System.Windows.Forms.TextBox();
      this.EditConsumerBackUrl = new System.Windows.Forms.TextBox();
      this.StatusStrip = new System.Windows.Forms.StatusStrip();
      this.LabelCountTweetsMain = new System.Windows.Forms.ToolStripStatusLabel();
      this.LabelCountTweetsMainValue = new System.Windows.Forms.ToolStripStatusLabel();
      this.LabelCountTweetsReplies = new System.Windows.Forms.ToolStripStatusLabel();
      this.LabelCountTweetsRepliesValue = new System.Windows.Forms.ToolStripStatusLabel();
      this.LabelCountTweetsRTs = new System.Windows.Forms.ToolStripStatusLabel();
      this.LabelCountTweetsRTsValue = new System.Windows.Forms.ToolStripStatusLabel();
      this.LabelCountAllRecipients = new System.Windows.Forms.ToolStripStatusLabel();
      this.LabelCountAllRecipientsValue = new System.Windows.Forms.ToolStripStatusLabel();
      this.PanelMain = new System.Windows.Forms.Panel();
      this.DataSet = new Ordisoftware.TweetsInspector.Data.DataSet();
      this.TweetsBindingSourceMain = new System.Windows.Forms.BindingSource(this.components);
      this.TweetsTableAdapter = new Ordisoftware.TweetsInspector.Data.DataSetTableAdapters.TweetsTableAdapter();
      this.TableAdapterManager = new Ordisoftware.TweetsInspector.Data.DataSetTableAdapters.TableAdapterManager();
      this.TweetsBindingSourceReplies = new System.Windows.Forms.BindingSource(this.components);
      this.TweetsBindingSourceRTs = new System.Windows.Forms.BindingSource(this.components);
      this.TrashBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.TrashTableAdapter = new Ordisoftware.TweetsInspector.Data.DataSetTableAdapters.TrashTableAdapter();
      LabelConsumerBackUrl = new System.Windows.Forms.Label();
      LabelConsumerKey = new System.Windows.Forms.Label();
      LabelConsumerSecret = new System.Windows.Forms.Label();
      LabelStartupConnectAction = new System.Windows.Forms.Label();
      this.TabControl.SuspendLayout();
      this.TabPageTweets.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.SplitContainerMain)).BeginInit();
      this.SplitContainerMain.Panel1.SuspendLayout();
      this.SplitContainerMain.Panel2.SuspendLayout();
      this.SplitContainerMain.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUsers)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource)).BeginInit();
      this.PanelFilterUsers.SuspendLayout();
      this.PanelTweetsTop.SuspendLayout();
      this.TabPageDestroyed.SuspendLayout();
      this.TabPageMessages.SuspendLayout();
      this.TabPageUsers.SuspendLayout();
      this.TabPageSettings.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.SettingsBindingSource)).BeginInit();
      this.StatusStrip.SuspendLayout();
      this.PanelMain.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.TweetsBindingSourceMain)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.TweetsBindingSourceReplies)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.TweetsBindingSourceRTs)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.TrashBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // LabelConsumerBackUrl
      // 
      LabelConsumerBackUrl.AutoSize = true;
      LabelConsumerBackUrl.Location = new System.Drawing.Point(20, 165);
      LabelConsumerBackUrl.Name = "LabelConsumerBackUrl";
      LabelConsumerBackUrl.Size = new System.Drawing.Size(48, 13);
      LabelConsumerBackUrl.TabIndex = 0;
      LabelConsumerBackUrl.Text = "Back Url";
      // 
      // LabelConsumerKey
      // 
      LabelConsumerKey.AutoSize = true;
      LabelConsumerKey.Location = new System.Drawing.Point(20, 75);
      LabelConsumerKey.Name = "LabelConsumerKey";
      LabelConsumerKey.Size = new System.Drawing.Size(75, 13);
      LabelConsumerKey.TabIndex = 2;
      LabelConsumerKey.Text = "Consumer Key";
      // 
      // LabelConsumerSecret
      // 
      LabelConsumerSecret.AutoSize = true;
      LabelConsumerSecret.Location = new System.Drawing.Point(20, 120);
      LabelConsumerSecret.Name = "LabelConsumerSecret";
      LabelConsumerSecret.Size = new System.Drawing.Size(88, 13);
      LabelConsumerSecret.TabIndex = 4;
      LabelConsumerSecret.Text = "Consumer Secret";
      // 
      // LabelStartupConnectAction
      // 
      LabelStartupConnectAction.AutoSize = true;
      LabelStartupConnectAction.Location = new System.Drawing.Point(20, 20);
      LabelStartupConnectAction.Name = "LabelStartupConnectAction";
      LabelStartupConnectAction.Size = new System.Drawing.Size(83, 13);
      LabelStartupConnectAction.TabIndex = 2;
      LabelStartupConnectAction.Text = "Startup connect";
      // 
      // ActionOpenMessages
      // 
      this.ActionOpenMessages.Location = new System.Drawing.Point(6, 6);
      this.ActionOpenMessages.Name = "ActionOpenMessages";
      this.ActionOpenMessages.Size = new System.Drawing.Size(75, 23);
      this.ActionOpenMessages.TabIndex = 0;
      this.ActionOpenMessages.Text = "Open";
      this.ActionOpenMessages.UseVisualStyleBackColor = true;
      this.ActionOpenMessages.Click += new System.EventHandler(this.ActionOpenMessages_Click);
      // 
      // OpenFileDialogJS
      // 
      this.OpenFileDialogJS.FileName = "tweet.js";
      this.OpenFileDialogJS.Filter = "JS Files|*.js";
      // 
      // EditUser1
      // 
      this.EditUser1.Location = new System.Drawing.Point(6, 35);
      this.EditUser1.Name = "EditUser1";
      this.EditUser1.Size = new System.Drawing.Size(100, 20);
      this.EditUser1.TabIndex = 1;
      // 
      // EditUser2
      // 
      this.EditUser2.Location = new System.Drawing.Point(6, 61);
      this.EditUser2.Name = "EditUser2";
      this.EditUser2.Size = new System.Drawing.Size(100, 20);
      this.EditUser2.TabIndex = 1;
      // 
      // EditMessagesCleaned
      // 
      this.EditMessagesCleaned.Location = new System.Drawing.Point(6, 324);
      this.EditMessagesCleaned.Multiline = true;
      this.EditMessagesCleaned.Name = "EditMessagesCleaned";
      this.EditMessagesCleaned.Size = new System.Drawing.Size(873, 322);
      this.EditMessagesCleaned.TabIndex = 2;
      // 
      // EditMessagesSource
      // 
      this.EditMessagesSource.Location = new System.Drawing.Point(6, 87);
      this.EditMessagesSource.Multiline = true;
      this.EditMessagesSource.Name = "EditMessagesSource";
      this.EditMessagesSource.Size = new System.Drawing.Size(873, 221);
      this.EditMessagesSource.TabIndex = 2;
      // 
      // TabControl
      // 
      this.TabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
      this.TabControl.Controls.Add(this.TabPageTweets);
      this.TabControl.Controls.Add(this.TabPageDestroyed);
      this.TabControl.Controls.Add(this.TabPageMessages);
      this.TabControl.Controls.Add(this.TabPageUsers);
      this.TabControl.Controls.Add(this.TabPageSettings);
      this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TabControl.Location = new System.Drawing.Point(10, 10);
      this.TabControl.Name = "TabControl";
      this.TabControl.SelectedIndex = 0;
      this.TabControl.Size = new System.Drawing.Size(864, 567);
      this.TabControl.TabIndex = 3;
      // 
      // TabPageTweets
      // 
      this.TabPageTweets.BackColor = System.Drawing.SystemColors.Control;
      this.TabPageTweets.Controls.Add(this.SplitContainerMain);
      this.TabPageTweets.Controls.Add(this.PanelTweetsTop);
      this.TabPageTweets.Location = new System.Drawing.Point(4, 25);
      this.TabPageTweets.Name = "TabPageTweets";
      this.TabPageTweets.Size = new System.Drawing.Size(856, 538);
      this.TabPageTweets.TabIndex = 1;
      this.TabPageTweets.Text = "Tweets";
      // 
      // SplitContainerMain
      // 
      this.SplitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SplitContainerMain.Location = new System.Drawing.Point(0, 70);
      this.SplitContainerMain.Name = "SplitContainerMain";
      // 
      // SplitContainerMain.Panel1
      // 
      this.SplitContainerMain.Panel1.Controls.Add(this.TweetsControl);
      // 
      // SplitContainerMain.Panel2
      // 
      this.SplitContainerMain.Panel2.Controls.Add(this.panel1);
      this.SplitContainerMain.Panel2MinSize = 100;
      this.SplitContainerMain.Size = new System.Drawing.Size(856, 468);
      this.SplitContainerMain.SplitterDistance = 730;
      this.SplitContainerMain.TabIndex = 9;
      // 
      // TweetsControl
      // 
      this.TweetsControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TweetsControl.Location = new System.Drawing.Point(0, 0);
      this.TweetsControl.MinimumSize = new System.Drawing.Size(700, 120);
      this.TweetsControl.Name = "TweetsControl";
      this.TweetsControl.Size = new System.Drawing.Size(730, 468);
      this.TweetsControl.TabIndex = 0;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.DataGridViewUsers);
      this.panel1.Controls.Add(this.PanelFilterUsers);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
      this.panel1.Size = new System.Drawing.Size(122, 468);
      this.panel1.TabIndex = 1;
      // 
      // DataGridViewUsers
      // 
      this.DataGridViewUsers.AllowUserToAddRows = false;
      this.DataGridViewUsers.AllowUserToDeleteRows = false;
      this.DataGridViewUsers.AllowUserToResizeRows = false;
      this.DataGridViewUsers.AutoGenerateColumns = false;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.DataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.DataGridViewUsers.ColumnHeadersHeight = 25;
      this.DataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.DataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnUserName,
            this.ColumnUserCount});
      this.DataGridViewUsers.DataSource = this.UsersBindingSource;
      this.DataGridViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
      this.DataGridViewUsers.EnableHeadersVisualStyles = false;
      this.DataGridViewUsers.Location = new System.Drawing.Point(5, 30);
      this.DataGridViewUsers.MultiSelect = false;
      this.DataGridViewUsers.Name = "DataGridViewUsers";
      this.DataGridViewUsers.ReadOnly = true;
      this.DataGridViewUsers.RowHeadersVisible = false;
      this.DataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.DataGridViewUsers.Size = new System.Drawing.Size(117, 438);
      this.DataGridViewUsers.TabIndex = 4;
      this.DataGridViewUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewUsers_CellClick);
      this.DataGridViewUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewUsers_CellDoubleClick);
      this.DataGridViewUsers.SelectionChanged += new System.EventHandler(this.DataGridViewUsers_SelectionChanged);
      // 
      // ColumnUserName
      // 
      this.ColumnUserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.ColumnUserName.DataPropertyName = "User";
      this.ColumnUserName.HeaderText = "User";
      this.ColumnUserName.Name = "ColumnUserName";
      this.ColumnUserName.ReadOnly = true;
      // 
      // ColumnUserCount
      // 
      this.ColumnUserCount.DataPropertyName = "Count";
      this.ColumnUserCount.HeaderText = "Count";
      this.ColumnUserCount.Name = "ColumnUserCount";
      this.ColumnUserCount.ReadOnly = true;
      this.ColumnUserCount.Width = 50;
      // 
      // PanelFilterUsers
      // 
      this.PanelFilterUsers.Controls.Add(this.EditFilterUsers);
      this.PanelFilterUsers.Controls.Add(this.ActionFilterUsersClear);
      this.PanelFilterUsers.Dock = System.Windows.Forms.DockStyle.Top;
      this.PanelFilterUsers.Location = new System.Drawing.Point(5, 0);
      this.PanelFilterUsers.Name = "PanelFilterUsers";
      this.PanelFilterUsers.Size = new System.Drawing.Size(117, 30);
      this.PanelFilterUsers.TabIndex = 0;
      // 
      // EditFilterUsers
      // 
      this.EditFilterUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.EditFilterUsers.Location = new System.Drawing.Point(0, 4);
      this.EditFilterUsers.Name = "EditFilterUsers";
      this.EditFilterUsers.Size = new System.Drawing.Size(89, 20);
      this.EditFilterUsers.TabIndex = 5;
      this.EditFilterUsers.TextChanged += new System.EventHandler(this.EditFilterUsers_TextChanged);
      // 
      // ActionFilterUsersClear
      // 
      this.ActionFilterUsersClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.ActionFilterUsersClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ActionFilterUsersClear.Location = new System.Drawing.Point(95, 3);
      this.ActionFilterUsersClear.Name = "ActionFilterUsersClear";
      this.ActionFilterUsersClear.Size = new System.Drawing.Size(23, 23);
      this.ActionFilterUsersClear.TabIndex = 2;
      this.ActionFilterUsersClear.Text = "X";
      this.ActionFilterUsersClear.UseVisualStyleBackColor = true;
      // 
      // PanelTweetsTop
      // 
      this.PanelTweetsTop.AutoScroll = true;
      this.PanelTweetsTop.Controls.Add(this.ActionCheckOnlineDestroyed);
      this.PanelTweetsTop.Controls.Add(this.EditSingleClickUserFilter);
      this.PanelTweetsTop.Controls.Add(this.ActionDelete);
      this.PanelTweetsTop.Controls.Add(this.EditSearchInMessage);
      this.PanelTweetsTop.Controls.Add(this.EditSearchInRecipients);
      this.PanelTweetsTop.Controls.Add(this.ActionGetLikes);
      this.PanelTweetsTop.Controls.Add(this.ActionSelectAll);
      this.PanelTweetsTop.Controls.Add(this.ActionSelectNone);
      this.PanelTweetsTop.Controls.Add(this.ActionFilterClear);
      this.PanelTweetsTop.Controls.Add(this.EditDeleteOnlyLocal);
      this.PanelTweetsTop.Controls.Add(this.EditSearch);
      this.PanelTweetsTop.Controls.Add(this.ActionConnect);
      this.PanelTweetsTop.Controls.Add(this.ActionLoadFromJS);
      this.PanelTweetsTop.Controls.Add(this.ActionSaveToCSV);
      this.PanelTweetsTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.PanelTweetsTop.Location = new System.Drawing.Point(0, 0);
      this.PanelTweetsTop.Name = "PanelTweetsTop";
      this.PanelTweetsTop.Size = new System.Drawing.Size(856, 70);
      this.PanelTweetsTop.TabIndex = 5;
      // 
      // ActionCheckOnlineDestroyed
      // 
      this.ActionCheckOnlineDestroyed.Enabled = false;
      this.ActionCheckOnlineDestroyed.Location = new System.Drawing.Point(326, 6);
      this.ActionCheckOnlineDestroyed.Name = "ActionCheckOnlineDestroyed";
      this.ActionCheckOnlineDestroyed.Size = new System.Drawing.Size(116, 23);
      this.ActionCheckOnlineDestroyed.TabIndex = 16;
      this.ActionCheckOnlineDestroyed.Text = "Check destroyed";
      this.ActionCheckOnlineDestroyed.UseVisualStyleBackColor = true;
      this.ActionCheckOnlineDestroyed.Click += new System.EventHandler(this.ActionCheckOnlineDestroyed_Click);
      // 
      // EditSingleClickUserFilter
      // 
      this.EditSingleClickUserFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.EditSingleClickUserFilter.AutoSize = true;
      this.EditSingleClickUserFilter.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.EditSingleClickUserFilter.Checked = global::Ordisoftware.TweetsInspector.Properties.Settings.Default.SingleClickUserFilter;
      this.EditSingleClickUserFilter.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.TweetsInspector.Properties.Settings.Default, "SingleClickUserFilter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditSingleClickUserFilter.Location = new System.Drawing.Point(714, 16);
      this.EditSingleClickUserFilter.Name = "EditSingleClickUserFilter";
      this.EditSingleClickUserFilter.Size = new System.Drawing.Size(139, 17);
      this.EditSingleClickUserFilter.TabIndex = 15;
      this.EditSingleClickUserFilter.Text = "Single click user filtering";
      this.EditSingleClickUserFilter.UseVisualStyleBackColor = true;
      // 
      // ActionDelete
      // 
      this.ActionDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ActionDelete.Location = new System.Drawing.Point(303, 37);
      this.ActionDelete.Name = "ActionDelete";
      this.ActionDelete.Size = new System.Drawing.Size(35, 23);
      this.ActionDelete.TabIndex = 14;
      this.ActionDelete.Text = "DEL";
      this.ActionDelete.UseVisualStyleBackColor = true;
      this.ActionDelete.Click += new System.EventHandler(this.ActionDelete_Click);
      // 
      // EditSearchInMessage
      // 
      this.EditSearchInMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.EditSearchInMessage.AutoSize = true;
      this.EditSearchInMessage.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.EditSearchInMessage.Checked = global::Ordisoftware.TweetsInspector.Properties.Settings.Default.SearchInMessage;
      this.EditSearchInMessage.CheckState = System.Windows.Forms.CheckState.Checked;
      this.EditSearchInMessage.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.TweetsInspector.Properties.Settings.Default, "SearchInMessage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditSearchInMessage.Location = new System.Drawing.Point(737, 48);
      this.EditSearchInMessage.Name = "EditSearchInMessage";
      this.EditSearchInMessage.Size = new System.Drawing.Size(116, 17);
      this.EditSearchInMessage.TabIndex = 13;
      this.EditSearchInMessage.Text = "Search in message";
      this.EditSearchInMessage.UseVisualStyleBackColor = true;
      this.EditSearchInMessage.CheckedChanged += new System.EventHandler(this.EditSearchInRecipients_CheckedChanged);
      // 
      // EditSearchInRecipients
      // 
      this.EditSearchInRecipients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.EditSearchInRecipients.AutoSize = true;
      this.EditSearchInRecipients.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.EditSearchInRecipients.Checked = global::Ordisoftware.TweetsInspector.Properties.Settings.Default.SearchInRecipients;
      this.EditSearchInRecipients.CheckState = System.Windows.Forms.CheckState.Checked;
      this.EditSearchInRecipients.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.TweetsInspector.Properties.Settings.Default, "SearchInRecipients", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditSearchInRecipients.Location = new System.Drawing.Point(745, 32);
      this.EditSearchInRecipients.Name = "EditSearchInRecipients";
      this.EditSearchInRecipients.Size = new System.Drawing.Size(108, 17);
      this.EditSearchInRecipients.TabIndex = 13;
      this.EditSearchInRecipients.Text = "Search recipients";
      this.EditSearchInRecipients.UseVisualStyleBackColor = true;
      this.EditSearchInRecipients.CheckedChanged += new System.EventHandler(this.EditSearchInRecipients_CheckedChanged);
      // 
      // ActionGetLikes
      // 
      this.ActionGetLikes.Enabled = false;
      this.ActionGetLikes.Location = new System.Drawing.Point(245, 6);
      this.ActionGetLikes.Name = "ActionGetLikes";
      this.ActionGetLikes.Size = new System.Drawing.Size(75, 23);
      this.ActionGetLikes.TabIndex = 12;
      this.ActionGetLikes.Text = "Likes";
      this.ActionGetLikes.UseVisualStyleBackColor = true;
      this.ActionGetLikes.Click += new System.EventHandler(this.ActionGetLikes_Click);
      // 
      // ActionSelectAll
      // 
      this.ActionSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ActionSelectAll.Location = new System.Drawing.Point(245, 37);
      this.ActionSelectAll.Name = "ActionSelectAll";
      this.ActionSelectAll.Size = new System.Drawing.Size(23, 23);
      this.ActionSelectAll.TabIndex = 10;
      this.ActionSelectAll.Text = "+";
      this.ActionSelectAll.UseVisualStyleBackColor = true;
      this.ActionSelectAll.Click += new System.EventHandler(this.ActionSelectAll_Click);
      // 
      // ActionSelectNone
      // 
      this.ActionSelectNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ActionSelectNone.Location = new System.Drawing.Point(274, 37);
      this.ActionSelectNone.Name = "ActionSelectNone";
      this.ActionSelectNone.Size = new System.Drawing.Size(23, 23);
      this.ActionSelectNone.TabIndex = 11;
      this.ActionSelectNone.Text = "-";
      this.ActionSelectNone.UseVisualStyleBackColor = true;
      this.ActionSelectNone.Click += new System.EventHandler(this.ActionSelectNone_Click);
      // 
      // ActionFilterClear
      // 
      this.ActionFilterClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ActionFilterClear.Location = new System.Drawing.Point(216, 37);
      this.ActionFilterClear.Name = "ActionFilterClear";
      this.ActionFilterClear.Size = new System.Drawing.Size(23, 23);
      this.ActionFilterClear.TabIndex = 9;
      this.ActionFilterClear.Text = "X";
      this.ActionFilterClear.UseVisualStyleBackColor = true;
      this.ActionFilterClear.Click += new System.EventHandler(this.ActionFilterClear_Click);
      // 
      // EditDeleteOnlyLocal
      // 
      this.EditDeleteOnlyLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.EditDeleteOnlyLocal.AutoSize = true;
      this.EditDeleteOnlyLocal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.EditDeleteOnlyLocal.Checked = global::Ordisoftware.TweetsInspector.Properties.Settings.Default.DeleteOnlyLocalMode;
      this.EditDeleteOnlyLocal.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.TweetsInspector.Properties.Settings.Default, "DeleteOnlyLocalMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditDeleteOnlyLocal.Location = new System.Drawing.Point(720, 0);
      this.EditDeleteOnlyLocal.Name = "EditDeleteOnlyLocal";
      this.EditDeleteOnlyLocal.Size = new System.Drawing.Size(133, 17);
      this.EditDeleteOnlyLocal.TabIndex = 4;
      this.EditDeleteOnlyLocal.Text = "Delete only local mode";
      this.EditDeleteOnlyLocal.UseVisualStyleBackColor = true;
      // 
      // EditSearch
      // 
      this.EditSearch.Location = new System.Drawing.Point(3, 38);
      this.EditSearch.Name = "EditSearch";
      this.EditSearch.Size = new System.Drawing.Size(207, 20);
      this.EditSearch.TabIndex = 2;
      this.EditSearch.TextChanged += new System.EventHandler(this.EditSearch_TextChanged);
      // 
      // ActionConnect
      // 
      this.ActionConnect.Location = new System.Drawing.Point(3, 6);
      this.ActionConnect.Name = "ActionConnect";
      this.ActionConnect.Size = new System.Drawing.Size(75, 23);
      this.ActionConnect.TabIndex = 0;
      this.ActionConnect.Text = "Connect";
      this.ActionConnect.UseVisualStyleBackColor = true;
      this.ActionConnect.Click += new System.EventHandler(this.ActionConnect_Click);
      // 
      // ActionLoadFromJS
      // 
      this.ActionLoadFromJS.Location = new System.Drawing.Point(84, 6);
      this.ActionLoadFromJS.Name = "ActionLoadFromJS";
      this.ActionLoadFromJS.Size = new System.Drawing.Size(75, 23);
      this.ActionLoadFromJS.TabIndex = 0;
      this.ActionLoadFromJS.Text = "Load JS";
      this.ActionLoadFromJS.UseVisualStyleBackColor = true;
      this.ActionLoadFromJS.Click += new System.EventHandler(this.ActionLoadFromJS_Click);
      // 
      // ActionSaveToCSV
      // 
      this.ActionSaveToCSV.Location = new System.Drawing.Point(165, 6);
      this.ActionSaveToCSV.Name = "ActionSaveToCSV";
      this.ActionSaveToCSV.Size = new System.Drawing.Size(75, 23);
      this.ActionSaveToCSV.TabIndex = 0;
      this.ActionSaveToCSV.Text = "Save CSV";
      this.ActionSaveToCSV.UseVisualStyleBackColor = true;
      this.ActionSaveToCSV.Click += new System.EventHandler(this.ActionSaveToCSV_Click);
      // 
      // TabPageDestroyed
      // 
      this.TabPageDestroyed.Controls.Add(this.ListTweetsTrash);
      this.TabPageDestroyed.Location = new System.Drawing.Point(4, 25);
      this.TabPageDestroyed.Name = "TabPageDestroyed";
      this.TabPageDestroyed.Padding = new System.Windows.Forms.Padding(3);
      this.TabPageDestroyed.Size = new System.Drawing.Size(856, 538);
      this.TabPageDestroyed.TabIndex = 3;
      this.TabPageDestroyed.Text = "Trash";
      this.TabPageDestroyed.UseVisualStyleBackColor = true;
      // 
      // ListTweetsTrash
      // 
      this.ListTweetsTrash.DefaultFilter = null;
      this.ListTweetsTrash.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ListTweetsTrash.Location = new System.Drawing.Point(3, 3);
      this.ListTweetsTrash.MinimumSize = new System.Drawing.Size(600, 120);
      this.ListTweetsTrash.Name = "ListTweetsTrash";
      this.ListTweetsTrash.Size = new System.Drawing.Size(850, 532);
      this.ListTweetsTrash.TabIndex = 0;
      this.ListTweetsTrash.Title = "DESTROYED";
      // 
      // TabPageMessages
      // 
      this.TabPageMessages.BackColor = System.Drawing.SystemColors.Control;
      this.TabPageMessages.Controls.Add(this.ActionOpenMessages);
      this.TabPageMessages.Controls.Add(this.EditUser1);
      this.TabPageMessages.Controls.Add(this.EditUser2);
      this.TabPageMessages.Controls.Add(this.EditMessagesSource);
      this.TabPageMessages.Controls.Add(this.EditMessagesCleaned);
      this.TabPageMessages.Location = new System.Drawing.Point(4, 25);
      this.TabPageMessages.Name = "TabPageMessages";
      this.TabPageMessages.Padding = new System.Windows.Forms.Padding(3);
      this.TabPageMessages.Size = new System.Drawing.Size(856, 538);
      this.TabPageMessages.TabIndex = 0;
      this.TabPageMessages.Text = "Messages";
      // 
      // TabPageUsers
      // 
      this.TabPageUsers.Controls.Add(this.EditUsers);
      this.TabPageUsers.Controls.Add(this.ActionGetFellowing);
      this.TabPageUsers.Controls.Add(this.ActionGetMutes);
      this.TabPageUsers.Controls.Add(this.ActionGetBlocks);
      this.TabPageUsers.Controls.Add(this.ActionGetFollowers);
      this.TabPageUsers.Location = new System.Drawing.Point(4, 25);
      this.TabPageUsers.Name = "TabPageUsers";
      this.TabPageUsers.Padding = new System.Windows.Forms.Padding(3);
      this.TabPageUsers.Size = new System.Drawing.Size(856, 538);
      this.TabPageUsers.TabIndex = 4;
      this.TabPageUsers.Text = "Users";
      this.TabPageUsers.UseVisualStyleBackColor = true;
      // 
      // EditUsers
      // 
      this.EditUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.EditUsers.Location = new System.Drawing.Point(105, 15);
      this.EditUsers.Name = "EditUsers";
      this.EditUsers.SelectionAlignment = Ordisoftware.Core.TextAlign.Left;
      this.EditUsers.Size = new System.Drawing.Size(735, 507);
      this.EditUsers.TabIndex = 9;
      this.EditUsers.Text = "";
      // 
      // ActionGetFellowing
      // 
      this.ActionGetFellowing.Location = new System.Drawing.Point(15, 15);
      this.ActionGetFellowing.Name = "ActionGetFellowing";
      this.ActionGetFellowing.Size = new System.Drawing.Size(75, 23);
      this.ActionGetFellowing.TabIndex = 8;
      this.ActionGetFellowing.Text = "Fellowing";
      this.ActionGetFellowing.UseVisualStyleBackColor = true;
      this.ActionGetFellowing.Click += new System.EventHandler(this.ActionGetFellowing_Click);
      // 
      // ActionGetMutes
      // 
      this.ActionGetMutes.Location = new System.Drawing.Point(15, 83);
      this.ActionGetMutes.Name = "ActionGetMutes";
      this.ActionGetMutes.Size = new System.Drawing.Size(75, 23);
      this.ActionGetMutes.TabIndex = 8;
      this.ActionGetMutes.Text = "Mutes";
      this.ActionGetMutes.UseVisualStyleBackColor = true;
      this.ActionGetMutes.Click += new System.EventHandler(this.ActionGetMutes_Click);
      // 
      // ActionGetBlocks
      // 
      this.ActionGetBlocks.Location = new System.Drawing.Point(15, 117);
      this.ActionGetBlocks.Name = "ActionGetBlocks";
      this.ActionGetBlocks.Size = new System.Drawing.Size(75, 23);
      this.ActionGetBlocks.TabIndex = 8;
      this.ActionGetBlocks.Text = "Blocks";
      this.ActionGetBlocks.UseVisualStyleBackColor = true;
      this.ActionGetBlocks.Click += new System.EventHandler(this.ActionGetBlocks_Click);
      // 
      // ActionGetFollowers
      // 
      this.ActionGetFollowers.Location = new System.Drawing.Point(15, 49);
      this.ActionGetFollowers.Name = "ActionGetFollowers";
      this.ActionGetFollowers.Size = new System.Drawing.Size(75, 23);
      this.ActionGetFollowers.TabIndex = 8;
      this.ActionGetFollowers.Text = "Followers";
      this.ActionGetFollowers.UseVisualStyleBackColor = true;
      this.ActionGetFollowers.Click += new System.EventHandler(this.ActionGetFollowers_Click);
      // 
      // TabPageSettings
      // 
      this.TabPageSettings.Controls.Add(this.SelectStartupConnectAction);
      this.TabPageSettings.Controls.Add(LabelConsumerSecret);
      this.TabPageSettings.Controls.Add(this.EditConsumerSecret);
      this.TabPageSettings.Controls.Add(LabelStartupConnectAction);
      this.TabPageSettings.Controls.Add(LabelConsumerKey);
      this.TabPageSettings.Controls.Add(this.EditConsumerKey);
      this.TabPageSettings.Controls.Add(LabelConsumerBackUrl);
      this.TabPageSettings.Controls.Add(this.EditConsumerBackUrl);
      this.TabPageSettings.Location = new System.Drawing.Point(4, 25);
      this.TabPageSettings.Name = "TabPageSettings";
      this.TabPageSettings.Padding = new System.Windows.Forms.Padding(3);
      this.TabPageSettings.Size = new System.Drawing.Size(856, 538);
      this.TabPageSettings.TabIndex = 2;
      this.TabPageSettings.Text = "Settings";
      this.TabPageSettings.UseVisualStyleBackColor = true;
      // 
      // SelectStartupConnectAction
      // 
      this.SelectStartupConnectAction.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.SettingsBindingSource, "StartupConnectAction", true));
      this.SelectStartupConnectAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.SelectStartupConnectAction.FormattingEnabled = true;
      this.SelectStartupConnectAction.Location = new System.Drawing.Point(23, 39);
      this.SelectStartupConnectAction.Name = "SelectStartupConnectAction";
      this.SelectStartupConnectAction.Size = new System.Drawing.Size(121, 21);
      this.SelectStartupConnectAction.TabIndex = 6;
      // 
      // SettingsBindingSource
      // 
      this.SettingsBindingSource.DataSource = typeof(System.Configuration.ApplicationSettingsBase);
      // 
      // EditConsumerSecret
      // 
      this.EditConsumerSecret.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SettingsBindingSource, "ConsumerSecret", true));
      this.EditConsumerSecret.Location = new System.Drawing.Point(23, 139);
      this.EditConsumerSecret.Name = "EditConsumerSecret";
      this.EditConsumerSecret.Size = new System.Drawing.Size(395, 20);
      this.EditConsumerSecret.TabIndex = 5;
      // 
      // EditConsumerKey
      // 
      this.EditConsumerKey.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SettingsBindingSource, "ConsumerKey", true));
      this.EditConsumerKey.Location = new System.Drawing.Point(23, 94);
      this.EditConsumerKey.Name = "EditConsumerKey";
      this.EditConsumerKey.Size = new System.Drawing.Size(395, 20);
      this.EditConsumerKey.TabIndex = 3;
      // 
      // EditConsumerBackUrl
      // 
      this.EditConsumerBackUrl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SettingsBindingSource, "ConsumerBackUrl", true));
      this.EditConsumerBackUrl.Location = new System.Drawing.Point(23, 184);
      this.EditConsumerBackUrl.Name = "EditConsumerBackUrl";
      this.EditConsumerBackUrl.Size = new System.Drawing.Size(395, 20);
      this.EditConsumerBackUrl.TabIndex = 1;
      // 
      // StatusStrip
      // 
      this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelCountTweetsMain,
            this.LabelCountTweetsMainValue,
            this.LabelCountTweetsReplies,
            this.LabelCountTweetsRepliesValue,
            this.LabelCountTweetsRTs,
            this.LabelCountTweetsRTsValue,
            this.LabelCountAllRecipients,
            this.LabelCountAllRecipientsValue});
      this.StatusStrip.Location = new System.Drawing.Point(0, 587);
      this.StatusStrip.Name = "StatusStrip";
      this.StatusStrip.Size = new System.Drawing.Size(884, 24);
      this.StatusStrip.TabIndex = 4;
      this.StatusStrip.Text = "statusStrip1";
      // 
      // LabelCountTweetsMain
      // 
      this.LabelCountTweetsMain.Name = "LabelCountTweetsMain";
      this.LabelCountTweetsMain.Size = new System.Drawing.Size(48, 19);
      this.LabelCountTweetsMain.Text = "Tweets :";
      // 
      // LabelCountTweetsMainValue
      // 
      this.LabelCountTweetsMainValue.Name = "LabelCountTweetsMainValue";
      this.LabelCountTweetsMainValue.Size = new System.Drawing.Size(13, 19);
      this.LabelCountTweetsMainValue.Text = "0";
      // 
      // LabelCountTweetsReplies
      // 
      this.LabelCountTweetsReplies.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
      this.LabelCountTweetsReplies.Name = "LabelCountTweetsReplies";
      this.LabelCountTweetsReplies.Size = new System.Drawing.Size(54, 19);
      this.LabelCountTweetsReplies.Text = "Replies :";
      // 
      // LabelCountTweetsRepliesValue
      // 
      this.LabelCountTweetsRepliesValue.Name = "LabelCountTweetsRepliesValue";
      this.LabelCountTweetsRepliesValue.Size = new System.Drawing.Size(13, 19);
      this.LabelCountTweetsRepliesValue.Text = "0";
      // 
      // LabelCountTweetsRTs
      // 
      this.LabelCountTweetsRTs.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
      this.LabelCountTweetsRTs.Name = "LabelCountTweetsRTs";
      this.LabelCountTweetsRTs.Size = new System.Drawing.Size(33, 19);
      this.LabelCountTweetsRTs.Text = "RTs :";
      // 
      // LabelCountTweetsRTsValue
      // 
      this.LabelCountTweetsRTsValue.Name = "LabelCountTweetsRTsValue";
      this.LabelCountTweetsRTsValue.Size = new System.Drawing.Size(13, 19);
      this.LabelCountTweetsRTsValue.Text = "0";
      // 
      // LabelCountAllRecipients
      // 
      this.LabelCountAllRecipients.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
      this.LabelCountAllRecipients.Name = "LabelCountAllRecipients";
      this.LabelCountAllRecipients.Size = new System.Drawing.Size(71, 19);
      this.LabelCountAllRecipients.Text = "Recipients :";
      // 
      // LabelCountAllRecipientsValue
      // 
      this.LabelCountAllRecipientsValue.Name = "LabelCountAllRecipientsValue";
      this.LabelCountAllRecipientsValue.Size = new System.Drawing.Size(13, 19);
      this.LabelCountAllRecipientsValue.Text = "0";
      // 
      // PanelMain
      // 
      this.PanelMain.Controls.Add(this.TabControl);
      this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.PanelMain.Location = new System.Drawing.Point(0, 0);
      this.PanelMain.Name = "PanelMain";
      this.PanelMain.Padding = new System.Windows.Forms.Padding(10);
      this.PanelMain.Size = new System.Drawing.Size(884, 587);
      this.PanelMain.TabIndex = 5;
      // 
      // DataSet
      // 
      this.DataSet.DataSetName = "DataSet";
      this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // TweetsBindingSourceMain
      // 
      this.TweetsBindingSourceMain.DataMember = "Tweets";
      this.TweetsBindingSourceMain.DataSource = this.DataSet;
      // 
      // TweetsTableAdapter
      // 
      this.TweetsTableAdapter.ClearBeforeFill = true;
      // 
      // TableAdapterManager
      // 
      this.TableAdapterManager.AutoDeleteTableAdapter = null;
      this.TableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.TableAdapterManager.FollowersTableAdapter = null;
      this.TableAdapterManager.FollowingTableAdapter = null;
      this.TableAdapterManager.TrashTableAdapter = null;
      this.TableAdapterManager.TweetsTableAdapter = this.TweetsTableAdapter;
      this.TableAdapterManager.UpdateOrder = Ordisoftware.TweetsInspector.Data.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // TweetsBindingSourceReplies
      // 
      this.TweetsBindingSourceReplies.DataMember = "Tweets";
      this.TweetsBindingSourceReplies.DataSource = this.DataSet;
      // 
      // TweetsBindingSourceRTs
      // 
      this.TweetsBindingSourceRTs.DataMember = "Tweets";
      this.TweetsBindingSourceRTs.DataSource = this.DataSet;
      // 
      // TrashBindingSource
      // 
      this.TrashBindingSource.DataMember = "Trash";
      this.TrashBindingSource.DataSource = this.DataSet;
      // 
      // TrashTableAdapter
      // 
      this.TrashTableAdapter.ClearBeforeFill = true;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(884, 611);
      this.Controls.Add(this.PanelMain);
      this.Controls.Add(this.StatusStrip);
      this.MinimumSize = new System.Drawing.Size(800, 600);
      this.Name = "MainForm";
      this.Text = "Tweets Inspector";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.Shown += new System.EventHandler(this.MainForm_Shown);
      this.TabControl.ResumeLayout(false);
      this.TabPageTweets.ResumeLayout(false);
      this.SplitContainerMain.Panel1.ResumeLayout(false);
      this.SplitContainerMain.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.SplitContainerMain)).EndInit();
      this.SplitContainerMain.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUsers)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource)).EndInit();
      this.PanelFilterUsers.ResumeLayout(false);
      this.PanelFilterUsers.PerformLayout();
      this.PanelTweetsTop.ResumeLayout(false);
      this.PanelTweetsTop.PerformLayout();
      this.TabPageDestroyed.ResumeLayout(false);
      this.TabPageMessages.ResumeLayout(false);
      this.TabPageMessages.PerformLayout();
      this.TabPageUsers.ResumeLayout(false);
      this.TabPageSettings.ResumeLayout(false);
      this.TabPageSettings.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.SettingsBindingSource)).EndInit();
      this.StatusStrip.ResumeLayout(false);
      this.StatusStrip.PerformLayout();
      this.PanelMain.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.TweetsBindingSourceMain)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.TweetsBindingSourceReplies)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.TweetsBindingSourceRTs)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.TrashBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button ActionOpenMessages;
    private System.Windows.Forms.OpenFileDialog OpenFileDialogJS;
    private System.Windows.Forms.TextBox EditUser1;
    private System.Windows.Forms.TextBox EditUser2;
    private System.Windows.Forms.TextBox EditMessagesCleaned;
    private System.Windows.Forms.TextBox EditMessagesSource;
    private System.Windows.Forms.TabControl TabControl;
    private System.Windows.Forms.TabPage TabPageMessages;
    private System.Windows.Forms.TabPage TabPageTweets;
    private System.Windows.Forms.Panel PanelTweetsTop;
    private System.Windows.Forms.Button ActionSaveToCSV;
    private System.Windows.Forms.Button ActionConnect;
    private System.Windows.Forms.Button ActionLoadFromJS;
    private System.Windows.Forms.SplitContainer SplitContainerMain;
    private System.Windows.Forms.TextBox EditSearch;
    private TweetsControl TweetsControl;
    private System.Windows.Forms.CheckBox EditDeleteOnlyLocal;
    private System.Windows.Forms.Button ActionGetFollowers;
    private System.Windows.Forms.Button ActionGetFellowing;
    private System.Windows.Forms.StatusStrip StatusStrip;
    private System.Windows.Forms.ToolStripStatusLabel LabelCountTweetsMain;
    private System.Windows.Forms.ToolStripStatusLabel LabelCountTweetsMainValue;
    private System.Windows.Forms.ToolStripStatusLabel LabelCountTweetsReplies;
    private System.Windows.Forms.ToolStripStatusLabel LabelCountTweetsRepliesValue;
    private System.Windows.Forms.ToolStripStatusLabel LabelCountTweetsRTs;
    private System.Windows.Forms.ToolStripStatusLabel LabelCountTweetsRTsValue;
    private System.Windows.Forms.ToolStripStatusLabel LabelCountAllRecipients;
    private System.Windows.Forms.ToolStripStatusLabel LabelCountAllRecipientsValue;
    private System.Windows.Forms.Panel PanelMain;
    internal Data.DataSet DataSet;
    internal System.Windows.Forms.BindingSource TweetsBindingSourceMain;
    internal System.Windows.Forms.BindingSource TweetsBindingSourceReplies;
    internal System.Windows.Forms.BindingSource TweetsBindingSourceRTs;
    internal Data.DataSetTableAdapters.TweetsTableAdapter TweetsTableAdapter;
    internal Data.DataSetTableAdapters.TableAdapterManager TableAdapterManager;
    private System.Windows.Forms.Button ActionFilterClear;
    public System.Windows.Forms.Button ActionSelectAll;
    public System.Windows.Forms.Button ActionSelectNone;
    private System.Windows.Forms.Button ActionGetLikes;
    internal System.Windows.Forms.CheckBox EditSearchInRecipients;
    internal System.Windows.Forms.CheckBox EditSearchInMessage;
    public System.Windows.Forms.Button ActionDelete;
    private System.Windows.Forms.TabPage TabPageSettings;
    private System.Windows.Forms.TextBox EditConsumerSecret;
    private System.Windows.Forms.BindingSource SettingsBindingSource;
    private System.Windows.Forms.TextBox EditConsumerKey;
    private System.Windows.Forms.TextBox EditConsumerBackUrl;
    private System.Windows.Forms.Panel PanelFilterUsers;
    public System.Windows.Forms.Button ActionFilterUsersClear;
    public System.Windows.Forms.TextBox EditFilterUsers;
    private System.Windows.Forms.BindingSource UsersBindingSource;
    private System.Windows.Forms.Panel panel1;
    public System.Windows.Forms.DataGridView DataGridViewUsers;
    private System.Windows.Forms.CheckBox EditSingleClickUserFilter;
    private System.Windows.Forms.Button ActionCheckOnlineDestroyed;
    private System.Windows.Forms.TabPage TabPageDestroyed;
    private ListTweets ListTweetsTrash;
    private System.Windows.Forms.BindingSource TrashBindingSource;
    private Data.DataSetTableAdapters.TrashTableAdapter TrashTableAdapter;
    private System.Windows.Forms.ComboBox SelectStartupConnectAction;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserName;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserCount;
    private System.Windows.Forms.Button ActionGetMutes;
    private System.Windows.Forms.Button ActionGetBlocks;
    private System.Windows.Forms.TabPage TabPageUsers;
    private Core.RichTextBoxEx EditUsers;
  }
}
