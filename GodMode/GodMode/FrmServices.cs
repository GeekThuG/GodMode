//M.kabiri
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.ServiceProcess;
using System.IO;

namespace GodMode
{
    public partial class FrmServices : Form
    {
        //ServiceController myservice = new ServiceController();
        //string i = "";
       // int a = 0;
        public void init_services(){
            try
            {
                ServiceController[] scServices;
                scServices = ServiceController.GetServices();

                foreach (ServiceController scTemp in scServices)
                {
                    if (scTemp.ServiceName.ToString() == "wuauserv" && scTemp.ServiceName == "wuauserv")
                    {

                        if (scTemp.Status.ToString() == "Running")
                        {
                            lblUpdate.Text = "Active";
                        }
                        else if (scTemp.Status.ToString() == "Stopped")
                            lblUpdate.Text = "Désactive";

                    }


                    else if (scTemp.ServiceName.ToString() == "WinDefend" && scTemp.ServiceName == "WinDefend")
                    {

                        if (scTemp.Status.ToString() == "Running")
                        {
                            lblwindef.Text = "Active";
                        }
                        else if (scTemp.Status.ToString() == "Stopped")
                            lblwindef.Text = "Désactive";

                    }

                    else if (scTemp.ServiceName.ToString() == "MpsSvc" && scTemp.ServiceName == "MpsSvc")
                    {

                        if (scTemp.Status.ToString() == "Running")
                        {
                            //MessageBox.Show("here Active");
                            lblFireWall.Text = "Active";
                        }
                        else if (scTemp.Status.ToString() == "Stopped")
                        {
                            //MessageBox.Show("here Désactive");
                            lblFireWall.Text = "Désactive";
                        }
                    }

                    else if (scTemp.ServiceName.ToString() == "vmickvpexchange")
                    {

                    }

                    else if (scTemp.ServiceName.ToString() == "vmickvpexchange" && scTemp.ServiceName == "vmickvpexchange")
                    {

                        if (scTemp.Status.ToString() == "Running")
                        {
                            lblHyperV.Text = "Active";
                        }
                        else if (scTemp.Status.ToString() == "Stopped")
                            lblHyperV.Text = "Désactive";
                    }


                    else if (scTemp.ServiceName.ToString() == "wscsvc" && scTemp.ServiceName == "wscsvc")
                    {

                        if (scTemp.Status.ToString() == "Running")
                        {
                            lblcentresecu.Text = "Active";
                        }
                        else if (scTemp.Status.ToString() == "Stopped")
                            lblcentresecu.Text = "Désactive";
                    }

                    else if (scTemp.ServiceName.ToString() == "IISADMIN" && scTemp.ServiceName == "IISADMIN")
                    {

                        if (scTemp.Status.ToString() == "Running")
                        {
                            lblIIS.Text = "Active";
                        }
                        else if (scTemp.Status.ToString() == "Stopped")
                        {
                            lblIIS.Text = "Désactive";
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Warinng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public FrmServices()
        {
            InitializeComponent();
            init_services();
           
        }

        private void FrmServices_Load(object sender, EventArgs e)
        {

        }

       
        /// <summary>
        /// Activation button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        /// <summary>
        /// Disable button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Start windows defender
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            System.Diagnostics.ProcessStartInfo ProcessInfo;
            System.Diagnostics.Process Process;

            ProcessInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe", "/K " + @" sc start WinDefend");
            ProcessInfo.CreateNoWindow = true;
            ProcessInfo.UseShellExecute = true;
            ProcessInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Process = System.Diagnostics.Process.Start(ProcessInfo);
            lblwindef.Text = "Active";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "Error");
            }
        }
        /// <summary>
        /// stop windows defender
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.ProcessStartInfo ProcessInfo;
                System.Diagnostics.Process Process;

                ProcessInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe", "/K " + @" sc stop WinDefend");
                ProcessInfo.CreateNoWindow = true;
                ProcessInfo.UseShellExecute = true;
                ProcessInfo.WindowStyle = ProcessWindowStyle.Hidden;
            
                Process = System.Diagnostics.Process.Start(ProcessInfo);
                lblwindef.Text = "Désactivé";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "Error");
            }
            
        }
        /// <summary>
        /// disable hyper v
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.ProcessStartInfo ProcessInfo;
                System.Diagnostics.Process Process;

                ProcessInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe", "/K " + @" dism.exe /Online /Disable-Feature:Microsoft-Hyper-V-All");
                ProcessInfo.CreateNoWindow = true;
                ProcessInfo.UseShellExecute = true;
                ProcessInfo.WindowStyle = ProcessWindowStyle.Hidden;
            
                Process = System.Diagnostics.Process.Start(ProcessInfo);
                lblHyperV.Text = "Désactivé";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Le service n'est pas installé sur votre ordinateur " + "Error");
            }
        }
        /// <summary>
        /// enable hyper v
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.ProcessStartInfo ProcessInfo;
                System.Diagnostics.Process Process;

                ProcessInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe", "/K " + @" dism.exe /Online /Enable-Feature:Microsoft-Hyper-V /All");
                ProcessInfo.CreateNoWindow = true;
                ProcessInfo.UseShellExecute = true;
                ProcessInfo.WindowStyle = ProcessWindowStyle.Hidden;
            
                Process = System.Diagnostics.Process.Start(ProcessInfo);
                lblHyperV.Text = "Active";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Le service n'est pas installé sur votre ordinateur " + "Error");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnfireenable_Click(object sender, EventArgs e)
        {
            try
            {
                Process proc = new Process();
                string top = "netsh.exe";
                proc.StartInfo.Arguments = "Firewall set opmode enable";
                proc.StartInfo.FileName = top;
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.CreateNoWindow = true;
                proc.Start();
                proc.WaitForExit();
                lblFireWall.Text = "Active";
                init_services();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()+"Error");
            }

            lblFireWall.Text = "Activé";
        }

        private void btnfiredisable_Click(object sender, EventArgs e)
        {
            try
            {
                Process proc = new Process();
                string top = "netsh.exe";
                proc.StartInfo.Arguments = "Firewall set opmode disable";
                proc.StartInfo.FileName = top;
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.CreateNoWindow = true;
                proc.Start();
                proc.WaitForExit();
                lblFireWall.Text = "Désactivé";
                init_services();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()+"Error");
            }

            lblFireWall.Text = "Désactivé";
        }

        private void btncsactiv_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceController myservice = new ServiceController();
                myservice.ServiceName = "wscsvc";
                if (myservice.Status.ToString() == "Running")
                {

                }
                else if (myservice.Status.ToString() == "Stopped")
                {

                    myservice.Start();
                    lblcentresecu.Text = "Active";
                    init_services();
                }
              
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "Error");
            }

        }

        private void btnwupactiv_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceController myservice = new ServiceController();
                myservice.ServiceName = "wuauserv";
                if (myservice.Status.ToString() == "Running")
                {

                }
                else if ( myservice.Status.ToString() == "Stopped")
                {
                   
                    myservice.Start();
                    lblUpdate.Text = "Active";
                    init_services();
                   
                   
                   
                }
               
              
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "Error");
            }
        }

        private void btnwupdis_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceController myservice = new ServiceController();
                myservice.ServiceName = "wuauserv";
                if (myservice.Status.ToString() == "Running")
                {
                    myservice.Stop();

                    lblUpdate.Text = "Désactivé";
                    init_services();
                    FrmServices.ActiveForm.ResetText();
                   
                    
                }
                else if (myservice.Status.ToString() == "Stopped")
                {

                   
                }
               
               
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "Error");
            }
        }

        private void btncsdis_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceController myservice = new ServiceController();
                myservice.ServiceName = "wscsvc";
                if (myservice.Status.ToString() == "Running")
                {
                    myservice.Stop();
                    lblcentresecu.Text = "Désactivé";
                    init_services();
                }
                else if (myservice.Status.ToString() == "Stopped")
                {

                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "Error");
            }
        }

        private void btnIISactiv_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceController myservice = new ServiceController();
                myservice.ServiceName = "IISADMIN";
                if (myservice.Status.ToString() == "Running")
                {
                    
                }
                else if (myservice.Status.ToString() == "Stopped")
                {
                    myservice.Start();
                    lblIIS.Text = "Active";
                    init_services();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Le service n'est pas installé sur votre ordinateur " + "Error");
            }
        }

        private void btnIISdis_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceController myservice = new ServiceController();
                myservice.ServiceName = "IISADMIN";
                if (myservice.Status.ToString() == "Running")
                {
                    myservice.Stop();
                    lblIIS.Text = "Désactive";
                    init_services();
                }
                else if (myservice.Status.ToString() == "Stopped")
                {
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Le service n'est pas installé sur votre ordinateur " + "Error");
            }
        }
        //Functions
       
    }
}
