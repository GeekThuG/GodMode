//M.kabiri

using System.Drawing;
using System.Windows.Forms;


namespace GodMode
{
    public partial class ProgressInfoForm : Form
    {

        #region Construct ProgressInfo

        public ProgressInfoForm()
        {
            InitializeComponent();
        }

        #endregion 

        #region Properties

        /// <summary>
        /// Form.Locattion.X
        /// </summary>
        public int LocationX
        {
            get;
            set;
        }

        /// <summary>
        /// Form.Locattion.Y
        /// </summary>
        public int LocationY
        {
            get;
            set;
        }

        #endregion

        #region Event Handler

        private void ProgressInfoLoad(object sender, System.EventArgs e)
        {
            Location = new Point(LocationX, LocationY);
        }

        #endregion
    }
}
