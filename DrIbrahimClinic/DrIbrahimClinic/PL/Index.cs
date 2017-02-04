using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.DateTime;
using DevComponents.DotNetBar;
using DrIbrahimClinic.Utility;

namespace DrIbrahimClinic.PL
{
    public partial class Index : Office2007Form
    {
        public Index()
        {
            InitializeComponent();
        }

        #region Events

        #region Form

        private void Index_Load(object sender, EventArgs e)
        {
            PrepareCalendarAndTime();
            SetCurrentDate();
            SetCurrentTime();
        }

        #endregion

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
            SetCurrentTime();
            if (Now.Hour == 1 && Now.Minute == 0 && Now.Second == 0)
                SetCurrentDate();
        }

        #endregion

        #endregion

        #region Methods

        private void PrepareCalendarAndTime()
        {
            var pos = PointToScreen(lblMonthName.Location);
            pos = picBoxCalendar.PointToClient(pos);
            lblMonthName.Parent = picBoxCalendar;
            lblMonthName.Location = pos;
            lblMonthName.BackColor = Color.Transparent;

            pos = PointToScreen(lblDayOfMonth.Location);
            pos = picBoxCalendar.PointToClient(pos);
            lblDayOfMonth.Parent = picBoxCalendar;
            lblDayOfMonth.Location = pos;
            lblDayOfMonth.BackColor = Color.Transparent;

            pos = PointToScreen(lblHrs.Location);
            pos = picBoxCalendar.PointToClient(pos);
            lblHrs.Parent = picBoxCalendar;
            lblHrs.Location = pos;
            lblHrs.BackColor = Color.Transparent;

            pos = PointToScreen(lblMins.Location);
            pos = picBoxCalendar.PointToClient(pos);
            lblMins.Parent = picBoxCalendar;
            lblMins.Location = pos;
            lblMins.BackColor = Color.Transparent;
        }

        private void SetCurrentDate()
        {
            lblMonthName.Text = Now.ToMonthName();
            lblDayOfMonth.Text = Now.ToDayNumber();
            lblDayName.Text = Now.ToDayName();
        }

        private void SetCurrentTime()
        {
            lblHrs.Text = Now.ToHour();
            lblMins.Text = Now.ToMinute();
        }

        #endregion
    }
}