namespace Ordisoftware.TweetsInspector
{
  partial class TweetsControl
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
      this.SplitterTop = new System.Windows.Forms.Splitter();
      this.splitter1 = new System.Windows.Forms.Splitter();
      this.ListTweetsReplies = new Ordisoftware.TweetsInspector.ListTweets();
      this.ListTweetsRTs = new Ordisoftware.TweetsInspector.ListTweets();
      this.ListTweetsMain = new Ordisoftware.TweetsInspector.ListTweets();
      this.SuspendLayout();
      // 
      // SplitterTop
      // 
      this.SplitterTop.Cursor = System.Windows.Forms.Cursors.HSplit;
      this.SplitterTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.SplitterTop.Location = new System.Drawing.Point(0, 183);
      this.SplitterTop.MinExtra = 100;
      this.SplitterTop.Name = "SplitterTop";
      this.SplitterTop.Size = new System.Drawing.Size(968, 10);
      this.SplitterTop.TabIndex = 9;
      this.SplitterTop.TabStop = false;
      // 
      // splitter1
      // 
      this.splitter1.Cursor = System.Windows.Forms.Cursors.HSplit;
      this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.splitter1.Location = new System.Drawing.Point(0, 434);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new System.Drawing.Size(968, 10);
      this.splitter1.TabIndex = 10;
      this.splitter1.TabStop = false;
      // 
      // ListTweetsReplies
      // 
      this.ListTweetsReplies.DefaultFilter = null;
      this.ListTweetsReplies.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ListTweetsReplies.Location = new System.Drawing.Point(0, 193);
      this.ListTweetsReplies.MinimumSize = new System.Drawing.Size(700, 120);
      this.ListTweetsReplies.Name = "ListTweetsReplies";
      this.ListTweetsReplies.Size = new System.Drawing.Size(968, 241);
      this.ListTweetsReplies.TabIndex = 7;
      // 
      // ListTweetsRTs
      // 
      this.ListTweetsRTs.DefaultFilter = null;
      this.ListTweetsRTs.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.ListTweetsRTs.Location = new System.Drawing.Point(0, 444);
      this.ListTweetsRTs.MinimumSize = new System.Drawing.Size(700, 120);
      this.ListTweetsRTs.Name = "ListTweetsRTs";
      this.ListTweetsRTs.Size = new System.Drawing.Size(968, 195);
      this.ListTweetsRTs.TabIndex = 6;
      // 
      // ListTweetsMain
      // 
      this.ListTweetsMain.DefaultFilter = null;
      this.ListTweetsMain.Dock = System.Windows.Forms.DockStyle.Top;
      this.ListTweetsMain.Location = new System.Drawing.Point(0, 0);
      this.ListTweetsMain.MinimumSize = new System.Drawing.Size(700, 120);
      this.ListTweetsMain.Name = "ListTweetsMain";
      this.ListTweetsMain.Size = new System.Drawing.Size(968, 183);
      this.ListTweetsMain.TabIndex = 7;
      // 
      // TweetsControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.ListTweetsReplies);
      this.Controls.Add(this.splitter1);
      this.Controls.Add(this.SplitterTop);
      this.Controls.Add(this.ListTweetsRTs);
      this.Controls.Add(this.ListTweetsMain);
      this.Name = "TweetsControl";
      this.Size = new System.Drawing.Size(968, 639);
      this.ResumeLayout(false);

    }

    #endregion
    public ListTweets ListTweetsMain;
    public ListTweets ListTweetsReplies;
    private System.Windows.Forms.Splitter SplitterTop;
    public ListTweets ListTweetsRTs;
    private System.Windows.Forms.Splitter splitter1;
  }
}
