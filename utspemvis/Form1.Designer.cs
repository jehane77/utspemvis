namespace utspemvis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tombolMusik = new WindowsFormsApplication1.RoundButton();
            this.tombolStart = new WindowsFormsApplication1.RoundButton();
            this.tombolExit = new WindowsFormsApplication1.RoundButton();
            this.roundButton1 = new WindowsFormsApplication1.RoundButton();
            this.roundButton2 = new WindowsFormsApplication1.RoundButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "LOGO TEBAK GAMBAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "TEBAK GAMBAR 2018";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "gambar senyum";
            // 
            // tombolMusik
            // 
            this.tombolMusik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tombolMusik.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tombolMusik.Location = new System.Drawing.Point(734, 12);
            this.tombolMusik.Name = "tombolMusik";
            this.tombolMusik.Size = new System.Drawing.Size(54, 46);
            this.tombolMusik.TabIndex = 7;
            this.tombolMusik.Text = "SOUND";
            this.tombolMusik.UseVisualStyleBackColor = false;
            this.tombolMusik.Click += new System.EventHandler(this.tombolReview_Click);
            // 
            // tombolStart
            // 
            this.tombolStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tombolStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tombolStart.Location = new System.Drawing.Point(272, 277);
            this.tombolStart.Name = "tombolStart";
            this.tombolStart.Size = new System.Drawing.Size(109, 67);
            this.tombolStart.TabIndex = 4;
            this.tombolStart.Text = "START";
            this.tombolStart.UseVisualStyleBackColor = false;
            this.tombolStart.Click += new System.EventHandler(this.roundButton3_Click);
            // 
            // tombolExit
            // 
            this.tombolExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tombolExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tombolExit.Location = new System.Drawing.Point(412, 277);
            this.tombolExit.Name = "tombolExit";
            this.tombolExit.Size = new System.Drawing.Size(109, 67);
            this.tombolExit.TabIndex = 3;
            this.tombolExit.Text = "EXIT";
            this.tombolExit.UseVisualStyleBackColor = false;
            this.tombolExit.Click += new System.EventHandler(this.tombolExit_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.roundButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.roundButton1.Image = ((System.Drawing.Image)(resources.GetObject("roundButton1.Image")));
            this.roundButton1.Location = new System.Drawing.Point(335, 364);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(36, 36);
            this.roundButton1.TabIndex = 12;
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.roundButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.roundButton2.Image = ((System.Drawing.Image)(resources.GetObject("roundButton2.Image")));
            this.roundButton2.Location = new System.Drawing.Point(293, 364);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(36, 36);
            this.roundButton2.TabIndex = 13;
            this.roundButton2.UseVisualStyleBackColor = false;
            this.roundButton2.Click += new System.EventHandler(this.roundButton2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tombolMusik);
            this.Controls.Add(this.tombolStart);
            this.Controls.Add(this.tombolExit);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WindowsFormsApplication1.RoundButton tombolExit;
        private WindowsFormsApplication1.RoundButton tombolStart;
        private WindowsFormsApplication1.RoundButton tombolMusik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private WindowsFormsApplication1.RoundButton roundButton1;
        private WindowsFormsApplication1.RoundButton roundButton2;
    }
}

