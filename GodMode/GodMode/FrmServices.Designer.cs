namespace GodMode
{
    partial class FrmServices
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnWinDef = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblwindef = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblHyperV = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblIIS = new System.Windows.Forms.Label();
            this.btnIISdis = new System.Windows.Forms.Button();
            this.btnIISactiv = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblFireWall = new System.Windows.Forms.Label();
            this.btnfiredisable = new System.Windows.Forms.Button();
            this.btnfireenable = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblcentresecu = new System.Windows.Forms.Label();
            this.btncsdis = new System.Windows.Forms.Button();
            this.btncsactiv = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.btnwupdis = new System.Windows.Forms.Button();
            this.btnwupactiv = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // btnWinDef
            // 
            this.btnWinDef.Location = new System.Drawing.Point(159, 19);
            this.btnWinDef.Name = "btnWinDef";
            this.btnWinDef.Size = new System.Drawing.Size(82, 33);
            this.btnWinDef.TabIndex = 8;
            this.btnWinDef.Text = "Activer";
            this.btnWinDef.UseVisualStyleBackColor = true;
            this.btnWinDef.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 32);
            this.button2.TabIndex = 9;
            this.button2.Text = "Désactiver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(151, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 33);
            this.button3.TabIndex = 10;
            this.button3.Text = "Désactiver";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(151, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 35);
            this.button4.TabIndex = 11;
            this.button4.Text = "Activer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblwindef
            // 
            this.lblwindef.AutoSize = true;
            this.lblwindef.Location = new System.Drawing.Point(10, 48);
            this.lblwindef.Name = "lblwindef";
            this.lblwindef.Size = new System.Drawing.Size(0, 13);
            this.lblwindef.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblwindef);
            this.groupBox1.Controls.Add(this.btnWinDef);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(34, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 107);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Windows Defender";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblHyperV);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(402, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 107);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hyper V";
            // 
            // lblHyperV
            // 
            this.lblHyperV.AutoSize = true;
            this.lblHyperV.Location = new System.Drawing.Point(9, 48);
            this.lblHyperV.Name = "lblHyperV";
            this.lblHyperV.Size = new System.Drawing.Size(0, 13);
            this.lblHyperV.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblIIS);
            this.groupBox3.Controls.Add(this.btnIISdis);
            this.groupBox3.Controls.Add(this.btnIISactiv);
            this.groupBox3.Location = new System.Drawing.Point(34, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 109);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "IIS";
            // 
            // lblIIS
            // 
            this.lblIIS.AutoSize = true;
            this.lblIIS.Location = new System.Drawing.Point(7, 46);
            this.lblIIS.Name = "lblIIS";
            this.lblIIS.Size = new System.Drawing.Size(0, 13);
            this.lblIIS.TabIndex = 2;
            // 
            // btnIISdis
            // 
            this.btnIISdis.Location = new System.Drawing.Point(159, 60);
            this.btnIISdis.Name = "btnIISdis";
            this.btnIISdis.Size = new System.Drawing.Size(82, 34);
            this.btnIISdis.TabIndex = 1;
            this.btnIISdis.Text = "Désativer";
            this.btnIISdis.UseVisualStyleBackColor = true;
            this.btnIISdis.Click += new System.EventHandler(this.btnIISdis_Click);
            // 
            // btnIISactiv
            // 
            this.btnIISactiv.Location = new System.Drawing.Point(159, 19);
            this.btnIISactiv.Name = "btnIISactiv";
            this.btnIISactiv.Size = new System.Drawing.Size(82, 35);
            this.btnIISactiv.TabIndex = 0;
            this.btnIISactiv.Text = "Activer";
            this.btnIISactiv.UseVisualStyleBackColor = true;
            this.btnIISactiv.Click += new System.EventHandler(this.btnIISactiv_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblFireWall);
            this.groupBox4.Controls.Add(this.btnfiredisable);
            this.groupBox4.Controls.Add(this.btnfireenable);
            this.groupBox4.Location = new System.Drawing.Point(402, 140);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(256, 109);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pare_feu Windows";
            // 
            // lblFireWall
            // 
            this.lblFireWall.AutoSize = true;
            this.lblFireWall.Location = new System.Drawing.Point(6, 46);
            this.lblFireWall.Name = "lblFireWall";
            this.lblFireWall.Size = new System.Drawing.Size(0, 13);
            this.lblFireWall.TabIndex = 5;
            // 
            // btnfiredisable
            // 
            this.btnfiredisable.Location = new System.Drawing.Point(151, 60);
            this.btnfiredisable.Name = "btnfiredisable";
            this.btnfiredisable.Size = new System.Drawing.Size(87, 34);
            this.btnfiredisable.TabIndex = 4;
            this.btnfiredisable.Text = "Désativer";
            this.btnfiredisable.UseVisualStyleBackColor = true;
            this.btnfiredisable.Click += new System.EventHandler(this.btnfiredisable_Click);
            // 
            // btnfireenable
            // 
            this.btnfireenable.Location = new System.Drawing.Point(151, 19);
            this.btnfireenable.Name = "btnfireenable";
            this.btnfireenable.Size = new System.Drawing.Size(87, 35);
            this.btnfireenable.TabIndex = 3;
            this.btnfireenable.Text = "Activer";
            this.btnfireenable.UseVisualStyleBackColor = true;
            this.btnfireenable.Click += new System.EventHandler(this.btnfireenable_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblcentresecu);
            this.groupBox5.Controls.Add(this.btncsdis);
            this.groupBox5.Controls.Add(this.btncsactiv);
            this.groupBox5.Location = new System.Drawing.Point(34, 278);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(261, 131);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Centre de Sécurité";
            // 
            // lblcentresecu
            // 
            this.lblcentresecu.AutoSize = true;
            this.lblcentresecu.Location = new System.Drawing.Point(10, 59);
            this.lblcentresecu.Name = "lblcentresecu";
            this.lblcentresecu.Size = new System.Drawing.Size(0, 13);
            this.lblcentresecu.TabIndex = 5;
            // 
            // btncsdis
            // 
            this.btncsdis.Location = new System.Drawing.Point(159, 70);
            this.btncsdis.Name = "btncsdis";
            this.btncsdis.Size = new System.Drawing.Size(82, 34);
            this.btncsdis.TabIndex = 4;
            this.btncsdis.Text = "Désativer";
            this.btncsdis.UseVisualStyleBackColor = true;
            this.btncsdis.Click += new System.EventHandler(this.btncsdis_Click);
            // 
            // btncsactiv
            // 
            this.btncsactiv.Location = new System.Drawing.Point(159, 29);
            this.btncsactiv.Name = "btncsactiv";
            this.btncsactiv.Size = new System.Drawing.Size(82, 35);
            this.btncsactiv.TabIndex = 3;
            this.btncsactiv.Text = "Activer";
            this.btncsactiv.UseVisualStyleBackColor = true;
            this.btncsactiv.Click += new System.EventHandler(this.btncsactiv_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblUpdate);
            this.groupBox6.Controls.Add(this.btnwupdis);
            this.groupBox6.Controls.Add(this.btnwupactiv);
            this.groupBox6.Location = new System.Drawing.Point(402, 280);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(256, 131);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Windows Update";
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(9, 57);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(0, 13);
            this.lblUpdate.TabIndex = 6;
            // 
            // btnwupdis
            // 
            this.btnwupdis.Location = new System.Drawing.Point(156, 68);
            this.btnwupdis.Name = "btnwupdis";
            this.btnwupdis.Size = new System.Drawing.Size(82, 34);
            this.btnwupdis.TabIndex = 6;
            this.btnwupdis.Text = "Désativer";
            this.btnwupdis.UseVisualStyleBackColor = true;
            this.btnwupdis.Click += new System.EventHandler(this.btnwupdis_Click);
            // 
            // btnwupactiv
            // 
            this.btnwupactiv.Location = new System.Drawing.Point(156, 27);
            this.btnwupactiv.Name = "btnwupactiv";
            this.btnwupactiv.Size = new System.Drawing.Size(82, 35);
            this.btnwupactiv.TabIndex = 5;
            this.btnwupactiv.Text = "Activer";
            this.btnwupactiv.UseVisualStyleBackColor = true;
            this.btnwupactiv.Click += new System.EventHandler(this.btnwupactiv_Click);
            // 
            // FrmServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(710, 499);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmServices";
            this.Load += new System.EventHandler(this.FrmServices_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnWinDef;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblwindef;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblHyperV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnIISdis;
        private System.Windows.Forms.Button btnIISactiv;
        private System.Windows.Forms.Label lblIIS;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnfiredisable;
        private System.Windows.Forms.Button btnfireenable;
        private System.Windows.Forms.Label lblFireWall;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btncsdis;
        private System.Windows.Forms.Button btncsactiv;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnwupdis;
        private System.Windows.Forms.Label lblcentresecu;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Button btnwupactiv;
    }
}