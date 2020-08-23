namespace WaktuShalat.View.UserControls
{
    partial class Page3
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.GetLocationWorker = new System.ComponentModel.BackgroundWorker();
            this.Label1 = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.LblLocality = new System.Windows.Forms.Label();
            this.LblFormattedAddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(776, 29);
            this.Panel1.TabIndex = 16;
            // 
            // GetLocationWorker
            // 
            this.GetLocationWorker.WorkerReportsProgress = true;
            this.GetLocationWorker.WorkerSupportsCancellation = true;
            this.GetLocationWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.GetLocationWorker_DoWork);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(16, 67);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(130, 30);
            this.Label1.TabIndex = 21;
            this.Label1.Text = "Lokasi Anda ";
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(8, 393);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(37, 13);
            this.LblStatus.TabIndex = 20;
            this.LblStatus.Text = "Status";
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(11, 409);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(752, 23);
            this.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ProgressBar1.TabIndex = 19;
            // 
            // LblLocality
            // 
            this.LblLocality.AutoEllipsis = true;
            this.LblLocality.AutoSize = true;
            this.LblLocality.BackColor = System.Drawing.Color.Transparent;
            this.LblLocality.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.LblLocality.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblLocality.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblLocality.Location = new System.Drawing.Point(17, 108);
            this.LblLocality.Name = "LblLocality";
            this.LblLocality.Size = new System.Drawing.Size(186, 20);
            this.LblLocality.TabIndex = 17;
            this.LblLocality.Text = "Mendeteksi Lokasi Anda...";
            // 
            // LblFormattedAddress
            // 
            this.LblFormattedAddress.AutoEllipsis = true;
            this.LblFormattedAddress.BackColor = System.Drawing.Color.Transparent;
            this.LblFormattedAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LblFormattedAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblFormattedAddress.Location = new System.Drawing.Point(18, 128);
            this.LblFormattedAddress.Name = "LblFormattedAddress";
            this.LblFormattedAddress.Size = new System.Drawing.Size(660, 41);
            this.LblFormattedAddress.TabIndex = 18;
            this.LblFormattedAddress.Text = "Mendeteksi Alamat Anda..";
            // 
            // Page3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.LblLocality);
            this.Controls.Add(this.LblFormattedAddress);
            this.Name = "Page3";
            this.Size = new System.Drawing.Size(776, 440);
            this.Load += new System.EventHandler(this.Page3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.ComponentModel.BackgroundWorker GetLocationWorker;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LblStatus;
        internal System.Windows.Forms.ProgressBar ProgressBar1;
        internal System.Windows.Forms.Label LblLocality;
        internal System.Windows.Forms.Label LblFormattedAddress;
    }
}
