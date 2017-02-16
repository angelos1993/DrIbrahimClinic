using System.ComponentModel;

namespace DrIbrahimClinic.DAL.VMs
{
    public class ExaminationTreatmentVm
    {
        [DisplayName(@"العلاج")]
        public string TreatmentName { get; set; }
        [DisplayName(@"الوصف")]
        public string TreatmentDescription { get; set; }
    }
}