using System.Diagnostics;

namespace gk_p3
{
    public partial class Form1 : Form
    {
        private bool moving = false;
        private Point lastMovingPoint;
        private int movingPointIndex;

        private Bitmap mainImage;
        private CmykColor[,] cmykImage;

        private Dictionary<Settings.CMYK, PictureBox> cmykWrappers = new Dictionary<Settings.CMYK, PictureBox>();
        private Dictionary<Settings.CMYK, Curve> curves = new Dictionary<Settings.CMYK, Curve>();
        private Settings.CMYK currentColor = Settings.CMYK.CYAN;

        public Form1()
        {
            InitializeComponent();

            this.curves.Add(Settings.CMYK.CYAN, new Curve(this.curvesWrapper.Height, this.curvesWrapper.Width));
            this.curves.Add(Settings.CMYK.MAGENTA, new Curve(this.curvesWrapper.Height, this.curvesWrapper.Width));
            this.curves.Add(Settings.CMYK.YELLOW, new Curve(this.curvesWrapper.Height, this.curvesWrapper.Width));
            this.curves.Add(Settings.CMYK.BLACK, new Curve(this.curvesWrapper.Height, this.curvesWrapper.Width));

            this.cmykWrappers.Add(Settings.CMYK.CYAN, this.cyanWrapper);
            this.cmykWrappers.Add(Settings.CMYK.MAGENTA, this.magentaWrapper);
            this.cmykWrappers.Add(Settings.CMYK.YELLOW, this.yellowWrapper);
            this.cmykWrappers.Add(Settings.CMYK.BLACK, this.blackWrapper);

            this.mainImage = (Bitmap)Bitmap.FromFile(@"C:\Users\RazorMeister\Downloads\mountain-9.jpg");
            //this.mainImage.Dispose();
            this.mainImageWrapper.Image = this.mainImage;

            this.SetImages();
        }

        private void SetImages()
        {
            this.cmykImage = new CmykColor[this.mainImage.Width, this.mainImage.Height];

            //this.cyanImage = new Bitmap(this.mainImage.Width, this.mainImage.Height);

            for (int i = 1; i < this.mainImage.Width; i++)
            {
                for (int j = 1; j < this.mainImage.Height; j++)
                {
                    this.cmykImage[i, j] = new CmykColor(this.mainImage.GetPixel(i, j));
                    //this.cyanImage.SetPixel(i, j, this.cmykImage[i, j].CyanToColor());
                }
            }

            //this.cyanWrapper.Image = this.cyanImage;

            foreach (var curve in this.curves.Values)
                curve.Reset();

            foreach (var color in this.cmykWrappers.Keys)
                this.UpdateCmykImage(color);

            this.UpdateResultImage();
        }

        private void UpdateCmykImage(Settings.CMYK? paramColor = null)
        {
            Settings.CMYK color = paramColor ?? this.currentColor;

            FastBitmap cmykColorBmp = new FastBitmap(this.mainImage.Width, this.mainImage.Height);

            int height = this.mainImage.Height;

            Parallel.For(1, this.mainImage.Width, (i) =>
            {
                for (int j = 1; j < height; j++)
                    cmykColorBmp.SetPixel(i, j, this.cmykImage[i, j].ComponentToColor(color, this.curves[color]));
            });

            this.cmykWrappers[color].Image?.Dispose();
            this.cmykWrappers[color].Image = new Bitmap(cmykColorBmp.Bitmap);
            
            if (color == this.currentColor)
            {
                this.currentColorImageWrapper.Image?.Dispose();
                this.currentColorImageWrapper.Image = new Bitmap(cmykColorBmp.Bitmap);
            }

            cmykColorBmp.Dispose();

            //Debug.WriteLine("DONE");
        }

        private void UpdateResultImage()
        {
            FastBitmap resultBmp = new FastBitmap(this.mainImage.Width, this.mainImage.Height);

            int height = this.mainImage.Height;

            Parallel.For(1, this.mainImage.Width, (i) =>
            {
                for (int j = 1; j < height; j++)
                    resultBmp.SetPixel(i, j, this.cmykImage[i, j].ToColor(
                        this.curves[Settings.CMYK.CYAN],
                        this.curves[Settings.CMYK.MAGENTA],
                        this.curves[Settings.CMYK.YELLOW],
                        this.curves[Settings.CMYK.BLACK]
                    ));
            });

            this.resultImageWrapper.Image?.Dispose();
            this.resultImageWrapper.Image = new Bitmap(resultBmp.Bitmap);
            resultBmp.Dispose();
            Debug.WriteLine("DONE RESULT");
        }

        private void curvesWrapper_Paint(object sender, PaintEventArgs e)
        {
            foreach (var cmykColor in this.curves.Keys)  
                if (cmykColor != this.currentColor)
                    this.curves[cmykColor].Draw(e, new Pen(CmykColor.GetColorByEnum(cmykColor), 1), false);

            this.curves[this.currentColor].Draw(e, new Pen(CmykColor.GetColorByEnum(this.currentColor), 1), true);
        }

        private void curvesWrapper_MouseDown(object sender, MouseEventArgs e)
        {
            int index = this.curves[this.currentColor].GetNearestPointIndex(e.Location);

            if (index >= 0)
            {
                this.moving = true;
                this.movingPointIndex = index;
                this.lastMovingPoint = e.Location;
            }
        }

        private void curvesWrapper_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.moving)
            {
                this.curves[this.currentColor].FinishMove();
                this.UpdateCmykImage();
                this.UpdateResultImage();
            }

            this.moving = false;
        }

        private void curvesWrapper_MouseMove(object sender, MouseEventArgs e)
        {
            if (!this.moving) return;

            int dx = e.Location.X - this.lastMovingPoint.X;
            int dy = e.Location.Y - this.lastMovingPoint.Y;
            this.lastMovingPoint = e.Location;

            this.curves[this.currentColor].MovePoint(this.movingPointIndex, dx, dy);

            this.curvesWrapper.Invalidate();
        }

        private void cyanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cyanRadioButton.Checked)
                this.SetCurrentColor(Settings.CMYK.CYAN);
        }

        private void magentaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.magentaRadioButton.Checked)
                this.SetCurrentColor(Settings.CMYK.MAGENTA);
        }

        private void yellowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.yellowRadioButton.Checked)
                this.SetCurrentColor(Settings.CMYK.YELLOW);
        }

        private void blackRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.blackRadioButton.Checked)
                this.SetCurrentColor(Settings.CMYK.BLACK);
        }

        private void SetCurrentColor(Settings.CMYK color)
        {
            this.currentColor = color;
            this.moving = false;
            this.curvesWrapper.Invalidate();
        }
    }
}