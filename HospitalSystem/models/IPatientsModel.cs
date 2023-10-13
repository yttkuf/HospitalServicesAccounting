using HospitalSystem.models.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.models
{
    internal interface IPatientsModel
    {
        List<Patient> GetPatients();
      
        void AddPatient(string name, string ssn, string adress);
       // void EditPatient();
    }
}
