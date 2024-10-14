using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_de_Mantenimiento
{
    internal class ConsultaVehiculo
    {
        private ConexionMysql conexionMysql;
        private List<Vehiculo> mvehiculo;

        public ConsultaVehiculo()
        {
            conexionMysql = new ConexionMysql();
            mvehiculo = new List<Vehiculo>();

        }

        public List<Vehiculo> getVehiculo(string filtro)
        {
            string query = "SELECT * FROM vehiculos";
            MySqlDataReader mReader = null;
            List<Vehiculo> mclientes = new List<Vehiculo>();

            try
            {
                if (filtro != "")
                {
                    query += " WHERE " +
                              "id_vehiculo LIKE '%" + filtro + "%' OR " +
                              "id_cliente LIKE '%" + filtro + "%' OR " +
                              "marca LIKE '%" + filtro + "%' OR " +
                              "modelo LIKE '%" + filtro + "%' OR " +
                              "placa LIKE '%" + filtro + "%';";
                }

                using (MySqlCommand mcomando = new MySqlCommand(query, conexionMysql.GetConnection()))
                {
                    mReader = mcomando.ExecuteReader();

                    while (mReader.Read())
                    {
                        Vehiculo mVehiculo = new Vehiculo
                        {
                            id_vehiculo = mReader.GetInt32("id_vehiculo"),
                            id_cliente = mReader.GetInt32("id_cliente"), 
                            marca = mReader.GetString("marca"),
                            modelo = mReader.GetString("modelo"),
                            ano = mReader.GetInt32("ano"), 
                            placa = mReader.GetString("placa")
                        };
                        mvehiculo.Add(mVehiculo);
                    }
                }

                mReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }

            return mvehiculo;
        }

        internal bool agregarVehiculo(Vehiculo mVehiculo)
        {
            string insert = "INSERT INTO vehiculos (id_cliente, marca, modelo, ano, placa) " +
                            "VALUES (@id_cliente, @marca, @modelo, @ano, @placa)";

            try
            {
                using (MySqlCommand mCommand = new MySqlCommand(insert, conexionMysql.GetConnection()))
                {
                    mCommand.Parameters.Add(new MySqlParameter("@id_cliente", mVehiculo.id_cliente));
                    mCommand.Parameters.Add(new MySqlParameter("@marca", mVehiculo.marca));
                    mCommand.Parameters.Add(new MySqlParameter("@modelo", mVehiculo.modelo));
                    mCommand.Parameters.Add(new MySqlParameter("@ano", mVehiculo.ano));
                    mCommand.Parameters.Add(new MySqlParameter("@placa", mVehiculo.placa));

                    return mCommand.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al agregar el vehículo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        internal bool modificarVehiculo(Vehiculo mvehiculo)
        {
            string update = "UPDATE vehiculos SET " +
                            "id_cliente = @id_cliente, " +
                            "marca = @marca, " +
                            "modelo = @modelo, " +
                            "ano = @ano, " +
                            "placa = @placa " +
                            "WHERE id_vehiculo = @id_vehiculo;";

            try
            {
                using (MySqlCommand mCommand = new MySqlCommand(update, conexionMysql.GetConnection()))
                {
                    mCommand.Parameters.AddWithValue("@id_vehiculo", mvehiculo.id_vehiculo);
                    mCommand.Parameters.AddWithValue("@id_cliente", mvehiculo.id_cliente);
                    mCommand.Parameters.AddWithValue("@marca", mvehiculo.marca);
                    mCommand.Parameters.AddWithValue("@modelo", mvehiculo.modelo);
                    mCommand.Parameters.AddWithValue("@ano", mvehiculo.ano);
                    mCommand.Parameters.AddWithValue("@placa", mvehiculo.placa);

                    int rowsAffected = mCommand.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("No se encontró el vehículo para modificar.");
                    }
                    return rowsAffected > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al modificar el vehículo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        internal bool eliminarVehiculo(Vehiculo mvehiculo)
        {
            string DELETE = "DELETE FROM vehiculos WHERE id_vehiculo = @id_vehiculo";

            try
            {
                using (MySqlCommand mCommand = new MySqlCommand(DELETE, conexionMysql.GetConnection()))
                {
                    mCommand.Parameters.AddWithValue("@id_vehiculo", mvehiculo.id_vehiculo);
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

    }
}
