namespace Ordisoftware.TwitterManager
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
      this.ActionOpenMessages = new System.Windows.Forms.Button();
      this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.EditUser1 = new System.Windows.Forms.TextBox();
      this.EditUser2 = new System.Windows.Forms.TextBox();
      this.EditMessagesCleaned = new System.Windows.Forms.TextBox();
      this.EditMessagesSource = new System.Windows.Forms.TextBox();
      this.TabControl = new System.Windows.Forms.TabControl();
      this.TabPageTweets = new System.Windows.Forms.TabPage();
      this.SplitContainerMain = new System.Windows.Forms.SplitContainer();
      this.ListBoxAllRecipients = new System.Windows.Forms.ListBox();
      this.PanelTweetsTop = new System.Windows.Forms.Panel();
      this.ActionGetFellowing = new System.Windows.Forms.Button();
      this.ActionGetFollowers = new System.Windows.Forms.Button();
      this.EditDeleteOnlyLocal = new System.Windows.Forms.CheckBox();
      this.EditSearch = new System.Windows.Forms.TextBox();
      this.ActionConnectTwitter = new System.Windows.Forms.Button();
      this.ActionLoadTweestFromJS = new System.Windows.Forms.Button();
      this.ActionSaveTweets = new System.Windows.Forms.Button();
      this.TabPageMessages = new System.Windows.Forms.TabPage();
      this.StatusStrip = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.LabelCountTweetsMain = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
      this.LabelCountTweetsReplies = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
      this.LabelCountTweetsRTs = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
      this.LabelCountAllRecipients = new System.Windows.Forms.ToolStripStatusLabel();
      this.PanelMain = new System.Windows.Forms.Panel();
      this.DataSet = new Ordisoftware.TwitterManager.Data.DataSet();
      this.TweetsBindingSourceMain = new System.Windows.Forms.BindingSource(this.components);
      this.TweetsTableAdapter = new Ordisoftware.TwitterManager.Data.DataSetTableAdapters.TweetsTableAdapter();
      this.TableAdapterManager = new Ordisoftware.TwitterManager.Data.DataSetTableAdapters.TableAdapterManager();
      this.TweetsBindingSourceReplies = new System.Windows.Forms.BindingSource(this.components);
      this.TweetsBindingSourceRTs = new System.Windows.Forms.BindingSource(this.components);
      this.TweetsControl = new Ordisoftware.TwitterManager.TweetsControl();
      this.ActionFilterClear = new System.Windows.Forms.Button();
      this.TabControl.SuspendLayout();
      this.TabPageTweets.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.SplitContainerMain)).BeginInit();
      this.SplitContainerMain.Panel1.SuspendLayout();
      this.SplitContainerMain.Panel2.SuspendLayout();
      this.SplitContainerMain.SuspendLayout();
      this.PanelTweetsTop.SuspendLayout();
      this.TabPageMessages.SuspendLayout();
      this.StatusStrip.SuspendLayout();
      this.PanelMain.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.TweetsBindingSourceMain)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.TweetsBindingSourceReplies)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.TweetsBindingSourceRTs)).BeginInit();
      this.SuspendLayout();
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
      this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TabControl.Location = new System.Drawing.Point(10, 10);
      this.TabControl.Name = "TabControl";
      this.TabControl.SelectedIndex = 0;
      this.TabControl.Size = new System.Drawing.Size(964, 619);
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
      this.PanelTweetsTop.Controls.Add(this.ActionFilterClear);
      this.PanelTweetsTop.Controls.Add(this.ActionGetFellowing);
      this.PanelTweetsTop.Controls.Add(this.ActionGetFollowers);
      this.PanelTweetsTop.Controls.Add(this.EditDeleteOnlyLocal);
      this.PanelTweetsTop.Controls.Add(this.EditSearch);
      this.PanelTweetsTop.Controls.Add(this.ActionConnectTwitter);
      this.PanelTweetsTop.Controls.Add(this.ActionLoadTweestFromJS);
      this.PanelTweetsTop.Controls.Add(this.ActionSaveTweets);
      this.PanelTweetsTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.PanelTweetsTop.Location = new System.Drawing.Point(0, 0);
      this.PanelTweetsTop.Name = "PanelTweetsTop";
      this.PanelTweetsTop.Size = new System.Drawing.Size(956, 65);
      this.PanelTweetsTop.TabIndex = 5;
      // 
      // ActionGetFellowing
      // 
      this.ActionGetFellowing.Location = new System.Drawing.Point(536, 7);
      this.ActionGetFellowing.Name = "ActionGetFellowing";
      this.ActionGetFellowing.Size = new System.Drawing.Size(88, 23);
      this.ActionGetFellowing.TabIndex = 8;
      this.ActionGetFellowing.Text = "Get Fellowing";
      this.ActionGetFellowing.UseVisualStyleBackColor = true;
      this.ActionGetFellowing.Click += new System.EventHandler(this.ActionGetFellowing_Click);
      // 
      // ActionGetFollowers
      // 
      this.ActionGetFollowers.Location = new System.Drawing.Point(630, 7);
      this.ActionGetFollowers.Name = "ActionGetFollowers";
      this.ActionGetFollowers.Size = new System.Drawing.Size(88, 23);
      this.ActionGetFollowers.TabIndex = 8;
      this.ActionGetFollowers.Text = "Get Followers";
      this.ActionGetFollowers.UseVisualStyleBackColor = true;
      this.ActionGetFollowers.Click += new System.EventHandler(this.ActionGetFollowers_Click);
      // 
      // EditDeleteOnlyLocal
      // 
      this.EditDeleteOnlyLocal.AutoSize = true;
      this.EditDeleteOnlyLocal.Checked = global::Ordisoftware.TwitterManager.Properties.Settings.Default.DeleteOnlyLocalMode;
      this.EditDeleteOnlyLocal.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.TwitterManager.Properties.Settings.Default, "DeleteOnlyLocalMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditDeleteOnlyLocal.Location = new System.Drawing.Point(330, 9);
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
      // ActionConnectTwitter
      // 
      this.ActionConnectTwitter.Location = new System.Drawing.Point(3, 6);
      this.ActionConnectTwitter.Name = "ActionConnectTwitter";
      this.ActionConnectTwitter.Size = new System.Drawing.Size(98, 23);
      this.ActionConnectTwitter.TabIndex = 0;
      this.ActionConnectTwitter.Text = "Connect Twitter";
      this.ActionConnectTwitter.UseVisualStyleBackColor = true;
      this.ActionConnectTwitter.Click += new System.EventHandler(this.ActionConnectTwitter_Click);
      // 
      // ActionLoadTweestFromJS
      // 
      this.ActionLoadTweestFromJS.Location = new System.Drawing.Point(112, 6);
      this.ActionLoadTweestFromJS.Name = "ActionLoadTweestFromJS";
      this.ActionLoadTweestFromJS.Size = new System.Drawing.Size(98, 23);
      this.ActionLoadTweestFromJS.TabIndex = 0;
      this.ActionLoadTweestFromJS.Text = "Load Tweets JS";
      this.ActionLoadTweestFromJS.UseVisualStyleBackColor = true;
      this.ActionLoadTweestFromJS.Click += new System.EventHandler(this.ActionLoadTweestFromJS_Click);
      // 
      // ActionSaveTweets
      // 
      this.ActionSaveTweets.Location = new System.Drawing.Point(221, 6);
      this.ActionSaveTweets.Name = "ActionSaveTweets";
      this.ActionSaveTweets.Size = new System.Drawing.Size(98, 23);
      this.ActionSaveTweets.TabIndex = 0;
      this.ActionSaveTweets.Text = "Save Tweets";
      this.ActionSaveTweets.UseVisualStyleBackColor = true;
      this.ActionSaveTweets.Click += new System.EventHandler(this.ActionSaveTweets_Click);
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
      this.TabPageMessages.Size = new System.Drawing.Size(956, 590);
      this.TabPageMessages.TabIndex = 0;
      this.TabPageMessages.Text = "Messages";
      // 
      // StatusStrip
      // 
      this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.LabelCountTweetsMain,
            this.toolStripStatusLabel3,
            this.LabelCountTweetsReplies,
            this.toolStripStatusLabel5,
            this.LabelCountTweetsRTs,
            this.toolStripStatusLabel7,
            this.LabelCountAllRecipients});
      this.StatusStrip.Location = new System.Drawing.Point(0, 639);
      this.StatusStrip.Name = "StatusStrip";
      this.StatusStrip.Size = new System.Drawing.Size(984, 22);
      this.StatusStrip.TabIndex = 4;
      this.StatusStrip.Text = "statusStrip1";
      // 
      // toolStripStatusLabel1
      // 
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new System.Drawing.Size(48, 17);
      this.toolStripStatusLabel1.Text = "Tweets :";
      // 
      // LabelCountTweetsMain
      // 
      this.LabelCountTweetsMain.Name = "LabelCountTweetsMain";
      this.LabelCountTweetsMain.Size = new System.Drawing.Size(13, 17);
      this.LabelCountTweetsMain.Text = "0";
      // 
      // toolStripStatusLabel3
      // 
      this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
      this.toolStripStatusLabel3.Size = new System.Drawing.Size(50, 17);
      this.toolStripStatusLabel3.Text = "Replies :";
      // 
      // LabelCountTweetsReplies
      // 
      this.LabelCountTweetsReplies.Name = "LabelCountTweetsReplies";
      this.LabelCountTweetsReplies.Size = new System.Drawing.Size(13, 17);
      this.LabelCountTweetsReplies.Text = "0";
      // 
      // toolStripStatusLabel5
      // 
      this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
      this.toolStripStatusLabel5.Size = new System.Drawing.Size(29, 17);
      this.toolStripStatusLabel5.Text = "RTs :";
      // 
      // LabelCountTweetsRTs
      // 
      this.LabelCountTweetsRTs.Name = "LabelCountTweetsRTs";
      this.LabelCountTweetsRTs.Size = new System.Drawing.Size(13, 17);
      this.LabelCountTweetsRTs.Text = "0";
      // 
      // toolStripStatusLabel7
      // 
      this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
      this.toolStripStatusLabel7.Size = new System.Drawing.Size(67, 17);
      this.toolStripStatusLabel7.Text = "Recipients :";
      // 
      // LabelCountAllRecipients
      // 
      this.LabelCountAllRecipients.Name = "LabelCountAllRecipients";
      this.LabelCountAllRecipients.Size = new System.Drawing.Size(13, 17);
      this.LabelCountAllRecipients.Text = "0";
      // 
      // PanelMain
      // 
      this.PanelMain.Controls.Add(this.TabControl);
      this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.PanelMain.Location = new System.Drawing.Point(0, 0);
      this.PanelMain.Name = "PanelMain";
      this.PanelMain.Padding = new System.Windows.Forms.Padding(10);
      this.PanelMain.Size = new System.Drawing.Size(984, 639);
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
      this.TableAdapterManager.UpdateOrder = Ordisoftware.TwitterManager.Data.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
      // TweetsControl
      // 
      this.TweetsControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TweetsControl.Location = new System.Drawing.Point(0, 0);
      this.TweetsControl.Name = "TweetsControl";
      this.TweetsControl.Size = new System.Drawing.Size(838, 525);
      this.TweetsControl.TabIndex = 0;
      // 
      // ActionFilterClear
      // 
      this.ActionFilterClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.ActionFilterClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ActionFilterClear.Location = new System.Drawing.Point(216, 35);
      this.ActionFilterClear.Name = "ActionFilterClear";
      this.ActionFilterClear.Size = new System.Drawing.Size(23, 23);
      this.ActionFilterClear.TabIndex = 9;
      this.ActionFilterClear.Text = "X";
      this.ActionFilterClear.UseVisualStyleBackColor = true;
      this.ActionFilterClear.Click += new System.EventHandler(this.ActionFilterClear_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(984, 661);
      this.Controls.Add(this.PanelMain);
      this.Controls.Add(this.StatusStrip);
      this.Name = "MainForm";
      this.Text = "Twitter Manager";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
      this.Load += new System.EventHandler(this.MainForm_Load);
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
    private System.Windows.Forms.Button ActionSaveTweets;
    private System.Windows.Forms.Button ActionConnectTwitter;
    private System.Windows.Forms.Button ActionLoadTweestFromJS;
    private System.Windows.Forms.SplitContainer SplitContainerMain;
    private System.Windows.Forms.ListBox ListBoxAllRecipients;
    private System.Windows.Forms.TextBox EditSearch;
    private TweetsControl TweetsControl;
    private System.Windows.Forms.CheckBox EditDeleteOnlyLocal;
    private System.Windows.Forms.Button ActionGetFollowers;
    private System.Windows.Forms.Button ActionGetFellowing;
    private System.Windows.Forms.StatusStrip StatusStrip;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.ToolStripStatusLabel LabelCountTweetsMain;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    private System.Windows.Forms.ToolStripStatusLabel LabelCountTweetsReplies;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
    private System.Windows.Forms.ToolStripStatusLabel LabelCountTweetsRTs;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
    private System.Windows.Forms.ToolStripStatusLabel LabelCountAllRecipients;
    private System.Windows.Forms.Panel PanelMain;
    internal Data.DataSet DataSet;
    internal System.Windows.Forms.BindingSource TweetsBindingSourceMain;
    internal System.Windows.Forms.BindingSource TweetsBindingSourceReplies;
    internal System.Windows.Forms.BindingSource TweetsBindingSourceRTs;
    internal Data.DataSetTableAdapters.TweetsTableAdapter TweetsTableAdapter;
    internal Data.DataSetTableAdapters.TableAdapterManager TableAdapterManager;
    private System.Windows.Forms.Button ActionFilterClear;
  }
}

