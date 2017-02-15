using System;

namespace DrIbrahimClinic.PL
{
    public partial class FrmRoshetta : MasterForm
    {
        public FrmRoshetta()
        {
            InitializeComponent();
        }

        private void FrmRo4etta_Load(object sender, EventArgs e)
        {
            reportViewer1.RefreshReport();
        }
    }
}