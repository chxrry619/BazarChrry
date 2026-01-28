using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string mensaje = ConexionHelper.Probar();
            MessageBox.Show(mensaje);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
