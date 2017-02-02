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

        private void FrmSearchPatient_Load(object sender, EventArgs e)
        {

        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtPatientId.Text = string.Empty;
            txtPatientName.Text = string.Empty;
            dtPatientBirthdate.Value = new DateTime(1, 1, 1);
            txtPatientPhone.Text = string.Empty;
        }

        private void FindPatient(object sender, EventArgs e)
        {
            
        }
    }
}
