using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_de_Mantenimiento
{
    internal class ConsultaHistorial
    {
        private ConexionMysql conexionMysql;
        private List<Historial> mhistorial;

        public ConsultaHistorial()
        {
            conexionMysql = new ConexionMysql();
            mhistorial = new List<Historial>();

        }
        public List<Historial> getHistorial(string filtro)
        {
            string query = "SELECT * FROM historial";
            MySqlDataReader mReader = null;
            List<Historial> mhistorial = new List<Historial>();

            try
            {
                if (filtro != "")
                {
                    query += " WHERE " +
                               "id_historial LIKE '%" + filtro + "%' OR " +
                               "tabla_modificada LIKE '%" + filtro + "%' OR " +
                               "id_registro LIKE '%" + filtro + "%' OR " +
                               "tipo_operacion LIKE '%" + filtro + "%' OR " +
                               "usuario LIKE '%" + filtro + "%';";
                }

                using (MySqlCommand mcomando = new MySqlCommand(query, conexionMysql.GetConnection()))
                {
                    mReader = mcomando.ExecuteReader();

                    while (mReader.Read())
                    {
                        Historial mHistorial = new Historial
                        {
                            id_historial = mReader.GetInt32("id_historial"),
                            tabla_modificada = mReader.GetString("tabla_modificada"),
                            id_registro = mReader.GetInt32("id_registro"),
                            tipo_operacion = mReader.GetString("tipo_operacion"),
                            usuario = mReader.IsDBNull(mReader.GetOrdinal("usuario")) ? string.Empty : mReader.GetString("usuario"),

                            fecha = mReader.IsDBNull(mReader.GetOrdinal("fecha"))
                                ? DateTime.MinValue
                                : mReader.GetDateTime("fecha"),

                            valores_anteriores = mReader.IsDBNull(mReader.GetOrdinal("valores_anteriores"))
                                ? string.Empty
                                : mReader.GetString("valores_anteriores"),

                            valores_nuevos = mReader.IsDBNull(mReader.GetOrdinal("valores_nuevos"))
                                ? string.Empty
                                : mReader.GetString("valores_nuevos")
                        };

                        mhistorial.Add(mHistorial);
                    }
                }

                mReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }

            return mhistorial;
        }


    }
}
