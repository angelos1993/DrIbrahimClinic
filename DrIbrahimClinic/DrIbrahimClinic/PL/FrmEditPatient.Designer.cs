namespace DrIbrahimClinic.PL
{
    partial class FrmEditPatient
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
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnClear = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.grpPanelPatient = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.intInputId = new DevComponents.Editors.IntegerInput();
            this.btnFindPatient = new DevComponents.DotNetBar.ButtonX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.switchBtnBirthType = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.switchBtnSucklingType = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.switchBtnGender = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.dtBirthdate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
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
            this.grpPanelPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intInputId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBirthdate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::DrIbrahimClinic.Properties.Resources.Save;
            this.btnSave.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(268, 414);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 37);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClear.Image = global::DrIbrahimClinic.Properties.Resources.Clear;
            this.btnClear.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnClear.Location = new System.Drawing.Point(170, 414);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 37);
            this.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "مسح";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = global::DrIbrahimClinic.Properties.Resources.Exit;
            this.btnCancel.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnCancel.Location = new System.Drawing.Point(72, 414);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 37);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "خروج";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpPanelPatient
            // 
            this.grpPanelPatient.CanvasColor = System.Drawing.SystemColors.Control;
            this.grpPanelPatient.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.grpPanelPatient.Controls.Add(this.intInputId);
            this.grpPanelPatient.Controls.Add(this.btnFindPatient);
            this.grpPanelPatient.Controls.Add(this.labelX6);
            this.grpPanelPatient.Controls.Add(this.switchBtnBirthType);
            this.grpPanelPatient.Controls.Add(this.switchBtnSucklingType);
            this.grpPanelPatient.Controls.Add(this.switchBtnGender);
            this.grpPanelPatient.Controls.Add(this.dtBirthdate);
            this.grpPanelPatient.Controls.Add(this.txtAddress);
            this.grpPanelPatient.Controls.Add(this.txtPhone);
            this.grpPanelPatient.Controls.Add(this.txtName);
            this.grpPanelPatient.Controls.Add(this.labelX8);
            this.grpPanelPatient.Controls.Add(this.labelX7);
            this.grpPanelPatient.Controls.Add(this.labelX5);
            this.grpPanelPatient.Controls.Add(this.labelX4);
            this.grpPanelPatient.Controls.Add(this.labelX3);
            this.grpPanelPatient.Controls.Add(this.labelX2);
            this.grpPanelPatient.Controls.Add(this.labelX1);
            this.grpPanelPatient.Location = new System.Drawing.Point(11, 13);
            this.grpPanelPatient.Name = "grpPanelPatient";
            this.grpPanelPatient.Size = new System.Drawing.Size(419, 388);
            // 
            // 
            // 
            this.grpPanelPatient.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.grpPanelPatient.Style.BackColorGradientAngle = 90;
            this.grpPanelPatient.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.grpPanelPatient.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpPanelPatient.Style.BorderBottomWidth = 1;
            this.grpPanelPatient.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.grpPanelPatient.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpPanelPatient.Style.BorderLeftWidth = 1;
            this.grpPanelPatient.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpPanelPatient.Style.BorderRightWidth = 1;
            this.grpPanelPatient.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpPanelPatient.Style.BorderTopWidth = 1;
            this.grpPanelPatient.Style.Class = "";
            this.grpPanelPatient.Style.CornerDiameter = 4;
            this.grpPanelPatient.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grpPanelPatient.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grpPanelPatient.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grpPanelPatient.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.grpPanelPatient.StyleMouseDown.Class = "";
            this.grpPanelPatient.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.grpPanelPatient.StyleMouseOver.Class = "";
            this.grpPanelPatient.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.grpPanelPatient.TabIndex = 10;
            this.grpPanelPatient.Text = "بيانات المريض";
            // 
            // intInputId
            // 
            // 
            // 
            // 
            this.intInputId.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intInputId.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.intInputId.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.intInputId.Location = new System.Drawing.Point(81, 12);
            this.intInputId.MinValue = 0;
            this.intInputId.Name = "intInputId";
            this.intInputId.ShowUpDown = true;
            this.intInputId.Size = new System.Drawing.Size(237, 26);
            this.intInputId.TabIndex = 16;
            // 
            // btnFindPatient
            // 
            this.btnFindPatient.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFindPatient.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFindPatient.Image = global::DrIbrahimClinic.Properties.Resources.Search;
            this.btnFindPatient.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnFindPatient.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnFindPatient.Location = new System.Drawing.Point(3, 12);
            this.btnFindPatient.Name = "btnFindPatient";
            this.btnFindPatient.Size = new System.Drawing.Size(72, 72);
            this.btnFindPatient.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFindPatient.TabIndex = 15;
            this.btnFindPatient.Text = "بحث";
            this.btnFindPatient.Click += new System.EventHandler(this.btnFindPatient_Click);
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(325, 3);
            this.labelX6.Margin = new System.Windows.Forms.Padding(4);
            this.labelX6.Name = "labelX6";
            this.labelX6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX6.Size = new System.Drawing.Size(85, 36);
            this.labelX6.TabIndex = 11;
            this.labelX6.Text = "رقم المريض";
            // 
            // switchBtnBirthType
            // 
            // 
            // 
            // 
            this.switchBtnBirthType.BackgroundStyle.Class = "";
            this.switchBtnBirthType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchBtnBirthType.Location = new System.Drawing.Point(238, 283);
            this.switchBtnBirthType.Name = "switchBtnBirthType";
            this.switchBtnBirthType.OffText = "قيصري";
            this.switchBtnBirthType.OnBackColor = System.Drawing.Color.Transparent;
            this.switchBtnBirthType.OnText = "طبيعي";
            this.switchBtnBirthType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.switchBtnBirthType.Size = new System.Drawing.Size(79, 23);
            this.switchBtnBirthType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchBtnBirthType.TabIndex = 6;
            this.switchBtnBirthType.Value = true;
            // 
            // switchBtnSucklingType
            // 
            // 
            // 
            // 
            this.switchBtnSucklingType.BackgroundStyle.Class = "";
            this.switchBtnSucklingType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchBtnSucklingType.Location = new System.Drawing.Point(238, 327);
            this.switchBtnSucklingType.Name = "switchBtnSucklingType";
            this.switchBtnSucklingType.OffText = "صناعي";
            this.switchBtnSucklingType.OnBackColor = System.Drawing.Color.Transparent;
            this.switchBtnSucklingType.OnText = "طبيعي";
            this.switchBtnSucklingType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.switchBtnSucklingType.Size = new System.Drawing.Size(79, 23);
            this.switchBtnSucklingType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchBtnSucklingType.TabIndex = 7;
            this.switchBtnSucklingType.Value = true;
            // 
            // switchBtnGender
            // 
            // 
            // 
            // 
            this.switchBtnGender.BackgroundStyle.Class = "";
            this.switchBtnGender.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchBtnGender.Location = new System.Drawing.Point(238, 151);
            this.switchBtnGender.Name = "switchBtnGender";
            this.switchBtnGender.OffText = "بنت";
            this.switchBtnGender.OnBackColor = System.Drawing.Color.Transparent;
            this.switchBtnGender.OnText = "ولد";
            this.switchBtnGender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.switchBtnGender.Size = new System.Drawing.Size(79, 23);
            this.switchBtnGender.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchBtnGender.TabIndex = 3;
            this.switchBtnGender.Value = true;
            // 
            // dtBirthdate
            // 
            // 
            // 
            // 
            this.dtBirthdate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtBirthdate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBirthdate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtBirthdate.ButtonDropDown.Visible = true;
            this.dtBirthdate.Location = new System.Drawing.Point(138, 102);
            // 
            // 
            // 
            this.dtBirthdate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtBirthdate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtBirthdate.MonthCalendar.BackgroundStyle.Class = "";
            this.dtBirthdate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBirthdate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtBirthdate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtBirthdate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtBirthdate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtBirthdate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtBirthdate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtBirthdate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtBirthdate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtBirthdate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBirthdate.MonthCalendar.DisplayMonth = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtBirthdate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtBirthdate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtBirthdate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtBirthdate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtBirthdate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtBirthdate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtBirthdate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBirthdate.MonthCalendar.TodayButtonVisible = true;
            this.dtBirthdate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtBirthdate.Name = "dtBirthdate";
            this.dtBirthdate.Size = new System.Drawing.Size(180, 26);
            this.dtBirthdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtBirthdate.TabIndex = 2;
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.Border.Class = "TextBoxBorder";
            this.txtAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAddress.Location = new System.Drawing.Point(31, 233);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAddress.Size = new System.Drawing.Size(287, 26);
            this.txtAddress.TabIndex = 5;
            // 
            // txtPhone
            // 
            // 
            // 
            // 
            this.txtPhone.Border.Class = "TextBoxBorder";
            this.txtPhone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPhone.Location = new System.Drawing.Point(31, 188);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(287, 26);
            this.txtPhone.TabIndex = 4;
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.Border.Class = "TextBoxBorder";
            this.txtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtName.Location = new System.Drawing.Point(80, 56);
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtName.Size = new System.Drawing.Size(238, 26);
            this.txtName.TabIndex = 1;
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(325, 315);
            this.labelX8.Margin = new System.Windows.Forms.Padding(4);
            this.labelX8.Name = "labelX8";
            this.labelX8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX8.Size = new System.Drawing.Size(85, 36);
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
            this.labelX7.Location = new System.Drawing.Point(325, 271);
            this.labelX7.Margin = new System.Windows.Forms.Padding(4);
            this.labelX7.Name = "labelX7";
            this.labelX7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX7.Size = new System.Drawing.Size(85, 36);
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
            this.labelX5.Location = new System.Drawing.Point(325, 182);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4);
            this.labelX5.Name = "labelX5";
            this.labelX5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX5.Size = new System.Drawing.Size(85, 36);
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
            this.labelX4.Location = new System.Drawing.Point(325, 226);
            this.labelX4.Margin = new System.Windows.Forms.Padding(4);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(85, 36);
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
            this.labelX3.Location = new System.Drawing.Point(325, 138);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(85, 36);
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
            this.labelX2.Location = new System.Drawing.Point(325, 94);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(85, 36);
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
            this.labelX1.Location = new System.Drawing.Point(325, 49);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(85, 36);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "اسم المريض";
            // 
            // FrmEditPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 461);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpPanelPatient);
            this.DoubleBuffered = true;
            this.Name = "FrmEditPatient";
            this.Text = "تعديل بيانات مريض";
            this.Load += new System.EventHandler(this.FrmEditPatient_Load);
            this.grpPanelPatient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.intInputId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBirthdate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.SwitchButton switchBtnBirthType;
        private DevComponents.DotNetBar.Controls.SwitchButton switchBtnSucklingType;
        private DevComponents.DotNetBar.Controls.SwitchButton switchBtnGender;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtBirthdate;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAddress;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPhone;
        private DevComponents.DotNetBar.Controls.TextBoxX txtName;
        private DevComponents.DotNetBar.ButtonX btnClear;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.GroupPanel grpPanelPatient;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.ButtonX btnFindPatient;
        private DevComponents.Editors.IntegerInput intInputId;
    }
}