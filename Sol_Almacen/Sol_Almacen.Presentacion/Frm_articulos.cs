﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_Almacen.Presentacion
{
    public partial class Frm_articulos : Form
    {
        public Frm_articulos()
        {
            InitializeComponent();
        }
        #region "Mis métodos"
              

        private void Formato_ar()
        {
            Dgv_articulos.Columns[0].Width = 80;
            Dgv_articulos.Columns[0].HeaderText = "CÓDIGO";
            Dgv_articulos.Columns[1].Width = 250;
            Dgv_articulos.Columns[1].HeaderText = "ARTÍCULO";
            Dgv_articulos.Columns[2].Width = 150;
            Dgv_articulos.Columns[2].HeaderText = "MARCA";
            Dgv_articulos.Columns[3].Width = 80;
            Dgv_articulos.Columns[3].HeaderText = "MEDIDA";
            Dgv_articulos.Columns[4].Width = 150;
            Dgv_articulos.Columns[4].HeaderText = "CATEGORÍA";
            Dgv_articulos.Columns[5].Width = 150;
            Dgv_articulos.Columns[5].HeaderText = "STOCK ACTUAL";
            Dgv_articulos.Columns[6].Visible = false;   
            Dgv_articulos.Columns[7].Visible = false;
        }

        private void Listado_ar(string cTexto)
        {
            D_Articulos Datos = new D_Articulos();
            Dgv_articulos.DataSource = Datos.Listado_ar(cTexto);
            this.Formato_ar();
        }

        #endregion

        private void Frm_articulos_Load(object sender, EventArgs e)
        {
            this.Listado_ar("%");
        }
    }
}
