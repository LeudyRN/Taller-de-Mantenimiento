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

        private ConexionMysql conexionMysql;
        private List<Clientes> mclientes;

        public ConsultaCliente()
        {
            conexionMysql = new ConexionMysql();
            mclientes = new List<Clientes>();

        }


        public List<Clientes> getClientes(string filtro)
        {
            string query = "SELECT * FROM clientes";
            MySqlDataReader mReader = null;

            try
            {
                if (filtro != "")
                {
                    query += " WHERE " + 
                        "nombre LIKE '%" + filtro + "%' OR " +
                        "apellido LIKE '%" + filtro + "%' OR " +
                        "numero_tel LIKE '%" + filtro + "%' OR " +
                        "direccion LIKE '%" + filtro + "%' OR " +
                        "cedula LIKE '%" + filtro + "%';";
                }

                MySqlCommand mcomando = new MySqlCommand(query);
                mcomando.Connection = conexionMysql.GetConnection();
                mReader = mcomando.ExecuteReader();


                Clientes mClientes = null;
                while (mReader.Read()) { 
                
                    mClientes = new Clientes();
                    mClientes.nombre = mReader.GetString("nombre");
                    mClientes.apellido = mReader.GetString("apellido");
                    mClientes.numero_tel = mReader.GetString("numero_tel");
                    mClientes.direccion = mReader.GetString("direccion");
                    mClientes.cedula = mReader.GetString("cedula");
                    mclientes.Add(mClientes);
                }

                mReader.Close();
            }
            catch (Exception e) {

                MessageBox.Show("Error: " + e.Message);
            }

            return mclientes;

        }

        internal bool agregarCliente(Clientes mclientes)
        {
          
            string insert = "INSERT INTO clientes (nombre, apellido, numero_tel, direccion, cedula) " +
                            "VALUES (@nombre, @apellido, @numero_tel, @direccion, @cedula);";

            using (MySqlCommand mCommand = new MySqlCommand(insert, conexionMysql.GetConnection()))
            {
            
                mCommand.Parameters.Add(new MySqlParameter("@nombre", mclientes.nombre));
                mCommand.Parameters.Add(new MySqlParameter("@apellido", mclientes.apellido));
                mCommand.Parameters.Add(new MySqlParameter("@numero_tel", mclientes.numero_tel));
                mCommand.Parameters.Add(new MySqlParameter("@direccion", mclientes.direccion));
                mCommand.Parameters.Add(new MySqlParameter("@cedula", mclientes.direccion));


                return mCommand.ExecuteNonQuery() > 0;
            }
        }

    }
}