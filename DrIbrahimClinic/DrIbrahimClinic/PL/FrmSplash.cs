using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrIbrahimClinic.PL
{
    public partial class FrmSplash : FrmMaster
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            Hide();
            new FrmIndex().Show();
        }
    }
}
