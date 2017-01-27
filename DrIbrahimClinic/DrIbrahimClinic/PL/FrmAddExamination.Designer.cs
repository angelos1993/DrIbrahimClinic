namespace DrIbrahimClinic.PL
{
    partial class FrmAddExamination
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.pnlPatientData = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.expPanelInoculations = new DevComponents.DotNetBar.ExpandablePanel();
            this.dtInoculationDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnAddInoculation = new DevComponents.DotNetBar.ButtonX();
            this.k = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.btnClearPatientData = new DevComponents.DotNetBar.ButtonX();
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.listViewEx1 = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.btnEditPatientData = new DevComponents.DotNetBar.ButtonX();
            this.btnAddNewPatient = new DevComponents.DotNetBar.ButtonX();
            this.btnFindPatient = new DevComponents.DotNetBar.ButtonX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.switchBtnBirthType = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.switchBtnSucklingType = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.switchBtnGender = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.dateBirthdate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPhone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.tabPatientData = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel3 = new DevComponents.DotNetBar.TabControlPanel();
            this.pnlExamination = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lstViewDiagnosis = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.btnAddDiagnosis = new DevComponents.DotNetBar.ButtonX();
            this.txtComplaint = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDiagnosis = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.tabItem3 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.pnlPreviousVisits = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvPreviousVisits = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel4 = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.textBoxX3 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pnlTreatment = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.textBoxX4 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX5 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgvTreatments = new DevComponents.DotNetBar.Controls.DataGridViewX();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.pnlPatientData.SuspendLayout();
            this.expPanelInoculations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInoculationDate)).BeginInit();
            this.expandablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateBirthdate)).BeginInit();
            this.tabControlPanel3.SuspendLayout();
            this.pnlExamination.SuspendLayout();
            this.tabControlPanel2.SuspendLayout();
            this.pnlPreviousVisits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviousVisits)).BeginInit();
            this.pnlTreatment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel3);
            this.tabControl1.Controls.Add(this.tabControlPanel4);
            this.tabControl1.Controls.Add(this.tabControlPanel2);
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 3;
            this.tabControl1.Size = new System.Drawing.Size(849, 476);
            this.tabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.RoundHeader;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabPatientData);
            this.tabControl1.Tabs.Add(this.tabItem2);
            this.tabControl1.Tabs.Add(this.tabItem3);
            this.tabControl1.Tabs.Add(this.tabItem1);
            this.tabControl1.Text = "tabControl1";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.pnlPatientData);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 28);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(849, 448);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.White;
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(215)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.SystemColors.ControlDarkDark;
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabPatientData;
            // 
            // pnlPatientData
            // 
            this.pnlPatientData.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlPatientData.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnlPatientData.Controls.Add(this.expPanelInoculations);
            this.pnlPatientData.Controls.Add(this.btnClearPatientData);
            this.pnlPatientData.Controls.Add(this.expandablePanel1);
            this.pnlPatientData.Controls.Add(this.btnEditPatientData);
            this.pnlPatientData.Controls.Add(this.btnAddNewPatient);
            this.pnlPatientData.Controls.Add(this.btnFindPatient);
            this.pnlPatientData.Controls.Add(this.textBoxX1);
            this.pnlPatientData.Controls.Add(this.labelX6);
            this.pnlPatientData.Controls.Add(this.switchBtnBirthType);
            this.pnlPatientData.Controls.Add(this.switchBtnSucklingType);
            this.pnlPatientData.Controls.Add(this.switchBtnGender);
            this.pnlPatientData.Controls.Add(this.dateBirthdate);
            this.pnlPatientData.Controls.Add(this.txtAddress);
            this.pnlPatientData.Controls.Add(this.txtPhone);
            this.pnlPatientData.Controls.Add(this.txtName);
            this.pnlPatientData.Controls.Add(this.labelX8);
            this.pnlPatientData.Controls.Add(this.labelX7);
            this.pnlPatientData.Controls.Add(this.labelX5);
            this.pnlPatientData.Controls.Add(this.labelX4);
            this.pnlPatientData.Controls.Add(this.labelX3);
            this.pnlPatientData.Controls.Add(this.labelX2);
            this.pnlPatientData.Controls.Add(this.labelX1);
            this.pnlPatientData.Location = new System.Drawing.Point(13, 4);
            this.pnlPatientData.Name = "pnlPatientData";
            this.pnlPatientData.Size = new System.Drawing.Size(826, 434);
            // 
            // 
            // 
            this.pnlPatientData.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlPatientData.Style.BackColorGradientAngle = 90;
            this.pnlPatientData.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlPatientData.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlPatientData.Style.BorderBottomWidth = 1;
            this.pnlPatientData.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlPatientData.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlPatientData.Style.BorderLeftWidth = 1;
            this.pnlPatientData.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlPatientData.Style.BorderRightWidth = 1;
            this.pnlPatientData.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlPatientData.Style.BorderTopWidth = 1;
            this.pnlPatientData.Style.Class = "";
            this.pnlPatientData.Style.CornerDiameter = 4;
            this.pnlPatientData.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnlPatientData.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnlPatientData.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlPatientData.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnlPatientData.StyleMouseDown.Class = "";
            this.pnlPatientData.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnlPatientData.StyleMouseOver.Class = "";
            this.pnlPatientData.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnlPatientData.TabIndex = 2;
            this.pnlPatientData.Text = "بيانات المريض";
            // 
            // expPanelInoculations
            // 
            this.expPanelInoculations.CanvasColor = System.Drawing.SystemColors.Control;
            this.expPanelInoculations.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expPanelInoculations.Controls.Add(this.textBoxX3);
            this.expPanelInoculations.Controls.Add(this.dtInoculationDate);
            this.expPanelInoculations.Controls.Add(this.btnAddInoculation);
            this.expPanelInoculations.Controls.Add(this.k);
            this.expPanelInoculations.Expanded = false;
            this.expPanelInoculations.ExpandedBounds = new System.Drawing.Rectangle(3, 230, 435, 167);
            this.expPanelInoculations.Location = new System.Drawing.Point(3, 230);
            this.expPanelInoculations.Name = "expPanelInoculations";
            this.expPanelInoculations.Size = new System.Drawing.Size(435, 26);
            this.expPanelInoculations.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expPanelInoculations.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expPanelInoculations.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expPanelInoculations.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expPanelInoculations.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expPanelInoculations.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expPanelInoculations.Style.GradientAngle = 90;
            this.expPanelInoculations.TabIndex = 17;
            this.expPanelInoculations.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expPanelInoculations.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expPanelInoculations.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expPanelInoculations.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expPanelInoculations.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expPanelInoculations.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expPanelInoculations.TitleStyle.GradientAngle = 90;
            this.expPanelInoculations.TitleText = "التطعيمات";
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
            this.dtInoculationDate.Location = new System.Drawing.Point(262, 34);
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
            this.dtInoculationDate.TabIndex = 16;
            // 
            // btnAddInoculation
            // 
            this.btnAddInoculation.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddInoculation.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddInoculation.Image = global::DrIbrahimClinic.Properties.Resources.Add;
            this.btnAddInoculation.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnAddInoculation.Location = new System.Drawing.Point(406, 34);
            this.btnAddInoculation.Name = "btnAddInoculation";
            this.btnAddInoculation.Size = new System.Drawing.Size(26, 26);
            this.btnAddInoculation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddInoculation.TabIndex = 19;
            // 
            // k
            // 
            // 
            // 
            // 
            this.k.Border.Class = "ListViewBorder";
            this.k.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.k.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.k.FullRowSelect = true;
            this.k.GridLines = true;
            this.k.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.k.Location = new System.Drawing.Point(0, -62);
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(435, 88);
            this.k.TabIndex = 17;
            this.k.UseCompatibleStateImageBehavior = false;
            this.k.View = System.Windows.Forms.View.Details;
            // 
            // btnClearPatientData
            // 
            this.btnClearPatientData.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClearPatientData.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClearPatientData.Image = global::DrIbrahimClinic.Properties.Resources.Clear;
            this.btnClearPatientData.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnClearPatientData.Location = new System.Drawing.Point(495, 362);
            this.btnClearPatientData.Name = "btnClearPatientData";
            this.btnClearPatientData.Size = new System.Drawing.Size(75, 35);
            this.btnClearPatientData.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClearPatientData.TabIndex = 15;
            this.btnClearPatientData.Text = "مسح";
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel1.Controls.Add(this.buttonX1);
            this.expandablePanel1.Controls.Add(this.textBoxX2);
            this.expandablePanel1.Controls.Add(this.listViewEx1);
            this.expandablePanel1.Expanded = false;
            this.expandablePanel1.ExpandedBounds = new System.Drawing.Rectangle(3, 20, 349, 209);
            this.expandablePanel1.Location = new System.Drawing.Point(3, 20);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(349, 26);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 16;
            this.expandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "Medical History";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::DrIbrahimClinic.Properties.Resources.Add;
            this.buttonX1.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.buttonX1.Location = new System.Drawing.Point(320, 34);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(26, 26);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 19;
            // 
            // textBoxX2
            // 
            // 
            // 
            // 
            this.textBoxX2.Border.Class = "TextBoxBorder";
            this.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX2.Location = new System.Drawing.Point(3, 34);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxX2.Size = new System.Drawing.Size(311, 26);
            this.textBoxX2.TabIndex = 18;
            // 
            // listViewEx1
            // 
            // 
            // 
            // 
            this.listViewEx1.Border.Class = "ListViewBorder";
            this.listViewEx1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.listViewEx1.FullRowSelect = true;
            this.listViewEx1.GridLines = true;
            this.listViewEx1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewEx1.Location = new System.Drawing.Point(3, 66);
            this.listViewEx1.Name = "listViewEx1";
            this.listViewEx1.Size = new System.Drawing.Size(343, 138);
            this.listViewEx1.TabIndex = 17;
            this.listViewEx1.UseCompatibleStateImageBehavior = false;
            this.listViewEx1.View = System.Windows.Forms.View.Details;
            // 
            // btnEditPatientData
            // 
            this.btnEditPatientData.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditPatientData.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEditPatientData.Image = global::DrIbrahimClinic.Properties.Resources.Edit;
            this.btnEditPatientData.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnEditPatientData.Location = new System.Drawing.Point(576, 362);
            this.btnEditPatientData.Name = "btnEditPatientData";
            this.btnEditPatientData.Size = new System.Drawing.Size(75, 35);
            this.btnEditPatientData.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEditPatientData.TabIndex = 16;
            this.btnEditPatientData.Text = "تعديل";
            // 
            // btnAddNewPatient
            // 
            this.btnAddNewPatient.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddNewPatient.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddNewPatient.Image = global::DrIbrahimClinic.Properties.Resources.Add;
            this.btnAddNewPatient.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnAddNewPatient.Location = new System.Drawing.Point(657, 362);
            this.btnAddNewPatient.Name = "btnAddNewPatient";
            this.btnAddNewPatient.Size = new System.Drawing.Size(75, 35);
            this.btnAddNewPatient.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddNewPatient.TabIndex = 14;
            this.btnAddNewPatient.Text = "جديد";
            // 
            // btnFindPatient
            // 
            this.btnFindPatient.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFindPatient.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFindPatient.Image = global::DrIbrahimClinic.Properties.Resources.Search;
            this.btnFindPatient.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnFindPatient.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnFindPatient.Location = new System.Drawing.Point(358, 20);
            this.btnFindPatient.Name = "btnFindPatient";
            this.btnFindPatient.Size = new System.Drawing.Size(80, 68);
            this.btnFindPatient.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFindPatient.TabIndex = 14;
            this.btnFindPatient.Text = "بحث";
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Location = new System.Drawing.Point(444, 20);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxX1.Size = new System.Drawing.Size(264, 26);
            this.textBoxX1.TabIndex = 10;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(742, 14);
            this.labelX6.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelX6.Name = "labelX6";
            this.labelX6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX6.Size = new System.Drawing.Size(68, 34);
            this.labelX6.TabIndex = 9;
            this.labelX6.Text = "رقم المريض";
            // 
            // switchBtnBirthType
            // 
            // 
            // 
            // 
            this.switchBtnBirthType.BackgroundStyle.Class = "";
            this.switchBtnBirthType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchBtnBirthType.Location = new System.Drawing.Point(620, 278);
            this.switchBtnBirthType.Name = "switchBtnBirthType";
            this.switchBtnBirthType.OffText = "قيصري";
            this.switchBtnBirthType.OnBackColor = System.Drawing.Color.Transparent;
            this.switchBtnBirthType.OnText = "طبيعي";
            this.switchBtnBirthType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.switchBtnBirthType.Size = new System.Drawing.Size(88, 22);
            this.switchBtnBirthType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchBtnBirthType.TabIndex = 5;
            this.switchBtnBirthType.Value = true;
            // 
            // switchBtnSucklingType
            // 
            // 
            // 
            // 
            this.switchBtnSucklingType.BackgroundStyle.Class = "";
            this.switchBtnSucklingType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchBtnSucklingType.Location = new System.Drawing.Point(620, 320);
            this.switchBtnSucklingType.Name = "switchBtnSucklingType";
            this.switchBtnSucklingType.OffText = "صناعي";
            this.switchBtnSucklingType.OnBackColor = System.Drawing.Color.Transparent;
            this.switchBtnSucklingType.OnText = "طبيعي";
            this.switchBtnSucklingType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.switchBtnSucklingType.Size = new System.Drawing.Size(88, 22);
            this.switchBtnSucklingType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchBtnSucklingType.TabIndex = 6;
            this.switchBtnSucklingType.Value = true;
            // 
            // switchBtnGender
            // 
            // 
            // 
            // 
            this.switchBtnGender.BackgroundStyle.Class = "";
            this.switchBtnGender.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchBtnGender.Location = new System.Drawing.Point(620, 152);
            this.switchBtnGender.Name = "switchBtnGender";
            this.switchBtnGender.OffText = "بنت";
            this.switchBtnGender.OnBackColor = System.Drawing.Color.Transparent;
            this.switchBtnGender.OnText = "ولد";
            this.switchBtnGender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.switchBtnGender.Size = new System.Drawing.Size(88, 22);
            this.switchBtnGender.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchBtnGender.TabIndex = 2;
            this.switchBtnGender.Value = true;
            // 
            // dateBirthdate
            // 
            // 
            // 
            // 
            this.dateBirthdate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateBirthdate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateBirthdate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateBirthdate.ButtonDropDown.Visible = true;
            this.dateBirthdate.Location = new System.Drawing.Point(508, 106);
            // 
            // 
            // 
            this.dateBirthdate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateBirthdate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dateBirthdate.MonthCalendar.BackgroundStyle.Class = "";
            this.dateBirthdate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateBirthdate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateBirthdate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateBirthdate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateBirthdate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateBirthdate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateBirthdate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateBirthdate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateBirthdate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dateBirthdate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateBirthdate.MonthCalendar.DisplayMonth = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dateBirthdate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateBirthdate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateBirthdate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateBirthdate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateBirthdate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateBirthdate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dateBirthdate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateBirthdate.MonthCalendar.TodayButtonVisible = true;
            this.dateBirthdate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateBirthdate.Name = "dateBirthdate";
            this.dateBirthdate.Size = new System.Drawing.Size(200, 26);
            this.dateBirthdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateBirthdate.TabIndex = 1;
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.Border.Class = "TextBoxBorder";
            this.txtAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAddress.Location = new System.Drawing.Point(444, 230);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAddress.Size = new System.Drawing.Size(264, 26);
            this.txtAddress.TabIndex = 4;
            // 
            // txtPhone
            // 
            // 
            // 
            // 
            this.txtPhone.Border.Class = "TextBoxBorder";
            this.txtPhone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPhone.Location = new System.Drawing.Point(444, 188);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(264, 26);
            this.txtPhone.TabIndex = 3;
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.Border.Class = "TextBoxBorder";
            this.txtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtName.Location = new System.Drawing.Point(444, 62);
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtName.Size = new System.Drawing.Size(264, 26);
            this.txtName.TabIndex = 0;
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(735, 308);
            this.labelX8.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelX8.Name = "labelX8";
            this.labelX8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX8.Size = new System.Drawing.Size(75, 34);
            this.labelX8.TabIndex = 8;
            this.labelX8.Text = "نوع الرضاعة";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(742, 266);
            this.labelX7.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelX7.Name = "labelX7";
            this.labelX7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX7.Size = new System.Drawing.Size(68, 34);
            this.labelX7.TabIndex = 7;
            this.labelX7.Text = "نوع الولادة";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(742, 182);
            this.labelX5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelX5.Name = "labelX5";
            this.labelX5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX5.Size = new System.Drawing.Size(68, 34);
            this.labelX5.TabIndex = 5;
            this.labelX5.Text = "تليفون";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(742, 224);
            this.labelX4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(68, 34);
            this.labelX4.TabIndex = 4;
            this.labelX4.Text = "العنوان";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(742, 140);
            this.labelX3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(68, 34);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "النوع";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(742, 98);
            this.labelX2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(68, 34);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "تاريخ الميلاد";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(742, 56);
            this.labelX1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(68, 34);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "اسم المريض";
            // 
            // tabPatientData
            // 
            this.tabPatientData.AttachedControl = this.tabControlPanel1;
            this.tabPatientData.Name = "tabPatientData";
            this.tabPatientData.Text = "المريض";
            // 
            // tabControlPanel3
            // 
            this.tabControlPanel3.Controls.Add(this.pnlExamination);
            this.tabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel3.Location = new System.Drawing.Point(0, 28);
            this.tabControlPanel3.Name = "tabControlPanel3";
            this.tabControlPanel3.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel3.Size = new System.Drawing.Size(849, 448);
            this.tabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.White;
            this.tabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(215)))));
            this.tabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel3.Style.BorderColor.Color = System.Drawing.SystemColors.ControlDarkDark;
            this.tabControlPanel3.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel3.Style.GradientAngle = 90;
            this.tabControlPanel3.TabIndex = 3;
            this.tabControlPanel3.TabItem = this.tabItem3;
            // 
            // pnlExamination
            // 
            this.pnlExamination.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlExamination.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnlExamination.Controls.Add(this.pnlTreatment);
            this.pnlExamination.Controls.Add(this.lstViewDiagnosis);
            this.pnlExamination.Controls.Add(this.btnAddDiagnosis);
            this.pnlExamination.Controls.Add(this.txtComplaint);
            this.pnlExamination.Controls.Add(this.txtDiagnosis);
            this.pnlExamination.Controls.Add(this.labelX10);
            this.pnlExamination.Controls.Add(this.labelX9);
            this.pnlExamination.Location = new System.Drawing.Point(4, 4);
            this.pnlExamination.Name = "pnlExamination";
            this.pnlExamination.Size = new System.Drawing.Size(841, 440);
            // 
            // 
            // 
            this.pnlExamination.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlExamination.Style.BackColorGradientAngle = 90;
            this.pnlExamination.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlExamination.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlExamination.Style.BorderBottomWidth = 1;
            this.pnlExamination.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlExamination.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlExamination.Style.BorderLeftWidth = 1;
            this.pnlExamination.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlExamination.Style.BorderRightWidth = 1;
            this.pnlExamination.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlExamination.Style.BorderTopWidth = 1;
            this.pnlExamination.Style.Class = "";
            this.pnlExamination.Style.CornerDiameter = 4;
            this.pnlExamination.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnlExamination.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnlExamination.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlExamination.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnlExamination.StyleMouseDown.Class = "";
            this.pnlExamination.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnlExamination.StyleMouseOver.Class = "";
            this.pnlExamination.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnlExamination.TabIndex = 5;
            this.pnlExamination.Text = "بيانات الكشف";
            // 
            // lstViewDiagnosis
            // 
            // 
            // 
            // 
            this.lstViewDiagnosis.Border.Class = "ListViewBorder";
            this.lstViewDiagnosis.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lstViewDiagnosis.FullRowSelect = true;
            this.lstViewDiagnosis.GridLines = true;
            this.lstViewDiagnosis.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstViewDiagnosis.Location = new System.Drawing.Point(5, 84);
            this.lstViewDiagnosis.Name = "lstViewDiagnosis";
            this.lstViewDiagnosis.Size = new System.Drawing.Size(356, 248);
            this.lstViewDiagnosis.TabIndex = 16;
            this.lstViewDiagnosis.UseCompatibleStateImageBehavior = false;
            this.lstViewDiagnosis.View = System.Windows.Forms.View.Details;
            // 
            // btnAddDiagnosis
            // 
            this.btnAddDiagnosis.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddDiagnosis.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddDiagnosis.Image = global::DrIbrahimClinic.Properties.Resources.Add;
            this.btnAddDiagnosis.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnAddDiagnosis.Location = new System.Drawing.Point(335, 52);
            this.btnAddDiagnosis.Name = "btnAddDiagnosis";
            this.btnAddDiagnosis.Size = new System.Drawing.Size(26, 26);
            this.btnAddDiagnosis.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddDiagnosis.TabIndex = 15;
            // 
            // txtComplaint
            // 
            // 
            // 
            // 
            this.txtComplaint.Border.Class = "TextBoxBorder";
            this.txtComplaint.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtComplaint.Location = new System.Drawing.Point(97, 10);
            this.txtComplaint.Name = "txtComplaint";
            this.txtComplaint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtComplaint.Size = new System.Drawing.Size(264, 26);
            this.txtComplaint.TabIndex = 12;
            // 
            // txtDiagnosis
            // 
            // 
            // 
            // 
            this.txtDiagnosis.Border.Class = "TextBoxBorder";
            this.txtDiagnosis.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDiagnosis.Location = new System.Drawing.Point(97, 52);
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDiagnosis.Size = new System.Drawing.Size(232, 26);
            this.txtDiagnosis.TabIndex = 11;
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.Class = "";
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(5, 46);
            this.labelX10.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(84, 34);
            this.labelX10.TabIndex = 3;
            this.labelX10.Text = "Diagnosis";
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.Class = "";
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(5, 4);
            this.labelX9.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(84, 34);
            this.labelX9.TabIndex = 2;
            this.labelX9.Text = "Complaint";
            // 
            // tabItem3
            // 
            this.tabItem3.AttachedControl = this.tabControlPanel3;
            this.tabItem3.Name = "tabItem3";
            this.tabItem3.Text = "الكشف";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.pnlPreviousVisits);
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 28);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(849, 448);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.White;
            this.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(215)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.SystemColors.ControlDarkDark;
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 2;
            this.tabControlPanel2.TabItem = this.tabItem2;
            // 
            // pnlPreviousVisits
            // 
            this.pnlPreviousVisits.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlPreviousVisits.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnlPreviousVisits.Controls.Add(this.dgvPreviousVisits);
            this.pnlPreviousVisits.Location = new System.Drawing.Point(13, 4);
            this.pnlPreviousVisits.Name = "pnlPreviousVisits";
            this.pnlPreviousVisits.Size = new System.Drawing.Size(826, 434);
            // 
            // 
            // 
            this.pnlPreviousVisits.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlPreviousVisits.Style.BackColorGradientAngle = 90;
            this.pnlPreviousVisits.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlPreviousVisits.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlPreviousVisits.Style.BorderBottomWidth = 1;
            this.pnlPreviousVisits.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlPreviousVisits.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlPreviousVisits.Style.BorderLeftWidth = 1;
            this.pnlPreviousVisits.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlPreviousVisits.Style.BorderRightWidth = 1;
            this.pnlPreviousVisits.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlPreviousVisits.Style.BorderTopWidth = 1;
            this.pnlPreviousVisits.Style.Class = "";
            this.pnlPreviousVisits.Style.CornerDiameter = 4;
            this.pnlPreviousVisits.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnlPreviousVisits.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnlPreviousVisits.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlPreviousVisits.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnlPreviousVisits.StyleMouseDown.Class = "";
            this.pnlPreviousVisits.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnlPreviousVisits.StyleMouseOver.Class = "";
            this.pnlPreviousVisits.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnlPreviousVisits.TabIndex = 3;
            this.pnlPreviousVisits.Text = "الزيارات السابقة";
            // 
            // dgvPreviousVisits
            // 
            this.dgvPreviousVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPreviousVisits.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPreviousVisits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPreviousVisits.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvPreviousVisits.Location = new System.Drawing.Point(0, 0);
            this.dgvPreviousVisits.Name = "dgvPreviousVisits";
            this.dgvPreviousVisits.Size = new System.Drawing.Size(820, 407);
            this.dgvPreviousVisits.TabIndex = 0;
            // 
            // tabItem2
            // 
            this.tabItem2.AttachedControl = this.tabControlPanel2;
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Text = "الزيارات السابقة";
            // 
            // tabControlPanel4
            // 
            this.tabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel4.Location = new System.Drawing.Point(0, 28);
            this.tabControlPanel4.Name = "tabControlPanel4";
            this.tabControlPanel4.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel4.Size = new System.Drawing.Size(849, 448);
            this.tabControlPanel4.Style.BackColor1.Color = System.Drawing.Color.White;
            this.tabControlPanel4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(215)))));
            this.tabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel4.Style.BorderColor.Color = System.Drawing.SystemColors.ControlDarkDark;
            this.tabControlPanel4.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel4.Style.GradientAngle = 90;
            this.tabControlPanel4.TabIndex = 4;
            this.tabControlPanel4.TabItem = this.tabItem1;
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel4;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "الروشتة";
            // 
            // textBoxX3
            // 
            // 
            // 
            // 
            this.textBoxX3.Border.Class = "TextBoxBorder";
            this.textBoxX3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX3.Location = new System.Drawing.Point(3, 34);
            this.textBoxX3.Name = "textBoxX3";
            this.textBoxX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxX3.Size = new System.Drawing.Size(253, 26);
            this.textBoxX3.TabIndex = 20;
            // 
            // pnlTreatment
            // 
            this.pnlTreatment.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlTreatment.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnlTreatment.Controls.Add(this.buttonX2);
            this.pnlTreatment.Controls.Add(this.textBoxX4);
            this.pnlTreatment.Controls.Add(this.textBoxX5);
            this.pnlTreatment.Controls.Add(this.dgvTreatments);
            this.pnlTreatment.Location = new System.Drawing.Point(367, 10);
            this.pnlTreatment.Name = "pnlTreatment";
            this.pnlTreatment.Size = new System.Drawing.Size(465, 322);
            // 
            // 
            // 
            this.pnlTreatment.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlTreatment.Style.BackColorGradientAngle = 90;
            this.pnlTreatment.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlTreatment.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlTreatment.Style.BorderBottomWidth = 1;
            this.pnlTreatment.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlTreatment.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlTreatment.Style.BorderLeftWidth = 1;
            this.pnlTreatment.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlTreatment.Style.BorderRightWidth = 1;
            this.pnlTreatment.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlTreatment.Style.BorderTopWidth = 1;
            this.pnlTreatment.Style.Class = "";
            this.pnlTreatment.Style.CornerDiameter = 4;
            this.pnlTreatment.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnlTreatment.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnlTreatment.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlTreatment.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnlTreatment.StyleMouseDown.Class = "";
            this.pnlTreatment.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnlTreatment.StyleMouseOver.Class = "";
            this.pnlTreatment.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnlTreatment.TabIndex = 17;
            this.pnlTreatment.Text = "العلاج";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Image = global::DrIbrahimClinic.Properties.Resources.Add;
            this.buttonX2.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.buttonX2.Location = new System.Drawing.Point(2, 3);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(26, 26);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 16;
            // 
            // textBoxX4
            // 
            // 
            // 
            // 
            this.textBoxX4.Border.Class = "TextBoxBorder";
            this.textBoxX4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX4.Location = new System.Drawing.Point(34, 3);
            this.textBoxX4.Name = "textBoxX4";
            this.textBoxX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxX4.Size = new System.Drawing.Size(208, 26);
            this.textBoxX4.TabIndex = 13;
            // 
            // textBoxX5
            // 
            // 
            // 
            // 
            this.textBoxX5.Border.Class = "TextBoxBorder";
            this.textBoxX5.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX5.Location = new System.Drawing.Point(248, 3);
            this.textBoxX5.Name = "textBoxX5";
            this.textBoxX5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxX5.Size = new System.Drawing.Size(208, 26);
            this.textBoxX5.TabIndex = 12;
            // 
            // dgvTreatments
            // 
            this.dgvTreatments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTreatments.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTreatments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTreatments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvTreatments.Location = new System.Drawing.Point(0, 35);
            this.dgvTreatments.Name = "dgvTreatments";
            this.dgvTreatments.Size = new System.Drawing.Size(459, 260);
            this.dgvTreatments.TabIndex = 0;
            // 
            // FrmAddExamination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 500);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Name = "FrmAddExamination";
            this.Text = "إضافة كشف جديد";
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.pnlPatientData.ResumeLayout(false);
            this.expPanelInoculations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtInoculationDate)).EndInit();
            this.expandablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateBirthdate)).EndInit();
            this.tabControlPanel3.ResumeLayout(false);
            this.pnlExamination.ResumeLayout(false);
            this.tabControlPanel2.ResumeLayout(false);
            this.pnlPreviousVisits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviousVisits)).EndInit();
            this.pnlTreatment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabPatientData;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel3;
        private DevComponents.DotNetBar.TabItem tabItem3;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel4;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.Controls.GroupPanel pnlPatientData;
        private DevComponents.DotNetBar.ButtonX btnClearPatientData;
        private DevComponents.DotNetBar.ButtonX btnEditPatientData;
        private DevComponents.DotNetBar.ButtonX btnAddNewPatient;
        private DevComponents.DotNetBar.ButtonX btnFindPatient;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.SwitchButton switchBtnBirthType;
        private DevComponents.DotNetBar.Controls.SwitchButton switchBtnSucklingType;
        private DevComponents.DotNetBar.Controls.SwitchButton switchBtnGender;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateBirthdate;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAddress;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPhone;
        private DevComponents.DotNetBar.Controls.TextBoxX txtName;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.GroupPanel pnlPreviousVisits;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvPreviousVisits;
        private DevComponents.DotNetBar.Controls.GroupPanel pnlExamination;
        private DevComponents.DotNetBar.Controls.ListViewEx lstViewDiagnosis;
        private DevComponents.DotNetBar.ButtonX btnAddDiagnosis;
        private DevComponents.DotNetBar.Controls.TextBoxX txtComplaint;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiagnosis;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
        private DevComponents.DotNetBar.Controls.ListViewEx listViewEx1;
        private DevComponents.DotNetBar.ExpandablePanel expPanelInoculations;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtInoculationDate;
        private DevComponents.DotNetBar.ButtonX btnAddInoculation;
        private DevComponents.DotNetBar.Controls.ListViewEx k;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX3;
        private DevComponents.DotNetBar.Controls.GroupPanel pnlTreatment;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX4;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX5;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTreatments;
    }
}