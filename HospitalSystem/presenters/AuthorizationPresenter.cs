using HospitalSystem.models;
using HospitalSystem.support;
using HospitalSystem.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using HospitalSystem.models.entities;

namespace HospitalSystem.presenters
    //kinda done
{
    class AuthorizationPresenter
    {
        IAuthorizationModel model;
        IAuthorizationView view;

        public AuthorizationPresenter(IAuthorizationView view)
        {
            this.model = new AuthorizationModel();
            this.view = view;
        }

        public void LoginMethod()
        {
            try
            {
                 
                model.LoginMethod(view.Login, view.Password);

                if (CurrentUser.Administrator!=null )
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    SaveLoginOptions();
                    view.Hide();
                }
                else if (CurrentUser.DoctorUser != null)
                {
                    DoctorForm doctorForm = new DoctorForm();
                    doctorForm.Show();
                    SaveLoginOptions();
                    view.Hide();
                }
                else if (CurrentUser.AccountantUser != null)
                {
                    AccountantForm accountantForm = new AccountantForm();
                    accountantForm.Show();
                    SaveLoginOptions();
                    view.Hide();
                }
                else
                    MessageBox.Show("Проверьте правильность ввода логина и пароля", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                if (view.Login == CurrentUser.admin.Login && view.Password == CurrentUser.admin.Password)
                {
                    MessageBox.Show("Проблемы с подключением к БД. \nПопробуйте сменить параметры подключения", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ConnectionSettingsForm connection = new ConnectionSettingsForm();
                    connection.Show();
                    view.Hide();
                }
                else
                    MessageBox.Show("Отсутствует подключение к БД. \nОбратитесь к администратору", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void LoadLoginOptions()
        {
            try
            {
                if (File.Exists(Core.loginOptions) && File.ReadAllText(Core.loginOptions) != "")
                {
                    var loginData = StringСryptography.Decrypt(File.ReadAllText(Core.loginOptions)).Split('㊗');
                    view.Login = loginData[0];
                    view.Password = loginData[1];
                    view.SaveOptions = Convert.ToBoolean(loginData[2]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        internal void SaveLoginOptions()
        {
            try
            {
                string loginOptions = "";
                if (view.SaveOptions)
                    loginOptions = $"{view.Login}㊗{view.Password}㊗{view.SaveOptions}";
                File.WriteAllText(Core.loginOptions, StringСryptography.Encrypt(loginOptions));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
