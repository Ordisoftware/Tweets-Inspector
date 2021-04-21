namespace Ordisoftware.TwitterManager
{
  partial class ListTweets
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

    #region Code généré par le Concepteur de composants

    /// <summary> 
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ActionTweetOpen = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionTweetDelete = new System.Windows.Forms.ToolStripMenuItem();
      this.DataGridView = new System.Windows.Forms.DataGridView();
      this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnRecipients = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TweetBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.ContextMenuStrip.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.TweetBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // ContextMenuStrip
      // 
      this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionTweetOpen,
            this.ActionTweetDelete});
      this.ContextMenuStrip.Name = "ContextMenuStrip";
      this.ContextMenuStrip.Size = new System.Drawing.Size(108, 48);
      // 
      // ActionTweetOpen
      // 
      this.ActionTweetOpen.Name = "ActionTweetOpen";
      this.ActionTweetOpen.Size = new System.Drawing.Size(107, 22);
      this.ActionTweetOpen.Text = "Open";
      this.ActionTweetOpen.Click += new System.EventHandler(this.ActionTweetOpen_Click);
      // 
      // ActionTweetDelete
      // 
      this.ActionTweetDelete.Name = "ActionTweetDelete";
      this.ActionTweetDelete.Size = new System.Drawing.Size(107, 22);
      this.ActionTweetDelete.Text = "Delete";
      this.ActionTweetDelete.Click += new System.EventHandler(this.ActionTweetDelete_Click);
      // 
      // DataGridView
      // 
      this.DataGridView.AllowUserToAddRows = false;
      this.DataGridView.AllowUserToDeleteRows = false;
      this.DataGridView.AllowUserToResizeRows = false;
      this.DataGridView.AutoGenerateColumns = false;
      this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnDate,
            this.ColumnRecipients,
            this.ColumnMessage});
      this.DataGridView.ContextMenuStrip = this.ContextMenuStrip;
      this.DataGridView.DataSource = this.TweetBindingSource;
      this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.DataGridView.Location = new System.Drawing.Point(0, 0);
      this.DataGridView.Name = "DataGridView";
      this.DataGridView.ReadOnly = true;
      this.DataGridView.RowHeadersVisible = false;
      this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.DataGridView.Size = new System.Drawing.Size(800, 150);
      this.DataGridView.TabIndex = 1;
      this.DataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellDoubleClick);
      // 
      // ColumnId
      // 
      this.ColumnId.DataPropertyName = "Id";
      this.ColumnId.HeaderText = "Id";
      this.ColumnId.Name = "ColumnId";
      this.ColumnId.ReadOnly = true;
      this.ColumnId.Width = 130;
      // 
      // ColumnDate
      // 
      this.ColumnDate.DataPropertyName = "Date";
      this.ColumnDate.HeaderText = "Date";
      this.ColumnDate.Name = "ColumnDate";
      this.ColumnDate.ReadOnly = true;
      this.ColumnDate.Width = 190;
      // 
      // ColumnRecipients
      // 
      this.ColumnRecipients.DataPropertyName = "Recipients";
      this.ColumnRecipients.HeaderText = "Recipients";
      this.ColumnRecipients.Name = "ColumnRecipients";
      this.ColumnRecipients.ReadOnly = true;
      this.ColumnRecipients.Width = 300;
      // 
      // ColumnMessage
      // 
      this.ColumnMessage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.ColumnMessage.DataPropertyName = "Message";
      this.ColumnMessage.HeaderText = "Message";
      this.ColumnMessage.Name = "ColumnMessage";
      this.ColumnMessage.ReadOnly = true;
      // 
      // TweetBindingSource
      // 
      this.TweetBindingSource.DataSource = typeof(TwitterManager.Tweet);
      // 
      // ListTweets
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.DataGridView);
      this.Name = "ListTweets";
      this.Size = new System.Drawing.Size(800, 150);
      this.ContextMenuStrip.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.TweetBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.ContextMenuStrip ContextMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem ActionTweetOpen;
    private System.Windows.Forms.ToolStripMenuItem ActionTweetDelete;
    private System.Windows.Forms.BindingSource TweetBindingSource;
    public System.Windows.Forms.DataGridView DataGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRecipients;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMessage;
  }
}
