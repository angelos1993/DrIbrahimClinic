using System.ComponentModel;

namespace DrIbrahimClinic.DAL.VMs
{
    public class TreatmentVm
    {
        //[DisplayName(@"Treatment Id")]
        //public int Id { get; set; }
        [DisplayName(@"Treatment Name")]
        public string Name { get; set; }
    }
}