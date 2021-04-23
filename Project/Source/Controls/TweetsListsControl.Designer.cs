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
      this.splitContainerTweetsAndRT = new System.Windows.Forms.SplitContainer();
      this.SplitContainerTweetsMainAndReplies = new System.Windows.Forms.SplitContainer();
      this.ListTweetsMain = new Ordisoftware.TweetsInspector.ListTweets();
      this.ListTweetsReplies = new Ordisoftware.TweetsInspector.ListTweets();
      this.ListTweetsRTs = new Ordisoftware.TweetsInspector.ListTweets();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerTweetsAndRT)).BeginInit();
      this.splitContainerTweetsAndRT.Panel1.SuspendLayout();
      this.splitContainerTweetsAndRT.Panel2.SuspendLayout();
      this.splitContainerTweetsAndRT.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.SplitContainerTweetsMainAndReplies)).BeginInit();
      this.SplitContainerTweetsMainAndReplies.Panel1.SuspendLayout();
      this.SplitContainerTweetsMainAndReplies.Panel2.SuspendLayout();
      this.SplitContainerTweetsMainAndReplies.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainerTweetsAndRT
      // 
      this.splitContainerTweetsAndRT.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainerTweetsAndRT.Location = new System.Drawing.Point(0, 0);
      this.splitContainerTweetsAndRT.Name = "splitContainerTweetsAndRT";
      this.splitContainerTweetsAndRT.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainerTweetsAndRT.Panel1
      // 
      this.splitContainerTweetsAndRT.Panel1.Controls.Add(this.SplitContainerTweetsMainAndReplies);
      // 
      // splitContainerTweetsAndRT.Panel2
      // 
      this.splitContainerTweetsAndRT.Panel2.Controls.Add(this.ListTweetsRTs);
      this.splitContainerTweetsAndRT.Size = new System.Drawing.Size(968, 639);
      this.splitContainerTweetsAndRT.SplitterDistance = 424;
      this.splitContainerTweetsAndRT.SplitterWidth = 10;
      this.splitContainerTweetsAndRT.TabIndex = 7;
      // 
      // SplitContainerTweetsMainAndReplies
      // 
      this.SplitContainerTweetsMainAndReplies.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SplitContainerTweetsMainAndReplies.Location = new System.Drawing.Point(0, 0);
      this.SplitContainerTweetsMainAndReplies.Name = "SplitContainerTweetsMainAndReplies";
      this.SplitContainerTweetsMainAndReplies.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // SplitContainerTweetsMainAndReplies.Panel1
      // 
      this.SplitContainerTweetsMainAndReplies.Panel1.Controls.Add(this.ListTweetsMain);
      // 
      // SplitContainerTweetsMainAndReplies.Panel2
      // 
      this.SplitContainerTweetsMainAndReplies.Panel2.Controls.Add(this.ListTweetsReplies);
      this.SplitContainerTweetsMainAndReplies.Size = new System.Drawing.Size(968, 424);
      this.SplitContainerTweetsMainAndReplies.SplitterDistance = 208;
      this.SplitContainerTweetsMainAndReplies.SplitterWidth = 10;
      this.SplitContainerTweetsMainAndReplies.TabIndex = 0;
      // 
      // ListTweetsMain
      // 
      this.ListTweetsMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ListTweetsMain.Location = new System.Drawing.Point(0, 0);
      this.ListTweetsMain.Name = "ListTweetsMain";
      this.ListTweetsMain.Size = new System.Drawing.Size(968, 208);
      this.ListTweetsMain.TabIndex = 7;
      // 
      // ListTweetsReplies
      // 
      this.ListTweetsReplies.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ListTweetsReplies.Location = new System.Drawing.Point(0, 0);
      this.ListTweetsReplies.Name = "ListTweetsReplies";
      this.ListTweetsReplies.Size = new System.Drawing.Size(968, 206);
      this.ListTweetsReplies.TabIndex = 7;
      // 
      // ListTweetsRTs
      // 
      this.ListTweetsRTs.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ListTweetsRTs.Location = new System.Drawing.Point(0, 0);
      this.ListTweetsRTs.Name = "ListTweetsRTs";
      this.ListTweetsRTs.Size = new System.Drawing.Size(968, 205);
      this.ListTweetsRTs.TabIndex = 6;
      // 
      // TweetsControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.splitContainerTweetsAndRT);
      this.Name = "TweetsControl";
      this.Size = new System.Drawing.Size(968, 639);
      this.splitContainerTweetsAndRT.Panel1.ResumeLayout(false);
      this.splitContainerTweetsAndRT.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerTweetsAndRT)).EndInit();
      this.splitContainerTweetsAndRT.ResumeLayout(false);
      this.SplitContainerTweetsMainAndReplies.Panel1.ResumeLayout(false);
      this.SplitContainerTweetsMainAndReplies.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.SplitContainerTweetsMainAndReplies)).EndInit();
      this.SplitContainerTweetsMainAndReplies.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainerTweetsAndRT;
    private System.Windows.Forms.SplitContainer SplitContainerTweetsMainAndReplies;
    public ListTweets ListTweetsMain;
    public ListTweets ListTweetsReplies;
    public ListTweets ListTweetsRTs;
  }
}
