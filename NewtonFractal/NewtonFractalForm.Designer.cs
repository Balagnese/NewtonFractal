namespace NewtonFractal
{
    partial class NewtonFractalForm
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
            this.newtonFractalpictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.iterationsNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.framesNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.frameLabel = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.fullScreenCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.epsTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.paralRadioButton = new System.Windows.Forms.RadioButton();
            this.seqRadioButton = new System.Windows.Forms.RadioButton();
            this.rotateButton = new System.Windows.Forms.Button();
            this.angleTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rotationXtextBox = new System.Windows.Forms.TextBox();
            this.rotationYtextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.newtonFractalpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.framesNumUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newtonFractalpictureBox
            // 
            this.newtonFractalpictureBox.Location = new System.Drawing.Point(12, 8);
            this.newtonFractalpictureBox.Name = "newtonFractalpictureBox";
            this.newtonFractalpictureBox.Size = new System.Drawing.Size(855, 600);
            this.newtonFractalpictureBox.TabIndex = 0;
            this.newtonFractalpictureBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(1018, 548);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(120, 23);
            this.stopButton.TabIndex = 11;
            this.stopButton.Text = "Stop falling";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(882, 548);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(118, 23);
            this.startButton.TabIndex = 10;
            this.startButton.Text = "Start falling";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(873, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Iterations";
            // 
            // iterationsNumUpDown
            // 
            this.iterationsNumUpDown.Location = new System.Drawing.Point(876, 133);
            this.iterationsNumUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.iterationsNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.iterationsNumUpDown.Name = "iterationsNumUpDown";
            this.iterationsNumUpDown.Size = new System.Drawing.Size(120, 22);
            this.iterationsNumUpDown.TabIndex = 8;
            this.iterationsNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(879, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Frames";
            // 
            // framesNumUpDown
            // 
            this.framesNumUpDown.Location = new System.Drawing.Point(882, 503);
            this.framesNumUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.framesNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.framesNumUpDown.Name = "framesNumUpDown";
            this.framesNumUpDown.Size = new System.Drawing.Size(120, 22);
            this.framesNumUpDown.TabIndex = 12;
            this.framesNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(883, 590);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "FRAME:";
            // 
            // frameLabel
            // 
            this.frameLabel.AutoSize = true;
            this.frameLabel.Location = new System.Drawing.Point(949, 590);
            this.frameLabel.Name = "frameLabel";
            this.frameLabel.Size = new System.Drawing.Size(60, 17);
            this.frameLabel.TabIndex = 15;
            this.frameLabel.Text = "<frame>";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(882, 204);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(118, 23);
            this.showButton.TabIndex = 16;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(882, 246);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(118, 23);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // fullScreenCheckBox
            // 
            this.fullScreenCheckBox.AutoSize = true;
            this.fullScreenCheckBox.Location = new System.Drawing.Point(1018, 204);
            this.fullScreenCheckBox.Name = "fullScreenCheckBox";
            this.fullScreenCheckBox.Size = new System.Drawing.Size(95, 21);
            this.fullScreenCheckBox.TabIndex = 18;
            this.fullScreenCheckBox.Text = "Fullscreen";
            this.fullScreenCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(876, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Epsilon";
            // 
            // epsTextBox
            // 
            this.epsTextBox.Location = new System.Drawing.Point(936, 166);
            this.epsTextBox.Name = "epsTextBox";
            this.epsTextBox.Size = new System.Drawing.Size(100, 22);
            this.epsTextBox.TabIndex = 20;
            this.epsTextBox.Text = "0.5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.paralRadioButton);
            this.groupBox1.Controls.Add(this.seqRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(879, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 79);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Run";
            // 
            // paralRadioButton
            // 
            this.paralRadioButton.AutoSize = true;
            this.paralRadioButton.Location = new System.Drawing.Point(7, 49);
            this.paralRadioButton.Name = "paralRadioButton";
            this.paralRadioButton.Size = new System.Drawing.Size(90, 21);
            this.paralRadioButton.TabIndex = 1;
            this.paralRadioButton.Text = "in parallel";
            this.paralRadioButton.UseVisualStyleBackColor = true;
            // 
            // seqRadioButton
            // 
            this.seqRadioButton.AutoSize = true;
            this.seqRadioButton.Checked = true;
            this.seqRadioButton.Location = new System.Drawing.Point(7, 22);
            this.seqRadioButton.Name = "seqRadioButton";
            this.seqRadioButton.Size = new System.Drawing.Size(104, 21);
            this.seqRadioButton.TabIndex = 0;
            this.seqRadioButton.TabStop = true;
            this.seqRadioButton.Text = "sequentially";
            this.seqRadioButton.UseVisualStyleBackColor = true;
            // 
            // rotateButton
            // 
            this.rotateButton.Location = new System.Drawing.Point(882, 409);
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(118, 23);
            this.rotateButton.TabIndex = 22;
            this.rotateButton.Text = "Rotate";
            this.rotateButton.UseVisualStyleBackColor = true;
            this.rotateButton.Click += new System.EventHandler(this.rotateButton_Click);
            // 
            // angleTextBox
            // 
            this.angleTextBox.Location = new System.Drawing.Point(936, 370);
            this.angleTextBox.Name = "angleTextBox";
            this.angleTextBox.Size = new System.Drawing.Size(100, 22);
            this.angleTextBox.TabIndex = 23;
            this.angleTextBox.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(882, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Angle ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(879, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Rotation center";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(882, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "X";
            // 
            // rotationXtextBox
            // 
            this.rotationXtextBox.Location = new System.Drawing.Point(906, 331);
            this.rotationXtextBox.Name = "rotationXtextBox";
            this.rotationXtextBox.Size = new System.Drawing.Size(100, 22);
            this.rotationXtextBox.TabIndex = 27;
            this.rotationXtextBox.Text = "0";
            // 
            // rotationYtextBox
            // 
            this.rotationYtextBox.Location = new System.Drawing.Point(1043, 331);
            this.rotationYtextBox.Name = "rotationYtextBox";
            this.rotationYtextBox.Size = new System.Drawing.Size(100, 22);
            this.rotationYtextBox.TabIndex = 29;
            this.rotationYtextBox.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1019, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Y";
            // 
            // NewtonFractalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 625);
            this.Controls.Add(this.rotationYtextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rotationXtextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.angleTextBox);
            this.Controls.Add(this.rotateButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.epsTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fullScreenCheckBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.frameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.framesNumUpDown);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iterationsNumUpDown);
            this.Controls.Add(this.newtonFractalpictureBox);
            this.Name = "NewtonFractalForm";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.newtonFractalpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.framesNumUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox newtonFractalpictureBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown iterationsNumUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown framesNumUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label frameLabel;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckBox fullScreenCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox epsTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton paralRadioButton;
        private System.Windows.Forms.RadioButton seqRadioButton;
        private System.Windows.Forms.Button rotateButton;
        private System.Windows.Forms.TextBox angleTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rotationXtextBox;
        private System.Windows.Forms.TextBox rotationYtextBox;
        private System.Windows.Forms.Label label8;
    }
}