using System.Diagnostics;
using System.Text.Json;

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
        private Dictionary<Settings.CMYK, Bitmap> cmykImages = new Dictionary<Settings.CMYK, Bitmap>();
        private Dictionary<Settings.CMYK, Curve> curves = new Dictionary<Settings.CMYK, Curve>();
        private Settings.CMYK currentColor = Settings.CMYK.CYAN;
        private bool showAllCurves = true;
        private bool blackAndWhite = false;

        public Form1()
        {
            InitializeComponent();

            this.curves.Add(Settings.CMYK.CYAN, new Curve(this.curvesWrapper.Width, this.curvesWrapper.Height));
            this.curves.Add(Settings.CMYK.MAGENTA, new Curve(this.curvesWrapper.Width, this.curvesWrapper.Height));
            this.curves.Add(Settings.CMYK.YELLOW, new Curve(this.curvesWrapper.Width, this.curvesWrapper.Height));
            this.curves.Add(Settings.CMYK.BLACK, new Curve(this.curvesWrapper.Width, this.curvesWrapper.Height));

            this.cmykWrappers.Add(Settings.CMYK.CYAN, this.cyanWrapper);
            this.cmykWrappers.Add(Settings.CMYK.MAGENTA, this.magentaWrapper);
            this.cmykWrappers.Add(Settings.CMYK.YELLOW, this.yellowWrapper);
            this.cmykWrappers.Add(Settings.CMYK.BLACK, this.blackWrapper);

            this.LoadImage(@"C:\Users\RazorMeister\Downloads\mountain-9.jpg");
        }

        private void LoadImage(string filePath)
        {
            if (this.mainImage != null)
                this.mainImage.Dispose();

            this.mainImage = (Bitmap)Bitmap.FromFile(filePath);
            this.mainImageWrapper.Image = this.mainImage;

            this.SetImages();
            this.curvesWrapper.Invalidate();
        }

        private void SetImages()
        {
            this.cmykImage = new CmykColor[this.mainImage.Width, this.mainImage.Height];

            for (int i = 1; i < this.mainImage.Width; i++)
                for (int j = 1; j < this.mainImage.Height; j++)
                    this.cmykImage[i, j] = new CmykColor(this.mainImage.GetPixel(i, j));

            foreach (var curve in this.curves.Values)
                curve.Reset();

            this.UpdateAllCmykImages();

            this.UpdateResultImage();
        }
 

        private void UpdateAllCmykImages()
        {
            foreach (var color in this.cmykWrappers.Keys)
                this.UpdateCmykImage(color);
        }

        private void UpdateCmykImage(Settings.CMYK? paramColor = null)
        {
            Settings.CMYK color = paramColor ?? this.currentColor;

            FastBitmap cmykColorBmp = new FastBitmap(this.mainImage.Width, this.mainImage.Height);

            int height = this.mainImage.Height;

            Parallel.For(1, this.mainImage.Width, (i) =>
            {
                for (int j = 1; j < height; j++)
                    cmykColorBmp.SetPixel(i, j, this.cmykImage[i, j].ComponentToColor(color, this.curves[color], this.blackAndWhite));
            });

            if (!this.cmykImages.ContainsKey(color))
                this.cmykImages.Add(color, new Bitmap(cmykColorBmp.Bitmap));
            else
            {
                this.cmykImages[color]?.Dispose();
                this.cmykImages[color] = new Bitmap(cmykColorBmp.Bitmap);
            }

            this.cmykWrappers[color].Image = this.cmykImages[color];

            if (color == this.currentColor)
                this.UpdateCurrentColorImage();

            cmykColorBmp.Dispose();
        }

        private void UpdateCurrentColorImage()
        {
            this.currentColorImageWrapper.Image = this.cmykImages[this.currentColor];
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
            if (this.showAllCurves)
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
            this.UpdateCurrentColorImage();
        }

        private void showAllCurvesCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.showAllCurves = this.showAllCurvesCheckbox.Checked;
            this.curvesWrapper.Invalidate();
        }

        private void importImageButton_Click(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                RestoreDirectory = true,
                InitialDirectory = Directory.GetParent(workingDirectory).Parent.FullName,
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;..."
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                this.LoadImage(openFileDialog.FileName);
        }

        private void saveCurvesButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "json files (*.jon)|*.json";
            saveFileDialog.DefaultExt = "json";
            saveFileDialog.Title = "Save curves to file";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Dictionary<Settings.CMYK, CurveDTO> toSerialize = new Dictionary<Settings.CMYK, CurveDTO>();

                foreach (var key in this.curves.Keys)
                {
                    (double[] normalizedPointsX, double[] normalizedPointsY) = this.curves[key].GetNormalizedPoints();
                    toSerialize.Add(key, new CurveDTO() { PointsX = normalizedPointsX, PointsY = normalizedPointsY });
                }
                    

                string json = JsonSerializer.Serialize(toSerialize);

                using (Stream s = File.Open(saveFileDialog.FileName, FileMode.OpenOrCreate))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(json);
                }
            }
        }

        private void importCurvesButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "json files (*.jon)|*.json";
            openFileDialog.Title = "Choose curves file to import";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader r = new StreamReader(fileStream))
                {
                    try
                    {
                        string json = r.ReadToEnd();
                        Dictionary<Settings.CMYK, CurveDTO> result = JsonSerializer.Deserialize<Dictionary<Settings.CMYK, CurveDTO>> (json);

                        this.curves = new Dictionary<Settings.CMYK, Curve>();

                        foreach (var key in result.Keys)
                            this.curves.Add(key, new Curve(this.curvesWrapper.Width, this.curvesWrapper.Height, result[key].PointsX, result[key].PointsY));

                        this.curvesWrapper.Invalidate();
                        this.UpdateAllCmykImages();
                        this.UpdateResultImage();
                    }
                    catch (Exception error)
                    {
                        Debug.WriteLine(error.ToString());
                        MessageBox.Show("Speficied file is incorrect!");
                    }
                }
            }
        }

        private void blackWhiteCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.blackAndWhite = this.blackWhiteCheckbox.Checked;
            this.UpdateAllCmykImages();
        }
    }
}