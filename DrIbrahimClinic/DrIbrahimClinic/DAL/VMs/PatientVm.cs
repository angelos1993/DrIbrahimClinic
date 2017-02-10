using System;
using System.ComponentModel;

namespace DrIbrahimClinic.DAL.VMs
{
    public class PatientVm
    {
        [DisplayName("الرقم")]
        public int Id { get; set; }

        [DisplayName("الاسم")]
        public string Name { get; set; }

        [DisplayName("تاريخ الميلاد")]
        public DateTime? Birthdate { get; set; }

        [DisplayName("النوع")]
        public string Gender { get; set; }

        [DisplayName("العنوان")]
        public string Address { get; set; }

        [DisplayName("تليفون")]
        public string Phone { get; set; }

        [DisplayName("نوع الولادة")]
        public string BirthType { get; set; }

        [DisplayName("نوع الرضاعة")]
        public string SucklingType { get; set; }
    }
}