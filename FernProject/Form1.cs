using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FernProject
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();


        }

        private Graphics g;
        private Pen p;

        private void FirstLine(int x, int y, double a, double b)
        {
            g.DrawLine(p, x, y, (int)Math.Round(x + a * Math.Cos(b)), (int)Math.Round(y - a * Math.Sin(b)));
        }

        private void Draw(int x, int y, double a, double b)
        {
            if (a > 1)
            {
                FirstLine(x, y, a, b);
                x = (int)Math.Round(x + a * Math.Cos(b));
                y = (int)Math.Round(y - a * Math.Sin(b));
                Draw(x, y, a * 0.5, b - 10 * Math.PI / 30);
                Draw(x, y, a * 0.5, b + 10 * Math.PI / 30);
                Draw(x, y, a * 0.7, b + Math.PI / 30);
            }
        }

        private void CheckFern_Click(object sender, EventArgs e)
        {
            g = ModelView.CreateGraphics();
            p = new Pen(Color.Black);
            g.FillRectangle(Brushes.White, 0, 0, ModelView.Width, ModelView.Height);
            Draw(100, 400, 500, Math.PI /4);
        }
    }
}
