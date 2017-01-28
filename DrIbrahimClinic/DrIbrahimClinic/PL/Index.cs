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
            FrmAddExaminatios frmAddExaminatios = new FrmAddExaminatios();
            frmAddExaminatios.ShowDialog();
        }

        private void btnEditExamination_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchExaminations_Click(object sender, EventArgs e)
        {
            FrmSearchExamination frmSearchExamination = new FrmSearchExamination();
            frmSearchExamination.ShowDialog();
        }
        
        #endregion

        #region Patient

        private void btnPatient_Click(object sender, EventArgs e)
        {
            FrmAddPatient frmAddPatient = new FrmAddPatient();
            frmAddPatient.ShowDialog();
        }

        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            FrmEditPatient frmEditPatient = new FrmEditPatient();
            frmEditPatient.ShowDialog();
        }

        private void btnSearchPatients_Click(object sender, EventArgs e)
        {
            FrmSearchPatient frmSearchPatient = new FrmSearchPatient();
            frmSearchPatient.ShowDialog();
        }

        private void btnPatientInoculations_Click(object sender, EventArgs e)
        {
            FrmPatientInoculations frmPatientInoculations = new FrmPatientInoculations();
            frmPatientInoculations.ShowDialog();
        }

        #endregion

        #region Treatment

        private void btnTreatment_Click(object sender, EventArgs e)
        {
            FrmAddTreatment frmAddTreatment = new FrmAddTreatment();
            frmAddTreatment.ShowDialog();
        }

        private void btnEditTreatment_Click(object sender, EventArgs e)
        {
            FrmEditTreatment frmEditTreatment = new FrmEditTreatment();
            frmEditTreatment.ShowDialog();
        }

        private void btnSearchTreatment_Click(object sender, EventArgs e)
        {
            FrmSearchTreatment frmSearchTreatment = new FrmSearchTreatment();
            frmSearchTreatment.ShowDialog();
        }

        #endregion

        #region Statistics

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            FrmAddExamination frmAddExamination = new FrmAddExamination();
            frmAddExamination.ShowDialog();
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