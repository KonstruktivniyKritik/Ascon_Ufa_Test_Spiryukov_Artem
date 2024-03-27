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
        string connectionString;
        SqlConnection connection;
        public byte Connected
        {
            get
            {
                if (connection == null)
                    return 2;
                switch (connection.State)
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

        public async Task<bool> ConnectToDB(string ConnectionString = "Server=(localdb)\\mssqllocaldb;Database=master;Trusted_Connection=True;")
        {
            this.connectionString = ConnectionString;
            connection = new SqlConnection(connectionString);
            try
            {
                await connection.OpenAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void DisconnectFromDB()
        {
            connection.Close();
        }
    }
}
