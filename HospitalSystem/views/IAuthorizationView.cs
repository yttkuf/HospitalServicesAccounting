using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.views
{
    public interface IAuthorizationView
    {
        void Hide();
        string Login { set; get; }
        string Password { set; get; }
        bool SaveOptions { set; get; }
    }
}
