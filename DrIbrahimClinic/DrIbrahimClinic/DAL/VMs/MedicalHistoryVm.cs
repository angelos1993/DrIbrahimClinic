using System.ComponentModel;

namespace DrIbrahimClinic.DAL.VMs
{
    public class MedicalHistoryVm
    {
        [DisplayName(@"Medical History Description")]
        public string Description { get; set; }
    }
}