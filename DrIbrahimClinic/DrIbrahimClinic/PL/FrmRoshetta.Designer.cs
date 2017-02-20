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
            this.rptViewerRoshetta = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptViewerRoshetta
            // 
            this.rptViewerRoshetta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptViewerRoshetta.LocalReport.ReportEmbeddedResource = "DrIbrahimClinic.PL.Reports.Roshetta.rdlc";
            this.rptViewerRoshetta.Location = new System.Drawing.Point(0, 0);
            this.rptViewerRoshetta.Name = "rptViewerRoshetta";
            this.rptViewerRoshetta.Size = new System.Drawing.Size(394, 494);
            this.rptViewerRoshetta.TabIndex = 0;
            // 
            // FrmRoshetta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 494);
            this.Controls.Add(this.rptViewerRoshetta);
            this.DoubleBuffered = true;
            this.Name = "FrmRoshetta";
            this.Text = "الروشتة";
            this.Load += new System.EventHandler(this.FrmRo4etta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptViewerRoshetta;
    }
}