﻿namespace ZegroServiceApplication
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
			this.StartService = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
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
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(275, 147);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ZegroService
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(358, 249);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.StartService);
			this.Name = "ZegroService";
			this.Text = "Zegro Service";
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button StartService;
		private System.Windows.Forms.Button button1;
	}
}

