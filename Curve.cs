﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gk_p3
{
    internal class Curve
    {
        public Point[] Points { get; set; } = new Point[4];

        private int wrapperHeight;
        private int wrapperWidth;

        private SortedDictionary<double, double> coOrdinates;

        public Curve(int wrapperHeight, int wrapperWidth)
        {
            this.wrapperHeight = wrapperHeight;
            this.wrapperWidth = wrapperWidth;

            this.Points[0] = this.SanitizePoint(new Point(0, 0));
            this.Points[1] = this.SanitizePoint(new Point(200, 50));
            this.Points[2] = this.SanitizePoint(new Point(400, 300));
            this.Points[3] = this.SanitizePoint(new Point(675, 100));
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
            {
                if (this.PointsDistance(this.Points[i], p) < 10)
                    return i;
            }

            return -1;
        }

        public void Reset()
        {
            this.Points[0] = this.SanitizePoint(new Point(0, 0));
            this.Points[1] = this.SanitizePoint(new Point(this.wrapperWidth/3, this.wrapperHeight/3));
            this.Points[2] = this.SanitizePoint(new Point((2 * this.wrapperWidth) / 3, (2 * this.wrapperHeight) / 3));
            this.Points[3] = this.SanitizePoint(new Point(this.wrapperWidth, this.wrapperHeight));

            this.SetCoOrdinates();

            foreach (var k in this.coOrdinates.Keys)
            {
                //Debug.WriteLine($"{k} - {this.coOrdinates[k]}");
            }
        }

        private double BinarySearchIterative(double[] x, double n)
        {
            int min = 0;
            int max = x.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;

                if (Math.Abs(n - x[mid]) < 0.01)
                    return x[++mid];
                else if (n < x[mid])
                    max = mid - 1;
                else
                    min = mid + 1;
            }

            return 0.0;
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

        public void Draw(PaintEventArgs e)
        {
            // Create pen.
            Pen pen = new Pen(Color.Black, 1);

            List<Point> curvePoints = new List<Point>();

            for (double t = 0.0; t <= 1.0; t += 0.001)
                curvePoints.Add(new Point((int)this.GetX(t), (int)this.GetY(t)));

            foreach (var point in this.Points)
                e.Graphics.DrawEllipse(pen, point.X - 5, point.Y - 5, 10, 10);

            // Draw arc to screen.
            e.Graphics.DrawLines(pen, curvePoints.ToArray());
        }
    }
}
