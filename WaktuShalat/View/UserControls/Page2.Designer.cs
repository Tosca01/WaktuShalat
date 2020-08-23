namespace WaktuShalat.View.UserControls
{
    partial class Page2
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
            this.LinkSave = new MetroFramework.Controls.MetroLink();
            this.TxtCity = new MaterialFramework.LollipopTextBox();
            this.CheckDetect = new MaterialSkin.Controls.MaterialCheckBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCekKota = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LinkSave
            // 
            this.LinkSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LinkSave.Image = global::WaktuShalat.Properties.Resources.baseline_done_black_24dp;
            this.LinkSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LinkSave.Location = new System.Drawing.Point(318, 400);
            this.LinkSave.Name = "LinkSave";
            this.LinkSave.Size = new System.Drawing.Size(147, 23);
            this.LinkSave.TabIndex = 20;
            this.LinkSave.Text = "Save lokasi";
            this.LinkSave.UseSelectable = true;
            this.LinkSave.Visible = false;
            this.LinkSave.Click += new System.EventHandler(this.LinkSave_Click);
            // 
            // TxtCity
            // 
            this.TxtCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCity.DarkTheme = false;
            this.TxtCity.FocusedColor = "#508ef5";
            this.TxtCity.FontColor = "#999999";
            this.TxtCity.IsEnabled = false;
            this.TxtCity.Location = new System.Drawing.Point(250, 340);
            this.TxtCity.MaxLength = 32767;
            this.TxtCity.Multiline = false;
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.ReadOnly = true;
            this.TxtCity.Size = new System.Drawing.Size(276, 24);
            this.TxtCity.TabIndex = 19;
            this.TxtCity.Text = "Nama kota";
            this.TxtCity.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtCity.UseSystemPasswordChar = false;
            this.TxtCity.Visible = false;
            // 
            // CheckDetect
            // 
            this.CheckDetect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckDetect.AutoSize = true;
            this.CheckDetect.Checked = true;
            this.CheckDetect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckDetect.Depth = 0;
            this.CheckDetect.Font = new System.Drawing.Font("Roboto", 10F);
            this.CheckDetect.Location = new System.Drawing.Point(267, 298);
            this.CheckDetect.Margin = new System.Windows.Forms.Padding(0);
            this.CheckDetect.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckDetect.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckDetect.Name = "CheckDetect";
            this.CheckDetect.Ripple = true;
            this.CheckDetect.Size = new System.Drawing.Size(235, 30);
            this.CheckDetect.TabIndex = 18;
            this.CheckDetect.Text = "Aktifkan Deteksi Lokasi Otomatis";
            this.CheckDetect.UseVisualStyleBackColor = true;
            this.CheckDetect.CheckedChanged += new System.EventHandler(this.CheckDetect_CheckedChanged);
            // 
            // LblTitle
            // 
            this.LblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(46, 254);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(685, 30);
            this.LblTitle.TabIndex = 17;
            this.LblTitle.Text = "Deteksi Lokasi Otomatis ";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox1.Image = global::WaktuShalat.Properties.Resources.Artboard_1_2x;
            this.PictureBox1.Location = new System.Drawing.Point(173, 37);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(404, 214);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 16;
            this.PictureBox1.TabStop = false;
            // 
            // BtnCekKota
            // 
            this.BtnCekKota.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnCekKota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCekKota.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCekKota.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCekKota.Location = new System.Drawing.Point(533, 331);
            this.BtnCekKota.Name = "BtnCekKota";
            this.BtnCekKota.Size = new System.Drawing.Size(74, 34);
            this.BtnCekKota.TabIndex = 21;
            this.BtnCekKota.Text = "Pilih Kota";
            this.BtnCekKota.UseVisualStyleBackColor = false;
            this.BtnCekKota.Visible = false;
            this.BtnCekKota.Click += new System.EventHandler(this.BtnCekKota_Click);
            // 
            // Page2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.BtnCekKota);
            this.Controls.Add(this.LinkSave);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.CheckDetect);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.PictureBox1);
            this.Name = "Page2";
            this.Size = new System.Drawing.Size(776, 440);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal MetroFramework.Controls.MetroLink LinkSave;
        internal MaterialFramework.LollipopTextBox TxtCity;
        internal MaterialSkin.Controls.MaterialCheckBox CheckDetect;
        internal System.Windows.Forms.Label LblTitle;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button BtnCekKota;
    }
}
