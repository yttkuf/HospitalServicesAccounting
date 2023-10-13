using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.views
{
  
        internal interface IQueryView : IView// inherites IView
        {
            string Query { get; }
        }
    }
