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
    public partial class FrmSearchPatient : MasterForm
    {
        public FrmSearchPatient()
        {
            InitializeComponent();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtPatientId.Text = string.Empty;
            txtPatientName.Text = string.Empty;
            dtPatientBirthdate.Value = new DateTime(1, 1, 1);
            txtPatientPhone.Text = string.Empty;
        }
    }
}
