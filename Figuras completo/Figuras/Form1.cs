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
        enum TipoFigura { Rectangulo, Circulo, Triangulo};
        enum TipoColor { Red, Black, Blue, Green };
        private TipoFigura figura_actual;
        private List<Figura> rectangulos;
        private TipoColor color_actual;
        private List<Color> colores;

        public Form1()
        {
            figura_actual = TipoFigura.Triangulo;
            color_actual = TipoColor.Black;
            rectangulos = new List<Figura>();
            InitializeComponent();
            colores = new List<Color>();
            InitializeComponent();
            trianguloToolStripMenuItem.Checked = true;
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
                    if (color_actual == TipoColor.Red)
                    {
                        Circulo c = new Circulo(e.X, e.Y, Color.Red, Color.Black);
                        c.Draw(this);
                        rectangulos.Add(c);
                    }
                    else if (color_actual == TipoColor.Green)
                    {
                        Circulo c = new Circulo(e.X, e.Y, Color.Green, Color.Black);
                        c.Draw(this);
                        rectangulos.Add(c);
                    }
                    else if (color_actual == TipoColor.Black)
                    {
                        Circulo c = new Circulo(e.X, e.Y, Color.Black, Color.Black);
                        c.Draw(this);
                        rectangulos.Add(c);
                    }
                    else if (color_actual == TipoColor.Blue)
                    {
                        Circulo c = new Circulo(e.X, e.Y, Color.Blue, Color.Black);
                        c.Draw(this);
                        rectangulos.Add(c);
                    }

                }
                else if (figura_actual == TipoFigura.Rectangulo)
                {
                    if (color_actual == TipoColor.Red)
                    {
                        Rectangulo r = new Rectangulo(e.X, e.Y, Color.Red, Color.Black);
                        r.Draw(this);
                        rectangulos.Add(r);
                    }
                    else if (color_actual == TipoColor.Green)
                    {
                        Rectangulo r = new Rectangulo(e.X, e.Y, Color.Green, Color.Black);
                        r.Draw(this);
                        rectangulos.Add(r);
                    }
                    else if (color_actual == TipoColor.Blue)
                    {
                        Rectangulo r = new Rectangulo(e.X, e.Y, Color.Blue, Color.Black);
                        r.Draw(this);
                        rectangulos.Add(r);
                    }
                    else if (color_actual == TipoColor.Black)
                    {
                        Rectangulo r = new Rectangulo(e.X, e.Y, Color.Black, Color.Black);
                        r.Draw(this);
                        rectangulos.Add(r);
                    }
                }
                else if (figura_actual == TipoFigura.Triangulo)
                {
                    if (color_actual == TipoColor.Red)
                    {
                        Triangulo t = new Triangulo(e.X, e.Y, Color.Black, Color.Red);
                        t.Draw(this);
                        rectangulos.Add(t);
                    }
                    else if (color_actual == TipoColor.Green)
                    {
                        Triangulo t = new Triangulo(e.X, e.Y, Color.Black, Color.Green);
                        t.Draw(this);
                        rectangulos.Add(t);
                    }
                    else if (color_actual == TipoColor.Blue)
                    {
                        Triangulo t = new Triangulo(e.X, e.Y, Color.Black, Color.Blue);
                        t.Draw(this);
                        rectangulos.Add(t);
                    }
                    else if (color_actual == TipoColor.Black)
                    {
                        Triangulo t = new Triangulo(e.X, e.Y, Color.Black, Color.Black);
                        t.Draw(this);
                        rectangulos.Add(t);
                    }
                }
            }


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figura r in rectangulos)
                
                r.Draw(this);
        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.rectanguloToolStripMenuItem.Checked = true;
            this.circuloToolStripMenuItem.Checked = false;
            this.trianguloToolStripMenuItem.Checked = false;
            figura_actual = TipoFigura.Rectangulo;
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.circuloToolStripMenuItem.Checked = true;
            this.rectanguloToolStripMenuItem.Checked = false;
            this.trianguloToolStripMenuItem.Checked = false;
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
            color_actual = TipoColor.Blue;
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.verdeToolStripMenuItem.Checked = true;
            this.azulToolStripMenuItem.Checked = false;
            this.rojoToolStripMenuItem.Checked = false;            
            this.negroToolStripMenuItem.Checked = false;
            color_actual = TipoColor.Green;
        }

        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            this.rojoToolStripMenuItem.Checked = true;
            this.azulToolStripMenuItem.Checked = false;
            this.verdeToolStripMenuItem.Checked = false;
            this.negroToolStripMenuItem.Checked = false;
            color_actual = TipoColor.Red;
        }

        private void negroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.azulToolStripMenuItem.Checked = false;
            this.rojoToolStripMenuItem.Checked = false;
            this.verdeToolStripMenuItem.Checked = false;
            this.negroToolStripMenuItem.Checked = true;
            color_actual = TipoColor.Black;
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.trianguloToolStripMenuItem.Checked = true;
            this.circuloToolStripMenuItem.Checked = false;
            this.rectanguloToolStripMenuItem.Checked = false;
            figura_actual = TipoFigura.Triangulo;
        }
    }
}
