using DrIbrahimClinic.DAL.Model;
using DrIbrahimClinic.DAL;

namespace DrIbrahimClinic.BBL
{
    public class PatientManager : BaseManager
    {
        #region Properties

        private PatientRepository _patientRepository;

        public PatientRepository PatientRepository
            => _patientRepository ?? (_patientRepository = new PatientRepository());

        #endregion

        public void AddPatient(Patient patient)
        {
            PatientRepository.Add(patient);
            PatientRepository.Save();
        }
    }
}