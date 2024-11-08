using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_de_Mantenimiento
{
    internal class ConsultaDetalle
    {

        private ConexionMysql conexionMysql;
        private List<Detalle> mdetalle;

        public ConsultaDetalle()
        {
            conexionMysql = new ConexionMysql();
            mdetalle = new List<Detalle>();

        }

        public List<Detalle> getDetalle(string filtro)
        {
            string query = @"
        SELECT do.id_detalle, do.id_orden, s.descripcion AS descripcion_servicio, do.subtotal
        FROM detalles_ordenes_de_trabajo do
        JOIN servicios s ON do.id_servicio = s.id_servicio";

            if (!string.IsNullOrEmpty(filtro))
            {
                query += " WHERE do.id_detalle LIKE @filtro OR " +
                         "do.id_orden LIKE @filtro OR " +
                         "s.descripcion LIKE @filtro OR " +
                         "do.subtotal LIKE @filtro";
            }

            List<Detalle> detalle = new List<Detalle>();

            try
            {
                using (MySqlCommand mcomando = new MySqlCommand(query, conexionMysql.GetConnection()))
                {
                    if (!string.IsNullOrEmpty(filtro))
                    {
                        mcomando.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                    }

                    using (MySqlDataReader mReader = mcomando.ExecuteReader())
                    {
                        while (mReader.Read())
                        {
                            Detalle mDetalle = new Detalle
                            {
                                id_detalle = mReader.GetInt32("id_detalle"),
                                id_orden = mReader.GetInt32("id_orden"),
                                descripcion_servicio = mReader.GetString("descripcion_servicio"),
                                subtotal = mReader.GetDecimal("subtotal")
                            };
                            detalle.Add(mDetalle);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }

            return detalle;
        }



        internal bool agregarDetalle(Detalle mDetalle)
        {
            string insert = "INSERT INTO detalles_ordenes_de_trabajo (id_orden, id_servicio, subtotal) " +
                           "VALUES (@id_orden, @id_servicio, @subtotal);";

            try
            {
                using (MySqlCommand mCommand = new MySqlCommand(insert, conexionMysql.GetConnection()))
                {
                    mCommand.Parameters.Add(new MySqlParameter("@id_orden", mDetalle.id_orden));
                    mCommand.Parameters.Add(new MySqlParameter("@id_servicio", mDetalle.id_servicio));
                    mCommand.Parameters.Add(new MySqlParameter("@subtotal", mDetalle.subtotal));

                    return mCommand.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al agregar el detalle: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private int ObtenerIdServicioPorNombre(string descripcion)
        {
            int idServicio = -1; 

            string query = "SELECT id_servicio FROM servicios WHERE descripcion = @descripcion;";
            try
            {
                using (MySqlCommand command = new MySqlCommand(query, conexionMysql.GetConnection()))
                {
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idServicio = reader.GetInt32(0); 
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al obtener el ID del servicio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return idServicio;
        }


        internal bool modificarDetalle(Detalle mdetalle, string descripcion)
        {
            
            int idServicio = ObtenerIdServicioPorNombre(descripcion);
            if (idServicio == -1)
            {
                MessageBox.Show("El nombre del servicio no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }

            string update = "UPDATE detalles_ordenes_de_trabajo SET id_orden = @id_orden, " +
                            "id_servicio = @id_servicio, subtotal = @subtotal " +
                            "WHERE id_detalle = @id_detalle;";

            try
            {
                using (MySqlCommand mCommand = new MySqlCommand(update, conexionMysql.GetConnection()))
                {
                    mCommand.Parameters.AddWithValue("@id_orden", mdetalle.id_orden);
                    mCommand.Parameters.AddWithValue("@id_servicio", idServicio);
                    mCommand.Parameters.AddWithValue("@subtotal", mdetalle.subtotal);
                    mCommand.Parameters.AddWithValue("@id_detalle", mdetalle.id_detalle);

                    int rowsAffected = mCommand.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("No se encontró el detalle de la orden para modificar.");
                    }
                    return rowsAffected > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al modificar el detalle de la orden: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        internal bool eliminarDetalle(Detalle mdetalle)
        {
            string DELETE = "DELETE FROM detalles_ordenes_de_trabajo WHERE id_detalle = @id_detalle";

            try
            {
                using (MySqlCommand mCommand = new MySqlCommand(DELETE, conexionMysql.GetConnection()))
                {
                    mCommand.Parameters.AddWithValue("@id_detalle", mdetalle.id_detalle);
                    return mCommand.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al eliminar el detalle de la orden: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
