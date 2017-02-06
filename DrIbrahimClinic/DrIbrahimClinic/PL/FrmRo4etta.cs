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
