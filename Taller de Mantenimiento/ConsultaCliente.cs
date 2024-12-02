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
            List<Clientes> mclientes = new List<Clientes>(); 

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

                using (MySqlCommand mcomando = new MySqlCommand(query, conexionMysql.GetConnection()))
                {
                    mReader = mcomando.ExecuteReader();

                    while (mReader.Read())
                    {
                        Clientes mClientes = new Clientes
                        {
                            id_cliente = mReader.GetInt32("id_cliente"),
                            nombre = mReader.GetString("nombre"),
                            apellido = mReader.GetString("apellido"),
                            numero_tel = mReader.GetString("numero_tel"),
                            direccion = mReader.GetString("direccion"),
                            cedula = mReader.GetString("cedula")
                        };
                        mclientes.Add(mClientes);
                    }
                }

                mReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }

            return mclientes;
        }

        internal bool agregarCliente(Clientes mclientes)
        {
 
            if (string.IsNullOrWhiteSpace(mclientes.nombre))
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(mclientes.apellido))
            {
                MessageBox.Show("El apellido no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(mclientes.numero_tel))
            {
                MessageBox.Show("El número de teléfono no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(mclientes.direccion))
            {
                MessageBox.Show("La dirección no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(mclientes.cedula))
            {
                MessageBox.Show("La cédula no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string insert = "INSERT INTO clientes (nombre, apellido, numero_tel, direccion, cedula) " +
                            "VALUES (@nombre, @apellido, @numero_tel, @direccion, @cedula);";

            try
            {
                using (MySqlCommand mCommand = new MySqlCommand(insert, conexionMysql.GetConnection()))
                {
                 
                    mCommand.Parameters.Add(new MySqlParameter("@nombre", mclientes.nombre));
                    mCommand.Parameters.Add(new MySqlParameter("@apellido", mclientes.apellido));
                    mCommand.Parameters.Add(new MySqlParameter("@numero_tel", mclientes.numero_tel));
                    mCommand.Parameters.Add(new MySqlParameter("@direccion", mclientes.direccion));
                    mCommand.Parameters.Add(new MySqlParameter("@cedula", mclientes.cedula));

                    
                    return mCommand.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al agregar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        internal bool eliminarClientes(Clientes mclientes)
        {
            string DELETE = "DELETE FROM clientes WHERE id_cliente = @id_cliente";

            try
            {
                using (MySqlCommand mCommand = new MySqlCommand(DELETE, conexionMysql.GetConnection()))
                {
                    mCommand.Parameters.AddWithValue("@id_cliente", mclientes.id_cliente);
                    return mCommand.ExecuteNonQuery() > 0;  
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al eliminar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        internal bool modificarCliente(Clientes mclientes)
        {
            string update = "UPDATE clientes SET " +
                           "nombre = @nombre, " +
                           "apellido = @apellido, " +
                           "numero_tel = @numero_tel, " +
                           "direccion = @direccion, " +
                           "cedula = @cedula " +
                           "WHERE id_cliente = @id_cliente;";

            using (MySqlCommand mCommand = new MySqlCommand(update, conexionMysql.GetConnection()))
            {
                
                mCommand.Parameters.AddWithValue("@id_cliente", mclientes.id_cliente);
                mCommand.Parameters.AddWithValue("@nombre", mclientes.nombre);
                mCommand.Parameters.AddWithValue("@apellido", mclientes.apellido);
                mCommand.Parameters.AddWithValue("@cedula", mclientes.cedula);
                mCommand.Parameters.AddWithValue("@numero_tel", mclientes.numero_tel);
                mCommand.Parameters.AddWithValue("@direccion", mclientes.direccion);

                return mCommand.ExecuteNonQuery() > 0;
            }
        }


    }
}