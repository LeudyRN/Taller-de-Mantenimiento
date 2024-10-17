using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_de_Mantenimiento
{
    internal class ConsultaInventario
    {

        private ConexionMysql conexionMysql;
        private List<Inventario> minventario;

        public ConsultaInventario()
        {
            conexionMysql = new ConexionMysql();
            minventario = new List<Inventario>();

        }

        public List<Inventario> getInventario(string filtro)
        {
            string query = "SELECT * FROM inventario";
            MySqlDataReader mReader = null;
            List<Inventario> inventarios = new List<Inventario>();

            try
            {
                if (filtro != "")
                {
                    query += " WHERE " +
                              "id_inventario LIKE '%" + filtro + "%' OR " +
                              "id_pieza LIKE '%" + filtro + "%' OR " +
                              "cantidad LIKE '%" + filtro + "%' OR " +
                              "ubicacion LIKE '%" + filtro + "%';";
                }

                using (MySqlCommand mcomando = new MySqlCommand(query, conexionMysql.GetConnection()))
                {
                    mReader = mcomando.ExecuteReader();

                    while (mReader.Read())
                    {
                        Inventario mInventario = new Inventario
                        {
                            id_inventario = mReader.GetInt32("id_inventario"),
                            id_pieza = mReader.GetInt32("id_pieza"),
                            cantidad = mReader.GetInt32("cantidad"),
                            ubicacion = mReader.GetString("ubicacion"),
                          
                        };
                        minventario.Add(mInventario);
                    }
                }

                mReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }

            return minventario;
        }

        internal bool agregarInventario(Inventario mInventario)
        {
            string insert = "INSERT INTO inventario (id_pieza, cantidad, ubicacion) " +
                           "VALUES (@id_pieza, @cantidad, @ubicacion);";

            try
            {
                using (MySqlCommand mCommand = new MySqlCommand(insert, conexionMysql.GetConnection()))
                {
                    mCommand.Parameters.Add(new MySqlParameter("@id_pieza", mInventario.id_pieza));
                    mCommand.Parameters.Add(new MySqlParameter("@cantidad", mInventario.cantidad));
                    mCommand.Parameters.Add(new MySqlParameter("@ubicacion", mInventario.ubicacion));

                    return mCommand.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al agregar la pieza al inventario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        internal bool modificarInventario(Inventario minventario)
        {
            string update = "UPDATE inventario SET id_pieza = @id_pieza, " +
                            "cantidad = @cantidad, ubicacion = @ubicacion " + 
                            "WHERE id_inventario = @id_inventario;";


            try
            {
                using (MySqlCommand mCommand = new MySqlCommand(update, conexionMysql.GetConnection()))
                {

                    mCommand.Parameters.AddWithValue("@id_inventario", minventario.id_inventario);
                    mCommand.Parameters.AddWithValue("@id_pieza", minventario.id_pieza);
                    mCommand.Parameters.AddWithValue("@cantidad", minventario.cantidad);
                    mCommand.Parameters.AddWithValue("@ubicacion", minventario.ubicacion);


               int rowsAffected = mCommand.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("No se encontró el inventario para modificar.");
                    }
                    return rowsAffected > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al modificar el inventario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        internal bool eliminarInventario(Inventario minventario)
        {
            string DELETE = "DELETE FROM inventario WHERE id_inventario = @id_inventario";

            try
            {
                using (MySqlCommand mCommand = new MySqlCommand(DELETE, conexionMysql.GetConnection()))
                {
                    mCommand.Parameters.AddWithValue("@id_inventario", minventario.id_inventario);
                    return mCommand.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al eliminar el inventario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
