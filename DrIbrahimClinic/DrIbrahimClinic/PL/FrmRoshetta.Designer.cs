namespace DrIbrahimClinic.PL
{
    partial class FrmRoshetta
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RoshettaTreatmentVmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptViewerRoshetta = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.RoshettaTreatmentVmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RoshettaTreatmentVmBindingSource
            // 
            this.RoshettaTreatmentVmBindingSource.DataSource = typeof(DrIbrahimClinic.DAL.VMs.RoshettaTreatmentVm);
            // 
            // rptViewerRoshetta
            // 
            this.rptViewerRoshetta.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RoshettaDataSet";
            reportDataSource1.Value = this.RoshettaTreatmentVmBindingSource;
            this.rptViewerRoshetta.LocalReport.DataSources.Add(reportDataSource1);
            this.rptViewerRoshetta.LocalReport.ReportEmbeddedResource = "DrIbrahimClinic.PL.Reports.RoshettaReport.rdlc";
            this.rptViewerRoshetta.Location = new System.Drawing.Point(0, 0);
            this.rptViewerRoshetta.Name = "rptViewerRoshetta";
            this.rptViewerRoshetta.Size = new System.Drawing.Size(584, 741);
            this.rptViewerRoshetta.TabIndex = 0;
            // 
            // FrmRoshetta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 741);
            this.Controls.Add(this.rptViewerRoshetta);
            this.DoubleBuffered = true;
            this.Name = "FrmRoshetta";
            this.Text = "الروشتة";
            this.Load += new System.EventHandler(this.FrmRo4etta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoshettaTreatmentVmBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptViewerRoshetta;
        private System.Windows.Forms.BindingSource RoshettaTreatmentVmBindingSource;
    }
}