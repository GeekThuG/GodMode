using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GodMode
{
    public partial class Winfsfrm : Form
    {
        public Winfsfrm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Enable Wfs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            System.Diagnostics.ProcessStartInfo ProcessInfo;
            System.Diagnostics.Process Process;

            ProcessInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe", "/K " + @" powercfg /hibernate on");
            ProcessInfo.CreateNoWindow = true;
            ProcessInfo.UseShellExecute = true;
            ProcessInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Process = System.Diagnostics.Process.Start(ProcessInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Le service n'est pas accessible, essayez à nouveau svp!!!!!");
            }
        }
        /// <summary>
        /// disable wfs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.ProcessStartInfo ProcessInfo;
                System.Diagnostics.Process Process;

                ProcessInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe", "/K " + @" powercfg /hibernate off");
                ProcessInfo.CreateNoWindow = true;
                ProcessInfo.UseShellExecute = true;
                ProcessInfo.WindowStyle = ProcessWindowStyle.Hidden;
                Process = System.Diagnostics.Process.Start(ProcessInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Le service n'est pas accessible, essayez à nouveau svp!!!!!");
            }
        }
    }
}
