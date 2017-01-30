using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace DrIbrahimClinic.PL
{
    public partial class Index : Office2007Form
    {
        public Index()
        {
            InitializeComponent();
        }

        #region Events

        #region Examination

        private void btnExamination_Click(object sender, EventArgs e)
        {
            new FrmAddExamination().ShowDialog();
        }

        private void btnEditExamination_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchExaminations_Click(object sender, EventArgs e)
        {
            new FrmSearchExamination().ShowDialog();
        }

        #endregion

        #region Patient

        private void btnPatient_Click(object sender, EventArgs e)
        {
            new FrmAddPatient().ShowDialog();
        }

        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            new FrmEditPatient().ShowDialog();
        }

        private void btnSearchPatients_Click(object sender, EventArgs e)
        {
            new FrmSearchPatient().ShowDialog();
        }

        private void btnPatientInoculations_Click(object sender, EventArgs e)
        {
            new FrmPatientInoculations().ShowDialog();
        }

        #endregion

        #region Treatment

        private void btnTreatment_Click(object sender, EventArgs e)
        {
            new FrmAddTreatment().ShowDialog();
        }

        private void btnEditTreatment_Click(object sender, EventArgs e)
        {
            new FrmEditTreatment().ShowDialog();
        }

        private void btnSearchTreatment_Click(object sender, EventArgs e)
        {
            new FrmSearchTreatment().ShowDialog();
        }

        #endregion

        #region Statistics

        private void btnStatistics_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region DB Backup & Restore

        private void btnBackupAndRestoreDB_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Timer - Clock

        private void timerClock_Tick(object sender, EventArgs e)
        {
            //TODO: clock ...
        }

        #endregion

        #endregion
    }
}