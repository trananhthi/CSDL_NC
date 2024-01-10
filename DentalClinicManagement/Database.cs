using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data.SqlClient;

namespace DentalClinicManagement
{
    public class DB
    {
        private static DB? _instance = null;
        private SqlConnection _connection = null;

        public string ConnectionString { get; set; } = "Server=tcp:sqldatabase-csdlnc.database.windows.net,1433;Initial Catalog=QL_PK;Persist Security Info=False;User ID=rongcon;Password=Phu110701;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100;";

        
        public void ImportDataToSQL()
        {
        }

        public SqlConnection? Connection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new SqlConnection(ConnectionString);
                    _connection.Open();
                }

                return _connection;
            }
        }

        // Chuỗi kết nối với tùy chọn Windows Authentication

        public static DB Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DB();
                }

                return _instance;
            }
        }
    }
}
