using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewtonFractal
{
    public partial class FullScreenForm : Form
    {
        public FullScreenForm(Type type, int iterCount, double eps, double pxl, int centerX, int centerY, int alpha = 0)
        {
            InitializeComponent();
            WindowState = FormWindowState.Normal;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Bounds = Screen.PrimaryScreen.Bounds;

            newtonFractalpictureBox.Image = Fractal.GetImage(type, newtonFractalpictureBox.Width, newtonFractalpictureBox.Height, iterCount, eps, pxl, centerX, centerY, alpha);

        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (e.KeyChar == (char)Keys.Escape)
                Close();
        }
    }
}
