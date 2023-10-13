using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalSystem.support;
using HospitalSystem.presenters;
namespace HospitalSystem.views.admin
{
    public partial class EditServicesForm : ProgrammStyleForm,IEditServicesView
    {
        ServicesPresenter presenter;

        public object Services
        {
            set
            {
                servicesDataGrid.DataSource = value;
            }
        }

        public object Dismissed
        {
            set
            {
                deletedServicesListBox.DataSource = value;
            }
        }

        public object Deleted { set => throw new NotImplementedException(); }

        public EditServicesForm()
        {
            InitializeComponent();
            presenter = new ServicesPresenter(this);

            servicesDataGrid.Name = "Name";
            deletedServicesListBox.DisplayMember = "Name";
            // servicesDataGrid.DataSource = Core.Context.Services.ToList();
        }
        private void SudentsForm_Load(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        private void addServiceBtn_Click(object sender, EventArgs e)
        {
            presenter.AddService(Text);
        }

        private void RecoverButton_Click(object sender, EventArgs e)
        {
            presenter.RecoverStudent(Text);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            presenter.DeleteStudent(Text);
        }

      
    }
}
