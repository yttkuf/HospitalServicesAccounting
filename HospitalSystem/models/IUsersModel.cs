using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.models
{
    internal interface IUsersModel
    {
        object GetDoctors();
        object GetAccountants();
        void AddDoctor(string login, string password);
        void AddAccountant(string login, bool isPrime);
        void DeleteDoctor(object item);
        void DeleteAccounta(object item);
    }
}
