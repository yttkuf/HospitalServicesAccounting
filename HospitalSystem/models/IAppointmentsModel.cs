using HospitalSystem.models.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.models
{
    internal interface IAppointmentsModel
    {
        List<Patient> GetDoctors();
        void EditAppointment();
        void AddPaymentInformation();
        void DeleteAppointment();
    }
}
