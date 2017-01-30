

using System;
using System.Drawing;
using System.Windows.Forms;
using GodMode.Properties;

namespace GodMode
{
    internal partial class UcNetworkAdapter : UserControl
    {

        #region Constuct UCNetworkAdapter

        public UcNetworkAdapter()
        {
            InitializeComponent();
        }

        /// <summary>
        /// An User Control handle a Network Adapter Information
        /// </summary>
        /// <param name="networkAdapter">The NetworkAdapter object 
        /// showed in the UCNetworkAdapter</param>
        /// <param name="eventHandler">The EventHandler for btnEnableDisable 
        /// in the UCNetworkAdapter</param>
        /// <param name="point">The location of the UCNetworkAdapter</param>
        /// <param name="parent">The parent control which contained 
        /// the UCNetworkAdapter</param>
        public UcNetworkAdapter(NetworkAdapter networkAdapter, 
            EventHandler eventHandler,
            Point point,
            Control parent)
        {
            InitializeComponent1();
            //pctNetworkAdapter.Image = (networkAdapter.NetEnabled > 0)
             //   ? Resources.ImgEnabledNetworkAdapter 
            //    : Resources.ImgDisabledNetworkAdapter;
            lbProductName.Text = networkAdapter.Name;
            lbConnectionStatus.Text = 
                NetworkAdapter.SaNetConnectionStatus[networkAdapter.NetConnectionStatus];
            btnEnableDisable.Text = (networkAdapter.NetEnabled > 0) 
                ? Resources.BtnText_Disable : Resources.BtnText_Enable;
            btnEnableDisable.Tag = 
                new[]{networkAdapter.DeviceId,networkAdapter.NetEnabled};
            btnEnableDisable.Click += eventHandler;
            Location = point;
            Parent = parent;
        }

        #endregion 

        private void lbProductName_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // UcNetworkAdapter
            // 
            this.Name = "UcNetworkAdapter";
            this.Size = new System.Drawing.Size(679, 150);
            this.Load += new System.EventHandler(this.UcNetworkAdapter_Load);
            this.ResumeLayout(false);

        }

        private void UcNetworkAdapter_Load(object sender, EventArgs e)
        {

        }

    }
}
