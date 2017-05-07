using System;
using System.Windows.Forms;

namespace dr.PCI
{
    public partial class drpciBase : Form
    {
        public drpciBase()
        {
            Form drpciSplash = new drpciSplash();
            drpciSplash.Show();

            InitializeComponent();
        }

        private void drpciBase_Load(object sender, EventArgs e)
        {
            
        }
    }
}
