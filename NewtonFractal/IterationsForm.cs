using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewtonFractal
{
    public partial class IterationsForm : Form
    {
        public IterationsForm()
        {
            InitializeComponent();
            numberOfIterationsNumUpDown.Value = 50;
            iterationLabel.Text = "";
        }

        double Tol = 0.5;
        int counter = 1;
        int numberOfIterations = 0;

        double PXL = 0.1;
        void fractal(int MaxCount, double Tol)
        {
            Complex r1 = new Complex(1.0, 0.0);
            Complex r2 = new Complex(-0.5, Math.Sin(0.66 * Math.PI));
            Complex r3 = new Complex(-0.5, -Math.Sin(0.66 * Math.PI));

            int width = newtonPictureBox.Width;
            int height = newtonPictureBox.Height;
            int X0 = width / 2;
            int Y0 = height / 2;

            Bitmap image = new Bitmap(width, height);
            double maxMod = 0.0;
            int count = 0;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    double x = (i - X0) * PXL;
                    double y = (j - Y0) * PXL;
                    Complex z = new Complex(x, y);
                    count = 0;
                    while (count < MaxCount && Complex.Abs(z - r1) >= Tol && Complex.Abs(z - r2) >= Tol && Complex.Abs(z - r3) >= Tol)
                    {
                        if (Complex.Abs(z) > 0.0)
                        {
                            z = z - (z * z * z - Complex.One) / (new Complex(3, 0) * z * z);
                        }
                        if (Complex.Abs(z) > maxMod)
                        {
                            maxMod = Complex.Abs(z);
                        }
                        count = count + 1;
                    }
                    Color color = Color.Black;
                    if (Complex.Abs(z - r1) <= Tol)
                    {
                        color = Color.Red;
                    }
                    if (Complex.Abs(z - r2) <= Tol)
                    {
                        color = Color.Blue;
                    }
                    if (Complex.Abs(z - r3) <= Tol)
                    {
                        color = Color.Green;
                    }
                    int xmin = image.Width;
                    int ymin = image.Height;
                    image.SetPixel(i, j, color);
                }
            }
            newtonPictureBox.Image = image;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            fractal(counter, Tol);
            if (counter <= numberOfIterations)
            {
                iterationLabel.Text = counter.ToString();
                counter++;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            numberOfIterations = (int)numberOfIterationsNumUpDown.Value;
            timer1.Start();
            stopButton.Enabled = true;
            startButton.Enabled = false;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            stopButton.Enabled = false;
            startButton.Enabled = true;
            counter = 1;
            iterationLabel.Text = "";
        }

        //private void trackBar1_Scroll(object sender, EventArgs e)
        //{
        //    Bitmap scaled_image = new Bitmap(image);
        //    Graphics graphics = Graphics.FromImage(scaled_image);
        //    float scale = 1 + (float)trackBar1.Value / 10;

        //    int width = image.Width;
        //    int height = image.Height;

        //    RectangleF destinationRect = new RectangleF(0, 0, scale * width, scale * height);
        //    RectangleF sourceRect = new RectangleF(0, 0, width, height);
        //    graphics.DrawImage(scaled_image, destinationRect, sourceRect, GraphicsUnit.Pixel);
        //    newtonPictureBox.Image = scaled_image;
        //}

    }
}
