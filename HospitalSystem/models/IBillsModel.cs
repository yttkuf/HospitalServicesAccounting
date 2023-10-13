using HospitalSystem.models.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.models
{
    internal interface IBillsModel
    {
        List<Bill> GetBills();
        
        void ChangePaymentMethod();
        void ProcessPayment();// add a payment to table payments уже не актуально придумав другу. схему
        void UpdatePaymentStatus();
    }
}
