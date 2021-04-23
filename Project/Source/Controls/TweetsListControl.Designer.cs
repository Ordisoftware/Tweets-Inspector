namespace Ordisoftware.TweetsInspector
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
      this.PanelBottom = new System.Windows.Forms.Panel();
      this.EditFilter = new System.Windows.Forms.TextBox();
      this.ActionFilterClear = new System.Windows.Forms.Button();
      this.ActionSelectAll = new System.Windows.Forms.Button();
      this.ActionSelectNone = new System.Windows.Forms.Button();
      this.LabelTitle = new System.Windows.Forms.Label();
      this.DataSet = new Ordisoftware.TweetsInspector.Data.DataSet();
      this.TweetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.TweetsTableAdapter = new Ordisoftware.TweetsInspector.Data.DataSetTableAdapters.TweetsTableAdapter();
      this.TableAdapterManager = new Ordisoftware.TweetsInspector.Data.DataSetTableAdapters.TableAdapterManager();
      this.DataGridView = new System.Windows.Forms.DataGridView();
      this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.recipientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ActionDelete = new System.Windows.Forms.Button();
      this.ContextMenuStrip.SuspendLayout();
      this.PanelBottom.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.TweetsBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
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
      // PanelBottom
      // 
      this.PanelBottom.Controls.Add(this.ActionDelete);
      this.PanelBottom.Controls.Add(this.EditFilter);
      this.PanelBottom.Controls.Add(this.ActionFilterClear);
      this.PanelBottom.Controls.Add(this.ActionSelectAll);
      this.PanelBottom.Controls.Add(this.ActionSelectNone);
      this.PanelBottom.Controls.Add(this.LabelTitle);
      this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Top;
      this.PanelBottom.Location = new System.Drawing.Point(0, 0);
      this.PanelBottom.Name = "PanelBottom";
      this.PanelBottom.Size = new System.Drawing.Size(800, 30);
      this.PanelBottom.TabIndex = 10;
      // 
      // EditFilter
      // 
      this.EditFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.EditFilter.Location = new System.Drawing.Point(469, 4);
      this.EditFilter.Name = "EditFilter";
      this.EditFilter.Size = new System.Drawing.Size(200, 20);
      this.EditFilter.TabIndex = 4;
      this.EditFilter.TextChanged += new System.EventHandler(this.EditFilter_TextChanged);
      // 
      // ActionFilterClear
      // 
      this.ActionFilterClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.ActionFilterClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ActionFilterClear.Location = new System.Drawing.Point(675, 3);
      this.ActionFilterClear.Name = "ActionFilterClear";
      this.ActionFilterClear.Size = new System.Drawing.Size(23, 23);
      this.ActionFilterClear.TabIndex = 1;
      this.ActionFilterClear.Text = "X";
      this.ActionFilterClear.UseVisualStyleBackColor = true;
      this.ActionFilterClear.Click += new System.EventHandler(this.ActionFilterClear_Click);
      // 
      // ActionSelectAll
      // 
      this.ActionSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.ActionSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ActionSelectAll.Location = new System.Drawing.Point(704, 3);
      this.ActionSelectAll.Name = "ActionSelectAll";
      this.ActionSelectAll.Size = new System.Drawing.Size(23, 23);
      this.ActionSelectAll.TabIndex = 1;
      this.ActionSelectAll.Text = "+";
      this.ActionSelectAll.UseVisualStyleBackColor = true;
      this.ActionSelectAll.Click += new System.EventHandler(this.ActionSelectAll_Click);
      // 
      // ActionSelectNone
      // 
      this.ActionSelectNone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.ActionSelectNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ActionSelectNone.Location = new System.Drawing.Point(733, 3);
      this.ActionSelectNone.Name = "ActionSelectNone";
      this.ActionSelectNone.Size = new System.Drawing.Size(23, 23);
      this.ActionSelectNone.TabIndex = 1;
      this.ActionSelectNone.Text = "-";
      this.ActionSelectNone.UseVisualStyleBackColor = true;
      this.ActionSelectNone.Click += new System.EventHandler(this.ActionSelectNone_Click);
      // 
      // LabelTitle
      // 
      this.LabelTitle.Dock = System.Windows.Forms.DockStyle.Left;
      this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LabelTitle.Location = new System.Drawing.Point(0, 0);
      this.LabelTitle.Name = "LabelTitle";
      this.LabelTitle.Size = new System.Drawing.Size(120, 30);
      this.LabelTitle.TabIndex = 0;
      this.LabelTitle.Text = "TITLE";
      this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // DataSet
      // 
      this.DataSet.DataSetName = "DataSet";
      this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // TweetsBindingSource
      // 
      this.TweetsBindingSource.DataMember = "Tweets";
      this.TweetsBindingSource.DataSource = this.DataSet;
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
      // DataGridView
      // 
      this.DataGridView.AllowUserToAddRows = false;
      this.DataGridView.AllowUserToDeleteRows = false;
      this.DataGridView.AllowUserToResizeRows = false;
      this.DataGridView.AutoGenerateColumns = false;
      this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.recipientsDataGridViewTextBoxColumn,
            this.messageDataGridViewTextBoxColumn});
      this.DataGridView.ContextMenuStrip = this.ContextMenuStrip;
      this.DataGridView.DataSource = this.TweetsBindingSource;
      this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.DataGridView.Location = new System.Drawing.Point(0, 30);
      this.DataGridView.Name = "DataGridView";
      this.DataGridView.ReadOnly = true;
      this.DataGridView.RowHeadersVisible = false;
      this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.DataGridView.Size = new System.Drawing.Size(800, 170);
      this.DataGridView.TabIndex = 1;
      this.DataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellDoubleClick);
      this.DataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataGridView_MouseDown);
      // 
      // idDataGridViewTextBoxColumn
      // 
      this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
      this.idDataGridViewTextBoxColumn.HeaderText = "Id";
      this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
      this.idDataGridViewTextBoxColumn.ReadOnly = true;
      this.idDataGridViewTextBoxColumn.Width = 130;
      // 
      // dateDataGridViewTextBoxColumn
      // 
      this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
      this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
      this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
      this.dateDataGridViewTextBoxColumn.ReadOnly = true;
      this.dateDataGridViewTextBoxColumn.Width = 180;
      // 
      // recipientsDataGridViewTextBoxColumn
      // 
      this.recipientsDataGridViewTextBoxColumn.DataPropertyName = "Recipients";
      this.recipientsDataGridViewTextBoxColumn.HeaderText = "Recipients";
      this.recipientsDataGridViewTextBoxColumn.Name = "recipientsDataGridViewTextBoxColumn";
      this.recipientsDataGridViewTextBoxColumn.ReadOnly = true;
      this.recipientsDataGridViewTextBoxColumn.Width = 250;
      // 
      // messageDataGridViewTextBoxColumn
      // 
      this.messageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.messageDataGridViewTextBoxColumn.DataPropertyName = "Message";
      this.messageDataGridViewTextBoxColumn.HeaderText = "Message";
      this.messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
      this.messageDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // ActionDelete
      // 
      this.ActionDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.ActionDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ActionDelete.Location = new System.Drawing.Point(762, 3);
      this.ActionDelete.Name = "ActionDelete";
      this.ActionDelete.Size = new System.Drawing.Size(35, 23);
      this.ActionDelete.TabIndex = 5;
      this.ActionDelete.Text = "DEL";
      this.ActionDelete.UseVisualStyleBackColor = true;
      this.ActionDelete.Click += new System.EventHandler(this.ActionTweetDelete_Click);
      // 
      // ListTweets
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.DataGridView);
      this.Controls.Add(this.PanelBottom);
      this.Name = "ListTweets";
      this.Size = new System.Drawing.Size(800, 200);
      this.ContextMenuStrip.ResumeLayout(false);
      this.PanelBottom.ResumeLayout(false);
      this.PanelBottom.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.TweetsBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.ContextMenuStrip ContextMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem ActionTweetOpen;
    private System.Windows.Forms.ToolStripMenuItem ActionTweetDelete;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRecipients;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMessage;
    private System.Windows.Forms.Panel PanelBottom;
    public System.Windows.Forms.Label LabelTitle;
    private Data.DataSet DataSet;
    private System.Windows.Forms.BindingSource TweetsBindingSource;
    private Data.DataSetTableAdapters.TweetsTableAdapter TweetsTableAdapter;
    private Data.DataSetTableAdapters.TableAdapterManager TableAdapterManager;
    public System.Windows.Forms.DataGridView DataGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn recipientsDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
    public System.Windows.Forms.TextBox EditFilter;
    public System.Windows.Forms.Button ActionSelectAll;
    public System.Windows.Forms.Button ActionSelectNone;
    public System.Windows.Forms.Button ActionFilterClear;
    public System.Windows.Forms.Button ActionDelete;
  }
}
