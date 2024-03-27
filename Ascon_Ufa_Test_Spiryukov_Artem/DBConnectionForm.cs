using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ascon_Ufa_Test_Spiryukov_Artem
{
    public partial class DBConnectionForm : Form
    {
        SqlWizard SqlWizard;
        public DBConnectionForm(SqlWizard sqlWizard)
        {
            InitializeComponent();
            SqlWizard = sqlWizard;
            if (SqlWizard.Connected == 1)
            {
                label_ConnectionInfo.Text = "Подключено";
                button_DBConnect.Click += DisConnect;
                textBox_ConnectionString.Enabled = false;
                button_DBConnect.Text = "Отключиться";
            }
            else
            {
                label_ConnectionInfo.Text = "Не подключено";
                button_DBConnect.Click += Connect;
            }
        }

        private async void Connect(object sender, EventArgs e)
        {
            label_ConnectionInfo.Text = "Подключаемся...";
            button_DBConnect.Enabled = false;
            if (await SqlWizard.ConnectToDB(textBox_ConnectionString.Text))
                this.Close();
            else
            {
                label_ConnectionInfo.Text = "Не подключено";
                MessageBox.Show("Ошибка при подключнии");
                button_DBConnect.Enabled = true;
            }

        }

        private async void DisConnect(object sender, EventArgs e)
        {
            label_ConnectionInfo.Text = "Отключаемся...";
            button_DBConnect.Enabled = false;
            SqlWizard.DisconnectFromDB();
            label_ConnectionInfo.Text = "Не подключено";
            button_DBConnect.Text = "Подключиться";
            button_DBConnect.Enabled = true;
            textBox_ConnectionString.Enabled = true;
            button_DBConnect.Click -= DisConnect;
            button_DBConnect.Click += Connect;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
