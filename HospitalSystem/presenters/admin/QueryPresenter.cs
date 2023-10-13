using HospitalSystem.support;
using HospitalSystem.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.presenters
{
    internal class QueryPresenter
    {
        IQueryView view;

        public QueryPresenter(IQueryView view)
        {
            this.view = view;
        }

        internal void ExecCommand()
        {
            try
            {
                var result = Core.Context.Database.ExecuteSqlCommand(view.Query);
                UserFeedback.InformationMessage($"Команда выплнена, изменено строк: {result}");
            }
            catch (Exception ex)
            {
                UserFeedback.ErrorMessage(ex);
            }
        }
    }
}
