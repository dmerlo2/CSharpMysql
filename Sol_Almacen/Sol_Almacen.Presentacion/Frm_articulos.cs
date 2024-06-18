using System;
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

        private void Estado_texto(bool lEstado)
        {
            txt_descripcion_ar.ReadOnly = !lEstado;
            txt_marca_ar.ReadOnly = !lEstado;
            txt_stock_actual.ReadOnly = !lEstado;
        }        

        private void Estado_botones_procesos(bool lEstado)
        {
            Btn_lupa_um.Enabled = lEstado;
            Btn_lupa_ca.Enabled=lEstado;

            Btn_Cancelar.Visible = lEstado;
            Btn_Guardar.Visible = lEstado;

            //Otros detalles
            Txt_buscar.ReadOnly = lEstado;
            Btn_buscar.Enabled= lEstado;
            Dgv_articulos.Enabled = !lEstado;
        }

        private void Estado_botones_principales(bool lestado)
        {
            Btn_Nuevo.Enabled = lestado;
            Btn_Actualizar.Enabled = lestado;
            Btn_Eliminar.Enabled = lestado;
            Btn_Reporte.Enabled = lestado;
            Btn_Salir.Enabled = lestado;
        }

        private void Limpia_texto()
        {
            txt_descripcion_ar.Text = "";
            txt_marca_ar.Text = "";
            Txt_descripcion_ca.Text = "";
            Txt_descripcion_um.Text = "";
            txt_stock_actual.Text = "";

        }
        #endregion

        #region "Mis variables"
        int nCodigo_ar = 0;
        int nEstadoGuarda = 0;
        #endregion

        private void Frm_articulos_Load(object sender, EventArgs e)
        {
            this.Listado_ar("%");
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_ar("%" + Txt_buscar.Text.Trim() + "%");
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 1; // Nuevo registro
            this.Limpia_texto();
            this.Estado_texto(true);
            this.Estado_botones_procesos(true);
            this.Estado_botones_principales(false);
            txt_descripcion_ar.Focus();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Limpia_texto();
            this.Estado_texto(false);
            this.Estado_botones_procesos(false);
            this.Estado_botones_principales(true);
            Txt_buscar.Focus();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            string Rpta = "";
            P_Articulos oAr = new P_Articulos();
            oAr.Codigo_ar = nCodigo_ar;
            oAr.Descripcion_ar = txt_descripcion_ar.Text.Trim();
            oAr.Marca_ar = txt_marca_ar.Text.Trim();
            oAr.Codigo_um = 1;
            oAr.Codigo_ca = 1;
            oAr.Stock_actual = Convert.ToDecimal(txt_stock_actual.Text);
            oAr.Fecha_crea = DateTime.Now.ToString("yyyy-MM-dd");
            oAr.Fecha_modifica = DateTime.Now.ToString("yyyy-MM-dd");

            D_Articulos Datos = new D_Articulos();
            Rpta = Datos.Guardar_ar(nEstadoGuarda,oAr);
            if (Rpta.Equals("OK"))
            {
                this.Estado_texto(false);
                this.Estado_botones_procesos(false);
                this.Estado_botones_principales(true);
                this.Listado_ar("%");
                MessageBox.Show("Los datos han sido guardados correctamente",
                               "Aviso del Sistema",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Rpta,
                               "Aviso del Sistema",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }
    }
}
