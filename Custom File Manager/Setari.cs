using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Setari : Form
    {
        public Setari()
        {
            InitializeComponent();
        }


        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void checkBoxWin_CheckedChanged(object sender, EventArgs e)
        {
            File.WriteAllText(@"extras/checkboxwin.txt", checkBoxWin.Checked.ToString());
            var locatie = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "Custom File Manager.lnk");
            if (checkBoxWin.Checked == true)
            {
                File.Copy(@"extras/Custom File Manager.lnk", locatie, true);
            }
            else
            {
                try
                {
                    File.Delete(locatie);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void Setari_Load(object sender, EventArgs e)
        {
            string value = File.ReadAllText(@"extras/checkboxwin.txt");
            checkBoxWin.Checked = bool.Parse(value);
            value = File.ReadAllText(@"extras/radiobuttons.txt");
            if (value == "1")
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
            else
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                radioButton1.Checked = false;
                File.WriteAllText(@"extras/radiobuttons.txt", "2");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                radioButton2.Checked = false;
                File.WriteAllText(@"extras/radiobuttons.txt", "1");
            }
        }
    }
}
