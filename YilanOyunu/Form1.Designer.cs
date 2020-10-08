namespace YilanOyunu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.saha = new System.Windows.Forms.Panel();
            this.cmsSaha = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seviyeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKolay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiZor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSkorlar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOyunuBaslat = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAdınız = new MetroFramework.Controls.MetroTextBox();
            this.mlblAdınız = new MetroFramework.Controls.MetroLabel();
            this.mlblAdGiris = new MetroFramework.Controls.MetroLabel();
            this.lblYonerge = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblPause = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.saha.SuspendLayout();
            this.cmsSaha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // saha
            // 
            this.saha.BackColor = System.Drawing.Color.Black;
            this.saha.ContextMenuStrip = this.cmsSaha;
            this.saha.Controls.Add(this.btnOyunuBaslat);
            this.saha.Controls.Add(this.pictureBox1);
            this.saha.Controls.Add(this.txtAdınız);
            this.saha.Controls.Add(this.mlblAdınız);
            this.saha.Controls.Add(this.mlblAdGiris);
            this.saha.Controls.Add(this.lblYonerge);
            this.saha.Controls.Add(this.lblGameOver);
            this.saha.Controls.Add(this.lblPause);
            this.saha.Controls.Add(this.lblPuan);
            this.saha.Location = new System.Drawing.Point(7, 54);
            this.saha.Name = "saha";
            this.saha.Size = new System.Drawing.Size(400, 400);
            this.saha.TabIndex = 0;
            this.saha.Paint += new System.Windows.Forms.PaintEventHandler(this.saha_Paint);
            // 
            // cmsSaha
            // 
            this.cmsSaha.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seviyeToolStripMenuItem,
            this.tsmiSkorlar});
            this.cmsSaha.Name = "cmsSaha";
            this.cmsSaha.Size = new System.Drawing.Size(111, 48);
            // 
            // seviyeToolStripMenuItem
            // 
            this.seviyeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiKolay,
            this.tsmiZor});
            this.seviyeToolStripMenuItem.Name = "seviyeToolStripMenuItem";
            this.seviyeToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.seviyeToolStripMenuItem.Text = "Seviye";
            // 
            // tsmiKolay
            // 
            this.tsmiKolay.Name = "tsmiKolay";
            this.tsmiKolay.Size = new System.Drawing.Size(103, 22);
            this.tsmiKolay.Text = "Kolay";
            this.tsmiKolay.Click += new System.EventHandler(this.tsmiKolay_Click);
            // 
            // tsmiZor
            // 
            this.tsmiZor.Checked = true;
            this.tsmiZor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiZor.Name = "tsmiZor";
            this.tsmiZor.Size = new System.Drawing.Size(103, 22);
            this.tsmiZor.Text = "Zor";
            this.tsmiZor.Click += new System.EventHandler(this.tsmiZor_Click);
            // 
            // tsmiSkorlar
            // 
            this.tsmiSkorlar.Name = "tsmiSkorlar";
            this.tsmiSkorlar.Size = new System.Drawing.Size(110, 22);
            this.tsmiSkorlar.Text = "Skorlar";
            this.tsmiSkorlar.Click += new System.EventHandler(this.tsmiSkorlar_Click);
            // 
            // btnOyunuBaslat
            // 
            this.btnOyunuBaslat.Location = new System.Drawing.Point(141, 204);
            this.btnOyunuBaslat.Name = "btnOyunuBaslat";
            this.btnOyunuBaslat.Size = new System.Drawing.Size(116, 36);
            this.btnOyunuBaslat.TabIndex = 5;
            this.btnOyunuBaslat.Text = "Oyunu Başlat";
            this.btnOyunuBaslat.UseSelectable = true;
            this.btnOyunuBaslat.Click += new System.EventHandler(this.btnOyunuBaslat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtAdınız
            // 
            // 
            // 
            // 
            this.txtAdınız.CustomButton.Image = null;
            this.txtAdınız.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.txtAdınız.CustomButton.Name = "";
            this.txtAdınız.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAdınız.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdınız.CustomButton.TabIndex = 1;
            this.txtAdınız.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdınız.CustomButton.UseSelectable = true;
            this.txtAdınız.CustomButton.Visible = false;
            this.txtAdınız.Lines = new string[0];
            this.txtAdınız.Location = new System.Drawing.Point(141, 175);
            this.txtAdınız.MaxLength = 32767;
            this.txtAdınız.Name = "txtAdınız";
            this.txtAdınız.PasswordChar = '\0';
            this.txtAdınız.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdınız.SelectedText = "";
            this.txtAdınız.SelectionLength = 0;
            this.txtAdınız.SelectionStart = 0;
            this.txtAdınız.ShortcutsEnabled = true;
            this.txtAdınız.Size = new System.Drawing.Size(116, 23);
            this.txtAdınız.TabIndex = 2;
            this.txtAdınız.UseSelectable = true;
            this.txtAdınız.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdınız.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlblAdınız
            // 
            this.mlblAdınız.AutoSize = true;
            this.mlblAdınız.BackColor = System.Drawing.Color.White;
            this.mlblAdınız.Location = new System.Drawing.Point(141, 153);
            this.mlblAdınız.Name = "mlblAdınız";
            this.mlblAdınız.Size = new System.Drawing.Size(48, 19);
            this.mlblAdınız.TabIndex = 3;
            this.mlblAdınız.Text = "Adınız:";
            // 
            // mlblAdGiris
            // 
            this.mlblAdGiris.Location = new System.Drawing.Point(0, 0);
            this.mlblAdGiris.Name = "mlblAdGiris";
            this.mlblAdGiris.Size = new System.Drawing.Size(400, 400);
            this.mlblAdGiris.TabIndex = 1;
            // 
            // lblYonerge
            // 
            this.lblYonerge.BackColor = System.Drawing.Color.Transparent;
            this.lblYonerge.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYonerge.ForeColor = System.Drawing.Color.Lime;
            this.lblYonerge.Location = new System.Drawing.Point(22, 253);
            this.lblYonerge.Name = "lblYonerge";
            this.lblYonerge.Size = new System.Drawing.Size(359, 130);
            this.lblYonerge.TabIndex = 0;
            this.lblYonerge.Text = "Başlamak ve durdurmak için F2 tuşuna basınız.Yılanı hareket ettirmek için yön tuş" +
    "larını (←↑→↓) kullanınız.";
            this.lblYonerge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGameOver
            // 
            this.lblGameOver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGameOver.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOver.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Red;
            this.lblGameOver.Location = new System.Drawing.Point(36, 123);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(323, 130);
            this.lblGameOver.TabIndex = 0;
            this.lblGameOver.Text = "GAME OVER";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPause
            // 
            this.lblPause.BackColor = System.Drawing.Color.Transparent;
            this.lblPause.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPause.ForeColor = System.Drawing.Color.Lime;
            this.lblPause.Location = new System.Drawing.Point(36, 123);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(323, 130);
            this.lblPause.TabIndex = 0;
            this.lblPause.Text = "PAUSED\r\n(Devam için F2)";
            this.lblPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPuan
            // 
            this.lblPuan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPuan.BackColor = System.Drawing.Color.Transparent;
            this.lblPuan.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuan.ForeColor = System.Drawing.Color.PaleGreen;
            this.lblPuan.Location = new System.Drawing.Point(329, 0);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(71, 35);
            this.lblPuan.TabIndex = 0;
            this.lblPuan.Text = "000";
            this.lblPuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 465);
            this.Controls.Add(this.saha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(414, 465);
            this.Name = "Form1";
            this.Text = "Yılan Oyunu";
            this.TransparencyKey = System.Drawing.Color.SkyBlue;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.saha.ResumeLayout(false);
            this.saha.PerformLayout();
            this.cmsSaha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel saha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblYonerge;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.ContextMenuStrip cmsSaha;
        private System.Windows.Forms.ToolStripMenuItem seviyeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiKolay;
        private System.Windows.Forms.ToolStripMenuItem tsmiZor;
        private System.Windows.Forms.ToolStripMenuItem tsmiSkorlar;
        private MetroFramework.Controls.MetroButton btnOyunuBaslat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txtAdınız;
        private MetroFramework.Controls.MetroLabel mlblAdınız;
        private MetroFramework.Controls.MetroLabel mlblAdGiris;
    }
}

