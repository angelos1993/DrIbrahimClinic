using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace DrIbrahimClinic.PL
{
    public partial class MasterForm : Office2007Form
    {
        public MasterForm()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            MaximizeBox = false;
            EnableGlass = false;
            StartPosition = FormStartPosition.CenterScreen;
            Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            ShowInTaskbar = false;
            AutoScaleMode = AutoScaleMode.Font;
        }
    }
}