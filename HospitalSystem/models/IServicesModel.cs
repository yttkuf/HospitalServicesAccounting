using HospitalSystem.models.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.models
{
    internal interface IServicesModel
    {
        List<Service> GetServices();
        List<Service> GetDeletedServices();
        void AddStudent(string name);
        void DeleteStudent(object student);
        void RecoverStudent(object item);
    }
}
