using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_de_Mantenimiento
{
    internal class ConsultaServicio
    {
        private ConexionMysql conexionMysql;
        private List<Servicios> mservicios;

        public ConsultaServicio()
        {
            conexionMysql = new ConexionMysql();
            mservicios = new List<Servicios>();

        }

        public List<Servicios> getServicios(string filtro)
        {
            string query = "SELECT * FROM servicios";
            MySqlDataReader mReader = null;
            List<Servicios> mservicios = new List<Servicios>();

            try
            {
                if (filtro != "")
                {
                    query += " WHERE " +
                              "id_servicio LIKE '%" + filtro + "%' OR " +
                              "descripcion LIKE '%" + filtro + "%' OR " +
                              "precio LIKE '%" + filtro + "%' OR " +
                              "tiempo_en_reparacion LIKE '%" + filtro + "%';";
                }

                using (MySqlCommand mcomando = new MySqlCommand(query, conexionMysql.GetConnection()))
                {
                    mReader = mcomando.ExecuteReader();

                    while (mReader.Read())
                    {
                        Servicios mServicios = new Servicios
                        {
                            id_servicio = mReader.GetInt32("id_servicio"),
                            descripcion = mReader.GetString("descripcion"),
                            precio = mReader.GetInt32("precio"),
                            tiempo_en_reparacion = mReader.GetInt32("tiempo_en_reparacion"),
                         
                        };
                        mservicios.Add(mServicios);
                    }
                }

                mReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }

            return mservicios;
        }

        internal bool agregarServicio(Servicios mServicios)
        {
            string insert = "INSERT INTO servicios (descripcion, precio, tiempo_en_reparacion) " +
                           "VALUES (@descripcion, @precio, @tiempo_en_reparacion);";

            try
            {
                using (MySqlCommand mCommand = new MySqlCommand(insert, conexionMysql.GetConnection()))
                {
                    mCommand.Parameters.Add(new MySqlParameter("@descripcion", mServicios.descripcion));
                    mCommand.Parameters.Add(new MySqlParameter("@precio", mServicios.precio));
                    mCommand.Parameters.Add(new MySqlParameter("@tiempo_en_reparacion", mServicios.tiempo_en_reparacion));

                    return mCommand.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al agregar el servicio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        internal bool modificarServicios(Servicios mservicios)
        {
            string update = "UPDATE servicios SET descripcion = @descripcion, " +
                            "precio = @precio, tiempo_en_reparacion = @tiempo_en_reparacion " +  
                            "WHERE id_servicio = @id_servicio;";


            try
            {
                using (MySqlCommand mCommand = new MySqlCommand(update, conexionMysql.GetConnection()))
                {

                    mCommand.Parameters.AddWithValue("@id_servicio", mservicios.id_servicio);        
                    mCommand.Parameters.AddWithValue("@descripcion", mservicios.descripcion);
                    mCommand.Parameters.AddWithValue("@precio", mservicios.precio);
                    mCommand.Parameters.AddWithValue("@tiempo_en_reparacion", mservicios.tiempo_en_reparacion);


                    int rowsAffected = mCommand.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("No se encontró el servicio para modificar.");
                    }
                    return rowsAffected > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al modificar el servicio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        internal bool eliminarServicio(Servicios mservicios)
        {
            string DELETE = "DELETE FROM servicios WHERE id_servicio = @id_servicio";

            try
            {
                using (MySqlCommand mCommand = new MySqlCommand(DELETE, conexionMysql.GetConnection()))
                {
                    mCommand.Parameters.AddWithValue("@id_servicio", mservicios.id_servicio);
                    return mCommand.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al eliminar el Servicio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
