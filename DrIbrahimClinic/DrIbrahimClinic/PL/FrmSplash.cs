using System;

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
