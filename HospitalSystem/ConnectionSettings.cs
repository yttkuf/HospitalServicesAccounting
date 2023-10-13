using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity;

namespace HospitalSystem
{
     public class ConnectionSettings
    {
        private string connection;

        public string Connection { get => connection; set => connection = value; }

        public void Connecting(string[] logininfo =null)
        {
            if (logininfo!=null)
            {
                BuildConnectionString(logininfo[0],logininfo[1]);
            }
            else {
                
                Connection =
                 System.Configuration.ConfigurationManager.
       ConnectionStrings["ConnectionString"].ConnectionString;
            }
           
        }
        private static void BuildConnectionString(string userName, string userPassword)
        {

            var ConnectionSetting = new ConnectionSettings();
            string connectString = ConnectionSetting.Connection;

            // Create a new SqlConnectionStringBuilder based on the
            // partial connection string retrieved from the config file.
            SqlConnectionStringBuilder builder =
                new SqlConnectionStringBuilder(connectString);

            builder.UserID = userName;
            builder.Password = userPassword;
            ConnectionSetting.Connection = builder.ToString();
        }
    }
}

