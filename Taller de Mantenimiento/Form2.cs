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

        private List<Vehiculo> mVehiculo;
        private Vehiculo mcarga1;
        private ConsultaVehiculo mConsultaVehiculo;

        private List<Piezas> mPiezas;
        private Piezas mcarga2;
        private ConsultaPiezas mConsultaPiezas;

        private List<Inventario> mInventario;
        private Inventario mcarga3;
        private ConsultaInventario mConsultaInventario;

        private List<Servicios> mServicio;
        private Servicios mcarga4;
        private ConsultaServicio mConsultaServicio;

        public Form2()
        {

            InitializeComponent();


            mClientes = new List<Clientes>();
            mConsultaCliente = new ConsultaCliente();
            mcarga = new Clientes();
            cargarClientes();
            textBox7.ReadOnly = true;

            mVehiculo = new List<Vehiculo>();
            mConsultaVehiculo = new ConsultaVehiculo();
            mcarga1 = new Vehiculo();
            cargarVehiculo();
            textBox9.ReadOnly = true;

            mPiezas = new List<Piezas>();
            mConsultaPiezas = new ConsultaPiezas();
            mcarga2 = new Piezas();
            cargarPiezas();
            textBox15.ReadOnly = true;

            mInventario = new List<Inventario>();
            mConsultaInventario = new ConsultaInventario();
            mcarga3 = new Inventario();
            cargarInventario();
            textBox22.ReadOnly = true;

            mServicio = new List<Servicios>();
            mConsultaServicio = new ConsultaServicio();
            mcarga4 = new Servicios();
            cargarServicio();
            textBox26.ReadOnly = true;
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

        private void cargarVehiculo(string filtro = "")
        {
            grid1.Items.Clear();
            grid1.Refresh();
            mVehiculo.Clear();


            mVehiculo= mConsultaVehiculo.getVehiculo(filtro);


            for (int i = 0; i < mVehiculo.Count; i++)
            {

                ListViewItem item = new ListViewItem(mVehiculo[i].id_vehiculo.ToString());

                item.SubItems.Add(mVehiculo[i].id_cliente.ToString());
                item.SubItems.Add(mVehiculo[i].marca);
                item.SubItems.Add(mVehiculo[i].modelo);
                item.SubItems.Add(mVehiculo[i].ano.ToString());
                item.SubItems.Add(mVehiculo[i].placa);

                grid1.Items.Add(item);
            }

        }

        private void cargarPiezas(string filtro = "")
        {
            grid2.Items.Clear();
            grid2.Refresh();
            mPiezas.Clear();


            mPiezas = mConsultaPiezas.getPiezas(filtro);


            for (int i = 0; i < mPiezas.Count; i++)
            {

                ListViewItem item = new ListViewItem(mPiezas[i].id_pieza.ToString());

             
                item.SubItems.Add(mPiezas[i].nombre_pieza);
                item.SubItems.Add(mPiezas[i].descripcion_pieza);
                item.SubItems.Add(mPiezas[i].precio.ToString());
                item.SubItems.Add(mPiezas[i].cantidad_disponible.ToString());

                grid2.Items.Add(item);
            }

        }

        private void cargarInventario(string filtro = "")
        {
            grid3.Items.Clear();
            grid3.Refresh();
            mInventario.Clear();


            mInventario = mConsultaInventario.getInventario(filtro);


            for (int i = 0; i < mInventario.Count; i++)
            {

                ListViewItem item = new ListViewItem(mInventario[i].id_inventario.ToString());


                item.SubItems.Add(mInventario[i].id_pieza.ToString());
                item.SubItems.Add(mInventario[i].cantidad.ToString());
                item.SubItems.Add(mInventario[i].ubicacion);

                grid3.Items.Add(item);
            }

        }

        private void cargarServicio(string filtro = "")
        {
            grid4.Items.Clear();
            grid4.Refresh();
            mServicio.Clear();


            mServicio = mConsultaServicio.getServicios(filtro);


            for (int i = 0; i < mServicio.Count; i++)
            {

                ListViewItem item = new ListViewItem(mServicio[i].id_servicio.ToString());

                item.SubItems.Add(mServicio[i].descripcion);
                item.SubItems.Add(mServicio[i].precio.ToString());
                item.SubItems.Add(mServicio[i].tiempo_en_reparacion.ToString());

                grid4.Items.Add(item);
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

        private void capturarDatosDelFormularioVehiculo()
        {

            mcarga1.id_cliente = int.Parse(textBox10.Text.Trim());
            mcarga1.marca = textBox11.Text.Trim();
            mcarga1.modelo = textBox12.Text.Trim();
            mcarga1.ano = int.Parse(textBox13.Text.Trim());
            mcarga1.placa = textBox14.Text.Trim();
        }

        private void capturarDatosDelFormularioPiezas()
        {

            mcarga2.nombre_pieza = textBox16.Text.Trim();
            mcarga2.descripcion_pieza = textBox17.Text.Trim();
            mcarga2.precio = int.Parse(textBox18.Text.Trim());
            mcarga2.cantidad_disponible = int.Parse(textBox20.Text.Trim());
        }

        private void capturarDatosDelFormularioInventario()
        {

            mcarga3.id_pieza = int.Parse(textBox23.Text.Trim());
            mcarga3.cantidad = int.Parse(textBox24.Text.Trim());
            mcarga3.ubicacion = textBox25.Text.Trim();
        
        }

        private void capturarDatosDelFormularioServicio()
        {

            mcarga4.descripcion = textBox28.Text.Trim();
            mcarga4.precio = decimal.Parse(textBox29.Text.Trim());
            mcarga4.tiempo_en_reparacion = int.Parse(textBox30.Text.Trim());

        }
        //------------------------------------
        private void capturarDatosDelFormularioParaEliminar()
        {
            mcarga.id_cliente = Convert.ToInt32(textBox7.Text.Trim());
            mcarga.nombre = textBox3.Text.Trim();
            mcarga.apellido = textBox2.Text.Trim();
            mcarga.cedula = textBox4.Text.Trim();
            mcarga.numero_tel = textBox5.Text.Trim();
            mcarga.direccion = textBox6.Text.Trim();
        }

        private void capturarDatosDelFormularioParaEliminarVehiculo()
        {
            mcarga1.id_vehiculo = Convert.ToInt32(textBox9.Text.Trim());
            mcarga1.id_cliente = Convert.ToInt32(textBox10.Text.Trim());
            mcarga1.marca = textBox11.Text.Trim();
            mcarga1.modelo = textBox12.Text.Trim();
            mcarga1.ano = Convert.ToInt32(textBox13.Text.Trim());
            mcarga1.placa = textBox14.Text.Trim();
          
        }

        private void capturarDatosDelFormularioParaEliminarPiezas()
        {
            mcarga2.id_pieza = Convert.ToInt32(textBox15.Text.Trim());
            mcarga2.nombre_pieza = textBox16.Text.Trim();
            mcarga2.descripcion_pieza = textBox17.Text.Trim();
            mcarga2.precio = Convert.ToInt32(textBox18.Text.Trim());
            mcarga2.cantidad_disponible = Convert.ToInt32(textBox20.Text.Trim());

        }

        private void capturarDatosDelFormularioParaEliminarInventario()
        {
            mcarga3.id_inventario = Convert.ToInt32(textBox22.Text.Trim());
            mcarga3.id_pieza = Convert.ToInt32(textBox23.Text.Trim());
            mcarga3.cantidad = Convert.ToInt32(textBox24.Text.Trim());
            mcarga3.ubicacion = textBox25.Text.Trim();

        }

        private void capturarDatosDelFormularioParaEliminarServicio()
        {
            mcarga4.id_servicio = Convert.ToInt32(textBox26.Text.Trim());
            mcarga4.descripcion = textBox28.Text.Trim();
            mcarga4.precio = Convert.ToDecimal(textBox29.Text.Trim());
            mcarga4.tiempo_en_reparacion = Convert.ToInt32(textBox30.Text.Trim());

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            //cargarClientes();
            //cargarVehiculo();
            //cargarPiezas();
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

        private void LimpiarCampos1()
        {
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";

        }

        private void LimpiarCampos2()
        {
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox20.Text = "";
        }

        private void LimpiarCampos3()
        {
            textBox22.Text = "";
            textBox23.Text = "";
            textBox24.Text = "";
            textBox25.Text = "";
        }

        private void LimpiarCampos4()
        {
            textBox26.Text = "";
            textBox28.Text = "";
            textBox29.Text = "";
            textBox30.Text = "";
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

        private bool datosCorrectosVehiculo()
        {
            if (string.IsNullOrWhiteSpace(textBox10.Text)) 
            {
                MessageBox.Show("Ingrese el ID del cliente");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox11.Text)) 
            {
                MessageBox.Show("Ingrese la marca del vehículo");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox12.Text)) 
            {
                MessageBox.Show("Ingrese el modelo del vehículo");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox13.Text)) 
            {
                MessageBox.Show("Ingrese el año del vehículo");
                return false;
            }

            if (!int.TryParse(textBox13.Text, out _)) 
            {
                MessageBox.Show("El año debe ser un número válido");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox14.Text)) 
            {
                MessageBox.Show("Ingrese la placa del vehículo");
                return false;
            }

            return true;
        }

        private bool datosCorrectosPiezas() { 

            if (string.IsNullOrWhiteSpace(textBox16.Text))
            {
                MessageBox.Show("Ingrese el nombre de la pieza");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox17.Text))
            {
                MessageBox.Show("Ingrese la descripcion de la pieza");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox18.Text))
            {
                MessageBox.Show("Ingrese el precio de la pieza");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox20.Text))
            {
                MessageBox.Show("Ingrese la cantidad de la pieza");
                return false;
            }

            return true;
        }

        private bool datosCorrectosInventario()
        {

            if (string.IsNullOrWhiteSpace(textBox23.Text))
            {
                MessageBox.Show("Ingrese el id de la pieza");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox24.Text))
            {
                MessageBox.Show("Ingrese la cantidad");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox25.Text))
            {
                MessageBox.Show("Ingrese la ubicacion");
                return false;
            }

            return true;
        }

        private bool datosCorrectosServicio()
        {

            if (string.IsNullOrWhiteSpace(textBox28.Text))
            {
                MessageBox.Show("Ingrese la descripcion del servicio");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox29.Text))
            {
                MessageBox.Show("Ingrese el precio del servicio");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox30.Text))
            {
                MessageBox.Show("Ingrese el tiempo de duracion del servicio");
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

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            cargarVehiculo(textBox8.Text.Trim());
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            if (!datosCorrectosVehiculo())
            {
                return;
            }

            cargarVehiculo();
            capturarDatosDelFormularioVehiculo();

            if (mConsultaVehiculo.agregarVehiculo(mcarga1))
            {

                MessageBox.Show("Vehiculo agregado");
                cargarVehiculo();
                LimpiarCampos1();
            }
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            if (!datosCorrectosVehiculo())
            {
                return;
            }

            mcarga1.id_vehiculo = Convert.ToInt32(textBox9.Text.Trim());
            mcarga1.id_cliente = Convert.ToInt32(textBox10.Text.Trim());
            mcarga1.marca = textBox11.Text.Trim();
            mcarga1.modelo = textBox12.Text.Trim();
            mcarga1.ano = Convert.ToInt32(textBox13.Text.Trim());
            mcarga1.placa = textBox14.Text.Trim();


            if (mConsultaVehiculo.modificarVehiculo(mcarga1))
            {
                MessageBox.Show("Vehículo modificado");
                cargarVehiculo();
                capturarDatosDelFormularioVehiculo();
                LimpiarCampos1();
            }
            else
            {
                MessageBox.Show("No se pudo modificar el vehículo.");
            }
        }
    

        private void grid1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (grid1.SelectedItems.Count > 0) 
            {
                ListViewItem selectedItem = grid1.SelectedItems[0];

                if (int.TryParse(selectedItem.SubItems[0].Text, out int idVehiculo)) 
                {
                    textBox9.Text = idVehiculo.ToString();
                    textBox10.Text = selectedItem.SubItems[1].Text; 
                    textBox11.Text = selectedItem.SubItems[2].Text; 
                    textBox12.Text = selectedItem.SubItems[3].Text; 
                    textBox13.Text = selectedItem.SubItems[4].Text; 
                    textBox14.Text = selectedItem.SubItems[5].Text; 
                }
            }

        }

        private void materialButton6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar este vehiculo?", "Eliminar Vehiculo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                capturarDatosDelFormularioParaEliminarVehiculo();

                if (mConsultaVehiculo.eliminarVehiculo(mcarga1))
                {
                    MessageBox.Show("Vehiculo eliminado");
                    cargarVehiculo();
                    LimpiarCampos1();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Vehiculo");
                }
            }
        }

        private void materialButton7_Click(object sender, EventArgs e)
        {
            if (!datosCorrectosPiezas())
            {
                return;
            }

            cargarPiezas();
            capturarDatosDelFormularioPiezas();

            if (mConsultaPiezas.agregarPiezas(mcarga2))
            {

                MessageBox.Show("Pieza agregada");
                cargarPiezas();
                LimpiarCampos2();
            }
        }

        private void grid2_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (grid2.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = grid2.SelectedItems[0];

                if (int.TryParse(selectedItem.SubItems[0].Text, out int idPieza))
                {
                    textBox15.Text = idPieza.ToString();
                    textBox16.Text = selectedItem.SubItems[1].Text;
                    textBox17.Text = selectedItem.SubItems[2].Text;
                    textBox18.Text = selectedItem.SubItems[3].Text;
                    textBox20.Text = selectedItem.SubItems[4].Text;
                    
                }
            }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            cargarPiezas(textBox19.Text.Trim());
        }

        private void materialButton8_Click(object sender, EventArgs e)
        {
            if (!datosCorrectosPiezas())
            {
                return;
            }

            mcarga2.id_pieza = Convert.ToInt32(textBox15.Text.Trim());
            mcarga2.nombre_pieza = textBox16.Text.Trim();
            mcarga2.descripcion_pieza = textBox17.Text.Trim();
            mcarga2.precio = Convert.ToInt32(textBox18.Text.Trim());
            mcarga2.cantidad_disponible = Convert.ToInt32(textBox20.Text.Trim());
            


            if (mConsultaPiezas.modificarPiezas(mcarga2))
            {
                MessageBox.Show("Pieza modificada");
                cargarPiezas();
                capturarDatosDelFormularioPiezas();
                LimpiarCampos2();
            }
            else
            {
                MessageBox.Show("No se pudo modificar la pieza.");
            }
        }

        private void materialButton9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar esta pieza?", "Eliminar pieza", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                capturarDatosDelFormularioParaEliminarPiezas();

                if (mConsultaPiezas.eliminarPiezas(mcarga2))
                {
                    MessageBox.Show("Pieza eliminada");
                    cargarPiezas();
                    LimpiarCampos2();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la pieza");
                }
            }
        }

        private void grid3_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (grid3.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = grid3.SelectedItems[0];

                if (int.TryParse(selectedItem.SubItems[0].Text, out int idInventario))
                {
                    textBox22.Text = idInventario.ToString();
                    textBox23.Text = selectedItem.SubItems[1].Text;
                    textBox24.Text = selectedItem.SubItems[2].Text;
                    textBox25.Text = selectedItem.SubItems[3].Text;

                }
            }
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            cargarInventario(textBox21.Text.Trim());
        }

        private void materialButton10_Click(object sender, EventArgs e)
        {
            if (!datosCorrectosInventario())
            {
                return;
            }

            cargarInventario();
            capturarDatosDelFormularioInventario();

            if (mConsultaInventario.agregarInventario(mcarga3))
            {

                MessageBox.Show("Inventario agregado");
                cargarInventario();
                LimpiarCampos3();
            }
        }

        private void materialButton11_Click(object sender, EventArgs e)
        {
            if (!datosCorrectosInventario())
            {
                return;
            }
            mcarga3.id_inventario = Convert.ToInt32(textBox22.Text.Trim());
            mcarga3.id_pieza = Convert.ToInt32(textBox23.Text.Trim());
            mcarga3.cantidad = Convert.ToInt32(textBox24.Text.Trim());
            mcarga3.ubicacion = textBox25.Text.Trim();
 

            if (mConsultaInventario.modificarInventario(mcarga3))
            {
                MessageBox.Show("Inventario modificado");
                cargarInventario();
                capturarDatosDelFormularioInventario();
                LimpiarCampos3();
            }
            else
            {
                MessageBox.Show("No se pudo modificar el inventario.");
            }
        }

        private void materialButton12_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea eliminar este inventario?", "Eliminar inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                capturarDatosDelFormularioParaEliminarInventario();

                if (mConsultaInventario.eliminarInventario(mcarga3))
                {
                    MessageBox.Show("Inventario eliminado");
                    cargarInventario();
                    LimpiarCampos3();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el inventario");
                }
            }

        }

        private void grid4_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (grid4.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = grid4.SelectedItems[0];

                if (int.TryParse(selectedItem.SubItems[0].Text, out int idServicio))
                {
                    textBox26.Text = idServicio.ToString();
                    textBox28.Text = selectedItem.SubItems[1].Text;
                    textBox29.Text = selectedItem.SubItems[2].Text;
                    textBox30.Text = selectedItem.SubItems[3].Text;

                }
            }
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            cargarServicio(textBox27.Text.Trim());
        }

        private void materialButton13_Click(object sender, EventArgs e)
        {
            if (!datosCorrectosServicio())
            {
                return;
            }

            cargarServicio();
            capturarDatosDelFormularioServicio();

            if (mConsultaServicio.agregarServicio(mcarga4))
            {

                MessageBox.Show("Servicio agregado");
                cargarServicio();
                LimpiarCampos4();
            }
        }

        private void materialButton14_Click(object sender, EventArgs e)
        {
            if (!datosCorrectosServicio())
            {
                return;
            }
            mcarga4.id_servicio = Convert.ToInt32(textBox26.Text.Trim());
            mcarga4.descripcion = textBox28.Text.Trim();
            mcarga4.precio = Convert.ToDecimal(textBox29.Text.Trim());
            mcarga4.tiempo_en_reparacion = Convert.ToInt32(textBox30.Text.Trim());

            if (mConsultaServicio.modificarServicios(mcarga4))
            {
                MessageBox.Show("Servicio modificado");
                cargarServicio();
                capturarDatosDelFormularioServicio();
                LimpiarCampos4();
            }
            else
            {
                MessageBox.Show("No se pudo modificar el servicio.");
            }
        }

        private void materialButton15_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea eliminar este servicio?", "Eliminar servicio", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                capturarDatosDelFormularioParaEliminarServicio();

                if (mConsultaServicio.eliminarServicio(mcarga4))
                {
                    MessageBox.Show("Servicio eliminado");
                    cargarServicio();
                    LimpiarCampos4();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el servicio");
                }
            }

        }

    }
}

