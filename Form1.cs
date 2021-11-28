using System.Collections.Concurrent;
using System.Diagnostics;
using System.Text.Json;
using gk_p3.Properties;

namespace gk_p3
{
    public partial class Form1 : Form
    {
        private bool moving = false;
        private Point lastMovingPoint;
        private int movingPointIndex;

        private Bitmap mainImage;
        private CmykColor[,] cmykImage;

        private ConcurrentDictionary<Settings.CMYK, PictureBox> cmykWrappers = new ConcurrentDictionary<Settings.CMYK, PictureBox>();
        private ConcurrentDictionary<Settings.CMYK, Bitmap> cmykImages = new ConcurrentDictionary<Settings.CMYK, Bitmap>();
        private ConcurrentDictionary<Settings.CMYK, Curve> curves = new ConcurrentDictionary<Settings.CMYK, Curve>();
        private Settings.CMYK currentColor = Settings.CMYK.CYAN;
        private bool showAllCurves = true;
        private bool blackAndWhite = false;
        private Thread loadImagesThread;

        private int mainImageWidth;
        private int mainImageHeight;
        private Color[,] mainImagePixels;

        private List<Control> controlsToDisableWhenLoading;

        public Form1()
        {
            InitializeComponent();

            this.InitiStructures();

            this.curvesWrapper.Invalidate();

            this.LoadImage();
        }

        private void InitiStructures()
        {
            this.controlsToDisableWhenLoading = new List<Control>()
            {
                this.cyanRadioButton,
                this.magentaRadioButton,
                this.yellowRadioButton,
                this.blackRadioButton,

                this.importCurvesButton,
                this.saveCurvesButton,

                this.importImageButton,
                this.saveImageButton,

                this.blackWhiteCheckbox,
                this.showAllCurvesCheckbox
            };

            foreach (Settings.CMYK color in Enum.GetValues(typeof(Settings.CMYK)))
                this.curves.TryAdd(color, new Curve(this.curvesWrapper.Width, this.curvesWrapper.Height));

            this.cmykWrappers.TryAdd(Settings.CMYK.CYAN, this.cyanWrapper);
            this.cmykWrappers.TryAdd(Settings.CMYK.MAGENTA, this.magentaWrapper);
            this.cmykWrappers.TryAdd(Settings.CMYK.YELLOW, this.yellowWrapper);
            this.cmykWrappers.TryAdd(Settings.CMYK.BLACK, this.blackWrapper);
        }

        private void LoadImage(string? filePath = null)
        {
            this.controlsToDisableWhenLoading.ForEach(control => control.Enabled = false);

            this.mainImageWrapper.Image = Resources.loading;
            this.resultImageWrapper.Image = Resources.loading;
            this.currentColorImageWrapper.Image = Resources.loading;

            foreach (var wrapper in this.cmykWrappers.Values)
                wrapper.Image = Resources.loading;

            if (this.loadImagesThread != null && this.loadImagesThread.IsAlive)
                this.loadImagesThread.Abort();

            this.loadImagesThread = new Thread(() =>
            {
                this.LoadImageAsync(filePath);
                this.SetImages();
                this.UpdateCurrentColorImage();
                this.controlsToDisableWhenLoading.ForEach(this.SetEnabledSafe);
                this.curvesWrapper.Invalidate();
            });

            this.loadImagesThread.Start();
        }

        private void SetEnabledSafe(Control control)
        {
            if (control.InvokeRequired)
                control.Invoke(this.SetEnabledSafe, new object[] { control });
            else
                control.Enabled = true;
        }

        private void LoadImageAsync(string? filePath = null)
        {
            if (this.mainImage != null)
                this.mainImage.Dispose();

            this.mainImage = filePath != null ? (Bitmap) Bitmap.FromFile(filePath) : Resources.defaultImage;

            this.mainImageWidth = this.mainImage.Width;
            this.mainImageHeight = this.mainImage.Height;

            this.mainImagePixels = new Color[this.mainImageWidth, this.mainImageHeight];

            for (int i = 1; i < this.mainImageWidth; i++)
                for (int j = 1; j < this.mainImageHeight; j++)
                    this.mainImagePixels[i, j] = this.mainImage.GetPixel(i, j);

            this.mainImageWrapper.Image = this.mainImage;
        }

        private void SetImages()
        {
            this.cmykImage = new CmykColor[this.mainImageWidth, this.mainImageHeight];

            for (int i = 1; i < this.mainImageWidth; i++)
                for (int j = 1; j < this.mainImageHeight; j++)
                    this.cmykImage[i, j] = new CmykColor(this.mainImagePixels[i, j]);

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

            FastBitmap cmykColorBmp = new FastBitmap(this.mainImageWidth, this.mainImageHeight);

            int height = this.mainImageHeight;

            Parallel.For(1, this.mainImageWidth, (i) =>
            {
                for (int j = 1; j < height; j++)
                    cmykColorBmp.SetPixel(i, j, this.cmykImage[i, j].ComponentToColor(color, this.curves[color], this.blackAndWhite));
            });

            if (!this.cmykImages.ContainsKey(color))
                this.cmykImages.TryAdd(color, new Bitmap(cmykColorBmp.Bitmap));
            else
            {
                this.cmykImages[color]?.Dispose();
                this.cmykImages[color] = new Bitmap(cmykColorBmp.Bitmap);
            }

            this.cmykWrappers[color].Image = this.cmykImages[color];

            if (color == this.currentColor && paramColor == null)
                this.UpdateCurrentColorImage();

            cmykColorBmp.Dispose();
        }

