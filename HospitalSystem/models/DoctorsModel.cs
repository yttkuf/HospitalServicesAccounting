using HospitalSystem.models.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.models
{
    internal class DoctorsModel : IDoctorsModel
    {
        public void AddDoctor(string name, string username, string adress)
        {
            throw new NotImplementedException();
        }

        public void DeleteDoctor(string name)
        {
            throw new NotImplementedException();
        }

        public List<Patient> GetDoctors()
        {
            throw new NotImplementedException();
        }
        public List<Patient> GetDeletedDoctors()
        {
            throw new NotImplementedException();
        }
    }
}
