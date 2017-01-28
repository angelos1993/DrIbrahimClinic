namespace DrIbrahimClinic.PL
{
    partial class FrmAddTreatment
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtTreatmentName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSaveAndNew = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(294, 4);
            this.labelX1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(61, 34);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "اسم العلاج";
            // 
            // txtTreatmentName
            // 
            // 
            // 
            // 
            this.txtTreatmentName.Border.Class = "TextBoxBorder";
            this.txtTreatmentName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTreatmentName.Location = new System.Drawing.Point(12, 12);
            this.txtTreatmentName.Name = "txtTreatmentName";
            this.txtTreatmentName.Size = new System.Drawing.Size(274, 26);
            this.txtTreatmentName.TabIndex = 1;
            // 
            // btnSaveAndNew
            // 
            this.btnSaveAndNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveAndNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSaveAndNew.Image = global::DrIbrahimClinic.Properties.Resources.Save;
            this.btnSaveAndNew.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnSaveAndNew.Location = new System.Drawing.Point(228, 47);
            this.btnSaveAndNew.Name = "btnSaveAndNew";
            this.btnSaveAndNew.Size = new System.Drawing.Size(129, 35);
            this.btnSaveAndNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSaveAndNew.TabIndex = 2;
            this.btnSaveAndNew.Text = "حفظ وإضافة آخر";
            this.btnSaveAndNew.Click += new System.EventHandler(this.btnSaveAndNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = global::DrIbrahimClinic.Properties.Resources.X;
            this.btnCancel.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnCancel.Location = new System.Drawing.Point(10, 47);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 35);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "خروج";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::DrIbrahimClinic.Properties.Resources.Save;
            this.btnSave.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(119, 47);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 35);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmAddTreatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 92);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSaveAndNew);
            this.Controls.Add(this.txtTreatmentName);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "FrmAddTreatment";
            this.RightToLeftLayout = true;
            this.Text = "إضافة علاج جديد";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTreatmentName;
        private DevComponents.DotNetBar.ButtonX btnSaveAndNew;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnCancel;
    }
}