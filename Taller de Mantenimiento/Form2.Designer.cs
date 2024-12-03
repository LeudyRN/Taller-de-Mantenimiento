﻿using System;
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
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
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
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
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.materialButton12 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton11 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton10 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel25 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel24 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel23 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel22 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.materialLabel21 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.grid3 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.materialButton15 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton14 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton13 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel30 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.materialLabel29 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.materialLabel28 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.materialLabel27 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.grid4 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.materialLabel26 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.materialButton18 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton17 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton16 = new MaterialSkin.Controls.MaterialButton();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.materialLabel36 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.grid5 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel35 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel34 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel33 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel32 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel31 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.materialLabel41 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton21 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton20 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton19 = new MaterialSkin.Controls.MaterialButton();
            this.comboBoxServicios = new MaterialSkin.Controls.MaterialComboBox();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.materialLabel40 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel39 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel38 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.materialLabel37 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.grid6 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.materialButton24 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton23 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton22 = new MaterialSkin.Controls.MaterialButton();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.materialLabel46 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.materialLabel45 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel44 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel43 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.materialLabel42 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.grid7 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader30 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader31 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader32 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.materialLabel52 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton26 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton25 = new MaterialSkin.Controls.MaterialButton();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.materialComboBox2 = new MaterialSkin.Controls.MaterialComboBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.materialLabel51 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel50 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel49 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel48 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.materialLabel47 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.grid8 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader33 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader34 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader35 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader36 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader37 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.materialButton29 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton28 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton27 = new MaterialSkin.Controls.MaterialButton();
            this.materialComboBox3 = new MaterialSkin.Controls.MaterialComboBox();
            this.textBox54 = new System.Windows.Forms.TextBox();
            this.textBox53 = new System.Windows.Forms.TextBox();
            this.textBox52 = new System.Windows.Forms.TextBox();
            this.textBox50 = new System.Windows.Forms.TextBox();
            this.textBox49 = new System.Windows.Forms.TextBox();
            this.textBox48 = new System.Windows.Forms.TextBox();
            this.materialLabel60 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel59 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel58 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel57 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel56 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel55 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel54 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.materialLabel53 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.grid9 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader38 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader39 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader40 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader41 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader42 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader43 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader44 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.grid11 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader53 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader54 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader55 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader56 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader57 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader58 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader59 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader60 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.materialLabel70 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.textBox62 = new System.Windows.Forms.TextBox();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.textBox57 = new System.Windows.Forms.TextBox();
            this.materialButton32 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton31 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton30 = new MaterialSkin.Controls.MaterialButton();
            this.materialComboBox4 = new MaterialSkin.Controls.MaterialComboBox();
            this.textBox61 = new System.Windows.Forms.TextBox();
            this.textBox60 = new System.Windows.Forms.TextBox();
            this.textBox59 = new System.Windows.Forms.TextBox();
            this.textBox58 = new System.Windows.Forms.TextBox();
            this.textBox56 = new System.Windows.Forms.TextBox();
            this.textBox55 = new System.Windows.Forms.TextBox();
            this.grid10 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader45 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader46 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader47 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader48 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader49 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader50 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader51 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader52 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox51 = new System.Windows.Forms.TextBox();
            this.materialLabel69 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.materialLabel68 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel67 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel66 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel65 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel64 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel63 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel62 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel61 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            this.tabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            this.tabPage11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            this.tabPage12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
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
            this.materialTabControl1.Controls.Add(this.tabPage11);
            this.materialTabControl1.Controls.Add(this.tabPage12);
            this.materialTabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialTabControl1.ItemSize = new System.Drawing.Size(60, 30);
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.Padding = new System.Drawing.Point(9, 6);
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1376, 583);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox5);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1368, 545);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 39);
            this.label1.TabIndex = 21;
            this.label1.Text = "Clientes";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(42, 47);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(74, 60);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.White;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.ForeColor = System.Drawing.Color.Black;
            this.materialLabel7.Location = new System.Drawing.Point(62, 232);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(20, 19);
            this.materialLabel7.TabIndex = 19;
            this.materialLabel7.Text = "ID:";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox7.Location = new System.Drawing.Point(88, 231);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(109, 20);
            this.textBox7.TabIndex = 18;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox6.Location = new System.Drawing.Point(387, 383);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(176, 20);
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
            this.materialLabel5.Location = new System.Drawing.Point(326, 384);
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
            this.materialLabel4.Location = new System.Drawing.Point(62, 384);
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
            this.materialLabel3.Location = new System.Drawing.Point(62, 307);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(54, 19);
            this.materialLabel3.TabIndex = 13;
            this.materialLabel3.Text = "Cedula:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.White;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(326, 307);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(62, 19);
            this.materialLabel2.TabIndex = 12;
            this.materialLabel2.Text = "Apellido:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.Black;
            this.materialLabel1.Location = new System.Drawing.Point(327, 232);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(61, 19);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Nombre:";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox5.Location = new System.Drawing.Point(129, 383);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(159, 20);
            this.textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox4.Location = new System.Drawing.Point(112, 306);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(176, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox3.Location = new System.Drawing.Point(387, 231);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(176, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox2.Location = new System.Drawing.Point(387, 306);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 20);
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
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
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
            this.materialButton1.Location = new System.Drawing.Point(276, 455);
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
            this.grid.Location = new System.Drawing.Point(603, 132);
            this.grid.MinimumSize = new System.Drawing.Size(200, 100);
            this.grid.MouseLocation = new System.Drawing.Point(-1, -1);
            this.grid.MouseState = MaterialSkin.MouseState.OUT;
            this.grid.Name = "grid";
            this.grid.OwnerDraw = true;
            this.grid.Size = new System.Drawing.Size(723, 317);
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
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.pictureBox6);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1368, 545);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vehiculos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 39);
            this.label2.TabIndex = 36;
            this.label2.Text = "Vehiculos";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(42, 47);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(74, 60);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 35;
            this.pictureBox6.TabStop = false;
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
            this.materialButton4.Location = new System.Drawing.Point(284, 443);
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
            this.textBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox14.Location = new System.Drawing.Point(396, 371);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(212, 20);
            this.textBox14.TabIndex = 31;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox13.Location = new System.Drawing.Point(85, 371);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(229, 20);
            this.textBox13.TabIndex = 30;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox12.Location = new System.Drawing.Point(396, 296);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(212, 20);
            this.textBox12.TabIndex = 29;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox11.Location = new System.Drawing.Point(102, 296);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(212, 20);
            this.textBox11.TabIndex = 28;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox10.Location = new System.Drawing.Point(396, 226);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 27;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox9.Location = new System.Drawing.Point(72, 225);
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
            this.materialLabel14.Location = new System.Drawing.Point(327, 372);
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
            this.materialLabel13.Location = new System.Drawing.Point(46, 372);
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
            this.materialLabel12.Location = new System.Drawing.Point(327, 297);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(58, 19);
            this.materialLabel12.TabIndex = 23;
            this.materialLabel12.Text = "Modelo:";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.BackColor = System.Drawing.Color.White;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(46, 297);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(50, 19);
            this.materialLabel11.TabIndex = 22;
            this.materialLabel11.Text = "Marca:";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.BackColor = System.Drawing.Color.White;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.ForeColor = System.Drawing.Color.Black;
            this.materialLabel10.Location = new System.Drawing.Point(327, 226);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(72, 19);
            this.materialLabel10.TabIndex = 21;
            this.materialLabel10.Text = "ID Cliente:";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.BackColor = System.Drawing.Color.White;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.ForeColor = System.Drawing.Color.Black;
            this.materialLabel9.Location = new System.Drawing.Point(46, 226);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(20, 19);
            this.materialLabel9.TabIndex = 20;
            this.materialLabel9.Text = "ID:";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
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
            this.grid1.Location = new System.Drawing.Point(625, 126);
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
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.pictureBox7);
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
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1368, 545);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Piezas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 39);
            this.label3.TabIndex = 44;
            this.label3.Text = "Piezas";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(42, 47);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(74, 60);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 43;
            this.pictureBox7.TabStop = false;
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
            this.materialButton7.Location = new System.Drawing.Point(303, 413);
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
            this.textBox19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
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
            this.textBox20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox20.Location = new System.Drawing.Point(469, 277);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(99, 20);
            this.textBox20.TabIndex = 35;
            // 
            // textBox18
            // 
            this.textBox18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox18.Location = new System.Drawing.Point(469, 208);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(99, 20);
            this.textBox18.TabIndex = 34;
            // 
            // textBox17
            // 
            this.textBox17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox17.Location = new System.Drawing.Point(160, 351);
            this.textBox17.Multiline = true;
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(408, 20);
            this.textBox17.TabIndex = 33;
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox16.Location = new System.Drawing.Point(160, 277);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(212, 20);
            this.textBox16.TabIndex = 32;
            // 
            // materialLabel19
            // 
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.BackColor = System.Drawing.Color.White;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel19.ForeColor = System.Drawing.Color.Black;
            this.materialLabel19.Location = new System.Drawing.Point(394, 278);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(69, 19);
            this.materialLabel19.TabIndex = 31;
            this.materialLabel19.Text = "Cantidad:";
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.BackColor = System.Drawing.Color.White;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel18.ForeColor = System.Drawing.Color.Black;
            this.materialLabel18.Location = new System.Drawing.Point(394, 208);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(49, 19);
            this.materialLabel18.TabIndex = 30;
            this.materialLabel18.Text = "Precio:";
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.BackColor = System.Drawing.Color.White;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel17.ForeColor = System.Drawing.Color.Black;
            this.materialLabel17.Location = new System.Drawing.Point(66, 351);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(88, 19);
            this.materialLabel17.TabIndex = 29;
            this.materialLabel17.Text = "Descripcion:";
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.BackColor = System.Drawing.Color.White;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel16.ForeColor = System.Drawing.Color.Black;
            this.materialLabel16.Location = new System.Drawing.Point(66, 278);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(61, 19);
            this.materialLabel16.TabIndex = 28;
            this.materialLabel16.Text = "Nombre:";
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox15.Location = new System.Drawing.Point(92, 207);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 20);
            this.textBox15.TabIndex = 27;
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.BackColor = System.Drawing.Color.White;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel15.ForeColor = System.Drawing.Color.Black;
            this.materialLabel15.Location = new System.Drawing.Point(66, 208);
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
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.pictureBox8);
            this.tabPage4.Controls.Add(this.materialButton12);
            this.tabPage4.Controls.Add(this.materialButton11);
            this.tabPage4.Controls.Add(this.materialButton10);
            this.tabPage4.Controls.Add(this.materialLabel25);
            this.tabPage4.Controls.Add(this.materialLabel24);
            this.tabPage4.Controls.Add(this.materialLabel23);
            this.tabPage4.Controls.Add(this.materialLabel22);
            this.tabPage4.Controls.Add(this.textBox25);
            this.tabPage4.Controls.Add(this.textBox24);
            this.tabPage4.Controls.Add(this.textBox23);
            this.tabPage4.Controls.Add(this.textBox22);
            this.tabPage4.Controls.Add(this.textBox21);
            this.tabPage4.Controls.Add(this.materialLabel21);
            this.tabPage4.Controls.Add(this.pictureBox4);
            this.tabPage4.Controls.Add(this.grid3);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1368, 545);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Inventario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 39);
            this.label4.TabIndex = 53;
            this.label4.Text = "Inventario";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(42, 47);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(74, 60);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 52;
            this.pictureBox8.TabStop = false;
            // 
            // materialButton12
            // 
            this.materialButton12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton12.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton12.Depth = 0;
            this.materialButton12.HighEmphasis = true;
            this.materialButton12.Icon = null;
            this.materialButton12.Location = new System.Drawing.Point(1038, 476);
            this.materialButton12.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton12.Name = "materialButton12";
            this.materialButton12.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton12.Size = new System.Drawing.Size(88, 36);
            this.materialButton12.TabIndex = 51;
            this.materialButton12.Text = "ELIMINAR";
            this.materialButton12.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton12.UseAccentColor = false;
            this.materialButton12.UseVisualStyleBackColor = true;
            this.materialButton12.Click += new System.EventHandler(this.materialButton12_Click);
            // 
            // materialButton11
            // 
            this.materialButton11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton11.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton11.Depth = 0;
            this.materialButton11.HighEmphasis = true;
            this.materialButton11.Icon = null;
            this.materialButton11.Location = new System.Drawing.Point(821, 476);
            this.materialButton11.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton11.Name = "materialButton11";
            this.materialButton11.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton11.Size = new System.Drawing.Size(99, 36);
            this.materialButton11.TabIndex = 50;
            this.materialButton11.Text = "MODIFICAR";
            this.materialButton11.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton11.UseAccentColor = false;
            this.materialButton11.UseVisualStyleBackColor = true;
            this.materialButton11.Click += new System.EventHandler(this.materialButton11_Click);
            // 
            // materialButton10
            // 
            this.materialButton10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton10.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton10.Depth = 0;
            this.materialButton10.HighEmphasis = true;
            this.materialButton10.Icon = null;
            this.materialButton10.Location = new System.Drawing.Point(289, 413);
            this.materialButton10.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton10.Name = "materialButton10";
            this.materialButton10.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton10.Size = new System.Drawing.Size(88, 36);
            this.materialButton10.TabIndex = 49;
            this.materialButton10.Text = "Agregar";
            this.materialButton10.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton10.UseAccentColor = false;
            this.materialButton10.UseVisualStyleBackColor = true;
            this.materialButton10.Click += new System.EventHandler(this.materialButton10_Click);
            // 
            // materialLabel25
            // 
            this.materialLabel25.AutoSize = true;
            this.materialLabel25.BackColor = System.Drawing.Color.White;
            this.materialLabel25.Depth = 0;
            this.materialLabel25.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel25.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel25.ForeColor = System.Drawing.Color.Black;
            this.materialLabel25.Location = new System.Drawing.Point(302, 309);
            this.materialLabel25.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel25.Name = "materialLabel25";
            this.materialLabel25.Size = new System.Drawing.Size(75, 19);
            this.materialLabel25.TabIndex = 48;
            this.materialLabel25.Text = "Ubicacion:";
            // 
            // materialLabel24
            // 
            this.materialLabel24.AutoSize = true;
            this.materialLabel24.BackColor = System.Drawing.Color.White;
            this.materialLabel24.Depth = 0;
            this.materialLabel24.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel24.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel24.ForeColor = System.Drawing.Color.Black;
            this.materialLabel24.Location = new System.Drawing.Point(308, 220);
            this.materialLabel24.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel24.Name = "materialLabel24";
            this.materialLabel24.Size = new System.Drawing.Size(69, 19);
            this.materialLabel24.TabIndex = 47;
            this.materialLabel24.Text = "Cantidad:";
            // 
            // materialLabel23
            // 
            this.materialLabel23.AutoSize = true;
            this.materialLabel23.BackColor = System.Drawing.Color.White;
            this.materialLabel23.Depth = 0;
            this.materialLabel23.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel23.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel23.ForeColor = System.Drawing.Color.Black;
            this.materialLabel23.Location = new System.Drawing.Point(96, 309);
            this.materialLabel23.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel23.Name = "materialLabel23";
            this.materialLabel23.Size = new System.Drawing.Size(62, 19);
            this.materialLabel23.TabIndex = 46;
            this.materialLabel23.Text = "ID pieza:";
            // 
            // materialLabel22
            // 
            this.materialLabel22.AutoSize = true;
            this.materialLabel22.BackColor = System.Drawing.Color.White;
            this.materialLabel22.Depth = 0;
            this.materialLabel22.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel22.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel22.ForeColor = System.Drawing.Color.Black;
            this.materialLabel22.Location = new System.Drawing.Point(96, 220);
            this.materialLabel22.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel22.Name = "materialLabel22";
            this.materialLabel22.Size = new System.Drawing.Size(20, 19);
            this.materialLabel22.TabIndex = 45;
            this.materialLabel22.Text = "ID:";
            // 
            // textBox25
            // 
            this.textBox25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox25.Location = new System.Drawing.Point(374, 308);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(212, 20);
            this.textBox25.TabIndex = 44;
            // 
            // textBox24
            // 
            this.textBox24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox24.Location = new System.Drawing.Point(374, 219);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(100, 20);
            this.textBox24.TabIndex = 43;
            // 
            // textBox23
            // 
            this.textBox23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox23.Location = new System.Drawing.Point(155, 308);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(100, 20);
            this.textBox23.TabIndex = 42;
            // 
            // textBox22
            // 
            this.textBox22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox22.Location = new System.Drawing.Point(122, 219);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(100, 20);
            this.textBox22.TabIndex = 41;
            // 
            // textBox21
            // 
            this.textBox21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox21.Location = new System.Drawing.Point(821, 77);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(305, 20);
            this.textBox21.TabIndex = 40;
            this.textBox21.TextChanged += new System.EventHandler(this.textBox21_TextChanged);
            // 
            // materialLabel21
            // 
            this.materialLabel21.AutoSize = true;
            this.materialLabel21.Depth = 0;
            this.materialLabel21.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel21.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel21.Location = new System.Drawing.Point(726, 76);
            this.materialLabel21.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel21.Name = "materialLabel21";
            this.materialLabel21.Size = new System.Drawing.Size(76, 19);
            this.materialLabel21.TabIndex = 39;
            this.materialLabel21.Text = "Busqueda:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(665, 69);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(55, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // grid3
            // 
            this.grid3.AutoSizeTable = false;
            this.grid3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader14,
            this.columnHeader15});
            this.grid3.Depth = 0;
            this.grid3.FullRowSelect = true;
            this.grid3.HideSelection = false;
            this.grid3.Location = new System.Drawing.Point(623, 132);
            this.grid3.MinimumSize = new System.Drawing.Size(200, 100);
            this.grid3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.grid3.MouseState = MaterialSkin.MouseState.OUT;
            this.grid3.Name = "grid3";
            this.grid3.OwnerDraw = true;
            this.grid3.Size = new System.Drawing.Size(703, 317);
            this.grid3.TabIndex = 3;
            this.grid3.UseCompatibleStateImageBehavior = false;
            this.grid3.View = System.Windows.Forms.View.Details;
            this.grid3.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.grid3_ItemSelectionChanged);
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "ID";
            this.columnHeader11.Width = 76;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "ID piezas";
            this.columnHeader12.Width = 172;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Cantidad";
            this.columnHeader14.Width = 140;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Ubicacion";
            this.columnHeader15.Width = 306;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.White;
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.materialButton15);
            this.tabPage5.Controls.Add(this.materialButton14);
            this.tabPage5.Controls.Add(this.materialButton13);
            this.tabPage5.Controls.Add(this.materialLabel30);
            this.tabPage5.Controls.Add(this.textBox30);
            this.tabPage5.Controls.Add(this.textBox29);
            this.tabPage5.Controls.Add(this.materialLabel29);
            this.tabPage5.Controls.Add(this.textBox28);
            this.tabPage5.Controls.Add(this.materialLabel28);
            this.tabPage5.Controls.Add(this.textBox27);
            this.tabPage5.Controls.Add(this.materialLabel27);
            this.tabPage5.Controls.Add(this.pictureBox10);
            this.tabPage5.Controls.Add(this.grid4);
            this.tabPage5.Controls.Add(this.textBox26);
            this.tabPage5.Controls.Add(this.materialLabel26);
            this.tabPage5.Controls.Add(this.pictureBox9);
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1368, 545);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Servicios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 39);
            this.label5.TabIndex = 69;
            this.label5.Text = "Servicios";
            // 
            // materialButton15
            // 
            this.materialButton15.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton15.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton15.Depth = 0;
            this.materialButton15.HighEmphasis = true;
            this.materialButton15.Icon = null;
            this.materialButton15.Location = new System.Drawing.Point(1038, 476);
            this.materialButton15.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton15.Name = "materialButton15";
            this.materialButton15.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton15.Size = new System.Drawing.Size(88, 36);
            this.materialButton15.TabIndex = 68;
            this.materialButton15.Text = "ELIMINAR";
            this.materialButton15.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton15.UseAccentColor = false;
            this.materialButton15.UseVisualStyleBackColor = true;
            this.materialButton15.Click += new System.EventHandler(this.materialButton15_Click);
            // 
            // materialButton14
            // 
            this.materialButton14.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton14.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton14.Depth = 0;
            this.materialButton14.HighEmphasis = true;
            this.materialButton14.Icon = null;
            this.materialButton14.Location = new System.Drawing.Point(749, 476);
            this.materialButton14.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton14.Name = "materialButton14";
            this.materialButton14.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton14.Size = new System.Drawing.Size(99, 36);
            this.materialButton14.TabIndex = 67;
            this.materialButton14.Text = "MODIFICAR";
            this.materialButton14.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton14.UseAccentColor = false;
            this.materialButton14.UseVisualStyleBackColor = true;
            this.materialButton14.Click += new System.EventHandler(this.materialButton14_Click);
            // 
            // materialButton13
            // 
            this.materialButton13.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton13.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton13.Depth = 0;
            this.materialButton13.HighEmphasis = true;
            this.materialButton13.Icon = null;
            this.materialButton13.Location = new System.Drawing.Point(253, 413);
            this.materialButton13.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton13.Name = "materialButton13";
            this.materialButton13.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton13.Size = new System.Drawing.Size(88, 36);
            this.materialButton13.TabIndex = 66;
            this.materialButton13.Text = "Agregar";
            this.materialButton13.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton13.UseAccentColor = false;
            this.materialButton13.UseVisualStyleBackColor = true;
            this.materialButton13.Click += new System.EventHandler(this.materialButton13_Click);
            // 
            // materialLabel30
            // 
            this.materialLabel30.AutoSize = true;
            this.materialLabel30.BackColor = System.Drawing.Color.White;
            this.materialLabel30.Depth = 0;
            this.materialLabel30.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel30.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel30.ForeColor = System.Drawing.Color.Black;
            this.materialLabel30.Location = new System.Drawing.Point(235, 302);
            this.materialLabel30.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel30.Name = "materialLabel30";
            this.materialLabel30.Size = new System.Drawing.Size(159, 19);
            this.materialLabel30.TabIndex = 65;
            this.materialLabel30.Text = "Tiempo de reparacion:";
            // 
            // textBox30
            // 
            this.textBox30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox30.Location = new System.Drawing.Point(400, 301);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(100, 20);
            this.textBox30.TabIndex = 64;
            // 
            // textBox29
            // 
            this.textBox29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox29.Location = new System.Drawing.Point(116, 301);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(100, 20);
            this.textBox29.TabIndex = 63;
            // 
            // materialLabel29
            // 
            this.materialLabel29.AutoSize = true;
            this.materialLabel29.BackColor = System.Drawing.Color.White;
            this.materialLabel29.Depth = 0;
            this.materialLabel29.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel29.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel29.ForeColor = System.Drawing.Color.Black;
            this.materialLabel29.Location = new System.Drawing.Point(61, 301);
            this.materialLabel29.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel29.Name = "materialLabel29";
            this.materialLabel29.Size = new System.Drawing.Size(49, 19);
            this.materialLabel29.TabIndex = 62;
            this.materialLabel29.Text = "Precio:";
            // 
            // textBox28
            // 
            this.textBox28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox28.Location = new System.Drawing.Point(319, 224);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(212, 20);
            this.textBox28.TabIndex = 61;
            // 
            // materialLabel28
            // 
            this.materialLabel28.AutoSize = true;
            this.materialLabel28.BackColor = System.Drawing.Color.White;
            this.materialLabel28.Depth = 0;
            this.materialLabel28.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel28.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel28.ForeColor = System.Drawing.Color.Black;
            this.materialLabel28.Location = new System.Drawing.Point(235, 226);
            this.materialLabel28.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel28.Name = "materialLabel28";
            this.materialLabel28.Size = new System.Drawing.Size(88, 19);
            this.materialLabel28.TabIndex = 60;
            this.materialLabel28.Text = "Descripcion:";
            // 
            // textBox27
            // 
            this.textBox27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox27.Location = new System.Drawing.Point(821, 77);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(305, 20);
            this.textBox27.TabIndex = 59;
            this.textBox27.TextChanged += new System.EventHandler(this.textBox27_TextChanged);
            // 
            // materialLabel27
            // 
            this.materialLabel27.AutoSize = true;
            this.materialLabel27.Depth = 0;
            this.materialLabel27.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel27.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel27.Location = new System.Drawing.Point(726, 76);
            this.materialLabel27.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel27.Name = "materialLabel27";
            this.materialLabel27.Size = new System.Drawing.Size(76, 19);
            this.materialLabel27.TabIndex = 58;
            this.materialLabel27.Text = "Busqueda:";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(665, 69);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(55, 38);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox10.TabIndex = 57;
            this.pictureBox10.TabStop = false;
            // 
            // grid4
            // 
            this.grid4.AutoSizeTable = false;
            this.grid4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19});
            this.grid4.Depth = 0;
            this.grid4.FullRowSelect = true;
            this.grid4.HideSelection = false;
            this.grid4.Location = new System.Drawing.Point(623, 132);
            this.grid4.MinimumSize = new System.Drawing.Size(200, 100);
            this.grid4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.grid4.MouseState = MaterialSkin.MouseState.OUT;
            this.grid4.Name = "grid4";
            this.grid4.OwnerDraw = true;
            this.grid4.Size = new System.Drawing.Size(703, 317);
            this.grid4.TabIndex = 56;
            this.grid4.UseCompatibleStateImageBehavior = false;
            this.grid4.View = System.Windows.Forms.View.Details;
            this.grid4.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.grid4_ItemSelectionChanged);
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "ID";
            this.columnHeader16.Width = 76;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Descripcion";
            this.columnHeader17.Width = 172;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Precio";
            this.columnHeader18.Width = 140;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Tiempo de reparacion";
            this.columnHeader19.Width = 306;
            // 
            // textBox26
            // 
            this.textBox26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox26.Location = new System.Drawing.Point(116, 224);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(100, 20);
            this.textBox26.TabIndex = 55;
            // 
            // materialLabel26
            // 
            this.materialLabel26.AutoSize = true;
            this.materialLabel26.BackColor = System.Drawing.Color.White;
            this.materialLabel26.Depth = 0;
            this.materialLabel26.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel26.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel26.ForeColor = System.Drawing.Color.Black;
            this.materialLabel26.Location = new System.Drawing.Point(61, 226);
            this.materialLabel26.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel26.Name = "materialLabel26";
            this.materialLabel26.Size = new System.Drawing.Size(20, 19);
            this.materialLabel26.TabIndex = 54;
            this.materialLabel26.Text = "ID:";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(42, 47);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(74, 60);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 53;
            this.pictureBox9.TabStop = false;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.White;
            this.tabPage6.Controls.Add(this.dateTimePicker1);
            this.tabPage6.Controls.Add(this.materialComboBox1);
            this.tabPage6.Controls.Add(this.textBox34);
            this.tabPage6.Controls.Add(this.textBox33);
            this.tabPage6.Controls.Add(this.textBox32);
            this.tabPage6.Controls.Add(this.materialButton18);
            this.tabPage6.Controls.Add(this.materialButton17);
            this.tabPage6.Controls.Add(this.materialButton16);
            this.tabPage6.Controls.Add(this.textBox31);
            this.tabPage6.Controls.Add(this.materialLabel36);
            this.tabPage6.Controls.Add(this.pictureBox13);
            this.tabPage6.Controls.Add(this.grid5);
            this.tabPage6.Controls.Add(this.materialLabel35);
            this.tabPage6.Controls.Add(this.materialLabel34);
            this.tabPage6.Controls.Add(this.materialLabel33);
            this.tabPage6.Controls.Add(this.materialLabel32);
            this.tabPage6.Controls.Add(this.materialLabel31);
            this.tabPage6.Controls.Add(this.pictureBox11);
            this.tabPage6.Controls.Add(this.label7);
            this.tabPage6.Location = new System.Drawing.Point(4, 34);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1368, 545);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Orden de trabajo";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 338);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(193, 20);
            this.dateTimePicker1.TabIndex = 74;
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Items.AddRange(new object[] {
            "Pendiente",
            "En proceso",
            "Listo"});
            this.materialComboBox1.Location = new System.Drawing.Point(425, 261);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(175, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 73;
            // 
            // textBox34
            // 
            this.textBox34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox34.Location = new System.Drawing.Point(425, 338);
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(175, 20);
            this.textBox34.TabIndex = 72;
            // 
            // textBox33
            // 
            this.textBox33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox33.Location = new System.Drawing.Point(143, 277);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(115, 20);
            this.textBox33.TabIndex = 71;
            // 
            // textBox32
            // 
            this.textBox32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox32.Location = new System.Drawing.Point(143, 218);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(115, 20);
            this.textBox32.TabIndex = 70;
            // 
            // materialButton18
            // 
            this.materialButton18.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton18.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton18.Depth = 0;
            this.materialButton18.HighEmphasis = true;
            this.materialButton18.Icon = null;
            this.materialButton18.Location = new System.Drawing.Point(1038, 471);
            this.materialButton18.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton18.Name = "materialButton18";
            this.materialButton18.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton18.Size = new System.Drawing.Size(88, 36);
            this.materialButton18.TabIndex = 69;
            this.materialButton18.Text = "ELIMINAR";
            this.materialButton18.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton18.UseAccentColor = false;
            this.materialButton18.UseVisualStyleBackColor = true;
            this.materialButton18.Click += new System.EventHandler(this.materialButton18_Click);
            // 
            // materialButton17
            // 
            this.materialButton17.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton17.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton17.Depth = 0;
            this.materialButton17.HighEmphasis = true;
            this.materialButton17.Icon = null;
            this.materialButton17.Location = new System.Drawing.Point(821, 471);
            this.materialButton17.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton17.Name = "materialButton17";
            this.materialButton17.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton17.Size = new System.Drawing.Size(99, 36);
            this.materialButton17.TabIndex = 68;
            this.materialButton17.Text = "MODIFICAR";
            this.materialButton17.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton17.UseAccentColor = false;
            this.materialButton17.UseVisualStyleBackColor = true;
            this.materialButton17.Click += new System.EventHandler(this.materialButton17_Click);
            // 
            // materialButton16
            // 
            this.materialButton16.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton16.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton16.Depth = 0;
            this.materialButton16.HighEmphasis = true;
            this.materialButton16.Icon = null;
            this.materialButton16.Location = new System.Drawing.Point(263, 426);
            this.materialButton16.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton16.Name = "materialButton16";
            this.materialButton16.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton16.Size = new System.Drawing.Size(88, 36);
            this.materialButton16.TabIndex = 67;
            this.materialButton16.Text = "Agregar";
            this.materialButton16.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton16.UseAccentColor = false;
            this.materialButton16.UseVisualStyleBackColor = true;
            this.materialButton16.Click += new System.EventHandler(this.materialButton16_Click);
            // 
            // textBox31
            // 
            this.textBox31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox31.Location = new System.Drawing.Point(821, 77);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(305, 20);
            this.textBox31.TabIndex = 63;
            this.textBox31.TextChanged += new System.EventHandler(this.textBox31_TextChanged);
            // 
            // materialLabel36
            // 
            this.materialLabel36.AutoSize = true;
            this.materialLabel36.Depth = 0;
            this.materialLabel36.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel36.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel36.Location = new System.Drawing.Point(726, 76);
            this.materialLabel36.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel36.Name = "materialLabel36";
            this.materialLabel36.Size = new System.Drawing.Size(76, 19);
            this.materialLabel36.TabIndex = 62;
            this.materialLabel36.Text = "Busqueda:";
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(665, 69);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(55, 38);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox13.TabIndex = 61;
            this.pictureBox13.TabStop = false;
            // 
            // grid5
            // 
            this.grid5.AutoSizeTable = false;
            this.grid5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24});
            this.grid5.Depth = 0;
            this.grid5.FullRowSelect = true;
            this.grid5.HideSelection = false;
            this.grid5.Location = new System.Drawing.Point(623, 132);
            this.grid5.MinimumSize = new System.Drawing.Size(200, 100);
            this.grid5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.grid5.MouseState = MaterialSkin.MouseState.OUT;
            this.grid5.Name = "grid5";
            this.grid5.OwnerDraw = true;
            this.grid5.Size = new System.Drawing.Size(703, 317);
            this.grid5.TabIndex = 60;
            this.grid5.UseCompatibleStateImageBehavior = false;
            this.grid5.View = System.Windows.Forms.View.Details;
            this.grid5.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.grid5_ItemSelectionChanged);
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "ID";
            this.columnHeader20.Width = 76;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "ID Vehiculo";
            this.columnHeader21.Width = 172;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Fecha";
            this.columnHeader22.Width = 140;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Estado";
            this.columnHeader23.Width = 156;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Total";
            this.columnHeader24.Width = 146;
            // 
            // materialLabel35
            // 
            this.materialLabel35.AutoSize = true;
            this.materialLabel35.BackColor = System.Drawing.Color.White;
            this.materialLabel35.Depth = 0;
            this.materialLabel35.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel35.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel35.ForeColor = System.Drawing.Color.Black;
            this.materialLabel35.Location = new System.Drawing.Point(377, 339);
            this.materialLabel35.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel35.Name = "materialLabel35";
            this.materialLabel35.Size = new System.Drawing.Size(42, 19);
            this.materialLabel35.TabIndex = 59;
            this.materialLabel35.Text = "Total:";
            // 
            // materialLabel34
            // 
            this.materialLabel34.AutoSize = true;
            this.materialLabel34.BackColor = System.Drawing.Color.White;
            this.materialLabel34.Depth = 0;
            this.materialLabel34.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel34.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel34.ForeColor = System.Drawing.Color.Black;
            this.materialLabel34.Location = new System.Drawing.Point(365, 277);
            this.materialLabel34.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel34.Name = "materialLabel34";
            this.materialLabel34.Size = new System.Drawing.Size(54, 19);
            this.materialLabel34.TabIndex = 58;
            this.materialLabel34.Text = "Estado:";
            // 
            // materialLabel33
            // 
            this.materialLabel33.AutoSize = true;
            this.materialLabel33.BackColor = System.Drawing.Color.White;
            this.materialLabel33.Depth = 0;
            this.materialLabel33.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel33.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel33.ForeColor = System.Drawing.Color.Black;
            this.materialLabel33.Location = new System.Drawing.Point(54, 339);
            this.materialLabel33.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel33.Name = "materialLabel33";
            this.materialLabel33.Size = new System.Drawing.Size(48, 19);
            this.materialLabel33.TabIndex = 57;
            this.materialLabel33.Text = "Fecha:";
            // 
            // materialLabel32
            // 
            this.materialLabel32.AutoSize = true;
            this.materialLabel32.BackColor = System.Drawing.Color.White;
            this.materialLabel32.Depth = 0;
            this.materialLabel32.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel32.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel32.ForeColor = System.Drawing.Color.Black;
            this.materialLabel32.Location = new System.Drawing.Point(54, 277);
            this.materialLabel32.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel32.Name = "materialLabel32";
            this.materialLabel32.Size = new System.Drawing.Size(83, 19);
            this.materialLabel32.TabIndex = 56;
            this.materialLabel32.Text = "ID vehiculo:";
            // 
            // materialLabel31
            // 
            this.materialLabel31.AutoSize = true;
            this.materialLabel31.BackColor = System.Drawing.Color.White;
            this.materialLabel31.Depth = 0;
            this.materialLabel31.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel31.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel31.ForeColor = System.Drawing.Color.Black;
            this.materialLabel31.Location = new System.Drawing.Point(54, 219);
            this.materialLabel31.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel31.Name = "materialLabel31";
            this.materialLabel31.Size = new System.Drawing.Size(20, 19);
            this.materialLabel31.TabIndex = 55;
            this.materialLabel31.Text = "ID:";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(42, 48);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(74, 60);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 53;
            this.pictureBox11.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(122, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(273, 39);
            this.label7.TabIndex = 0;
            this.label7.Text = "Orden de Trabajo";
            // 
            // tabPage7
            // 
            this.tabPage7.AllowDrop = true;
            this.tabPage7.BackColor = System.Drawing.Color.White;
            this.tabPage7.Controls.Add(this.textBox37);
            this.tabPage7.Controls.Add(this.materialLabel41);
            this.tabPage7.Controls.Add(this.materialButton21);
            this.tabPage7.Controls.Add(this.materialButton20);
            this.tabPage7.Controls.Add(this.materialButton19);
            this.tabPage7.Controls.Add(this.comboBoxServicios);
            this.tabPage7.Controls.Add(this.textBox38);
            this.tabPage7.Controls.Add(this.textBox36);
            this.tabPage7.Controls.Add(this.materialLabel40);
            this.tabPage7.Controls.Add(this.materialLabel39);
            this.tabPage7.Controls.Add(this.materialLabel38);
            this.tabPage7.Controls.Add(this.textBox35);
            this.tabPage7.Controls.Add(this.materialLabel37);
            this.tabPage7.Controls.Add(this.pictureBox14);
            this.tabPage7.Controls.Add(this.grid6);
            this.tabPage7.Controls.Add(this.pictureBox12);
            this.tabPage7.Controls.Add(this.label6);
            this.tabPage7.Location = new System.Drawing.Point(4, 34);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1368, 545);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Detalle de Orden";
            // 
            // textBox37
            // 
            this.textBox37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox37.Location = new System.Drawing.Point(165, 234);
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(146, 20);
            this.textBox37.TabIndex = 80;
            // 
            // materialLabel41
            // 
            this.materialLabel41.AutoSize = true;
            this.materialLabel41.BackColor = System.Drawing.Color.White;
            this.materialLabel41.Depth = 0;
            this.materialLabel41.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel41.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel41.ForeColor = System.Drawing.Color.Black;
            this.materialLabel41.Location = new System.Drawing.Point(79, 235);
            this.materialLabel41.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel41.Name = "materialLabel41";
            this.materialLabel41.Size = new System.Drawing.Size(73, 19);
            this.materialLabel41.TabIndex = 79;
            this.materialLabel41.Text = "ID Detalle:";
            // 
            // materialButton21
            // 
            this.materialButton21.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton21.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton21.Depth = 0;
            this.materialButton21.HighEmphasis = true;
            this.materialButton21.Icon = null;
            this.materialButton21.Location = new System.Drawing.Point(1027, 470);
            this.materialButton21.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton21.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton21.Name = "materialButton21";
            this.materialButton21.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton21.Size = new System.Drawing.Size(88, 36);
            this.materialButton21.TabIndex = 78;
            this.materialButton21.Text = "ELIMINAR";
            this.materialButton21.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton21.UseAccentColor = false;
            this.materialButton21.UseVisualStyleBackColor = true;
            this.materialButton21.Click += new System.EventHandler(this.materialButton21_Click);
            // 
            // materialButton20
            // 
            this.materialButton20.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton20.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton20.Depth = 0;
            this.materialButton20.HighEmphasis = true;
            this.materialButton20.Icon = null;
            this.materialButton20.Location = new System.Drawing.Point(807, 470);
            this.materialButton20.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton20.Name = "materialButton20";
            this.materialButton20.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton20.Size = new System.Drawing.Size(99, 36);
            this.materialButton20.TabIndex = 77;
            this.materialButton20.Text = "MODIFICAR";
            this.materialButton20.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton20.UseAccentColor = false;
            this.materialButton20.UseVisualStyleBackColor = true;
            this.materialButton20.Click += new System.EventHandler(this.materialButton20_Click);
            // 
            // materialButton19
            // 
            this.materialButton19.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton19.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton19.Depth = 0;
            this.materialButton19.HighEmphasis = true;
            this.materialButton19.Icon = null;
            this.materialButton19.Location = new System.Drawing.Point(282, 459);
            this.materialButton19.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton19.Name = "materialButton19";
            this.materialButton19.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton19.Size = new System.Drawing.Size(88, 36);
            this.materialButton19.TabIndex = 76;
            this.materialButton19.Text = "Agregar";
            this.materialButton19.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton19.UseAccentColor = false;
            this.materialButton19.UseVisualStyleBackColor = true;
            this.materialButton19.Click += new System.EventHandler(this.materialButton19_Click);
            // 
            // comboBoxServicios
            // 
            this.comboBoxServicios.AutoResize = false;
            this.comboBoxServicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxServicios.Depth = 0;
            this.comboBoxServicios.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxServicios.DropDownHeight = 174;
            this.comboBoxServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxServicios.DropDownWidth = 121;
            this.comboBoxServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxServicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxServicios.FormattingEnabled = true;
            this.comboBoxServicios.IntegralHeight = false;
            this.comboBoxServicios.ItemHeight = 43;
            this.comboBoxServicios.Location = new System.Drawing.Point(165, 370);
            this.comboBoxServicios.MaxDropDownItems = 4;
            this.comboBoxServicios.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxServicios.Name = "comboBoxServicios";
            this.comboBoxServicios.Size = new System.Drawing.Size(335, 49);
            this.comboBoxServicios.StartIndex = 0;
            this.comboBoxServicios.TabIndex = 75;
            this.comboBoxServicios.SelectedIndexChanged += new System.EventHandler(this.comboBoxServicios_SelectedIndexChanged_1);
            // 
            // textBox38
            // 
            this.textBox38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox38.Location = new System.Drawing.Point(376, 234);
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(115, 20);
            this.textBox38.TabIndex = 73;
            // 
            // textBox36
            // 
            this.textBox36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox36.Location = new System.Drawing.Point(165, 303);
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(146, 20);
            this.textBox36.TabIndex = 71;
            // 
            // materialLabel40
            // 
            this.materialLabel40.AutoSize = true;
            this.materialLabel40.BackColor = System.Drawing.Color.White;
            this.materialLabel40.Depth = 0;
            this.materialLabel40.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel40.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel40.ForeColor = System.Drawing.Color.Black;
            this.materialLabel40.Location = new System.Drawing.Point(328, 235);
            this.materialLabel40.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel40.Name = "materialLabel40";
            this.materialLabel40.Size = new System.Drawing.Size(42, 19);
            this.materialLabel40.TabIndex = 67;
            this.materialLabel40.Text = "Total:";
            // 
            // materialLabel39
            // 
            this.materialLabel39.AutoSize = true;
            this.materialLabel39.BackColor = System.Drawing.Color.White;
            this.materialLabel39.Depth = 0;
            this.materialLabel39.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel39.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel39.ForeColor = System.Drawing.Color.Black;
            this.materialLabel39.Location = new System.Drawing.Point(79, 390);
            this.materialLabel39.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel39.Name = "materialLabel39";
            this.materialLabel39.Size = new System.Drawing.Size(61, 19);
            this.materialLabel39.TabIndex = 66;
            this.materialLabel39.Text = "Servicio:";
            // 
            // materialLabel38
            // 
            this.materialLabel38.AutoSize = true;
            this.materialLabel38.BackColor = System.Drawing.Color.White;
            this.materialLabel38.Depth = 0;
            this.materialLabel38.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel38.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel38.ForeColor = System.Drawing.Color.Black;
            this.materialLabel38.Location = new System.Drawing.Point(79, 304);
            this.materialLabel38.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel38.Name = "materialLabel38";
            this.materialLabel38.Size = new System.Drawing.Size(66, 19);
            this.materialLabel38.TabIndex = 65;
            this.materialLabel38.Text = "ID Orden:";
            // 
            // textBox35
            // 
            this.textBox35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox35.Location = new System.Drawing.Point(821, 77);
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(305, 20);
            this.textBox35.TabIndex = 64;
            this.textBox35.TextChanged += new System.EventHandler(this.textBox35_TextChanged);
            // 
            // materialLabel37
            // 
            this.materialLabel37.AutoSize = true;
            this.materialLabel37.Depth = 0;
            this.materialLabel37.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel37.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel37.Location = new System.Drawing.Point(726, 76);
            this.materialLabel37.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel37.Name = "materialLabel37";
            this.materialLabel37.Size = new System.Drawing.Size(76, 19);
            this.materialLabel37.TabIndex = 63;
            this.materialLabel37.Text = "Busqueda:";
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(665, 69);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(55, 38);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox14.TabIndex = 62;
            this.pictureBox14.TabStop = false;
            // 
            // grid6
            // 
            this.grid6.AutoSizeTable = false;
            this.grid6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid6.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader25,
            this.columnHeader26,
            this.columnHeader27,
            this.columnHeader29});
            this.grid6.Depth = 0;
            this.grid6.FullRowSelect = true;
            this.grid6.HideSelection = false;
            this.grid6.Location = new System.Drawing.Point(623, 132);
            this.grid6.MinimumSize = new System.Drawing.Size(200, 100);
            this.grid6.MouseLocation = new System.Drawing.Point(-1, -1);
            this.grid6.MouseState = MaterialSkin.MouseState.OUT;
            this.grid6.Name = "grid6";
            this.grid6.OwnerDraw = true;
            this.grid6.Size = new System.Drawing.Size(703, 317);
            this.grid6.TabIndex = 61;
            this.grid6.UseCompatibleStateImageBehavior = false;
            this.grid6.View = System.Windows.Forms.View.Details;
            this.grid6.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.grid6_ItemSelectionChanged);
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "ID Detalle";
            this.columnHeader25.Width = 103;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "ID Orden";
            this.columnHeader26.Width = 149;
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "Servicio/ID";
            this.columnHeader27.Width = 140;
            // 
            // columnHeader29
            // 
            this.columnHeader29.Text = "Total";
            this.columnHeader29.Width = 231;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(42, 46);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(74, 60);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 53;
            this.pictureBox12.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(122, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(425, 39);
            this.label6.TabIndex = 0;
            this.label6.Text = "Detalle de Orden de trabajo";
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.White;
            this.tabPage8.Controls.Add(this.materialButton24);
            this.tabPage8.Controls.Add(this.materialButton23);
            this.tabPage8.Controls.Add(this.materialButton22);
            this.tabPage8.Controls.Add(this.textBox42);
            this.tabPage8.Controls.Add(this.materialLabel46);
            this.tabPage8.Controls.Add(this.dateTimePicker2);
            this.tabPage8.Controls.Add(this.textBox41);
            this.tabPage8.Controls.Add(this.textBox40);
            this.tabPage8.Controls.Add(this.materialLabel45);
            this.tabPage8.Controls.Add(this.materialLabel44);
            this.tabPage8.Controls.Add(this.materialLabel43);
            this.tabPage8.Controls.Add(this.textBox39);
            this.tabPage8.Controls.Add(this.materialLabel42);
            this.tabPage8.Controls.Add(this.pictureBox17);
            this.tabPage8.Controls.Add(this.grid7);
            this.tabPage8.Controls.Add(this.label8);
            this.tabPage8.Controls.Add(this.pictureBox15);
            this.tabPage8.Location = new System.Drawing.Point(4, 34);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(1368, 545);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Facturacion";
            // 
            // materialButton24
            // 
            this.materialButton24.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton24.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton24.Depth = 0;
            this.materialButton24.HighEmphasis = true;
            this.materialButton24.Icon = null;
            this.materialButton24.Location = new System.Drawing.Point(855, 462);
            this.materialButton24.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton24.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton24.Name = "materialButton24";
            this.materialButton24.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton24.Size = new System.Drawing.Size(88, 36);
            this.materialButton24.TabIndex = 88;
            this.materialButton24.Text = "ELIMINAR";
            this.materialButton24.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton24.UseAccentColor = false;
            this.materialButton24.UseVisualStyleBackColor = true;
            this.materialButton24.Click += new System.EventHandler(this.materialButton24_Click);
            // 
            // materialButton23
            // 
            this.materialButton23.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton23.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton23.Depth = 0;
            this.materialButton23.HighEmphasis = true;
            this.materialButton23.Icon = null;
            this.materialButton23.Location = new System.Drawing.Point(414, 462);
            this.materialButton23.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton23.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton23.Name = "materialButton23";
            this.materialButton23.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton23.Size = new System.Drawing.Size(134, 36);
            this.materialButton23.TabIndex = 87;
            this.materialButton23.Text = "Generar EXCEL";
            this.materialButton23.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton23.UseAccentColor = false;
            this.materialButton23.UseVisualStyleBackColor = true;
            this.materialButton23.Click += new System.EventHandler(this.materialButton23_Click);
            // 
            // materialButton22
            // 
            this.materialButton22.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton22.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton22.Depth = 0;
            this.materialButton22.HighEmphasis = true;
            this.materialButton22.Icon = null;
            this.materialButton22.Location = new System.Drawing.Point(147, 462);
            this.materialButton22.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton22.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton22.Name = "materialButton22";
            this.materialButton22.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton22.Size = new System.Drawing.Size(118, 36);
            this.materialButton22.TabIndex = 86;
            this.materialButton22.Text = "Generar PDF";
            this.materialButton22.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton22.UseAccentColor = false;
            this.materialButton22.UseVisualStyleBackColor = true;
            this.materialButton22.Click += new System.EventHandler(this.materialButton22_Click);
            // 
            // textBox42
            // 
            this.textBox42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox42.Location = new System.Drawing.Point(181, 375);
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(112, 20);
            this.textBox42.TabIndex = 85;
            // 
            // materialLabel46
            // 
            this.materialLabel46.AutoSize = true;
            this.materialLabel46.BackColor = System.Drawing.Color.White;
            this.materialLabel46.Depth = 0;
            this.materialLabel46.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel46.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel46.ForeColor = System.Drawing.Color.Black;
            this.materialLabel46.Location = new System.Drawing.Point(68, 296);
            this.materialLabel46.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel46.Name = "materialLabel46";
            this.materialLabel46.Size = new System.Drawing.Size(78, 19);
            this.materialLabel46.TabIndex = 84;
            this.materialLabel46.Text = "ID Factura:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(393, 292);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(193, 20);
            this.dateTimePicker2.TabIndex = 83;
            // 
            // textBox41
            // 
            this.textBox41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox41.Location = new System.Drawing.Point(393, 375);
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(193, 20);
            this.textBox41.TabIndex = 82;
            // 
            // textBox40
            // 
            this.textBox40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox40.Location = new System.Drawing.Point(147, 291);
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(146, 20);
            this.textBox40.TabIndex = 81;
            // 
            // materialLabel45
            // 
            this.materialLabel45.AutoSize = true;
            this.materialLabel45.BackColor = System.Drawing.Color.White;
            this.materialLabel45.Depth = 0;
            this.materialLabel45.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel45.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel45.ForeColor = System.Drawing.Color.Black;
            this.materialLabel45.Location = new System.Drawing.Point(339, 377);
            this.materialLabel45.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel45.Name = "materialLabel45";
            this.materialLabel45.Size = new System.Drawing.Size(42, 19);
            this.materialLabel45.TabIndex = 68;
            this.materialLabel45.Text = "Total:";
            // 
            // materialLabel44
            // 
            this.materialLabel44.AutoSize = true;
            this.materialLabel44.BackColor = System.Drawing.Color.White;
            this.materialLabel44.Depth = 0;
            this.materialLabel44.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel44.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel44.ForeColor = System.Drawing.Color.Black;
            this.materialLabel44.Location = new System.Drawing.Point(339, 295);
            this.materialLabel44.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel44.Name = "materialLabel44";
            this.materialLabel44.Size = new System.Drawing.Size(48, 19);
            this.materialLabel44.TabIndex = 67;
            this.materialLabel44.Text = "Fecha:";
            // 
            // materialLabel43
            // 
            this.materialLabel43.AutoSize = true;
            this.materialLabel43.BackColor = System.Drawing.Color.White;
            this.materialLabel43.Depth = 0;
            this.materialLabel43.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel43.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel43.ForeColor = System.Drawing.Color.Black;
            this.materialLabel43.Location = new System.Drawing.Point(68, 375);
            this.materialLabel43.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel43.Name = "materialLabel43";
            this.materialLabel43.Size = new System.Drawing.Size(119, 19);
            this.materialLabel43.TabIndex = 66;
            this.materialLabel43.Text = "ID Detalle Orden:";
            // 
            // textBox39
            // 
            this.textBox39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox39.Location = new System.Drawing.Point(821, 77);
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(305, 20);
            this.textBox39.TabIndex = 65;
            this.textBox39.TextChanged += new System.EventHandler(this.textBox39_TextChanged);
            // 
            // materialLabel42
            // 
            this.materialLabel42.AutoSize = true;
            this.materialLabel42.Depth = 0;
            this.materialLabel42.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel42.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel42.Location = new System.Drawing.Point(726, 76);
            this.materialLabel42.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel42.Name = "materialLabel42";
            this.materialLabel42.Size = new System.Drawing.Size(76, 19);
            this.materialLabel42.TabIndex = 64;
            this.materialLabel42.Text = "Busqueda:";
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
            this.pictureBox17.Location = new System.Drawing.Point(665, 69);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(55, 38);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox17.TabIndex = 63;
            this.pictureBox17.TabStop = false;
            // 
            // grid7
            // 
            this.grid7.AutoSizeTable = false;
            this.grid7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid7.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader28,
            this.columnHeader30,
            this.columnHeader31,
            this.columnHeader32});
            this.grid7.Depth = 0;
            this.grid7.FullRowSelect = true;
            this.grid7.HideSelection = false;
            this.grid7.Location = new System.Drawing.Point(623, 132);
            this.grid7.MinimumSize = new System.Drawing.Size(200, 100);
            this.grid7.MouseLocation = new System.Drawing.Point(-1, -1);
            this.grid7.MouseState = MaterialSkin.MouseState.OUT;
            this.grid7.Name = "grid7";
            this.grid7.OwnerDraw = true;
            this.grid7.Size = new System.Drawing.Size(703, 317);
            this.grid7.TabIndex = 62;
            this.grid7.UseCompatibleStateImageBehavior = false;
            this.grid7.View = System.Windows.Forms.View.Details;
            this.grid7.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.grid7_ItemSelectionChanged);
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "ID Factura";
            this.columnHeader28.Width = 103;
            // 
            // columnHeader30
            // 
            this.columnHeader30.Text = "ID Detalle Orden";
            this.columnHeader30.Width = 164;
            // 
            // columnHeader31
            // 
            this.columnHeader31.Text = "Fecha";
            this.columnHeader31.Width = 140;
            // 
            // columnHeader32
            // 
            this.columnHeader32.Text = "Total";
            this.columnHeader32.Width = 231;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(140, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 39);
            this.label8.TabIndex = 55;
            this.label8.Text = "Facturacion";
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(42, 46);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(92, 76);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox15.TabIndex = 54;
            this.pictureBox15.TabStop = false;
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.Color.White;
            this.tabPage9.Controls.Add(this.textBox46);
            this.tabPage9.Controls.Add(this.materialLabel52);
            this.tabPage9.Controls.Add(this.materialButton26);
            this.tabPage9.Controls.Add(this.materialButton25);
            this.tabPage9.Controls.Add(this.textBox45);
            this.tabPage9.Controls.Add(this.textBox44);
            this.tabPage9.Controls.Add(this.materialComboBox2);
            this.tabPage9.Controls.Add(this.dateTimePicker3);
            this.tabPage9.Controls.Add(this.materialLabel51);
            this.tabPage9.Controls.Add(this.materialLabel50);
            this.tabPage9.Controls.Add(this.materialLabel49);
            this.tabPage9.Controls.Add(this.materialLabel48);
            this.tabPage9.Controls.Add(this.textBox43);
            this.tabPage9.Controls.Add(this.materialLabel47);
            this.tabPage9.Controls.Add(this.pictureBox18);
            this.tabPage9.Controls.Add(this.grid8);
            this.tabPage9.Controls.Add(this.label9);
            this.tabPage9.Controls.Add(this.pictureBox16);
            this.tabPage9.Location = new System.Drawing.Point(4, 34);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(1368, 545);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Ventas";
            // 
            // textBox46
            // 
            this.textBox46.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox46.Location = new System.Drawing.Point(127, 224);
            this.textBox46.Name = "textBox46";
            this.textBox46.Size = new System.Drawing.Size(146, 20);
            this.textBox46.TabIndex = 91;
            // 
            // materialLabel52
            // 
            this.materialLabel52.AutoSize = true;
            this.materialLabel52.Depth = 0;
            this.materialLabel52.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel52.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel52.Location = new System.Drawing.Point(51, 225);
            this.materialLabel52.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel52.Name = "materialLabel52";
            this.materialLabel52.Size = new System.Drawing.Size(73, 19);
            this.materialLabel52.TabIndex = 90;
            this.materialLabel52.Text = "ID Ventas:";
            // 
            // materialButton26
            // 
            this.materialButton26.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton26.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton26.Depth = 0;
            this.materialButton26.HighEmphasis = true;
            this.materialButton26.Icon = null;
            this.materialButton26.Location = new System.Drawing.Point(854, 488);
            this.materialButton26.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton26.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton26.Name = "materialButton26";
            this.materialButton26.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton26.Size = new System.Drawing.Size(88, 36);
            this.materialButton26.TabIndex = 89;
            this.materialButton26.Text = "ELIMINAR";
            this.materialButton26.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton26.UseAccentColor = false;
            this.materialButton26.UseVisualStyleBackColor = true;
            this.materialButton26.Click += new System.EventHandler(this.materialButton26_Click);
            // 
            // materialButton25
            // 
            this.materialButton25.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton25.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton25.Depth = 0;
            this.materialButton25.HighEmphasis = true;
            this.materialButton25.Icon = null;
            this.materialButton25.Location = new System.Drawing.Point(259, 488);
            this.materialButton25.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton25.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton25.Name = "materialButton25";
            this.materialButton25.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton25.Size = new System.Drawing.Size(88, 36);
            this.materialButton25.TabIndex = 88;
            this.materialButton25.Text = "AGREGAR";
            this.materialButton25.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton25.UseAccentColor = false;
            this.materialButton25.UseVisualStyleBackColor = true;
            this.materialButton25.Click += new System.EventHandler(this.materialButton25_Click);
            // 
            // textBox45
            // 
            this.textBox45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox45.Location = new System.Drawing.Point(127, 305);
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(146, 20);
            this.textBox45.TabIndex = 87;
            // 
            // textBox44
            // 
            this.textBox44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox44.Location = new System.Drawing.Point(371, 225);
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(146, 20);
            this.textBox44.TabIndex = 86;
            // 
            // materialComboBox2
            // 
            this.materialComboBox2.AutoResize = false;
            this.materialComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox2.Depth = 0;
            this.materialComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox2.DropDownHeight = 174;
            this.materialComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox2.DropDownWidth = 121;
            this.materialComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox2.FormattingEnabled = true;
            this.materialComboBox2.IntegralHeight = false;
            this.materialComboBox2.ItemHeight = 43;
            this.materialComboBox2.Items.AddRange(new object[] {
            "Selecciona",
            "Efectivo",
            "Tarjeta",
            "Transferencia"});
            this.materialComboBox2.Location = new System.Drawing.Point(177, 371);
            this.materialComboBox2.MaxDropDownItems = 4;
            this.materialComboBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox2.Name = "materialComboBox2";
            this.materialComboBox2.Size = new System.Drawing.Size(335, 49);
            this.materialComboBox2.StartIndex = 0;
            this.materialComboBox2.TabIndex = 85;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(371, 302);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(193, 20);
            this.dateTimePicker3.TabIndex = 84;
            // 
            // materialLabel51
            // 
            this.materialLabel51.AutoSize = true;
            this.materialLabel51.Depth = 0;
            this.materialLabel51.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel51.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel51.Location = new System.Drawing.Point(51, 388);
            this.materialLabel51.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel51.Name = "materialLabel51";
            this.materialLabel51.Size = new System.Drawing.Size(120, 19);
            this.materialLabel51.TabIndex = 70;
            this.materialLabel51.Text = "Metodo de pago:";
            // 
            // materialLabel50
            // 
            this.materialLabel50.AutoSize = true;
            this.materialLabel50.Depth = 0;
            this.materialLabel50.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel50.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel50.Location = new System.Drawing.Point(51, 306);
            this.materialLabel50.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel50.Name = "materialLabel50";
            this.materialLabel50.Size = new System.Drawing.Size(42, 19);
            this.materialLabel50.TabIndex = 69;
            this.materialLabel50.Text = "Total:";
            // 
            // materialLabel49
            // 
            this.materialLabel49.AutoSize = true;
            this.materialLabel49.Depth = 0;
            this.materialLabel49.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel49.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel49.Location = new System.Drawing.Point(299, 306);
            this.materialLabel49.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel49.Name = "materialLabel49";
            this.materialLabel49.Size = new System.Drawing.Size(48, 19);
            this.materialLabel49.TabIndex = 68;
            this.materialLabel49.Text = "Fecha:";
            // 
            // materialLabel48
            // 
            this.materialLabel48.AutoSize = true;
            this.materialLabel48.Depth = 0;
            this.materialLabel48.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel48.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel48.Location = new System.Drawing.Point(299, 225);
            this.materialLabel48.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel48.Name = "materialLabel48";
            this.materialLabel48.Size = new System.Drawing.Size(70, 19);
            this.materialLabel48.TabIndex = 67;
            this.materialLabel48.Text = "ID cliente:";
            // 
            // textBox43
            // 
            this.textBox43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox43.Location = new System.Drawing.Point(821, 77);
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(305, 20);
            this.textBox43.TabIndex = 66;
            this.textBox43.TextChanged += new System.EventHandler(this.textBox43_TextChanged);
            // 
            // materialLabel47
            // 
            this.materialLabel47.AutoSize = true;
            this.materialLabel47.Depth = 0;
            this.materialLabel47.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel47.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel47.Location = new System.Drawing.Point(726, 76);
            this.materialLabel47.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel47.Name = "materialLabel47";
            this.materialLabel47.Size = new System.Drawing.Size(76, 19);
            this.materialLabel47.TabIndex = 65;
            this.materialLabel47.Text = "Busqueda:";
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
            this.pictureBox18.Location = new System.Drawing.Point(665, 69);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(55, 38);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox18.TabIndex = 64;
            this.pictureBox18.TabStop = false;
            // 
            // grid8
            // 
            this.grid8.AutoSizeTable = false;
            this.grid8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid8.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader33,
            this.columnHeader34,
            this.columnHeader35,
            this.columnHeader36,
            this.columnHeader37});
            this.grid8.Depth = 0;
            this.grid8.FullRowSelect = true;
            this.grid8.HideSelection = false;
            this.grid8.Location = new System.Drawing.Point(623, 132);
            this.grid8.MinimumSize = new System.Drawing.Size(200, 100);
            this.grid8.MouseLocation = new System.Drawing.Point(-1, -1);
            this.grid8.MouseState = MaterialSkin.MouseState.OUT;
            this.grid8.Name = "grid8";
            this.grid8.OwnerDraw = true;
            this.grid8.Size = new System.Drawing.Size(703, 317);
            this.grid8.TabIndex = 63;
            this.grid8.UseCompatibleStateImageBehavior = false;
            this.grid8.View = System.Windows.Forms.View.Details;
            this.grid8.SelectedIndexChanged += new System.EventHandler(this.grid8_SelectedIndexChanged);
            // 
            // columnHeader33
            // 
            this.columnHeader33.Text = "ID Ventas";
            this.columnHeader33.Width = 103;
            // 
            // columnHeader34
            // 
            this.columnHeader34.Text = "ID Cliente";
            this.columnHeader34.Width = 149;
            // 
            // columnHeader35
            // 
            this.columnHeader35.Text = "Fecha";
            this.columnHeader35.Width = 140;
            // 
            // columnHeader36
            // 
            this.columnHeader36.Text = "Total";
            this.columnHeader36.Width = 105;
            // 
            // columnHeader37
            // 
            this.columnHeader37.Text = "Metodo de pago";
            this.columnHeader37.Width = 221;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(140, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 39);
            this.label9.TabIndex = 56;
            this.label9.Text = "Ventas";
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
            this.pictureBox16.Location = new System.Drawing.Point(42, 46);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(92, 76);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox16.TabIndex = 55;
            this.pictureBox16.TabStop = false;
            // 
            // tabPage10
            // 
            this.tabPage10.BackColor = System.Drawing.Color.White;
            this.tabPage10.Controls.Add(this.materialButton29);
            this.tabPage10.Controls.Add(this.materialButton28);
            this.tabPage10.Controls.Add(this.materialButton27);
            this.tabPage10.Controls.Add(this.materialComboBox3);
            this.tabPage10.Controls.Add(this.textBox54);
            this.tabPage10.Controls.Add(this.textBox53);
            this.tabPage10.Controls.Add(this.textBox52);
            this.tabPage10.Controls.Add(this.textBox50);
            this.tabPage10.Controls.Add(this.textBox49);
            this.tabPage10.Controls.Add(this.textBox48);
            this.tabPage10.Controls.Add(this.materialLabel60);
            this.tabPage10.Controls.Add(this.materialLabel59);
            this.tabPage10.Controls.Add(this.materialLabel58);
            this.tabPage10.Controls.Add(this.materialLabel57);
            this.tabPage10.Controls.Add(this.materialLabel56);
            this.tabPage10.Controls.Add(this.materialLabel55);
            this.tabPage10.Controls.Add(this.materialLabel54);
            this.tabPage10.Controls.Add(this.textBox47);
            this.tabPage10.Controls.Add(this.materialLabel53);
            this.tabPage10.Controls.Add(this.pictureBox20);
            this.tabPage10.Controls.Add(this.grid9);
            this.tabPage10.Controls.Add(this.label10);
            this.tabPage10.Controls.Add(this.pictureBox19);
            this.tabPage10.Location = new System.Drawing.Point(4, 34);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(1368, 545);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Text = "Detalles de Ventas";
            // 
            // materialButton29
            // 
            this.materialButton29.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton29.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton29.Depth = 0;
            this.materialButton29.HighEmphasis = true;
            this.materialButton29.Icon = null;
            this.materialButton29.Location = new System.Drawing.Point(953, 488);
            this.materialButton29.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton29.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton29.Name = "materialButton29";
            this.materialButton29.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton29.Size = new System.Drawing.Size(88, 36);
            this.materialButton29.TabIndex = 102;
            this.materialButton29.Text = "ELIMINAR";
            this.materialButton29.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton29.UseAccentColor = false;
            this.materialButton29.UseVisualStyleBackColor = true;
            this.materialButton29.Click += new System.EventHandler(this.materialButton29_Click);
            // 
            // materialButton28
            // 
            this.materialButton28.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton28.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton28.Depth = 0;
            this.materialButton28.HighEmphasis = true;
            this.materialButton28.Icon = null;
            this.materialButton28.Location = new System.Drawing.Point(729, 488);
            this.materialButton28.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton28.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton28.Name = "materialButton28";
            this.materialButton28.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton28.Size = new System.Drawing.Size(99, 36);
            this.materialButton28.TabIndex = 101;
            this.materialButton28.Text = "MODIFICAR";
            this.materialButton28.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton28.UseAccentColor = false;
            this.materialButton28.UseVisualStyleBackColor = true;
            this.materialButton28.Click += new System.EventHandler(this.materialButton28_Click);
            // 
            // materialButton27
            // 
            this.materialButton27.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton27.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton27.Depth = 0;
            this.materialButton27.HighEmphasis = true;
            this.materialButton27.Icon = null;
            this.materialButton27.Location = new System.Drawing.Point(227, 488);
            this.materialButton27.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton27.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton27.Name = "materialButton27";
            this.materialButton27.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton27.Size = new System.Drawing.Size(88, 36);
            this.materialButton27.TabIndex = 100;
            this.materialButton27.Text = "Agregar";
            this.materialButton27.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton27.UseAccentColor = false;
            this.materialButton27.UseVisualStyleBackColor = true;
            this.materialButton27.Click += new System.EventHandler(this.materialButton27_Click);
            // 
            // materialComboBox3
            // 
            this.materialComboBox3.AutoResize = false;
            this.materialComboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox3.Depth = 0;
            this.materialComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox3.DropDownHeight = 174;
            this.materialComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox3.DropDownWidth = 121;
            this.materialComboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox3.FormattingEnabled = true;
            this.materialComboBox3.IntegralHeight = false;
            this.materialComboBox3.ItemHeight = 43;
            this.materialComboBox3.Location = new System.Drawing.Point(108, 409);
            this.materialComboBox3.MaxDropDownItems = 4;
            this.materialComboBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox3.Name = "materialComboBox3";
            this.materialComboBox3.Size = new System.Drawing.Size(372, 49);
            this.materialComboBox3.StartIndex = 0;
            this.materialComboBox3.TabIndex = 99;
            this.materialComboBox3.SelectedIndexChanged += new System.EventHandler(this.materialComboBox3_SelectedIndexChanged);
            // 
            // textBox54
            // 
            this.textBox54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox54.Location = new System.Drawing.Point(307, 358);
            this.textBox54.Name = "textBox54";
            this.textBox54.Size = new System.Drawing.Size(173, 20);
            this.textBox54.TabIndex = 98;
            // 
            // textBox53
            // 
            this.textBox53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox53.Location = new System.Drawing.Point(363, 291);
            this.textBox53.Name = "textBox53";
            this.textBox53.Size = new System.Drawing.Size(117, 20);
            this.textBox53.TabIndex = 97;
            // 
            // textBox52
            // 
            this.textBox52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox52.Location = new System.Drawing.Point(334, 232);
            this.textBox52.Name = "textBox52";
            this.textBox52.Size = new System.Drawing.Size(146, 20);
            this.textBox52.TabIndex = 96;
            // 
            // textBox50
            // 
            this.textBox50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox50.Location = new System.Drawing.Point(108, 358);
            this.textBox50.Name = "textBox50";
            this.textBox50.Size = new System.Drawing.Size(103, 20);
            this.textBox50.TabIndex = 94;
            // 
            // textBox49
            // 
            this.textBox49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox49.Location = new System.Drawing.Point(108, 292);
            this.textBox49.Name = "textBox49";
            this.textBox49.Size = new System.Drawing.Size(103, 20);
            this.textBox49.TabIndex = 93;
            // 
            // textBox48
            // 
            this.textBox48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox48.Location = new System.Drawing.Point(65, 232);
            this.textBox48.Name = "textBox48";
            this.textBox48.Size = new System.Drawing.Size(146, 20);
            this.textBox48.TabIndex = 92;
            // 
            // materialLabel60
            // 
            this.materialLabel60.AutoSize = true;
            this.materialLabel60.Depth = 0;
            this.materialLabel60.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel60.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel60.Location = new System.Drawing.Point(259, 359);
            this.materialLabel60.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel60.Name = "materialLabel60";
            this.materialLabel60.Size = new System.Drawing.Size(42, 19);
            this.materialLabel60.TabIndex = 74;
            this.materialLabel60.Text = "Total:";
            // 
            // materialLabel59
            // 
            this.materialLabel59.AutoSize = true;
            this.materialLabel59.Depth = 0;
            this.materialLabel59.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel59.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel59.Location = new System.Drawing.Point(259, 292);
            this.materialLabel59.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel59.Name = "materialLabel59";
            this.materialLabel59.Size = new System.Drawing.Size(107, 19);
            this.materialLabel59.TabIndex = 73;
            this.materialLabel59.Text = "Precio unitario:";
            // 
            // materialLabel58
            // 
            this.materialLabel58.AutoSize = true;
            this.materialLabel58.Depth = 0;
            this.materialLabel58.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel58.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel58.Location = new System.Drawing.Point(259, 233);
            this.materialLabel58.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel58.Name = "materialLabel58";
            this.materialLabel58.Size = new System.Drawing.Size(69, 19);
            this.materialLabel58.TabIndex = 72;
            this.materialLabel58.Text = "Cantidad:";
            // 
            // materialLabel57
            // 
            this.materialLabel57.AutoSize = true;
            this.materialLabel57.Depth = 0;
            this.materialLabel57.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel57.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel57.Location = new System.Drawing.Point(39, 430);
            this.materialLabel57.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel57.Name = "materialLabel57";
            this.materialLabel57.Size = new System.Drawing.Size(61, 19);
            this.materialLabel57.TabIndex = 71;
            this.materialLabel57.Text = "Servicio:";
            // 
            // materialLabel56
            // 
            this.materialLabel56.AutoSize = true;
            this.materialLabel56.Depth = 0;
            this.materialLabel56.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel56.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel56.Location = new System.Drawing.Point(39, 359);
            this.materialLabel56.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel56.Name = "materialLabel56";
            this.materialLabel56.Size = new System.Drawing.Size(63, 19);
            this.materialLabel56.TabIndex = 70;
            this.materialLabel56.Text = "ID Pieza:";
            // 
            // materialLabel55
            // 
            this.materialLabel55.AutoSize = true;
            this.materialLabel55.Depth = 0;
            this.materialLabel55.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel55.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel55.Location = new System.Drawing.Point(39, 293);
            this.materialLabel55.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel55.Name = "materialLabel55";
            this.materialLabel55.Size = new System.Drawing.Size(63, 19);
            this.materialLabel55.TabIndex = 69;
            this.materialLabel55.Text = "ID venta:";
            // 
            // materialLabel54
            // 
            this.materialLabel54.AutoSize = true;
            this.materialLabel54.Depth = 0;
            this.materialLabel54.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel54.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel54.Location = new System.Drawing.Point(39, 233);
            this.materialLabel54.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel54.Name = "materialLabel54";
            this.materialLabel54.Size = new System.Drawing.Size(20, 19);
            this.materialLabel54.TabIndex = 68;
            this.materialLabel54.Text = "iD:";
            // 
            // textBox47
            // 
            this.textBox47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox47.Location = new System.Drawing.Point(821, 77);
            this.textBox47.Name = "textBox47";
            this.textBox47.Size = new System.Drawing.Size(305, 20);
            this.textBox47.TabIndex = 67;
            this.textBox47.TextChanged += new System.EventHandler(this.textBox47_TextChanged);
            // 
            // materialLabel53
            // 
            this.materialLabel53.AutoSize = true;
            this.materialLabel53.Depth = 0;
            this.materialLabel53.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel53.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel53.Location = new System.Drawing.Point(726, 76);
            this.materialLabel53.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel53.Name = "materialLabel53";
            this.materialLabel53.Size = new System.Drawing.Size(76, 19);
            this.materialLabel53.TabIndex = 66;
            this.materialLabel53.Text = "Busqueda:";
            // 
            // pictureBox20
            // 
            this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
            this.pictureBox20.Location = new System.Drawing.Point(665, 69);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(55, 38);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox20.TabIndex = 65;
            this.pictureBox20.TabStop = false;
            // 
            // grid9
            // 
            this.grid9.AutoSizeTable = false;
            this.grid9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid9.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader38,
            this.columnHeader39,
            this.columnHeader40,
            this.columnHeader41,
            this.columnHeader42,
            this.columnHeader43,
            this.columnHeader44});
            this.grid9.Depth = 0;
            this.grid9.FullRowSelect = true;
            this.grid9.HideSelection = false;
            this.grid9.Location = new System.Drawing.Point(623, 132);
            this.grid9.MinimumSize = new System.Drawing.Size(200, 100);
            this.grid9.MouseLocation = new System.Drawing.Point(-1, -1);
            this.grid9.MouseState = MaterialSkin.MouseState.OUT;
            this.grid9.Name = "grid9";
            this.grid9.OwnerDraw = true;
            this.grid9.Size = new System.Drawing.Size(703, 317);
            this.grid9.TabIndex = 64;
            this.grid9.UseCompatibleStateImageBehavior = false;
            this.grid9.View = System.Windows.Forms.View.Details;
            this.grid9.SelectedIndexChanged += new System.EventHandler(this.grid9_SelectedIndexChanged);
            // 
            // columnHeader38
            // 
            this.columnHeader38.Text = "ID";
            this.columnHeader38.Width = 59;
            // 
            // columnHeader39
            // 
            this.columnHeader39.Text = "ID Venta";
            this.columnHeader39.Width = 99;
            // 
            // columnHeader40
            // 
            this.columnHeader40.Text = "ID Pieza";
            this.columnHeader40.Width = 89;
            // 
            // columnHeader41
            // 
            this.columnHeader41.Text = "Servicio/ ID";
            this.columnHeader41.Width = 105;
            // 
            // columnHeader42
            // 
            this.columnHeader42.Text = "Cantidad";
            this.columnHeader42.Width = 99;
            // 
            // columnHeader43
            // 
            this.columnHeader43.Text = "Precio Unitario";
            this.columnHeader43.Width = 130;
            // 
            // columnHeader44
            // 
            this.columnHeader44.Text = "Total";
            this.columnHeader44.Width = 119;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(140, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(324, 39);
            this.label10.TabIndex = 57;
            this.label10.Text = "Detalle de las Ventas";
            // 
            // pictureBox19
            // 
            this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
            this.pictureBox19.Location = new System.Drawing.Point(42, 46);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(92, 76);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox19.TabIndex = 56;
            this.pictureBox19.TabStop = false;
            // 
            // tabPage11
            // 
            this.tabPage11.BackColor = System.Drawing.Color.White;
            this.tabPage11.Controls.Add(this.grid11);
            this.tabPage11.Controls.Add(this.label12);
            this.tabPage11.Controls.Add(this.pictureBox24);
            this.tabPage11.Controls.Add(this.materialLabel70);
            this.tabPage11.Controls.Add(this.pictureBox23);
            this.tabPage11.Controls.Add(this.textBox62);
            this.tabPage11.Location = new System.Drawing.Point(4, 34);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Size = new System.Drawing.Size(1368, 545);
            this.tabPage11.TabIndex = 10;
            this.tabPage11.Text = "Historial";
            // 
            // grid11
            // 
            this.grid11.AutoSizeTable = false;
            this.grid11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid11.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader53,
            this.columnHeader54,
            this.columnHeader55,
            this.columnHeader56,
            this.columnHeader57,
            this.columnHeader58,
            this.columnHeader59,
            this.columnHeader60});
            this.grid11.Depth = 0;
            this.grid11.FullRowSelect = true;
            this.grid11.HideSelection = false;
            this.grid11.Location = new System.Drawing.Point(91, 197);
            this.grid11.MinimumSize = new System.Drawing.Size(200, 100);
            this.grid11.MouseLocation = new System.Drawing.Point(-1, -1);
            this.grid11.MouseState = MaterialSkin.MouseState.OUT;
            this.grid11.Name = "grid11";
            this.grid11.OwnerDraw = true;
            this.grid11.Size = new System.Drawing.Size(1197, 317);
            this.grid11.TabIndex = 65;
            this.grid11.UseCompatibleStateImageBehavior = false;
            this.grid11.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader53
            // 
            this.columnHeader53.Text = "ID";
            this.columnHeader53.Width = 59;
            // 
            // columnHeader54
            // 
            this.columnHeader54.Text = "Tabla Modificada";
            this.columnHeader54.Width = 172;
            // 
            // columnHeader55
            // 
            this.columnHeader55.Text = "# De Registro";
            this.columnHeader55.Width = 145;
            // 
            // columnHeader56
            // 
            this.columnHeader56.Text = "Tipo de Operacion";
            this.columnHeader56.Width = 172;
            // 
            // columnHeader57
            // 
            this.columnHeader57.Text = "Usuario";
            this.columnHeader57.Width = 124;
            // 
            // columnHeader58
            // 
            this.columnHeader58.Text = "Fecha";
            this.columnHeader58.Width = 112;
            // 
            // columnHeader59
            // 
            this.columnHeader59.Text = "Valores Anteriores";
            this.columnHeader59.Width = 197;
            // 
            // columnHeader60
            // 
            this.columnHeader60.Text = "Valores Nuevos";
            this.columnHeader60.Width = 213;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(127, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(322, 39);
            this.label12.TabIndex = 58;
            this.label12.Text = "Historial de Cambios";
            // 
            // pictureBox24
            // 
            this.pictureBox24.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox24.Image")));
            this.pictureBox24.Location = new System.Drawing.Point(29, 24);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(92, 76);
            this.pictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox24.TabIndex = 57;
            this.pictureBox24.TabStop = false;
            // 
            // materialLabel70
            // 
            this.materialLabel70.AutoSize = true;
            this.materialLabel70.Depth = 0;
            this.materialLabel70.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel70.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel70.Location = new System.Drawing.Point(510, 131);
            this.materialLabel70.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel70.Name = "materialLabel70";
            this.materialLabel70.Size = new System.Drawing.Size(76, 19);
            this.materialLabel70.TabIndex = 19;
            this.materialLabel70.Text = "Busqueda:";
            // 
            // pictureBox23
            // 
            this.pictureBox23.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox23.Image")));
            this.pictureBox23.Location = new System.Drawing.Point(449, 124);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(55, 38);
            this.pictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox23.TabIndex = 18;
            this.pictureBox23.TabStop = false;
            // 
            // textBox62
            // 
            this.textBox62.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox62.Location = new System.Drawing.Point(592, 130);
            this.textBox62.Name = "textBox62";
            this.textBox62.Size = new System.Drawing.Size(305, 20);
            this.textBox62.TabIndex = 17;
            this.textBox62.TextChanged += new System.EventHandler(this.textBox62_TextChanged);
            // 
            // tabPage12
            // 
            this.tabPage12.BackColor = System.Drawing.Color.White;
            this.tabPage12.Controls.Add(this.textBox57);
            this.tabPage12.Controls.Add(this.materialButton32);
            this.tabPage12.Controls.Add(this.materialButton31);
            this.tabPage12.Controls.Add(this.materialButton30);
            this.tabPage12.Controls.Add(this.materialComboBox4);
            this.tabPage12.Controls.Add(this.textBox61);
            this.tabPage12.Controls.Add(this.textBox60);
            this.tabPage12.Controls.Add(this.textBox59);
            this.tabPage12.Controls.Add(this.textBox58);
            this.tabPage12.Controls.Add(this.textBox56);
            this.tabPage12.Controls.Add(this.textBox55);
            this.tabPage12.Controls.Add(this.grid10);
            this.tabPage12.Controls.Add(this.textBox51);
            this.tabPage12.Controls.Add(this.materialLabel69);
            this.tabPage12.Controls.Add(this.pictureBox22);
            this.tabPage12.Controls.Add(this.materialLabel68);
            this.tabPage12.Controls.Add(this.materialLabel67);
            this.tabPage12.Controls.Add(this.materialLabel66);
            this.tabPage12.Controls.Add(this.materialLabel65);
            this.tabPage12.Controls.Add(this.materialLabel64);
            this.tabPage12.Controls.Add(this.materialLabel63);
            this.tabPage12.Controls.Add(this.materialLabel62);
            this.tabPage12.Controls.Add(this.materialLabel61);
            this.tabPage12.Controls.Add(this.pictureBox21);
            this.tabPage12.Controls.Add(this.label11);
            this.tabPage12.Location = new System.Drawing.Point(4, 34);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Size = new System.Drawing.Size(1368, 545);
            this.tabPage12.TabIndex = 11;
            this.tabPage12.Text = "Usuarios";
            // 
            // textBox57
            // 
            this.textBox57.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox57.Location = new System.Drawing.Point(162, 323);
            this.textBox57.Name = "textBox57";
            this.textBox57.Size = new System.Drawing.Size(150, 20);
            this.textBox57.TabIndex = 104;
            // 
            // materialButton32
            // 
            this.materialButton32.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton32.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton32.Depth = 0;
            this.materialButton32.HighEmphasis = true;
            this.materialButton32.Icon = null;
            this.materialButton32.Location = new System.Drawing.Point(1025, 468);
            this.materialButton32.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton32.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton32.Name = "materialButton32";
            this.materialButton32.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton32.Size = new System.Drawing.Size(88, 36);
            this.materialButton32.TabIndex = 103;
            this.materialButton32.Text = "ELIMINAR";
            this.materialButton32.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton32.UseAccentColor = false;
            this.materialButton32.UseVisualStyleBackColor = true;
            this.materialButton32.Click += new System.EventHandler(this.materialButton32_Click);
            // 
            // materialButton31
            // 
            this.materialButton31.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton31.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton31.Depth = 0;
            this.materialButton31.HighEmphasis = true;
            this.materialButton31.Icon = null;
            this.materialButton31.Location = new System.Drawing.Point(766, 468);
            this.materialButton31.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton31.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton31.Name = "materialButton31";
            this.materialButton31.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton31.Size = new System.Drawing.Size(99, 36);
            this.materialButton31.TabIndex = 102;
            this.materialButton31.Text = "MODIFICAR";
            this.materialButton31.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton31.UseAccentColor = false;
            this.materialButton31.UseVisualStyleBackColor = true;
            this.materialButton31.Click += new System.EventHandler(this.materialButton31_Click);
            // 
            // materialButton30
            // 
            this.materialButton30.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton30.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton30.Depth = 0;
            this.materialButton30.HighEmphasis = true;
            this.materialButton30.Icon = null;
            this.materialButton30.Location = new System.Drawing.Point(264, 468);
            this.materialButton30.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton30.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton30.Name = "materialButton30";
            this.materialButton30.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton30.Size = new System.Drawing.Size(88, 36);
            this.materialButton30.TabIndex = 101;
            this.materialButton30.Text = "Agregar";
            this.materialButton30.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton30.UseAccentColor = false;
            this.materialButton30.UseVisualStyleBackColor = true;
            this.materialButton30.Click += new System.EventHandler(this.materialButton30_Click);
            // 
            // materialComboBox4
            // 
            this.materialComboBox4.AutoResize = false;
            this.materialComboBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox4.Depth = 0;
            this.materialComboBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox4.DropDownHeight = 174;
            this.materialComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox4.DropDownWidth = 121;
            this.materialComboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox4.FormattingEnabled = true;
            this.materialComboBox4.IntegralHeight = false;
            this.materialComboBox4.ItemHeight = 43;
            this.materialComboBox4.Items.AddRange(new object[] {
            "Selecciona",
            "Administrador",
            "Mecanico",
            "Asistente"});
            this.materialComboBox4.Location = new System.Drawing.Point(399, 362);
            this.materialComboBox4.MaxDropDownItems = 4;
            this.materialComboBox4.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox4.Name = "materialComboBox4";
            this.materialComboBox4.Size = new System.Drawing.Size(180, 49);
            this.materialComboBox4.StartIndex = 0;
            this.materialComboBox4.TabIndex = 100;
            // 
            // textBox61
            // 
            this.textBox61.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox61.Location = new System.Drawing.Point(399, 323);
            this.textBox61.Name = "textBox61";
            this.textBox61.Size = new System.Drawing.Size(180, 20);
            this.textBox61.TabIndex = 99;
            // 
            // textBox60
            // 
            this.textBox60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox60.Location = new System.Drawing.Point(399, 268);
            this.textBox60.Name = "textBox60";
            this.textBox60.Size = new System.Drawing.Size(180, 20);
            this.textBox60.TabIndex = 98;
            // 
            // textBox59
            // 
            this.textBox59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox59.Location = new System.Drawing.Point(399, 218);
            this.textBox59.Name = "textBox59";
            this.textBox59.Size = new System.Drawing.Size(180, 20);
            this.textBox59.TabIndex = 97;
            // 
            // textBox58
            // 
            this.textBox58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox58.Location = new System.Drawing.Point(126, 376);
            this.textBox58.Name = "textBox58";
            this.textBox58.Size = new System.Drawing.Size(186, 20);
            this.textBox58.TabIndex = 96;
            // 
            // textBox56
            // 
            this.textBox56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox56.Location = new System.Drawing.Point(198, 267);
            this.textBox56.Name = "textBox56";
            this.textBox56.Size = new System.Drawing.Size(114, 20);
            this.textBox56.TabIndex = 94;
            // 
            // textBox55
            // 
            this.textBox55.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox55.Location = new System.Drawing.Point(96, 218);
            this.textBox55.Name = "textBox55";
            this.textBox55.Size = new System.Drawing.Size(98, 20);
            this.textBox55.TabIndex = 93;
            // 
            // grid10
            // 
            this.grid10.AutoSizeTable = false;
            this.grid10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid10.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader45,
            this.columnHeader46,
            this.columnHeader47,
            this.columnHeader48,
            this.columnHeader49,
            this.columnHeader50,
            this.columnHeader51,
            this.columnHeader52});
            this.grid10.Depth = 0;
            this.grid10.FullRowSelect = true;
            this.grid10.HideSelection = false;
            this.grid10.Location = new System.Drawing.Point(625, 135);
            this.grid10.MinimumSize = new System.Drawing.Size(200, 100);
            this.grid10.MouseLocation = new System.Drawing.Point(-1, -1);
            this.grid10.MouseState = MaterialSkin.MouseState.OUT;
            this.grid10.Name = "grid10";
            this.grid10.OwnerDraw = true;
            this.grid10.Size = new System.Drawing.Size(703, 317);
            this.grid10.TabIndex = 80;
            this.grid10.UseCompatibleStateImageBehavior = false;
            this.grid10.View = System.Windows.Forms.View.Details;
            this.grid10.SelectedIndexChanged += new System.EventHandler(this.grid10_SelectedIndexChanged);
            // 
            // columnHeader45
            // 
            this.columnHeader45.Text = "ID";
            this.columnHeader45.Width = 59;
            // 
            // columnHeader46
            // 
            this.columnHeader46.Text = "User";
            this.columnHeader46.Width = 84;
            // 
            // columnHeader47
            // 
            this.columnHeader47.Text = "Contraseña";
            this.columnHeader47.Width = 114;
            // 
            // columnHeader48
            // 
            this.columnHeader48.Text = "Nombre";
            this.columnHeader48.Width = 105;
            // 
            // columnHeader49
            // 
            this.columnHeader49.Text = "Apellido";
            this.columnHeader49.Width = 99;
            // 
            // columnHeader50
            // 
            this.columnHeader50.Text = "Correo";
            this.columnHeader50.Width = 130;
            // 
            // columnHeader51
            // 
            this.columnHeader51.Text = "Telefono";
            this.columnHeader51.Width = 119;
            // 
            // columnHeader52
            // 
            this.columnHeader52.Text = "Rol";
            // 
            // textBox51
            // 
            this.textBox51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.textBox51.Location = new System.Drawing.Point(824, 75);
            this.textBox51.Name = "textBox51";
            this.textBox51.Size = new System.Drawing.Size(305, 20);
            this.textBox51.TabIndex = 79;
            this.textBox51.TextChanged += new System.EventHandler(this.textBox51_TextChanged);
            // 
            // materialLabel69
            // 
            this.materialLabel69.AutoSize = true;
            this.materialLabel69.Depth = 0;
            this.materialLabel69.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel69.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel69.Location = new System.Drawing.Point(729, 74);
            this.materialLabel69.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel69.Name = "materialLabel69";
            this.materialLabel69.Size = new System.Drawing.Size(76, 19);
            this.materialLabel69.TabIndex = 78;
            this.materialLabel69.Text = "Busqueda:";
            // 
            // pictureBox22
            // 
            this.pictureBox22.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox22.Image")));
            this.pictureBox22.Location = new System.Drawing.Point(668, 67);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(55, 38);
            this.pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox22.TabIndex = 77;
            this.pictureBox22.TabStop = false;
            // 
            // materialLabel68
            // 
            this.materialLabel68.AutoSize = true;
            this.materialLabel68.Depth = 0;
            this.materialLabel68.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel68.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel68.Location = new System.Drawing.Point(342, 377);
            this.materialLabel68.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel68.Name = "materialLabel68";
            this.materialLabel68.Size = new System.Drawing.Size(28, 19);
            this.materialLabel68.TabIndex = 76;
            this.materialLabel68.Text = "Rol:";
            // 
            // materialLabel67
            // 
            this.materialLabel67.AutoSize = true;
            this.materialLabel67.Depth = 0;
            this.materialLabel67.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel67.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel67.Location = new System.Drawing.Point(342, 323);
            this.materialLabel67.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel67.Name = "materialLabel67";
            this.materialLabel67.Size = new System.Drawing.Size(68, 19);
            this.materialLabel67.TabIndex = 75;
            this.materialLabel67.Text = "Telefono:";
            // 
            // materialLabel66
            // 
            this.materialLabel66.AutoSize = true;
            this.materialLabel66.Depth = 0;
            this.materialLabel66.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel66.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel66.Location = new System.Drawing.Point(342, 268);
            this.materialLabel66.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel66.Name = "materialLabel66";
            this.materialLabel66.Size = new System.Drawing.Size(51, 19);
            this.materialLabel66.TabIndex = 74;
            this.materialLabel66.Text = "Correo:";
            // 
            // materialLabel65
            // 
            this.materialLabel65.AutoSize = true;
            this.materialLabel65.Depth = 0;
            this.materialLabel65.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel65.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel65.Location = new System.Drawing.Point(70, 323);
            this.materialLabel65.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel65.Name = "materialLabel65";
            this.materialLabel65.Size = new System.Drawing.Size(86, 19);
            this.materialLabel65.TabIndex = 73;
            this.materialLabel65.Text = "Contraseña:";
            // 
            // materialLabel64
            // 
            this.materialLabel64.AutoSize = true;
            this.materialLabel64.Depth = 0;
            this.materialLabel64.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel64.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel64.Location = new System.Drawing.Point(342, 219);
            this.materialLabel64.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel64.Name = "materialLabel64";
            this.materialLabel64.Size = new System.Drawing.Size(62, 19);
            this.materialLabel64.TabIndex = 72;
            this.materialLabel64.Text = "Apellido:";
            // 
            // materialLabel63
            // 
            this.materialLabel63.AutoSize = true;
            this.materialLabel63.Depth = 0;
            this.materialLabel63.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel63.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel63.Location = new System.Drawing.Point(70, 377);
            this.materialLabel63.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel63.Name = "materialLabel63";
            this.materialLabel63.Size = new System.Drawing.Size(61, 19);
            this.materialLabel63.TabIndex = 71;
            this.materialLabel63.Text = "Nombre:";
            // 
            // materialLabel62
            // 
            this.materialLabel62.AutoSize = true;
            this.materialLabel62.Depth = 0;
            this.materialLabel62.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel62.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel62.Location = new System.Drawing.Point(70, 268);
            this.materialLabel62.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel62.Name = "materialLabel62";
            this.materialLabel62.Size = new System.Drawing.Size(139, 19);
            this.materialLabel62.TabIndex = 70;
            this.materialLabel62.Text = "Nombre de usuario:";
            // 
            // materialLabel61
            // 
            this.materialLabel61.AutoSize = true;
            this.materialLabel61.Depth = 0;
            this.materialLabel61.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel61.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel61.Location = new System.Drawing.Point(70, 219);
            this.materialLabel61.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel61.Name = "materialLabel61";
            this.materialLabel61.Size = new System.Drawing.Size(20, 19);
            this.materialLabel61.TabIndex = 69;
            this.materialLabel61.Text = "iD:";
            // 
            // pictureBox21
            // 
            this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
            this.pictureBox21.Location = new System.Drawing.Point(42, 46);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(92, 76);
            this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox21.TabIndex = 59;
            this.pictureBox21.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(140, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(310, 39);
            this.label11.TabIndex = 58;
            this.label11.Text = "Gestion de Usuarios";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(59)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(1383, 662);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Form2";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            this.tabPage11.ResumeLayout(false);
            this.tabPage11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            this.tabPage12.ResumeLayout(false);
            this.tabPage12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
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
        private TextBox textBox21;
        private MaterialLabel materialLabel21;
        private PictureBox pictureBox4;
        private MaterialListView grid3;
        private ColumnHeader columnHeader11;
        internal ColumnHeader columnHeader12;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private MaterialLabel materialLabel25;
        private MaterialLabel materialLabel24;
        private MaterialLabel materialLabel23;
        private MaterialLabel materialLabel22;
        private TextBox textBox25;
        private TextBox textBox24;
        private TextBox textBox23;
        private TextBox textBox22;
        private MaterialButton materialButton12;
        private MaterialButton materialButton11;
        private MaterialButton materialButton10;
        private TabPage tabPage11;
        private TabPage tabPage12;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private MaterialListView grid4;
        private ColumnHeader columnHeader16;
        internal ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader19;
        private TextBox textBox26;
        private MaterialLabel materialLabel26;
        private TextBox textBox27;
        private MaterialLabel materialLabel27;
        private PictureBox pictureBox10;
        private MaterialLabel materialLabel30;
        private TextBox textBox30;
        private TextBox textBox29;
        private MaterialLabel materialLabel29;
        private TextBox textBox28;
        private MaterialLabel materialLabel28;
        private MaterialButton materialButton15;
        private MaterialButton materialButton14;
        private MaterialButton materialButton13;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label6;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private MaterialListView grid5;
        private ColumnHeader columnHeader20;
        internal ColumnHeader columnHeader21;
        private ColumnHeader columnHeader22;
        private ColumnHeader columnHeader23;
        private ColumnHeader columnHeader24;
        private MaterialLabel materialLabel35;
        private MaterialLabel materialLabel34;
        private MaterialLabel materialLabel33;
        private MaterialLabel materialLabel32;
        private MaterialLabel materialLabel31;
        private MaterialButton materialButton18;
        private MaterialButton materialButton17;
        private MaterialButton materialButton16;
        private TextBox textBox31;
        private MaterialLabel materialLabel36;
        private PictureBox pictureBox13;
        private MaterialComboBox materialComboBox1;
        private TextBox textBox34;
        private TextBox textBox33;
        private TextBox textBox32;
        private DateTimePicker dateTimePicker1;
        private MaterialListView grid6;
        private ColumnHeader columnHeader25;
        internal ColumnHeader columnHeader26;
        private ColumnHeader columnHeader27;
        private TextBox textBox35;
        private MaterialLabel materialLabel37;
        private PictureBox pictureBox14;
        private MaterialLabel materialLabel38;
        private MaterialButton materialButton21;
        private MaterialButton materialButton20;
        private MaterialButton materialButton19;
        private MaterialComboBox comboBoxServicios;
        private TextBox textBox38;
        private TextBox textBox36;
        private MaterialLabel materialLabel40;
        private MaterialLabel materialLabel39;
        private TextBox textBox37;
        private MaterialLabel materialLabel41;
        private ColumnHeader columnHeader29;
        private Label label8;
        private PictureBox pictureBox15;
        private Label label9;
        private PictureBox pictureBox16;
        private TextBox textBox39;
        private MaterialLabel materialLabel42;
        private PictureBox pictureBox17;
        private MaterialListView grid7;
        private ColumnHeader columnHeader28;
        internal ColumnHeader columnHeader30;
        private ColumnHeader columnHeader31;
        private ColumnHeader columnHeader32;
        private TextBox textBox41;
        private TextBox textBox40;
        private MaterialLabel materialLabel45;
        private MaterialLabel materialLabel44;
        private MaterialLabel materialLabel43;
        private TextBox textBox42;
        private MaterialLabel materialLabel46;
        private DateTimePicker dateTimePicker2;
        private MaterialButton materialButton22;
        private MaterialButton materialButton23;
        private MaterialButton materialButton24;
        private TextBox textBox43;
        private MaterialLabel materialLabel47;
        private PictureBox pictureBox18;
        private MaterialListView grid8;
        private ColumnHeader columnHeader33;
        internal ColumnHeader columnHeader34;
        private ColumnHeader columnHeader35;
        private ColumnHeader columnHeader36;
        private MaterialLabel materialLabel48;
        private TextBox textBox45;
        private TextBox textBox44;
        private MaterialComboBox materialComboBox2;
        private DateTimePicker dateTimePicker3;
        private MaterialLabel materialLabel51;
        private MaterialLabel materialLabel50;
        private MaterialLabel materialLabel49;
        private MaterialButton materialButton26;
        private MaterialButton materialButton25;
        private ColumnHeader columnHeader37;
        private TextBox textBox46;
        private MaterialLabel materialLabel52;
        private Label label10;
        private PictureBox pictureBox19;
        private MaterialListView grid9;
        private ColumnHeader columnHeader38;
        internal ColumnHeader columnHeader39;
        private ColumnHeader columnHeader40;
        private ColumnHeader columnHeader41;
        private ColumnHeader columnHeader42;
        private TextBox textBox47;
        private MaterialLabel materialLabel53;
        private PictureBox pictureBox20;
        private MaterialLabel materialLabel60;
        private MaterialLabel materialLabel59;
        private MaterialLabel materialLabel58;
        private MaterialLabel materialLabel57;
        private MaterialLabel materialLabel56;
        private MaterialLabel materialLabel55;
        private MaterialLabel materialLabel54;
        private ColumnHeader columnHeader43;
        private ColumnHeader columnHeader44;
        private TextBox textBox54;
        private TextBox textBox53;
        private TextBox textBox52;
        private TextBox textBox50;
        private TextBox textBox49;
        private TextBox textBox48;
        private MaterialButton materialButton29;
        private MaterialButton materialButton28;
        private MaterialButton materialButton27;
        private MaterialComboBox materialComboBox3;
        private MaterialLabel materialLabel62;
        private MaterialLabel materialLabel61;
        private PictureBox pictureBox21;
        private Label label11;
        private MaterialLabel materialLabel67;
        private MaterialLabel materialLabel66;
        private MaterialLabel materialLabel65;
        private MaterialLabel materialLabel64;
        private MaterialLabel materialLabel63;
        private MaterialListView grid10;
        private ColumnHeader columnHeader45;
        internal ColumnHeader columnHeader46;
        private ColumnHeader columnHeader47;
        private ColumnHeader columnHeader48;
        private ColumnHeader columnHeader49;
        private ColumnHeader columnHeader50;
        private ColumnHeader columnHeader51;
        private TextBox textBox51;
        private MaterialLabel materialLabel69;
        private PictureBox pictureBox22;
        private MaterialLabel materialLabel68;
        private TextBox textBox56;
        private TextBox textBox55;
        private MaterialComboBox materialComboBox4;
        private TextBox textBox61;
        private TextBox textBox60;
        private TextBox textBox59;
        private TextBox textBox58;
        private MaterialButton materialButton31;
        private MaterialButton materialButton30;
        private MaterialButton materialButton32;
        private ColumnHeader columnHeader52;
        private TextBox textBox57;
        private Label label12;
        private PictureBox pictureBox24;
        private MaterialLabel materialLabel70;
        private PictureBox pictureBox23;
        private TextBox textBox62;
        private MaterialListView grid11;
        private ColumnHeader columnHeader53;
        internal ColumnHeader columnHeader54;
        private ColumnHeader columnHeader55;
        private ColumnHeader columnHeader56;
        private ColumnHeader columnHeader57;
        private ColumnHeader columnHeader58;
        private ColumnHeader columnHeader59;
        private ColumnHeader columnHeader60;
    }
}