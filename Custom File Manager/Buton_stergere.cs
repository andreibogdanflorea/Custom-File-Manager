using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Buton_stergere : Button
    {
        public Buton_stergere()
        {
            BackColor = SystemColors.Control;
            Size = new Size(15, 15);
            FlatStyle = FlatStyle.Flat;
            BackgroundImageLayout = ImageLayout.Stretch;
            TextAlign = ContentAlignment.BottomCenter;
            ForeColor = Color.Black;
            BackgroundImage = Image.FromFile("images/buton_stergere.png");
        }
    }
}
