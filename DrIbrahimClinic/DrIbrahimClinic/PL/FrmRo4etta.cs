using System;

namespace DrIbrahimClinic.PL
{
    public partial class FrmRo4etta : MasterForm
    {
        public FrmRo4etta()
        {
            InitializeComponent();
        }

        private void FrmRo4etta_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
