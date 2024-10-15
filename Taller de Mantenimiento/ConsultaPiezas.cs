using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_de_Mantenimiento
{
    internal class ConsultaPiezas
    {

        private ConexionMysql conexionMysql;
        private List<Piezas> mpiezas;

        public ConsultaPiezas()
        {
            conexionMysql = new ConexionMysql();
            mpiezas = new List<Piezas>();

        }


        public List<Piezas> getPiezas(string filtro)
        {
            string query = "SELECT * FROM piezas";
            MySqlDataReader mReader = null;
            List<Piezas> mpiezas = new List<Piezas>();

            try
            {
                if (filtro != "")
                {
                    query += " WHERE " +
                              "id_pieza LIKE '%" + filtro + "%' OR " +
                              "nombre_pieza LIKE '%" + filtro + "%' OR " +
                              "descripcion_pieza LIKE '%" + filtro + "%' OR " +
                              "precio LIKE '%" + filtro + "%' OR " +
                              "cantidad_disponible LIKE '%" + filtro + "%';";
                }

                using (MySqlCommand mcomando = new MySqlCommand(query, conexionMysql.GetConnection()))
                {
                    mReader = mcomando.ExecuteReader();

                    while (mReader.Read())
                    {
                        Piezas mPiezas = new Piezas
                        {
                            id_pieza = mReader.GetInt32("id_pieza"),
                            nombre_pieza = mReader.GetString("nombre_pieza"),
                            descripcion_pieza = mReader.GetString("descripcion_pieza"),
                            precio = mReader.GetInt32("precio"),
                            cantidad_disponible = mReader.GetInt32("cantidad_disponible"),
                            
                        };
                        mpiezas.Add(mPiezas);
                    }
                }

                mReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }

            return mpiezas;
        }

        internal bool agregarPiezas(Piezas mPiezas)
        {
            string insert = "INSERT INTO piezas (nombre_pieza, descripcion_pieza, precio, cantidad_disponible) " +
                            "VALUES (@nombre_pieza, @descripcion_pieza, @precio, @cantidad_disponible)";

            try
            {
                using (MySqlCommand mCommand = new MySqlCommand(insert, conexionMysql.GetConnection()))
                {
                    mCommand.Parameters.Add(new MySqlParameter("@nombre_pieza", mPiezas.nombre_pieza));
                    mCommand.Parameters.Add(new MySqlParameter("@descripcion_pieza", mPiezas.descripcion_pieza));
                    mCommand.Parameters.Add(new MySqlParameter("@precio", mPiezas.precio));
                    mCommand.Parameters.Add(new MySqlParameter("@cantidad_disponible", mPiezas.cantidad_disponible));
                   

                    return mCommand.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al agregar la piezas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        internal bool modificarPiezas(Piezas mpiezas)
        {
            string update = "UPDATE piezas SET " +
                            "nombre_pieza = @nombre_pieza, " +
                            "descripcion_pieza = @descripcion_pieza, " +
                            "precio = @precio, " +
                            "cantidad_disponible = @cantidad_disponible " + 
                            "WHERE id_pieza = @id_pieza;";

            try
            {
                using (MySqlCommand mCommand = new MySqlCommand(update, conexionMysql.GetConnection()))
                {
                    mCommand.Parameters.AddWithValue("@id_pieza", mpiezas.id_pieza);
                    mCommand.Parameters.AddWithValue("@nombre_pieza", mpiezas.nombre_pieza);
                    mCommand.Parameters.AddWithValue("@descripcion_pieza", mpiezas.descripcion_pieza);
                    mCommand.Parameters.AddWithValue("@precio", mpiezas.precio);
                    mCommand.Parameters.AddWithValue("@cantidad_disponible", mpiezas.cantidad_disponible);


                    int rowsAffected = mCommand.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("No se encontró la piezas para modificar.");
                    }
                    return rowsAffected > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al modificar la piezas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        internal bool eliminarPiezas(Piezas mpeiezas)
        {
            string DELETE = "DELETE FROM piezas WHERE id_pieza = @id_pieza";

            try
            {
                using (MySqlCommand mCommand = new MySqlCommand(DELETE, conexionMysql.GetConnection()))
                {
                    mCommand.Parameters.AddWithValue("@id_pieza", mpeiezas.id_pieza);
                    return mCommand.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al eliminar la pieza: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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