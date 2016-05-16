using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        enum TipoFigura { Rectangulo, Circulo };
        enum TipoColor { Rojo, Negro, Azul, Verde };
        private TipoFigura figura_actual;
        private List<Figura> rectangulos;
        private TipoColor color_actual;
        private List<Color> colores;

        public Form1()
        {
            figura_actual = TipoFigura.Circulo;
            color_actual = TipoColor.Negro;
            rectangulos = new List<Figura>();
            InitializeComponent();
            colores = new List<Color>();
            InitializeComponent();
            circuloToolStripMenuItem.Checked = true;
            negroToolStripMenuItem.Checked = true;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Right == e.Button)
            {
                contextMenuStrip1.Show(this, e.X, e.Y);

            }
            else if (MouseButtons.Left == e.Button)
            {
                
                if (figura_actual == TipoFigura.Circulo)
                {
                    Circulo c = new Circulo(e.X, e.Y);
                    c.Draw(this);
                    rectangulos.Add(c);
                    Color a = new Color();
                    colores.Add(a);
                }
                else if (figura_actual == TipoFigura.Rectangulo)
                {
                    Rectangulo r = new Rectangulo(e.X, e.Y);
                    r.Draw(this);
                    rectangulos.Add(r);
                    Color a = new Color();
                    colores.Add(a);
                }
            }


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figura r in rectangulos)
                foreach (Color a in colores)
                r.Draw(this);
        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.rectanguloToolStripMenuItem.Checked = true;
            this.circuloToolStripMenuItem.Checked = false;
            figura_actual = TipoFigura.Rectangulo;
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.circuloToolStripMenuItem.Checked = true;
            this.rectanguloToolStripMenuItem.Checked = false;
            figura_actual = TipoFigura.Circulo;
        }

        private void ordenarToolStripMenuItem_Click_1(object sender, EventArgs e)
        { 
            rectangulos.Sort();
            rectangulos.Reverse();
        }


        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.azulToolStripMenuItem.Checked = true;
            this.rojoToolStripMenuItem.Checked = false;
            this.verdeToolStripMenuItem.Checked = false;
            this.negroToolStripMenuItem.Checked = false;
            color_actual = TipoColor.Azul;
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.azulToolStripMenuItem.Checked = false;
            this.rojoToolStripMenuItem.Checked = false;
            this.verdeToolStripMenuItem.Checked = true;
            this.negroToolStripMenuItem.Checked = false;
            color_actual = TipoColor.Verde;
        }

        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.azulToolStripMenuItem.Checked = false;
            this.rojoToolStripMenuItem.Checked = true;
            this.verdeToolStripMenuItem.Checked = false;
            this.negroToolStripMenuItem.Checked = false;
            color_actual = TipoColor.Rojo;
        }

        private void negroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.azulToolStripMenuItem.Checked = false;
            this.rojoToolStripMenuItem.Checked = false;
            this.verdeToolStripMenuItem.Checked = false;
            this.negroToolStripMenuItem.Checked = true;
            color_actual = TipoColor.Negro;
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
