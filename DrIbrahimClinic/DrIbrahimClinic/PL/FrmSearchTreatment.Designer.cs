namespace DrIbrahimClinic.PL
{
    partial class FrmSearchTreatment
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
            this.pnlSearchTreatments = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.radStartsWith = new System.Windows.Forms.RadioButton();
            this.radContains = new System.Windows.Forms.RadioButton();
            this.txtTreatmentName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgvTreatments = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.pnlSearchTreatments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearchTreatments
            // 
            this.pnlSearchTreatments.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlSearchTreatments.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnlSearchTreatments.Controls.Add(this.radStartsWith);
            this.pnlSearchTreatments.Controls.Add(this.radContains);
            this.pnlSearchTreatments.Controls.Add(this.txtTreatmentName);
            this.pnlSearchTreatments.Controls.Add(this.dgvTreatments);
            this.pnlSearchTreatments.Location = new System.Drawing.Point(11, 13);
            this.pnlSearchTreatments.Name = "pnlSearchTreatments";
            this.pnlSearchTreatments.Size = new System.Drawing.Size(462, 501);
            // 
            // 
            // 
            this.pnlSearchTreatments.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlSearchTreatments.Style.BackColorGradientAngle = 90;
            this.pnlSearchTreatments.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlSearchTreatments.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlSearchTreatments.Style.BorderBottomWidth = 1;
            this.pnlSearchTreatments.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlSearchTreatments.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlSearchTreatments.Style.BorderLeftWidth = 1;
            this.pnlSearchTreatments.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlSearchTreatments.Style.BorderRightWidth = 1;
            this.pnlSearchTreatments.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlSearchTreatments.Style.BorderTopWidth = 1;
            this.pnlSearchTreatments.Style.Class = "";
            this.pnlSearchTreatments.Style.CornerDiameter = 4;
            this.pnlSearchTreatments.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnlSearchTreatments.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnlSearchTreatments.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlSearchTreatments.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnlSearchTreatments.StyleMouseDown.Class = "";
            this.pnlSearchTreatments.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnlSearchTreatments.StyleMouseOver.Class = "";
            this.pnlSearchTreatments.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnlSearchTreatments.TabIndex = 0;
            this.pnlSearchTreatments.Text = "بحث عن علاج";
            // 
            // radStartsWith
            // 
            this.radStartsWith.AutoSize = true;
            this.radStartsWith.BackColor = System.Drawing.Color.Transparent;
            this.radStartsWith.Checked = true;
            this.radStartsWith.Location = new System.Drawing.Point(246, 3);
            this.radStartsWith.Name = "radStartsWith";
            this.radStartsWith.Size = new System.Drawing.Size(102, 24);
            this.radStartsWith.TabIndex = 1;
            this.radStartsWith.TabStop = true;
            this.radStartsWith.Text = "Starts with";
            this.radStartsWith.UseVisualStyleBackColor = false;
            this.radStartsWith.CheckedChanged += new System.EventHandler(this.FindTreatment);
            // 
            // radContains
            // 
            this.radContains.AutoSize = true;
            this.radContains.BackColor = System.Drawing.Color.Transparent;
            this.radContains.Location = new System.Drawing.Point(353, 3);
            this.radContains.Name = "radContains";
            this.radContains.Size = new System.Drawing.Size(90, 24);
            this.radContains.TabIndex = 2;
            this.radContains.Text = "Contains";
            this.radContains.UseVisualStyleBackColor = false;
            this.radContains.CheckedChanged += new System.EventHandler(this.FindTreatment);
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
            this.txtTreatmentName.Size = new System.Drawing.Size(238, 26);
            this.txtTreatmentName.TabIndex = 0;
            this.txtTreatmentName.TextChanged += new System.EventHandler(this.FindTreatment);
            // 
            // dgvTreatments
            // 
            this.dgvTreatments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTreatments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTreatments.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTreatments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTreatments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvTreatments.Location = new System.Drawing.Point(0, 38);
            this.dgvTreatments.Name = "dgvTreatments";
            this.dgvTreatments.ReadOnly = true;
            this.dgvTreatments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTreatments.Size = new System.Drawing.Size(456, 436);
            this.dgvTreatments.TabIndex = 3;
            // 
            // FrmSearchTreatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 526);
            this.Controls.Add(this.pnlSearchTreatments);
            this.DoubleBuffered = true;
            this.Name = "FrmSearchTreatment";
            this.Text = "بحث عن علاج";
            this.Load += new System.EventHandler(this.FrmSearchTreatment_Load);
            this.pnlSearchTreatments.ResumeLayout(false);
            this.pnlSearchTreatments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel pnlSearchTreatments;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTreatments;
        private System.Windows.Forms.RadioButton radStartsWith;
        private System.Windows.Forms.RadioButton radContains;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTreatmentName;
    }
}