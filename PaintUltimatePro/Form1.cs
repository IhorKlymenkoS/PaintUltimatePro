using System;
using System.Drawing;
using System.Windows.Forms;

namespace PaintUltimatePro
{
    public partial class PaintUltimatePro : Form
    {
        private bool _moving;

        public PaintUltimatePro()
        {
            InitializeComponent();
            brushBox.SelectedIndex = 0;
            colourBox.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void brushBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            _moving = true;
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            var color = Brushes.Black;
            int size = brushBox.SelectedIndex + 1;

            if (colourBox.SelectedIndex==0)
            {
                 color = Brushes.Black;
            }
            else if(colourBox.SelectedIndex == 1)
            {
                 color = Brushes.Red;
            }
            else
            {
                 color = Brushes.Blue;
            }
            

            if (_moving==true)
            {
                var graphics = pictureBox.CreateGraphics();
                graphics.FillRectangle(color, e.X, e.Y, size, size);
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_MouseUp_22(object sender, MouseEventArgs e)
        {
            _moving = false;
        }
    }
}
