using System.ComponentModel;

namespace DrIbrahimClinic.DAL.VMs
{
    public class InoculationVm
    {
        [DisplayName(@"اسم التطعيم")]
        public string Name { get; set; }
        [DisplayName(@"تاريخ التطعيم")]
        public string Date { get; set; }
    }
}