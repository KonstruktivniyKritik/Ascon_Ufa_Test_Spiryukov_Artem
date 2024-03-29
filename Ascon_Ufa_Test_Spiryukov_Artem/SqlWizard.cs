using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascon_Ufa_Test_Spiryukov_Artem
{
    public class SqlWizard
    {
        string ConnectionString;
        SqlConnection Connection;
        SqlDataReader Reader;
        public delegate void SqlNotify();
        public event SqlNotify Connect;
        public event SqlNotify Disconnect;
        public event SqlNotify Fail;
        public event SqlNotify Processing;
        public byte Connected
        {
            get
            {
                if (Connection == null)
                    return 2;
                switch (Connection.State)
                {
                    case System.Data.ConnectionState.Open:
                        return 1;
                        break;
                    case System.Data.ConnectionState.Closed:
                    case System.Data.ConnectionState.Broken:
                        return 2;
                    default:
                        return 3;
                }
            }
        }
        public SqlWizard() 
        {
        }

        public async Task ConnectToDB(string connectionString = "Server=(localdb)\\mssqllocaldb;Database=master;Trusted_Connection=True;")
        {
            try
            {
                ConnectionString = connectionString;
                Connection = new SqlConnection(this.ConnectionString);
                await Connection.OpenAsync();
                Connect.Invoke();
            }
            catch
            {
                Fail.Invoke();
            }
        }

        public void DisconnectFromDB()
        {
            Connection.Close();
            Disconnect.Invoke();
        }

        async public Task<SqlDataReader> ExecuteOrder(string sqlExpression)
        {
            if (Reader != null)
                Reader.Close();
            Processing.Invoke();
            SqlCommand Command = new SqlCommand(sqlExpression, Connection);
            try
            {
                Reader = await Command.ExecuteReaderAsync();
            }
            catch
            {
                MessageBox.Show("Ошибка при обращении к базе данных");
                Reader.Close();
                
            }
            return Reader;
        }
    }
}
