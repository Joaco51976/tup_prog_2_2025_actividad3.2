using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ejer2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            List<Figura> figuras = new List<Figura>();

            figuras.Add(new Cuadrado(2));
            figuras.Add(new Cuadrado(5));
            figuras.Add(new Rectangulo(3, 4));
            figuras.Add(new Circulo(3));

            figuras.Sort();

            lstFiguras.Items.Clear();

            foreach (Figura f in figuras)
            {
                lstFiguras.Items.Add(f.ToString());
            }
        }
    }
}