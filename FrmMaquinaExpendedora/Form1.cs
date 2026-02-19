using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrmMaquinaExpendedora
{
       public partial class Form1 : Form
    {

        public int pagoUsuario;
        public int DineroEnMaquina;
        public int DevueltaDinero;
        bool HayDevueltaSuficiente = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }











        public int DevueltaComrador()
        {
            return DevueltaDinero; 

        }

        public bool ComprobacionPrecio()
        {
            return HayDevueltaSuficiente;
        }
    }

}
