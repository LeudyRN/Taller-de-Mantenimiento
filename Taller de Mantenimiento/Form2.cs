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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Taller_de_Mantenimiento
{




    public partial class Form2 : MaterialSkin.Controls.MaterialForm
    {

        private List<Clientes> mClientes;
        private Clientes mcarga;
        private ConsultaCliente mConsultaCliente;

        public Form2()
        {

            InitializeComponent();



            mClientes = new List<Clientes>();
            mConsultaCliente = new ConsultaCliente();
            mcarga = new Clientes();
            cargarClientes();



        }

        private void cargarClientes(string filtro = "")
        {
            grid.Items.Clear();  
            grid.Refresh();     
            mClientes.Clear();  

    
            mClientes = mConsultaCliente.getClientes(filtro);


            for (int i = 0; i < mClientes.Count; i++)
            {

                ListViewItem item = new ListViewItem(mClientes[i].nombre);

                item.SubItems.Add(mClientes[i].apellido);
                item.SubItems.Add(mClientes[i].numero_tel);
                item.SubItems.Add(mClientes[i].direccion);
                item.SubItems.Add(mClientes[i].cedula);

                grid.Items.Add(item);
            }
        }



        private void Form2_Load(object sender, EventArgs e)
        {

            cargarClientes();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cargarClientes(textBox1.Text.Trim());
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

            if (!datosCorrectos())
            {
                return;
            }

            cargarClientes();

            if (mConsultaCliente.agregarCliente(mcarga))
            {

                MessageBox.Show("Producto agregado");
                cargarClientes();
                LimpiarCampos();
            }

        }

        private void LimpiarCampos()
        {

            textBox3.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }

        /*  private void cargarClientes()
          {
              mcarga.nombre = textBox3.Text.Trim();
              mcarga.apellido = textBox2.Text.Trim();
              mcarga.cedula =  textBox4.Text.Trim();
              mcarga.numero_tel = textBox5.Text.Trim();
              mcarga.direccion = textBox6.Text.Trim();
          }*/

        private bool datosCorrectos()
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Ingrese el nombre");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Ingrese el apellido");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Ingrese la cédula");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Ingrese el teléfono");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Ingrese la dirección");
                return false;
            }


            return true;
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            
        }
    }
}

