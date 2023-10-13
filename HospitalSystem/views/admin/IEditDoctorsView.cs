using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.views.admin
{
    internal interface IEditDoctorsView:IView
    {
        object Doctors
        {
            set;
        }

        object Deleted
        {
            set;
        }
    }
}
