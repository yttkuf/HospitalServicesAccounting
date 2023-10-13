using HospitalSystem.models.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.models
{
    internal interface IDoctorsModel
    {
        List<Patient> GetDoctors();
        List<Patient> GetDeletedDoctors();

        void AddDoctor(string name, string username, string adress);// add trigger before insert create a user
        void DeleteDoctor(string name);

    }
}
