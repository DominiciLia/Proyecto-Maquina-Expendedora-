using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrmMaquinaExpendedora
{

    public partial class FrmDataBase : Form
    {
        public FrmDataBase()
        {

            InitializeComponent();
            using (ConexionBD db = new ConexionBD())

            {

                var lst = from d in db.productos
                          select d;
                dataGridView1.DataSource = lst.ToList();

            }


        }

        private void FrmDataBase_Load(object sender, EventArgs e)
        {

        }

        private int codigoSeleccionado;


        private void Btn_Uptade_Click(object sender, EventArgs e)
        {


            try
            {
                using (var context = new ConexionBD())
                {
                    var producto = context.productos
                                          .FirstOrDefault(p => p.codigoProducto == codigoSeleccionado);

                    if (producto == null)
                    {
                        MessageBox.Show("Producto no encontrado");
                        return;
                    }

                    if (!decimal.TryParse(Txt_PrecioProducto.Text, out decimal precio))
                    {
                        MessageBox.Show("Precio inválido");
                        return;
                    }

                    if (!int.TryParse(Txt_CantidadProducto.Text, out int cantidad))
                    {
                        MessageBox.Show("Cantidad inválida");
                        return;
                    }

               
                                    
                    producto.precio = precio;
                    producto.cantidad = cantidad;

                    int filas = context.SaveChanges();

                    MessageBox.Show("Producto actualizado correctamente. Filas afectadas: " + filas);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            //if (codigoSeleccionado == null)
            //{
            //    MessageBox.Show("Seleccione un producto primero");
            //    return;
            //}

            //using (var context = new ConexionBD())
            //{
            //    var prod = context.productos
            //                      .FirstOrDefault(p => p.codigoProducto == codigoSeleccionado);

            //    if (prod == null)
            //    {
            //        MessageBox.Show("Producto no encontrado");
            //        return;
            //    }

            //    if (!decimal.TryParse(Txt_PrecioProducto.Text, out decimal precio))
            //    {
            //        MessageBox.Show("Precio inválido");
            //        return;
            //    }

            //    if (!int.TryParse(Txt_CantidadProducto.Text, out int cantidad))
            //    {
            //        MessageBox.Show("Cantidad inválida");
            //        return;
            //    }

            //    prod.producto = Txt_NombreProducto.Text;
            //    prod.precio = precio;
            //    prod.cantidad = cantidad;

            //    context.SaveChanges();

            //    MessageBox.Show("Producto actualizado correctamente");
            //}
        }




        private void refrescar()
        {
            using (ConexionBD db = new ConexionBD())
            {

                var lst = from d in db.productos
                          select d;
                dataGridView1.DataSource = lst.ToList();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                codigoSeleccionado = Convert.ToInt32(
                    dataGridView1.CurrentRow.Cells["codigoProducto"].Value
                );

                Txt_NombreProducto.Text =
                    dataGridView1.CurrentRow.Cells["producto"].Value?.ToString();

                Txt_PrecioProducto.Text =
                    dataGridView1.CurrentRow.Cells["precio"].Value?.ToString();

                Txt_CantidadProducto.Text =
                    dataGridView1.CurrentRow.Cells["cantidad"].Value?.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 FrmPrincipal = new Form1();
            this.Close();
            FrmPrincipal.Show();

        }
    }
}


    



