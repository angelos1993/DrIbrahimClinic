namespace DrIbrahimClinic.PL
{
    partial class FrmSearchExamination
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSearchExaminations = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.intInputPatientId = new DevComponents.Editors.IntegerInput();
            this.btnClearSearch = new DevComponents.DotNetBar.ButtonX();
            this.dtExaminationDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtPatientName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgvExaminations = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.pnlSearchExaminations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intInputPatientId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtExaminationDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExaminations)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearchExaminations
            // 
            this.pnlSearchExaminations.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlSearchExaminations.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnlSearchExaminations.Controls.Add(this.intInputPatientId);
            this.pnlSearchExaminations.Controls.Add(this.btnClearSearch);
            this.pnlSearchExaminations.Controls.Add(this.dtExaminationDate);
            this.pnlSearchExaminations.Controls.Add(this.labelX2);
            this.pnlSearchExaminations.Controls.Add(this.labelX6);
            this.pnlSearchExaminations.Controls.Add(this.labelX1);
            this.pnlSearchExaminations.Controls.Add(this.txtPatientName);
            this.pnlSearchExaminations.Controls.Add(this.dgvExaminations);
            this.pnlSearchExaminations.Location = new System.Drawing.Point(11, 13);
            this.pnlSearchExaminations.Name = "pnlSearchExaminations";
            this.pnlSearchExaminations.Size = new System.Drawing.Size(787, 548);
            // 
            // 
            // 
            this.pnlSearchExaminations.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlSearchExaminations.Style.BackColorGradientAngle = 90;
            this.pnlSearchExaminations.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlSearchExaminations.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlSearchExaminations.Style.BorderBottomWidth = 1;
            this.pnlSearchExaminations.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlSearchExaminations.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlSearchExaminations.Style.BorderLeftWidth = 1;
            this.pnlSearchExaminations.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlSearchExaminations.Style.BorderRightWidth = 1;
            this.pnlSearchExaminations.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlSearchExaminations.Style.BorderTopWidth = 1;
            this.pnlSearchExaminations.Style.Class = "";
            this.pnlSearchExaminations.Style.CornerDiameter = 4;
            this.pnlSearchExaminations.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnlSearchExaminations.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnlSearchExaminations.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlSearchExaminations.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnlSearchExaminations.StyleMouseDown.Class = "";
            this.pnlSearchExaminations.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnlSearchExaminations.StyleMouseOver.Class = "";
            this.pnlSearchExaminations.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnlSearchExaminations.TabIndex = 8;
            this.pnlSearchExaminations.Text = "بحث عن كشف";
            // 
            // intInputPatientId
            // 
            // 
            // 
            // 
            this.intInputPatientId.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intInputPatientId.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.intInputPatientId.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.intInputPatientId.Location = new System.Drawing.Point(436, 13);
            this.intInputPatientId.MinValue = 0;
            this.intInputPatientId.Name = "intInputPatientId";
            this.intInputPatientId.ShowUpDown = true;
            this.intInputPatientId.Size = new System.Drawing.Size(238, 26);
            this.intInputPatientId.TabIndex = 23;
            this.intInputPatientId.ValueChanged += new System.EventHandler(this.FindExamination);
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClearSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClearSearch.Image = global::DrIbrahimClinic.Properties.Resources.Undo;
            this.btnClearSearch.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnClearSearch.Location = new System.Drawing.Point(236, 46);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(192, 26);
            this.btnClearSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClearSearch.TabIndex = 19;
            this.btnClearSearch.Text = "إلغاء البحث";
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // dtExaminationDate
            // 
            // 
            // 
            // 
            this.dtExaminationDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtExaminationDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtExaminationDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtExaminationDate.ButtonDropDown.Visible = true;
            this.dtExaminationDate.Location = new System.Drawing.Point(237, 13);
            // 
            // 
            // 
            this.dtExaminationDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtExaminationDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtExaminationDate.MonthCalendar.BackgroundStyle.Class = "";
            this.dtExaminationDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtExaminationDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtExaminationDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtExaminationDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtExaminationDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtExaminationDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtExaminationDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtExaminationDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtExaminationDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtExaminationDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtExaminationDate.MonthCalendar.DisplayMonth = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtExaminationDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtExaminationDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtExaminationDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtExaminationDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtExaminationDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtExaminationDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtExaminationDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtExaminationDate.MonthCalendar.TodayButtonVisible = true;
            this.dtExaminationDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtExaminationDate.Name = "dtExaminationDate";
            this.dtExaminationDate.Size = new System.Drawing.Size(123, 26);
            this.dtExaminationDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtExaminationDate.TabIndex = 18;
            this.dtExaminationDate.ValueChanged += new System.EventHandler(this.FindExamination);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(367, 3);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(61, 36);
            this.labelX2.TabIndex = 22;
            this.labelX2.Text = "التاريخ";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(681, 4);
            this.labelX6.Margin = new System.Windows.Forms.Padding(4);
            this.labelX6.Name = "labelX6";
            this.labelX6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX6.Size = new System.Drawing.Size(97, 36);
            this.labelX6.TabIndex = 21;
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
            this.labelX1.Location = new System.Drawing.Point(681, 41);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(97, 36);
            this.labelX1.TabIndex = 20;
            this.labelX1.Text = "اسم المريض";
            // 
            // txtPatientName
            // 
            // 
            // 
            // 
            this.txtPatientName.Border.Class = "TextBoxBorder";
            this.txtPatientName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPatientName.Location = new System.Drawing.Point(436, 46);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(238, 26);
            this.txtPatientName.TabIndex = 17;
            this.txtPatientName.TextChanged += new System.EventHandler(this.FindExamination);
            // 
            // dgvExaminations
            // 
            this.dgvExaminations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvExaminations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExaminations.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExaminations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvExaminations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvExaminations.Location = new System.Drawing.Point(0, 85);
            this.dgvExaminations.Name = "dgvExaminations";
            this.dgvExaminations.ReadOnly = true;
            this.dgvExaminations.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvExaminations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExaminations.Size = new System.Drawing.Size(781, 436);
            this.dgvExaminations.TabIndex = 3;
            // 
            // FrmSearchExamination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 572);
            this.Controls.Add(this.pnlSearchExaminations);
            this.DoubleBuffered = true;
            this.Name = "FrmSearchExamination";
            this.Text = "بحث عن كشف";
            this.Load += new System.EventHandler(this.FrmSearchExamination_Load);
            this.pnlSearchExaminations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.intInputPatientId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtExaminationDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExaminations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel pnlSearchExaminations;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvExaminations;
        private DevComponents.DotNetBar.ButtonX btnClearSearch;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtExaminationDate;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPatientName;
        private DevComponents.Editors.IntegerInput intInputPatientId;
    }
}