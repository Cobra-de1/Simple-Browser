
namespace SimpleBrowser
{
    partial class Browser
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
            if (disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Back = new System.Windows.Forms.ToolStripButton();
            this.Forward = new System.Windows.Forms.ToolStripButton();
            this.search = new System.Windows.Forms.ToolStripTextBox();
            this.Download = new System.Windows.Forms.ToolStripButton();
            this.View = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.HeaderRequest = new System.Windows.Forms.ToolStripButton();
            this.HeaderRespone = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Back,
            this.Forward,
            this.search,
            this.HeaderRequest,
            this.HeaderRespone,
            this.Download,
            this.View});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1529, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Back
            // 
            this.Back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
            this.Back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(29, 24);
            this.Back.Text = "Back";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Forward
            // 
            this.Forward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Forward.Image = ((System.Drawing.Image)(resources.GetObject("Forward.Image")));
            this.Forward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(29, 28);
            this.Forward.Text = "Forward";
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // search
            // 
            this.search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(1292, 31);
            this.search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_KeyDown);
            // 
            // Download
            // 
            this.Download.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Download.Image = ((System.Drawing.Image)(resources.GetObject("Download.Image")));
            this.Download.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(29, 28);
            this.Download.Text = "Download";
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // View
            // 
            this.View.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.View.Image = ((System.Drawing.Image)(resources.GetObject("View.Image")));
            this.View.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(29, 28);
            this.View.Text = "View";
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 27);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1529, 528);
            this.webBrowser1.TabIndex = 2;
            // 
            // HeaderRequest
            // 
            this.HeaderRequest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HeaderRequest.Image = ((System.Drawing.Image)(resources.GetObject("HeaderRequest.Image")));
            this.HeaderRequest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HeaderRequest.Name = "HeaderRequest";
            this.HeaderRequest.Size = new System.Drawing.Size(29, 28);
            this.HeaderRequest.Text = "HeaderRequest";
            this.HeaderRequest.ToolTipText = "HeaderRequest";
            this.HeaderRequest.Click += new System.EventHandler(this.HeaderRequest_Click);
            // 
            // HeaderRespone
            // 
            this.HeaderRespone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HeaderRespone.Image = ((System.Drawing.Image)(resources.GetObject("HeaderRespone.Image")));
            this.HeaderRespone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HeaderRespone.Name = "HeaderRespone";
            this.HeaderRespone.Size = new System.Drawing.Size(29, 28);
            this.HeaderRespone.Text = "HeaderRespone";
            this.HeaderRespone.Click += new System.EventHandler(this.HeaderRespone_Click);
            // 
            // Lab04_Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 555);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Lab04_Bai04";
            this.Text = "Lab04_Bai04";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox search;
        private System.Windows.Forms.ToolStripButton Download;
        private System.Windows.Forms.ToolStripButton View;
        private System.Windows.Forms.ToolStripButton Back;
        private System.Windows.Forms.ToolStripButton Forward;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripButton HeaderRequest;
        private System.Windows.Forms.ToolStripButton HeaderRespone;
    }
}