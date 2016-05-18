using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    abstract class Figura : IComparable
    {
        protected int X;
        protected int Y;
        protected Pen pluma, plumaL;
        protected int ancho;
        protected int largo;
        protected Color color;
        protected SolidBrush brocha;
        protected Color TipoColor;
        protected int lugar;

        public Figura(int x, int y, Color b, Color p) 
        {
            X = x;
            Y = y;
            TipoColor = b;
            TipoColor = p;
            brocha = new SolidBrush(b);
            pluma = new Pen(p, 1);            
            Random rnd = new Random();
            plumaL = new Pen(p, rnd.Next(1,10));
            ancho = rnd.Next(10,80);
            largo = ancho;
            color = Color.Black;

        }

        public abstract void Draw(Form f);

        public int CompareTo(object obj)
        {

            return this.largo.CompareTo(((Figura)obj).largo);
        }
    }
    class Rectangulo : Figura
    {
        public Rectangulo(int x, int y, Color b, Color p)
            : base(x, y, b, p)
        {
        }

        public override void Draw(Form f)
        {
            Graphics g = f.CreateGraphics();
            g.DrawRectangle(pluma, this.X, this.Y, ancho, largo);
            g.FillRectangle(brocha, this.X, this.Y, ancho, largo);
        }

    }

    class Circulo : Figura
    {
        public Circulo(int x, int y, Color b, Color p)
            : base(x, y, b, p)
        {

        }

        public override void Draw(Form f)
        {
            Graphics g = f.CreateGraphics();
            g.DrawEllipse(pluma, this.X, this.Y, ancho, largo);
            g.FillEllipse(brocha, this.X, this.Y, ancho, largo);
        }
    }

    class Triangulo : Figura
    {
        public Triangulo(int x, int y, Color b, Color p)
            : base(x, y, b, p)
        {

        }

        public override void Draw(Form f)
        {
            Graphics g = f.CreateGraphics();
            g.DrawLine(plumaL, this.X, this.Y , ancho, largo);            
        }
    }
}
