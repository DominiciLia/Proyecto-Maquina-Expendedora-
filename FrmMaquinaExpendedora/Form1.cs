using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Eventing.Reader;

namespace FrmMaquinaExpendedora
{
    public partial class Form1 : Form
    {
        public int pagoUsuario;
        public int PrecioProducto;
        public int DineroEnMaquina;
        public int DevueltaDinero;
        public bool PagoRealizado;
        public int Falta_Por_Pagar;


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
            TimerProductoEnPantalla.Stop();
            progressBar1.Value = 0;
            string valor = txt_Money.Text;
            if (valor != "")
            {
                txt_Money.Text = valor.Substring(0, valor.Length - 1);
            }
        }

        private void Btn_Enviar(object sender, EventArgs e)
        {
            try
            {
                using (ConexionBD conexion = new ConexionBD())

                {

                    var producto = (from Producto in conexion.productos
                                    where Producto.codigoProducto == Convert.ToInt32(txt_Money.Text)
                                    select new
                                    {
                                        Producto.producto,
                                        Producto.precio,
                                        Producto.cantidad

                                    }).FirstOrDefault();

                    if (producto != null)
                    {
                        PrecioProducto = Convert.ToInt32(producto.precio); 
                        Lbl_NombreProducto.Text = producto.producto.ToString();
                        Lbl_PrecioProducto.Text = $"RD$ {PrecioProducto}"; 

                        Lbl_DisponibilidadProducto.Text = producto.cantidad.ToString();
                        TimerProductoEnPantalla.Start();
                    }

                }


            }
            catch (Exception)
            {

                MessageBox.Show("Producto no encontrado. Ingrese código de producto valido");
                txt_Money.Text = "";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        private void TimerProductoEnPantalla_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 99)
            {
                TimerProductoEnPantalla.Stop();

                txt_Money.Text = "";
                Lbl_NombreProducto.Text = "";
                Lbl_PrecioProducto.Text = "";
                Lbl_DisponibilidadProducto.Text = "";
                progressBar1.Value = 0;

            }
        }


        private void btn_pagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_PagoCliente.Text))
                {
                    MessageBox.Show("Ingrese un monto");
                    return;
                }

                if (string.IsNullOrEmpty(Lbl_PrecioProducto.Text))
                {
                    MessageBox.Show("Seleccione un producto primero");
                    return;
                }

                ComprobacionPrecio();

                if (PagoRealizado)
                {
                    DevueltaComprador();

                }


            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Ha ocurrido un error;{ex}");
            }
        }




        public int DevueltaComprador()
        {

            int Precio_Producto = Convert.ToInt32(PrecioProducto);
            int Cantidad_Ingresada = Convert.ToInt32(Txt_PagoCliente.Text);

            DevueltaDinero = Cantidad_Ingresada - Precio_Producto;

            if (DevueltaDinero == 0)
            {
                MessageBox.Show("Compra realizada con éxito");
                Lbl_CuantoHayDeDevuelta.Text = "Pago exacto. No tiene devuelta.";
                DineroEnMaquina += Precio_Producto;

                TimerProductoEnPantalla.Stop();
                progressBar1.Value = 0;
                return 0;
            }
            else if (DevueltaDinero > DineroEnMaquina)
            {
                MessageBox.Show("La máquina no tiene suficiente devuelta.");
                Lbl_CuantoHayDeDevuelta.Text = $"Tome de nuevo su dinero: {Cantidad_Ingresada}";

                TimerProductoEnPantalla.Stop();
                progressBar1.Value = 0;

                return 0;
            }
            else
            {
                Lbl_CuantoHayDeDevuelta.Text = $"Tome sus RD${DevueltaDinero} de devuelta.";
                MessageBox.Show("Compra realizada con éxito");
                DineroEnMaquina += Precio_Producto;
                return DevueltaDinero;
            }

        }



        public bool ComprobacionPrecio()
        {

            PrecioProducto = PrecioProducto;
            pagoUsuario = Convert.ToInt32(Txt_PagoCliente.Text);
            Falta_Por_Pagar = (PrecioProducto - pagoUsuario);


            if (Falta_Por_Pagar == 0)
            {
                MessageBox.Show("Pago realizado Exitosamente");
                return PagoRealizado = true;
            }

            else if (Falta_Por_Pagar > 0)
            {

                Lbl_CuantoHayDeDevuelta.Text = $"Pago insuficiente. Faltan {Falta_Por_Pagar}";
                return PagoRealizado = false;
            }


            return PagoRealizado;
        }



        private void PanelBotones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Uptade_Click(object sender, EventArgs e)
        {
            FrmDataBase frmDataBase = new FrmDataBase();
            this.Hide();
            frmDataBase.Show();

        }

    }
}







