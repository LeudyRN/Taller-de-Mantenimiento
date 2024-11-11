using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_de_Mantenimiento
{
    internal class ConsultaOrden
    {

        private ConexionMysql conexionMysql;
        private List<Orden> morden;

        public ConsultaOrden()
        {
            conexionMysql = new ConexionMysql();
            morden = new List<Orden>();

        }

        public List<Orden> getOrden(string filtro)
        {
            string query = "SELECT * FROM ordenes_de_trabajo";
            MySqlDataReader mReader = null;
            List<Orden> orden = new List<Orden>();

            try
            {
                if (filtro != "")
                {
                    query += " WHERE " +
                             "id_orden LIKE '%" + filtro + "%' OR " +
                             "id_vehiculo LIKE '%" + filtro + "%' OR " +
                             "estado LIKE '%" + filtro + "%' OR " +
                             "total LIKE '%" + filtro + "%';";
                }

                using (MySqlCommand mcomando = new MySqlCommand(query, conexionMysql.GetConnection()))
                {
                    mReader = mcomando.ExecuteReader();

                    while (mReader.Read())
                    {
                        Orden mOrden = new Orden
                        {
                            id_orden = mReader.GetInt32("id_orden"),
                            id_vehiculo = mReader.GetInt32("id_vehiculo"),
      
                            fecha = mReader.IsDBNull(mReader.GetOrdinal("fecha"))
                                    ? DateTime.MinValue
                                    : mReader.GetDateTime("fecha"),

                            estado = mReader.GetString("estado"),
                            total = mReader.GetDecimal("total"),
                        };
                        orden.Add(mOrden);
                    }
                }

                mReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }

            return orden;
        }


        internal bool agregarOrden(Orden mOrden)
        {
            string insert = "INSERT INTO ordenes_de_trabajo (id_vehiculo, fecha, estado, total) " +
                            "VALUES (@id_vehiculo, @fecha, @estado, @total);";

            try
            {
                using (MySqlCommand mCommand = new MySqlCommand(insert, conexionMysql.GetConnection()))
                {
                    mCommand.Parameters.Add(new MySqlParameter("@id_vehiculo", mOrden.id_vehiculo));
                   
                    mCommand.Parameters.Add(new MySqlParameter("@fecha", mOrden.fecha.ToString("yyyy-MM-dd")));
                    mCommand.Parameters.Add(new MySqlParameter("@estado", mOrden.estado));
                    mCommand.Parameters.Add(new MySqlParameter("@total", mOrden.total));

                    return mCommand.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al agregar la orden: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        internal bool modificarOrden(Orden morden)
        {
            string update = "UPDATE ordenes_de_trabajo SET id_vehiculo = @id_vehiculo, fecha = @fecha, estado = @estado, total = @total " +
                            "WHERE id_orden = @id_orden;";

            try
            {
                using (MySqlCommand mCommand = new MySqlCommand(update, conexionMysql.GetConnection()))
                {
                    mCommand.Parameters.AddWithValue("@id_vehiculo", morden.id_vehiculo);
                    mCommand.Parameters.AddWithValue("@fecha", morden.fecha.ToString("yyyy-MM-dd"));
                    mCommand.Parameters.AddWithValue("@estado", morden.estado);
                    mCommand.Parameters.AddWithValue("@total", morden.total);
                    mCommand.Parameters.AddWithValue("@id_orden", morden.id_orden);

                    int rowsAffected = mCommand.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("No se encontró la orden para modificar.");
                    }
                    return rowsAffected > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al modificar la orden: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        internal bool eliminarOrden(Orden morden)
        {
            string DELETE = "DELETE FROM ordenes_de_trabajo WHERE id_orden = @id_orden";

            try
            {
                using (MySqlCommand mCommand = new MySqlCommand(DELETE, conexionMysql.GetConnection()))
                {
                    mCommand.Parameters.AddWithValue("@id_orden", morden.id_orden);
                    return mCommand.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al eliminar la orden: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
