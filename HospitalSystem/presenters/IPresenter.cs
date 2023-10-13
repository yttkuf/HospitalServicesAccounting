using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.presenters
{
    public interface IPresenter//main presenter Idk
    {
        event EventHandler<EventArgs> RenewEvent;
    }
}
