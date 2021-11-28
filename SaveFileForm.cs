using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gk_p3
{
    public partial class SaveFileForm : Form
    {
        public Bitmap resultImage;
        public Bitmap cyanImage;
        public Bitmap magentaImage;
        public Bitmap yellowImage;
        public Bitmap blackImage;

        private SELECTED_FILE currenFile = SELECTED_FILE.RESULT;

        private enum SELECTED_FILE
        {
            RESULT,
            CYAN,
            MAGENTA,
            YELLOW,
            BLACK
        }

        public SaveFileForm()
        {
            InitializeComponent();
        }

        public void SetImages()
        {
            this.resultImageWrapper.Image = this.resultImage;
            this.cyanWrapper.Image = this.cyanImage;
            this.magentaWrapper.Image = this.magentaImage;
            this.yellowWrapper.Image = this.yellowImage;
            this.blackWrapper.Image = this.blackImage;
        }

        private void DeleteWrappersBorder()
        {
            this.resultImageWrapper.BorderStyle = BorderStyle.None;
            this.cyanWrapper.BorderStyle = BorderStyle.None;
            this.magentaWrapper.BorderStyle = BorderStyle.None;
            this.yellowWrapper.BorderStyle = BorderStyle.None;
            this.blackWrapper.BorderStyle = BorderStyle.None;
        }

        private void cyanWrapper_Click(object sender, EventArgs e)
        {
            this.DeleteWrappersBorder();
            this.cyanWrapper.BorderStyle = BorderStyle.Fixed3D;
            this.currenFile = SELECTED_FILE.CYAN;
        }

        private void magentaWrapper_Click(object sender, EventArgs e)
        {
            this.DeleteWrappersBorder();
            this.magentaWrapper.BorderStyle = BorderStyle.Fixed3D;
            this.currenFile = SELECTED_FILE.MAGENTA;
        }
        private void yellowWrapper_Click(object sender, EventArgs e)
        {
            this.DeleteWrappersBorder();
            this.yellowWrapper.BorderStyle = BorderStyle.Fixed3D;
            this.currenFile = SELECTED_FILE.YELLOW;
        }

        private void blackWrapper_Click(object sender, EventArgs e)
        {
            this.DeleteWrappersBorder();
            this.blackWrapper.BorderStyle = BorderStyle.Fixed3D;
            this.currenFile = SELECTED_FILE.BLACK;
        }

        private void resultImageWrapper_Click(object sender, EventArgs e)
        {
            this.DeleteWrappersBorder();
            this.resultImageWrapper.BorderStyle = BorderStyle.Fixed3D;
            this.currenFile = SELECTED_FILE.RESULT;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Bitmap image;

            switch (this.currenFile)
            {
                case SELECTED_FILE.CYAN:
                    image = this.cyanImage;
                    break;
                case SELECTED_FILE.MAGENTA:
                    image = this.magentaImage;
                    break;
                case SELECTED_FILE.YELLOW:
                    image = this.yellowImage;
                    break;
                case SELECTED_FILE.BLACK:
                    image = this.blackImage;
                    break;
                default:
                    image = this.resultImage;
                    break;
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Files|*.jpg;*.jpeg;*.png;";
            dialog.DefaultExt = "jpeg";
            dialog.Title = "Save image to file";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image.Save(dialog.FileName, ImageFormat.Jpeg);
                this.Close();
            }
        }
    }
}
