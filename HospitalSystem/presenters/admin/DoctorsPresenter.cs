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
    internal class DoctorsPresenter : IPresenter
    {
        IDoctorsModel model;
        IEditDoctorsView view;

        public event EventHandler<EventArgs> RenewEvent;

        public DoctorsPresenter(IEditDoctorsView view)
        {
            model = new DoctorsModel();
            this.view = view;

            Global.InitializePresenter(this);
        }

        public void LoadData()
        {
            try
            {
                view.Doctors = model.GetDoctors();
                view.Deleted = model.GetDeletedDoctors();
            }
            catch (Exception ex)
            {
                UserFeedback.ErrorMessage(ex);
            }

        }

    }
}
