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

namespace GodMode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnservice_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.panel1.GetContainerControl().ActiveControl == null)
                {

                    if (Application.OpenForms["FrmServices"] as FrmServices != null)
                    {
                        //Close
                        MessageBox.Show("Services Form Panel is already Open!!!!");
                    }
                    else
                    {
                        //Open
                        FrmServices SvrFrm = new FrmServices();
                        SvrFrm.TopLevel = false;
                        SvrFrm.AutoScroll = true;
                        this.panel1.Controls.Add(SvrFrm);
                        SvrFrm.Show();

                    }

                }
                else
                {
                    panel1.Controls.Clear();
                    this.panel1.Controls.Remove(this.panel1.GetContainerControl().ActiveControl);
                    FrmServices SvrFrm = new FrmServices();
                    SvrFrm.TopLevel = false;
                    SvrFrm.AutoScroll = true;
                    this.panel1.Controls.Add(SvrFrm);
                    SvrFrm.Show();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncmd_Click(object sender, EventArgs e)
        {
            try { 
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = "PowerShell.exe";
            proc.StartInfo = startInfo;
            proc.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "Error");
            }
        }

        private void btnapp_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.panel1.GetContainerControl().ActiveControl == null)
                {

                    if (Application.OpenForms["FrmApplis"] as FrmApplis != null)
                    {
                        //Close
                        MessageBox.Show("Application Form Panel is already Open!!!!");
                    }
                    else
                    {
                        //Open
                        FrmApplis appFrm = new FrmApplis();
                        appFrm.TopLevel = false;
                        appFrm.AutoScroll = true;
                        this.panel1.Controls.Add(appFrm);
                        appFrm.Show();

                    }

                }
                else
                {
                    panel1.Controls.Clear();
                    this.panel1.Controls.Remove(this.panel1.GetContainerControl().ActiveControl);
                    FrmApplis appFrm = new FrmApplis();
                    appFrm.TopLevel = false;
                    appFrm.AutoScroll = true;
                    this.panel1.Controls.Add(appFrm);
                    appFrm.Show();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnnetwork_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.panel1.GetContainerControl().ActiveControl == null)
                {

                    if (Application.OpenForms["MainForm"] as MainForm != null)
                    {
                        //Close
                        MessageBox.Show("Network Form Panel is already Open!!!!");
                    }
                    else
                    {
                        //Open
                        MainForm Mfrm = new MainForm();
                        Mfrm.TopLevel = false;
                        Mfrm.AutoScroll = true;
                        this.panel1.Controls.Add(Mfrm);
                        Mfrm.Show();

                    }

                }
                else
                {
                    panel1.Controls.Clear();
                    this.panel1.Controls.Remove(this.panel1.GetContainerControl().ActiveControl);
                    MainForm Mfrm = new MainForm();
                    Mfrm.TopLevel = false;
                    Mfrm.AutoScroll = true;
                    this.panel1.Controls.Add(Mfrm);
                    Mfrm.Show();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
               
        private void btnawin_Click(object sender, EventArgs e)
        {
            try { 
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = @"C:\Windows\System32\slui.exe";
            process.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "Error");
            }
        }
        /// <summary>
        /// UAC
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.panel1.GetContainerControl().ActiveControl == null)
                {

                    if (Application.OpenForms["UacFrm"] as UacFrm != null)
                    {
                        //Close
                        MessageBox.Show("Network Form Panel is already Open!!!!");
                    }
                    else
                    {
                        //Open
                        UacFrm uacfrm = new UacFrm();
                        uacfrm.TopLevel = false;
                        uacfrm.AutoScroll = true;
                        this.panel1.Controls.Add(uacfrm);
                        uacfrm.Show();

                    }

                }
                else
                {
                    panel1.Controls.Clear();
                    this.panel1.Controls.Remove(this.panel1.GetContainerControl().ActiveControl);
                    UacFrm uacfrm = new UacFrm();
                    uacfrm.TopLevel = false;
                    uacfrm.AutoScroll = true;
                    this.panel1.Controls.Add(uacfrm);
                    uacfrm.Show();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// WinFastStartUp
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.panel1.GetContainerControl().ActiveControl == null)
                {

                    if (Application.OpenForms["Winfsfrm"] as Winfsfrm != null)
                    {
                        //Close
                        MessageBox.Show("Windows Smart StartUp Form Panel is already Open!!!!");
                    }
                    else
                    {
                        //Open
                        Winfsfrm wfs = new Winfsfrm();
                        wfs.TopLevel = false;
                        wfs.AutoScroll = true;
                        this.panel1.Controls.Add(wfs);
                        wfs.Show();

                    }

                }
                else
                {
                    panel1.Controls.Clear();
                    this.panel1.Controls.Remove(this.panel1.GetContainerControl().ActiveControl);
                    Winfsfrm wfs = new Winfsfrm();
                    wfs.TopLevel = false;
                    wfs.AutoScroll = true;
                    this.panel1.Controls.Add(wfs);
                    wfs.Show();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdCmd_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.FileName = "Cmd.exe";
                proc.StartInfo = startInfo;
                proc.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "Error");
            }
        }
    }
}
