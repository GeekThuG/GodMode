namespace GodMode
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnawin = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnapp = new System.Windows.Forms.Button();
            this.btncmd = new System.Windows.Forms.Button();
            this.btnnetwork = new System.Windows.Forms.Button();
            this.btnservice = new System.Windows.Forms.Button();
            this.btnAdCmd = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(203, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 481);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.btnAdCmd);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnawin);
            this.panel2.Controls.Add(this.btnexit);
            this.panel2.Controls.Add(this.btnapp);
            this.panel2.Controls.Add(this.btncmd);
            this.panel2.Controls.Add(this.btnnetwork);
            this.panel2.Controls.Add(this.btnservice);
            this.panel2.Location = new System.Drawing.Point(12, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 481);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(23, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 39);
            this.button2.TabIndex = 8;
            this.button2.Text = "Windows Fast Startup";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(23, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Smart Screen";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnawin
            // 
            this.btnawin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnawin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnawin.Location = new System.Drawing.Point(23, 382);
            this.btnawin.Name = "btnawin";
            this.btnawin.Size = new System.Drawing.Size(134, 42);
            this.btnawin.TabIndex = 6;
            this.btnawin.Text = "Activation Windows";
            this.btnawin.UseVisualStyleBackColor = false;
            this.btnawin.Click += new System.EventHandler(this.btnawin_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexit.Location = new System.Drawing.Point(23, 434);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(134, 44);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Quitter";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnapp
            // 
            this.btnapp.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnapp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnapp.Location = new System.Drawing.Point(23, 329);
            this.btnapp.Name = "btnapp";
            this.btnapp.Size = new System.Drawing.Size(134, 42);
            this.btnapp.TabIndex = 4;
            this.btnapp.Text = "Applications";
            this.btnapp.UseVisualStyleBackColor = false;
            this.btnapp.Click += new System.EventHandler(this.btnapp_Click);
            // 
            // btncmd
            // 
            this.btncmd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btncmd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncmd.Location = new System.Drawing.Point(23, 175);
            this.btncmd.Name = "btncmd";
            this.btncmd.Size = new System.Drawing.Size(134, 39);
            this.btncmd.TabIndex = 3;
            this.btncmd.Text = "Console Admin PowerShell";
            this.btncmd.UseVisualStyleBackColor = false;
            this.btncmd.Click += new System.EventHandler(this.btncmd_Click);
            // 
            // btnnetwork
            // 
            this.btnnetwork.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnnetwork.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnnetwork.Location = new System.Drawing.Point(23, 123);
            this.btnnetwork.Name = "btnnetwork";
            this.btnnetwork.Size = new System.Drawing.Size(134, 39);
            this.btnnetwork.TabIndex = 1;
            this.btnnetwork.Text = "Réseaux";
            this.btnnetwork.UseVisualStyleBackColor = false;
            this.btnnetwork.Click += new System.EventHandler(this.btnnetwork_Click);
            // 
            // btnservice
            // 
            this.btnservice.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnservice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnservice.Location = new System.Drawing.Point(23, 28);
            this.btnservice.Name = "btnservice";
            this.btnservice.Size = new System.Drawing.Size(134, 41);
            this.btnservice.TabIndex = 0;
            this.btnservice.Text = "Services/Sécurité";
            this.btnservice.UseVisualStyleBackColor = false;
            this.btnservice.Click += new System.EventHandler(this.btnservice_Click);
            // 
            // btnAdCmd
            // 
            this.btnAdCmd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdCmd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdCmd.Location = new System.Drawing.Point(23, 227);
            this.btnAdCmd.Name = "btnAdCmd";
            this.btnAdCmd.Size = new System.Drawing.Size(134, 39);
            this.btnAdCmd.TabIndex = 9;
            this.btnAdCmd.Text = "Console Admin Cmd";
            this.btnAdCmd.UseVisualStyleBackColor = false;
            this.btnAdCmd.Click += new System.EventHandler(this.btnAdCmd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(932, 525);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GodMode";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnapp;
        private System.Windows.Forms.Button btncmd;
        private System.Windows.Forms.Button btnnetwork;
        private System.Windows.Forms.Button btnservice;
        private System.Windows.Forms.Button btnawin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAdCmd;
    }
}

