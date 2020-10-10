using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace WindowsFormsApplication1
{
    class Buton : Button
    {

        public Buton()
        {
            Setari settings = new Setari();
            string value = File.ReadAllText(@"extras/radiobuttons.txt");
            if (value == "1")
                BackColor = SystemColors.Control;
            else
                BackColor = SystemColors.ActiveCaptionText;
            Size = new Size(190, 85);
            FlatStyle = FlatStyle.Flat;
            Location = new Point(100, 100);
            BackgroundImageLayout = ImageLayout.Stretch;
            TextAlign = ContentAlignment.BottomCenter;
            ForeColor = Color.Black;
            Font = new Font("Arial Narrow", 12, FontStyle.Bold);
        }

    }
}
