using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.views.doctor
{
    internal interface IDoctor:IView
    {
        string UserName
        {
            set;
        }
        bool Attendance
        {
            set;
        }
        bool Reports
        {
            set;
        }
        bool Connection
        {
            set;
        }
        bool Settings
        {
            set;
        }

        bool Signed
        {
            set;
        }
        bool Schedules
        {
            set;
        }
        bool Query
        {
            set;
        }
    }
}
