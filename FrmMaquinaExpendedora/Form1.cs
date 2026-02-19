using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace FrmMaquinaExpendedora
{
    public partial class Form1 : Form
    {
        public string primnum, secnum;
        public int pagoUsuario;
        public int DineroEnMaquina;
        public int DevueltaDinero;
        bool HayDevueltaSuficiente = false;
        public int CodigoProdcuto;

      
        public Form1()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Borrar_Click(object sender, EventArgs e)
        {

        }






        private void Btn_Num0_Click(object sender, EventArgs e)
        {
            txt_Money.Text = txt_Money.Text + "0";
        }



        private void Btn_Num1_Click(object sender, EventArgs e)
        {
            txt_Money.Text = txt_Money.Text + "1";
        }

        private void Btn_Num2_Click(object sender, EventArgs e)
        {
            txt_Money.Text = txt_Money.Text + "2";
        }

        private void btn_Num3_Click(object sender, EventArgs e)
        {
            txt_Money.Text = txt_Money.Text + "3";
        }

        private void Btn_Num4_Click(object sender, EventArgs e)
        {
            txt_Money.Text = txt_Money.Text + "4";
        }

        private void Btn_Num5_Click(object sender, EventArgs e)
        {
            txt_Money.Text = txt_Money.Text + "5";
        }

        private void Btn_Num6_Click(object sender, EventArgs e)
        {
            txt_Money.Text = txt_Money.Text + "6";
        }

        private void Btn_Num7_Click(object sender, EventArgs e)
        {
            txt_Money.Text = txt_Money.Text + "7";
        }

        private void Btn_Num8_Click(object sender, EventArgs e)
        {
            txt_Money.Text = txt_Money.Text + "8";
        }

        private void Btn_Num9_Click(object sender, EventArgs e)
        {
            txt_Money.Text = txt_Money.Text + "9";
        }

        private void Btn_Borrar_Click_1(object sender, EventArgs e)
        {
            string valor = txt_Money.Text;
            if (valor != "")
            {
                txt_Money.Text = valor.Substring(0, valor.Length - 1);
            }
        }

        private void Btn_Enviar(object sender, EventArgs e)
        {
            using (ConexionBD conexion = new ConexionBD())

            {
                CodigoProdcuto = Convert.ToInt32(txt_Money.Text);

                var producto = conexion.productos.Find(CodigoProdcuto);

                if (producto != null)
                {
                    Lbl_NombreProducto.Text = producto.producto;
                    Lbl_PrecioProducto.Text = Convert.ToString(producto.precio);
                    Lbl_DisponibilidadProducto.Text = Convert.ToString(producto.cantidad);

                }



                //CodigoProdcuto= Convert.ToInt32(txt_Money.Text);

                //var producto = (from Producto in conexion.productos
                //                where Producto.codigoProducto == txt_Money.Text
                //                select new
                //                {
                //                    Producto.producto,
                //                    Producto.precio,
                //                    Producto.cantidad


                //                });



            }

        }






        public int DevueltaComrador()
        {
            int Precio_Producto = Convert.ToInt32(Lbl_PrecioProducto);
            int Cantidad_Ingresada = Convert.ToInt32(Txt_PagoCliente.Text);

            DevueltaDinero = (Cantidad_Ingresada - Precio_Producto);

            if (DevueltaDinero == 0)
            {
                MessageBox.Show("Usted ha pagado la cantidad exacta, no tiene devuleta");

                return 0;
            }

            else if (DevueltaDinero > DineroEnMaquina)
            {
                MessageBox.Show("La maquina No tiene devuelta, tome su dinero");
                return 0;
            }
            else
            {
                return DevueltaDinero;
            }



        }

        public bool ComprobacionPrecio()
        {
            return HayDevueltaSuficiente;
        }

        
    }

}




