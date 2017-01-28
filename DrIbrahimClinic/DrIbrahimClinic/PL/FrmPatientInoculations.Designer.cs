namespace DrIbrahimClinic.PL
{
    partial class FrmPatientInoculations
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
            this.grpPanelPatientData = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnFindPatient = new DevComponents.DotNetBar.ButtonX();
            this.txtPatientId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtPatientName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX3 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dtInoculationDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnAddInoculation = new DevComponents.DotNetBar.ButtonX();
            this.lstVwPatientInoculations = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.grpPanelPatientInoculations = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnClear = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.grpPanelPatientData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInoculationDate)).BeginInit();
            this.grpPanelPatientInoculations.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPanelPatientData
            // 
            this.grpPanelPatientData.CanvasColor = System.Drawing.SystemColors.Control;
            this.grpPanelPatientData.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.grpPanelPatientData.Controls.Add(this.btnFindPatient);
            this.grpPanelPatientData.Controls.Add(this.txtPatientId);
            this.grpPanelPatientData.Controls.Add(this.labelX6);
            this.grpPanelPatientData.Controls.Add(this.txtPatientName);
            this.grpPanelPatientData.Controls.Add(this.labelX1);
            this.grpPanelPatientData.Location = new System.Drawing.Point(12, 12);
            this.grpPanelPatientData.Name = "grpPanelPatientData";
            this.grpPanelPatientData.Size = new System.Drawing.Size(466, 120);
            // 
            // 
            // 
            this.grpPanelPatientData.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.grpPanelPatientData.Style.BackColorGradientAngle = 90;
            this.grpPanelPatientData.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.grpPanelPatientData.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpPanelPatientData.Style.BorderBottomWidth = 1;
            this.grpPanelPatientData.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.grpPanelPatientData.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpPanelPatientData.Style.BorderLeftWidth = 1;
            this.grpPanelPatientData.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpPanelPatientData.Style.BorderRightWidth = 1;
            this.grpPanelPatientData.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpPanelPatientData.Style.BorderTopWidth = 1;
            this.grpPanelPatientData.Style.Class = "";
            this.grpPanelPatientData.Style.CornerDiameter = 4;
            this.grpPanelPatientData.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grpPanelPatientData.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grpPanelPatientData.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grpPanelPatientData.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.grpPanelPatientData.StyleMouseDown.Class = "";
            this.grpPanelPatientData.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.grpPanelPatientData.StyleMouseOver.Class = "";
            this.grpPanelPatientData.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.grpPanelPatientData.TabIndex = 11;
            this.grpPanelPatientData.Text = "بيانات المريض";
            // 
            // btnFindPatient
            // 
            this.btnFindPatient.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFindPatient.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFindPatient.Image = global::DrIbrahimClinic.Properties.Resources.Search;
            this.btnFindPatient.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnFindPatient.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnFindPatient.Location = new System.Drawing.Point(3, 11);
            this.btnFindPatient.Name = "btnFindPatient";
            this.btnFindPatient.Size = new System.Drawing.Size(80, 68);
            this.btnFindPatient.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFindPatient.TabIndex = 2;
            this.btnFindPatient.Text = "بحث";
            this.btnFindPatient.Click += new System.EventHandler(this.btnFindPatient_Click);
            // 
            // txtPatientId
            // 
            // 
            // 
            // 
            this.txtPatientId.Border.Class = "TextBoxBorder";
            this.txtPatientId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPatientId.Location = new System.Drawing.Point(89, 11);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPatientId.Size = new System.Drawing.Size(290, 26);
            this.txtPatientId.TabIndex = 0;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(387, 3);
            this.labelX6.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelX6.Name = "labelX6";
            this.labelX6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX6.Size = new System.Drawing.Size(68, 34);
            this.labelX6.TabIndex = 11;
            this.labelX6.Text = "رقم المريض";
            // 
            // txtPatientName
            // 
            // 
            // 
            // 
            this.txtPatientName.Border.Class = "TextBoxBorder";
            this.txtPatientName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPatientName.Location = new System.Drawing.Point(89, 53);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPatientName.Size = new System.Drawing.Size(290, 26);
            this.txtPatientName.TabIndex = 1;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(387, 47);
            this.labelX1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(68, 34);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "اسم المريض";
            // 
            // textBoxX3
            // 
            // 
            // 
            // 
            this.textBoxX3.Border.Class = "TextBoxBorder";
            this.textBoxX3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX3.Location = new System.Drawing.Point(3, 3);
            this.textBoxX3.Name = "textBoxX3";
            this.textBoxX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxX3.Size = new System.Drawing.Size(276, 26);
            this.textBoxX3.TabIndex = 0;
            // 
            // dtInoculationDate
            // 
            // 
            // 
            // 
            this.dtInoculationDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtInoculationDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtInoculationDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtInoculationDate.ButtonDropDown.Visible = true;
            this.dtInoculationDate.Location = new System.Drawing.Point(285, 3);
            // 
            // 
            // 
            this.dtInoculationDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtInoculationDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtInoculationDate.MonthCalendar.BackgroundStyle.Class = "";
            this.dtInoculationDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtInoculationDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtInoculationDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtInoculationDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtInoculationDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtInoculationDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtInoculationDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtInoculationDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtInoculationDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtInoculationDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtInoculationDate.MonthCalendar.DisplayMonth = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtInoculationDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtInoculationDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtInoculationDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtInoculationDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtInoculationDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtInoculationDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtInoculationDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtInoculationDate.MonthCalendar.TodayButtonVisible = true;
            this.dtInoculationDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtInoculationDate.Name = "dtInoculationDate";
            this.dtInoculationDate.Size = new System.Drawing.Size(138, 26);
            this.dtInoculationDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtInoculationDate.TabIndex = 1;
            // 
            // btnAddInoculation
            // 
            this.btnAddInoculation.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddInoculation.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddInoculation.Image = global::DrIbrahimClinic.Properties.Resources.Add;
            this.btnAddInoculation.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnAddInoculation.Location = new System.Drawing.Point(429, 3);
            this.btnAddInoculation.Name = "btnAddInoculation";
            this.btnAddInoculation.Size = new System.Drawing.Size(26, 26);
            this.btnAddInoculation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddInoculation.TabIndex = 2;
            this.btnAddInoculation.Click += new System.EventHandler(this.btnAddInoculation_Click);
            // 
            // lstVwPatientInoculations
            // 
            // 
            // 
            // 
            this.lstVwPatientInoculations.Border.Class = "ListViewBorder";
            this.lstVwPatientInoculations.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lstVwPatientInoculations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstVwPatientInoculations.FullRowSelect = true;
            this.lstVwPatientInoculations.GridLines = true;
            this.lstVwPatientInoculations.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstVwPatientInoculations.Location = new System.Drawing.Point(0, 35);
            this.lstVwPatientInoculations.Name = "lstVwPatientInoculations";
            this.lstVwPatientInoculations.Size = new System.Drawing.Size(460, 226);
            this.lstVwPatientInoculations.TabIndex = 22;
            this.lstVwPatientInoculations.UseCompatibleStateImageBehavior = false;
            this.lstVwPatientInoculations.View = System.Windows.Forms.View.Details;
            // 
            // grpPanelPatientInoculations
            // 
            this.grpPanelPatientInoculations.CanvasColor = System.Drawing.SystemColors.Control;
            this.grpPanelPatientInoculations.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.grpPanelPatientInoculations.Controls.Add(this.textBoxX3);
            this.grpPanelPatientInoculations.Controls.Add(this.lstVwPatientInoculations);
            this.grpPanelPatientInoculations.Controls.Add(this.dtInoculationDate);
            this.grpPanelPatientInoculations.Controls.Add(this.btnAddInoculation);
            this.grpPanelPatientInoculations.Location = new System.Drawing.Point(12, 138);
            this.grpPanelPatientInoculations.Name = "grpPanelPatientInoculations";
            this.grpPanelPatientInoculations.Size = new System.Drawing.Size(466, 288);
            // 
            // 
            // 
            this.grpPanelPatientInoculations.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.grpPanelPatientInoculations.Style.BackColorGradientAngle = 90;
            this.grpPanelPatientInoculations.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.grpPanelPatientInoculations.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpPanelPatientInoculations.Style.BorderBottomWidth = 1;
            this.grpPanelPatientInoculations.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.grpPanelPatientInoculations.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpPanelPatientInoculations.Style.BorderLeftWidth = 1;
            this.grpPanelPatientInoculations.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpPanelPatientInoculations.Style.BorderRightWidth = 1;
            this.grpPanelPatientInoculations.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpPanelPatientInoculations.Style.BorderTopWidth = 1;
            this.grpPanelPatientInoculations.Style.Class = "";
            this.grpPanelPatientInoculations.Style.CornerDiameter = 4;
            this.grpPanelPatientInoculations.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grpPanelPatientInoculations.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grpPanelPatientInoculations.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grpPanelPatientInoculations.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.grpPanelPatientInoculations.StyleMouseDown.Class = "";
            this.grpPanelPatientInoculations.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.grpPanelPatientInoculations.StyleMouseOver.Class = "";
            this.grpPanelPatientInoculations.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.grpPanelPatientInoculations.TabIndex = 16;
            this.grpPanelPatientInoculations.Text = "التطعيمات";
            // 
            // btnClear
            // 
            this.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClear.Image = global::DrIbrahimClinic.Properties.Resources.Clear;
            this.btnClear.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnClear.Location = new System.Drawing.Point(249, 435);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 35);
            this.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "مسح";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = global::DrIbrahimClinic.Properties.Resources.Exit;
            this.btnCancel.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnCancel.Location = new System.Drawing.Point(140, 435);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 35);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "خروج";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmPatientInoculations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 480);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpPanelPatientInoculations);
            this.Controls.Add(this.grpPanelPatientData);
            this.DoubleBuffered = true;
            this.Name = "FrmPatientInoculations";
            this.Text = "تطعيمات المريض";
            this.Load += new System.EventHandler(this.FrmPatientInoculations_Load);
            this.grpPanelPatientData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtInoculationDate)).EndInit();
            this.grpPanelPatientInoculations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel grpPanelPatientData;
        private DevComponents.DotNetBar.ButtonX btnFindPatient;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPatientId;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPatientName;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX3;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtInoculationDate;
        private DevComponents.DotNetBar.ButtonX btnAddInoculation;
        private DevComponents.DotNetBar.Controls.ListViewEx lstVwPatientInoculations;
        private DevComponents.DotNetBar.Controls.GroupPanel grpPanelPatientInoculations;
        private DevComponents.DotNetBar.ButtonX btnClear;
        private DevComponents.DotNetBar.ButtonX btnCancel;
    }
}