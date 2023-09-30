
namespace GESTION_DE_MEDICAMENTOS_T2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecioUni = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecioUni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.bttIngresoDatos = new System.Windows.Forms.Button();
            this.pnDatos = new System.Windows.Forms.Panel();
            this.bttAgregar = new System.Windows.Forms.Button();
            this.bttOpciones = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bttEliminarMedi = new System.Windows.Forms.Button();
            this.bttListaMedi = new System.Windows.Forms.Button();
            this.pnOpciones = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.pnlCodigo = new System.Windows.Forms.Panel();
            this.lblNombreCod = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.bttBuscarMedi = new System.Windows.Forms.Button();
            this.dgvPRoductos = new System.Windows.Forms.DataGridView();
            this.bttOrdenar = new System.Windows.Forms.Button();
            this.pnDatos.SuspendLayout();
            this.pnOpciones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlCodigo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRoductos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(66, 18);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(84, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(8, 21);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 13);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "CODIGO:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(8, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(8, 106);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(65, 13);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "CANTIDAD:";
            // 
            // lblPrecioUni
            // 
            this.lblPrecioUni.AutoSize = true;
            this.lblPrecioUni.Location = new System.Drawing.Point(8, 150);
            this.lblPrecioUni.Name = "lblPrecioUni";
            this.lblPrecioUni.Size = new System.Drawing.Size(105, 13);
            this.lblPrecioUni.TabIndex = 5;
            this.lblPrecioUni.Text = "PRECIO UNITARIO:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(79, 103);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(84, 20);
            this.txtCantidad.TabIndex = 6;
            // 
            // txtPrecioUni
            // 
            this.txtPrecioUni.Location = new System.Drawing.Point(119, 147);
            this.txtPrecioUni.Name = "txtPrecioUni";
            this.txtPrecioUni.Size = new System.Drawing.Size(84, 20);
            this.txtPrecioUni.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(71, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(84, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // bttIngresoDatos
            // 
            this.bttIngresoDatos.Location = new System.Drawing.Point(17, 3);
            this.bttIngresoDatos.Name = "bttIngresoDatos";
            this.bttIngresoDatos.Size = new System.Drawing.Size(152, 23);
            this.bttIngresoDatos.TabIndex = 14;
            this.bttIngresoDatos.Text = "INGRESO DE DATOS";
            this.bttIngresoDatos.UseVisualStyleBackColor = true;
            this.bttIngresoDatos.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnDatos
            // 
            this.pnDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDatos.Controls.Add(this.bttAgregar);
            this.pnDatos.Controls.Add(this.txtPrecioUni);
            this.pnDatos.Controls.Add(this.txtCodigo);
            this.pnDatos.Controls.Add(this.lblCodigo);
            this.pnDatos.Controls.Add(this.lblNombre);
            this.pnDatos.Controls.Add(this.lblCantidad);
            this.pnDatos.Controls.Add(this.lblPrecioUni);
            this.pnDatos.Controls.Add(this.txtNombre);
            this.pnDatos.Controls.Add(this.txtCantidad);
            this.pnDatos.Location = new System.Drawing.Point(13, 32);
            this.pnDatos.Name = "pnDatos";
            this.pnDatos.Size = new System.Drawing.Size(219, 222);
            this.pnDatos.TabIndex = 15;
            // 
            // bttAgregar
            // 
            this.bttAgregar.Location = new System.Drawing.Point(118, 183);
            this.bttAgregar.Name = "bttAgregar";
            this.bttAgregar.Size = new System.Drawing.Size(96, 34);
            this.bttAgregar.TabIndex = 9;
            this.bttAgregar.Text = "AGREGAR";
            this.bttAgregar.UseVisualStyleBackColor = true;
            this.bttAgregar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // bttOpciones
            // 
            this.bttOpciones.Location = new System.Drawing.Point(265, 3);
            this.bttOpciones.Name = "bttOpciones";
            this.bttOpciones.Size = new System.Drawing.Size(122, 23);
            this.bttOpciones.TabIndex = 16;
            this.bttOpciones.Text = "OPCIONES";
            this.bttOpciones.UseVisualStyleBackColor = true;
            this.bttOpciones.Click += new System.EventHandler(this.bttOpciones_Click);
            // 
            // bttEliminarMedi
            // 
            this.bttEliminarMedi.Location = new System.Drawing.Point(18, 154);
            this.bttEliminarMedi.Name = "bttEliminarMedi";
            this.bttEliminarMedi.Size = new System.Drawing.Size(162, 28);
            this.bttEliminarMedi.TabIndex = 12;
            this.bttEliminarMedi.Text = "ELIMINAR MEDICAMENTO";
            this.bttEliminarMedi.UseVisualStyleBackColor = true;
            this.bttEliminarMedi.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttListaMedi
            // 
            this.bttListaMedi.Location = new System.Drawing.Point(203, 13);
            this.bttListaMedi.Name = "bttListaMedi";
            this.bttListaMedi.Size = new System.Drawing.Size(162, 28);
            this.bttListaMedi.TabIndex = 10;
            this.bttListaMedi.Text = "LISTA DE MEDICAMENTOS";
            this.bttListaMedi.UseVisualStyleBackColor = true;
            this.bttListaMedi.Click += new System.EventHandler(this.bttListaMedi_Click);
            // 
            // pnOpciones
            // 
            this.pnOpciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnOpciones.Controls.Add(this.bttOrdenar);
            this.pnOpciones.Controls.Add(this.panel1);
            this.pnOpciones.Controls.Add(this.pnlCodigo);
            this.pnOpciones.Controls.Add(this.bttBuscarMedi);
            this.pnOpciones.Controls.Add(this.dgvPRoductos);
            this.pnOpciones.Controls.Add(this.bttListaMedi);
            this.pnOpciones.Controls.Add(this.bttEliminarMedi);
            this.pnOpciones.Location = new System.Drawing.Point(265, 32);
            this.pnOpciones.Name = "pnOpciones";
            this.pnOpciones.Size = new System.Drawing.Size(386, 260);
            this.pnOpciones.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblEliminar);
            this.panel1.Controls.Add(this.txtEliminar);
            this.panel1.Location = new System.Drawing.Point(18, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 55);
            this.panel1.TabIndex = 23;
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Location = new System.Drawing.Point(6, 7);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(140, 13);
            this.lblEliminar.TabIndex = 21;
            this.lblEliminar.Text = "CODIGO DEL PRODUCTO:";
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(9, 22);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(137, 20);
            this.txtEliminar.TabIndex = 19;
            // 
            // pnlCodigo
            // 
            this.pnlCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCodigo.Controls.Add(this.lblNombreCod);
            this.pnlCodigo.Controls.Add(this.txtBuscar);
            this.pnlCodigo.Location = new System.Drawing.Point(18, 47);
            this.pnlCodigo.Name = "pnlCodigo";
            this.pnlCodigo.Size = new System.Drawing.Size(162, 55);
            this.pnlCodigo.TabIndex = 22;
            // 
            // lblNombreCod
            // 
            this.lblNombreCod.AutoSize = true;
            this.lblNombreCod.Location = new System.Drawing.Point(6, 7);
            this.lblNombreCod.Name = "lblNombreCod";
            this.lblNombreCod.Size = new System.Drawing.Size(140, 13);
            this.lblNombreCod.TabIndex = 21;
            this.lblNombreCod.Text = "CODIGO DEL PRODUCTO:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(9, 22);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(137, 20);
            this.txtBuscar.TabIndex = 19;
            // 
            // bttBuscarMedi
            // 
            this.bttBuscarMedi.Location = new System.Drawing.Point(18, 13);
            this.bttBuscarMedi.Name = "bttBuscarMedi";
            this.bttBuscarMedi.Size = new System.Drawing.Size(162, 28);
            this.bttBuscarMedi.TabIndex = 18;
            this.bttBuscarMedi.Text = "BUSCAR MEDICAMENTO";
            this.bttBuscarMedi.UseVisualStyleBackColor = true;
            this.bttBuscarMedi.Click += new System.EventHandler(this.bttBuscarMedi_Click);
            // 
            // dgvPRoductos
            // 
            this.dgvPRoductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPRoductos.Location = new System.Drawing.Point(203, 47);
            this.dgvPRoductos.Name = "dgvPRoductos";
            this.dgvPRoductos.Size = new System.Drawing.Size(162, 162);
            this.dgvPRoductos.TabIndex = 17;
            // 
            // bttOrdenar
            // 
            this.bttOrdenar.Location = new System.Drawing.Point(243, 215);
            this.bttOrdenar.Name = "bttOrdenar";
            this.bttOrdenar.Size = new System.Drawing.Size(122, 28);
            this.bttOrdenar.TabIndex = 24;
            this.bttOrdenar.Text = "ORDENAR LISTA";
            this.bttOrdenar.UseVisualStyleBackColor = true;
            this.bttOrdenar.Click += new System.EventHandler(this.bttOrdenar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 299);
            this.Controls.Add(this.pnOpciones);
            this.Controls.Add(this.bttOpciones);
            this.Controls.Add(this.pnDatos);
            this.Controls.Add(this.bttIngresoDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnDatos.ResumeLayout(false);
            this.pnDatos.PerformLayout();
            this.pnOpciones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCodigo.ResumeLayout(false);
            this.pnlCodigo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRoductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecioUni;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecioUni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button bttIngresoDatos;
        private System.Windows.Forms.Panel pnDatos;
        private System.Windows.Forms.Button bttOpciones;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button bttEliminarMedi;
        private System.Windows.Forms.Button bttListaMedi;
        private System.Windows.Forms.Panel pnOpciones;
        private System.Windows.Forms.Button bttAgregar;
        private System.Windows.Forms.DataGridView dgvPRoductos;
        private System.Windows.Forms.Button bttBuscarMedi;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblNombreCod;
        private System.Windows.Forms.Panel pnlCodigo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.Button bttOrdenar;
    }
}

