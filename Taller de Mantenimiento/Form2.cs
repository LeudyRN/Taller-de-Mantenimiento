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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace Taller_de_Mantenimiento
{




    public partial class Form2 : MaterialSkin.Controls.MaterialForm
    {
        private ConexionMysql conexionMysql;
        
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

        private List<Orden> mOrden;
        private Orden mcarga5;
        private ConsultaOrden mConsultaOrden;

        private List<Detalle> mDetalle;
        private Detalle mcarga6;
        private ConsultaDetalle mConsultaDetalle;

        private List<Factura> mFactura;
        private Factura mcarga7;
        private ConsultaFactura mConsultaFactura;

        private List<Ventas> mVentas;
        private Ventas mcarga8;
        private ConsultaVenta mConsultaVenta;

        private List<DetalleVentas> mDetalleVentas;
        private DetalleVentas mcarga9;
        private ConsultaDetalleVentas mConsultaDetalleVentas;

        private List<Usuarios> mUsuarios;
        private Usuarios mcarga10;
        private ConsultaUsuario mConsultaUsuario;

        public Form2()
        {

            InitializeComponent();
      
            conexionMysql = new ConexionMysql();

           
            CargarServicios();
            CargarServicios1();

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

            mOrden = new List<Orden>();
            mConsultaOrden = new ConsultaOrden();
            mcarga5 = new Orden();
            cargarOrden();
            textBox32.ReadOnly = true;

            mDetalle = new List<Detalle>();
            mConsultaDetalle = new ConsultaDetalle();
            mcarga6 = new Detalle();
            cargarDetalle();
            textBox37.ReadOnly = true;

            mFactura = new List<Factura>();
            mConsultaFactura = new ConsultaFactura();
            mcarga7 = new Factura();
            cargarFactura();
            textBox40.ReadOnly = true;
            textBox41.ReadOnly = true;

            mVentas = new List<Ventas>();
            mConsultaVenta = new ConsultaVenta();
            mcarga8 = new Ventas();
            cargarVentas();
            textBox46.ReadOnly = true;

            mDetalleVentas = new List<DetalleVentas>();
            mConsultaDetalleVentas = new ConsultaDetalleVentas();
            mcarga9 = new DetalleVentas();
            cargarDetalleVentas();
            textBox48.ReadOnly = true;

            mUsuarios = new List<Usuarios>();
            mConsultaUsuario = new ConsultaUsuario();
            mcarga10 = new Usuarios();
            cargarUsuario();
            textBox55.ReadOnly = true;
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

        private void cargarOrden(string filtro = "")
        {
            grid5.Items.Clear();
            grid5.Refresh();
            mOrden.Clear();


            mOrden = mConsultaOrden.getOrden(filtro);


            for (int i = 0; i < mOrden.Count; i++)
            {

                ListViewItem item = new ListViewItem(mOrden[i].id_orden.ToString());

                item.SubItems.Add(mOrden[i].id_vehiculo.ToString());
                item.SubItems.Add(mOrden[i].fecha.ToString("yyyy-MM-dd"));
                item.SubItems.Add(mOrden[i].estado.ToString());
                item.SubItems.Add(mOrden[i].total.ToString());

                grid5.Items.Add(item);
            }

        }

        private void cargarDetalle(string filtro = "")
        {
            grid6.Items.Clear();
            grid6.Refresh();
            mDetalle.Clear();


            mDetalle = mConsultaDetalle.getDetalle(filtro);


            for (int i = 0; i < mDetalle.Count; i++)
            {

                ListViewItem item = new ListViewItem(mDetalle[i].id_detalle.ToString());

             /*   item.SubItems.Add(mDetalle[i].id_orden.ToString());
                item.SubItems.Add(mDetalle[i].id_servicio.ToString());
                item.SubItems.Add(mDetalle[i].subtotal.ToString());*/

                item.SubItems.Add(mDetalle[i].id_orden.ToString());
                item.SubItems.Add(mDetalle[i].descripcion_servicio); 
                item.SubItems.Add(mDetalle[i].subtotal.ToString());

                grid6.Items.Add(item);
            }

        }

        private void cargarFactura(string filtro = "")
        {
            grid7.Items.Clear();
            grid7.Refresh();
            mFactura.Clear();


            mFactura = mConsultaFactura.getFactura(filtro);


            for (int i = 0; i < mFactura.Count; i++)
            {

                ListViewItem item = new ListViewItem(mFactura[i].id_factura.ToString());

                item.SubItems.Add(mFactura[i].id_orden.ToString());
                item.SubItems.Add(mFactura[i].fecha.ToString("yyyy-MM-dd"));
                item.SubItems.Add(mFactura[i].total.ToString());

                grid7.Items.Add(item);
            }

        }

        private void cargarVentas(string filtro = "")
        {
            grid8.Items.Clear();
            grid8.Refresh();
            mVentas.Clear();


            mVentas = mConsultaVenta.getVentas(filtro);


            for (int i = 0; i < mVentas.Count; i++)
            {

                ListViewItem item = new ListViewItem(mVentas[i].id_venta.ToString());

                item.SubItems.Add(mVentas[i].id_cliente.ToString());
                item.SubItems.Add(mVentas[i].fecha.ToString("yyyy-MM-dd"));
                item.SubItems.Add(mVentas[i].total.ToString());
                item.SubItems.Add(mVentas[i].metodo_pago.ToString());

                grid8.Items.Add(item);
            }

        }

        private void cargarDetalleVentas(string filtro = "")
        {
            grid9.Items.Clear();
            grid9.Refresh();
            mDetalleVentas.Clear();


            mDetalleVentas = mConsultaDetalleVentas.getDetalleVentas(filtro);


            for (int i = 0; i < mDetalleVentas.Count; i++)
            {

                ListViewItem item = new ListViewItem(mDetalleVentas[i].id_detalle_venta.ToString());

                item.SubItems.Add(mDetalleVentas[i].id_venta.ToString());
                item.SubItems.Add(mDetalleVentas[i].id_pieza.ToString());
                item.SubItems.Add(mDetalle[i].descripcion_servicio);
                item.SubItems.Add(mDetalleVentas[i].cantidad.ToString());
                item.SubItems.Add(mDetalleVentas[i].precio_unitario.ToString());
                item.SubItems.Add(mDetalleVentas[i].subtotal.ToString());

                grid9.Items.Add(item);
            }

        }

        private void cargarUsuario(string filtro = "")
        {
            grid10.Items.Clear(); // Limpia el ListView
            grid10.Refresh(); // (Opcional, puede eliminarse)
            mUsuarios.Clear(); // Limpia la lista local

            // Obtén los usuarios filtrados
            mUsuarios = mConsultaUsuario.getUsuarios(filtro);

            // Valida si la lista está vacía o nula
            if (mUsuarios == null || mUsuarios.Count == 0)
            {
                MessageBox.Show("No se encontraron usuarios con el filtro especificado.",
                                "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Salir del método si no hay datos
            }

            // Iterar sobre la lista de usuarios
            for (int i = 0; i < mUsuarios.Count; i++)
            {
                ListViewItem item = new ListViewItem(mUsuarios[i].id_usuario.ToString());

                item.SubItems.Add(mUsuarios[i].nombre_usuario ?? ""); // Manejo de valores nulos
                item.SubItems.Add(mUsuarios[i].contrasena ?? "");
                item.SubItems.Add(mUsuarios[i].nombre ?? "");
                item.SubItems.Add(mUsuarios[i].apellido ?? "");
                item.SubItems.Add(mUsuarios[i].Correo ?? "");
                item.SubItems.Add(mUsuarios[i].numero_tel ?? "");
                item.SubItems.Add(mUsuarios[i].rol ?? "");

                grid10.Items.Add(item); // Agrega el item al ListView
            }
        }


        //------------------------------------
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

        private void capturarDatosDelFormularioOrden()
        {
            try
            {
                mcarga5.id_vehiculo = int.Parse(textBox33.Text.Trim());

                mcarga5.fecha = dateTimePicker1.Value;

                mcarga5.estado = materialComboBox1.Text.Trim();

                
                mcarga5.total = decimal.Parse(textBox34.Text.Trim());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error de formato en los datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al capturar datos: " + ex.Message);
            }
        }

        private void capturarDatosDelFormularioDetalle()
        {
            mcarga6.id_orden = int.Parse(textBox36.Text.Trim());

            if (comboBoxServicios.SelectedItem is KeyValuePair<int, string> selectedService)
            {
                mcarga6.id_servicio = selectedService.Key; 
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un servicio.");
                return;
            }

            mcarga6.subtotal = decimal.Parse(textBox38.Text.Trim());
        }

        private void capturarDatosDelFormularioFactura()
        {
            mcarga7.id_orden = int.Parse(textBox42.Text.Trim());
            mcarga7.fecha = dateTimePicker2.Value;
            
        }

        private void capturarDatosDelFormularioVentas()
        {
            try
            {
                mcarga8.id_cliente = int.Parse(textBox44.Text.Trim());

                mcarga8.fecha = dateTimePicker3.Value;

                mcarga8.total = decimal.Parse(textBox45.Text.Trim());

                mcarga8.metodo_pago = materialComboBox2.Text.Trim();

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error de formato en los datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al capturar datos: " + ex.Message);
            }
        }

        private void capturarDatosDelFormularioDetallesVentas()
        {
            try
            {
                mcarga9.id_venta = int.Parse(textBox49.Text.Trim());

                mcarga9.id_pieza = int.Parse(textBox50.Text.Trim());

                if (materialComboBox3.SelectedItem is KeyValuePair<int, string> selectedService)
                {
                    mcarga9.id_servicio = selectedService.Key;
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un servicio.");
                    return;
                }

                mcarga9.cantidad = int.Parse(textBox52.Text.Trim());

                mcarga9.precio_unitario = decimal.Parse(textBox53.Text.Trim());

                mcarga9.subtotal = decimal.Parse(textBox54.Text.Trim());

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error de formato en los datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al capturar datos: " + ex.Message);
            }
        }

        private void capturarDatosDelFormularioUsuario()
        {
            mcarga10.nombre_usuario = textBox56.Text.Trim();
            mcarga10.contrasena = textBox57.Text.Trim();
            mcarga10.nombre = textBox58.Text.Trim();
            mcarga10.apellido = textBox59.Text.Trim();
            mcarga10.Correo = textBox60.Text.Trim();
            mcarga10.numero_tel = textBox61.Text.Trim();
            mcarga10.rol = materialComboBox4.Text.Trim();
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

        private void capturarDatosDelFormularioParaEliminarOrden()
        {
            mcarga5.id_orden = int.Parse(textBox32.Text.Trim());
            mcarga5.id_vehiculo = int.Parse(textBox33.Text.Trim());
            mcarga5.fecha = DateTime.Parse(dateTimePicker1.Text.Trim());
            mcarga5.estado = materialComboBox1.Text.Trim();
            mcarga5.total = decimal.Parse(textBox34.Text.Trim());

        }

        private void capturarDatosDelFormularioParaEliminarDetalle()
        {
            mcarga6.id_detalle = int.Parse(textBox37.Text.Trim());
            mcarga6.id_orden = int.Parse(textBox36.Text.Trim());

            if (comboBoxServicios.SelectedItem is KeyValuePair<int, string> selectedService)
            {
                mcarga6.id_servicio = selectedService.Key;
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un servicio.");
                return;
            }

            mcarga6.subtotal = decimal.Parse(textBox38.Text.Trim());

        }

        private void capturarDatosDelFormularioParaEliminarFactura()
        {
            mcarga7.id_factura = int.Parse(textBox40.Text.Trim());
            mcarga7.id_orden = int.Parse(textBox42.Text.Trim());
            mcarga7.fecha = dateTimePicker2.Value;
            mcarga7.total = decimal.Parse(textBox41.Text.Trim());
        }

        private void capturarDatosDelFormularioParaEliminarVentas()
        {
            try
            {
                mcarga8.id_venta = int.Parse(textBox46.Text.Trim());

                mcarga8.id_cliente = int.Parse(textBox44.Text.Trim());

                mcarga8.fecha = dateTimePicker3.Value;

                mcarga8.total = decimal.Parse(textBox45.Text.Trim());

                mcarga8.metodo_pago = materialComboBox2.Text.Trim();

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error de formato en los datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al capturar datos: " + ex.Message);
            }
        }

        private void capturarDatosDelFormularioDetallesVentasParaEliminar()
        {
            try
            {
                mcarga9.id_detalle_venta = int.Parse(textBox48.Text.Trim());

                mcarga9.id_venta = int.Parse(textBox49.Text.Trim());

                mcarga9.id_pieza = int.Parse(textBox50.Text.Trim());

                if (materialComboBox3.SelectedItem is KeyValuePair<int, string> selectedService)
                {
                    mcarga9.id_servicio = selectedService.Key;
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un servicio.");
                    return;
                }

                mcarga9.cantidad = int.Parse(textBox52.Text.Trim());

                mcarga9.precio_unitario = decimal.Parse(textBox53.Text.Trim());

                mcarga9.subtotal = decimal.Parse(textBox54.Text.Trim());

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error de formato en los datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al capturar datos: " + ex.Message);
            }
        }

        private void capturarDatosDelFormularioParaEliminarUsuario()
        {
            mcarga10.id_usuario = int.Parse(textBox55.Text.Trim());
            mcarga10.nombre_usuario = textBox56.Text.Trim();
            mcarga10.contrasena = textBox57.Text.Trim();
            mcarga10.nombre = textBox58.Text.Trim();
            mcarga10.apellido = textBox59.Text.Trim();
            mcarga10.Correo = textBox60.Text.Trim();
            mcarga10.numero_tel = textBox61.Text.Trim();
            mcarga10.rol = materialComboBox4.Text.Trim();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            //cargarClientes();
            //cargarVehiculo();
            //cargarPiezas();
            // tabPage1.BackgroundImageLayout = ImageLayout.Stretch;

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

        private void LimpiarCampos5()
        {
            textBox32.Text = "";
            textBox33.Text = "";
            materialComboBox1.Text = "";
            textBox34.Text = "";
            dateTimePicker1.Text = "";
        }

        private void LimpiarCampos6()
        {
            textBox37.Text = "";
            textBox36.Text = "";
            textBox38.Text = "";
            comboBoxServicios.Text = "";
        }
        private void LimpiarCampos7()
        {
            textBox42.Text = "";
            textBox40.Text = "";
            textBox41.Text = "";
            dateTimePicker2.Text = "";
        }

        private void LimpiarCampos8()
        {
            textBox46.Text = "";
            textBox44.Text = "";
            textBox45.Text = "";
            dateTimePicker3.Text = "";
            materialComboBox2.Text = "";
        }

        private void LimpiarCampos9()
        {

            textBox48.Text = "";
            textBox49.Text = "";
            textBox50.Text = "";
            materialComboBox3.Text = "";
            textBox52.Text = "";
            textBox53.Text = "";
            textBox54.Text = "";
        }
        private void LimpiarCampos10()
        {
            textBox55.Text = "";
            textBox56.Text = "";
            textBox57.Text = "";
            textBox58.Text = "";
            textBox59.Text = "";
            textBox60.Text = "";
            textBox61.Text = "";
            materialComboBox4.Text = "";
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

        private bool datosCorrectosOrden()
        {

            if (string.IsNullOrWhiteSpace(textBox33.Text))
            {
                MessageBox.Show("Ingrese el id del vehiculo");
                return false;
            }

            if (string.IsNullOrWhiteSpace(dateTimePicker1.Text))
            {
                MessageBox.Show("Ingrese la fecha");
                return false;
            }

            if (string.IsNullOrWhiteSpace(materialComboBox1.Text))
            {
                MessageBox.Show("Ingrese el estado");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox34.Text))
            {
                MessageBox.Show("Ingrese el total");
                return false;
            }

            return true;
        }

        private bool datosCorrectosDetalle()
        {

            if (string.IsNullOrWhiteSpace(textBox36.Text))
            {
                MessageBox.Show("Ingrese el id de la orden");
                return false;
            }

            if (string.IsNullOrWhiteSpace(comboBoxServicios.Text))
            {
                MessageBox.Show("Ingrese el Servicio");
                return false;
            }

            return true;
        }

        private bool datosCorrectosFacturas()
        {

            if (string.IsNullOrWhiteSpace(textBox42.Text))
            {
                MessageBox.Show("Ingrese el id de la Orden");
                return false;
            }

            if (string.IsNullOrWhiteSpace(dateTimePicker2.Text))
            {
                MessageBox.Show("Ingrese la fecha");
                return false;
            }

            return true;
        }

        private bool datosCorrectoVentas()
        {

            if (string.IsNullOrWhiteSpace(textBox44.Text))
            {
                MessageBox.Show("Ingrese el id del Cliente");
                return false;
            }

            if (string.IsNullOrWhiteSpace(dateTimePicker3.Text))
            {
                MessageBox.Show("Ingrese la fecha");
                return false;
            }

            if (string.IsNullOrWhiteSpace(materialComboBox2.Text))
            {
                MessageBox.Show("Ingrese el metodo de pago");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox45.Text))
            {
                MessageBox.Show("Ingrese el total");
                return false;
            }

            return true;
        }

        private bool datosCorrectoDetalleVentas()
        {

            if (string.IsNullOrWhiteSpace(textBox49.Text))
            {
                MessageBox.Show("Ingrese el id del Cliente");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox50.Text))
            {
                MessageBox.Show("Ingrese el id de la pieza");
                return false;
            }

            if (string.IsNullOrWhiteSpace(materialComboBox3.Text))
            {
                MessageBox.Show("Ingrese el servicio");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox52.Text))
            {
                MessageBox.Show("Ingrese la cantidad");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox53.Text))
            {
                MessageBox.Show("Ingrese el precio unitario");
                return false;
            }


            if (string.IsNullOrWhiteSpace(textBox54.Text))
            {
                MessageBox.Show("Ingrese el total");
                return false;
            }


            return true;
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

        private void grid5_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            if (grid5.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = grid5.SelectedItems[0];

                if (int.TryParse(selectedItem.SubItems[0].Text, out int id_orden))
                {
                    textBox32.Text = id_orden.ToString();
                    textBox33.Text = selectedItem.SubItems[1].Text;
                    string fechaTexto = selectedItem.SubItems[2].Text;

                
                    if (!string.IsNullOrEmpty(fechaTexto) && DateTime.TryParse(fechaTexto, out DateTime fecha))
                    {
                   
                        if (fecha >= dateTimePicker1.MinDate && fecha <= dateTimePicker1.MaxDate)
                        {
                            dateTimePicker1.Value = fecha;
                        }
                        else
                        {
                            MessageBox.Show("La fecha está fuera del rango permitido.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La fecha no es válida o está vacía.");
                    }

                    materialComboBox1.Text = selectedItem.SubItems[3].Text;
                    textBox34.Text = selectedItem.SubItems[4].Text;
                }
            }
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            cargarOrden(textBox31.Text.Trim());
        }

        private void materialButton16_Click(object sender, EventArgs e)
        {
            if (!datosCorrectosOrden())
            {
                return;
            }

            cargarOrden();
            capturarDatosDelFormularioOrden();

            if (mConsultaOrden.agregarOrden(mcarga5))
            {

                MessageBox.Show("Orden agregada");
                cargarOrden();
                LimpiarCampos5();
            }
        }

        private void materialButton17_Click(object sender, EventArgs e)
        {
            if (!datosCorrectosOrden())
            {
                return;
            }

            mcarga5.id_orden = Convert.ToInt32(textBox32.Text.Trim()); 
            mcarga5.id_vehiculo = Convert.ToInt32(textBox33.Text.Trim());
            mcarga5.fecha = dateTimePicker1.Value; 
            mcarga5.estado = materialComboBox1.Text.Trim(); 
            mcarga5.total = Convert.ToDecimal(textBox34.Text.Trim()); 

            if (mConsultaOrden.modificarOrden(mcarga5))
            {
                MessageBox.Show("Orden modificada correctamente.");
                cargarOrden(); 
                capturarDatosDelFormularioOrden(); 
                LimpiarCampos5();
            }
            else
            {
                MessageBox.Show("No se pudo modificar la orden.");
            }
        }

        private void materialButton18_Click(object sender, EventArgs e)
        {
            capturarDatosDelFormularioParaEliminarOrden();

            if (mConsultaOrden.eliminarOrden(mcarga5))
            {
                MessageBox.Show("Orden eliminada");
                cargarOrden();
                LimpiarCampos5();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar La Orden");
            }
        }


        private void CargarServicios()
        {
            string query = "SELECT id_servicio, descripcion FROM servicios";
            using (MySqlCommand cmd = new MySqlCommand(query, conexionMysql.GetConnection()))
            {
                try
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    comboBoxServicios.Items.Clear();

                    while (reader.Read())
                    {
                        int idServicio = reader.GetInt32("id_servicio");
                        string descripcion = reader.GetString("descripcion");

                        comboBoxServicios.Items.Add(new KeyValuePair<int, string>(idServicio, descripcion));
                    }

                    reader.Close();
                    comboBoxServicios.DisplayMember = "Value";
                    comboBoxServicios.ValueMember = "Key";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar servicios: " + ex.Message);
                }
            }
        }

        private void comboBoxServicios_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxServicios.SelectedItem is KeyValuePair<int, string> selectedService)
            {
                int idServicio = selectedService.Key;
                int idOrden;

                if (!int.TryParse(textBox36.Text, out idOrden))  
                {
                 
                    return;
                }
                string query = @"
                                SELECT 
                                    s.precio, 
                                    SUM(do.subtotal) AS totalOrden
                                FROM 
                                    servicios s
                                LEFT JOIN 
                                    detalles_ordenes_de_trabajo do ON s.id_servicio = do.id_servicio
                                WHERE 
                                    s.id_servicio = @id_servicio AND do.id_orden = @id_orden
                                GROUP BY 
                                    s.precio, do.id_orden";

                using (MySqlCommand cmd = new MySqlCommand(query, conexionMysql.GetConnection()))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@id_servicio", idServicio);
                        cmd.Parameters.AddWithValue("@id_orden", idOrden);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                   
                                decimal precioServicio = reader.IsDBNull(reader.GetOrdinal("precio")) ? 0.00m : reader.GetDecimal("precio");
                                decimal totalOrden = reader.IsDBNull(reader.GetOrdinal("totalOrden")) ? 0.00m : reader.GetDecimal("totalOrden");

                         
                                textBox38.Text = precioServicio.ToString("0.00");

                            }
                            else
                            {
                                textBox38.Text = "0.00"; 
                                                         
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al obtener los datos: " + ex.Message);
                    }
                }
            }
        }

    /*    private void comboBoxServicios_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxServicios.SelectedItem is KeyValuePair<int, string> selectedService)
            {
                int idServicio = selectedService.Key;

                string query = "SELECT precio FROM servicios WHERE id_servicio = @id_servicio";
                using (MySqlCommand cmd = new MySqlCommand(query, conexionMysql.GetConnection()))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@id_servicio", idServicio);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            decimal precio = Convert.ToDecimal(result);
                            textBox38.Text = precio.ToString("0.00");
                        }
                        else
                        {
                            textBox38.Text = "0.00";  
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al obtener precio: " + ex.Message);
                    }
                }
            }
        }
        */

        private void grid6_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
          
            if (grid6.SelectedItems.Count > 0)
            {
            
                ListViewItem selectedItem = grid6.SelectedItems[0];

             
                if (int.TryParse(selectedItem.SubItems[0].Text, out int id_detalle))
                {
                    textBox37.Text = id_detalle.ToString();
                    textBox36.Text = selectedItem.SubItems[1].Text;
                    comboBoxServicios.Text = selectedItem.SubItems[2].Text;           
                    textBox38.Text = selectedItem.SubItems[3].Text;
                }
            }
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            cargarDetalle(textBox35.Text.Trim());
        }

        private void materialButton19_Click(object sender, EventArgs e)
        {
            if (!datosCorrectosDetalle())
            {
                return;
            }

            cargarDetalle();
            capturarDatosDelFormularioDetalle();

            if (mConsultaDetalle.agregarDetalle(mcarga6))
            {

                MessageBox.Show("Detalle agregado");
                cargarDetalle();
                LimpiarCampos6();
            }
        }

        private void materialButton20_Click(object sender, EventArgs e)
        {
            if (!datosCorrectosDetalle())
            {
                return; 
            }

            mcarga6.id_detalle = Convert.ToInt32(textBox37.Text.Trim());
            mcarga6.id_orden = Convert.ToInt32(textBox36.Text.Trim());
            mcarga6.subtotal = Convert.ToDecimal(textBox38.Text.Trim());

            string nombreServicio = comboBoxServicios.Text.Trim();

            if (mConsultaDetalle.modificarDetalle(mcarga6, nombreServicio))
            {
                MessageBox.Show("Detalle modificado correctamente.");
                cargarDetalle();
                capturarDatosDelFormularioDetalle();
                LimpiarCampos6();
            }
            else
            {
                MessageBox.Show("No se pudo modificar la orden.");
            }
        }

        private void materialButton21_Click(object sender, EventArgs e)
        {
            capturarDatosDelFormularioParaEliminarDetalle();

            if (mConsultaDetalle.eliminarDetalle(mcarga6))
            {
                MessageBox.Show("Detalle eliminado");
                cargarDetalle();
                LimpiarCampos6();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el detalle");
            }
        }

        private void grid7_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (grid7.SelectedItems.Count > 0)
            {

                ListViewItem selectedItem = grid7.SelectedItems[0];


                if (int.TryParse(selectedItem.SubItems[0].Text, out int id_factura))
                {
                    textBox40.Text = id_factura.ToString();
                    textBox42.Text = selectedItem.SubItems[1].Text;
                    string fechaTexto = selectedItem.SubItems[2].Text;


                    if (!string.IsNullOrEmpty(fechaTexto) && DateTime.TryParse(fechaTexto, out DateTime fecha))
                    {

                        if (fecha >= dateTimePicker2.MinDate && fecha <= dateTimePicker2.MaxDate)
                        {
                            dateTimePicker2.Value = fecha;
                        }
                        else
                        {
                            MessageBox.Show("La fecha está fuera del rango permitido.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La fecha no es válida o está vacía.");
                    }

                    textBox41.Text = selectedItem.SubItems[3].Text;
                }
            }
        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {
            cargarFactura(textBox39.Text.Trim());
        }

        private void materialButton22_Click(object sender, EventArgs e)
        {
            if (!datosCorrectosFacturas())
            {
                return;
            }

            cargarFactura();
            capturarDatosDelFormularioFactura();

            if (mConsultaFactura.GenerarFacturaPDF(mcarga7.id_orden))
            {

                MessageBox.Show("Factura generada");
                cargarFactura();
                LimpiarCampos7();
            }
        }

        private void materialButton23_Click(object sender, EventArgs e)
        {
            if (!datosCorrectosFacturas())
            {
                return;
            }

            cargarFactura();
            capturarDatosDelFormularioFactura();

            if (mConsultaFactura.GenerarFacturaEXCEL(mcarga7.id_orden))
            {

                MessageBox.Show("Factura generada");
                cargarFactura();
                LimpiarCampos7();
            }
        }

        private void materialButton24_Click(object sender, EventArgs e)
        {
            capturarDatosDelFormularioParaEliminarFactura();

            if (mConsultaFactura.eliminarFactura(mcarga7))
            {
                MessageBox.Show("Factura eliminada");
                cargarFactura();
                LimpiarCampos7();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar la factura");
            }
        }

        private void grid8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (grid8.SelectedItems.Count > 0)
            {

                ListViewItem selectedItem = grid8.SelectedItems[0];


                if (int.TryParse(selectedItem.SubItems[0].Text, out int id_venta))
                {
                    textBox46.Text = id_venta.ToString();
                    textBox44.Text = selectedItem.SubItems[1].Text;
                    string fechaTexto = selectedItem.SubItems[2].Text;


                    if (!string.IsNullOrEmpty(fechaTexto) && DateTime.TryParse(fechaTexto, out DateTime fecha))
                    {

                        if (fecha >= dateTimePicker3.MinDate && fecha <= dateTimePicker3.MaxDate)
                        {
                            dateTimePicker3.Value = fecha;
                        }
                        else
                        {
                            MessageBox.Show("La fecha está fuera del rango permitido.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La fecha no es válida o está vacía.");
                    }

                    textBox45.Text = selectedItem.SubItems[3].Text;
                    materialComboBox2.Text = selectedItem.SubItems[4].Text;
                }
            }
        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {
            cargarVentas(textBox43.Text.Trim());
        }

        private void materialButton25_Click(object sender, EventArgs e)
        {
            if (!datosCorrectoVentas())
            {
                return;
            }

            cargarVentas();
            capturarDatosDelFormularioVentas();

            if (mConsultaVenta.agregarVentas(mcarga8))
            {

                MessageBox.Show("Venta agregada");
                cargarVentas();
                LimpiarCampos8();
            }
        }

        private void materialButton26_Click(object sender, EventArgs e)
        {
            capturarDatosDelFormularioParaEliminarVentas();

            if (mConsultaVenta.eliminarVentas(mcarga8))
            {
                MessageBox.Show("Venta eliminada");
                cargarVentas();
                LimpiarCampos8();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar la factura");
            }
        }

        private void grid9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (grid9.SelectedItems.Count > 0)
            {

                ListViewItem selectedItem = grid9.SelectedItems[0];


                if (int.TryParse(selectedItem.SubItems[0].Text, out int id_detalle_venta))
                {
                    textBox48.Text = id_detalle_venta.ToString();
                    textBox49.Text = selectedItem.SubItems[1].Text;
                    textBox50.Text = selectedItem.SubItems[2].Text;
                    materialComboBox3.Text = selectedItem.SubItems[3].Text;
                    textBox52.Text = selectedItem.SubItems[4].Text;
                    textBox53.Text = selectedItem.SubItems[5].Text;
                    textBox54.Text = selectedItem.SubItems[6].Text;
                }
            }
        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {
            cargarDetalleVentas(textBox47.Text.Trim());
        }

        private void materialButton27_Click(object sender, EventArgs e)
        {
            if (!datosCorrectoDetalleVentas())
            {
                return;
            }

            cargarDetalleVentas();
            capturarDatosDelFormularioDetallesVentas();

            if (mConsultaDetalleVentas.agregarDetalleVentas(mcarga9))
            {

                MessageBox.Show("Detalle de venta agregada");
                cargarDetalleVentas();
                LimpiarCampos9();
            }
        }

        private void CargarServicios1()
        {
            string query = "SELECT id_servicio, descripcion FROM servicios";
            using (MySqlCommand cmd = new MySqlCommand(query, conexionMysql.GetConnection()))
            {
                try
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        materialComboBox3.Items.Clear();

                        while (reader.Read())
                        {
                            int idServicio = reader.GetInt32("id_servicio");
                            string descripcion = reader.GetString("descripcion");

                            materialComboBox3.Items.Add(new KeyValuePair<int, string>(idServicio, descripcion));
                        }
                    }

                    materialComboBox3.DisplayMember = "Value";
                    materialComboBox3.ValueMember = "Key";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar servicios: " + ex.Message);
                }
            }
        }

        private void materialComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialComboBox3.SelectedItem is KeyValuePair<int, string> selectedService)
            {
                int idServicio = selectedService.Key;

                if (!int.TryParse(textBox49.Text, out int idVenta))
                {
                    MessageBox.Show("ID de venta no válido.");
                    return;
                }

                string query = @"
            SELECT 
                dv.precio_unitario, 
                dv.cantidad, 
                dv.subtotal
            FROM 
                detalles_ventas dv
            WHERE 
                dv.id_servicio = @id_servicio AND dv.id_venta = @id_venta";

                using (MySqlCommand cmd = new MySqlCommand(query, conexionMysql.GetConnection()))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@id_servicio", idServicio);
                        cmd.Parameters.AddWithValue("@id_venta", idVenta);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                decimal precioUnitario = reader.IsDBNull(reader.GetOrdinal("precio_unitario")) ? 0.00m : reader.GetDecimal("precio_unitario");
                                int cantidad = reader.IsDBNull(reader.GetOrdinal("cantidad")) ? 0 : reader.GetInt32("cantidad");
                                decimal subtotal = reader.IsDBNull(reader.GetOrdinal("subtotal")) ? 0.00m : reader.GetDecimal("subtotal");

                                textBox52.Text = precioUnitario.ToString("0.00");
                                textBox53.Text = cantidad.ToString();
                                textBox54.Text = subtotal.ToString("0.00");
                            }
                            else
                            {
                                textBox52.Text = "0";
                                textBox53.Text = "0";
                                textBox54.Text = "0";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al obtener los datos: " + ex.Message);
                    }
                }
            }

        }
        private void materialButton28_Click(object sender, EventArgs e)
        {
            if (!datosCorrectoDetalleVentas())
            {
                return;
            }

            mcarga9.id_detalle_venta = Convert.ToInt32(textBox48.Text.Trim());
            mcarga9.id_venta = Convert.ToInt32(textBox49.Text.Trim());
            mcarga9.id_pieza = Convert.ToInt32(textBox50.Text.Trim());

            string nombreServicio = materialComboBox3.Text.Trim();

            if (mConsultaDetalleVentas.modificarDetalleVentas(mcarga9, nombreServicio))
            {
                MessageBox.Show("Detalle modificado correctamente.");
                cargarDetalleVentas();
                capturarDatosDelFormularioDetallesVentas();
                LimpiarCampos9();
            }
            else
            {
                MessageBox.Show("No se pudo modificar la orden.");
            }
        }

        private void materialButton29_Click(object sender, EventArgs e)
        {
            capturarDatosDelFormularioDetallesVentasParaEliminar();

            if (mConsultaDetalleVentas.EliminarVentaDetallada(mcarga9))
            {
                MessageBox.Show("Detalle eliminado");
                cargarDetalleVentas();
                LimpiarCampos9();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el detalle");
            }
        }

        private void grid10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (grid10.SelectedItems.Count > 0)
            {

                ListViewItem selectedItem = grid10.SelectedItems[0];


                if (int.TryParse(selectedItem.SubItems[0].Text, out int id_usuario))
                {
                    textBox55.Text = id_usuario.ToString();
                    textBox56.Text = selectedItem.SubItems[1].Text;
                    textBox57.Text = selectedItem.SubItems[2].Text;
                    textBox58.Text = selectedItem.SubItems[3].Text;
                    textBox59.Text = selectedItem.SubItems[4].Text;
                    textBox60.Text = selectedItem.SubItems[5].Text;
                    textBox61.Text = selectedItem.SubItems[6].Text;
                    materialComboBox4.Text = selectedItem.SubItems[7].Text;
                }
            }
        }

        private void textBox51_TextChanged(object sender, EventArgs e)
        {
            cargarUsuario(textBox51.Text.Trim());
        }

        private void materialButton30_Click(object sender, EventArgs e)
        {
 
            cargarUsuario();
            capturarDatosDelFormularioUsuario();

            if (mConsultaUsuario.agregarUsuarios(mcarga10))
            {

                MessageBox.Show("Usuario agregado");
                cargarUsuario();
                LimpiarCampos10();
            }
        }

        private void materialButton31_Click(object sender, EventArgs e)
        {

            mcarga10.id_usuario = Convert.ToInt32(textBox55.Text.Trim());
            mcarga10.nombre_usuario = textBox56.Text.Trim();
            mcarga10.contrasena = textBox57.Text.Trim();
            mcarga10.nombre = textBox58.Text.Trim();
            mcarga10.apellido = textBox59.Text.Trim();
            mcarga10.Correo = textBox60.Text.Trim();
            mcarga10.numero_tel = textBox61.Text.Trim();
            mcarga10.rol = materialComboBox4.Text.Trim();


            if (mConsultaUsuario.modificarUsuarios(mcarga10))
            {
                MessageBox.Show("Usuario modificado");
                cargarUsuario();
                capturarDatosDelFormularioUsuario();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("No se pudo modificar el cliente.");
            }
        }

        private void materialButton32_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar este Usuario?", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                capturarDatosDelFormularioParaEliminarUsuario();

                if (mConsultaUsuario.eliminarUsuarios(mcarga10))
                {
                    MessageBox.Show("Usuario eliminado");
                    cargarUsuario();
                    LimpiarCampos10();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Usuario");
                }
            }
        }
    }

}

