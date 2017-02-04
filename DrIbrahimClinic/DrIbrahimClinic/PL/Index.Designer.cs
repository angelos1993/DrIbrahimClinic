namespace DrIbrahimClinic.PL
{
    partial class Index
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.panelButtons = new DevComponents.DotNetBar.PanelEx();
            this.btnBackupAndRestoreDB = new DevComponents.DotNetBar.ButtonX();
            this.btnStatistics = new DevComponents.DotNetBar.ButtonX();
            this.btnTreatment = new DevComponents.DotNetBar.ButtonX();
            this.btnAddTreatment = new DevComponents.DotNetBar.ButtonItem();
            this.btnEditTreatment = new DevComponents.DotNetBar.ButtonItem();
            this.btnSearchTreatment = new DevComponents.DotNetBar.ButtonItem();
            this.btnPatient = new DevComponents.DotNetBar.ButtonX();
            this.btnAddPatient = new DevComponents.DotNetBar.ButtonItem();
            this.btnEditPatient = new DevComponents.DotNetBar.ButtonItem();
            this.btnSearchPatients = new DevComponents.DotNetBar.ButtonItem();
            this.btnPatientInoculations = new DevComponents.DotNetBar.ButtonItem();
            this.btnExamination = new DevComponents.DotNetBar.ButtonX();
            this.btnAddExamination = new DevComponents.DotNetBar.ButtonItem();
            this.btnEditExamination = new DevComponents.DotNetBar.ButtonItem();
            this.btnSearchExaminations = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.lblMonthName = new DevComponents.DotNetBar.LabelX();
            this.lblDayOfMonth = new DevComponents.DotNetBar.LabelX();
            this.picBoxCalendar = new System.Windows.Forms.PictureBox();
            this.picBoxClock = new System.Windows.Forms.PictureBox();
            this.lblHrs = new DevComponents.DotNetBar.LabelX();
            this.lblMins = new DevComponents.DotNetBar.LabelX();
            this.lblDayName = new DevComponents.DotNetBar.LabelX();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCalendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClock)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue;
            // 
            // panelButtons
            // 
            this.panelButtons.CanvasColor = System.Drawing.Color.Transparent;
            this.panelButtons.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelButtons.Controls.Add(this.btnBackupAndRestoreDB);
            this.panelButtons.Controls.Add(this.btnStatistics);
            this.panelButtons.Controls.Add(this.btnTreatment);
            this.panelButtons.Controls.Add(this.btnPatient);
            this.panelButtons.Controls.Add(this.btnExamination);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelButtons.RightToLeftLayout = true;
            this.panelButtons.Size = new System.Drawing.Size(802, 100);
            this.panelButtons.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelButtons.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelButtons.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelButtons.Style.BackgroundImage = global::DrIbrahimClinic.Properties.Resources.Header;
            this.panelButtons.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelButtons.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelButtons.Style.GradientAngle = 90;
            this.panelButtons.TabIndex = 0;
            // 
            // btnBackupAndRestoreDB
            // 
            this.btnBackupAndRestoreDB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBackupAndRestoreDB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBackupAndRestoreDB.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBackupAndRestoreDB.Image = global::DrIbrahimClinic.Properties.Resources.BackupAndRestore;
            this.btnBackupAndRestoreDB.ImageFixedSize = new System.Drawing.Size(80, 70);
            this.btnBackupAndRestoreDB.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBackupAndRestoreDB.Location = new System.Drawing.Point(400, 0);
            this.btnBackupAndRestoreDB.Name = "btnBackupAndRestoreDB";
            this.btnBackupAndRestoreDB.Size = new System.Drawing.Size(100, 100);
            this.btnBackupAndRestoreDB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBackupAndRestoreDB.TabIndex = 4;
            this.btnBackupAndRestoreDB.Text = "قاعدة البيانات";
            this.btnBackupAndRestoreDB.Click += new System.EventHandler(this.btnBackupAndRestoreDB_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStatistics.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnStatistics.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStatistics.Image = global::DrIbrahimClinic.Properties.Resources.Statistics;
            this.btnStatistics.ImageFixedSize = new System.Drawing.Size(80, 70);
            this.btnStatistics.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnStatistics.Location = new System.Drawing.Point(300, 0);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(100, 100);
            this.btnStatistics.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnStatistics.TabIndex = 3;
            this.btnStatistics.Text = "إحصائيات";
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnTreatment
            // 
            this.btnTreatment.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTreatment.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTreatment.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTreatment.Image = global::DrIbrahimClinic.Properties.Resources.Treatment;
            this.btnTreatment.ImageFixedSize = new System.Drawing.Size(80, 70);
            this.btnTreatment.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTreatment.Location = new System.Drawing.Point(200, 0);
            this.btnTreatment.Name = "btnTreatment";
            this.btnTreatment.Size = new System.Drawing.Size(100, 100);
            this.btnTreatment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTreatment.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAddTreatment,
            this.btnEditTreatment,
            this.btnSearchTreatment});
            this.btnTreatment.TabIndex = 2;
            this.btnTreatment.Text = "علاج";
            this.btnTreatment.Click += new System.EventHandler(this.btnTreatment_Click);
            // 
            // btnAddTreatment
            // 
            this.btnAddTreatment.GlobalItem = false;
            this.btnAddTreatment.Image = global::DrIbrahimClinic.Properties.Resources.Add;
            this.btnAddTreatment.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnAddTreatment.Name = "btnAddTreatment";
            this.btnAddTreatment.Text = "إضافة علاج جديد ...";
            this.btnAddTreatment.Click += new System.EventHandler(this.btnTreatment_Click);
            // 
            // btnEditTreatment
            // 
            this.btnEditTreatment.GlobalItem = false;
            this.btnEditTreatment.Image = global::DrIbrahimClinic.Properties.Resources.Edit;
            this.btnEditTreatment.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnEditTreatment.Name = "btnEditTreatment";
            this.btnEditTreatment.Text = "تعديل بيانات علاج ...";
            this.btnEditTreatment.Click += new System.EventHandler(this.btnEditTreatment_Click);
            // 
            // btnSearchTreatment
            // 
            this.btnSearchTreatment.GlobalItem = false;
            this.btnSearchTreatment.Image = global::DrIbrahimClinic.Properties.Resources.Search;
            this.btnSearchTreatment.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnSearchTreatment.Name = "btnSearchTreatment";
            this.btnSearchTreatment.Text = "بحث ...";
            this.btnSearchTreatment.Click += new System.EventHandler(this.btnSearchTreatment_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPatient.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPatient.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPatient.Image = global::DrIbrahimClinic.Properties.Resources.Patient;
            this.btnPatient.ImageFixedSize = new System.Drawing.Size(80, 70);
            this.btnPatient.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPatient.Location = new System.Drawing.Point(100, 0);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(100, 100);
            this.btnPatient.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPatient.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAddPatient,
            this.btnEditPatient,
            this.btnSearchPatients,
            this.btnPatientInoculations});
            this.btnPatient.TabIndex = 1;
            this.btnPatient.Text = "مريض";
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.GlobalItem = false;
            this.btnAddPatient.Image = global::DrIbrahimClinic.Properties.Resources.Add;
            this.btnAddPatient.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Text = "إضافة مريض جديد ...";
            this.btnAddPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // btnEditPatient
            // 
            this.btnEditPatient.GlobalItem = false;
            this.btnEditPatient.Image = global::DrIbrahimClinic.Properties.Resources.Edit;
            this.btnEditPatient.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnEditPatient.Name = "btnEditPatient";
            this.btnEditPatient.Text = "تعديل بيانات مريض ...";
            this.btnEditPatient.Click += new System.EventHandler(this.btnEditPatient_Click);
            // 
            // btnSearchPatients
            // 
            this.btnSearchPatients.GlobalItem = false;
            this.btnSearchPatients.Image = global::DrIbrahimClinic.Properties.Resources.Search;
            this.btnSearchPatients.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnSearchPatients.Name = "btnSearchPatients";
            this.btnSearchPatients.Text = "بحث ...";
            this.btnSearchPatients.Click += new System.EventHandler(this.btnSearchPatients_Click);
            // 
            // btnPatientInoculations
            // 
            this.btnPatientInoculations.GlobalItem = false;
            this.btnPatientInoculations.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnPatientInoculations.Name = "btnPatientInoculations";
            this.btnPatientInoculations.Text = "تطعيمات المريض ...";
            this.btnPatientInoculations.Click += new System.EventHandler(this.btnPatientInoculations_Click);
            // 
            // btnExamination
            // 
            this.btnExamination.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExamination.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExamination.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExamination.Image = global::DrIbrahimClinic.Properties.Resources.Examination;
            this.btnExamination.ImageFixedSize = new System.Drawing.Size(80, 70);
            this.btnExamination.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnExamination.Location = new System.Drawing.Point(0, 0);
            this.btnExamination.Name = "btnExamination";
            this.btnExamination.Size = new System.Drawing.Size(100, 100);
            this.btnExamination.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExamination.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAddExamination,
            this.btnEditExamination,
            this.btnSearchExaminations});
            this.btnExamination.TabIndex = 0;
            this.btnExamination.Text = "كشف";
            this.btnExamination.Click += new System.EventHandler(this.btnExamination_Click);
            // 
            // btnAddExamination
            // 
            this.btnAddExamination.GlobalItem = false;
            this.btnAddExamination.Image = global::DrIbrahimClinic.Properties.Resources.Add;
            this.btnAddExamination.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnAddExamination.Name = "btnAddExamination";
            this.btnAddExamination.Text = "إضافة كشف جديد ...";
            this.btnAddExamination.Click += new System.EventHandler(this.btnExamination_Click);
            // 
            // btnEditExamination
            // 
            this.btnEditExamination.GlobalItem = false;
            this.btnEditExamination.Image = global::DrIbrahimClinic.Properties.Resources.Edit;
            this.btnEditExamination.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnEditExamination.Name = "btnEditExamination";
            this.btnEditExamination.Text = "تعديل كشف ...";
            this.btnEditExamination.Click += new System.EventHandler(this.btnEditExamination_Click);
            // 
            // btnSearchExaminations
            // 
            this.btnSearchExaminations.GlobalItem = false;
            this.btnSearchExaminations.Image = global::DrIbrahimClinic.Properties.Resources.Search;
            this.btnSearchExaminations.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnSearchExaminations.Name = "btnSearchExaminations";
            this.btnSearchExaminations.Text = "بحث ...";
            this.btnSearchExaminations.Click += new System.EventHandler(this.btnSearchExaminations_Click);
            // 
            // buttonItem1
            // 
            this.buttonItem1.GlobalItem = false;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "buttonItem1";
            // 
            // buttonItem2
            // 
            this.buttonItem2.GlobalItem = false;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Text = "buttonItem2";
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // lblMonthName
            // 
            this.lblMonthName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblMonthName.BackgroundStyle.Class = "";
            this.lblMonthName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMonthName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthName.ForeColor = System.Drawing.Color.White;
            this.lblMonthName.Location = new System.Drawing.Point(46, 462);
            this.lblMonthName.Name = "lblMonthName";
            this.lblMonthName.Size = new System.Drawing.Size(130, 35);
            this.lblMonthName.TabIndex = 2;
            this.lblMonthName.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblDayOfMonth
            // 
            this.lblDayOfMonth.AntiAlias = false;
            this.lblDayOfMonth.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblDayOfMonth.BackgroundStyle.Class = "";
            this.lblDayOfMonth.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDayOfMonth.Font = new System.Drawing.Font("Arial", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayOfMonth.ForeColor = System.Drawing.Color.Red;
            this.lblDayOfMonth.Location = new System.Drawing.Point(64, 354);
            this.lblDayOfMonth.Name = "lblDayOfMonth";
            this.lblDayOfMonth.Size = new System.Drawing.Size(150, 90);
            this.lblDayOfMonth.TabIndex = 3;
            this.lblDayOfMonth.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // picBoxCalendar
            // 
            this.picBoxCalendar.Image = global::DrIbrahimClinic.Properties.Resources.Calendar;
            this.picBoxCalendar.Location = new System.Drawing.Point(40, 312);
            this.picBoxCalendar.Name = "picBoxCalendar";
            this.picBoxCalendar.Size = new System.Drawing.Size(200, 200);
            this.picBoxCalendar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCalendar.TabIndex = 1;
            this.picBoxCalendar.TabStop = false;
            // 
            // picBoxClock
            // 
            this.picBoxClock.Image = global::DrIbrahimClinic.Properties.Resources.Time;
            this.picBoxClock.Location = new System.Drawing.Point(40, 106);
            this.picBoxClock.Name = "picBoxClock";
            this.picBoxClock.Size = new System.Drawing.Size(200, 200);
            this.picBoxClock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxClock.TabIndex = 4;
            this.picBoxClock.TabStop = false;
            // 
            // lblHrs
            // 
            this.lblHrs.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblHrs.BackgroundStyle.Class = "";
            this.lblHrs.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblHrs.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHrs.ForeColor = System.Drawing.Color.Black;
            this.lblHrs.Location = new System.Drawing.Point(91, 192);
            this.lblHrs.Name = "lblHrs";
            this.lblHrs.Size = new System.Drawing.Size(50, 50);
            this.lblHrs.TabIndex = 5;
            this.lblHrs.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblMins
            // 
            this.lblMins.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblMins.BackgroundStyle.Class = "";
            this.lblMins.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMins.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMins.ForeColor = System.Drawing.Color.Black;
            this.lblMins.Location = new System.Drawing.Point(153, 192);
            this.lblMins.Name = "lblMins";
            this.lblMins.Size = new System.Drawing.Size(50, 50);
            this.lblMins.TabIndex = 6;
            this.lblMins.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblDayName
            // 
            // 
            // 
            // 
            this.lblDayName.BackgroundStyle.Class = "";
            this.lblDayName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDayName.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayName.ForeColor = System.Drawing.Color.Red;
            this.lblDayName.Location = new System.Drawing.Point(40, 252);
            this.lblDayName.Name = "lblDayName";
            this.lblDayName.Size = new System.Drawing.Size(200, 54);
            this.lblDayName.TabIndex = 7;
            this.lblDayName.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 576);
            this.Controls.Add(this.lblMins);
            this.Controls.Add(this.lblHrs);
            this.Controls.Add(this.lblDayName);
            this.Controls.Add(this.picBoxClock);
            this.Controls.Add(this.lblDayOfMonth);
            this.Controls.Add(this.lblMonthName);
            this.Controls.Add(this.picBoxCalendar);
            this.Controls.Add(this.panelButtons);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Index";
            this.Text = "د / ابراهيم رزق الميري";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Index_Load);
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCalendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.PanelEx panelButtons;
        private DevComponents.DotNetBar.ButtonX btnExamination;
        private DevComponents.DotNetBar.ButtonItem btnAddExamination;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem btnEditExamination;
        private DevComponents.DotNetBar.ButtonItem btnSearchExaminations;
        private DevComponents.DotNetBar.ButtonX btnPatient;
        private DevComponents.DotNetBar.ButtonItem btnAddPatient;
        private DevComponents.DotNetBar.ButtonItem btnEditPatient;
        private DevComponents.DotNetBar.ButtonItem btnSearchPatients;
        private DevComponents.DotNetBar.ButtonX btnTreatment;
        private DevComponents.DotNetBar.ButtonItem btnAddTreatment;
        private DevComponents.DotNetBar.ButtonItem btnEditTreatment;
        private DevComponents.DotNetBar.ButtonItem btnSearchTreatment;
        private DevComponents.DotNetBar.ButtonX btnStatistics;
        private DevComponents.DotNetBar.ButtonX btnBackupAndRestoreDB;
        private DevComponents.DotNetBar.ButtonItem btnPatientInoculations;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.PictureBox picBoxCalendar;
        private DevComponents.DotNetBar.LabelX lblMonthName;
        private DevComponents.DotNetBar.LabelX lblDayOfMonth;
        private System.Windows.Forms.PictureBox picBoxClock;
        private DevComponents.DotNetBar.LabelX lblHrs;
        private DevComponents.DotNetBar.LabelX lblMins;
        private DevComponents.DotNetBar.LabelX lblDayName;
    }
}