using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3CX_FTP_Downloader
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// WebClient that will be doing the downloading
        /// </summary>
        WebClient m_WebClient;          
        /// <summary>
        /// The stopwatch which will be used to calculate the download speed
        /// </summary>
        Stopwatch m_StopWatch; 

        public MainForm()
        {
            InitializeComponent();
            // Initialize stopwatch
            m_StopWatch = new Stopwatch();
        }

        // Handles click on 'Download' button
        private void IDB_DOWNLOAD_Click(object sender, EventArgs e)
        {
            string filename = String.Empty;
            string pathToSavedFile = String.Empty;

            HideStatus();
            try
            {
                Uri URL = new Uri(IDT_URL.Text);
                // Get the name of file to be downloaded
                filename = Path.GetFileName(URL.AbsolutePath);
                // Verify that specified URI is a file
                if (filename.Equals(String.Empty)) throw new Exception("Invalid URI: This is not a file");

                pathToSavedFile = IDT_SAVETO.Text;
                // Verify that pathToSavedFile to saved file is not empty
                if (pathToSavedFile.Equals(String.Empty)) throw new Exception("Error: Path to saved file should not be empty");
                // Verify that pathToSavedFile to saved file exists
                if (!Directory.Exists(pathToSavedFile)) throw new Exception("Error: Path to saved file doesn't exist");

                ShowStatus(string.Format("Filename: {0}\nSaved to: {1}", filename, pathToSavedFile), false);
                EnableDownloadButton(false);

                // Start downloading
                DownloadFile(URL, pathToSavedFile + filename);
            }
            catch (Exception ex)
            {
                ShowStatus(ex.Message, false);
            }
        }

        // Handles click on '...' button (choose path to saved file)
        private void IDB_SAVETO_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                IDT_SAVETO.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        /// <summary>
        /// Method starting async downloading of requested file
        /// </summary>
        /// <param name="url">URL of file to download</param>
        /// <param name="location">Full path with name of the saved file</param>
        public void DownloadFile(Uri url, string location)
        {
            using (m_WebClient = new WebClient())
            {
                m_WebClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                m_WebClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

                // Start the stopwatch which we will be using to calculate the download speed
                m_StopWatch.Start();

                try
                {
                    // Start downloading the file
                    m_WebClient.DownloadFileAsync(url, location);
                }
                catch (Exception ex)
                {
                    // Show error message in status holder if any arised
                    IDT_STATUS.Invoke((MethodInvoker)delegate { IDT_STATUS.Text = ex.Message; });
                }
            }
        }

        // The event that will fire whenever the progress of the WebClient is changed
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // Download speed in bytes per second
            double downloadSpeedBytes = e.BytesReceived / m_StopWatch.Elapsed.TotalSeconds;
            // Calculate download speed in kb/s
            IDT_TRANSFERRATE.Text = string.Format("{0} kb/s", (downloadSpeedBytes / 1024d).ToString("0.00"));

            // Update the progressbar percentage only when the value is not the same.
            IDPB_DOWNLOADPROGRESS.Value = e.ProgressPercentage;

            // Calculate estimated time left to complete download.
            IDT_TIMELEFT.Text = string.Format("{0} sec", 
                ((e.TotalBytesToReceive - e.BytesReceived) / downloadSpeedBytes).ToString("0.00"));

            // Show the amount of downloaded bytes
            IDT_DOWNLOADEDBYTES.Text = string.Format("{0} MB's / {1} MB's",
                (e.BytesReceived / 1024d / 1024d).ToString("0.00"),
                (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));
        }

        // The event that will trigger when the WebClient is completed
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            // Reset the stopwatch.
            m_StopWatch.Reset();
            EnableDownloadButton(true);
            if (e.Error != null)
            {
                string error = e.Error.ToString();
                // Show error message in status holder if any arised
                IDT_STATUS.Invoke((MethodInvoker)delegate { IDT_STATUS.Text = error; });
                return;
            }
            
            if (e.Cancelled == true)
            {
                IDT_STATUS.Invoke((MethodInvoker)delegate { IDT_STATUS.Text = "Download canceled"; });
            }
            else
            {
                IDT_STATUS.Invoke((MethodInvoker)delegate { IDT_STATUS.Text = "Download completed!"; });
            }
            
        }

        #region Tools
        /// <summary>
        /// Show message in status holder
        /// </summary>
        /// <param name="message">Message to show</param>
        /// <param name="append">Flag showing whether message will be appended to any existing messages. If False will truncate all previous messages</param>
        private void ShowStatus(string message, bool append)
        {
            if (!IDT_STATUS.Visible) IDT_STATUS.Visible = true;
            if (append) IDT_STATUS.Text += message;
            else IDT_STATUS.Text = message;
        }

        /// <summary>
        /// Hide status holder
        /// </summary>
        private void HideStatus()
        {
            if (IDT_STATUS.Visible) IDT_STATUS.Visible = false;
        }

        /// <summary>
        /// Enables/disables download button
        /// </summary>
        /// <param name="enabled">True to enable download button, false to disable</param>
        private void EnableDownloadButton(bool enabled)
        {
            IDB_DOWNLOAD.Enabled = enabled;
        }
        #endregion

        
    }
}

