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
            this.dgvExaminations = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.pnlSearchExaminations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExaminations)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearchExaminations
            // 
            this.pnlSearchExaminations.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlSearchExaminations.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnlSearchExaminations.Controls.Add(this.dgvExaminations);
            this.pnlSearchExaminations.Location = new System.Drawing.Point(12, 12);
            this.pnlSearchExaminations.Name = "pnlSearchExaminations";
            this.pnlSearchExaminations.Size = new System.Drawing.Size(875, 521);
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
            // dgvExaminations
            // 
            this.dgvExaminations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExaminations.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExaminations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvExaminations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvExaminations.Location = new System.Drawing.Point(0, 80);
            this.dgvExaminations.Name = "dgvExaminations";
            this.dgvExaminations.Size = new System.Drawing.Size(869, 414);
            this.dgvExaminations.TabIndex = 3;
            // 
            // FrmSearchExamination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 543);
            this.Controls.Add(this.pnlSearchExaminations);
            this.DoubleBuffered = true;
            this.Name = "FrmSearchExamination";
            this.Text = "بحث عن كشف";
            this.pnlSearchExaminations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExaminations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel pnlSearchExaminations;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvExaminations;
    }
}