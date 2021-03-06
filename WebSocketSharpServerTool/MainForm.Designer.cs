﻿using System.Windows.Forms;

namespace WebSocketSharpServerTool
{
    public partial class MainForm : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.thumbprint = new System.Windows.Forms.TextBox();
            this.url = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Button();
            this.privateKeyOption = new System.Windows.Forms.GroupBox();
            this.pfxFileOption = new System.Windows.Forms.RadioButton();
            this.keystoreOption = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.pfxPath = new System.Windows.Forms.TextBox();
            this.browseForPfx = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.pfxPassword = new System.Windows.Forms.TextBox();
            this.privateKeyOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.start.Location = new System.Drawing.Point(607, 507);
            this.start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(100, 23);
            this.start.TabIndex = 7;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "This server echoes back whatever data is sent to it.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(489, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "For wss:// scheme, create and initialize service\'s X509 certificate as follows..." +
    "";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(21, 63);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(794, 130);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 293);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thumbprint of X509 certificate";
            // 
            // thumbprint
            // 
            this.thumbprint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.thumbprint.Location = new System.Drawing.Point(19, 313);
            this.thumbprint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.thumbprint.Name = "thumbprint";
            this.thumbprint.Size = new System.Drawing.Size(412, 22);
            this.thumbprint.TabIndex = 2;
            this.thumbprint.Text = "3228f47d6f0a56c47f62d96b9d0e8580049389a0";
            // 
            // url
            // 
            this.url.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.url.Location = new System.Drawing.Point(19, 464);
            this.url.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(796, 22);
            this.url.TabIndex = 6;
            this.url.Text = "wss://localhost:8088";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 444);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Service URL";
            // 
            // stop
            // 
            this.stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stop.Enabled = false;
            this.stop.Location = new System.Drawing.Point(715, 507);
            this.stop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(100, 23);
            this.stop.TabIndex = 8;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // privateKeyOption
            // 
            this.privateKeyOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.privateKeyOption.Controls.Add(this.pfxFileOption);
            this.privateKeyOption.Controls.Add(this.keystoreOption);
            this.privateKeyOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.privateKeyOption.Location = new System.Drawing.Point(23, 201);
            this.privateKeyOption.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.privateKeyOption.Name = "privateKeyOption";
            this.privateKeyOption.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.privateKeyOption.Size = new System.Drawing.Size(409, 80);
            this.privateKeyOption.TabIndex = 0;
            this.privateKeyOption.TabStop = false;
            this.privateKeyOption.Text = "Private Key";
            // 
            // pfxFileOption
            // 
            this.pfxFileOption.AutoSize = true;
            this.pfxFileOption.Location = new System.Drawing.Point(11, 48);
            this.pfxFileOption.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pfxFileOption.Name = "pfxFileOption";
            this.pfxFileOption.Size = new System.Drawing.Size(81, 21);
            this.pfxFileOption.TabIndex = 1;
            this.pfxFileOption.Text = "PFX File";
            this.pfxFileOption.UseVisualStyleBackColor = true;
            this.pfxFileOption.CheckedChanged += new System.EventHandler(this.PfxFileOption_CheckedChanged);
            // 
            // keystoreOption
            // 
            this.keystoreOption.AutoSize = true;
            this.keystoreOption.Checked = true;
            this.keystoreOption.Location = new System.Drawing.Point(9, 20);
            this.keystoreOption.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.keystoreOption.Name = "keystoreOption";
            this.keystoreOption.Size = new System.Drawing.Size(358, 21);
            this.keystoreOption.TabIndex = 0;
            this.keystoreOption.TabStop = true;
            this.keystoreOption.Text = "Use Keystore (Windows only, may require elevation)";
            this.keystoreOption.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 343);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "PFX file path";
            // 
            // pfxPath
            // 
            this.pfxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pfxPath.Enabled = false;
            this.pfxPath.Location = new System.Drawing.Point(19, 363);
            this.pfxPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pfxPath.Name = "pfxPath";
            this.pfxPath.ReadOnly = true;
            this.pfxPath.Size = new System.Drawing.Size(688, 22);
            this.pfxPath.TabIndex = 3;
            this.pfxPath.Text = "mycompany.pfx";
            // 
            // browseForPfx
            // 
            this.browseForPfx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.browseForPfx.Enabled = false;
            this.browseForPfx.Location = new System.Drawing.Point(716, 363);
            this.browseForPfx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.browseForPfx.Name = "browseForPfx";
            this.browseForPfx.Size = new System.Drawing.Size(100, 23);
            this.browseForPfx.TabIndex = 4;
            this.browseForPfx.Text = "Browse...";
            this.browseForPfx.UseVisualStyleBackColor = true;
            this.browseForPfx.Click += new System.EventHandler(this.BrowseForPfx_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "pfx";
            this.openFileDialog.Filter = "PFX files|*.pfx";
            this.openFileDialog.Title = "Pick PFX file";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 394);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "PFX password";
            // 
            // pfxPassword
            // 
            this.pfxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pfxPassword.Enabled = false;
            this.pfxPassword.Location = new System.Drawing.Point(19, 414);
            this.pfxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pfxPassword.Name = "pfxPassword";
            this.pfxPassword.PasswordChar = '*';
            this.pfxPassword.Size = new System.Drawing.Size(141, 22);
            this.pfxPassword.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AcceptButton = this.start;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 543);
            this.Controls.Add(this.pfxPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.browseForPfx);
            this.Controls.Add(this.pfxPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.privateKeyOption);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.url);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.thumbprint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(634, 580);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebSocketSharp Server Tool";
            this.privateKeyOption.ResumeLayout(false);
            this.privateKeyOption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox thumbprint;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.GroupBox privateKeyOption;
        private System.Windows.Forms.RadioButton pfxFileOption;
        private System.Windows.Forms.RadioButton keystoreOption;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pfxPath;
        private System.Windows.Forms.Button browseForPfx;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pfxPassword;
    }
}

