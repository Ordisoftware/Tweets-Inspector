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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.MenuOpen = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuDelete = new System.Windows.Forms.ToolStripMenuItem();
      this.PanelBottom = new System.Windows.Forms.Panel();
      this.ActionOpen = new System.Windows.Forms.Button();
      this.ActionDelete = new System.Windows.Forms.Button();
      this.EditFilter = new System.Windows.Forms.TextBox();
      this.ActionFilterClear = new System.Windows.Forms.Button();
      this.ActionSelectAll = new System.Windows.Forms.Button();
      this.ActionSelectNone = new System.Windows.Forms.Button();
      this.LabelTitle = new System.Windows.Forms.Label();
      this.DataSet = new Ordisoftware.TweetsInspector.Data.DataSet();
      this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.TweetsTableAdapter = new Ordisoftware.TweetsInspector.Data.DataSetTableAdapters.TweetsTableAdapter();
      this.TableAdapterManager = new Ordisoftware.TweetsInspector.Data.DataSetTableAdapters.TableAdapterManager();
      this.DataGridView = new System.Windows.Forms.DataGridView();
      this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnRecipients = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ContextMenuStrip.SuspendLayout();
      this.PanelBottom.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // ContextMenuStrip
      // 
      this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOpen,
            this.MenuDelete});
      this.ContextMenuStrip.Name = "ContextMenuStrip";
      this.ContextMenuStrip.Size = new System.Drawing.Size(108, 48);
      // 
      // MenuOpen
      // 
      this.MenuOpen.Name = "MenuOpen";
      this.MenuOpen.Size = new System.Drawing.Size(107, 22);
      this.MenuOpen.Text = "Open";
      this.MenuOpen.Click += new System.EventHandler(this.ActionOpen_Click);
      // 
      // MenuDelete
      // 
      this.MenuDelete.Name = "MenuDelete";
      this.MenuDelete.Size = new System.Drawing.Size(107, 22);
      this.MenuDelete.Text = "Delete";
      this.MenuDelete.Click += new System.EventHandler(this.ActionDelete_Click);
      // 
      // PanelBottom
      // 
      this.PanelBottom.Controls.Add(this.ActionOpen);
      this.PanelBottom.Controls.Add(this.ActionDelete);
      this.PanelBottom.Controls.Add(this.EditFilter);
      this.PanelBottom.Controls.Add(this.ActionFilterClear);
      this.PanelBottom.Controls.Add(this.ActionSelectAll);
      this.PanelBottom.Controls.Add(this.ActionSelectNone);
      this.PanelBottom.Controls.Add(this.LabelTitle);
      this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Top;
      this.PanelBottom.Location = new System.Drawing.Point(0, 0);
      this.PanelBottom.Name = "PanelBottom";
      this.PanelBottom.Size = new System.Drawing.Size(600, 30);
      this.PanelBottom.TabIndex = 10;
      // 
      // ActionOpen
      // 
      this.ActionOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.ActionOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ActionOpen.Location = new System.Drawing.Point(515, 3);
      this.ActionOpen.Name = "ActionOpen";
      this.ActionOpen.Size = new System.Drawing.Size(45, 23);
      this.ActionOpen.TabIndex = 5;
      this.ActionOpen.Text = "OPEN";
      this.ActionOpen.UseVisualStyleBackColor = true;
      this.ActionOpen.Click += new System.EventHandler(this.ActionOpen_Click);
      // 
      // ActionDelete
      // 
      this.ActionDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.ActionDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ActionDelete.Location = new System.Drawing.Point(566, 3);
      this.ActionDelete.Name = "ActionDelete";
      this.ActionDelete.Size = new System.Drawing.Size(35, 23);
      this.ActionDelete.TabIndex = 5;
      this.ActionDelete.Text = "DEL";
      this.ActionDelete.UseVisualStyleBackColor = true;
      this.ActionDelete.Click += new System.EventHandler(this.ActionDelete_Click);
      // 
      // EditFilter
      // 
      this.EditFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.EditFilter.Location = new System.Drawing.Point(222, 4);
      this.EditFilter.Name = "EditFilter";
      this.EditFilter.Size = new System.Drawing.Size(200, 20);
      this.EditFilter.TabIndex = 4;
      this.EditFilter.TextChanged += new System.EventHandler(this.EditFilter_TextChanged);
      // 
      // ActionFilterClear
      // 
      this.ActionFilterClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.ActionFilterClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ActionFilterClear.Location = new System.Drawing.Point(428, 3);
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
      this.ActionSelectAll.Location = new System.Drawing.Point(457, 3);
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
      this.ActionSelectNone.Location = new System.Drawing.Point(486, 3);
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
      this.LabelTitle.Size = new System.Drawing.Size(150, 30);
      this.LabelTitle.TabIndex = 0;
      this.LabelTitle.Text = "TITLE";
      this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // DataSet
      // 
      this.DataSet.DataSetName = "DataSet";
      this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // BindingSource
      // 
      this.BindingSource.DataMember = "Tweets";
      this.BindingSource.DataSource = this.DataSet;
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
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.DataGridView.ColumnHeadersHeight = 25;
      this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDate,
            this.ColumnId,
            this.ColumnRecipients,
            this.ColumnMessage});
      this.DataGridView.ContextMenuStrip = this.ContextMenuStrip;
      this.DataGridView.DataSource = this.BindingSource;
      this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.DataGridView.EnableHeadersVisualStyles = false;
      this.DataGridView.Location = new System.Drawing.Point(0, 30);
      this.DataGridView.Name = "DataGridView";
      this.DataGridView.ReadOnly = true;
      this.DataGridView.RowHeadersVisible = false;
      this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.DataGridView.Size = new System.Drawing.Size(600, 90);
      this.DataGridView.TabIndex = 1;
      this.DataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellDoubleClick);
      this.DataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataGridView_MouseDown);
      // 
      // ColumnDate
      // 
      this.ColumnDate.DataPropertyName = "Date";
      this.ColumnDate.HeaderText = "Date";
      this.ColumnDate.Name = "ColumnDate";
      this.ColumnDate.ReadOnly = true;
      this.ColumnDate.Width = 115;
      // 
      // ColumnId
      // 
      this.ColumnId.DataPropertyName = "Id";
      this.ColumnId.HeaderText = "Id";
      this.ColumnId.Name = "ColumnId";
      this.ColumnId.ReadOnly = true;
      this.ColumnId.Width = 125;
      // 
      // ColumnRecipients
      // 
      this.ColumnRecipients.DataPropertyName = "Recipients";
      this.ColumnRecipients.HeaderText = "Recipients";
      this.ColumnRecipients.Name = "ColumnRecipients";
      this.ColumnRecipients.ReadOnly = true;
      this.ColumnRecipients.Width = 175;
      // 
      // ColumnMessage
      // 
      this.ColumnMessage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.ColumnMessage.DataPropertyName = "Message";
      this.ColumnMessage.HeaderText = "Message";
      this.ColumnMessage.Name = "ColumnMessage";
      this.ColumnMessage.ReadOnly = true;
      // 
      // ListTweets
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.DataGridView);
      this.Controls.Add(this.PanelBottom);
      this.MinimumSize = new System.Drawing.Size(600, 120);
      this.Name = "ListTweets";
      this.Size = new System.Drawing.Size(600, 120);
      this.ContextMenuStrip.ResumeLayout(false);
      this.PanelBottom.ResumeLayout(false);
      this.PanelBottom.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.ContextMenuStrip ContextMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem MenuOpen;
    private System.Windows.Forms.ToolStripMenuItem MenuDelete;
    private System.Windows.Forms.Panel PanelBottom;
    public System.Windows.Forms.Label LabelTitle;
    private Data.DataSet DataSet;
    private System.Windows.Forms.BindingSource BindingSource;
    private Data.DataSetTableAdapters.TweetsTableAdapter TweetsTableAdapter;
    private Data.DataSetTableAdapters.TableAdapterManager TableAdapterManager;
    public System.Windows.Forms.DataGridView DataGridView;
    public System.Windows.Forms.TextBox EditFilter;
    public System.Windows.Forms.Button ActionSelectAll;
    public System.Windows.Forms.Button ActionSelectNone;
    public System.Windows.Forms.Button ActionFilterClear;
    public System.Windows.Forms.Button ActionDelete;
    public System.Windows.Forms.Button ActionOpen;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRecipients;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMessage;
  }
}