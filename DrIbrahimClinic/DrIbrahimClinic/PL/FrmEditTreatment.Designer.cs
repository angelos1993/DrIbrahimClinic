namespace DrIbrahimClinic.PL
{
    partial class FrmEditTreatment
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
            this.txtTreatmentOldName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnSaveAndNew = new DevComponents.DotNetBar.ButtonX();
            this.txtTreatmentNewName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btnClear = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // txtTreatmentOldName
            // 
            // 
            // 
            // 
            this.txtTreatmentOldName.Border.Class = "TextBoxBorder";
            this.txtTreatmentOldName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTreatmentOldName.Location = new System.Drawing.Point(11, 13);
            this.txtTreatmentOldName.Name = "txtTreatmentOldName";
            this.txtTreatmentOldName.Size = new System.Drawing.Size(266, 26);
            this.txtTreatmentOldName.TabIndex = 0;
            this.txtTreatmentOldName.WatermarkText = "Treatment Name ...";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(284, 7);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(91, 36);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "اسم العلاج";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = global::DrIbrahimClinic.Properties.Resources.Exit;
            this.btnCancel.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnCancel.Location = new System.Drawing.Point(11, 80);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(67, 37);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "خروج";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::DrIbrahimClinic.Properties.Resources.Save;
            this.btnSave.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(157, 80);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 37);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveAndNew
            // 
            this.btnSaveAndNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveAndNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSaveAndNew.Image = global::DrIbrahimClinic.Properties.Resources.Save;
            this.btnSaveAndNew.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnSaveAndNew.Location = new System.Drawing.Point(229, 80);
            this.btnSaveAndNew.Name = "btnSaveAndNew";
            this.btnSaveAndNew.Size = new System.Drawing.Size(146, 37);
            this.btnSaveAndNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSaveAndNew.TabIndex = 2;
            this.btnSaveAndNew.Text = "حفظ وتعديل آخر";
            this.btnSaveAndNew.Click += new System.EventHandler(this.btnSaveAndNew_Click);
            // 
            // txtTreatmentNewName
            // 
            // 
            // 
            // 
            this.txtTreatmentNewName.Border.Class = "TextBoxBorder";
            this.txtTreatmentNewName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTreatmentNewName.Location = new System.Drawing.Point(11, 46);
            this.txtTreatmentNewName.Name = "txtTreatmentNewName";
            this.txtTreatmentNewName.Size = new System.Drawing.Size(266, 26);
            this.txtTreatmentNewName.TabIndex = 1;
            this.txtTreatmentNewName.WatermarkText = "New Treatment Name ...";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(284, 40);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(91, 36);
            this.labelX2.TabIndex = 11;
            this.labelX2.Text = "الاسم الجديد";
            // 
            // btnClear
            // 
            this.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClear.Image = global::DrIbrahimClinic.Properties.Resources.Clear;
            this.btnClear.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnClear.Location = new System.Drawing.Point(84, 80);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 37);
            this.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "مسح";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmEditTreatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 126);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtTreatmentNewName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSaveAndNew);
            this.Controls.Add(this.txtTreatmentOldName);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Name = "FrmEditTreatment";
            this.Text = "تعديل بيانات علاج";
            this.Load += new System.EventHandler(this.FrmEditTreatment_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnSaveAndNew;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTreatmentOldName;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTreatmentNewName;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btnClear;
    }
}