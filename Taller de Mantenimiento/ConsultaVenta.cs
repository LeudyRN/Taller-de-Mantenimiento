using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_de_Mantenimiento
{
    internal class ConsultaVenta
    {
        private ConexionMysql conexionMysql;
        private List<Ventas> mventas;

        public ConsultaVenta()
        {
            conexionMysql = new ConexionMysql();
            mventas = new List<Ventas>();

        }

        public List<Ventas> getVentas(string filtro)
        {
            string query = "SELECT * FROM ventas";
            MySqlDataReader mReader = null;
            List<Ventas> ventas = new List<Ventas>();

            try
            {
                if (filtro != "")
                {
                    query += " WHERE " +
                             "id_venta LIKE '%" + filtro + "%' OR " +
                             "id_cliente LIKE '%" + filtro + "%' OR " +
                             "total LIKE '%" + filtro + "%' OR " +
                             "metodo_pago LIKE '%" + filtro + "%';";
                }

                using (MySqlCommand mcomando = new MySqlCommand(query, conexionMysql.GetConnection()))
                {
                    mReader = mcomando.ExecuteReader();

                    while (mReader.Read())
                    {
                        Ventas mVentas = new Ventas
                        {
                            id_venta = mReader.GetInt32("id_venta"),
                            id_cliente = mReader.GetInt32("id_cliente"),

                            fecha = mReader.IsDBNull(mReader.GetOrdinal("fecha"))
                                    ? DateTime.MinValue
                                    : mReader.GetDateTime("fecha"),

                            total = mReader.GetDecimal("total"),
                            metodo_pago = mReader.GetString("metodo_pago"),
                        };
                        ventas.Add(mVentas);
                    }
                }

                mReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }

            return ventas;
        }

        internal bool agregarVentas(Ventas mVentas)
        {
            string insert = "INSERT INTO ventas (id_cliente, fecha, total, metodo_pago) " +
                            "VALUES (@id_cliente, @fecha, @total, @metodo_pago);";

            try
            {
                using (MySqlCommand mCommand = new MySqlCommand(insert, conexionMysql.GetConnection()))
                {
                    mCommand.Parameters.Add(new MySqlParameter("@id_cliente", mVentas.id_cliente));
                    mCommand.Parameters.Add(new MySqlParameter("@fecha", mVentas.fecha.ToString("yyyy-MM-dd")));
                    mCommand.Parameters.Add(new MySqlParameter("@total", mVentas.total));
                    mCommand.Parameters.Add(new MySqlParameter("@metodo_pago", mVentas.metodo_pago));

                    return mCommand.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al agregar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        internal bool eliminarVentas(Ventas mventas)
        {
            string DELETE = "DELETE FROM ventas WHERE id_venta = @id_venta";

            try
            {
                using (MySqlCommand mCommand = new MySqlCommand(DELETE, conexionMysql.GetConnection()))
                {
                    mCommand.Parameters.AddWithValue("@id_venta", mventas.id_venta);
                    return mCommand.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al eliminar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
