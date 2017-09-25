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
			this.HostInput = new System.Windows.Forms.TextBox();
			this.UserNameInput = new System.Windows.Forms.TextBox();
			this.PasswordInput = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.UpdateConfButton = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.BrowseButton = new System.Windows.Forms.Button();
			this.FileLocationInput = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.ApiUrlInput = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// StartService
			// 
			this.StartService.Location = new System.Drawing.Point(305, 17);
			this.StartService.Name = "StartService";
			this.StartService.Size = new System.Drawing.Size(103, 35);
			this.StartService.TabIndex = 0;
			this.StartService.Text = "Start service";
			this.StartService.UseVisualStyleBackColor = true;
			this.StartService.Click += new System.EventHandler(this.StartService_Click);
			// 
			// HostInput
			// 
			this.HostInput.Location = new System.Drawing.Point(105, 32);
			this.HostInput.Name = "HostInput";
			this.HostInput.Size = new System.Drawing.Size(150, 20);
			this.HostInput.TabIndex = 1;
			// 
			// UserNameInput
			// 
			this.UserNameInput.Location = new System.Drawing.Point(105, 63);
			this.UserNameInput.Name = "UserNameInput";
			this.UserNameInput.Size = new System.Drawing.Size(150, 20);
			this.UserNameInput.TabIndex = 2;
			// 
			// PasswordInput
			// 
			this.PasswordInput.Location = new System.Drawing.Point(105, 88);
			this.PasswordInput.Name = "PasswordInput";
			this.PasswordInput.PasswordChar = '*';
			this.PasswordInput.Size = new System.Drawing.Size(150, 20);
			this.PasswordInput.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(67, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Host";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(38, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "User name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(43, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Password";
			// 
			// UpdateConfButton
			// 
			this.UpdateConfButton.Location = new System.Drawing.Point(128, 178);
			this.UpdateConfButton.Name = "UpdateConfButton";
			this.UpdateConfButton.Size = new System.Drawing.Size(101, 23);
			this.UpdateConfButton.TabIndex = 7;
			this.UpdateConfButton.Text = "Update";
			this.UpdateConfButton.UseVisualStyleBackColor = true;
			this.UpdateConfButton.Click += new System.EventHandler(this.UpdateConfButton_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(34, 123);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Write files to";
			// 
			// BrowseButton
			// 
			this.BrowseButton.Location = new System.Drawing.Point(204, 107);
			this.BrowseButton.Name = "BrowseButton";
			this.BrowseButton.Size = new System.Drawing.Size(25, 23);
			this.BrowseButton.TabIndex = 10;
			this.BrowseButton.Text = "...";
			this.BrowseButton.UseVisualStyleBackColor = true;
			this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
			// 
			// FileLocationInput
			// 
			this.FileLocationInput.Location = new System.Drawing.Point(105, 119);
			this.FileLocationInput.Name = "FileLocationInput";
			this.FileLocationInput.Size = new System.Drawing.Size(120, 20);
			this.FileLocationInput.TabIndex = 11;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.ApiUrlInput);
			this.groupBox1.Controls.Add(this.UpdateConfButton);
			this.groupBox1.Controls.Add(this.BrowseButton);
			this.groupBox1.Location = new System.Drawing.Point(26, 10);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(241, 217);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Configuration";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(28, 145);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "API url";
			// 
			// ApiUrlInput
			// 
			this.ApiUrlInput.Location = new System.Drawing.Point(79, 141);
			this.ApiUrlInput.Name = "ApiUrlInput";
			this.ApiUrlInput.Size = new System.Drawing.Size(150, 20);
			this.ApiUrlInput.TabIndex = 13;
			// 
			// ZegroService
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(440, 276);
			this.Controls.Add(this.FileLocationInput);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.PasswordInput);
			this.Controls.Add(this.UserNameInput);
			this.Controls.Add(this.HostInput);
			this.Controls.Add(this.StartService);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ZegroService";
			this.Text = "Zegro Service";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button StartService;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.TextBox HostInput;
		private System.Windows.Forms.TextBox UserNameInput;
		private System.Windows.Forms.TextBox PasswordInput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button UpdateConfButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button BrowseButton;
		private System.Windows.Forms.TextBox FileLocationInput;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox ApiUrlInput;
	}
}

