namespace NewtonFractal
{
    partial class IterationsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.newtonPictureBox = new System.Windows.Forms.PictureBox();
            this.numberOfIterationsNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stopButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.iterationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.newtonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfIterationsNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // newtonPictureBox
            // 
            this.newtonPictureBox.Location = new System.Drawing.Point(12, 12);
            this.newtonPictureBox.Name = "newtonPictureBox";
            this.newtonPictureBox.Size = new System.Drawing.Size(704, 557);
            this.newtonPictureBox.TabIndex = 0;
            this.newtonPictureBox.TabStop = false;
            // 
            // numberOfIterationsNumUpDown
            // 
            this.numberOfIterationsNumUpDown.Location = new System.Drawing.Point(775, 33);
            this.numberOfIterationsNumUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numberOfIterationsNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfIterationsNumUpDown.Name = "numberOfIterationsNumUpDown";
            this.numberOfIterationsNumUpDown.Size = new System.Drawing.Size(120, 22);
            this.numberOfIterationsNumUpDown.TabIndex = 2;
            this.numberOfIterationsNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(772, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of iterations";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(775, 77);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(857, 77);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 5;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(775, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Iteration: ";
            // 
            // iterationLabel
            // 
            this.iterationLabel.AutoSize = true;
            this.iterationLabel.Location = new System.Drawing.Point(849, 122);
            this.iterationLabel.Name = "iterationLabel";
            this.iterationLabel.Size = new System.Drawing.Size(75, 17);
            this.iterationLabel.TabIndex = 7;
            this.iterationLabel.Text = "<iteration>";
            // 
            // NewtonFractalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 581);
            this.Controls.Add(this.iterationLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberOfIterationsNumUpDown);
            this.Controls.Add(this.newtonPictureBox);
            this.Name = "NewtonFractalForm";
            this.Text = "Newton Fractal";
            ((System.ComponentModel.ISupportInitialize)(this.newtonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfIterationsNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox newtonPictureBox;
        private System.Windows.Forms.NumericUpDown numberOfIterationsNumUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label iterationLabel;
    }
}

