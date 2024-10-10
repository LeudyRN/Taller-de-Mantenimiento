using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SqlClient;
using MySqlConnector;


namespace Taller_de_Mantenimiento
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
            private Dictionary<PictureBox, Timer> animationTimers = new Dictionary<PictureBox, Timer>();
            private Dictionary<PictureBox, bool> isMouseOver = new Dictionary<PictureBox, bool>();
            private int zoomFactor =3;  
            private int maxZoomSize = 30;  
            private Dictionary<PictureBox, (int originalWidth, int originalHeight, int originalX, int originalY)> originalSizes;

        public Form1()
        {
            InitializeComponent();


            materialTextBox22.PasswordChar = '*';


            PictureBox[] pictureBoxes = new PictureBox[] { pictureBox1, pictureBox3, pictureBox4 };

            originalSizes = new Dictionary<PictureBox, (int, int, int, int)>();
            foreach (var pictureBox in pictureBoxes)
            {
                originalSizes[pictureBox] = (pictureBox.Width, pictureBox.Height, pictureBox.Location.X, pictureBox.Location.Y);


                pictureBox.MouseEnter += PictureBox_MouseEnter;
                pictureBox.MouseLeave += PictureBox_MouseLeave;

          
                Timer timer = new Timer();
                timer.Interval = 15;
                timer.Tick += (s, e) => AnimationTick(pictureBox);
                animationTimers[pictureBox] = timer;
                isMouseOver[pictureBox] = false;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialCheckbox1.Checked == true)
            {
                materialTextBox22.PasswordChar = '\0';
            }

            else
            {
                materialTextBox22.PasswordChar = '*';
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string correo = materialTextBox21.Text;
            string contraseña = materialTextBox22.Text;

            if (IniciarSesion(correo, contraseña))
            {
               
                Form2 form2= new Form2();
                form2.Show();
                this.Hide();
                

            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos.");
            }

        }


        private bool IniciarSesion(string correo, string contraseña)
        {
            bool inicioExitoso = false;

            // Crea una instancia de ConexionMysql
            ConexionMysql conexionDb = new ConexionMysql();

            using (MySqlConnection conexion = conexionDb.GetConnection())
            {
                try
                {
                    // Asegúrate de que la conexión está abierta
                    if (conexion.State == System.Data.ConnectionState.Closed)
                    {
                        conexion.Open();
                    }

                    // Consulta para contar los usuarios que coinciden con las credenciales
                    string query = "SELECT * FROM usuarios WHERE correo OR nombre_usuario = @correo AND contrasena = @contraseña";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@correo", correo);
                        cmd.Parameters.AddWithValue("@contraseña", contraseña);

                        // Ejecuta la consulta y convierte el resultado a un entero
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        // Establece inicioExitoso a true si hay 1 coincidencia
                        inicioExitoso = count == 1;
                    }
                }
                catch (MySqlException ex) // Manejo específico de errores de MySQL
                {
                    MessageBox.Show("Error de conexión: " + ex.Message);
                }
                catch (InvalidOperationException ex) // Captura errores de estado de conexión
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                catch (Exception ex) // Captura cualquier otro tipo de error
                {
                    MessageBox.Show("Error inesperado: " + ex.Message);
                }
            }

            return inicioExitoso;
        }



        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            isMouseOver[pictureBox] = true;
            animationTimers[pictureBox].Start();
        }

        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            isMouseOver[pictureBox] = false;
            animationTimers[pictureBox].Start();
        }



        private void AnimationTick(PictureBox pictureBox)
        {
            var originalSize = originalSizes[pictureBox];

            if (isMouseOver[pictureBox])
            {
               
                if (pictureBox.Width < originalSize.originalWidth + maxZoomSize)
                {
                    pictureBox.Size = new Size(pictureBox.Width + zoomFactor, pictureBox.Height + zoomFactor);
                    pictureBox.Location = new Point(
                        pictureBox.Location.X - zoomFactor / 2,
                        pictureBox.Location.Y - zoomFactor / 2);
                }
                else
                {
                    animationTimers[pictureBox].Stop();
                }
            }
            else
            {
                
                if (pictureBox.Width > originalSize.originalWidth)
                {
                    pictureBox.Size = new Size(pictureBox.Width - zoomFactor, pictureBox.Height - zoomFactor);
                    pictureBox.Location = new Point(
                        pictureBox.Location.X + zoomFactor / 2,
                        pictureBox.Location.Y + zoomFactor / 2);
                }
                else
                {
                    pictureBox.Size = new Size(originalSize.originalWidth, originalSize.originalHeight);
                    pictureBox.Location = new Point(originalSize.originalX, originalSize.originalY);
                    animationTimers[pictureBox].Stop();
                }
            }
        }





    }
 }

