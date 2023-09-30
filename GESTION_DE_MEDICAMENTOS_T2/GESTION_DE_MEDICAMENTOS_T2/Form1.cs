using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_DE_MEDICAMENTOS_T2
{
    public partial class Form1 : Form
    {
        static string[] name = new string[100];
        Producto[] productos = new Producto[0];
        static int contador=0;

            public Form1()
            {
                InitializeComponent();
            }

            private void Form1_Load(object sender, EventArgs e)
            {
                this.pnDatos.Visible = false;
                this.pnOpciones.Visible = false;
                this.dgvPRoductos.Visible = false;
                this.bttOrdenar.Visible = false;
            }

            private void button2_Click(object sender, EventArgs e)
            {
                this.pnDatos.Visible = true;
            }

            private void bttOpciones_Click(object sender, EventArgs e)
            {
                this.pnOpciones.Visible = true;
            }
        private void EliminarProducto(int indice)
        {
            Producto[] nuevosProductos = new Producto[productos.Length - 1];

            for (int i = 0; i < indice; i++)
            {
                nuevosProductos[i] = productos[i];
            }

            for (int i = indice + 1; i < productos.Length; i++)
            {
                nuevosProductos[i - 1] = productos[i];
            }

            productos = nuevosProductos;
        }

        private void OrdenarProductosPorNombreBurbuja()
        {
            int n = productos.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (string.Compare(productos[j].nombre, productos[j + 1].nombre) > 0)
                    {
                        Producto temp = productos[j];
                        productos[j] = productos[j + 1];
                        productos[j + 1] = temp;
                    }
                }
            }
        }
        private void ActualizarDataGridView()
        {
            dgvPRoductos.DataSource = null;
            dgvPRoductos.DataSource = productos;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            string nuevoCodigo = txtCodigo.Text;
            string nuevoNombre = txtNombre.Text;
            string nuevaCantidad = txtCantidad.Text;
            string nuevoPrecio = txtPrecioUni.Text;

            if (string.IsNullOrWhiteSpace(nuevoCodigo) || string.IsNullOrWhiteSpace(nuevoNombre) || string.IsNullOrWhiteSpace(nuevaCantidad) || string.IsNullOrWhiteSpace(nuevoPrecio))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de agregar un producto.");
            }
            else
            {
                bool productoExistente = productos.Any(p => p.codigo == nuevoCodigo || p.nombre == nuevoNombre);

                if (productoExistente)
                {
                    Producto productoDuplicado = productos.FirstOrDefault(p => p.codigo == nuevoCodigo || p.nombre == nuevoNombre);

                    if (productoDuplicado != null)
                    {
                        if (productoDuplicado.codigo == nuevoCodigo)
                        {
                            MessageBox.Show("Ya existe un producto con el mismo código.\nNombre del producto: " + productoDuplicado.nombre);
                        }
                        else if (productoDuplicado.nombre == nuevoNombre)
                        {
                            MessageBox.Show("Ya existe un producto con el mismo nombre.\nCódigo del producto: " + productoDuplicado.codigo);
                        }
                    }
                }
                else
                {
                    Array.Resize(ref productos, productos.Length + 1);

                    Producto item = new Producto
                    {
                        codigo = nuevoCodigo,
                        nombre = nuevoNombre,
                        cantidad = nuevaCantidad,
                        precio = nuevoPrecio,
                    };

                    if (productos.Length > 0)
                    {
                        productos[productos.Length - 1] = item;
                    }
                    else
                    {
                        productos[0] = item;
                    }

                    MessageBox.Show("Producto ingresado con éxito!!!");
                    name[contador] = nuevoCodigo;
                    contador++;
                }
            }
        }
        private void bttListaMedi_Click(object sender, EventArgs e)
        {
            this.bttOrdenar.Visible = true;
            if (productos.Length > 0)
            {
                this.dgvPRoductos.Visible = true;
                dgvPRoductos.DataSource = productos;
            }
            else
            {
                MessageBox.Show("Aun no ingresas un producto");
            }
        }

        private void bttBuscarMedi_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            for (int i = 0; i < productos.Length; i++)
            {
                if (name[i] == txtBuscar.Text)
                {
                    encontrado = true;
                    MessageBox.Show("el medicamento encontrado existe y es: " + productos[i].nombre);
                    break;
                }
            }
            if (!encontrado)
            {
                MessageBox.Show("el medicamento no existe");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigoAEliminar = txtEliminar.Text;

            int indiceAEliminar = -1;
            for (int i = 0; i < productos.Length; i++)
            {
                if (productos[i].codigo == codigoAEliminar)
                {
                    indiceAEliminar = i;
                    break;
                }
            }

            if (indiceAEliminar != -1)
            {
                EliminarProducto(indiceAEliminar);

                ActualizarDataGridView();

                txtEliminar.Text = string.Empty;

                MessageBox.Show("Producto eliminado con éxito.");
            }
            else
            {
                MessageBox.Show("No se encontró ningún producto con ese código.");
            }
        }

        private void bttOrdenar_Click(object sender, EventArgs e)
        {
            OrdenarProductosPorNombreBurbuja();
            ActualizarDataGridView();
        }
    }
}
