using System;
using System.Drawing;

namespace ZegroServiceApplication
{
    partial class ZegroService
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZegroService));
			this.StartService = new System.Windows.Forms.Button();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.SuspendLayout();
			// 
			// StartService
			// 
			this.StartService.Location = new System.Drawing.Point(91, 41);
			this.StartService.Name = "StartService";
			this.StartService.Size = new System.Drawing.Size(103, 35);
			this.StartService.TabIndex = 0;
			this.StartService.Text = "Start service";
			this.StartService.UseVisualStyleBackColor = true;
			this.StartService.Click += new System.EventHandler(this.StartService_Click);
			// 
			// ZegroService
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(358, 249);
			this.Controls.Add(this.StartService);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ZegroService";
			this.Text = "Zegro Service";
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button StartService;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
	}
}

