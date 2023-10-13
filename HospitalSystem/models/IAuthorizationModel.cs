using HospitalSystem.models.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Created , maybe add some void or functions later but copied so should work
namespace HospitalSystem.models
{
    interface IAuthorizationModel
    {
        void LoginMethod(string login, string password);
        bool CheckConnection();
    }
}
