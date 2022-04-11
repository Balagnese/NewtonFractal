namespace NewtonFractal
{
    partial class FullScreenForm
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
            this.newtonFractalpictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.newtonFractalpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // newtonFractalpictureBox
            // 
            this.newtonFractalpictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newtonFractalpictureBox.Location = new System.Drawing.Point(0, 0);
            this.newtonFractalpictureBox.Name = "newtonFractalpictureBox";
            this.newtonFractalpictureBox.Size = new System.Drawing.Size(800, 449);
            this.newtonFractalpictureBox.TabIndex = 0;
            this.newtonFractalpictureBox.TabStop = false;
            // 
            // FullScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newtonFractalpictureBox);
            this.Name = "FullScreenForm";
            ((System.ComponentModel.ISupportInitialize)(this.newtonFractalpictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox newtonFractalpictureBox;
    }
}