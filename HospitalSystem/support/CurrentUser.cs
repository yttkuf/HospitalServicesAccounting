using HospitalSystem.models.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.support
{
    public static class CurrentUser
    {
        public static User DoctorUser { get; set; }
        public static User AccountantUser { get; set; }
        public static User Administrator { get; set; }
        public readonly static User admin = new User { Login = "meckbaig", Password = "MeckbAdmin" };
    }
}
