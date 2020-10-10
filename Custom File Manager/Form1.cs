using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            eroare.Text = "";
            eroare.ForeColor = Color.White;
            eroare.Location = new Point(eroare.Location.X - 5, eroare.Location.Y - 2);
            label2.Visible = false;
        }

        //Logare
        private void btnLogare_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Completati ambele campuri.");
            }
            else
            {
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
                OleDbDataAdapter odda = new OleDbDataAdapter("Select * from Client where User='" + textBox1.Text + "' and Parola='" + textBox2.Text + "'", con);
                DataTable dt = new DataTable();
                odda.Fill(dt);
                try
                {
                    if (dt.Rows[0][0].ToString() != "0")
                    {
                        if (checkBox2.Checked == true)
                        {
                            Properties.Settings.Default.UserName = textBox1.Text;
                            Properties.Settings.Default.Parola = textBox2.Text;
                            Properties.Settings.Default.Save();
                        }
                        else
                        {
                            Properties.Settings.Default.UserName = "";
                            Properties.Settings.Default.Parola = "";
                            Properties.Settings.Default.Save();
                        }

                        System.IO.File.WriteAllText(@"textbox1.txt", textBox1.Text.ToString());
                        this.Hide();
                        Librarie f = new Librarie();
                        f.Closed += (s, args) => this.Close();
                        f.Show();
                    }
                }
                catch
                {
                    label2.Visible = true;
                    label2.Text = "Eroare la autentificare.\nNume de utilizator sau parolă greșită.";
                }
            }
        }


        //Colorare Borduri
        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.FromArgb(21, 122, 155));
            int top = textBox1.Top, bot = textBox1.Bottom, left = textBox1.Left, right = textBox1.Right;
            g.DrawRectangle(p, left - 1, top - 1, right - left + 1, bot - top + 1);
            g.Dispose();
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.FromArgb(50, 50, 50));
            int top = textBox1.Top, bot = textBox1.Bottom, left = textBox1.Left, right = textBox1.Right;
            g.DrawRectangle(p, left - 1, top - 1, right - left + 1, bot - top + 1);
            g.Dispose();
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.FromArgb(21, 122, 155));
            int top = textBox2.Top, bot = textBox2.Bottom, left = textBox2.Left, right = textBox2.Right;
            g.DrawRectangle(p, left - 1, top - 1, right - left + 1, bot - top + 1);
            g.Dispose();
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.FromArgb(50, 50, 50));
            int top = textBox2.Top, bot = textBox2.Bottom, left = textBox2.Left, right = textBox2.Right;
            g.DrawRectangle(p, left - 1, top - 1, right - left + 1, bot - top + 1);
            g.Dispose();
        }

        private void textBox3_MouseEnter(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.FromArgb(21, 122, 155));
            int top = textBox3.Top, bot = textBox3.Bottom, left = textBox3.Left, right = textBox3.Right;
            g.DrawRectangle(p, left - 1, top - 1, right - left + 1, bot - top + 1);
            g.Dispose();
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.FromArgb(50, 50, 50));
            int top = textBox3.Top, bot = textBox3.Bottom, left = textBox3.Left, right = textBox3.Right;
            g.DrawRectangle(p, left - 1, top - 1, right - left + 1, bot - top + 1);
            g.Dispose();
        }

        private void textBox4_MouseEnter(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.FromArgb(21, 122, 155));
            int top = textBox4.Top, bot = textBox4.Bottom, left = textBox4.Left, right = textBox4.Right;
            g.DrawRectangle(p, left - 1, top - 1, right - left + 1, bot - top + 1);
            g.Dispose();
        }

        private void textBox4_MouseLeave(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.FromArgb(50, 50, 50));
            int top = textBox4.Top, bot = textBox4.Bottom, left = textBox4.Left, right = textBox4.Right;
            g.DrawRectangle(p, left - 1, top - 1, right - left + 1, bot - top + 1);
            g.Dispose();
        }


        //Focus pe label1
        private void Login_Shown(object sender, EventArgs e)
        {
            label1.Focus();
            if (checkBox1.Checked == true)
            {
                this.Hide();
                Librarie f = new Librarie();
                f.Closed += (s, args) => this.Close();
                f.Show();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text == " Nume de utilizator")
            {
                textBox1.Text = "";
                textBox1.ForeColor = SystemColors.Control;
            }

            if (e.KeyChar == (char)Keys.Back && (textBox1.Text.Length == 1 || textBox1.Text.Length == 0))
            {
                textBox1.Text = " Nume de utilizator";
                textBox1.ForeColor = SystemColors.ControlDarkDark;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox2.Text == " Parolă")
            {
                textBox2.Text = "";
                textBox2.PasswordChar = '•';
                textBox2.ForeColor = SystemColors.Control;
            }

            if (e.KeyChar == (char)Keys.Back && (textBox2.Text.Length == 1 || textBox2.Text.Length == 0))
            {
                textBox2.PasswordChar = '\0';
                textBox2.Text = " Parolă";
                textBox2.ForeColor = SystemColors.ControlDarkDark;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox3.Text == " Confirmă Parola")
            {
                textBox3.Text = "";
                textBox3.PasswordChar = '•';
                textBox3.ForeColor = SystemColors.Control;
            }

            if (e.KeyChar == (char)Keys.Back && (textBox3.Text.Length == 1 || textBox3.Text.Length == 0))
            {
                textBox3.PasswordChar = '\0';
                textBox3.Text = " Confirmă Parola";
                textBox3.ForeColor = SystemColors.ControlDarkDark;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox4.Text == " Adresă de email")
            {
                textBox4.Text = "";
                textBox4.ForeColor = SystemColors.Control;
            }

            if (e.KeyChar == (char)Keys.Back && (textBox4.Text.Length == 1 || textBox4.Text.Length == 0))
            {
                textBox4.Text = " Adresă de email";
                textBox4.ForeColor = SystemColors.ControlDarkDark;
            }
        }


        //Scriere de la pozitia 0
        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == " Nume de utilizator")
                textBox1.SelectionStart = 0;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == " Parolă")
                textBox2.SelectionStart = 0;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == " Confirmă Parola")
                textBox3.SelectionStart = 0;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == " Adresă de email")
                textBox4.SelectionStart = 0;
        }


        //Miscare formular
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        //buton Close
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //buton Minimize
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //Trecere de la fereastra Login la fereastra Inregistrare
        private void label3_Click(object sender, EventArgs e)
        {
            if (label3.Text == "Creează Cont")
            {
                textBox1.Text = " Nume de utilizator";
                textBox2.PasswordChar = '\0';
                textBox2.Text = " Parolă";
                textBox1.ForeColor = SystemColors.ControlDarkDark;
                textBox2.ForeColor = SystemColors.ControlDarkDark;
                textBox3.Visible = true;
                textBox4.Visible = true;
                label1.Text = "ÎNREGISTRARE";
                label1.Location = new Point(331, label1.Location.Y);
                label3.Text = "Înapoi";
                label3.Location = new Point(371, label3.Location.Y);
                button3.Visible = true;
                btnLogin.Visible = false;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                label2.Visible = false;
                label2.Text = "";
            }
            else
            {
                label3.Text = "Creează Cont";
                label1.Text = "LOGARE";
                textBox3.Visible = false;
                label1.Location = new Point(354, label1.Location.Y);
                textBox4.Visible = false;
                label3.Location = new Point(356, label3.Location.Y);
                button3.Visible = false;
                btnLogin.Visible = true;
                checkBox1.Visible = true;
                checkBox2.Visible = true;
            }
        }

        //Verificare User, Parola si Email valid
        bool userValid()
        {
            if (textBox1.Text.Length > 5) return true;
            eroare.Text = "Nume de utilizator prea scurt!";
            return false;
        }

        bool parolaValida()
        {
            if (textBox2.Text != textBox3.Text)
            {
                eroare.Text = "Parole diferite!";
                return false;
            }
            else if (textBox2.Text.Length < 5)
            {
                eroare.Text = "Parola trebuie sa con?ina minim 6 caractere!";
                return false;
            }
            return true;
        }

        bool emailValid(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                eroare.Text = "Email invalid!";
                return false;
            }
        }

        //Inregistrare
        private void button3_Click(object sender, EventArgs e)
        {
            if (userValid() && parolaValida() && emailValid(textBox4.Text))
            {
                eroare.Text = "";

                OleDbConnection odc = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
                OleDbCommand odcmd = new OleDbCommand("Select ID from Client where Email=@email", odc);
                odcmd.Parameters.AddWithValue("@email", this.textBox4.Text);
                OleDbCommand odcmduser = new OleDbCommand("Select ID from Client where [User]=@username", odc);
                odcmduser.Parameters.AddWithValue("@username", this.textBox1.Text);
                odc.Open();
                var nId = odcmd.ExecuteScalar();
                var nUs = odcmduser.ExecuteScalar();
                odc.Close();
                if (nId != null)
                {
                    MessageBox.Show("Email-ul a mai fost utilizat!");
                    textBox4.Text = " Adresă de email";
                    textBox4.ForeColor = SystemColors.ControlDarkDark;
                }
                else if (nUs != null)
                {
                    MessageBox.Show("Numele de utilizator a mai fost utilizat!");
                    textBox1.Text = " Nume de utilizator";
                    textBox1.ForeColor = SystemColors.ControlDarkDark;
                }
                else
                {
                    string query2 = "Insert into Client ([User], Parola, Email) values ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox4.Text + "')";
                    OleDbCommand odcmd2 = new OleDbCommand(query2, odc);
                    odc.Open();
                    odcmd2.ExecuteNonQuery();
                    odc.Close();
                    MessageBox.Show("Cont creat cu succes.");
                    label3.Text = "Creează Cont";
                    label1.Text = "LOGARE";
                    textBox3.Visible = false;
                    label1.Location = new Point(354, label1.Location.Y);
                    textBox4.Visible = false;
                    label3.Location = new Point(356, label3.Location.Y);
                    button3.Visible = false;
                    btnLogin.Visible = true;
                    checkBox1.Visible = true;
                    checkBox2.Visible = true;
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

            string value = System.IO.File.ReadAllText(@"checkbox2.txt");
            checkBox2.Checked = bool.Parse(value);
            value = System.IO.File.ReadAllText(@"checkbox1.txt");
            checkBox1.Checked = bool.Parse(value);

            textBox1.Text = " Nume de utilizator";
            textBox2.Text = " Parolă";
            textBox2.PasswordChar = '\0';
            textBox1.ForeColor = SystemColors.ControlDarkDark;
            textBox2.ForeColor = SystemColors.ControlDarkDark;

            if (Properties.Settings.Default.UserName != "")
            {
                textBox1.Text = Properties.Settings.Default.UserName;
                textBox2.Text = Properties.Settings.Default.Parola;
                textBox2.PasswordChar = '•';
                textBox1.ForeColor = SystemColors.Control;
                textBox2.ForeColor = SystemColors.Control;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"checkbox2.txt", checkBox2.Checked.ToString());

            if (checkBox2.Checked == false)
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Parola = "";
                Properties.Settings.Default.Save();
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"checkbox1.txt", checkBox1.Checked.ToString());
        }

    }
}
