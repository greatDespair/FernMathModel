using System;

namespace FernProject
{
    public class SpiralAngle
    {

        public int RotateAngle { get; set; }
        public int BaseDegree { get; set; }
        public int Radius { get; set; }
        public int ScaleDegree { get; set; }
        public int Step { get; set; }
        public int CurrentStep { get; set; }
        public SpiralAngle()
        {
            BaseDegree = 0;
            Radius = 10;
        }

        public SpiralAngle(int fDegree, int radius, int rotateAngle, int scale, int scaleStep)
        {
            CurrentStep = 1;
            Step = scaleStep;
            RotateAngle = rotateAngle;
            BaseDegree = fDegree % 360;
            ScaleDegree = scale;
            Radius = radius;
        }

        public void IncDegree()
        {
            BaseDegree = BaseDegree % 360;
            BaseDegree += RotateAngle;

            CurrentStep++;
            if(CurrentStep % Step == 0)
                RotateAngle += ScaleDegree;
        }

        public double[] GetNewPoints(double x, double y)
        {
            double currentDegree = GetAngleInRadians(BaseDegree);

            double newX = x + (0) * Math.Cos(currentDegree) - (Radius) * Math.Sin(currentDegree);
            double newY = y + (0) * Math.Sin(currentDegree) + (Radius) * Math.Cos(currentDegree);

            return new double[] { newX, newY };
        }

        private double GetAngleInRadians(int degree) 
        {
            double angle = (double)degree * Math.PI / 180;
            return angle;
        }

    }
}