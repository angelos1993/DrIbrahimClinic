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
            this.radStartsWith = new System.Windows.Forms.RadioButton();
            this.radContains = new System.Windows.Forms.RadioButton();
            this.txtTreatmentName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgvTreatments = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.pnlSearchPatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearchPatients
            // 
            this.pnlSearchPatients.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlSearchPatients.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnlSearchPatients.Controls.Add(this.radStartsWith);
            this.pnlSearchPatients.Controls.Add(this.radContains);
            this.pnlSearchPatients.Controls.Add(this.txtTreatmentName);
            this.pnlSearchPatients.Controls.Add(this.dgvTreatments);
            this.pnlSearchPatients.Location = new System.Drawing.Point(12, 12);
            this.pnlSearchPatients.Name = "pnlSearchPatients";
            this.pnlSearchPatients.Size = new System.Drawing.Size(832, 521);
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
            // radStartsWith
            // 
            this.radStartsWith.AutoSize = true;
            this.radStartsWith.BackColor = System.Drawing.Color.Transparent;
            this.radStartsWith.Checked = true;
            this.radStartsWith.Location = new System.Drawing.Point(273, 3);
            this.radStartsWith.Name = "radStartsWith";
            this.radStartsWith.Size = new System.Drawing.Size(108, 23);
            this.radStartsWith.TabIndex = 1;
            this.radStartsWith.TabStop = true;
            this.radStartsWith.Text = "Starts with";
            this.radStartsWith.UseVisualStyleBackColor = false;
            // 
            // radContains
            // 
            this.radContains.AutoSize = true;
            this.radContains.BackColor = System.Drawing.Color.Transparent;
            this.radContains.Location = new System.Drawing.Point(384, 3);
            this.radContains.Name = "radContains";
            this.radContains.Size = new System.Drawing.Size(96, 23);
            this.radContains.TabIndex = 2;
            this.radContains.Text = "Contains";
            this.radContains.UseVisualStyleBackColor = false;
            // 
            // txtTreatmentName
            // 
            // 
            // 
            // 
            this.txtTreatmentName.Border.Class = "TextBoxBorder";
            this.txtTreatmentName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTreatmentName.Location = new System.Drawing.Point(3, 3);
            this.txtTreatmentName.Name = "txtTreatmentName";
            this.txtTreatmentName.Size = new System.Drawing.Size(264, 26);
            this.txtTreatmentName.TabIndex = 0;
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
            this.dgvTreatments.Location = new System.Drawing.Point(0, 80);
            this.dgvTreatments.Name = "dgvTreatments";
            this.dgvTreatments.Size = new System.Drawing.Size(826, 414);
            this.dgvTreatments.TabIndex = 3;
            // 
            // FrmSearchPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 545);
            this.Controls.Add(this.pnlSearchPatients);
            this.DoubleBuffered = true;
            this.Name = "FrmSearchPatient";
            this.Text = "بحث عن مريض";
            this.pnlSearchPatients.ResumeLayout(false);
            this.pnlSearchPatients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel pnlSearchPatients;
        private System.Windows.Forms.RadioButton radStartsWith;
        private System.Windows.Forms.RadioButton radContains;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTreatmentName;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTreatments;
    }
}