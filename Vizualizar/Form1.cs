using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Vizualizar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public MySqlCommand commandDatabase;
        public MySqlConnection databaseConnection;
        public MySqlDataReader reader;

        public string server = "localhost";
        public string database = "alumnos";
        public string user = "root";
        public string password = "";
        public string port = "3306";
        public string sslM = "none";

        void conectar()
        {
            string connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);
            databaseConnection = new MySqlConnection(connectionString);

            try
            {
                databaseConnection.Open();
                Console.WriteLine("Conexion exitosa");
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message + connectionString);
            }
        }

      

        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            conectar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
