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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSearchPatients = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.intInputPatientId = new DevComponents.Editors.IntegerInput();
            this.btnClearSearch = new DevComponents.DotNetBar.ButtonX();
            this.txtPatientPhone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtPatientName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgvPatients = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.pnlSearchPatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intInputPatientId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearchPatients
            // 
            this.pnlSearchPatients.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlSearchPatients.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnlSearchPatients.Controls.Add(this.intInputPatientId);
            this.pnlSearchPatients.Controls.Add(this.btnClearSearch);
            this.pnlSearchPatients.Controls.Add(this.txtPatientPhone);
            this.pnlSearchPatients.Controls.Add(this.labelX5);
            this.pnlSearchPatients.Controls.Add(this.labelX6);
            this.pnlSearchPatients.Controls.Add(this.labelX1);
            this.pnlSearchPatients.Controls.Add(this.txtPatientName);
            this.pnlSearchPatients.Controls.Add(this.dgvPatients);
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
            // intInputPatientId
            // 
            // 
            // 
            // 
            this.intInputPatientId.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intInputPatientId.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.intInputPatientId.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.intInputPatientId.Location = new System.Drawing.Point(449, 3);
            this.intInputPatientId.MinValue = 0;
            this.intInputPatientId.Name = "intInputPatientId";
            this.intInputPatientId.ShowUpDown = true;
            this.intInputPatientId.Size = new System.Drawing.Size(232, 26);
            this.intInputPatientId.TabIndex = 0;
            this.intInputPatientId.ValueChanged += new System.EventHandler(this.FindPatient);
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClearSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClearSearch.Image = global::DrIbrahimClinic.Properties.Resources.Undo;
            this.btnClearSearch.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnClearSearch.Location = new System.Drawing.Point(175, 39);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(259, 26);
            this.btnClearSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClearSearch.TabIndex = 3;
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
            this.txtPatientPhone.Location = new System.Drawing.Point(175, 7);
            this.txtPatientPhone.Name = "txtPatientPhone";
            this.txtPatientPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPatientPhone.Size = new System.Drawing.Size(191, 26);
            this.txtPatientPhone.TabIndex = 2;
            this.txtPatientPhone.WatermarkText = "رقم التليفون ...";
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
            this.labelX5.Location = new System.Drawing.Point(373, 1);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4);
            this.labelX5.Name = "labelX5";
            this.labelX5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX5.Size = new System.Drawing.Size(61, 36);
            this.labelX5.TabIndex = 17;
            this.labelX5.Text = "تليفون";
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
            this.labelX6.Margin = new System.Windows.Forms.Padding(4);
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
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(93, 36);
            this.labelX1.TabIndex = 12;
            this.labelX1.Text = "اسم المريض";
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
            this.txtPatientName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPatientName.Size = new System.Drawing.Size(232, 26);
            this.txtPatientName.TabIndex = 1;
            this.txtPatientName.WatermarkText = "اسم المريض ...";
            this.txtPatientName.TextChanged += new System.EventHandler(this.FindPatient);
            // 
            // dgvPatients
            // 
            this.dgvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatients.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPatients.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPatients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvPatients.Location = new System.Drawing.Point(0, 72);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatients.Size = new System.Drawing.Size(785, 449);
            this.dgvPatients.TabIndex = 4;
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
            ((System.ComponentModel.ISupportInitialize)(this.intInputPatientId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel pnlSearchPatients;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPatientName;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvPatients;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPatientPhone;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ButtonX btnClearSearch;
        private DevComponents.Editors.IntegerInput intInputPatientId;
    }
}