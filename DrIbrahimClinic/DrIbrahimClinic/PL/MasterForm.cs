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
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.EnableGlass = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.ShowInTaskbar = false;
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }
    }
}
