namespace ColorPicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUpload = new Button();
            pictureBox1 = new PictureBox();
            lblRGB = new Label();
            lblHEX = new Label();
            label1 = new Label();
            label2 = new Label();
            btnCopy = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(1303, 262);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(117, 44);
            btnUpload.TabIndex = 0;
            btnUpload.Text = "Upload Image";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(17, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1280, 720);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            // 
            // lblRGB
            // 
            lblRGB.Font = new Font("Segoe UI", 10F);
            lblRGB.Location = new Point(1312, 340);
            lblRGB.Name = "lblRGB";
            lblRGB.Size = new Size(100, 23);
            lblRGB.TabIndex = 2;
            lblRGB.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblHEX
            // 
            lblHEX.Font = new Font("Segoe UI", 10F);
            lblHEX.Location = new Point(1312, 400);
            lblHEX.Name = "lblHEX";
            lblHEX.Size = new Size(100, 23);
            lblHEX.TabIndex = 3;
            lblHEX.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(1312, 310);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 4;
            label1.Text = "RGB:";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(1312, 370);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 5;
            label2.Text = "HEX:";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(1333, 426);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(58, 24);
            btnCopy.TabIndex = 6;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 771);
            Controls.Add(btnCopy);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblHEX);
            Controls.Add(lblRGB);
            Controls.Add(pictureBox1);
            Controls.Add(btnUpload);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnUpload;
        private PictureBox pictureBox1;
        private Label lblRGB;
        private Label lblHEX;
        private Label label1;
        private Label label2;
        private Button btnCopy;
    }
}
