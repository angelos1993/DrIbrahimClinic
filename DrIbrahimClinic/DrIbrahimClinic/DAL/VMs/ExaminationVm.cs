using System.ComponentModel;

namespace DrIbrahimClinic.DAL.VMs
{
    public class ExaminationVm
    {
        [DisplayName(@"رقم المريض")]
        public int PatientId { get; set; }
        [DisplayName(@"اسم المريض")]
        public string PatientName { get; set; }
        [DisplayName(@"تاريخ الكشف")]
        public string ExaminationDate { get; set; }
        [DisplayName(@"نوع الكشف")]
        public string ExaminationType { get; set; }
        [DisplayName(@"الشكوي")]
        public string Complaint { get; set; }
        [DisplayName(@"التشخيص")]
        public string Diagnosis { get; set; }
        [DisplayName(@"الطول")]
        public string PatientLength { get; set; }
        [DisplayName(@"الوزن")]
        public string PatientWeight { get; set; }
        [DisplayName(@"محيط الرأس")]
        public string PatientHeadCircumference { get; set; }
        [DisplayName(@"العلاج")]
        public string Treatment { get; set; }
    }
}