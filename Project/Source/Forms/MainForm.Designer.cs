﻿namespace Ordisoftware.TweetsInspector
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
      this.ActionOpenMessages = new System.Windows.Forms.Button();
      this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.EditUser1 = new System.Windows.Forms.TextBox();
      this.EditUser2 = new System.Windows.Forms.TextBox();
      this.EditMessagesCleaned = new System.Windows.Forms.TextBox();
      this.EditMessagesSource = new System.Windows.Forms.TextBox();
      this.TabControl = new System.Windows.Forms.TabControl();
      this.TabPageTweets = new System.Windows.Forms.TabPage();
      this.SplitContainerMain = new System.Windows.Forms.SplitContainer();
      this.TweetsControl = new Ordisoftware.TweetsInspector.TweetsControl();
      this.ListBoxAllRecipients = new System.Windows.Forms.ListBox();
      this.PanelTweetsTop = new System.Windows.Forms.Panel();
      this.ActionDelete = new System.Windows.Forms.Button();
      this.EditSearchInMessage = new System.Windows.Forms.CheckBox();
      this.EditSearchUser = new System.Windows.Forms.CheckBox();
      this.ActionGetLikes = new System.Windows.Forms.Button();
      this.ActionSelectAll = new System.Windows.Forms.Button();
      this.ActionSelectNone = new System.Windows.Forms.Button();
      this.ActionFilterClear = new System.Windows.Forms.Button();
      this.ActionGetFellowing = new System.Windows.Forms.Button();
      this.ActionGetFollowers = new System.Windows.Forms.Button();
      this.EditDeleteOnlyLocal = new System.Windows.Forms.CheckBox();
      this.EditSearch = new System.Windows.Forms.TextBox();
      this.ActionConnect = new System.Windows.Forms.Button();
      this.ActionLoadFromJS = new System.Windows.Forms.Button();
      this.ActionSaveToCSV = new System.Windows.Forms.Button();
      this.TabPageMessages = new System.Windows.Forms.TabPage();
      this.TabPageSettings = new System.Windows.Forms.TabPage();
      this.EditConnectAtStartup = new System.Windows.Forms.CheckBox();
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
      LabelConsumerBackUrl = new System.Windows.Forms.Label();
      LabelConsumerKey = new System.Windows.Forms.Label();
      LabelConsumerSecret = new System.Windows.Forms.Label();
      this.TabControl.SuspendLayout();
      this.TabPageTweets.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.SplitContainerMain)).BeginInit();
      this.SplitContainerMain.Panel1.SuspendLayout();
      this.SplitContainerMain.Panel2.SuspendLayout();
      this.SplitContainerMain.SuspendLayout();
      this.PanelTweetsTop.SuspendLayout();
      this.TabPageMessages.SuspendLayout();
      this.TabPageSettings.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.SettingsBindingSource)).BeginInit();
      this.StatusStrip.SuspendLayout();
      this.PanelMain.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.TweetsBindingSourceMain)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.TweetsBindingSourceReplies)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.TweetsBindingSourceRTs)).BeginInit();
      this.SuspendLayout();
      // 
      // LabelConsumerBackUrl
      // 
      LabelConsumerBackUrl.AutoSize = true;
      LabelConsumerBackUrl.Location = new System.Drawing.Point(20, 125);
      LabelConsumerBackUrl.Name = "LabelConsumerBackUrl";
      LabelConsumerBackUrl.Size = new System.Drawing.Size(51, 13);
      LabelConsumerBackUrl.TabIndex = 0;
      LabelConsumerBackUrl.Text = "Back Url:";
      // 
      // LabelConsumerKey
      // 
      LabelConsumerKey.AutoSize = true;
      LabelConsumerKey.Location = new System.Drawing.Point(20, 55);
      LabelConsumerKey.Name = "LabelConsumerKey";
      LabelConsumerKey.Size = new System.Drawing.Size(78, 13);
      LabelConsumerKey.TabIndex = 2;
      LabelConsumerKey.Text = "Consumer Key:";
      // 
      // LabelConsumerSecret
      // 
      LabelConsumerSecret.AutoSize = true;
      LabelConsumerSecret.Location = new System.Drawing.Point(20, 90);
      LabelConsumerSecret.Name = "LabelConsumerSecret";
      LabelConsumerSecret.Size = new System.Drawing.Size(91, 13);
      LabelConsumerSecret.TabIndex = 4;
      LabelConsumerSecret.Text = "Consumer Secret:";
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
      this.TabControl.Controls.Add(this.TabPageMessages);
      this.TabControl.Controls.Add(this.TabPageSettings);
      this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TabControl.Location = new System.Drawing.Point(10, 10);
      this.TabControl.Name = "TabControl";
      this.TabControl.SelectedIndex = 0;
      this.TabControl.Size = new System.Drawing.Size(964, 617);
      this.TabControl.TabIndex = 3;
      // 
      // TabPageTweets
      // 
      this.TabPageTweets.BackColor = System.Drawing.SystemColors.Control;
      this.TabPageTweets.Controls.Add(this.SplitContainerMain);
      this.TabPageTweets.Controls.Add(this.PanelTweetsTop);
      this.TabPageTweets.Location = new System.Drawing.Point(4, 25);
      this.TabPageTweets.Name = "TabPageTweets";
      this.TabPageTweets.Size = new System.Drawing.Size(956, 590);
      this.TabPageTweets.TabIndex = 1;
      this.TabPageTweets.Text = "Tweets";
      // 
      // SplitContainerMain
      // 
      this.SplitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SplitContainerMain.Location = new System.Drawing.Point(0, 65);
      this.SplitContainerMain.Name = "SplitContainerMain";
      // 
      // SplitContainerMain.Panel1
      // 
      this.SplitContainerMain.Panel1.Controls.Add(this.TweetsControl);
      // 
      // SplitContainerMain.Panel2
      // 
      this.SplitContainerMain.Panel2.Controls.Add(this.ListBoxAllRecipients);
      this.SplitContainerMain.Size = new System.Drawing.Size(956, 525);
      this.SplitContainerMain.SplitterDistance = 838;
      this.SplitContainerMain.SplitterWidth = 10;
      this.SplitContainerMain.TabIndex = 9;
      // 
      // TweetsControl
      // 
      this.TweetsControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TweetsControl.Location = new System.Drawing.Point(0, 0);
      this.TweetsControl.Name = "TweetsControl";
      this.TweetsControl.Size = new System.Drawing.Size(838, 525);
      this.TweetsControl.TabIndex = 0;
      // 
      // ListBoxAllRecipients
      // 
      this.ListBoxAllRecipients.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ListBoxAllRecipients.FormattingEnabled = true;
      this.ListBoxAllRecipients.IntegralHeight = false;
      this.ListBoxAllRecipients.Location = new System.Drawing.Point(0, 0);
      this.ListBoxAllRecipients.Name = "ListBoxAllRecipients";
      this.ListBoxAllRecipients.Size = new System.Drawing.Size(108, 525);
      this.ListBoxAllRecipients.TabIndex = 11;
      this.ListBoxAllRecipients.DoubleClick += new System.EventHandler(this.ListBoxAllRecipients_DoubleClick);
      // 
      // PanelTweetsTop
      // 
      this.PanelTweetsTop.AutoScroll = true;
      this.PanelTweetsTop.Controls.Add(this.ActionDelete);
      this.PanelTweetsTop.Controls.Add(this.EditSearchInMessage);
      this.PanelTweetsTop.Controls.Add(this.EditSearchUser);
      this.PanelTweetsTop.Controls.Add(this.ActionGetLikes);
      this.PanelTweetsTop.Controls.Add(this.ActionSelectAll);
      this.PanelTweetsTop.Controls.Add(this.ActionSelectNone);
      this.PanelTweetsTop.Controls.Add(this.ActionFilterClear);
      this.PanelTweetsTop.Controls.Add(this.ActionGetFellowing);
      this.PanelTweetsTop.Controls.Add(this.ActionGetFollowers);
      this.PanelTweetsTop.Controls.Add(this.EditDeleteOnlyLocal);
      this.PanelTweetsTop.Controls.Add(this.EditSearch);
      this.PanelTweetsTop.Controls.Add(this.ActionConnect);
      this.PanelTweetsTop.Controls.Add(this.ActionLoadFromJS);
      this.PanelTweetsTop.Controls.Add(this.ActionSaveToCSV);
      this.PanelTweetsTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.PanelTweetsTop.Location = new System.Drawing.Point(0, 0);
      this.PanelTweetsTop.Name = "PanelTweetsTop";
      this.PanelTweetsTop.Size = new System.Drawing.Size(956, 65);
      this.PanelTweetsTop.TabIndex = 5;
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
      this.EditSearchInMessage.Location = new System.Drawing.Point(837, 43);
      this.EditSearchInMessage.Name = "EditSearchInMessage";
      this.EditSearchInMessage.Size = new System.Drawing.Size(116, 17);
      this.EditSearchInMessage.TabIndex = 13;
      this.EditSearchInMessage.Text = "Search in message";
      this.EditSearchInMessage.UseVisualStyleBackColor = true;
      this.EditSearchInMessage.CheckedChanged += new System.EventHandler(this.EditSearch_CheckedChanged);
      // 
      // EditSearchUser
      // 
      this.EditSearchUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.EditSearchUser.AutoSize = true;
      this.EditSearchUser.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.EditSearchUser.Checked = global::Ordisoftware.TweetsInspector.Properties.Settings.Default.SearchUser;
      this.EditSearchUser.CheckState = System.Windows.Forms.CheckState.Checked;
      this.EditSearchUser.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.TweetsInspector.Properties.Settings.Default, "SearchUser", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditSearchUser.Location = new System.Drawing.Point(841, 26);
      this.EditSearchUser.Name = "EditSearchUser";
      this.EditSearchUser.Size = new System.Drawing.Size(112, 17);
      this.EditSearchUser.TabIndex = 13;
      this.EditSearchUser.Text = "Search user name";
      this.EditSearchUser.UseVisualStyleBackColor = true;
      this.EditSearchUser.CheckedChanged += new System.EventHandler(this.EditSearch_CheckedChanged);
      // 
      // ActionGetLikes
      // 
      this.ActionGetLikes.Location = new System.Drawing.Point(408, 6);
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
      // ActionGetFellowing
      // 
      this.ActionGetFellowing.Location = new System.Drawing.Point(246, 6);
      this.ActionGetFellowing.Name = "ActionGetFellowing";
      this.ActionGetFellowing.Size = new System.Drawing.Size(75, 23);
      this.ActionGetFellowing.TabIndex = 8;
      this.ActionGetFellowing.Text = "Fellowing";
      this.ActionGetFellowing.UseVisualStyleBackColor = true;
      this.ActionGetFellowing.Click += new System.EventHandler(this.ActionGetFellowing_Click);
      // 
      // ActionGetFollowers
      // 
      this.ActionGetFollowers.Location = new System.Drawing.Point(327, 6);
      this.ActionGetFollowers.Name = "ActionGetFollowers";
      this.ActionGetFollowers.Size = new System.Drawing.Size(75, 23);
      this.ActionGetFollowers.TabIndex = 8;
      this.ActionGetFollowers.Text = "Followers";
      this.ActionGetFollowers.UseVisualStyleBackColor = true;
      this.ActionGetFollowers.Click += new System.EventHandler(this.ActionGetFollowers_Click);
      // 
      // EditDeleteOnlyLocal
      // 
      this.EditDeleteOnlyLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.EditDeleteOnlyLocal.AutoSize = true;
      this.EditDeleteOnlyLocal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.EditDeleteOnlyLocal.Checked = global::Ordisoftware.TweetsInspector.Properties.Settings.Default.DeleteOnlyLocalMode;
      this.EditDeleteOnlyLocal.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.TweetsInspector.Properties.Settings.Default, "DeleteOnlyLocalMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditDeleteOnlyLocal.Location = new System.Drawing.Point(820, 5);
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
      this.TabPageMessages.Size = new System.Drawing.Size(956, 588);
      this.TabPageMessages.TabIndex = 0;
      this.TabPageMessages.Text = "Messages";
      // 
      // TabPageSettings
      // 
      this.TabPageSettings.Controls.Add(this.EditConnectAtStartup);
      this.TabPageSettings.Controls.Add(LabelConsumerSecret);
      this.TabPageSettings.Controls.Add(this.EditConsumerSecret);
      this.TabPageSettings.Controls.Add(LabelConsumerKey);
      this.TabPageSettings.Controls.Add(this.EditConsumerKey);
      this.TabPageSettings.Controls.Add(LabelConsumerBackUrl);
      this.TabPageSettings.Controls.Add(this.EditConsumerBackUrl);
      this.TabPageSettings.Location = new System.Drawing.Point(4, 25);
      this.TabPageSettings.Name = "TabPageSettings";
      this.TabPageSettings.Padding = new System.Windows.Forms.Padding(3);
      this.TabPageSettings.Size = new System.Drawing.Size(956, 588);
      this.TabPageSettings.TabIndex = 2;
      this.TabPageSettings.Text = "Settings";
      this.TabPageSettings.UseVisualStyleBackColor = true;
      // 
      // EditConnectAtStartup
      // 
      this.EditConnectAtStartup.AutoSize = true;
      this.EditConnectAtStartup.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.SettingsBindingSource, "ConnectAtStartup", true));
      this.EditConnectAtStartup.Location = new System.Drawing.Point(23, 19);
      this.EditConnectAtStartup.Name = "EditConnectAtStartup";
      this.EditConnectAtStartup.Size = new System.Drawing.Size(160, 17);
      this.EditConnectAtStartup.TabIndex = 7;
      this.EditConnectAtStartup.Text = "Connect to Twitter at startup";
      this.EditConnectAtStartup.UseVisualStyleBackColor = true;
      // 
      // SettingsBindingSource
      // 
      this.SettingsBindingSource.DataSource = typeof(System.Configuration.ApplicationSettingsBase);
      // 
      // EditConsumerSecret
      // 
      this.EditConsumerSecret.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SettingsBindingSource, "ConsumerSecret", true));
      this.EditConsumerSecret.Location = new System.Drawing.Point(117, 86);
      this.EditConsumerSecret.Name = "EditConsumerSecret";
      this.EditConsumerSecret.Size = new System.Drawing.Size(395, 20);
      this.EditConsumerSecret.TabIndex = 5;
      // 
      // EditConsumerKey
      // 
      this.EditConsumerKey.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SettingsBindingSource, "ConsumerKey", true));
      this.EditConsumerKey.Location = new System.Drawing.Point(117, 51);
      this.EditConsumerKey.Name = "EditConsumerKey";
      this.EditConsumerKey.Size = new System.Drawing.Size(395, 20);
      this.EditConsumerKey.TabIndex = 3;
      // 
      // EditConsumerBackUrl
      // 
      this.EditConsumerBackUrl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SettingsBindingSource, "ConsumerBackUrl", true));
      this.EditConsumerBackUrl.Location = new System.Drawing.Point(117, 121);
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
      this.StatusStrip.Location = new System.Drawing.Point(0, 637);
      this.StatusStrip.Name = "StatusStrip";
      this.StatusStrip.Size = new System.Drawing.Size(984, 24);
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
      this.PanelMain.Size = new System.Drawing.Size(984, 637);
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
      this.TableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.TableAdapterManager.FollowersTableAdapter = null;
      this.TableAdapterManager.FollowingTableAdapter = null;
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
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(984, 661);
      this.Controls.Add(this.PanelMain);
      this.Controls.Add(this.StatusStrip);
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
      this.PanelTweetsTop.ResumeLayout(false);
      this.PanelTweetsTop.PerformLayout();
      this.TabPageMessages.ResumeLayout(false);
      this.TabPageMessages.PerformLayout();
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
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button ActionOpenMessages;
    private System.Windows.Forms.OpenFileDialog OpenFileDialog;
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
    private System.Windows.Forms.ListBox ListBoxAllRecipients;
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
    internal System.Windows.Forms.CheckBox EditSearchUser;
    internal System.Windows.Forms.CheckBox EditSearchInMessage;
    public System.Windows.Forms.Button ActionDelete;
    private System.Windows.Forms.TabPage TabPageSettings;
    private System.Windows.Forms.TextBox EditConsumerSecret;
    private System.Windows.Forms.BindingSource SettingsBindingSource;
    private System.Windows.Forms.TextBox EditConsumerKey;
    private System.Windows.Forms.TextBox EditConsumerBackUrl;
    private System.Windows.Forms.CheckBox EditConnectAtStartup;
  }
}
