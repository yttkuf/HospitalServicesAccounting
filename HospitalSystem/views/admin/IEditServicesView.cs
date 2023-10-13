using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.views.admin
{
    public interface IEditServicesView:IView
    {
        object Services
        {
            set;
        }

        object Deleted
        {
            set;
        }
    }
}
