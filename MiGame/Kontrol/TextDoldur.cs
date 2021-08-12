using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiGame
{
    class TextDoldur
    {
        public void TextEnter(TextBox text, string yazi)
        {
            if (text.Text == yazi)
            {
                text.Text = "";
                Color myRgbColor = new Color();
                myRgbColor = Color.FromArgb(114, 20, 126);
                text.ForeColor = myRgbColor;
            }
        }
        public void TextLeave(TextBox textBox, string yazi)
        {
            if (textBox.Text == "")
            {
                textBox.Text = yazi;
                Color myRgbColor = new Color();
                myRgbColor = Color.FromArgb(156, 74, 167);
                textBox.ForeColor = myRgbColor;
            }
        }
        public void SifreEnter(TextBox textBox, string yazi)
        {
            if (textBox.Text == yazi)
            {
                textBox.Text = "";
                Color myRgbColor = new Color();
                myRgbColor = Color.FromArgb(114, 20, 126);
                textBox.ForeColor = myRgbColor;
                textBox.PasswordChar = '*';
            }
        }
        char? none = null;
        public void SifreLeave(TextBox textBox, string yazi)
        {
            if (textBox.Text == "")
            {
                textBox.Text = yazi;
                Color myRgbColor = new Color();
                myRgbColor = Color.FromArgb(156, 74, 167);
                textBox.ForeColor = myRgbColor;
                textBox.PasswordChar = Convert.ToChar(none);
            }
        }
    }
}
