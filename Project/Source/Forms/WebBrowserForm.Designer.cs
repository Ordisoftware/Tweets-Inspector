﻿namespace Ordisoftware.TwitterManager
{
  partial class WebBrowserForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if ( disposing && ( components != null ) )
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.WebBrowser = new CefSharp.WinForms.ChromiumWebBrowser();
      this.SuspendLayout();
      // 
      // WebBrowser
      // 
      this.WebBrowser.ActivateBrowserOnCreation = false;
      this.WebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
      this.WebBrowser.Location = new System.Drawing.Point(0, 0);
      this.WebBrowser.Name = "WebBrowser";
      this.WebBrowser.Size = new System.Drawing.Size(784, 561);
      this.WebBrowser.TabIndex = 0;
      // 
      // WebBrowserForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 561);
      this.Controls.Add(this.WebBrowser);
      this.Name = "WebBrowserForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "BrowserForm";
      this.ResumeLayout(false);

    }

    #endregion

    public CefSharp.WinForms.ChromiumWebBrowser WebBrowser;
  }
}