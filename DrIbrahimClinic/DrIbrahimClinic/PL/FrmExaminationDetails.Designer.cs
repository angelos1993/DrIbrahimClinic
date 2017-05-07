namespace DrIbrahimClinic.PL
{
    partial class FrmExaminationDetails
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
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.dgvTreatments = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lblDiagnosis = new DevComponents.DotNetBar.LabelX();
            this.lblComplaint = new DevComponents.DotNetBar.LabelX();
            this.lblPatientLnWtHdCir = new DevComponents.DotNetBar.LabelX();
            this.lblPatientName = new DevComponents.DotNetBar.LabelX();
            this.lblExaminationTypeAndDate = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = global::DrIbrahimClinic.Properties.Resources.Exit;
            this.btnCancel.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnCancel.Location = new System.Drawing.Point(167, 353);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 37);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "خروج";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.dgvTreatments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvTreatments.Location = new System.Drawing.Point(12, 157);
            this.dgvTreatments.Name = "dgvTreatments";
            this.dgvTreatments.ReadOnly = true;
            this.dgvTreatments.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTreatments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTreatments.Size = new System.Drawing.Size(402, 190);
            this.dgvTreatments.TabIndex = 6;
            // 
            // lblDiagnosis
            // 
            // 
            // 
            // 
            this.lblDiagnosis.BackgroundStyle.Class = "";
            this.lblDiagnosis.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDiagnosis.Location = new System.Drawing.Point(12, 128);
            this.lblDiagnosis.Name = "lblDiagnosis";
            this.lblDiagnosis.Size = new System.Drawing.Size(402, 23);
            this.lblDiagnosis.TabIndex = 5;
            this.lblDiagnosis.Text = "Diagnosis";
            this.lblDiagnosis.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblComplaint
            // 
            // 
            // 
            // 
            this.lblComplaint.BackgroundStyle.Class = "";
            this.lblComplaint.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblComplaint.Location = new System.Drawing.Point(12, 99);
            this.lblComplaint.Name = "lblComplaint";
            this.lblComplaint.Size = new System.Drawing.Size(402, 23);
            this.lblComplaint.TabIndex = 4;
            this.lblComplaint.Text = "Complaint";
            this.lblComplaint.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblPatientLnWtHdCir
            // 
            // 
            // 
            // 
            this.lblPatientLnWtHdCir.BackgroundStyle.Class = "";
            this.lblPatientLnWtHdCir.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPatientLnWtHdCir.Location = new System.Drawing.Point(12, 70);
            this.lblPatientLnWtHdCir.Name = "lblPatientLnWtHdCir";
            this.lblPatientLnWtHdCir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPatientLnWtHdCir.Size = new System.Drawing.Size(402, 23);
            this.lblPatientLnWtHdCir.TabIndex = 3;
            this.lblPatientLnWtHdCir.Text = "Patient Details (Ln, Wt, HdCir)";
            this.lblPatientLnWtHdCir.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblPatientName
            // 
            this.lblPatientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.lblPatientName.BackgroundStyle.Class = "";
            this.lblPatientName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblPatientName.Location = new System.Drawing.Point(12, 41);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPatientName.Size = new System.Drawing.Size(402, 23);
            this.lblPatientName.TabIndex = 2;
            this.lblPatientName.Text = "Patient name";
            this.lblPatientName.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblExaminationTypeAndDate
            // 
            // 
            // 
            // 
            this.lblExaminationTypeAndDate.BackgroundStyle.Class = "";
            this.lblExaminationTypeAndDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblExaminationTypeAndDate.Location = new System.Drawing.Point(12, 12);
            this.lblExaminationTypeAndDate.Name = "lblExaminationTypeAndDate";
            this.lblExaminationTypeAndDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblExaminationTypeAndDate.Size = new System.Drawing.Size(402, 23);
            this.lblExaminationTypeAndDate.TabIndex = 0;
            this.lblExaminationTypeAndDate.Text = "Examination Type & Date";
            this.lblExaminationTypeAndDate.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // FrmExaminationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvTreatments);
            this.Controls.Add(this.lblDiagnosis);
            this.Controls.Add(this.lblComplaint);
            this.Controls.Add(this.lblPatientLnWtHdCir);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.lblExaminationTypeAndDate);
            this.DoubleBuffered = true;
            this.Name = "FrmExaminationDetails";
            this.Text = "تفاصيل الكشف";
            this.Load += new System.EventHandler(this.FrmExaminationDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblExaminationTypeAndDate;
        private DevComponents.DotNetBar.LabelX lblPatientName;
        private DevComponents.DotNetBar.LabelX lblPatientLnWtHdCir;
        private DevComponents.DotNetBar.LabelX lblComplaint;
        private DevComponents.DotNetBar.LabelX lblDiagnosis;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTreatments;
        private DevComponents.DotNetBar.ButtonX btnCancel;
    }
}