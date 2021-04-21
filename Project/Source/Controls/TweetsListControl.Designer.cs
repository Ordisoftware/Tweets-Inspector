namespace TwitterManager
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
      this.ListView = new System.Windows.Forms.ListView();
      this.ColumnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnRecipients = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ActionTweetOpen = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionTweetDelete = new System.Windows.Forms.ToolStripMenuItem();
      this.ContextMenuStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // ListView
      // 
      this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnId,
            this.ColumnDate,
            this.ColumnRecipients,
            this.ColumnMessage});
      this.ListView.ContextMenuStrip = this.ContextMenuStrip;
      this.ListView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ListView.FullRowSelect = true;
      this.ListView.HideSelection = false;
      this.ListView.Location = new System.Drawing.Point(0, 0);
      this.ListView.Name = "ListView";
      this.ListView.Size = new System.Drawing.Size(800, 150);
      this.ListView.TabIndex = 0;
      this.ListView.UseCompatibleStateImageBehavior = false;
      this.ListView.View = System.Windows.Forms.View.Details;
      this.ListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListView_ColumnClick);
      this.ListView.SizeChanged += new System.EventHandler(this.ListView_SizeChanged);
      this.ListView.DoubleClick += new System.EventHandler(this.ListView_DoubleClick);
      // 
      // ColumnId
      // 
      this.ColumnId.Text = "Id";
      this.ColumnId.Width = 130;
      // 
      // ColumnDate
      // 
      this.ColumnDate.Text = "Date";
      this.ColumnDate.Width = 190;
      // 
      // ColumnRecipients
      // 
      this.ColumnRecipients.Text = "Recipients";
      this.ColumnRecipients.Width = 300;
      // 
      // ColumnMessage
      // 
      this.ColumnMessage.Text = "Message";
      this.ColumnMessage.Width = 150;
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
      // ListTweets
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.ListView);
      this.Name = "ListTweets";
      this.Size = new System.Drawing.Size(800, 150);
      this.ContextMenuStrip.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.ColumnHeader ColumnId;
    private System.Windows.Forms.ColumnHeader ColumnDate;
    private System.Windows.Forms.ColumnHeader ColumnRecipients;
    private System.Windows.Forms.ColumnHeader ColumnMessage;
    private System.Windows.Forms.ContextMenuStrip ContextMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem ActionTweetOpen;
    private System.Windows.Forms.ToolStripMenuItem ActionTweetDelete;
    internal System.Windows.Forms.ListView ListView;
  }
}
