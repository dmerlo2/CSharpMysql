namespace Sol_Almacen.Presentacion
{
    partial class Frm_articulos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.Dgv_articulos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_descripcion_ar = new System.Windows.Forms.TextBox();
            this.txt_marca_ar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_descripcion_um = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_lupa_um = new System.Windows.Forms.Button();
            this.Btn_lupa_ca = new System.Windows.Forms.Button();
            this.Txt_descripcion_ca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_stock_actual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Txt_buscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_articulos
            // 
            this.Dgv_articulos.AllowUserToAddRows = false;
            this.Dgv_articulos.AllowUserToDeleteRows = false;
            this.Dgv_articulos.AllowUserToOrderColumns = true;
            this.Dgv_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_articulos.Location = new System.Drawing.Point(3, 202);
            this.Dgv_articulos.Name = "Dgv_articulos";
            this.Dgv_articulos.ReadOnly = true;
            this.Dgv_articulos.Size = new System.Drawing.Size(628, 209);
            this.Dgv_articulos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Articulo";
            // 
            // txt_descripcion_ar
            // 
            this.txt_descripcion_ar.Location = new System.Drawing.Point(65, 6);
            this.txt_descripcion_ar.Name = "txt_descripcion_ar";
            this.txt_descripcion_ar.ReadOnly = true;
            this.txt_descripcion_ar.Size = new System.Drawing.Size(246, 20);
            this.txt_descripcion_ar.TabIndex = 2;
            // 
            // txt_marca_ar
            // 
            this.txt_marca_ar.Location = new System.Drawing.Point(394, 10);
            this.txt_marca_ar.Name = "txt_marca_ar";
            this.txt_marca_ar.ReadOnly = true;
            this.txt_marca_ar.Size = new System.Drawing.Size(246, 20);
            this.txt_marca_ar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marca";
            // 
            // Txt_descripcion_um
            // 
            this.Txt_descripcion_um.Location = new System.Drawing.Point(65, 51);
            this.Txt_descripcion_um.Name = "Txt_descripcion_um";
            this.Txt_descripcion_um.ReadOnly = true;
            this.Txt_descripcion_um.Size = new System.Drawing.Size(212, 20);
            this.Txt_descripcion_um.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Medida";
            // 
            // Btn_lupa_um
            // 
            this.Btn_lupa_um.Location = new System.Drawing.Point(279, 49);
            this.Btn_lupa_um.Name = "Btn_lupa_um";
            this.Btn_lupa_um.Size = new System.Drawing.Size(32, 23);
            this.Btn_lupa_um.TabIndex = 7;
            this.Btn_lupa_um.Text = "::";
            this.Btn_lupa_um.UseVisualStyleBackColor = true;
            // 
            // Btn_lupa_ca
            // 
            this.Btn_lupa_ca.Location = new System.Drawing.Point(599, 47);
            this.Btn_lupa_ca.Name = "Btn_lupa_ca";
            this.Btn_lupa_ca.Size = new System.Drawing.Size(32, 23);
            this.Btn_lupa_ca.TabIndex = 10;
            this.Btn_lupa_ca.Text = "::";
            this.Btn_lupa_ca.UseVisualStyleBackColor = true;
            // 
            // Txt_descripcion_ca
            // 
            this.Txt_descripcion_ca.Location = new System.Drawing.Point(385, 49);
            this.Txt_descripcion_ca.Name = "Txt_descripcion_ca";
            this.Txt_descripcion_ca.ReadOnly = true;
            this.Txt_descripcion_ca.Size = new System.Drawing.Size(212, 20);
            this.Txt_descripcion_ca.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Categoria";
            // 
            // txt_stock_actual
            // 
            this.txt_stock_actual.Location = new System.Drawing.Point(95, 86);
            this.txt_stock_actual.Name = "txt_stock_actual";
            this.txt_stock_actual.ReadOnly = true;
            this.txt_stock_actual.Size = new System.Drawing.Size(68, 20);
            this.txt_stock_actual.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Stock actual";
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(239, 124);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancelar.TabIndex = 13;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Visible = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(345, 124);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Guardar.TabIndex = 14;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Visible = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.Location = new System.Drawing.Point(679, 23);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(85, 73);
            this.Btn_Nuevo.TabIndex = 15;
            this.Btn_Nuevo.Text = "Nuevo";
            this.Btn_Nuevo.UseVisualStyleBackColor = true;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.Location = new System.Drawing.Point(679, 114);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(85, 73);
            this.Btn_Actualizar.TabIndex = 16;
            this.Btn_Actualizar.Text = "Actualizar";
            this.Btn_Actualizar.UseVisualStyleBackColor = true;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Location = new System.Drawing.Point(679, 209);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(85, 73);
            this.Btn_Eliminar.TabIndex = 17;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.Location = new System.Drawing.Point(679, 288);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(85, 73);
            this.Btn_Reporte.TabIndex = 18;
            this.Btn_Reporte.Text = "Reporte";
            this.Btn_Reporte.UseVisualStyleBackColor = true;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Location = new System.Drawing.Point(679, 367);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(85, 73);
            this.Btn_Salir.TabIndex = 19;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Location = new System.Drawing.Point(279, 165);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(32, 23);
            this.Btn_buscar.TabIndex = 22;
            this.Btn_buscar.Text = "::";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Txt_buscar
            // 
            this.Txt_buscar.Location = new System.Drawing.Point(65, 167);
            this.Txt_buscar.Name = "Txt_buscar";
            this.Txt_buscar.Size = new System.Drawing.Size(212, 20);
            this.Txt_buscar.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Buscar";
            // 
            // Frm_articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Txt_buscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Reporte);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.txt_stock_actual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn_lupa_ca);
            this.Controls.Add(this.Txt_descripcion_ca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_lupa_um);
            this.Controls.Add(this.Txt_descripcion_um);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_marca_ar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_descripcion_ar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_articulos);
            this.Name = "Frm_articulos";
            this.Text = "Frm_articulos";
            this.Load += new System.EventHandler(this.Frm_articulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_articulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_articulos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_descripcion_ar;
        private System.Windows.Forms.TextBox txt_marca_ar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_descripcion_um;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_lupa_um;
        private System.Windows.Forms.Button Btn_lupa_ca;
        private System.Windows.Forms.TextBox Txt_descripcion_ca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_stock_actual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Reporte;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.TextBox Txt_buscar;
        private System.Windows.Forms.Label label6;
    }
}