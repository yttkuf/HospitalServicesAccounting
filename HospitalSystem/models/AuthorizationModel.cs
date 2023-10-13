
using HospitalSystem.models.entities;
using HospitalSystem.support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
//Created , maybe add some void or functions later but copied so should work
namespace HospitalSystem.models
{
    public class AuthorizationModel : IAuthorizationModel
    {
        public bool CheckConnection()//checks random command if connection works returns true
        {
            try
            {
                if (Core.Context.Appointments.AsNoTracking().ToList() != null)
                    return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void LoginMethod(string login, string password)//changed from original
        {
            try
            {
                Core.Context.Users.AsNoTracking().ToList();
                var LoggedUser = Core.Context.Users.FirstOrDefault(c => c.Login == login && c.Password == password);
                if (LoggedUser == null)
                {
                    throw new Exception("Введены некорректные учетные данные");
                }
                switch (LoggedUser.IdRole)
                {

                    case 1:
                        {
                            CurrentUser.Administrator = LoggedUser;break;
                        }
                    case 2:
                        { CurrentUser.DoctorUser = LoggedUser; break; }
                    case 3:
                        { CurrentUser.AccountantUser = LoggedUser;break;  }

                }
             
                //change later
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
