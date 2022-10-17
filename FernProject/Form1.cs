using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        private void DrawSpiral(float startX, float startY, int iterations)
        {
            g = ModelView.CreateGraphics();
            Pen b = new Pen(Color.Green, 5);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            SpiralAngle spiral = new SpiralAngle(0, 10, 1, 1, 4);
            double currentX = 0;
            double currentY = 0;
            double[] newPoints = new double[2];
            for(int i = 0; i < iterations; i++)
            {
                
                spiral.IncDegree();
                
                Array.Copy(spiral.GetNewPoints(currentX, currentY), newPoints, 2);

                g.DrawCurve(b, new PointF[] {
                new PointF(){X = startX + (float)currentX, Y = startY - (float)currentY },
                new PointF(){X = startX + (float)newPoints[0], Y = startY - (float)newPoints[1] },
                });

                currentX = (double)newPoints[0];
                currentY = (double)newPoints[1];

                Thread.Sleep(10);
            }

        }
        
        private void DrawFern(int x, int y, double a, double b)
        {
            
        }

        private void CheckFern_Click(object sender, EventArgs e)
        {
            DrawSpiral(250, 250);
            
            
        }
        private void ViewDays()
        {
            DaysView.Text = Convert.ToString(100 - levelVar_);

        }
    }
}
