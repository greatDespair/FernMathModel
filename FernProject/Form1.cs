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
        private int levelVar_;
        public MainForm()
        {
            InitializeComponent();


        }

        private Graphics g;
        private Pen p;

        private void DrawLine(int x, int y, double a, double b)
        {
            g.DrawLine(p, x, y, (int)Math.Round(x + 0.2*a * Math.Cos(b)), (int)Math.Round(y - 0.2*a * Math.Sin(b)));

        }

        private void Draw(int x, int y, double a, double b)
        {
            if (a > levelVar_)
            {

                DrawLine(x, y, a, b);
                x = (int)Math.Round(x + 0.2 * a * Math.Cos(b));
                y = (int)Math.Round(y - 0.2 * a * Math.Sin(b));
                Draw(x, y, a * 0.3, b - 10 * Math.PI / 30);
                Draw(x, y, a * 0.3, b + 10 * Math.PI / 30);
                Draw(x, y, a * 0.9, b + Math.PI / 30);
            }
        }

        private void CheckFern_Click(object sender, EventArgs e)
        {

            g = ModelView.CreateGraphics();
            p = new Pen(Color.Green);
            g.FillRectangle(Brushes.White, 0, 0, ModelView.Width, ModelView.Height);
            for (levelVar_ = 100; levelVar_ > 2; levelVar_--)
            {
                ViewDays();
                Draw(70, 500, 300, Math.PI / 4);
            }
        }
        private void ViewDays()
        {
            DaysView.Text = Convert.ToString(100 - levelVar_);

        }
    }
}
