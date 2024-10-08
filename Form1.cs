using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        string hex = "#ffffff";
        Color color;

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap bitmap = new(pictureBox1.Image);
                if (e.X < bitmap.Width && e.Y < bitmap.Height)
                {
                    color = bitmap.GetPixel(e.X, e.Y);
                    lblRGB.Text = $"{color.R}, {color.G}, {color.B}";

                    hex = ColorTranslator.ToHtml(color);
                    lblHEX.Text = $"{hex}";

                    btnCopy.BackColor = color;
                }
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(hex);
        }
    }
}
