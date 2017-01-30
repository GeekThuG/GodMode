using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace GodMode
{
    public partial class FrmApplis : Form
    {
        public FrmApplis()
        {
            InitializeComponent();
        }

        // téléchargement de Adobe //
        Uri uri = new Uri("https://admdownload.adobe.com/bin/live/readerdc_fr_ha_install.exe");
        string filename = @"C:\Temp\adobe.exe";

        private void btnadobe_Click(object sender, EventArgs e)
        {

            try
            {
                if (File.Exists(filename))
                {
                    File.Delete(filename);
                }
                else
                {
                    WebClient wc = new WebClient();
                    wc.DownloadFileAsync(uri, filename);
                    wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged);
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(wc_DownloadFileCompleted);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void wc_DownloadProgressChanged(object sender, System.Net.DownloadProgressChangedEventArgs e)
        {

            progressBar1.Value = e.ProgressPercentage;
            if (progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Value = 0;
            }
        }
        private void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                MessageBox.Show("Téléchargement Terminé! , installation du logiciel", "Téléchargement Terminé!");
                Process.Start(filename);
            }
            else
            {
                MessageBox.Show("Impossible de lancer le téléchargement , Vérifiez votre connexion", "Téléchargement échoué!");
            }
        }

        // téléchargement Avast //
        Uri uri1 = new Uri("http://files.avast.com/iavs9x/avast_free_antivirus_setup_online.exe");
        string filename1 = @"C:\Temp\avast.exe";

        private void btnavast_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(filename1))
                {
                    File.Delete(filename1);
                }
                else
                {
                    WebClient wc = new WebClient();
                    wc.DownloadFileAsync(uri1, filename1);
                    wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged1);
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(wc_DownloadFileCompleted1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void wc_DownloadProgressChanged1(object sender, System.Net.DownloadProgressChangedEventArgs e)
        {

            progressBar1.Value = e.ProgressPercentage;
            if (progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Value = 0;
            }
        }
        private void wc_DownloadFileCompleted1(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                MessageBox.Show("Téléchargement Terminé! , installation du logiciel", "Téléchargement Terminé!");
                Process.Start(filename1);
            }
            else
            {
                MessageBox.Show("Impossible de lancer le téléchargement , Vérifiez votre connexion", "Téléchargement échoué!");
            }
        }

        // téléchargement de skype //
        Uri uri2 = new Uri("http://www.skype.com/go/getskype-full");
        string filename2 = @"C:\Temp\skype.exe";

        private void btnskype_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(filename2))
                {
                    File.Delete(filename2);
                }
                else
                {
                    WebClient wc = new WebClient();
                    wc.DownloadFileAsync(uri2, filename2);
                    wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged2);
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(wc_DownloadFileCompleted2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void wc_DownloadProgressChanged2(object sender, System.Net.DownloadProgressChangedEventArgs e)
        {

            progressBar1.Value = e.ProgressPercentage;
            if (progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Value = 0;
            }
        }
        private void wc_DownloadFileCompleted2(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                MessageBox.Show("Téléchargement Terminé! , installation du logiciel", "Téléchargement Terminé!");
                Process.Start(filename2);
            }
            else
            {
                MessageBox.Show("Impossible de lancer le téléchargement , Vérifiez votre connexion", "Téléchargement échoué!");
            }
        }

        // téléchargement de winrar //

        Uri uri3 = new Uri("http://www.rarlab.com/rar/winrar-x64-540fr.exe");
        string filename3 = @"C:\Temp\winrar.exe";

        private void btnwirar_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(filename3))
                {
                    File.Delete(filename3);
                }
                else
                {
                    WebClient wc = new WebClient();
                    wc.DownloadFileAsync(uri3, filename3);
                    wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged3);
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(wc_DownloadFileCompleted3);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void wc_DownloadProgressChanged3(object sender, System.Net.DownloadProgressChangedEventArgs e)
        {

            progressBar1.Value = e.ProgressPercentage;
            if (progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Value = 0;
            }
        }
        private void wc_DownloadFileCompleted3(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                MessageBox.Show("Téléchargement Terminé! , installation du logiciel", "Téléchargement Terminé!");
                Process.Start(filename3);
            }
            else
            {
                MessageBox.Show("Impossible de lancer le téléchargement , Vérifiez votre connexion", "Téléchargement échoué!");
            }
        }
    }
}
