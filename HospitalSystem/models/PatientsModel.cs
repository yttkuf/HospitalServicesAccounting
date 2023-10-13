using HospitalSystem.support;
using HospitalSystem.models.entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.models
{
    public class PatientsModel : IPatientsModel
    {
        public List<Patient> GetPatients() //get Patients to list
        {
            try
            {
                return Core.Context.Patients.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void AddPatient(string name, string ssn, string adress)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new ArgumentException();
                }
                Patient patient = new Patient();
                patient.PatientName = name;
                patient.PatientSSN = ssn;
                if (!string.IsNullOrEmpty(adress)) { patient.PatientAddres = adress; };

                Core.Context.Patients.Add(patient);
                Core.Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
