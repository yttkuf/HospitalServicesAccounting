using HospitalSystem.models;
using HospitalSystem.support;
using HospitalSystem.presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;
using HospitalSystem.Properties;
//kinda ashould load
namespace HospitalSystem.views
{
    public partial class AuthorizationForm : Form, IAuthorizationView
    {
        AuthorizationPresenter presenter;
        public AuthorizationForm()
        {
            InitializeComponent();
            presenter = new AuthorizationPresenter(this);
            Core.Server = Settings.Default.server;
            Core.Database = Settings.Default.database;
            Core.Login = Settings.Default.login;
            Core.Password = Settings.Default.password;
           
            ;
            Core.NewConnectionString();
            presenter.LoadLoginOptions();
        }
        public string Login
        {
            set
            {
                loginTextBox.Text = value;
            }
            get
            {
                return loginTextBox.Text;
            }
        }
        public string Password
        {
            set
            {
                passwordTextBox.Text = value;
            }
            get
            {
                return passwordTextBox.Text;
            }
        }
        public bool SaveOptions
        {
            set
            {
                saveOptionsCheckBox.Checked = value;
            }
            get
            {
                return saveOptionsCheckBox.Checked;
            }
        }

     /*   private void ToRegistrationButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            Hide();
        }
*/
        private void LoginButton_Click(object sender, EventArgs e)
        {
            presenter.LoginMethod();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                presenter.LoginMethod();
        }

      /*  private void ForgotPasswordLabel_Click(object sender, EventArgs e)
        {
            RecoveryForm recoveryForm = new RecoveryForm();
            recoveryForm.Show();
            Hide();
        }*/

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
