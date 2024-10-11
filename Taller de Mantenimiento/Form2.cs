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
using System.Diagnostics;


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
            textBox7.ReadOnly = true;


        }

        private void cargarClientes(string filtro = "")
        {
            grid.Items.Clear();  
            grid.Refresh();     
            mClientes.Clear();
         
    
            mClientes = mConsultaCliente.getClientes(filtro);


            for (int i = 0; i < mClientes.Count; i++)
            {

                ListViewItem item = new ListViewItem(mClientes[i].id_cliente.ToString());

                item.SubItems.Add(mClientes[i].nombre);
                item.SubItems.Add(mClientes[i].apellido);
                item.SubItems.Add(mClientes[i].cedula);
                item.SubItems.Add(mClientes[i].numero_tel);
                item.SubItems.Add(mClientes[i].direccion);

                grid.Items.Add(item);
            }


        }

        private void capturarDatosDelFormulario()
        {
      
            mcarga.nombre = textBox3.Text.Trim();
            mcarga.apellido = textBox2.Text.Trim();
            mcarga.cedula = textBox4.Text.Trim();
            mcarga.numero_tel = textBox5.Text.Trim();
            mcarga.direccion = textBox6.Text.Trim();
        }

        private void capturarDatosDelFormularioParaEliminar()
        {
            mcarga.id_cliente = Convert.ToInt32(textBox7.Text.Trim());
            mcarga.nombre = textBox3.Text.Trim();
            mcarga.apellido = textBox2.Text.Trim();
            mcarga.cedula = textBox4.Text.Trim();
            mcarga.numero_tel = textBox5.Text.Trim();
            mcarga.direccion = textBox6.Text.Trim();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            cargarClientes();
           // tabPage1.BackgroundImageLayout = ImageLayout.Stretch;
        }


        private void materialButton1_Click(object sender, EventArgs e)
        {


            if (!datosCorrectos())
            {
                return;
            }

            cargarClientes();
            capturarDatosDelFormulario();

            if (mConsultaCliente.agregarCliente(mcarga))
            {

                MessageBox.Show("Cliente agregado");
                cargarClientes();
                LimpiarCampos();
            }

        }

        private void LimpiarCampos()
        {
            textBox7.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }


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
            if (!datosCorrectos())
            {
                return;
            }

            mcarga.id_cliente = Convert.ToInt32(textBox7.Text.Trim()); 
            mcarga.nombre = textBox3.Text.Trim();
            mcarga.apellido = textBox2.Text.Trim();
            mcarga.cedula = textBox4.Text.Trim();
            mcarga.numero_tel = textBox5.Text.Trim();
            mcarga.direccion = textBox6.Text.Trim();

            if (mConsultaCliente.modificarCliente(mcarga))
            {
                MessageBox.Show("Cliente modificado");
                cargarClientes();
                capturarDatosDelFormulario();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("No se pudo modificar el cliente.");
            }
        }



        private void grid_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (grid.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = grid.SelectedItems[0];

                if (int.TryParse(selectedItem.SubItems[0].Text, out int idCliente))
                {
                    textBox7.Text = idCliente.ToString();
                    textBox3.Text = selectedItem.SubItems[1].Text; 
                    textBox2.Text = selectedItem.SubItems[2].Text; 
                    textBox4.Text = selectedItem.SubItems[3].Text; 
                    textBox5.Text = selectedItem.SubItems[4].Text; 
                    textBox6.Text = selectedItem.SubItems[5].Text; 
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cargarClientes(textBox1.Text.Trim());
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea eliminar el cliente?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                capturarDatosDelFormularioParaEliminar();

                if (mConsultaCliente.eliminarClientes(mcarga))
                {
                    MessageBox.Show("Cliente eliminado");
                    cargarClientes();
                    LimpiarCampos();   
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el cliente");
                }
            }
        }

    }
}

