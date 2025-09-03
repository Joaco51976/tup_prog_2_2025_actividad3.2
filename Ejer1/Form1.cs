using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            ArrayList figuras = new ArrayList();

            figuras.Add(new Rectangulo(5, 2));
            figuras.Add(new Rectangulo(3, 4));
            figuras.Add(new Cuadrado(2));
            figuras.Add(new Cuadrado(5));
            figuras.Add(new Circulo(2));
            figuras.Add(new Circulo(4));

            lstFiguras.Items.Clear();

            foreach (IFigura f in figuras)
            {
                lstFiguras.Items.Add($"{f} - Área: {f.CalcularArea():0.00} - Perímetro: {f.CalcularPerimetro():0.00}");
            }
        }
    }
}