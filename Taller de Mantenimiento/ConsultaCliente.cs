using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_de_Mantenimiento
{
    internal class ConsultaCliente
    {
        private bool IniciarSesion(string correo, string contraseña)
        {

            string connectionString = "server=localhost;database=nueva;uid=root;pwd=RLN12345e";
            bool consultaexitosa = true;


            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();


                    string query = "SELECT * FROM new_table WHERE correo or username = @correo AND contra = @contraseña";



                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@correo", correo);
                        cmd.Parameters.AddWithValue("@contraseña", contraseña);


                        int count = Convert.ToInt32(cmd.ExecuteScalar());


                        consultaexitosa = count == 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return consultaexitosa;
        }
    }
}
