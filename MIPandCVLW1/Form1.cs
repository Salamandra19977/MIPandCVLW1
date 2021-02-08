using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIPandCVLW1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkedListBox.SelectedIndex = 0;
        }
        private void SelectBtn_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
            string filePath = openFile.FileName;
            pathTextBox.Text = openFile.FileName;

            new Thread(() => this.ToBlackWhite(new Bitmap(filePath))).Start();
            new Thread(() => this.ToInversion(new Bitmap(filePath))).Start();
            new Thread(() => this.ToBinarization(new Bitmap(filePath))).Start();
            new Thread(() => this.ToExtprop(new Bitmap(filePath))).Start();
            new Thread(() => this.ToIterp(new Bitmap(filePath))).Start();
            new Thread(() => this.Normalization(new Bitmap(filePath))).Start();
            examplePictureBox.Image = new Bitmap(filePath);
        }
        private void LinerHistogrammButton_Click(object sender, EventArgs e)
        {
            switch (checkedListBox.FindString(checkedListBox.SelectedItem.ToString()))
            {
                case 0:
                    new Thread(() => this.ToLinearChart(new Bitmap(examplePictureBox.Image))).Start();
                    break;
                case 1:
                    new Thread(() => this.ToLinearChart(new Bitmap(blackWhitePictureBox.Image))).Start();
                    break;
                case 2:
                    new Thread(() => this.ToLinearChart(new Bitmap(binarizationPictureBox.Image))).Start();
                    break;
                case 3:
                    new Thread(() => this.ToLinearChart(new Bitmap(inversionPictureBox.Image))).Start();
                    break;
                case 4:
                    new Thread(() => this.ToLinearChart(new Bitmap(extrpolPictureBox.Image))).Start();
                    break;
                case 5:
                    new Thread(() => this.ToLinearChart(new Bitmap(iterpPictureBox.Image))).Start();
                    break;
            }
        }
        private void KumHistogrammButton_Click(object sender, EventArgs e)
        {
            switch (checkedListBox.FindString(checkedListBox.SelectedItem.ToString()))
            {
                case 0:
                    new Thread(() => this.ToKumChart(new Bitmap(examplePictureBox.Image))).Start();
                    break;
                case 1:
                    new Thread(() => this.ToKumChart(new Bitmap(blackWhitePictureBox.Image))).Start();
                    break;
                case 2:
                    new Thread(() => this.ToKumChart(new Bitmap(binarizationPictureBox.Image))).Start();
                    break;
                case 3:
                    new Thread(() => this.ToKumChart(new Bitmap(inversionPictureBox.Image))).Start();
                    break;
                case 4:
                    new Thread(() => this.ToKumChart(new Bitmap(extrpolPictureBox.Image))).Start();
                    break;
                case 5:
                    new Thread(() => this.ToKumChart(new Bitmap(iterpPictureBox.Image))).Start();
                    break;
            }
        }
        public void ToBlackWhite(Bitmap img)
        {
            int rgb;
            Color c;

            Bitmap bmp = new Bitmap(img);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    c = bmp.GetPixel(x, y);
                    rgb = (int)Math.Round((double)(c.R + c.G + c.B)/3);
                    bmp.SetPixel(x, y, Color.FromArgb(rgb, rgb, rgb));
                }
            }

            this.Invoke((MethodInvoker)delegate () {
                label2.Text = bmp.Width.ToString() + "x" + bmp.Height.ToString();
                blackWhitePictureBox.Image = bmp;                
            });
        }
        public void ToInversion(Bitmap img)
        {
            Color c;

            Bitmap bmp = new Bitmap(img);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    c = bmp.GetPixel(x, y);
                    bmp.SetPixel(x, y, Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B));
                }
            }

            this.Invoke((MethodInvoker)delegate () {
                inversionPictureBox.Image = bmp;
            });
        }
        public void ToBinarization(Bitmap img)
        {
            Color c;
            Bitmap bmp = new Bitmap(img);
            int value = Convert.ToInt16(valueTextBox.Text);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    c = bmp.GetPixel(x, y);
                    if(255 - (int)c.R > value) bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0)); 
                    else bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }
            }

            this.Invoke((MethodInvoker)delegate () {
                binarizationPictureBox.Image = bmp;
            });
        }
        public void ToExtprop(Bitmap img)
        {
            Color c, nc;
            Bitmap bmp = new Bitmap(img);
            Bitmap newbmp = new Bitmap(img.Width*2, img.Height * 2);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    c = bmp.GetPixel(x, y);
                    nc = newbmp.GetPixel(x*2, y*2);
                    newbmp.SetPixel(x*2, y*2, Color.FromArgb(c.R, c.G, c.B));
                    newbmp.SetPixel(x * 2, y * 2 + 1, Color.FromArgb(nc.R, nc.G, nc.B));
                    newbmp.SetPixel(x * 2 + 1, y * 2, Color.FromArgb(nc.R, nc.G, nc.B));
                }
            }

            this.Invoke((MethodInvoker)delegate () {
                label1.Text = newbmp.Width.ToString() + "x" + newbmp.Height.ToString();
                newbmp.Save("ImageExtrop.jpg");
                extrpolPictureBox.Image = newbmp;
            });
        }
        public void ToIterp(Bitmap img)
        {
            Bitmap bmp = new Bitmap(img);
            int newWidth = (int)(bmp.Width * 2);
            int newHeight = (int)(bmp.Height * 2);
            Bitmap newbmp = new Bitmap(newWidth, newHeight, bmp.PixelFormat);

            for (int x = 0; x < newWidth; x++)
            {
                for (int y = 0; y < newHeight; y++)
                {
                    float gx = ((float)x) / newWidth * (bmp.Width - 1);
                    float gy = ((float)y) / newHeight * (bmp.Height - 1);
                    int gxi = (int)gx;
                    int gyi = (int)gy;
                    Color c00 = bmp.GetPixel(gxi, gyi);
                    Color c10 = bmp.GetPixel(gxi + 1, gyi);
                    Color c01 = bmp.GetPixel(gxi, gyi + 1);
                    Color c11 = bmp.GetPixel(gxi + 1, gyi + 1);

                    int red = (int)Blerp(c00.R, c10.R, c01.R, c11.R, gx - gxi, gy - gyi);
                    int green = (int)Blerp(c00.G, c10.G, c01.G, c11.G, gx - gxi, gy - gyi);
                    int blue = (int)Blerp(c00.B, c10.B, c01.B, c11.B, gx - gxi, gy - gyi);
                    Color rgb = Color.FromArgb(red, green, blue);
                    newbmp.SetPixel(x, y, rgb);
                }
            }

            this.Invoke((MethodInvoker)delegate () {
                label3.Text = newbmp.Width.ToString() + "x" + newbmp.Height.ToString();
                newbmp.Save("ImageIterpol.jpg");
                iterpPictureBox.Image = newbmp;
            });
        }
        private static float Lerp(float s, float e, float t)
        {
            return s + (e - s) * t;
        }
        private static float Blerp(float c00, float c10, float c01, float c11, float tx, float ty)
        {
            return Lerp(Lerp(c00, c10, tx), Lerp(c01, c11, tx), ty);
        }
        public void ToLinearChart(Bitmap img)
        {
            Color c;
            Bitmap bmp = new Bitmap(img);         
            Dictionary<Color, int> history = new Dictionary<Color, int>();
            List<string> value = new List<string>();
            List<int> count = new List<int>();
            List<int> kum = new List<int>();
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    c = bmp.GetPixel(x, y);
                    if (history.ContainsKey(c))
                        history[c] = history[c] + 1;
                    else
                        history.Add(c, 1);
                }
            }

            foreach (Color key in history.Keys)
            {
                value.Add(key.ToString());
                count.Add(history[key]);
                this.Invoke((MethodInvoker)delegate () {
                    textBox1.Text += key.ToString() + "=" + history[key] +"\r\n";
                });
            }

            this.Invoke((MethodInvoker)delegate () {
                chart1.Series["Series1"].Points.DataBindXY(value, count);
            });
        }

        public void ToKumChart(Bitmap img)
        {
            Color c;
            Bitmap bmp = new Bitmap(img);
            Dictionary<Color, int> history = new Dictionary<Color, int>();
            List<string> value = new List<string>();
            List<int> count = new List<int>();
            List<int> kum = new List<int>();
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    c = bmp.GetPixel(x, y);
                    if (history.ContainsKey(c))
                        history[c] = history[c] + 1;
                    else
                        history.Add(c, 1);
                }
            }

            foreach (Color key in history.Keys)
            {
                value.Add(key.ToString());
                count.Add(history[key]);
            }

            kum.Add(count[0]);

            for (int i = 1; i < count.Count; i++)
            {
                int k = count[i];
                int k2 = kum[i - 1];

                kum.Add(count[i] + kum[i - 1]);
            }

            this.Invoke((MethodInvoker)delegate () {
                chart1.Series["Series1"].Points.DataBindXY(value, kum);
            });
        }

        public void Normalization(Bitmap srcImage, double blackPointPercent = 0.1, double whitePointPercent = 0.1)
        {
            //Lock bits for your source image into system memory
            Rectangle rect = new Rectangle(0, 0, srcImage.Width, srcImage.Height);
            BitmapData srcData = srcImage.LockBits(rect, ImageLockMode.ReadOnly,
                PixelFormat.Format32bppArgb);
            //Create a bitmap to which you will write new pixel data
            Bitmap destImage = new Bitmap(srcImage.Width, srcImage.Height);
            //Lock bits for your writable bitmap into system memory
            Rectangle rect2 = new Rectangle(0, 0, destImage.Width, destImage.Height);
            BitmapData destData = destImage.LockBits(rect2, ImageLockMode.WriteOnly,
                PixelFormat.Format32bppArgb);
            //Get the width of a single row of pixels in the bitmap
            int stride = srcData.Stride;
            //Scan for the first pixel data in bitmaps
            IntPtr srcScan0 = srcData.Scan0;
            IntPtr destScan0 = destData.Scan0;
            var freq = new int[256];
            unsafe
            {
                //Create an array of pixel data from source image
                byte* src = (byte*)srcScan0;
                //Get the number of pixels for each intensity value
                for (int y = 0; y < srcImage.Height; ++y)
                {
                    for (int x = 0; x < srcImage.Width; ++x)
                    {
                        freq[src[y * stride + x * 4]]++;
                    }
                }
                //Get the total number of pixels in the image
                int numPixels = srcImage.Width * srcImage.Height;
                //Set the minimum intensity value of an image (0 = black)
                int minI = 0;
                //Get the total number of black pixels
                var blackPixels = numPixels * blackPointPercent;
                //Set a variable for summing up the pixels that will turn black
                int accum = 0;
                //Sum up the darkest shades until you reach the total of black pixels
                while (minI < 255)
                {
                    accum += freq[minI];
                    if (accum > blackPixels) break;
                    minI++;
                }
                //Set the maximum intensity of an image (255 = white)
                int maxI = 255;
                //Set the total number of white pixels
                var whitePixels = numPixels * whitePointPercent;
                //Reset the summing variable back to 0
                accum = 0;
                //Sum up the pixels that are the lightest which will turn white
                while (maxI > 0)
                {
                    accum += freq[maxI];
                    if (accum > whitePixels) break;
                    maxI--;
                }
                //Part of a normalization equation that doesn't vary with each pixel
                double spread = 255d / (maxI - minI);
                //Create an array of pixel data from created image
                byte* dst = (byte*)destScan0;
                //Write new pixel data to the image
                for (int y = 0; y < srcImage.Height; ++y)
                {
                    for (int x = 0; x < srcImage.Width; ++x)
                    {
                        int i = y * stride + x * 4;
                        //Part of equation that varies with each pixel
                        double value = Math.Round((src[i] - minI) * spread);
                        byte val = (byte)(Math.Min(Math.Max(value, 0), 255));
                        dst[i] = val;
                        dst[i + 1] = val;
                        dst[i + 2] = val;
                        dst[i + 3] = 255;
                    }
                }
            }
            //Unlock bits from system memory
            srcImage.UnlockBits(srcData);
            destImage.UnlockBits(destData);

            this.Invoke((MethodInvoker)delegate () {
                normalPictureBox.Image = destImage;
            });
        }

        private void ExtrpolPictureBox_Click(object sender, EventArgs e)
        {
            new Image(new Bitmap(extrpolPictureBox.Image)).Show();
        }

        private void IterpPictureBox_Click(object sender, EventArgs e)
        {
            new Image(new Bitmap(iterpPictureBox.Image)).Show();
        }
    }
}
