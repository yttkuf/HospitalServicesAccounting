using HospitalSystem.support;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalSystem.views.admin
{
    public partial class EditDoctorsForm : ProgrammStyleForm,IEditDoctorsView
    {
        public EditDoctorsForm()
        {
            InitializeComponent();
            
        }

        public object Doctors { set => throw new NotImplementedException(); }
        public object Deleted { set => throw new NotImplementedException(); }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
