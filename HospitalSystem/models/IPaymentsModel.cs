using HospitalSystem.models.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.models
{
    internal interface IPaymentsModel
    {
        List<Payment> GetPayments();
        void EditPayment();

    }
}
