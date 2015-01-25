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

namespace PhotoEditor
{
    public partial class PhotoEditor : Form
    {
        Image saveImg, edittedImg;
        Rectangle selection;
        Boolean dragging = false;
        Boolean selected = false;
        Pen pen = new Pen(Color.White, 2);
        Point origin;
        Rectangle empty = new Rectangle(0, 0, 0, 0);

        public PhotoEditor()
        {
            InitializeComponent();
            DoubleBuffered = false;
        }

        private void reset()
        {
            brightnessBar.Value = 4;
            contrastBar.Value = 4;
            gammaBar.Value = 4;
            rBar.Value = 4;
            gBar.Value = 4;
            bBar.Value = 4;
            selection = new Rectangle(0, 0, 0, 0);
            selected = false;
        }

        private void open_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select an image file";
            dialog.Filter = "Image files(bmp, jpg, png, tiff)|*.bmp;*.jpg;*.jpeg;*.png;*.tiff";
            dialog.InitialDirectory = @"C:\";

            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.Cancel) return;

            String filename = dialog.FileName;
            if(filename == "" || filename == null)
            {
                MessageBox.Show("Bad File Path!", "Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                Image img = Image.FromFile(filename);
                reset();
                mainImage.Image = img;
                saveImg = img;
                edittedImg = img;
            }   
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (saveImg != null)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "PNG file|*.bmp;*.jpg;*.jpeg;*.png;*.tiff";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    mainImage.Image.Save(dialog.FileName, ImageFormat.Png);
                }
            }
        }

        /* Revert the picture back to original state */
        private void original_Click(object sender, EventArgs e)
        {
            mainImage.Image = saveImg;
            edittedImg = saveImg;
            reset();
        }

        private void PhotoEditor_Resize(object sender, EventArgs e)
        {
            imageContainer.Height = this.Height - 125;
            imageContainer.Width = this.Width - 15;
        }

        
        /* Attempt at Smooth scroll drawing*/
        //private void imageContainer_Scroll(object sender, ScrollEventArgs e)
        //{
        //    //Create a graphics object and draw a portion of the image in the PictureBox.
        //    Graphics g = mainImage.CreateGraphics();

        //    int xWidth = mainImage.Width;
        //    int yHeight = mainImage.Height;

        //    int x;
        //    int y;

        //    if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
        //    {
        //        x = e.NewValue;
        //        y = imageContainer.VerticalScroll.Value;
        //    }
        //    else //e.ScrollOrientation == ScrollOrientation.VerticalScroll
        //    {
        //        y = e.NewValue;
        //        x = imageContainer.HorizontalScroll.Value;
        //    }

        //    g.DrawImage(mainImage.Image,
        //      new Rectangle(0, 0, xWidth, yHeight),  //where to draw the image 
        //      new Rectangle(x, y, xWidth, yHeight),  //the portion of the image to draw
        //      GraphicsUnit.Pixel);

        //    mainImage.Update();
        //}

        //http://blog.bee-eee.com/2008/01/23/c-adjusting-brightnesscontrast-and-gamma-of-an-image/
        private void colorMatrixEdit(float brightness, float contrast, float gamma, float r, float g, float b)
        {
            Bitmap originalImage = (Bitmap)edittedImg.Clone();

            float trueBrightness = brightness - 1;
            if (gamma == 0) gamma = 0.01f;

            float[][] ptsArray ={
                new float[] {contrast * r, 0, 0, 0, 0}, // scale red
                new float[] {0, contrast * g, 0, 0, 0}, // scale green
                new float[] {0, 0, contrast * b, 0, 0}, // scale blue
                new float[] {0, 0, 0, 1.0f, 0}, // don't scale alpha
                new float[] {trueBrightness, trueBrightness, trueBrightness, 0, 1}};

            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.ClearColorMatrix();
            imageAttributes.SetColorMatrix(new ColorMatrix(ptsArray), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            imageAttributes.SetGamma(gamma, ColorAdjustType.Bitmap);
            Graphics gr = Graphics.FromImage(originalImage);
            gr.DrawImage(originalImage, new Rectangle(0, 0, originalImage.Width, originalImage.Height)
                , 0, 0, originalImage.Width, originalImage.Height,
                GraphicsUnit.Pixel, imageAttributes);

            mainImage.Image = originalImage;
        }

        private void scrollAction()
        {
            if (edittedImg != null)
            {
                float brightness = brightnessBar.Value * 0.25f;
                float contrast = contrastBar.Value * 0.25f;
                float gamma = gammaBar.Value * 0.25f;
                float r = rBar.Value * 0.25f;
                float g = gBar.Value * 0.25f;
                float b = bBar.Value * 0.25f;

                colorMatrixEdit(brightness, contrast, gamma, r, g, b);
            }
        }


        private void brightnessBar_Scroll(object sender, EventArgs e)
        {
            scrollAction();
        }

        private void contrastBar_Scroll(object sender, EventArgs e)
        {
            scrollAction();
        }

        private void gammaBar_Scroll(object sender, EventArgs e)
        {
            scrollAction();
        }

        private void rBar_Scroll(object sender, EventArgs e)
        {
            scrollAction();
        }

        private void gBar_Scroll(object sender, EventArgs e)
        {
            scrollAction();
        }

        private void bBar_Scroll(object sender, EventArgs e)
        {
            scrollAction();
        }

        private void grayscale_Click(object sender, EventArgs e)
        {
            if (saveImg != null)
            {
                Bitmap originalImage = (Bitmap)saveImg.Clone();

                float[][] ptsArray =
                {
                    new float[] {.3f, .3f, .3f, 0, 0},
                    new float[] {.59f, .59f, .59f, 0, 0},
                    new float[] {.11f, .11f, .11f, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1}
                };

                ImageAttributes imageAttributes = new ImageAttributes();
                imageAttributes.ClearColorMatrix();
                imageAttributes.SetColorMatrix(new ColorMatrix(ptsArray), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                Graphics gr = Graphics.FromImage(originalImage);
                gr.DrawImage(originalImage, new Rectangle(0, 0, originalImage.Width, originalImage.Height)
                    , 0, 0, originalImage.Width, originalImage.Height,
                    GraphicsUnit.Pixel, imageAttributes);

                mainImage.Image = originalImage;
                edittedImg = originalImage;
                reset();
            }
        }

        private void sepia_Click(object sender, EventArgs e)
        {
            if (saveImg != null)
            {
                Bitmap originalImage = (Bitmap)saveImg.Clone();

                float[][] ptsArray =
                {
                    new float[]{.393f, .349f, .272f, 0, 0},
                    new float[]{.769f, .686f, .534f, 0, 0},
                    new float[]{.189f, .168f, .131f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                };

                ImageAttributes imageAttributes = new ImageAttributes();
                imageAttributes.ClearColorMatrix();
                imageAttributes.SetColorMatrix(new ColorMatrix(ptsArray), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                Graphics gr = Graphics.FromImage(originalImage);
                gr.DrawImage(originalImage, new Rectangle(0, 0, originalImage.Width, originalImage.Height)
                    , 0, 0, originalImage.Width, originalImage.Height,
                    GraphicsUnit.Pixel, imageAttributes);

                mainImage.Image = originalImage;
                edittedImg = originalImage;
                reset();
            }
        }

        private void invert_Click(object sender, EventArgs e)
        {
            if (saveImg != null)
            {
                Bitmap originalImage = (Bitmap)saveImg.Clone();

                float[][] ptsArray =
                {
                    new float[]{-1, 0, 0, 0, 0},
                    new float[]{0, -1, 0, 0, 0},
                    new float[]{0, 0, -1, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{1, 1, 1, 0, 1}
                };

                ImageAttributes imageAttributes = new ImageAttributes();
                imageAttributes.ClearColorMatrix();
                imageAttributes.SetColorMatrix(new ColorMatrix(ptsArray), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                Graphics gr = Graphics.FromImage(originalImage);
                gr.DrawImage(originalImage, new Rectangle(0, 0, originalImage.Width, originalImage.Height)
                    , 0, 0, originalImage.Width, originalImage.Height,
                    GraphicsUnit.Pixel, imageAttributes);

                mainImage.Image = originalImage;
                edittedImg = originalImage;
                reset();
            }
        }

        /*                                */
        /* Drag to select an area to edit */
        /*                                */
        private void mainImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (saveImg != null)
            {
                origin = mainImage.PointToClient(Cursor.Position);
                selection = new Rectangle(origin, new Size(0, 0));
                dragging = true;
            }
        }

        private void mainImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point point = mainImage.PointToClient(Cursor.Position);
                selection.Width = Math.Abs(origin.X - point.X);
                selection.Height = Math.Abs(origin.Y - point.Y);
                selection.X = Math.Min(origin.X, point.X);
                selection.Y = Math.Min(origin.Y, point.Y);

                mainImage.Invalidate();
                selected = true;
            }
        }

        private void mainImage_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void mainImage_Paint(object sender, PaintEventArgs e)
        {
            if (dragging && !selection.Equals(empty)) {
                e.Graphics.DrawRectangle(pen, selection);
            }
        }

        private void flip_Click(object sender, EventArgs e)
        {
            if (saveImg != null)
            {
                flipDialog flp = new flipDialog();
                flp.ShowDialog();
                if (flp.result == 1)
                {
                    Bitmap copy = mainImage.Image as Bitmap;
                    copy.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    mainImage.Image = copy;
                    saveImg = mainImage.Image;
                    edittedImg = mainImage.Image;
                }
                else if (flp.result == 2)
                {
                    Bitmap copy = mainImage.Image as Bitmap;
                    copy.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    mainImage.Image = copy;
                    saveImg = mainImage.Image;
                    edittedImg = mainImage.Image;
                }
                mainImage.Invalidate();
            }
       }

        private void rotate_Click(object sender, EventArgs e)
        {
            if (saveImg != null)
            {
                rotateDialog rt = new rotateDialog();
                rt.ShowDialog();
                if (rt.result == 1)
                {
                    Bitmap copy = mainImage.Image as Bitmap;
                    copy.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    mainImage.Image = copy;
                    saveImg = mainImage.Image;
                    edittedImg = mainImage.Image;
                }
                else if (rt.result == 2)
                {
                    Bitmap copy = mainImage.Image as Bitmap;
                    copy.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    mainImage.Image = copy;
                    saveImg = mainImage.Image;
                    edittedImg = mainImage.Image;
                }
                else if (rt.result == 3)
                {
                    Bitmap copy = mainImage.Image as Bitmap;
                    copy.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    mainImage.Image = copy;
                    saveImg = mainImage.Image;
                    edittedImg = mainImage.Image;
                }
                mainImage.Invalidate();
            }
        }


        /*                            */
        /* Crop out the selected area */
        /*                            */
        private void crop_Click(object sender, EventArgs e)
        {
            if (selected)
            {
                Bitmap image = mainImage.Image as Bitmap;
                Bitmap cropped = image.Clone(selection, image.PixelFormat);
                mainImage.Image = cropped as Image;
                saveImg = mainImage.Image;
                edittedImg = mainImage.Image;
                reset();
            }
        }
    }
}
