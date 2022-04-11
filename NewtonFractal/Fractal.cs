using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NewtonFractal
{
    class Fractal
    {
        public static Bitmap GetImage(Type type, int width, int height, int iterCount, double eps, double pxl, int centerX, int centerY, int alpha = 0)
        {
            switch (type)
            {
                case Type.SEQUENTIALLY:
                    return GetImageSeq(width, height, iterCount, eps, pxl, centerX, centerY, alpha);
                case Type.PARALLEL:
                    return GetImageParallel(width, height, iterCount, eps, pxl, centerX, centerY, alpha);
                default:
                    return GetImageSeq(width, height, iterCount, eps, pxl, centerX, centerY, alpha);
            }
        }

        private static Bitmap GetImageSeq(int width, int height, int iterCount, double eps, double pxl, int centerX, int centerY, int alpha)
        {
            Complex r1 = new Complex(1.0, 0.0);
            Complex r2 = new Complex(-0.5, Math.Sin(0.66 * Math.PI));
            Complex r3 = new Complex(-0.5, -Math.Sin(0.66 * Math.PI));

            int X0 = width / 2;
            int Y0 = height / 2;

            Bitmap image = new Bitmap(width, height);
            int count = 0;

            double c = Math.Cos(alpha), s = Math.Sin(alpha);

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    double x = (i - X0) * pxl;
                    double y = (j - Y0) * pxl;

                    Complex z = new Complex(x * c - y * s + centerX, x * s + y * c + centerY);

                    count = 0;
                    while (count < iterCount && Complex.Abs(z - r1) >= eps && Complex.Abs(z - r2) >= eps && Complex.Abs(z - r3) >= eps)
                    {
                        if (Complex.Abs(z) > 0.0)
                        {
                            z = z - (z * z * z - Complex.One) / (new Complex(3, 0) * z * z);
                        }
                        count = count + 1;
                    }
                    Color color = Color.Black;
                    if (Complex.Abs(z - r1) <= eps)
                    {
                        color = Color.Red;
                    }
                    if (Complex.Abs(z - r2) <= eps)
                    {
                        color = Color.Blue;
                    }
                    if (Complex.Abs(z - r3) <= eps)
                    {
                        color = Color.Green;
                    }
                    image.SetPixel(i, j, color);
                }
            }
            return image;
        }

        private static Bitmap GetImageParallel(int width, int height, int iterCount, double eps, double pxl, int centerX, int centerY, int alpha)
        {
            Complex r1 = new Complex(1.0, 0.0);
            Complex r2 = new Complex(-0.5, Math.Sin(0.66 * Math.PI));
            Complex r3 = new Complex(-0.5, -Math.Sin(0.66 * Math.PI));

            int X0 = width / 2;
            int Y0 = height / 2;

            Bitmap image = new Bitmap(width, height);

            Color[,] colors = new Color[width, height];
            double c = Math.Cos(alpha), s = Math.Sin(alpha);
            
            Parallel.For(0, width, i => {
                Parallel.For(0, height, j => {
                    double x = (i - X0) * pxl;
                    double y = (j - Y0) * pxl;
                    Complex z = new Complex(x * c - y * s + centerX, x * s + y * c + centerY);
                    int count = 0;
                    while (count < iterCount && Complex.Abs(z - r1) >= eps && Complex.Abs(z - r2) >= eps && Complex.Abs(z - r3) >= eps)
                    {
                        if (Complex.Abs(z) > 0.0)
                        {
                            z = z - (z * z * z - Complex.One) / (new Complex(3, 0) * z * z);
                        }
                        count = count + 1;
                    }
                    Color color = Color.Black;
                    if (Complex.Abs(z - r1) <= eps)
                    {
                        color = Color.Red;
                    }
                    if (Complex.Abs(z - r2) <= eps)
                    {
                        color = Color.Blue;
                    }
                    if (Complex.Abs(z - r3) <= eps)
                    {
                        color = Color.Green;
                    }
                    colors[i, j] = color;
                });
            });

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++){
                    image.SetPixel(i, j, colors[i, j]);
                }
            }

            return image;
        }

    }
}
