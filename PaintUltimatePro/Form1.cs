using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace PaintUltimatePro
{
    public partial class PaintUltimatePro : Form
    {
        private int _size;
        private Color _color;
        private bool _moving;
        private string[] _files;
        private int _index;

        public PaintUltimatePro()
        {
            InitializeComponent();
            _size = 1; 
            _index = 0;
            _files = Directory.GetFiles(@"Images");
            _color = Color.Black;
            comboBox1.SelectedIndex = 0;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (checkBoxDoNow.Checked)
            {
                var graphics = pictureBox.CreateGraphics();
                using (Font myFont = new Font("Arial", 14))
                graphics.DrawString(textBox1.Text, myFont, Brushes.Black, e.X, e.Y);

            }
            else
            {
                _moving = true;
            }
            
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (_moving)
            {
                var graphics = pictureBox.CreateGraphics();
                var brush = new SolidBrush(_color);
                Pen pen = new Pen(brush);
                switch (comboBox1.Text)
                {
                    case "A":
                        graphics.FillEllipse(brush, e.X, e.Y, _size, _size);
                        break;
                    case "B":
                        graphics.FillRectangle(brush, e.X, e.Y, _size, _size);
                        break;
                    case "C":
                        graphics.DrawLine(pen, e.X, e.Y, _size, _size);
                        break;
                }
            }
        }

        private void pictureBox_MouseUp_22(object sender, MouseEventArgs e)
        {
            _moving = false;
        }

        private void trackBarSize_Scroll(object sender, EventArgs e)
        {
            _size = trackBarSize.Value;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                _color = colorDialog.Color;
            }
        }

        private void timerBackgroundChange_Tick(object sender, EventArgs e)
        {
            
            if (_files.Length > 0)
            {
                pictureBox.Image = Image.FromFile(_files[_index]);
                _index = _index + 1 < _files.Length ? ++_index : 0;
            }
            else
            {
                timerBackgroundChange.Stop();
            }
        }

        private void buttonOpenFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                _files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
                timerBackgroundChange.Start();
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                checkBox1.Checked = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                timerBackgroundChange.Stop();
            }
            else
            {
                timerBackgroundChange.Start();
            }
        }

        private void buttonSaveFileAs_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string save = Path.GetExtension(saveFileDialog1.FileName);
                switch (save)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                pictureBox.Image.Save(saveFileDialog1.FileName, format);
            }
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            ImageFormat format = pictureBox.Image.RawFormat;
            string name = pictureBox.ImageLocation;
            pictureBox.Image.Save(name, format);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
