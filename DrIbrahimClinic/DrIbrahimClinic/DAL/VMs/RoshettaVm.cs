using System.Collections.Generic;

namespace DrIbrahimClinic.DAL.VMs
{
    public class RoshettaVm
    {
        public string PatientId { get; set; }
        public string PatientName { get; set; }
        public string PatientWeight { get; set; }
        public string ExaminationDate { get; set; }
        public string PatientAge { get; set; }
        public List<RoshettaTreatmentVm> RoshettaTreatments { get; set; }
    }
}