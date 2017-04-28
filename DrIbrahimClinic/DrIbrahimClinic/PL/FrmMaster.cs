using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace DrIbrahimClinic.PL
{
    public partial class FrmMaster : Office2007Form
    {
        public FrmMaster()
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
            //Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular);
            ShowInTaskbar = false;
            AutoScaleMode = AutoScaleMode.Font;
        }
    }
}