namespace WaktuShalat.View
{
    partial class Cities
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
            this.materialPanel1 = new MaterialFramework.MaterialPanel();
            this.materialLabel1 = new MaterialFramework.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listCity = new System.Windows.Forms.ListBox();
            this.materialPanel2 = new MaterialFramework.MaterialPanel();
            this.materialLabel2 = new MaterialFramework.MaterialLabel();
            this.TxtSearch = new MaterialFramework.LollipopTextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnPilih = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.materialPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.materialPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialPanel1
            // 
            this.materialPanel1.Controls.Add(this.materialLabel1);
            this.materialPanel1.Controls.Add(this.pictureBox1);
            this.materialPanel1.DarkTheme = false;
            this.materialPanel1.Location = new System.Drawing.Point(-6, -2);
            this.materialPanel1.Name = "materialPanel1";
            this.materialPanel1.Size = new System.Drawing.Size(573, 42);
            this.materialPanel1.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.materialLabel1.FontSize = 10;
            this.materialLabel1.FontWeight = MaterialFramework.FontType.Medium;
            this.materialLabel1.Location = new System.Drawing.Point(42, 12);
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(90, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "WaktuShalat";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WaktuShalat.Properties.Resources.WaktuShalat_logo;
            this.pictureBox1.Location = new System.Drawing.Point(14, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // listCity
            // 
            this.listCity.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listCity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCity.FormattingEnabled = true;
            this.listCity.Location = new System.Drawing.Point(11, 75);
            this.listCity.Name = "listCity";
            this.listCity.Size = new System.Drawing.Size(519, 260);
            this.listCity.TabIndex = 1;
            // 
            // materialPanel2
            // 
            this.materialPanel2.Controls.Add(this.materialLabel2);
            this.materialPanel2.Controls.Add(this.TxtSearch);
            this.materialPanel2.Controls.Add(this.lblTotal);
            this.materialPanel2.Controls.Add(this.label2);
            this.materialPanel2.Controls.Add(this.listCity);
            this.materialPanel2.DarkTheme = false;
            this.materialPanel2.Location = new System.Drawing.Point(12, 58);
            this.materialPanel2.Name = "materialPanel2";
            this.materialPanel2.Size = new System.Drawing.Size(540, 349);
            this.materialPanel2.TabIndex = 2;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.materialLabel2.FontSize = 10;
            this.materialLabel2.FontWeight = MaterialFramework.FontType.Medium;
            this.materialLabel2.Location = new System.Drawing.Point(9, 12);
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(138, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Kota Yang Didukung";
            // 
            // TxtSearch
            // 
            this.TxtSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtSearch.DarkTheme = false;
            this.TxtSearch.FocusedColor = "#508ef5";
            this.TxtSearch.FontColor = "#999999";
            this.TxtSearch.IsEnabled = true;
            this.TxtSearch.Location = new System.Drawing.Point(11, 46);
            this.TxtSearch.MaxLength = 32767;
            this.TxtSearch.Multiline = false;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.ReadOnly = false;
            this.TxtSearch.Size = new System.Drawing.Size(216, 24);
            this.TxtSearch.TabIndex = 6;
            this.TxtSearch.Text = "Cari..";
            this.TxtSearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtSearch.UseSystemPasswordChar = false;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotal.Location = new System.Drawing.Point(471, 57);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "totalkota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total :";
            // 
            // BtnPilih
            // 
            this.BtnPilih.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnPilih.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPilih.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPilih.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnPilih.Location = new System.Drawing.Point(477, 419);
            this.BtnPilih.Name = "BtnPilih";
            this.BtnPilih.Size = new System.Drawing.Size(75, 34);
            this.BtnPilih.TabIndex = 22;
            this.BtnPilih.Text = "Pilih";
            this.BtnPilih.UseVisualStyleBackColor = false;
            this.BtnPilih.Click += new System.EventHandler(this.BtnPilih_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnCancel.Location = new System.Drawing.Point(12, 419);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 34);
            this.BtnCancel.TabIndex = 23;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // Cities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(564, 465);
            this.Controls.Add(this.BtnPilih);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.materialPanel2);
            this.Controls.Add(this.materialPanel1);
            this.Name = "Cities";
            this.ShowIcon = false;
            this.Text = "Cities";
            this.Load += new System.EventHandler(this.Cities_Load);
            this.materialPanel1.ResumeLayout(false);
            this.materialPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.materialPanel2.ResumeLayout(false);
            this.materialPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialFramework.MaterialPanel materialPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listCity;
        private MaterialFramework.MaterialPanel materialPanel2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private MaterialFramework.LollipopTextBox TxtSearch;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnPilih;
        private MaterialFramework.MaterialLabel materialLabel1;
        private MaterialFramework.MaterialLabel materialLabel2;
    }
}