using HospitalSystem.models;
using HospitalSystem.support;
using HospitalSystem.views.admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.presenters
{
    public class ServicesPresenter : IPresenter
    {
        IServicesModel model;
        IEditServicesView view;

        public event EventHandler<EventArgs> RenewEvent;

        public ServicesPresenter(IEditServicesView view)
        {
            model = new ServicesModel();
            this.view = view;

            Global.InitializePresenter(this);
        }

        public void LoadData()
        {
            try
            {
                view.Services = model.GetServices();
                view.Deleted = model.GetDeletedServices();
            }
            catch (Exception ex)
            {
                UserFeedback.ErrorMessage(ex);
            }

        }

        internal void AddService(object text)
        {
            throw new NotImplementedException();
        }

        internal void RecoverStudent(object selectedItem)
        {
            throw new NotImplementedException();
        }

        internal void DeleteStudent(object selectedItem)
        {
            throw new NotImplementedException();
        }
    }
}