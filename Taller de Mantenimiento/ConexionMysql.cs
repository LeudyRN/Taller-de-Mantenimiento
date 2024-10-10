using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_de_Mantenimiento
{
    internal class ConexionMysql : Conexion
    {

        private MySqlConnection connection;
        private string cadenaConexion;

        public ConexionMysql()
        {
            cadenaConexion = $"Server={server};Database={database};Uid={user};Pwd={password};";
            connection = new MySqlConnection(cadenaConexion);

        }


        public MySqlConnection GetConnection()
        {

            try
            {

                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (Exception e) {

                MessageBox.Show(e.ToString());
            
            
            }

            return connection;
        }
    }
}
