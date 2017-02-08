using System;
using System.Collections.Generic;
using System.Linq;
using DrIbrahimClinic.DAL.Model;
using DrIbrahimClinic.DAL;

namespace DrIbrahimClinic.BLL
{
    public class PatientManager : BaseManager
    {
        #region Properties

        private PatientRepository _patientRepository;

        public PatientRepository PatientRepository
            => _patientRepository ?? (_patientRepository = new PatientRepository());

        #endregion

        #region Methods

        public void AddPatient(Patient patient)
        {
            PatientRepository.Add(patient);
            PatientRepository.Save();
        }

        public void UpdatePatient(Patient patient)
        {
            PatientRepository.Update(patient);
            PatientRepository.Save();
        }

        public void DeletePatient(Patient patient)
        {
            PatientRepository.Delete(patient);
            PatientRepository.Save();
        }

        public IEnumerable<Patient> GetAllPatients()
        {
            return PatientRepository.GetAll().AsEnumerable();
        }

        public Patient GetPatientById(int patientId)
        {
            return GetAllPatients().FirstOrDefault(patient => patient.Id == patientId);
        }

        public IEnumerable<Patient> GetPatients(Func<Patient, bool> where)
        {
            return GetAllPatients().Where(where);
        }

        #endregion
    }
}