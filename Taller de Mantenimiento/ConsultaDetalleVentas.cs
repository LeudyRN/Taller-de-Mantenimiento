using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_de_Mantenimiento
{
    internal class ConsultaDetalleVentas
    {
        private ConexionMysql conexionMysql;
        private List<DetalleVentas> mConsultaDetalleVentas;

        public ConsultaDetalleVentas()
        {
            conexionMysql = new ConexionMysql();
            mConsultaDetalleVentas = new List<DetalleVentas>();
        }

        public List<DetalleVentas> getDetalleVentas(string filtro)
        {
            string query = "SELECT * FROM detalles_ventas";
            MySqlDataReader mReader = null;
            List<DetalleVentas> detalleventas = new List<DetalleVentas>();

            try
            {
                if (filtro != "")
                {
                    query += " WHERE " +
                             "id_detalle_venta LIKE '%" + filtro + "%' OR " +
                             "id_venta LIKE '%" + filtro + "%' OR " +
                             "id_servicio LIKE '%" + filtro + "%' OR " +
                             "id_pieza LIKE '%" + filtro + "%';";
                }

                using (MySqlCommand mcomando = new MySqlCommand(query, conexionMysql.GetConnection()))
                {
                    mReader = mcomando.ExecuteReader();

                    while (mReader.Read())
                    {
                        DetalleVentas mDetallesVentas = new DetalleVentas
                        {
                            id_detalle_venta = mReader.GetInt32("id_detalle_venta"),
                            id_venta = mReader.GetInt32("id_venta"),
                            id_pieza = mReader.GetInt32("id_pieza"),
                            id_servicio = mReader.GetInt32("id_servicio"),
                            cantidad = mReader.GetInt32("cantidad"),
                            precio_unitario = mReader.GetDecimal("precio_unitario"),
                            subtotal = mReader.GetDecimal("subtotal"),
                        };
                        detalleventas.Add(mDetallesVentas);
                    }
                }

                mReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }

            return detalleventas;
        }

        internal bool agregarDetalleVentas(DetalleVentas mDetalleVentas)
        {
            string insert = "INSERT INTO detalles_ventas (id_venta, id_pieza, id_servicio, cantidad, precio_unitario, subtotal) " +
                           "VALUES (@id_venta, @id_pieza, @id_servicio, @cantidad, @precio_unitario, @subtotal);";

            try
            {
                using (MySqlCommand mCommand = new MySqlCommand(insert, conexionMysql.GetConnection()))
                {
                    mCommand.Parameters.Add(new MySqlParameter("@id_detalle_venta", mDetalleVentas.id_detalle_venta)); 
                    mCommand.Parameters.Add(new MySqlParameter("@id_venta", mDetalleVentas.id_venta));
                    mCommand.Parameters.Add(new MySqlParameter("@id_pieza", mDetalleVentas.id_pieza));
                    mCommand.Parameters.Add(new MySqlParameter("@id_servicio", mDetalleVentas.id_servicio));
                    mCommand.Parameters.Add(new MySqlParameter("@cantidad", mDetalleVentas.cantidad));
                    mCommand.Parameters.Add(new MySqlParameter("@precio_unitario", mDetalleVentas.precio_unitario));
                    mCommand.Parameters.Add(new MySqlParameter("@subtotal", mDetalleVentas.subtotal));

                    return mCommand.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al agregar el detalle de la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        internal bool modificarDetalleVentas(DetalleVentas mDetalleVentas)
        {
            string update = "UPDATE detalles_ventas SET id_venta = @id_venta, id_pieza = @id_pieza, " +
                            "id_servicio = @id_servicio, cantidad = @cantidad " +
                            "precio_unitario = @precio_unitario, subtotal = @subtotal " +
                            "WHERE id_detalle_venta = @id_detalle_venta;";

            try
            {
                using (MySqlCommand mCommand = new MySqlCommand(update, conexionMysql.GetConnection()))
                {

                    mCommand.Parameters.AddWithValue("@id_venta", mDetalleVentas.id_venta);
                    mCommand.Parameters.AddWithValue("@id_pieza", mDetalleVentas.id_pieza);
                    mCommand.Parameters.AddWithValue("@id_servicio", mDetalleVentas.id_servicio);
                    mCommand.Parameters.AddWithValue("@cantidad", mDetalleVentas.cantidad);
                    mCommand.Parameters.AddWithValue("@precio_unitario", mDetalleVentas.precio_unitario);
                    mCommand.Parameters.AddWithValue("@subtotal", mDetalleVentas.subtotal);

                    int rowsAffected = mCommand.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("No se encontró la venta detallada para modificar.");
                    }
                    return rowsAffected > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al modificar la venta detallada: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        internal bool EliminarVentaDetallada(DetalleVentas mDetalleVentas)
        {
            string DELETE = "DELETE FROM detalles_ventas WHERE id_detalle_venta = @id_detalle_venta";

            try
            {
                using (MySqlCommand mCommand = new MySqlCommand(DELETE, conexionMysql.GetConnection()))
                {
                    mCommand.Parameters.AddWithValue("@id_detalle_venta", mDetalleVentas.id_detalle_venta);
                    return mCommand.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al eliminar la venta detallada: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
