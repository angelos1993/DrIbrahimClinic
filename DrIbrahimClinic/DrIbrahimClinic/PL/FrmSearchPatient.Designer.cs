namespace DrIbrahimClinic.PL
{
    partial class FrmSearchPatient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSearchPatients = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnClearSearch = new DevComponents.DotNetBar.ButtonX();
            this.txtPatientPhone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.dtPatientBirthdate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtPatientId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPatientName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgvTreatments = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.pnlSearchPatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPatientBirthdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearchPatients
            // 
            this.pnlSearchPatients.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlSearchPatients.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnlSearchPatients.Controls.Add(this.btnClearSearch);
            this.pnlSearchPatients.Controls.Add(this.txtPatientPhone);
            this.pnlSearchPatients.Controls.Add(this.labelX5);
            this.pnlSearchPatients.Controls.Add(this.dtPatientBirthdate);
            this.pnlSearchPatients.Controls.Add(this.labelX2);
            this.pnlSearchPatients.Controls.Add(this.labelX6);
            this.pnlSearchPatients.Controls.Add(this.labelX1);
            this.pnlSearchPatients.Controls.Add(this.txtPatientId);
            this.pnlSearchPatients.Controls.Add(this.txtPatientName);
            this.pnlSearchPatients.Controls.Add(this.dgvTreatments);
            this.pnlSearchPatients.Location = new System.Drawing.Point(11, 13);
            this.pnlSearchPatients.Name = "pnlSearchPatients";
            this.pnlSearchPatients.Size = new System.Drawing.Size(791, 548);
            // 
            // 
            // 
            this.pnlSearchPatients.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlSearchPatients.Style.BackColorGradientAngle = 90;
            this.pnlSearchPatients.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlSearchPatients.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlSearchPatients.Style.BorderBottomWidth = 1;
            this.pnlSearchPatients.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlSearchPatients.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlSearchPatients.Style.BorderLeftWidth = 1;
            this.pnlSearchPatients.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlSearchPatients.Style.BorderRightWidth = 1;
            this.pnlSearchPatients.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlSearchPatients.Style.BorderTopWidth = 1;
            this.pnlSearchPatients.Style.Class = "";
            this.pnlSearchPatients.Style.CornerDiameter = 4;
            this.pnlSearchPatients.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnlSearchPatients.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnlSearchPatients.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlSearchPatients.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnlSearchPatients.StyleMouseDown.Class = "";
            this.pnlSearchPatients.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnlSearchPatients.StyleMouseOver.Class = "";
            this.pnlSearchPatients.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnlSearchPatients.TabIndex = 7;
            this.pnlSearchPatients.Text = "بحث عن مريض";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClearSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClearSearch.Image = global::DrIbrahimClinic.Properties.Resources.Undo;
            this.btnClearSearch.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnClearSearch.Location = new System.Drawing.Point(3, 3);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(166, 58);
            this.btnClearSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClearSearch.TabIndex = 4;
            this.btnClearSearch.Text = "إلغاء البحث";
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // txtPatientPhone
            // 
            // 
            // 
            // 
            this.txtPatientPhone.Border.Class = "TextBoxBorder";
            this.txtPatientPhone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPatientPhone.Location = new System.Drawing.Point(175, 35);
            this.txtPatientPhone.Name = "txtPatientPhone";
            this.txtPatientPhone.Size = new System.Drawing.Size(169, 26);
            this.txtPatientPhone.TabIndex = 3;
            this.txtPatientPhone.TextChanged += new System.EventHandler(this.FindPatient);
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(351, 29);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX5.Name = "labelX5";
            this.labelX5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX5.Size = new System.Drawing.Size(83, 36);
            this.labelX5.TabIndex = 17;
            this.labelX5.Text = "تليفون";
            // 
            // dtPatientBirthdate
            // 
            // 
            // 
            // 
            this.dtPatientBirthdate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtPatientBirthdate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtPatientBirthdate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtPatientBirthdate.ButtonDropDown.Visible = true;
            this.dtPatientBirthdate.Location = new System.Drawing.Point(175, 3);
            // 
            // 
            // 
            this.dtPatientBirthdate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtPatientBirthdate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtPatientBirthdate.MonthCalendar.BackgroundStyle.Class = "";
            this.dtPatientBirthdate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtPatientBirthdate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtPatientBirthdate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtPatientBirthdate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtPatientBirthdate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtPatientBirthdate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtPatientBirthdate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtPatientBirthdate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtPatientBirthdate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtPatientBirthdate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtPatientBirthdate.MonthCalendar.DisplayMonth = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtPatientBirthdate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtPatientBirthdate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtPatientBirthdate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtPatientBirthdate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtPatientBirthdate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtPatientBirthdate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtPatientBirthdate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtPatientBirthdate.MonthCalendar.TodayButtonVisible = true;
            this.dtPatientBirthdate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtPatientBirthdate.Name = "dtPatientBirthdate";
            this.dtPatientBirthdate.Size = new System.Drawing.Size(169, 26);
            this.dtPatientBirthdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtPatientBirthdate.TabIndex = 2;
            this.dtPatientBirthdate.TextChanged += new System.EventHandler(this.FindPatient);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(351, -3);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(83, 36);
            this.labelX2.TabIndex = 15;
            this.labelX2.Text = "تاريخ الميلاد";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(688, -3);
            this.labelX6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX6.Name = "labelX6";
            this.labelX6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX6.Size = new System.Drawing.Size(93, 36);
            this.labelX6.TabIndex = 13;
            this.labelX6.Text = "رقم المريض";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(688, 29);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(93, 36);
            this.labelX1.TabIndex = 12;
            this.labelX1.Text = "اسم المريض";
            // 
            // txtPatientId
            // 
            // 
            // 
            // 
            this.txtPatientId.Border.Class = "TextBoxBorder";
            this.txtPatientId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPatientId.Location = new System.Drawing.Point(449, 3);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Size = new System.Drawing.Size(232, 26);
            this.txtPatientId.TabIndex = 0;
            this.txtPatientId.TextChanged += new System.EventHandler(this.FindPatient);
            // 
            // txtPatientName
            // 
            // 
            // 
            // 
            this.txtPatientName.Border.Class = "TextBoxBorder";
            this.txtPatientName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPatientName.Location = new System.Drawing.Point(449, 35);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(232, 26);
            this.txtPatientName.TabIndex = 1;
            this.txtPatientName.TextChanged += new System.EventHandler(this.FindPatient);
            // 
            // dgvTreatments
            // 
            this.dgvTreatments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTreatments.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTreatments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTreatments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvTreatments.Location = new System.Drawing.Point(0, 72);
            this.dgvTreatments.Name = "dgvTreatments";
            this.dgvTreatments.Size = new System.Drawing.Size(785, 449);
            this.dgvTreatments.TabIndex = 5;
            // 
            // FrmSearchPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 574);
            this.Controls.Add(this.pnlSearchPatients);
            this.DoubleBuffered = true;
            this.Name = "FrmSearchPatient";
            this.Text = "بحث عن مريض";
            this.Load += new System.EventHandler(this.FrmSearchPatient_Load);
            this.pnlSearchPatients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtPatientBirthdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel pnlSearchPatients;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPatientName;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTreatments;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPatientId;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtPatientBirthdate;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPatientPhone;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ButtonX btnClearSearch;
    }
}