        private void UpdateCurrentColorImage()
        {
            this.currentColorImageWrapper.Image = this.cmykImages[this.currentColor];
        }

        private void UpdateCurrentCurveImages()
        {
            Action[] methods = new Action[] {() => this.UpdateCmykImage(), this.UpdateResultImage};
            Parallel.For(0, methods.Length, (i) => methods[i]());
        }

        private void UpdateResultImage()
        {
            FastBitmap resultBmp = new FastBitmap(this.mainImageWidth, this.mainImageHeight);

            int height = this.mainImageHeight;

            Parallel.For(1, this.mainImageWidth, (i) =>
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
        }

        private void curvesWrapper_Paint(object sender, PaintEventArgs e)
        {
            if (this.showAllCurves)
                foreach (var cmykColor in this.curves.Keys)  
                    if (cmykColor != this.currentColor)
                        this.curves[cmykColor].Draw(e, new Pen(CmykColor.GetColorByEnum(cmykColor), 1), false);

            this.curves[this.currentColor].Draw(e, new Pen(CmykColor.GetColorByEnum(this.currentColor), 2), true);
        }

        private void curvesWrapper_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.loadImagesThread != null && this.loadImagesThread.IsAlive)
                return;

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
                this.UpdateCurrentCurveImages();
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
            if (this.loadImagesThread != null && this.loadImagesThread.IsAlive)
                return;

            this.currentColor = color;
            this.moving = false;

            switch(color)
            {
                case Settings.CMYK.CYAN:
                    this.cyanRadioButton.Checked = true;
                    this.cyanWrapper.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case Settings.CMYK.MAGENTA:
                    this.magentaRadioButton.Checked = true;
                    this.magentaWrapper.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case Settings.CMYK.YELLOW:
                    this.yellowRadioButton.Checked = true;
                    this.yellowWrapper.BorderStyle = BorderStyle.Fixed3D;
                    break;
                default:
                    this.blackRadioButton.Checked = true;
                    this.blackWrapper.BorderStyle = BorderStyle.Fixed3D;
                    break;
            }

            this.RemoveImagesBorder(this.currentColor);

            this.curvesWrapper.Invalidate();
            this.UpdateCurrentColorImage();
        }

        private void RemoveImagesBorder(Settings.CMYK withoutColor)
        {
            foreach (Settings.CMYK color in Enum.GetValues(typeof(Settings.CMYK)))
                if (color != withoutColor)
                    this.cmykWrappers[color].BorderStyle = BorderStyle.None;
        }

        private void showAllCurvesCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.showAllCurves = this.showAllCurvesCheckbox.Checked;
            this.curvesWrapper.Invalidate();
        }

        private void importImageButton_Click(object sender, EventArgs e)
        {
            if (this.loadImagesThread != null && this.loadImagesThread.IsAlive)
                return;

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
            if (this.loadImagesThread != null && this.loadImagesThread.IsAlive)
                return;

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
            if (this.loadImagesThread != null && this.loadImagesThread.IsAlive)
                return;

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

                        this.curves = new ConcurrentDictionary<Settings.CMYK, Curve>();

                        foreach (var key in result.Keys)
                            this.curves.TryAdd(key, new Curve(this.curvesWrapper.Width, this.curvesWrapper.Height, result[key].PointsX, result[key].PointsY));

                        this.curvesWrapper.Invalidate();
                        this.UpdateCurrentCurveImages();
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
            if (this.loadImagesThread != null && this.loadImagesThread.IsAlive)
                return;

            this.blackAndWhite = this.blackWhiteCheckbox.Checked;
            this.UpdateAllCmykImages();
        }

        private void cyanWrapper_Click(object sender, EventArgs e)
        {
            this.SetCurrentColor(Settings.CMYK.CYAN);
        }

        private void magentaWrapper_Click(object sender, EventArgs e)
        {
            this.SetCurrentColor(Settings.CMYK.MAGENTA);
        }

        private void yellowWrapper_Click(object sender, EventArgs e)
        {
            this.SetCurrentColor(Settings.CMYK.YELLOW);
        }

        private void blackWrapper_Click(object sender, EventArgs e)
        {
            this.SetCurrentColor(Settings.CMYK.BLACK);
        }

        private void saveImageButton_Click(object sender, EventArgs e)
        {
            if (this.loadImagesThread != null && this.loadImagesThread.IsAlive)
                return;

            SaveFileForm saveFileForm = new SaveFileForm();

            saveFileForm.resultImage = (Bitmap)this.resultImageWrapper.Image;
            saveFileForm.cyanImage = (Bitmap)this.cyanWrapper.Image;
            saveFileForm.magentaImage = (Bitmap)this.magentaWrapper.Image;
            saveFileForm.yellowImage = (Bitmap)this.yellowWrapper.Image;
            saveFileForm.blackImage = (Bitmap)this.blackWrapper.Image;

            saveFileForm.SetImages();

            saveFileForm.ShowDialog();
        }
    }
}