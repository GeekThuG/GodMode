namespace GodMode
{
    partial class FrmApplis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmApplis));
            this.btnadobe = new System.Windows.Forms.Button();
            this.btnavast = new System.Windows.Forms.Button();
            this.btnskype = new System.Windows.Forms.Button();
            this.btnwirar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnadobe
            // 
            this.btnadobe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnadobe.BackgroundImage")));
            this.btnadobe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnadobe.Location = new System.Drawing.Point(52, 69);
            this.btnadobe.Name = "btnadobe";
            this.btnadobe.Size = new System.Drawing.Size(137, 100);
            this.btnadobe.TabIndex = 0;
            this.btnadobe.UseVisualStyleBackColor = true;
            this.btnadobe.Click += new System.EventHandler(this.btnadobe_Click);
            // 
            // btnavast
            // 
            this.btnavast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnavast.BackgroundImage")));
            this.btnavast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnavast.Location = new System.Drawing.Point(510, 75);
            this.btnavast.Name = "btnavast";
            this.btnavast.Size = new System.Drawing.Size(142, 94);
            this.btnavast.TabIndex = 1;
            this.btnavast.UseVisualStyleBackColor = true;
            this.btnavast.Click += new System.EventHandler(this.btnavast_Click);
            // 
            // btnskype
            // 
            this.btnskype.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnskype.BackgroundImage")));
            this.btnskype.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnskype.Location = new System.Drawing.Point(52, 250);
            this.btnskype.Name = "btnskype";
            this.btnskype.Size = new System.Drawing.Size(137, 104);
            this.btnskype.TabIndex = 2;
            this.btnskype.UseVisualStyleBackColor = true;
            this.btnskype.Click += new System.EventHandler(this.btnskype_Click);
            // 
            // btnwirar
            // 
            this.btnwirar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnwirar.BackgroundImage")));
            this.btnwirar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnwirar.Location = new System.Drawing.Point(510, 250);
            this.btnwirar.Name = "btnwirar";
            this.btnwirar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnwirar.Size = new System.Drawing.Size(142, 104);
            this.btnwirar.TabIndex = 3;
            this.btnwirar.UseVisualStyleBackColor = true;
            this.btnwirar.Click += new System.EventHandler(this.btnwirar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(249, 358);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(206, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chargement...";
            // 
            // FrmApplis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(742, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnwirar);
            this.Controls.Add(this.btnskype);
            this.Controls.Add(this.btnavast);
            this.Controls.Add(this.btnadobe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmApplis";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Applications";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadobe;
        private System.Windows.Forms.Button btnavast;
        private System.Windows.Forms.Button btnskype;
        private System.Windows.Forms.Button btnwirar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
    }
}