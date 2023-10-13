using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalSystem.views;
using HospitalSystem.presenters;
namespace HospitalSystem
{
    public partial class AccountantForm : MainMenuStyleForm
    {
        public AccountantForm()
        {
            InitializeComponent();


        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /*    private void pricesBtn_Click(object sender, EventArgs e)
            {
                //string sqlConnectionString = ConfigurationManager.ConnectionStrings["HospitalSystem.Properties.Settings.SqlConnection"].ConnectionString;
                ServiceView view = new ServiceView();
                var ConnSetting = new ConnectionSettings();
                ConnSetting.Connecting();
                HospitalContext context = new HospitalContext(ConnSetting.Connection);
                new ServicePresenter(view, context);
                view.Show();}*/
    }
    }

