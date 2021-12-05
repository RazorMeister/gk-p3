
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace gk_p3
{
    internal class Curve
    {
        private const int POINT_RADIUS = 7;

        public Point[] Points { get; set; } = new Point[4];

        private readonly int wrapperHeight;
        private readonly int wrapperWidth;

        private SortedDictionary<double, double> coOrdinates;

        public Curve(int wrapperWidth, int wrapperHeight)
        {
            this.wrapperWidth = wrapperWidth;
            this.wrapperHeight = wrapperHeight;

            this.Reset();
        }

        public Curve(int wrapperWidth, int wrapperHeight, double[] normalizedPointsX, double[] normalizedPointsY)
        {
            this.wrapperWidth = wrapperWidth;
            this.wrapperHeight = wrapperHeight;

            for (int i = 0; i < normalizedPointsX.Length; i++)
                this.Points[i] = this.SanitizePoint(new Point((int)(normalizedPointsX[i] * (double)this.wrapperWidth), (int)(normalizedPointsY[i] * (double)this.wrapperHeight)));
        
            this.SetCoOrdinates();
        }

        public void SetZeroCurve()
        {
            double dx = (double)this.wrapperWidth / (this.Points.Length - 1);

            for (int i = 0; i < this.Points.Length; i++)
                this.Points[i] = this.SanitizePoint(new Point((int) (i * dx), 0));

            this.SetCoOrdinates();
        }

        private double PointsDistance(Point p1, Point p2)
        {
            return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
        }

        private Point SanitizePoint(Point p)
        {
            return new Point(p.X, this.wrapperHeight - p.Y);
        }

        public void MovePoint(int index, int dx, int dy)
        {
            int newX = Math.Max(0, Math.Min(this.wrapperWidth, this.Points[index].X + dx));
            int newY = Math.Max(0, Math.Min(this.wrapperHeight, this.Points[index].Y + dy));

            this.Points[index] = new Point(newX, newY);
        }

        public void FinishMove()
        {
            this.SetCoOrdinates();
        }

        public int GetNearestPointIndex(Point p)
        {
            for (int i=0; i<Points.Length; i++)
                if (this.PointsDistance(this.Points[i], p) < 10)
                    return i;

            return -1;
        }

        public void Reset()
        {
            this.Points[0] = this.SanitizePoint(new Point(0, 0));
            this.Points[1] = this.SanitizePoint(new Point(this.wrapperWidth/3, this.wrapperHeight/3));
            this.Points[2] = this.SanitizePoint(new Point((2 * this.wrapperWidth) / 3, (2 * this.wrapperHeight) / 3));
            this.Points[3] = this.SanitizePoint(new Point(this.wrapperWidth, this.wrapperHeight));

            this.SetCoOrdinates();
        }

        private void SetCoOrdinates()
        {
            this.coOrdinates = new SortedDictionary<double, double>();

            for (double t = 0.0; t < 1.0; t += 0.001)
            {
                double y = ((double)this.wrapperHeight - this.GetY(t)) / this.wrapperHeight;
                double x = this.GetX(t) / this.wrapperWidth;

                y = Math.Round(Math.Max(0, Math.Min(1, y)), 2);
                x = Math.Round(Math.Max(0, Math.Min(1, x)), 2);

                if (this.coOrdinates.ContainsKey(x) == true) continue;

                this.coOrdinates.Add(x, y);
            }
        }

        public double GetYByX(double x)
        {
            if (this.coOrdinates.ContainsKey(x) == true) return this.coOrdinates[x];
            return 0.0;
        }

        private double GetX(double t)
        {
            return (
                this.Points[0].X * Math.Pow((1 - t), 3) +
                this.Points[1].X * 3 * t * Math.Pow((1 - t), 2) +
                this.Points[2].X * 3 * Math.Pow(t, 2) * (1 - t) +
                this.Points[3].X * Math.Pow(t, 3)
            );
        }

        private double GetY(double t)
        {
            return (
                this.Points[0].Y * Math.Pow((1 - t), 3) +
                this.Points[1].Y * 3 * t * Math.Pow((1 - t), 2) +
                this.Points[2].Y * 3 * Math.Pow(t, 2) * (1 - t) +
                this.Points[3].Y * Math.Pow(t, 3)
            );
        }

        public (double[], double[]) GetNormalizedPoints()
        {
            double[] normalizedPointsX = new double[this.Points.Length];
            double[] normalizedPointsY = new double[this.Points.Length];

            for (int i = 0; i < this.Points.Length; i++)
            {
                normalizedPointsX[i] = (double)this.Points[i].X / (double)this.wrapperWidth;
                normalizedPointsY[i] = (this.wrapperHeight - (double)this.Points[i].Y) / (double)this.wrapperHeight;
            }

            return (normalizedPointsX, normalizedPointsY);
        }

        public void Draw(PaintEventArgs e, Pen pen, bool drawPoints = false)
        {
            List<Point> curvePoints = new List<Point>();

            // Make cubic Bezier
            for (double t = 0.0; t <= 1.0; t += 0.001)
                curvePoints.Add(new Point((int)this.GetX(t), (int)this.GetY(t)));

            // Draw single control points
            if (drawPoints)
                foreach (var point in this.Points)
                    e.Graphics.FillEllipse(pen.Brush, point.X - POINT_RADIUS, point.Y - POINT_RADIUS, POINT_RADIUS + POINT_RADIUS, POINT_RADIUS + POINT_RADIUS);

            // Draw arc to screen.
            e.Graphics.DrawLines(pen, curvePoints.ToArray());
        }
    }
}
