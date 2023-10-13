using HospitalSystem.models.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HospitalSystem.models
{
    public class ServicesModel:IServicesModel
    {
     

        List<Service> IServicesModel.GetServices()
        {
            throw new NotImplementedException();
        }

        List<Service> IServicesModel.GetDeletedServices()
        {
            throw new NotImplementedException();
        }

        void IServicesModel.AddStudent(string name)
        {
            throw new NotImplementedException();
        }

        void IServicesModel.DeleteStudent(object student)
        {
            throw new NotImplementedException();
        }

        void IServicesModel.RecoverStudent(object item)
        {
            throw new NotImplementedException();
        }
    }
}
