namespace _3CX_FTP_Downloader
{
    partial class MainForm
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
            this.IDPB_DOWNLOADPROGRESS = new System.Windows.Forms.ProgressBar();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblTransferRate = new System.Windows.Forms.Label();
            this.lblEstimatedTime = new System.Windows.Forms.Label();
            this.IDT_URL = new System.Windows.Forms.TextBox();
            this.IDB_DOWNLOAD = new System.Windows.Forms.Button();
            this.lblDownloadedBytes = new System.Windows.Forms.Label();
            this.IDT_STATUS = new System.Windows.Forms.TextBox();
            this.IDT_TRANSFERRATE = new System.Windows.Forms.TextBox();
            this.IDT_TIMELEFT = new System.Windows.Forms.TextBox();
            this.IDT_DOWNLOADEDBYTES = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.IDT_SAVETO = new System.Windows.Forms.TextBox();
            this.IDB_SAVETO = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // IDPB_DOWNLOADPROGRESS
            // 
            this.IDPB_DOWNLOADPROGRESS.Location = new System.Drawing.Point(12, 100);
            this.IDPB_DOWNLOADPROGRESS.Name = "IDPB_DOWNLOADPROGRESS";
            this.IDPB_DOWNLOADPROGRESS.Size = new System.Drawing.Size(513, 23);
            this.IDPB_DOWNLOADPROGRESS.TabIndex = 0;
            // 
            // lblUrl
            // 
            this.lblUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUrl.Location = new System.Drawing.Point(12, 20);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(100, 23);
            this.lblUrl.TabIndex = 1;
            this.lblUrl.Text = "URL:";
            this.lblUrl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTransferRate
            // 
            this.lblTransferRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTransferRate.Location = new System.Drawing.Point(12, 140);
            this.lblTransferRate.Name = "lblTransferRate";
            this.lblTransferRate.Size = new System.Drawing.Size(100, 23);
            this.lblTransferRate.TabIndex = 2;
            this.lblTransferRate.Text = "Transfer rate:";
            this.lblTransferRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEstimatedTime
            // 
            this.lblEstimatedTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEstimatedTime.Location = new System.Drawing.Point(12, 180);
            this.lblEstimatedTime.Name = "lblEstimatedTime";
            this.lblEstimatedTime.Size = new System.Drawing.Size(100, 23);
            this.lblEstimatedTime.TabIndex = 3;
            this.lblEstimatedTime.Text = "Estimated time left:";
            this.lblEstimatedTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IDT_URL
            // 
            this.IDT_URL.Location = new System.Drawing.Point(118, 22);
            this.IDT_URL.Name = "IDT_URL";
            this.IDT_URL.Size = new System.Drawing.Size(326, 20);
            this.IDT_URL.TabIndex = 4;
            // 
            // IDB_DOWNLOAD
            // 
            this.IDB_DOWNLOAD.Location = new System.Drawing.Point(450, 20);
            this.IDB_DOWNLOAD.Name = "IDB_DOWNLOAD";
            this.IDB_DOWNLOAD.Size = new System.Drawing.Size(75, 23);
            this.IDB_DOWNLOAD.TabIndex = 5;
            this.IDB_DOWNLOAD.Text = "Download";
            this.IDB_DOWNLOAD.UseVisualStyleBackColor = true;
            this.IDB_DOWNLOAD.Click += new System.EventHandler(this.IDB_DOWNLOAD_Click);
            // 
            // lblDownloadedBytes
            // 
            this.lblDownloadedBytes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDownloadedBytes.Location = new System.Drawing.Point(12, 220);
            this.lblDownloadedBytes.Name = "lblDownloadedBytes";
            this.lblDownloadedBytes.Size = new System.Drawing.Size(100, 23);
            this.lblDownloadedBytes.TabIndex = 6;
            this.lblDownloadedBytes.Text = "Downloaded bytes:";
            this.lblDownloadedBytes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IDT_STATUS
            // 
            this.IDT_STATUS.Enabled = false;
            this.IDT_STATUS.Location = new System.Drawing.Point(12, 260);
            this.IDT_STATUS.Multiline = true;
            this.IDT_STATUS.Name = "IDT_STATUS";
            this.IDT_STATUS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.IDT_STATUS.Size = new System.Drawing.Size(513, 72);
            this.IDT_STATUS.TabIndex = 7;
            // 
            // IDT_TRANSFERRATE
            // 
            this.IDT_TRANSFERRATE.Enabled = false;
            this.IDT_TRANSFERRATE.Location = new System.Drawing.Point(118, 142);
            this.IDT_TRANSFERRATE.Name = "IDT_TRANSFERRATE";
            this.IDT_TRANSFERRATE.Size = new System.Drawing.Size(154, 20);
            this.IDT_TRANSFERRATE.TabIndex = 8;
            // 
            // IDT_TIMELEFT
            // 
            this.IDT_TIMELEFT.Enabled = false;
            this.IDT_TIMELEFT.Location = new System.Drawing.Point(118, 182);
            this.IDT_TIMELEFT.Name = "IDT_TIMELEFT";
            this.IDT_TIMELEFT.Size = new System.Drawing.Size(154, 20);
            this.IDT_TIMELEFT.TabIndex = 9;
            // 
            // IDT_DOWNLOADEDBYTES
            // 
            this.IDT_DOWNLOADEDBYTES.Enabled = false;
            this.IDT_DOWNLOADEDBYTES.Location = new System.Drawing.Point(118, 222);
            this.IDT_DOWNLOADEDBYTES.Name = "IDT_DOWNLOADEDBYTES";
            this.IDT_DOWNLOADEDBYTES.Size = new System.Drawing.Size(154, 20);
            this.IDT_DOWNLOADEDBYTES.TabIndex = 10;
            // 
            // lblPath
            // 
            this.lblPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPath.Location = new System.Drawing.Point(12, 60);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(100, 23);
            this.lblPath.TabIndex = 11;
            this.lblPath.Text = "Save to:";
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IDT_SAVETO
            // 
            this.IDT_SAVETO.Location = new System.Drawing.Point(118, 62);
            this.IDT_SAVETO.Name = "IDT_SAVETO";
            this.IDT_SAVETO.Size = new System.Drawing.Size(326, 20);
            this.IDT_SAVETO.TabIndex = 12;
            // 
            // IDB_SAVETO
            // 
            this.IDB_SAVETO.Location = new System.Drawing.Point(450, 62);
            this.IDB_SAVETO.Name = "IDB_SAVETO";
            this.IDB_SAVETO.Size = new System.Drawing.Size(33, 23);
            this.IDB_SAVETO.TabIndex = 13;
            this.IDB_SAVETO.Text = "...";
            this.IDB_SAVETO.UseVisualStyleBackColor = true;
            this.IDB_SAVETO.Click += new System.EventHandler(this.IDB_SAVETO_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 336);
            this.Controls.Add(this.IDB_SAVETO);
            this.Controls.Add(this.IDT_SAVETO);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.IDT_DOWNLOADEDBYTES);
            this.Controls.Add(this.IDT_TIMELEFT);
            this.Controls.Add(this.IDT_TRANSFERRATE);
            this.Controls.Add(this.IDT_STATUS);
            this.Controls.Add(this.lblDownloadedBytes);
            this.Controls.Add(this.IDB_DOWNLOAD);
            this.Controls.Add(this.IDT_URL);
            this.Controls.Add(this.lblEstimatedTime);
            this.Controls.Add(this.lblTransferRate);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.IDPB_DOWNLOADPROGRESS);
            this.Name = "MainForm";
            this.Text = "3CX_FTP_Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar IDPB_DOWNLOADPROGRESS;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblTransferRate;
        private System.Windows.Forms.Label lblEstimatedTime;
        private System.Windows.Forms.TextBox IDT_URL;
        private System.Windows.Forms.Button IDB_DOWNLOAD;
        private System.Windows.Forms.Label lblDownloadedBytes;
        private System.Windows.Forms.TextBox IDT_STATUS;
        private System.Windows.Forms.TextBox IDT_TRANSFERRATE;
        private System.Windows.Forms.TextBox IDT_TIMELEFT;
        private System.Windows.Forms.TextBox IDT_DOWNLOADEDBYTES;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox IDT_SAVETO;
        private System.Windows.Forms.Button IDB_SAVETO;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

