using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewtonFractal
{
    public partial class NewtonFractalForm : Form
    {
        public NewtonFractalForm()
        {
            InitializeComponent();
            iterationsNumUpDown.Value = 20;
            framesNumUpDown.Value = 300;
            frameLabel.Text = "";
            newtonFractalpictureBox.Image = Fractal.GetImage(type, newtonFractalpictureBox.Width, newtonFractalpictureBox.Height, iterCount, eps, pxl, rotateX, rotateY, angle);

        }

        double eps = 0.5;
        int iterCount = 25;
        int frames = 300;
        double FACTOR = 0.98;
        int angle = 0;
        int rotateX = 0;
        int rotateY = 0;
        Type type = Type.SEQUENTIALLY;

        void updateParameters()
        {
            iterCount = (int)iterationsNumUpDown.Value;
            frames = (int)framesNumUpDown.Value;
            try
            {
                eps = Convert.ToDouble(epsTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for Epsilon!");
            }
            if (seqRadioButton.Checked)
            {
                type = Type.SEQUENTIALLY;
            }
            else if (paralRadioButton.Checked)
            {
                type = Type.PARALLEL;
            }
            try
            {
                angle = Convert.ToInt32(angleTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for Angle!");
            }
            try
            {
                rotateX = Convert.ToInt32(rotationXtextBox.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for Rotation Center: X!");
            }
            try
            {
                rotateY = Convert.ToInt32(rotationYtextBox.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for Rotation Center: Y!");
            }

        }

        int counter = 1;
        double pxl = 0.1;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            newtonFractalpictureBox.Image = Fractal.GetImage(type, newtonFractalpictureBox.Width, newtonFractalpictureBox.Height, iterCount, eps, pxl, rotateX, rotateY, angle);
            if (counter <= frames)
            {
                frameLabel.Text = counter.ToString();
                counter++;
            }
            else
            {
                timer1.Stop();
            }
            pxl *= FACTOR;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            updateParameters();
            timer1.Start();
            stopButton.Enabled = true;
            startButton.Enabled = false;
            showButton.Enabled = false;
            saveButton.Enabled = false;
            iterationsNumUpDown.Enabled = false;
            framesNumUpDown.Enabled = false;
            fullScreenCheckBox.Enabled = false;
            epsTextBox.Enabled = false;
            groupBox1.Enabled = false;
            angleTextBox.Enabled = false;
            rotationXtextBox.Enabled = false;
            rotationYtextBox.Enabled = false;
            rotateButton.Enabled = false;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            stopButton.Enabled = false;
            startButton.Enabled = true;
            counter = 1;
            frameLabel.Text = "";
            showButton.Enabled = true;
            saveButton.Enabled = true;
            iterationsNumUpDown.Enabled = true;
            framesNumUpDown.Enabled = true;
            fullScreenCheckBox.Enabled = true;
            epsTextBox.Enabled = true;
            groupBox1.Enabled = true;
            angleTextBox.Enabled = true;
            rotationXtextBox.Enabled = true;
            rotationYtextBox.Enabled = true;
            rotateButton.Enabled = true;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            updateParameters();
            if (fullScreenCheckBox.Checked)
            {
                FullScreenForm frm = new FullScreenForm(type, iterCount, eps, pxl, 0, 0, angle);
                frm.Show();
            }
            newtonFractalpictureBox.Image = Fractal.GetImage(type, newtonFractalpictureBox.Width, newtonFractalpictureBox.Height, iterCount, eps, pxl, 0, 0, angle);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                newtonFractalpictureBox.Image.Save(sfd.FileName, format);
            }
        }

        private void rotateButton_Click(object sender, EventArgs e)
        {
            updateParameters();
            newtonFractalpictureBox.Image = Fractal.GetImage(type, newtonFractalpictureBox.Width, newtonFractalpictureBox.Height, iterCount, eps, pxl, rotateX, rotateY, angle);

        }
    }
}
