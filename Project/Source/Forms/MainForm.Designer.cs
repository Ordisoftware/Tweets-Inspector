namespace TwitterManager
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
      this.ActionOpenMessages = new System.Windows.Forms.Button();
      this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.EditUser1 = new System.Windows.Forms.TextBox();
      this.EditUser2 = new System.Windows.Forms.TextBox();
      this.EditMessagesCleaned = new System.Windows.Forms.TextBox();
      this.EditMessagesSource = new System.Windows.Forms.TextBox();
      this.TabControl = new System.Windows.Forms.TabControl();
      this.TabPageTweets = new System.Windows.Forms.TabPage();
      this.SplitContainerMain = new System.Windows.Forms.SplitContainer();
      this.TweetsControl = new TwitterManager.TweetsControl();
      this.ListBoxAllRecipients = new System.Windows.Forms.ListBox();
      this.PanelBottom = new System.Windows.Forms.Panel();
      this.ProgressBar = new System.Windows.Forms.ProgressBar();
      this.PanelTweetsTop = new System.Windows.Forms.Panel();
      this.EditSearchResultsShowInForm = new System.Windows.Forms.CheckBox();
      this.ActionSearch = new System.Windows.Forms.Button();
      this.EditSearch = new System.Windows.Forms.TextBox();
      this.ActionConnectTwitter = new System.Windows.Forms.Button();
      this.ActionLoadTweestFromJS = new System.Windows.Forms.Button();
      this.ActionSaveTweets = new System.Windows.Forms.Button();
      this.TabPageMessages = new System.Windows.Forms.TabPage();
      this.TabControl.SuspendLayout();
      this.TabPageTweets.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.SplitContainerMain)).BeginInit();
      this.SplitContainerMain.Panel1.SuspendLayout();
      this.SplitContainerMain.Panel2.SuspendLayout();
      this.SplitContainerMain.SuspendLayout();
      this.PanelTweetsTop.SuspendLayout();
      this.TabPageMessages.SuspendLayout();
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
      this.TabControl.Size = new System.Drawing.Size(964, 641);
      this.TabControl.TabIndex = 3;
      // 
      // TabPageTweets
      // 
      this.TabPageTweets.BackColor = System.Drawing.SystemColors.Control;
      this.TabPageTweets.Controls.Add(this.SplitContainerMain);
      this.TabPageTweets.Controls.Add(this.PanelBottom);
      this.TabPageTweets.Controls.Add(this.ProgressBar);
      this.TabPageTweets.Controls.Add(this.PanelTweetsTop);
      this.TabPageTweets.Location = new System.Drawing.Point(4, 25);
      this.TabPageTweets.Name = "TabPageTweets";
      this.TabPageTweets.Size = new System.Drawing.Size(956, 612);
      this.TabPageTweets.TabIndex = 1;
      this.TabPageTweets.Text = "Tweets";
      // 
      // SplitContainerMain
      // 
      this.SplitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SplitContainerMain.Location = new System.Drawing.Point(0, 35);
      this.SplitContainerMain.Name = "SplitContainerMain";
      // 
      // SplitContainerMain.Panel1
      // 
      this.SplitContainerMain.Panel1.Controls.Add(this.TweetsControl);
      // 
      // SplitContainerMain.Panel2
      // 
      this.SplitContainerMain.Panel2.Controls.Add(this.ListBoxAllRecipients);
      this.SplitContainerMain.Size = new System.Drawing.Size(956, 557);
      this.SplitContainerMain.SplitterDistance = 852;
      this.SplitContainerMain.SplitterWidth = 10;
      this.SplitContainerMain.TabIndex = 9;
      // 
      // TweetsControl
      // 
      this.TweetsControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TweetsControl.Location = new System.Drawing.Point(0, 0);
      this.TweetsControl.Name = "TweetsControl";
      this.TweetsControl.Size = new System.Drawing.Size(852, 557);
      this.TweetsControl.TabIndex = 0;
      // 
      // ListBoxAllRecipients
      // 
      this.ListBoxAllRecipients.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ListBoxAllRecipients.FormattingEnabled = true;
      this.ListBoxAllRecipients.Location = new System.Drawing.Point(0, 0);
      this.ListBoxAllRecipients.Name = "ListBoxAllRecipients";
      this.ListBoxAllRecipients.Size = new System.Drawing.Size(94, 557);
      this.ListBoxAllRecipients.TabIndex = 11;
      this.ListBoxAllRecipients.DoubleClick += new System.EventHandler(this.ListBoxAllRecipients_DoubleClick);
      // 
      // PanelBottom
      // 
      this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.PanelBottom.Location = new System.Drawing.Point(0, 592);
      this.PanelBottom.Name = "PanelBottom";
      this.PanelBottom.Size = new System.Drawing.Size(956, 10);
      this.PanelBottom.TabIndex = 8;
      // 
      // ProgressBar
      // 
      this.ProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.ProgressBar.Location = new System.Drawing.Point(0, 602);
      this.ProgressBar.Name = "ProgressBar";
      this.ProgressBar.Size = new System.Drawing.Size(956, 10);
      this.ProgressBar.Step = 1;
      this.ProgressBar.TabIndex = 7;
      // 
      // PanelTweetsTop
      // 
      this.PanelTweetsTop.Controls.Add(this.EditSearchResultsShowInForm);
      this.PanelTweetsTop.Controls.Add(this.ActionSearch);
      this.PanelTweetsTop.Controls.Add(this.EditSearch);
      this.PanelTweetsTop.Controls.Add(this.ActionConnectTwitter);
      this.PanelTweetsTop.Controls.Add(this.ActionLoadTweestFromJS);
      this.PanelTweetsTop.Controls.Add(this.ActionSaveTweets);
      this.PanelTweetsTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.PanelTweetsTop.Location = new System.Drawing.Point(0, 0);
      this.PanelTweetsTop.Name = "PanelTweetsTop";
      this.PanelTweetsTop.Size = new System.Drawing.Size(956, 35);
      this.PanelTweetsTop.TabIndex = 5;
      // 
      // EditSearchResultsShowInForm
      // 
      this.EditSearchResultsShowInForm.AutoSize = true;
      this.EditSearchResultsShowInForm.Checked = global::TwitterManager.Properties.Settings.Default.MainFormEditSearchResultsShowInForm;
      this.EditSearchResultsShowInForm.CheckState = System.Windows.Forms.CheckState.Checked;
      this.EditSearchResultsShowInForm.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::TwitterManager.Properties.Settings.Default, "MainFormEditSearchResultsShowInForm", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditSearchResultsShowInForm.Location = new System.Drawing.Point(607, 9);
      this.EditSearchResultsShowInForm.Name = "EditSearchResultsShowInForm";
      this.EditSearchResultsShowInForm.Size = new System.Drawing.Size(164, 17);
      this.EditSearchResultsShowInForm.TabIndex = 4;
      this.EditSearchResultsShowInForm.Text = "Show search results in a form";
      this.EditSearchResultsShowInForm.UseVisualStyleBackColor = true;
      // 
      // ActionSearch
      // 
      this.ActionSearch.Location = new System.Drawing.Point(526, 6);
      this.ActionSearch.Name = "ActionSearch";
      this.ActionSearch.Size = new System.Drawing.Size(75, 23);
      this.ActionSearch.TabIndex = 3;
      this.ActionSearch.Text = "Search";
      this.ActionSearch.UseVisualStyleBackColor = true;
      this.ActionSearch.Click += new System.EventHandler(this.ActionSearch_Click);
      // 
      // EditSearch
      // 
      this.EditSearch.Location = new System.Drawing.Point(326, 7);
      this.EditSearch.Name = "EditSearch";
      this.EditSearch.Size = new System.Drawing.Size(194, 20);
      this.EditSearch.TabIndex = 2;
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
      this.ActionLoadTweestFromJS.Location = new System.Drawing.Point(107, 6);
      this.ActionLoadTweestFromJS.Name = "ActionLoadTweestFromJS";
      this.ActionLoadTweestFromJS.Size = new System.Drawing.Size(98, 23);
      this.ActionLoadTweestFromJS.TabIndex = 0;
      this.ActionLoadTweestFromJS.Text = "Load Tweets JS";
      this.ActionLoadTweestFromJS.UseVisualStyleBackColor = true;
      this.ActionLoadTweestFromJS.Click += new System.EventHandler(this.ActionLoadTweestFromJS_Click);
      // 
      // ActionSaveTweets
      // 
      this.ActionSaveTweets.Location = new System.Drawing.Point(211, 6);
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
      this.TabPageMessages.Size = new System.Drawing.Size(956, 612);
      this.TabPageMessages.TabIndex = 0;
      this.TabPageMessages.Text = "Messages";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(984, 661);
      this.Controls.Add(this.TabControl);
      this.Name = "MainForm";
      this.Padding = new System.Windows.Forms.Padding(10);
      this.Text = "Twitter Manager";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
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
      this.ResumeLayout(false);

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
    private System.Windows.Forms.Panel PanelBottom;
    private System.Windows.Forms.ProgressBar ProgressBar;
    private System.Windows.Forms.SplitContainer SplitContainerMain;
    private System.Windows.Forms.ListBox ListBoxAllRecipients;
    private System.Windows.Forms.Button ActionSearch;
    private System.Windows.Forms.TextBox EditSearch;
    private TweetsControl TweetsControl;
    private System.Windows.Forms.CheckBox EditSearchResultsShowInForm;
  }
}

