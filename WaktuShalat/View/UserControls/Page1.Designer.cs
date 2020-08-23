namespace WaktuShalat.View.UserControls
{
    partial class Page1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblSubtitle = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.CheckAudio = new MaterialSkin.Controls.MaterialCheckBox();
            this.CheckNotif = new MaterialSkin.Controls.MaterialCheckBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblSubtitle
            // 
            this.LblSubtitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSubtitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubtitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LblSubtitle.Location = new System.Drawing.Point(114, 274);
            this.LblSubtitle.Name = "LblSubtitle";
            this.LblSubtitle.Size = new System.Drawing.Size(545, 64);
            this.LblSubtitle.TabIndex = 17;
            this.LblSubtitle.Text = "Deteksi Lokasi Otomatis ";
            this.LblSubtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblTitle
            // 
            this.LblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(46, 239);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(685, 30);
            this.LblTitle.TabIndex = 16;
            this.LblTitle.Text = "Deteksi Lokasi Otomatis ";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckAudio
            // 
            this.CheckAudio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckAudio.AutoSize = true;
            this.CheckAudio.Checked = true;
            this.CheckAudio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckAudio.Depth = 0;
            this.CheckAudio.Font = new System.Drawing.Font("Roboto", 10F);
            this.CheckAudio.Location = new System.Drawing.Point(283, 388);
            this.CheckAudio.Margin = new System.Windows.Forms.Padding(0);
            this.CheckAudio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckAudio.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckAudio.Name = "CheckAudio";
            this.CheckAudio.Ripple = true;
            this.CheckAudio.Size = new System.Drawing.Size(191, 30);
            this.CheckAudio.TabIndex = 15;
            this.CheckAudio.Text = "Aktifkan Audio saat adzan";
            this.CheckAudio.UseVisualStyleBackColor = true;
            // 
            // CheckNotif
            // 
            this.CheckNotif.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckNotif.AutoSize = true;
            this.CheckNotif.Checked = true;
            this.CheckNotif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckNotif.Depth = 0;
            this.CheckNotif.Font = new System.Drawing.Font("Roboto", 10F);
            this.CheckNotif.Location = new System.Drawing.Point(283, 348);
            this.CheckNotif.Margin = new System.Windows.Forms.Padding(0);
            this.CheckNotif.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckNotif.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckNotif.Name = "CheckNotif";
            this.CheckNotif.Ripple = true;
            this.CheckNotif.Size = new System.Drawing.Size(215, 30);
            this.CheckNotif.TabIndex = 14;
            this.CheckNotif.Text = "Aktifkan Notifikasi saat adzan";
            this.CheckNotif.UseVisualStyleBackColor = true;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox1.Image = global::WaktuShalat.Properties.Resources.WaktuShalat_logo;
            this.PictureBox1.Location = new System.Drawing.Point(173, 22);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(404, 214);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 13;
            this.PictureBox1.TabStop = false;
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.LblSubtitle);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.CheckAudio);
            this.Controls.Add(this.CheckNotif);
            this.Controls.Add(this.PictureBox1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(776, 440);
            this.Load += new System.EventHandler(this.Page1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label LblSubtitle;
        internal System.Windows.Forms.Label LblTitle;
        internal MaterialSkin.Controls.MaterialCheckBox CheckAudio;
        internal MaterialSkin.Controls.MaterialCheckBox CheckNotif;
        internal System.Windows.Forms.PictureBox PictureBox1;
    }
}
