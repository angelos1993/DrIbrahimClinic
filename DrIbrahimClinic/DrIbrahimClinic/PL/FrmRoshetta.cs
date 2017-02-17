using System;
using DrIbrahimClinic.DAL.Model;

namespace DrIbrahimClinic.PL
{
    public partial class FrmRoshetta : MasterForm
    {
        public FrmRoshetta(Examination examination)
        {
            InitializeComponent();
            Examination = examination;
        }

        #region Properties

        public Examination Examination { get; set; }

        #endregion

        private void FrmRo4etta_Load(object sender, EventArgs e)
        {
            reportViewer1.RefreshReport();
        }
    }
}