using HospitalSystem.models.entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HospitalSystem.support
{
    public static class Core
    {
        static string connectionConfig = Environment.CurrentDirectory + @"\config";
        static public string loginOptions = Environment.CurrentDirectory + @"\login";
        private static HospitalSystemEntities context; //контекст
        public static HospitalSystemEntities Context { get => context ?? (context = new HospitalSystemEntities()); }
        public static void LoadConnectionData()
        {
            if (File.Exists(connectionConfig))
            {
                var connectionData = StringСryptography.Decrypt(File.ReadAllText(connectionConfig)).Split(';');
                Server = connectionData[0];
                Database = connectionData[1];
                Login = connectionData[2];
                Password = connectionData[3];
                NewConnectionString();
            }
        }
        public static void NewConnectionString()
        {
            SqlConnectionStringBuilder sqlConnection = new SqlConnectionStringBuilder();
            sqlConnection.DataSource = Server;
            sqlConnection.InitialCatalog = Database;
            sqlConnection.UserID = Login;
            sqlConnection.Password = Password;
            Context.Database.Connection.ConnectionString = sqlConnection.ConnectionString;
            SaveConnectionData();
        }
        public static void SaveConnectionData()
        {
            File.WriteAllText(connectionConfig, StringСryptography.Encrypt($"{Server};{Database};{Login};{Password}"));
        }
        #region Connection
        public static string Server { get => server; set => server = value; }
        public static string Database { get => database; set => database = value; }
        public static string Login { get => login; set => login = value; }
        public static string Password { get => password; set => password = value; }
        //зачем нужны переменные снизу
        static string server;
        static string database;
        static string login;
        static string password;
        #endregion
        public static void RenewConnectionString()
        {
            SqlConnectionStringBuilder sqlConnection = new SqlConnectionStringBuilder();
            sqlConnection.DataSource = Server;
            sqlConnection.InitialCatalog = Database;
            sqlConnection.UserID = Login;
            sqlConnection.Password = Password;
            Context.Database.Connection.ConnectionString = sqlConnection.ConnectionString;
        }
       
    }
}
