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
    partial class Form2 
    {
  
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.grid = new MaterialSkin.Controls.MaterialListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cedula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Direccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialButton6 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton5 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grid1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialButton9 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton8 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton7 = new MaterialSkin.Controls.MaterialButton();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.grid2 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Controls.Add(this.tabPage6);
            this.materialTabControl1.Controls.Add(this.tabPage7);
            this.materialTabControl1.Controls.Add(this.tabPage8);
            this.materialTabControl1.Controls.Add(this.tabPage9);
            this.materialTabControl1.Controls.Add(this.tabPage10);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1375, 583);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.tabPage1.Controls.Add(this.materialLabel7);
            this.tabPage1.Controls.Add(this.textBox7);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.materialLabel6);
            this.tabPage1.Controls.Add(this.materialLabel5);
            this.tabPage1.Controls.Add(this.materialLabel4);
            this.tabPage1.Controls.Add(this.materialLabel3);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.materialButton3);
            this.tabPage1.Controls.Add(this.materialButton2);
            this.tabPage1.Controls.Add(this.materialButton1);
            this.tabPage1.Controls.Add(this.grid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1367, 557);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.materialLabel7.Depth = 0;
            this.materialLabel7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.ForeColor = System.Drawing.Color.Black;
            this.materialLabel7.Location = new System.Drawing.Point(253, 98);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(20, 19);
            this.materialLabel7.TabIndex = 19;
            this.materialLabel7.Text = "ID:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(330, 98);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 18;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(330, 419);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(212, 20);
            this.textBox6.TabIndex = 17;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(726, 76);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(76, 19);
            this.materialLabel6.TabIndex = 16;
            this.materialLabel6.Text = "Busqueda:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(253, 420);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(71, 19);
            this.materialLabel5.TabIndex = 15;
            this.materialLabel5.Text = "Direccion:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(253, 357);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(68, 19);
            this.materialLabel4.TabIndex = 14;
            this.materialLabel4.Text = "Telefono:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(253, 288);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(54, 19);
            this.materialLabel3.TabIndex = 13;
            this.materialLabel3.Text = "Cedula:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(253, 223);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(62, 19);
            this.materialLabel2.TabIndex = 12;
            this.materialLabel2.Text = "Apellido:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.Black;
            this.materialLabel1.Location = new System.Drawing.Point(253, 154);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(61, 19);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Nombre:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(330, 356);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(212, 20);
            this.textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(330, 287);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(212, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(330, 153);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(212, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(330, 222);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 20);
            this.textBox2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(665, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(821, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(1038, 488);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(88, 36);
            this.materialButton3.TabIndex = 3;
            this.materialButton3.Text = "ELIMINAR";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(821, 488);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(99, 36);
            this.materialButton2.TabIndex = 2;
            this.materialButton2.Text = "MODIFICAR";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(387, 488);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(88, 36);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "Agregar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // grid
            // 
            this.grid.AutoSizeTable = false;
            this.grid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nombre,
            this.Apellido,
            this.Cedula,
            this.Telefono,
            this.Direccion});
            this.grid.Depth = 0;
            this.grid.FullRowSelect = true;
            this.grid.HideSelection = false;
            this.grid.Location = new System.Drawing.Point(623, 132);
            this.grid.MinimumSize = new System.Drawing.Size(200, 100);
            this.grid.MouseLocation = new System.Drawing.Point(-1, -1);
            this.grid.MouseState = MaterialSkin.MouseState.OUT;
            this.grid.Name = "grid";
            this.grid.OwnerDraw = true;
            this.grid.Size = new System.Drawing.Size(703, 317);
            this.grid.TabIndex = 0;
            this.grid.UseCompatibleStateImageBehavior = false;
            this.grid.View = System.Windows.Forms.View.Details;
            this.grid.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.grid_ItemSelectionChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 54;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 139;
            // 
            // Apellido
            // 
            this.Apellido.Text = "Apellido";
            this.Apellido.Width = 142;
            // 
            // Cedula
            // 
            this.Cedula.Text = "Cedula";
            this.Cedula.Width = 133;
            // 
            // Telefono
            // 
            this.Telefono.Text = "Telefono";
            this.Telefono.Width = 130;
            // 
            // Direccion
            // 
            this.Direccion.Text = "Direccion";
            this.Direccion.Width = 102;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.tabPage2.Controls.Add(this.materialButton6);
            this.tabPage2.Controls.Add(this.materialButton5);
            this.tabPage2.Controls.Add(this.materialButton4);
            this.tabPage2.Controls.Add(this.textBox14);
            this.tabPage2.Controls.Add(this.textBox13);
            this.tabPage2.Controls.Add(this.textBox12);
            this.tabPage2.Controls.Add(this.textBox11);
            this.tabPage2.Controls.Add(this.textBox10);
            this.tabPage2.Controls.Add(this.textBox9);
            this.tabPage2.Controls.Add(this.materialLabel14);
            this.tabPage2.Controls.Add(this.materialLabel13);
            this.tabPage2.Controls.Add(this.materialLabel12);
            this.tabPage2.Controls.Add(this.materialLabel11);
            this.tabPage2.Controls.Add(this.materialLabel10);
            this.tabPage2.Controls.Add(this.materialLabel9);
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Controls.Add(this.materialLabel8);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.grid1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1367, 557);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vehiculos";
            // 
            // materialButton6
            // 
            this.materialButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton6.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton6.Depth = 0;
            this.materialButton6.HighEmphasis = true;
            this.materialButton6.Icon = null;
            this.materialButton6.Location = new System.Drawing.Point(1038, 488);
            this.materialButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton6.Name = "materialButton6";
            this.materialButton6.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton6.Size = new System.Drawing.Size(88, 36);
            this.materialButton6.TabIndex = 34;
            this.materialButton6.Text = "ELIMINAR";
            this.materialButton6.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton6.UseAccentColor = false;
            this.materialButton6.UseVisualStyleBackColor = true;
            this.materialButton6.Click += new System.EventHandler(this.materialButton6_Click);
            // 
            // materialButton5
            // 
            this.materialButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton5.Depth = 0;
            this.materialButton5.HighEmphasis = true;
            this.materialButton5.Icon = null;
            this.materialButton5.Location = new System.Drawing.Point(821, 488);
            this.materialButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton5.Name = "materialButton5";
            this.materialButton5.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton5.Size = new System.Drawing.Size(99, 36);
            this.materialButton5.TabIndex = 33;
            this.materialButton5.Text = "MODIFICAR";
            this.materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton5.UseAccentColor = false;
            this.materialButton5.UseVisualStyleBackColor = true;
            this.materialButton5.Click += new System.EventHandler(this.materialButton5_Click);
            // 
            // materialButton4
            // 
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(387, 488);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Size = new System.Drawing.Size(88, 36);
            this.materialButton4.TabIndex = 32;
            this.materialButton4.Text = "Agregar";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            this.materialButton4.Click += new System.EventHandler(this.materialButton4_Click);
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(330, 419);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(212, 20);
            this.textBox14.TabIndex = 31;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(330, 352);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(212, 20);
            this.textBox13.TabIndex = 30;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(330, 288);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(212, 20);
            this.textBox12.TabIndex = 29;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(330, 222);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(212, 20);
            this.textBox11.TabIndex = 28;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(330, 153);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(212, 20);
            this.textBox10.TabIndex = 27;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(330, 98);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 26;
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.Location = new System.Drawing.Point(253, 420);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(45, 19);
            this.materialLabel14.TabIndex = 25;
            this.materialLabel14.Text = "Placa:";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.Location = new System.Drawing.Point(253, 353);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(33, 19);
            this.materialLabel13.TabIndex = 24;
            this.materialLabel13.Text = "Año:";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(253, 288);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(58, 19);
            this.materialLabel12.TabIndex = 23;
            this.materialLabel12.Text = "Modelo:";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.materialLabel11.Depth = 0;
            this.materialLabel11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(253, 223);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(50, 19);
            this.materialLabel11.TabIndex = 22;
            this.materialLabel11.Text = "Marca:";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.materialLabel10.Depth = 0;
            this.materialLabel10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.ForeColor = System.Drawing.Color.Black;
            this.materialLabel10.Location = new System.Drawing.Point(253, 154);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(72, 19);
            this.materialLabel10.TabIndex = 21;
            this.materialLabel10.Text = "ID Cliente:";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.materialLabel9.Depth = 0;
            this.materialLabel9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.ForeColor = System.Drawing.Color.Black;
            this.materialLabel9.Location = new System.Drawing.Point(253, 98);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(20, 19);
            this.materialLabel9.TabIndex = 20;
            this.materialLabel9.Text = "ID:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(821, 77);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(305, 20);
            this.textBox8.TabIndex = 18;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(726, 76);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(76, 19);
            this.materialLabel8.TabIndex = 17;
            this.materialLabel8.Text = "Busqueda:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(665, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // grid1
            // 
            this.grid1.AutoSizeTable = false;
            this.grid1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.grid1.Depth = 0;
            this.grid1.FullRowSelect = true;
            this.grid1.HideSelection = false;
            this.grid1.Location = new System.Drawing.Point(623, 132);
            this.grid1.MinimumSize = new System.Drawing.Size(200, 100);
            this.grid1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.grid1.MouseState = MaterialSkin.MouseState.OUT;
            this.grid1.Name = "grid1";
            this.grid1.OwnerDraw = true;
            this.grid1.Size = new System.Drawing.Size(703, 317);
            this.grid1.TabIndex = 1;
            this.grid1.UseCompatibleStateImageBehavior = false;
            this.grid1.View = System.Windows.Forms.View.Details;
            this.grid1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.grid1_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 54;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID Cliente";
            this.columnHeader2.Width = 139;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Marca";
            this.columnHeader3.Width = 136;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Modelo";
            this.columnHeader4.Width = 133;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Año";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Placa";
            this.columnHeader6.Width = 102;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.tabPage3.Controls.Add(this.materialButton9);
            this.tabPage3.Controls.Add(this.materialButton8);
            this.tabPage3.Controls.Add(this.materialButton7);
            this.tabPage3.Controls.Add(this.textBox19);
            this.tabPage3.Controls.Add(this.materialLabel20);
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Controls.Add(this.textBox20);
            this.tabPage3.Controls.Add(this.textBox18);
            this.tabPage3.Controls.Add(this.textBox17);
            this.tabPage3.Controls.Add(this.textBox16);
            this.tabPage3.Controls.Add(this.materialLabel19);
            this.tabPage3.Controls.Add(this.materialLabel18);
            this.tabPage3.Controls.Add(this.materialLabel17);
            this.tabPage3.Controls.Add(this.materialLabel16);
            this.tabPage3.Controls.Add(this.textBox15);
            this.tabPage3.Controls.Add(this.materialLabel15);
            this.tabPage3.Controls.Add(this.grid2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1367, 557);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Piezas";
            // 
            // materialButton9
            // 
            this.materialButton9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton9.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton9.Depth = 0;
            this.materialButton9.HighEmphasis = true;
            this.materialButton9.Icon = null;
            this.materialButton9.Location = new System.Drawing.Point(1038, 476);
            this.materialButton9.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton9.Name = "materialButton9";
            this.materialButton9.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton9.Size = new System.Drawing.Size(88, 36);
            this.materialButton9.TabIndex = 42;
            this.materialButton9.Text = "ELIMINAR";
            this.materialButton9.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton9.UseAccentColor = false;
            this.materialButton9.UseVisualStyleBackColor = true;
            this.materialButton9.Click += new System.EventHandler(this.materialButton9_Click);
            // 
            // materialButton8
            // 
            this.materialButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton8.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton8.Depth = 0;
            this.materialButton8.HighEmphasis = true;
            this.materialButton8.Icon = null;
            this.materialButton8.Location = new System.Drawing.Point(821, 476);
            this.materialButton8.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton8.Name = "materialButton8";
            this.materialButton8.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton8.Size = new System.Drawing.Size(99, 36);
            this.materialButton8.TabIndex = 41;
            this.materialButton8.Text = "MODIFICAR";
            this.materialButton8.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton8.UseAccentColor = false;
            this.materialButton8.UseVisualStyleBackColor = true;
            this.materialButton8.Click += new System.EventHandler(this.materialButton8_Click);
            // 
            // materialButton7
            // 
            this.materialButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton7.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton7.Depth = 0;
            this.materialButton7.HighEmphasis = true;
            this.materialButton7.Icon = null;
            this.materialButton7.Location = new System.Drawing.Point(301, 476);
            this.materialButton7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton7.Name = "materialButton7";
            this.materialButton7.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton7.Size = new System.Drawing.Size(88, 36);
            this.materialButton7.TabIndex = 40;
            this.materialButton7.Text = "Agregar";
            this.materialButton7.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton7.UseAccentColor = false;
            this.materialButton7.UseVisualStyleBackColor = true;
            this.materialButton7.Click += new System.EventHandler(this.materialButton7_Click);
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(821, 77);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(305, 20);
            this.textBox19.TabIndex = 39;
            this.textBox19.TextChanged += new System.EventHandler(this.textBox19_TextChanged);
            // 
            // materialLabel20
            // 
            this.materialLabel20.AutoSize = true;
            this.materialLabel20.Depth = 0;
            this.materialLabel20.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel20.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel20.Location = new System.Drawing.Point(726, 76);
            this.materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel20.Name = "materialLabel20";
            this.materialLabel20.Size = new System.Drawing.Size(76, 19);
            this.materialLabel20.TabIndex = 38;
            this.materialLabel20.Text = "Busqueda:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(665, 69);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(469, 346);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(99, 20);
            this.textBox20.TabIndex = 35;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(469, 273);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(99, 20);
            this.textBox18.TabIndex = 34;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(160, 346);
            this.textBox17.Multiline = true;
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(212, 20);
            this.textBox17.TabIndex = 33;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(160, 273);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(212, 20);
            this.textBox16.TabIndex = 32;
            // 
            // materialLabel19
            // 
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.materialLabel19.Depth = 0;
            this.materialLabel19.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel19.ForeColor = System.Drawing.Color.Black;
            this.materialLabel19.Location = new System.Drawing.Point(394, 347);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(69, 19);
            this.materialLabel19.TabIndex = 31;
            this.materialLabel19.Text = "Cantidad:";
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.materialLabel18.Depth = 0;
            this.materialLabel18.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel18.ForeColor = System.Drawing.Color.Black;
            this.materialLabel18.Location = new System.Drawing.Point(394, 273);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(49, 19);
            this.materialLabel18.TabIndex = 30;
            this.materialLabel18.Text = "Precio:";
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.materialLabel17.Depth = 0;
            this.materialLabel17.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel17.ForeColor = System.Drawing.Color.Black;
            this.materialLabel17.Location = new System.Drawing.Point(66, 347);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(88, 19);
            this.materialLabel17.TabIndex = 29;
            this.materialLabel17.Text = "Descripcion:";
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.materialLabel16.Depth = 0;
            this.materialLabel16.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel16.ForeColor = System.Drawing.Color.Black;
            this.materialLabel16.Location = new System.Drawing.Point(66, 273);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(61, 19);
            this.materialLabel16.TabIndex = 28;
            this.materialLabel16.Text = "Nombre:";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(160, 195);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 20);
            this.textBox15.TabIndex = 27;
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.materialLabel15.Depth = 0;
            this.materialLabel15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel15.ForeColor = System.Drawing.Color.Black;
            this.materialLabel15.Location = new System.Drawing.Point(66, 196);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(20, 19);
            this.materialLabel15.TabIndex = 21;
            this.materialLabel15.Text = "ID:";
            // 
            // grid2
            // 
            this.grid2.AutoSizeTable = false;
            this.grid2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader13});
            this.grid2.Depth = 0;
            this.grid2.FullRowSelect = true;
            this.grid2.HideSelection = false;
            this.grid2.Location = new System.Drawing.Point(623, 132);
            this.grid2.MinimumSize = new System.Drawing.Size(200, 100);
            this.grid2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.grid2.MouseState = MaterialSkin.MouseState.OUT;
            this.grid2.Name = "grid2";
            this.grid2.OwnerDraw = true;
            this.grid2.Size = new System.Drawing.Size(703, 317);
            this.grid2.TabIndex = 2;
            this.grid2.UseCompatibleStateImageBehavior = false;
            this.grid2.View = System.Windows.Forms.View.Details;
            this.grid2.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.grid2_ItemSelectionChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID";
            this.columnHeader7.Width = 54;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Nombre";
            this.columnHeader8.Width = 104;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Descripcion";
            this.columnHeader9.Width = 216;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Precio";
            this.columnHeader10.Width = 150;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Cantidad";
            this.columnHeader13.Width = 174;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1367, 557);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Inventario";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1367, 557);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Servicios";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1367, 557);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Ordenes de trabajo";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1367, 557);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Detalle de Orden de trabajo";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(1367, 557);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Factuiracion";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(1367, 557);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Ventas";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(1367, 557);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Text = "Detalle de Ventas";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(59)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(1381, 650);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Form2";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MaterialListView grid;
        private MaterialButton materialButton2;
        private MaterialButton materialButton1;
        private TextBox textBox1;
        private MaterialButton materialButton3;
        private PictureBox pictureBox1;
        private ColumnHeader Apellido;
        private ColumnHeader Cedula;
        private ColumnHeader Telefono;
        private ColumnHeader Direccion;
        internal ColumnHeader Nombre;
        private MaterialLabel materialLabel1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private MaterialLabel materialLabel2;
        private MaterialLabel materialLabel3;
        private MaterialLabel materialLabel5;
        private MaterialLabel materialLabel4;
        private MaterialLabel materialLabel6;
        private TextBox textBox6;
        private MaterialLabel materialLabel7;
        private TextBox textBox7;
        private ColumnHeader ID;
        private MaterialListView grid1;
        private ColumnHeader columnHeader1;
        internal ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TextBox textBox8;
        private MaterialLabel materialLabel8;
        private PictureBox pictureBox2;
        private MaterialLabel materialLabel14;
        private MaterialLabel materialLabel13;
        private MaterialLabel materialLabel12;
        private MaterialLabel materialLabel11;
        private MaterialLabel materialLabel10;
        private MaterialLabel materialLabel9;
        private TextBox textBox14;
        private TextBox textBox13;
        private TextBox textBox12;
        private TextBox textBox11;
        private TextBox textBox10;
        private TextBox textBox9;
        private MaterialButton materialButton6;
        private MaterialButton materialButton5;
        private MaterialButton materialButton4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private TabPage tabPage9;
        private TabPage tabPage10;
        private MaterialListView grid2;
        private ColumnHeader columnHeader7;
        internal ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private TextBox textBox15;
        private MaterialLabel materialLabel15;
        private ColumnHeader columnHeader13;
        private TextBox textBox19;
        private MaterialLabel materialLabel20;
        private PictureBox pictureBox3;
        private TextBox textBox20;
        private TextBox textBox18;
        private TextBox textBox17;
        private TextBox textBox16;
        private MaterialLabel materialLabel19;
        private MaterialLabel materialLabel18;
        private MaterialLabel materialLabel17;
        private MaterialLabel materialLabel16;
        private MaterialButton materialButton9;
        private MaterialButton materialButton8;
        private MaterialButton materialButton7;
    }
}