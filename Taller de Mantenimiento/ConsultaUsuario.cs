using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace Taller_de_Mantenimiento
{
    internal class ConsultaUsuario
    {

       

        private ConexionMysql conexionMysql;
        private List<Usuarios> musuarios;

        public ConsultaUsuario()
        {
            conexionMysql = new ConexionMysql();
            musuarios = new List<Usuarios>();

        }
        public List<Usuarios> getUsuarios(string filtro)
        {
            string query = "SELECT * FROM usuarios";
            MySqlDataReader mReader = null;
            List<Usuarios> musuarios = new List<Usuarios>();

            try
            {
                if (filtro != "")
                {
                    query += " WHERE " +
                              "nombre_usuario LIKE '%" + filtro + "%' OR " +
                              "nombre LIKE '%" + filtro + "%' OR " +
                              "apellido LIKE '%" + filtro + "%' OR " +
                              "Correo LIKE '%" + filtro + "%' OR " +
                              "Correo LIKE '%" + filtro + "%';";
                }

                using (MySqlCommand mcomando = new MySqlCommand(query, conexionMysql.GetConnection()))
                {
                    mReader = mcomando.ExecuteReader();

                    while (mReader.Read())
                    {
                        Usuarios mUsuarios = new Usuarios
                        {
                            id_usuario = mReader.GetInt32("id_usuario"),
                            nombre_usuario = mReader.GetString("nombre_usuario"),
                            contrasena = mReader.GetString("contrasena"),
                            nombre = mReader.GetString("nombre"),
                            apellido = mReader.GetString("apellido"),
                            Correo = mReader.GetString("Correo"),
                            numero_tel = mReader.GetString("numero_tel"),
                            rol = mReader.GetString("rol")
                          
                        };
                        musuarios.Add(mUsuarios);
                    }
                }

                mReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }

            return musuarios;
        }

        internal bool agregarUsuarios(Usuarios musuarios)
        {
           
            if (string.IsNullOrWhiteSpace(musuarios.nombre_usuario))
            {
                MessageBox.Show("El nombre de usuario no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(musuarios.contrasena))
            {
                MessageBox.Show("La contrasena no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(musuarios.nombre))
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(musuarios.apellido))
            {
                MessageBox.Show("El apellido no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(musuarios.Correo))
            {
                MessageBox.Show("El correo no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(musuarios.numero_tel))
            {
                MessageBox.Show("El telefono no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(musuarios.rol))
            {
                MessageBox.Show("El  rol no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(musuarios.contrasena);

            string insert = "INSERT INTO usuarios (nombre_usuario, contrasena, nombre, apellido, Correo, numero_tel, rol) " +
                "VALUES (@nombre_usuario, @contrasena, @nombre, @apellido, @Correo, @numero_tel, @rol);";

            try
            {
                using (MySqlCommand mCommand = new MySqlCommand(insert, conexionMysql.GetConnection()))
                {
                    mCommand.Parameters.AddWithValue("@nombre_usuario", musuarios.nombre_usuario);
                    mCommand.Parameters.AddWithValue("@contrasena", hashedPassword); 
                    mCommand.Parameters.AddWithValue("@nombre", musuarios.nombre);
                    mCommand.Parameters.AddWithValue("@apellido", musuarios.apellido);
                    mCommand.Parameters.AddWithValue("@Correo", musuarios.Correo);
                    mCommand.Parameters.AddWithValue("@numero_tel", musuarios.numero_tel);
                    mCommand.Parameters.AddWithValue("@rol", musuarios.rol);

                    return mCommand.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al agregar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        internal bool modificarUsuarios(Usuarios musuarios)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(musuarios.contrasena);

            string update = "UPDATE usuarios SET " +
                            "nombre_usuario = @nombre_usuario, " +
                            "contrasena = @contrasena, " +
                            "nombre = @nombre, " +
                            "apellido = @apellido, " +
                            "Correo = @Correo, " +
                            "numero_tel = @numero_tel, " +
                            "rol = @rol " +
                            "WHERE id_usuario = @id_usuario;";

            using (MySqlCommand mCommand = new MySqlCommand(update, conexionMysql.GetConnection()))
            {
                mCommand.Parameters.AddWithValue("@id_usuario", musuarios.id_usuario);
                mCommand.Parameters.AddWithValue("@nombre_usuario", musuarios.nombre_usuario);
                mCommand.Parameters.AddWithValue("@contrasena", hashedPassword); 
                mCommand.Parameters.AddWithValue("@nombre", musuarios.nombre);
                mCommand.Parameters.AddWithValue("@apellido", musuarios.apellido);
                mCommand.Parameters.AddWithValue("@Correo", musuarios.Correo);
                mCommand.Parameters.AddWithValue("@numero_tel", musuarios.numero_tel);
                mCommand.Parameters.AddWithValue("@rol", musuarios.rol);

                return mCommand.ExecuteNonQuery() > 0;
            }
        }

        internal bool eliminarUsuarios(Usuarios musuarios)
        {
            string DELETE = "DELETE FROM usuarios WHERE id_usuario = @id_usuario";

            try
            {
                using (MySqlCommand mCommand = new MySqlCommand(DELETE, conexionMysql.GetConnection()))
                {
                    mCommand.Parameters.AddWithValue("@id_usuario", musuarios.id_usuario);
                    return mCommand.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al eliminar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
