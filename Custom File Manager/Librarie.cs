using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Librarie : Form
    {
        public Librarie()
        {
            InitializeComponent();
        }

        Color cul1 = Color.FromArgb(64, 64, 64);
        Color cul2 = Color.FromArgb(50, 50, 50);
        Color cul3 = SystemColors.ControlDarkDark;
        Color cul4 = SystemColors.Control;
        Color cul5 = Color.Black;

        //Buton Close
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Buton Minimize
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Miscare formular
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Librarie_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void jocuri_MouseDown(object sender, MouseEventArgs e)
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
        private void btnjoc_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void btnapp_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void btndoc_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void btnfol_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void customTabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {

        }


        private void btnapp_Click(object sender, EventArgs e)
        {
            customTabControl1.SelectedTab = app;

            btnjocuri.ForeColor = cul3;
            btnapp.ForeColor = cul4;
            btndoc.ForeColor = cul3;
            btnfold.ForeColor = cul3;
        }

        private void btndoc_Click(object sender, EventArgs e)
        {
            customTabControl1.SelectedTab = doc;

            btnjocuri.ForeColor = cul3;
            btnapp.ForeColor = cul3;
            btndoc.ForeColor = cul4;
            btnfold.ForeColor = cul3;

        }

        private void btnfold_Click(object sender, EventArgs e)
        {
            customTabControl1.SelectedTab = foldere;

            btnjocuri.ForeColor = cul3;
            btnapp.ForeColor = cul3;
            btndoc.ForeColor = cul3;
            btnfold.ForeColor = cul4;
        }

        private void btnjocuri_Click(object sender, EventArgs e)
        {
            customTabControl1.SelectedTab = jocuri;

            btnjocuri.ForeColor = cul4;
            btnapp.ForeColor = cul3;
            btndoc.ForeColor = cul3;
            btnfold.ForeColor = cul3;
        }

        private void btnset_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height);
            using (Graphics G = Graphics.FromImage(bmp))
            {
                G.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                G.CopyFromScreen(this.PointToScreen(new Point(0, 0)), new Point(0, 0), this.ClientRectangle.Size);
                double percent = 0.40;
                Color darken = Color.FromArgb((int)(255 * percent), Color.Black);
                using (Brush brsh = new SolidBrush(darken))
                {
                    G.FillRectangle(brsh, this.ClientRectangle);
                }
            }

            using (Panel p = new Panel())
            {
                p.Location = new Point(0, 0);
                p.Size = this.ClientRectangle.Size;
                p.BackgroundImage = bmp;
                this.Controls.Add(p);
                p.BringToFront();

                Setari frm = new Setari();
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.radioButton1.CheckedChanged += (s, args) => { colorare(); };
                frm.radioButton2.CheckedChanged += (s, args) => { colorare(); };
                frm.ShowDialog(this);
            }
        }

        private void btnjocuri_MouseEnter(object sender, EventArgs e)
        {
            btnjocuri.BackColor = cul5;
        }

        private void btnjocuri_MouseLeave(object sender, EventArgs e)
        {
            btnjocuri.BackColor = cul2;
        }

        private void btnapp_MouseEnter(object sender, EventArgs e)
        {
            btnapp.BackColor = cul5;
        }

        private void btnapp_MouseLeave(object sender, EventArgs e)
        {
            btnapp.BackColor = cul2;
        }

        private void btndoc_MouseEnter(object sender, EventArgs e)
        {
            btndoc.BackColor = cul5;
        }

        private void btndoc_MouseLeave(object sender, EventArgs e)
        {
            btndoc.BackColor = cul2;
        }

        private void btnfold_MouseEnter(object sender, EventArgs e)
        {
            btnfold.BackColor = cul5;
        }

        private void btnfold_MouseLeave(object sender, EventArgs e)
        {
            btnfold.BackColor = cul2;
        }

        private void btnset_MouseEnter(object sender, EventArgs e)
        {
            btnset.BackColor = cul5;
        }

        private void btnset_MouseLeave(object sender, EventArgs e)
        {
            btnset.BackColor = cul2;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = cul5;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = cul2;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = cul5;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = cul2;
        }


        public string GetLengthOfFile(double length)
        {
            string l = String.Format("{0:F3}", length) + " bytes";
            if (length > 1024)
            {
                length /= 1024.0;
                Math.Round(length, 3);
                l = String.Format("{0:F3}", length) + " KB";
            }
            if (length > 1024)
            {
                length /= 1024.0;
                Math.Round(length, 3);
                l = String.Format("{0:F3}", length) + " MB";
            }
            if (length > 1024)
            {
                length /= 1024.0;
                l = String.Format("{0:F3}", length) + " GB";
            }

            return l;
        }

        List<Button> list = new List<Button>();
        List<string> ls = new List<string>();

        struct rand
        {
            public string path;
            public int tab, nr;
            public long dim;
            public DateTime dt;
            public string nume;
        };
        rand[] data=new rand[1000];
        int count;
        ToolTip ttip = new ToolTip();


        //Jocuri
        int lastx1 = 20, lasty1 = 20;
        List<Button> lbjoc = new List<Button>();
        List<Panel> lpjoc = new List<Panel>();
        List<Button> lstjoc = new List<Button>();
        List<Tuple<int, int>> xyjoc = new List<Tuple<int, int>>();
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Executables (*.exe)|*.exe";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OleDbConnection odc1 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
                OleDbCommand odcmd1 = new OleDbCommand("Select Count(*) from Fisiere where Cale=@path and Tab=@pag", odc1);
                odcmd1.Parameters.AddWithValue("@path", openFileDialog1.FileName);
                odcmd1.Parameters.AddWithValue("@pag", 1);
                odc1.Open();
                Int32 nid = (Int32)odcmd1.ExecuteScalar();
                odc1.Close();
                if (nid != 0)
                {
                    MessageBox.Show("The file was already added.");
                }
                else
                {
                    DateTime dtv = DateTime.Now;
                    var fileInfo = new FileInfo(openFileDialog1.FileName); 
                    OleDbConnection odc = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
                    OleDbCommand odcmd = new OleDbCommand("Insert into Fisiere (Cale, Tab, Timp, Nr, Dimensiune, Nume) values ('" + openFileDialog1.FileName + "','" + 1 + "','" + dtv + "','" + 0 + "', '" + fileInfo.Length + "','" + Path.GetFileNameWithoutExtension(openFileDialog1.FileName) + "')", odc);
                    odc.Open();
                    odcmd.ExecuteNonQuery();
                    odc.Close();

                    Buton btn = new Buton();

                    string l = GetLengthOfFile(fileInfo.Length);
                    ttip.SetToolTip(btn, "Last accessed at: " + dtv + " \nNumber of clicks: " + 0 + " \nSize: " + l + "");

                    btn.Location = new Point(lasty1, lastx1);
                    Panel pan = new Panel();
                    pan.Size = new Size(190, 15);
                    pan.Location = new Point(lasty1, lastx1 + 85);
                    pan.BackColor = cul5;
                    TextBox tB = new TextBox();
                    tB.Size = new Size(180, 15);
                    tB.ReadOnly = true;
                    tB.BorderStyle = BorderStyle.None;
                    tB.BackColor = cul5;
                    tB.DoubleClick += new EventHandler(tB_DoubleClick);
                    tB.KeyDown += new KeyEventHandler(tB_KeyDown);
                    FileInfo fi = new FileInfo(openFileDialog1.FileName);
                    tB.Text = Path.GetFileNameWithoutExtension(fi.Name);
                    tB.ForeColor = cul4;
                    tB.AutoSize = true;
                    pan.Controls.Add(tB);
                    pan.BringToFront();
                    panelJoc.Controls.Add(pan);

                    Buton_stergere st = new Buton_stergere();
                    st.Location = new Point(lasty1 + 175, lastx1);
                    xyjoc.Add(Tuple.Create(lastx1, lasty1));

                    lasty1 += 200;
                    if (lasty1 > 1200)
                    {
                        lasty1 = 20;
                        lastx1 += 120;
                    }

                    Icon icon = Icon.ExtractAssociatedIcon(openFileDialog1.FileName);
                    Bitmap bp = new Bitmap(icon.ToBitmap(), new Size(50, 50));
                    btn.BackgroundImage = bp;
                    btn.BackgroundImageLayout = ImageLayout.Center;

                    lbjoc.Add(btn);
                    lpjoc.Add(pan);
                    lstjoc.Add(st);
                    list.Add(btn);
                    ls.Add(openFileDialog1.FileName);
                    tB.AccessibleDescription = ls[list.IndexOf(btn)];
                    btn.Click += (s, e1) =>
                    {
                        Process process = new Process();
                        process.StartInfo.FileName = ls[list.IndexOf(btn)];
                        process.Start();
                        OleDbConnection odcon = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
                        int numar = 0;
                        OleDbCommand odcom = new OleDbCommand("Select Nr from Fisiere where Cale like @cale", odcon);
                        odcom.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                        odcon.Open();
                        OleDbDataAdapter da = new OleDbDataAdapter();
                        da.SelectCommand = odcom;
                        DataTable dtC = new DataTable();
                        da.Fill(dtC);
                        odcon.Close();
                        numar = Convert.ToInt32(dtC.Rows[0][0]) + 1;

                        odcom.CommandText = "Update Fisiere set Nr='" + numar + "' where cale=@cale";
                        odcom.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                        odcon.Open();
                        odcom.ExecuteNonQuery();
                        odcon.Close();
                        odcom.CommandText = "Update Fisiere set Timp='" + DateTime.Now + "' where cale=@cale";
                        odcom.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                        odcon.Open();
                        odcom.ExecuteNonQuery();
                        odcon.Close();
                        ttip.SetToolTip(btn, "Last accessed at: " + DateTime.Now + " \nNumber of clicks: " + numar + " \nSize: " + l + "");
                    };

                    st.Click += (s, e1) =>
                    {
                        OleDbConnection odcon = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
                        OleDbCommand odcom = new OleDbCommand("Delete from Fisiere where Cale like @cale", odcon);
                        odcom.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                        odcon.Open();
                        odcom.ExecuteNonQuery();
                        odcon.Close();
                        panelJoc.Controls.Remove(st);
                        panelJoc.Controls.Remove(btn);
                        panelJoc.Controls.Remove(pan);
                        st.Dispose();
                        btn.Dispose();
                        pan.Dispose();
                        int xc = xyjoc[lbjoc.IndexOf(btn)].Item1;
                        int yc = xyjoc[lbjoc.IndexOf(btn)].Item2;
                        for (int i = lbjoc.IndexOf(btn) + 1; i < lbjoc.Count; i++)
                        {
                            int xnou = xyjoc[i].Item1;
                            int ynou = xyjoc[i].Item2;

                            lbjoc[i].Location = new Point(yc, xc);
                            lpjoc[i].Location = new Point(yc, xc + 85);
                            lstjoc[i].Location = new Point(yc + 175, xc);
                            xc = xnou;
                            yc = ynou;
                        }
                        lbjoc.Remove(btn);
                        lpjoc.Remove(pan);
                        lstjoc.Remove(st);

                        lasty1 -= 200;
                        if (lasty1 < 20)
                        {
                            lasty1 = 20;
                            lastx1 -= 120;
                        }
                    };
                    
                    panelJoc.Controls.Add(st);
                    panelJoc.Controls.Add(btn);
                }

            }
        }

        void tB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox tBox = (TextBox)sender;
                tBox.ReadOnly = true;
                label1.Focus();
                OleDbConnection odc = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
                OleDbCommand odcmd = new OleDbCommand("Update Fisiere set Nume='" + tBox.Text + "' where cale=@cale", odc);
                odcmd.Parameters.AddWithValue("@cale", tBox.AccessibleDescription);
                odc.Open();
                odcmd.ExecuteNonQuery();
                odc.Close();
            }
        }


        void tB_DoubleClick(object sender, EventArgs e)
        {
            TextBox tBox = (TextBox)sender;
            tBox.ReadOnly = false;
        }



        //Aplicatii
        int lastx2 = 20, lasty2 = 20;
        List<Button> lbapp = new List<Button>();
        List<Panel> lpapp = new List<Panel>();
        List<Button> lstapp = new List<Button>();
        List<Tuple<int, int>> xyapp = new List<Tuple<int, int>>();
        private void button4_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Executables (*.exe)|*.exe";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OleDbConnection odc1 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
                OleDbCommand odcmd1 = new OleDbCommand("Select Count(*) from Fisiere where Cale=@path and Tab=@pag", odc1);
                odcmd1.Parameters.AddWithValue("@path", openFileDialog1.FileName);
                odcmd1.Parameters.AddWithValue("@pag", 2);
                odc1.Open();
                Int32 nid = (Int32)odcmd1.ExecuteScalar();
                odc1.Close();
                if (nid != 0)
                {
                    MessageBox.Show("The file was already added.");
                }
                else
                {
                    DateTime dtv = DateTime.Now;
                    var fileInfo = new FileInfo(openFileDialog1.FileName);
                    OleDbConnection odc = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
                    OleDbCommand odcmd = new OleDbCommand("Insert into Fisiere (Cale, Tab, Timp, Nr, Dimensiune, Nume) values ('" + openFileDialog1.FileName + "','" + 2 + "','" + dtv + "','" + 0 + "', '" + fileInfo.Length + "','" + Path.GetFileNameWithoutExtension(openFileDialog1.FileName) + "')", odc);
                    odc.Open();
                    odcmd.ExecuteNonQuery();
                    odc.Close();

                    Buton btn = new Buton();

                    string l = GetLengthOfFile(fileInfo.Length);
                    ttip.SetToolTip(btn, "Last accessed at: " + dtv + " \nNumber of clicks: " + 0 + " \nSize: " + l + "");

                    btn.Location = new Point(lasty2, lastx2);
                    Panel pan = new Panel();
                    pan.Size = new Size(190, 15);
                    pan.Location = new Point(lasty2, lastx2 + 85);
                    pan.BackColor = cul5;
                    TextBox tB = new TextBox();
                    tB.Size = new Size(180, 15);
                    tB.ReadOnly = true;
                    tB.BorderStyle = BorderStyle.None;
                    tB.BackColor = cul5;
                    tB.DoubleClick += new EventHandler(tB_DoubleClick);
                    tB.KeyDown += new KeyEventHandler(tB_KeyDown);
                    FileInfo fi = new FileInfo(openFileDialog1.FileName);
                    tB.Text = Path.GetFileNameWithoutExtension(fi.Name);
                    tB.ForeColor = cul4;
                    tB.AutoSize = true;
                    pan.Controls.Add(tB);
                    pan.BringToFront();
                    panelApp.Controls.Add(pan);

                    Buton_stergere st = new Buton_stergere();
                    st.Location = new Point(lasty2 + 175, lastx2);
                    xyapp.Add(Tuple.Create(lastx2, lasty2));

                    lasty2 += 200;
                    if (lasty2 > 1200)
                    {
                        lasty2 = 20;
                        lastx2 += 120;
                    }


                    Icon icon = Icon.ExtractAssociatedIcon(openFileDialog1.FileName);
                    Bitmap bp = new Bitmap(icon.ToBitmap(), new Size(50, 50));
                    btn.BackgroundImage = bp;
                    btn.BackgroundImageLayout = ImageLayout.Center;

                    lbapp.Add(btn);
                    lpapp.Add(pan);
                    lstapp.Add(st);
                    list.Add(btn);
                    ls.Add(openFileDialog1.FileName);
                    tB.AccessibleDescription = ls[list.IndexOf(btn)];

                    btn.Click += (s, e1) =>
                    {
                        Process process = new Process();
                        process.StartInfo.FileName = ls[list.IndexOf(btn)];
                        process.Start();
                        OleDbConnection odcon = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
                        int numar = 0;
                        OleDbCommand odcom = new OleDbCommand("Select Nr from Fisiere where Cale like @cale", odcon);
                        odcom.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                        odcon.Open();
                        OleDbDataAdapter da = new OleDbDataAdapter();
                        da.SelectCommand = odcom;
                        DataTable dtC = new DataTable();
                        da.Fill(dtC);
                        odcon.Close();
                        numar = Convert.ToInt32(dtC.Rows[0][0]) + 1;

                        odcom.CommandText = "Update Fisiere set Nr='" + numar + "' where cale=@cale";
                        odcom.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                        odcon.Open();
                        odcom.ExecuteNonQuery();
                        odcon.Close();
                        odcom.CommandText = "Update Fisiere set Timp='" + DateTime.Now + "' where cale=@cale";
                        odcom.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                        odcon.Open();
                        odcom.ExecuteNonQuery();
                        odcon.Close();
                        ttip.SetToolTip(btn, "Last accessed at: " + DateTime.Now + " \nNumber of clicks: " + numar + " \nSize: " + l + "");
                    };

                    st.Click += (s, e1) =>
                    {
                        OleDbConnection odcon = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
                        OleDbCommand odcom = new OleDbCommand("Delete from Fisiere where Cale like @cale", odcon);
                        odcom.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                        odcon.Open();
                        odcom.ExecuteNonQuery();
                        odcon.Close();
                        panelApp.Controls.Remove(st);
                        panelApp.Controls.Remove(btn);
                        panelApp.Controls.Remove(pan);
                        st.Dispose();
                        btn.Dispose();
                        pan.Dispose();
                        int xc = xyapp[lbapp.IndexOf(btn)].Item1;
                        int yc = xyapp[lbapp.IndexOf(btn)].Item2;
                        for (int i = lbapp.IndexOf(btn) + 1; i < lbapp.Count; i++)
                        {
                            int xnou = xyapp[i].Item1;
                            int ynou = xyapp[i].Item2;

                            lbapp[i].Location = new Point(yc, xc);
                            lpapp[i].Location = new Point(yc, xc + 85);
                            lstapp[i].Location = new Point(yc + 175, xc);
                            xc = xnou;
                            yc = ynou;
                        }
                        lbapp.Remove(btn);
                        lpapp.Remove(pan);
                        lstapp.Remove(st);

                        lasty2 -= 200;
                        if (lasty2 < 20)
                        {
                            lasty2 = 20;
                            lastx2 -= 120;
                        }
                    };

                    panelApp.Controls.Add(st);
                    panelApp.Controls.Add(btn);

                }


            }
        }

        //Documente
        int lastx3 = 20, lasty3 = 20;
        List<Button> lbdoc = new List<Button>();
        List<Panel> lpdoc = new List<Panel>();
        List<Button> lstdoc = new List<Button>();
        List<Tuple<int, int>> xydoc = new List<Tuple<int, int>>();
        private void button5_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OleDbConnection odc1 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
                OleDbCommand odcmd1 = new OleDbCommand("Select Count(*) from Fisiere where Cale=@path and Tab=@pag", odc1);
                odcmd1.Parameters.AddWithValue("@path", openFileDialog1.FileName);
                odcmd1.Parameters.AddWithValue("@pag", 3);
                odc1.Open();
                Int32 nid = (Int32)odcmd1.ExecuteScalar();
                odc1.Close();
                if (nid != 0)
                {
                    MessageBox.Show("The file was already added.");
                }
                else
                {
                    DateTime dtv = DateTime.Now;
                    var fileInfo = new FileInfo(openFileDialog1.FileName);
                    OleDbConnection odc = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
                    OleDbCommand odcmd = new OleDbCommand("Insert into Fisiere (Cale, Tab, Timp, Nr, Dimensiune, Nume) values ('" + openFileDialog1.FileName + "','" + 3 + "','" + dtv + "','" + 0 + "', '" + fileInfo.Length + "','" + Path.GetFileNameWithoutExtension(openFileDialog1.FileName) + "')", odc);
                    odc.Open();
                    odcmd.ExecuteNonQuery();
                    odc.Close();

                    Buton btn = new Buton();

                    string l = GetLengthOfFile(fileInfo.Length);
                    ttip.SetToolTip(btn, "Last accessed at: " + dtv + " \nNumber of clicks: " + 0 + " \nSize: " + l + "");

                    btn.Location = new Point(lasty3, lastx3);
                    Panel pan = new Panel();
                    pan.Size = new Size(190, 15);
                    pan.Location = new Point(lasty3, lastx3 + 85);
                    pan.BackColor = cul5;
                    TextBox tB = new TextBox();
                    tB.Size = new Size(180, 15);
                    tB.ReadOnly = true;
                    tB.BorderStyle = BorderStyle.None;
                    tB.BackColor = cul5;
                    tB.DoubleClick += new EventHandler(tB_DoubleClick);
                    tB.KeyDown += new KeyEventHandler(tB_KeyDown);
                    FileInfo fi = new FileInfo(openFileDialog1.FileName);
                    tB.Text = Path.GetFileNameWithoutExtension(fi.Name);
                    tB.ForeColor = cul4;
                    tB.AutoSize = true;
                    pan.Controls.Add(tB);
                    pan.BringToFront();
                    panelDoc.Controls.Add(pan);

                    Buton_stergere st = new Buton_stergere();
                    st.Location = new Point(lasty3 + 175, lastx3);
                    xydoc.Add(Tuple.Create(lastx3, lasty3));

                    lasty3 += 200;
                    if (lasty3 > 1200)
                    {
                        lasty3 = 20;
                        lastx3 += 120;
                    }

                    Icon icon = Icon.ExtractAssociatedIcon(openFileDialog1.FileName);
                    Bitmap bp = new Bitmap(icon.ToBitmap(), new Size(50, 50));
                    btn.BackgroundImage = bp;
                    btn.BackgroundImageLayout = ImageLayout.Center;


                    lbdoc.Add(btn);
                    lpdoc.Add(pan);
                    lstdoc.Add(st);
                    list.Add(btn);
                    ls.Add(openFileDialog1.FileName);
                    tB.AccessibleDescription = ls[list.IndexOf(btn)];

                    btn.Click += (s, e1) =>
                    {
                        Process process = new Process();
                        process.StartInfo.FileName = ls[list.IndexOf(btn)];
                        process.Start();
                        OleDbConnection odcon = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
                        int numar = 0;
                        OleDbCommand odcom = new OleDbCommand("Select Nr from Fisiere where Cale like @cale", odcon);
                        odcom.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                        odcon.Open();
                        OleDbDataAdapter da = new OleDbDataAdapter();
                        da.SelectCommand = odcom;
                        DataTable dtC = new DataTable();
                        da.Fill(dtC);
                        odcon.Close();
                        numar = Convert.ToInt32(dtC.Rows[0][0]) + 1;

                        odcom.CommandText = "Update Fisiere set Nr='" + numar + "' where cale=@cale";
                        odcom.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                        odcon.Open();
                        odcom.ExecuteNonQuery();
                        odcon.Close();
                        odcom.CommandText = "Update Fisiere set Timp='" + DateTime.Now + "' where cale=@cale";
                        odcom.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                        odcon.Open();
                        odcom.ExecuteNonQuery();
                        odcon.Close();
                        ttip.SetToolTip(btn, "Last accessed at: " + DateTime.Now + " \nNumber of clicks: " + numar + " \nSize: " + l + "");
                    };

                    st.Click += (s, e1) =>
                    {
                        OleDbConnection odcon = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
                        OleDbCommand odcom = new OleDbCommand("Delete from Fisiere where Cale like @cale", odcon);
                        odcom.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                        odcon.Open();
                        odcom.ExecuteNonQuery();
                        odcon.Close();
                        panelDoc.Controls.Remove(st);
                        panelDoc.Controls.Remove(btn);
                        panelDoc.Controls.Remove(pan);
                        st.Dispose();
                        btn.Dispose();
                        pan.Dispose();
                        int xc = xydoc[lbdoc.IndexOf(btn)].Item1;
                        int yc = xydoc[lbdoc.IndexOf(btn)].Item2;
                        for (int i = lbdoc.IndexOf(btn) + 1; i < lbdoc.Count; i++)
                        {
                            int xnou = xydoc[i].Item1;
                            int ynou = xydoc[i].Item2;

                            lbdoc[i].Location = new Point(yc, xc);
                            lpdoc[i].Location = new Point(yc, xc + 85);
                            lstdoc[i].Location = new Point(yc + 175, xc);
                            xc = xnou;
                            yc = ynou;
                        }
                        lbdoc.Remove(btn);
                        lpdoc.Remove(pan);
                        lstdoc.Remove(st);

                        lasty3 -= 200;
                        if (lasty3 < 20)
                        {
                            lasty3 = 20;
                            lastx3 -= 120;
                        }
                    };

                    panelDoc.Controls.Add(st);
                    panelDoc.Controls.Add(btn);
                }

            }
        }

        public static long GetFileSizeSumFromDirectory(string searchDirectory)
        {
            var files = Directory.EnumerateFiles(searchDirectory);
            var currentSize = (from file in files let fileInfo = new FileInfo(file) select fileInfo.Length).Sum();

            var directories = Directory.EnumerateDirectories(searchDirectory);
            var subDirSize = (from directory in directories select GetFileSizeSumFromDirectory(directory)).Sum();

            return currentSize + subDirSize;
        }

        //Foldere
        int lastx4 = 20, lasty4 = 20;
        List<Button> lbfol = new List<Button>();
        List<Panel> lpfol = new List<Panel>();
        List<Button> lstfol = new List<Button>();
        List<Tuple<int, int>> xyfol = new List<Tuple<int, int>>();
        private void button6_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                OleDbConnection odc1 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
                OleDbCommand odcmd1 = new OleDbCommand("Select Count(*) from Fisiere where Cale=@path and Tab=@pag", odc1);
                odcmd1.Parameters.AddWithValue("@path", folderBrowserDialog1.SelectedPath);
                odcmd1.Parameters.AddWithValue("@pag", 4);
                odc1.Open();
                Int32 nid = (Int32)odcmd1.ExecuteScalar();
                odc1.Close();
                if (nid != 0)
                {
                    MessageBox.Show("The folder was already added.");
                }
                else
                {
                    DateTime dtv = DateTime.Now;
                    string l;
                    long size;
                    try
                    {
                        size = GetFileSizeSumFromDirectory(folderBrowserDialog1.SelectedPath);
                        l = GetLengthOfFile(size);
                    }
                    catch
                    {
                        size = long.MaxValue - 1;
                        l = GetLengthOfFile(long.MaxValue);
                    }
                    OleDbConnection odc = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
                    OleDbCommand odcmd = new OleDbCommand("Insert into Fisiere (Cale, Tab, Timp, Nr, Dimensiune, Nume) values ('" + folderBrowserDialog1.SelectedPath + "','" + 4 + "','" + dtv + "','" + 0 + "', '" + size.ToString() + "','" + Path.GetFileNameWithoutExtension(folderBrowserDialog1.SelectedPath) + "')", odc);
                    odc.Open();
                    odcmd.ExecuteNonQuery();
                    odc.Close();

                    Buton btn = new Buton();

                    ttip.SetToolTip(btn, "Last accessed at: " + dtv + " \nNumber of clicks: " + 0 + " \nSize: " + l + "");

                    btn.Location = new Point(lasty4, lastx4);
                    Panel pan = new Panel();
                    pan.Size = new Size(190, 15);
                    pan.Location = new Point(lasty4, lastx4 + 85);
                    pan.BackColor = cul5;
                    TextBox tB = new TextBox();
                    tB.Size = new Size(180, 15);
                    tB.ReadOnly = true;
                    tB.BorderStyle = BorderStyle.None;
                    tB.BackColor = cul5;
                    tB.DoubleClick += new EventHandler(tB_DoubleClick);
                    tB.KeyDown += new KeyEventHandler(tB_KeyDown);
                    FileInfo fi = new FileInfo(folderBrowserDialog1.SelectedPath);
                    tB.Text = Path.GetFileNameWithoutExtension(fi.Name);
                    tB.ForeColor = cul4;
                    tB.AutoSize = true;
                    pan.Controls.Add(tB);
                    pan.BringToFront();
                    panelFold.Controls.Add(pan);

                    Buton_stergere st = new Buton_stergere();
                    st.Location = new Point(lasty4 + 175, lastx4);
                    xyfol.Add(Tuple.Create(lastx4, lasty4));

                    lasty4 += 200;
                    if (lasty4 > 1200)
                    {
                        lasty4 = 20;
                        lastx4 += 120;
                    }


                    int width = 200, height = 100;
                    Bitmap bmp = new Bitmap(width, height);
                    Random rand = new Random();
                    for (int y = 0; y < height; y += height / 4)
                    {
                        for (int x = 0; x < width; x += width / 8)
                        {
                            int a = rand.Next(256);
                            int r = rand.Next(256);
                            int g = rand.Next(256);
                            int b = rand.Next(256);
                            for (int k1 = y; k1 < y + height / 2 && k1 < height; k1++)
                                for (int k2 = x; k2 < x + width / 4 && k2 < width; k2++)
                                    bmp.SetPixel(k2, k1, Color.FromArgb(a, r, g, b));
                        }
                    }
                    btn.BackgroundImage = bmp;

                    lbfol.Add(btn);
                    lpfol.Add(pan);
                    lstfol.Add(st);
                    list.Add(btn);
                    ls.Add(folderBrowserDialog1.SelectedPath);
                    tB.AccessibleDescription = ls[list.IndexOf(btn)];

                    btn.Click += (s, e1) =>
                    {
                        Process process = new Process();
                        process.StartInfo.FileName = ls[list.IndexOf(btn)];
                        process.Start();
                        OleDbConnection odcon = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
                        int numar = 0;
                        OleDbCommand odcom = new OleDbCommand("Select Nr from Fisiere where Cale like @cale", odcon);
                        odcom.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                        odcon.Open();
                        OleDbDataAdapter da = new OleDbDataAdapter();
                        da.SelectCommand = odcom;
                        DataTable dtC = new DataTable();
                        da.Fill(dtC);
                        odcon.Close();
                        numar = Convert.ToInt32(dtC.Rows[0][0]) + 1;

                        odcom.CommandText = "Update Fisiere set Nr='" + numar + "' where cale=@cale";
                        odcom.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                        odcon.Open();
                        odcom.ExecuteNonQuery();
                        odcon.Close();
                        odcom.CommandText = "Update Fisiere set Timp='" + DateTime.Now + "' where cale=@cale";
                        odcom.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                        odcon.Open();
                        odcom.ExecuteNonQuery();
                        odcon.Close();
                        ttip.SetToolTip(btn, "Last accessed at: " + DateTime.Now + " \nNumber of clicks: " + numar + " \nSize: " + l + "");
                    };

                    st.Click += (s, e1) =>
                    {
                        OleDbConnection odcon = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
                        OleDbCommand odcom = new OleDbCommand("Delete from Fisiere where Cale like @cale", odcon);
                        odcom.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                        odcon.Open();
                        odcom.ExecuteNonQuery();
                        odcon.Close();
                        panelFold.Controls.Remove(st);
                        panelFold.Controls.Remove(btn);
                        panelFold.Controls.Remove(pan);
                        st.Dispose();
                        btn.Dispose();
                        pan.Dispose();
                        int xc = xyfol[lbfol.IndexOf(btn)].Item1;
                        int yc = xyfol[lbfol.IndexOf(btn)].Item2;
                        for (int i = lbfol.IndexOf(btn) + 1; i < lbfol.Count; i++)
                        {
                            int xnou = xyfol[i].Item1;
                            int ynou = xyfol[i].Item2;

                            lbfol[i].Location = new Point(yc, xc);
                            lpfol[i].Location = new Point(yc, xc + 85);
                            lstfol[i].Location = new Point(yc + 175, xc);
                            xc = xnou;
                            yc = ynou;
                        }
                        lbfol.Remove(btn);
                        lpfol.Remove(pan);
                        lstfol.Remove(st);

                        lasty4 -= 200;
                        if (lasty4 < 20)
                        {
                            lasty4 = 20;
                            lastx4 -= 120;
                        }
                    };

                    panelFold.Controls.Add(st);
                    panelFold.Controls.Add(btn);
                }
            }
        }

        string split(string path)
        {
            string[] myData = path.Split('\\');
            string final = "";
            int ok = 0;
            foreach (string s in myData)
            {
                if (ok == 1)
                    final += s + "\\";
                if (String.Compare(s, "Debug") == 0)
                    ok = 1;
                
            }

            return final;
        }


        public void buton_jocuri(string path3)
        {
            string save = path3;
            string path = path3;
            string path2 = Path.Combine(Environment.CurrentDirectory, split(path3));
            path2 = path2.Remove(path2.Length - 1);
            if (!File.Exists(path3) && File.Exists(path2))
                path = path2;

            if (File.Exists(path))
            {
                Buton btn = new Buton();
                FileInfo fi = new FileInfo(path);
                string l = GetLengthOfFile(fi.Length);

                btn.Location = new Point(lasty1, lastx1);
                Panel pan = new Panel();
                pan.Size = new Size(190, 15);
                pan.Location = new Point(lasty1, lastx1 + 85);
                pan.BackColor = cul5;
                TextBox tB = new TextBox();
                tB.Size = new Size(180, 15);
                tB.ReadOnly = true;
                tB.BorderStyle = BorderStyle.None;
                tB.BackColor = cul5;
                tB.DoubleClick += new EventHandler(tB_DoubleClick);
                tB.KeyDown += new KeyEventHandler(tB_KeyDown);
                tB.ForeColor = cul4;
                tB.AutoSize = true;
                pan.Controls.Add(tB);
                pan.BringToFront();
                panelJoc.Controls.Add(pan);

                Buton_stergere st = new Buton_stergere();
                st.Location = new Point(lasty1 + 175, lastx1);
                xyjoc.Add(Tuple.Create(lastx1, lasty1));

                lasty1 += 200;
                if (lasty1 > 1200)
                {
                    lasty1 = 20;
                    lastx1 += 120;
                }

                Icon icon = Icon.ExtractAssociatedIcon(path);
                Bitmap bp = new Bitmap(icon.ToBitmap(), new Size(50, 50));
                btn.BackgroundImage = bp;
                btn.BackgroundImageLayout = ImageLayout.Center;


                lbjoc.Add(btn);
                lpjoc.Add(pan);
                lstjoc.Add(st);
                list.Add(btn);
                ls.Add(path);
                tB.AccessibleDescription = ls[list.IndexOf(btn)];

                //MessageBox.Show(path + " " + save);
                OleDbConnection odco = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
                OleDbCommand odcom = new OleDbCommand("Update Fisiere set Cale='" + path + "' where Cale=@cale", odco);
                odcom.Parameters.AddWithValue("@cale", save);
                odco.Open();
                odcom.ExecuteNonQuery();
                odco.Close();

                OleDbCommand odcomd = new OleDbCommand("Select Nr from Fisiere where Cale=@cale", odco);
                odcomd.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                odco.Open();
                OleDbDataAdapter da1 = new OleDbDataAdapter();
                da1.SelectCommand = odcomd;
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                odco.Close();
                int nr1 = Convert.ToInt32(dt1.Rows[0][0]);

                odcomd.CommandText = "Select Timp from Fisiere where Cale=@cale";
                odcomd.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                odco.Open();
                OleDbDataAdapter da2 = new OleDbDataAdapter();
                da2.SelectCommand = odcomd;
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                odco.Close();
                DateTime dateTime1 = Convert.ToDateTime(dt2.Rows[0][0]);
                ttip.SetToolTip(btn, "Ultima accesare: " + dateTime1 + " \nNumăr de accesări: " + nr1 + " \nSize: " + l + "");

                odcomd.CommandText = "Select Nume from Fisiere where Cale=@cale";
                odcomd.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                odco.Open();
                OleDbDataAdapter da3 = new OleDbDataAdapter();
                da3.SelectCommand = odcomd;
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                odco.Close();
                string str = dt3.Rows[0][0].ToString();
                tB.Text = str;

                btn.Click += (s, e1) =>
                {
                    Process process = new Process();
                    process.StartInfo.FileName = ls[list.IndexOf(btn)];
                    process.Start();
                    OleDbConnection odcon = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
                    int numar = 0;
                    odcom = new OleDbCommand("Select Nr from Fisiere where Cale like @cale", odcon);
                    odcom.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                    odcon.Open();
                    OleDbDataAdapter da = new OleDbDataAdapter();
                    da.SelectCommand = odcom;
                    DataTable dtC = new DataTable();
                    da.Fill(dtC);
                    odcon.Close();
                    numar = Convert.ToInt32(dtC.Rows[0][0]) + 1;

                    odcom.CommandText = "Update Fisiere set Nr='" + numar + "' where cale=@cale";
                    odcom.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                    odcon.Open();
                    odcom.ExecuteNonQuery();
                    odcon.Close();
                    odcom.CommandText = "Update Fisiere set Timp='" + DateTime.Now + "' where cale=@cale";
                    odcom.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                    odcon.Open();
                    odcom.ExecuteNonQuery();
                    odcon.Close();
                    ttip.SetToolTip(btn, "Ultima accesare: " + DateTime.Now + " \nNumăr de accesări: " + numar + " \nSize: " + l + "");
                };

                st.Click += (s, e1) =>
                {
                    OleDbConnection odcon = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
                    odcom = new OleDbCommand("Delete from Fisiere where Cale like @cale", odcon);
                    odcom.Parameters.AddWithValue("@cale", path);
                    odcon.Open();
                    odcom.ExecuteNonQuery();
                    odcon.Close();
                    panelJoc.Controls.Remove(st);
                    panelJoc.Controls.Remove(btn);
                    panelJoc.Controls.Remove(pan);
                    st.Dispose();
                    btn.Dispose();
                    pan.Dispose();
                    int xc = xyjoc[lbjoc.IndexOf(btn)].Item1;
                    int yc = xyjoc[lbjoc.IndexOf(btn)].Item2;
                    for (int i = lbjoc.IndexOf(btn) + 1; i < lbjoc.Count; i++)
                    {
                        int xnou = xyjoc[i].Item1;
                        int ynou = xyjoc[i].Item2;

                        lbjoc[i].Location = new Point(yc, xc);
                        lpjoc[i].Location = new Point(yc, xc + 85);
                        lstjoc[i].Location = new Point(yc + 175, xc);
                        xc = xnou;
                        yc = ynou;
                    }
                    lbjoc.Remove(btn);
                    lpjoc.Remove(pan);
                    lstjoc.Remove(st);

                    lasty1 -= 200;
                    if (lasty1 < 20)
                    {
                        lasty1 = 20;
                        lastx1 -= 120;
                    }
                };

                panelJoc.Controls.Add(st);
                panelJoc.Controls.Add(btn);
            }
        }

        public void buton_aplicatii(string path3)
        {
            string save = path3;
            string path = path3;
            string path2 = Path.Combine(Environment.CurrentDirectory, split(path3));
            path2 = path2.Remove(path2.Length - 1);
            if (!File.Exists(path3) && File.Exists(path2))
                path = path2;
            

            if (File.Exists(path))
            {
                Buton btn = new Buton();
                FileInfo fi = new FileInfo(path);
                string l = GetLengthOfFile(fi.Length);

                btn.Location = new Point(lasty2, lastx2);
                Panel pan = new Panel();
                pan.Size = new Size(190, 15);
                pan.Location = new Point(lasty2, lastx2 + 85);
                pan.BackColor = cul5;
                TextBox tB = new TextBox();
                tB.Size = new Size(180, 15);
                tB.ReadOnly = true;
                tB.BorderStyle = BorderStyle.None;
                tB.BackColor = cul5;
                tB.DoubleClick += new EventHandler(tB_DoubleClick);
                tB.KeyDown += new KeyEventHandler(tB_KeyDown);
                tB.ForeColor = cul4;
                tB.AutoSize = true;
                pan.Controls.Add(tB);
                pan.BringToFront();
                panelApp.Controls.Add(pan);

                Buton_stergere st = new Buton_stergere();
                st.Location = new Point(lasty2 + 175, lastx2);
                xyapp.Add(Tuple.Create(lastx2, lasty2));

                lasty2 += 200;
                if (lasty2 > 1200)
                {
                    lasty2 = 20;
                    lastx2 += 120;
                }

                Icon icon = Icon.ExtractAssociatedIcon(path);
                Bitmap bp = new Bitmap(icon.ToBitmap(), new Size(50, 50));
                btn.BackgroundImage = bp;
                btn.BackgroundImageLayout = ImageLayout.Center;

                lbapp.Add(btn);
                lpapp.Add(pan);
                lstapp.Add(st);
                list.Add(btn);
                ls.Add(path);
                tB.AccessibleDescription = ls[list.IndexOf(btn)];

                OleDbConnection odco = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
                OleDbCommand odcom = new OleDbCommand("Update Fisiere set Cale='" + path + "' where Cale=@cale", odco);
                odcom.Parameters.AddWithValue("@cale", save);
                odco.Open();
                odcom.ExecuteNonQuery();
                odco.Close();

                OleDbCommand odcomd = new OleDbCommand("Select Nr from Fisiere where Cale=@cale", odco);
                odcomd.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                odco.Open();
                OleDbDataAdapter da1 = new OleDbDataAdapter();
                da1.SelectCommand = odcomd;
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                odco.Close();
                int nr1 = Convert.ToInt32(dt1.Rows[0][0]);

                odcomd.CommandText = "Select Timp from Fisiere where Cale=@cale";
                odcomd.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                odco.Open();
                OleDbDataAdapter da2 = new OleDbDataAdapter();
                da2.SelectCommand = odcomd;
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                odco.Close();
                DateTime dateTime1 = Convert.ToDateTime(dt2.Rows[0][0]);
                ttip.SetToolTip(btn, "Ultima accesare: " + dateTime1 + " \nNumăr de accesări: " + nr1 + " \nSize: " + l + "");

                odcomd.CommandText = "Select Nume from Fisiere where Cale=@cale";
                odcomd.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                odco.Open();
                OleDbDataAdapter da3 = new OleDbDataAdapter();
                da3.SelectCommand = odcomd;
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                odco.Close();
                string str = dt3.Rows[0][0].ToString();
                tB.Text = str;

                btn.Click += (s, e1) =>
                {
                    Process process = new Process();
                    process.StartInfo.FileName = ls[list.IndexOf(btn)];
                    process.Start();
                    OleDbConnection odcon = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
                    int numar = 0;
                    odcom = new OleDbCommand("Select Nr from Fisiere where Cale like @cale", odcon);
                    odcom.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                    odcon.Open();
                    OleDbDataAdapter da = new OleDbDataAdapter();
                    da.SelectCommand = odcom;
                    DataTable dtC = new DataTable();
                    da.Fill(dtC);
                    odcon.Close();
                    numar = Convert.ToInt32(dtC.Rows[0][0]) + 1;

                    odcom.CommandText = "Update Fisiere set Nr='" + numar + "' where cale=@cale";
                    odcom.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                    odcon.Open();
                    odcom.ExecuteNonQuery();
                    odcon.Close();
                    odcom.CommandText = "Update Fisiere set Timp='" + DateTime.Now + "' where cale=@cale";
                    odcom.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                    odcon.Open();
                    odcom.ExecuteNonQuery();
                    odcon.Close();
                    ttip.SetToolTip(btn, "Last accessed at: " + DateTime.Now + " \nNumber of clicks: " + numar + " \nSize: " + l + "");
                };

                st.Click += (s, e1) =>
                {
                    OleDbConnection odcon = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
                    odcom = new OleDbCommand("Delete from Fisiere where Cale like @cale", odcon);
                    odcom.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                    odcon.Open();
                    odcom.ExecuteNonQuery();
                    odcon.Close();
                    panelApp.Controls.Remove(st);
                    panelApp.Controls.Remove(btn);
                    panelApp.Controls.Remove(pan);
                    st.Dispose();
                    btn.Dispose();
                    pan.Dispose();
                    int xc = xyapp[lbapp.IndexOf(btn)].Item1;
                    int yc = xyapp[lbapp.IndexOf(btn)].Item2;
                    for (int i = lbapp.IndexOf(btn) + 1; i < lbapp.Count; i++)
                    {
                        int xnou = xyapp[i].Item1;
                        int ynou = xyapp[i].Item2;

                        lbapp[i].Location = new Point(yc, xc);
                        lpapp[i].Location = new Point(yc, xc + 85);
                        lstapp[i].Location = new Point(yc + 175, xc);
                        xc = xnou;
                        yc = ynou;
                    }
                    lbapp.Remove(btn);
                    lpapp.Remove(pan);
                    lstapp.Remove(st);

                    lasty2 -= 200;
                    if (lasty2 < 20)
                    {
                        lasty2 = 20;
                        lastx2 -= 120;
                    }
                };

                panelApp.Controls.Add(st);
                panelApp.Controls.Add(btn);
            }
        }

        public void buton_documente(string path3)
        {
            string save = path3;
            string path = path3;
            string path2 = Path.Combine(Environment.CurrentDirectory, split(path3));
            path2 = path2.Remove(path2.Length - 1);
            if (!File.Exists(path3) && File.Exists(path2))
                path = path2;

            if (File.Exists(path))
            {
                
                Buton btn = new Buton();
                FileInfo fi = new FileInfo(path);
                string l = GetLengthOfFile(fi.Length);

                btn.Location = new Point(lasty3, lastx3);
                Panel pan = new Panel();
                pan.Size = new Size(190, 15);
                pan.Location = new Point(lasty3, lastx3 + 85);
                pan.BackColor = cul5;
                TextBox tB = new TextBox();
                tB.Size = new Size(180, 15);
                tB.ReadOnly = true;
                tB.BorderStyle = BorderStyle.None;
                tB.BackColor = cul5;
                tB.DoubleClick += new EventHandler(tB_DoubleClick);
                tB.KeyDown += new KeyEventHandler(tB_KeyDown);
                tB.ForeColor = cul4;
                tB.AutoSize = true;
                pan.Controls.Add(tB);
                pan.BringToFront();
                panelDoc.Controls.Add(pan);

                Buton_stergere st = new Buton_stergere();
                st.Location = new Point(lasty3 + 175, lastx3);
                xydoc.Add(Tuple.Create(lastx3, lasty3));

                lasty3 += 200;
                if (lasty3 > 1200)
                {
                    lasty3 = 20;
                    lastx3 += 120;
                }

                Icon icon = Icon.ExtractAssociatedIcon(path);
                Bitmap bp = new Bitmap(icon.ToBitmap(), new Size(50, 50));
                btn.BackgroundImage = bp;
                btn.BackgroundImageLayout = ImageLayout.Center;

                lbdoc.Add(btn);
                lpdoc.Add(pan);
                lstdoc.Add(st);
                list.Add(btn);
                ls.Add(path);
                tB.AccessibleDescription = ls[list.IndexOf(btn)];

                OleDbConnection odco = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
                OleDbCommand odcom = new OleDbCommand("Update Fisiere set Cale='" + path + "' where Cale=@cale", odco);
                odcom.Parameters.AddWithValue("@cale", save);
                odco.Open();
                odcom.ExecuteNonQuery();
                odco.Close();

                odcom = new OleDbCommand("Update Fisiere set Cale='" + path + "' where cale=@cale",odco);
                odcom.Parameters.AddWithValue("@cale", save);
                odco.Open();
                odcom.ExecuteNonQuery();
                odco.Close();

                
                OleDbCommand odcomd = new OleDbCommand("Select Nr from Fisiere where Cale=@cale", odco);
                odcomd.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                odco.Open();
                OleDbDataAdapter da1 = new OleDbDataAdapter();
                da1.SelectCommand = odcomd;
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                odco.Close();
                int nr1 = Convert.ToInt32(dt1.Rows[0][0]);

                odcomd.CommandText = "Select Timp from Fisiere where Cale=@cale";
                odcomd.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                odco.Open();
                OleDbDataAdapter da2 = new OleDbDataAdapter();
                da2.SelectCommand = odcomd;
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                odco.Close();
                DateTime dateTime1 = Convert.ToDateTime(dt2.Rows[0][0]);
                ttip.SetToolTip(btn, "Last accessed at: " + dateTime1 + "\nNumber of clicks: " + nr1 + " \nSize: " + l + "");

                odcomd.CommandText = "Select Nume from Fisiere where Cale=@cale";
                odcomd.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                odco.Open();
                OleDbDataAdapter da3 = new OleDbDataAdapter();
                da3.SelectCommand = odcomd;
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                odco.Close();
                string str = dt3.Rows[0][0].ToString();
                tB.Text = str;

                btn.Click += (s, e1) =>
                {
                    Process process = new Process();
                    process.StartInfo.FileName = ls[list.IndexOf(btn)];
                    process.Start();
                    OleDbConnection odcon = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
                    int numar = 0;
                    odcom = new OleDbCommand("Select Nr from Fisiere where Cale like @cale", odcon);
                    odcom.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                    odcon.Open();
                    OleDbDataAdapter da = new OleDbDataAdapter();
                    da.SelectCommand = odcom;
                    DataTable dtC = new DataTable();
                    da.Fill(dtC);
                    odcon.Close();
                    numar = Convert.ToInt32(dtC.Rows[0][0]) + 1;

                    odcom.CommandText = "Update Fisiere set Nr='" + numar + "' where cale=@cale";
                    odcom.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                    odcon.Open();
                    odcom.ExecuteNonQuery();
                    odcon.Close();
                    odcom.CommandText = "Update Fisiere set Timp='" + DateTime.Now + "' where cale=@cale";
                    odcom.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                    odcon.Open();
                    odcom.ExecuteNonQuery();
                    odcon.Close();
                    ttip.SetToolTip(btn, "Last accessed at: " + DateTime.Now + " \nNumber of clicks: " + numar + " \n: " + l + "");
                };

                st.Click += (s, e1) =>
                {
                    OleDbConnection odcon = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
                    odcom = new OleDbCommand("Delete from Fisiere where Cale like @cale", odcon);
                    odcom.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                    odcon.Open();
                    odcom.ExecuteNonQuery();
                    odcon.Close();
                    panelDoc.Controls.Remove(st);
                    panelDoc.Controls.Remove(btn);
                    panelDoc.Controls.Remove(pan);
                    st.Dispose();
                    btn.Dispose();
                    pan.Dispose();
                    int xc = xydoc[lbdoc.IndexOf(btn)].Item1;
                    int yc = xydoc[lbdoc.IndexOf(btn)].Item2;
                    for (int i = lbdoc.IndexOf(btn) + 1; i < lbdoc.Count; i++)
                    {
                        int xnou = xydoc[i].Item1;
                        int ynou = xydoc[i].Item2;

                        lbdoc[i].Location = new Point(yc, xc);
                        lpdoc[i].Location = new Point(yc, xc + 85);
                        lstdoc[i].Location = new Point(yc + 175, xc);
                        xc = xnou;
                        yc = ynou;
                    }
                    lbdoc.Remove(btn);
                    lpdoc.Remove(pan);
                    lstdoc.Remove(st);

                    lasty3 -= 200;
                    if (lasty3 < 20)
                    {
                        lasty3 = 20;
                        lastx3 -= 120;
                    }
                };

                panelDoc.Controls.Add(st);
                panelDoc.Controls.Add(btn);
            }
        }

        public void buton_foldere(string path3)
        {
            string save = path3;
            string path = path3;
            string path2 = Path.Combine(Environment.CurrentDirectory, split(path3));
            path2 = path2.Remove(path2.Length - 1);
            if (!Directory.Exists(path3) && Directory.Exists(path2))
                path = path2;

            if (Directory.Exists(path))
            {
                Buton btn = new Buton();
                string l;
                try
                {
                    long size = GetFileSizeSumFromDirectory(path);
                    l = GetLengthOfFile(size);
                }
                catch
                {
                    l = GetLengthOfFile(long.MaxValue);
                }


                btn.Location = new Point(lasty4, lastx4);
                Panel pan = new Panel();
                pan.Size = new Size(190, 15);
                pan.Location = new Point(lasty4, lastx4 + 85);
                pan.BackColor = cul5;
                TextBox tB = new TextBox();
                tB.Size = new Size(180, 15);
                tB.ReadOnly = true;
                tB.BorderStyle = BorderStyle.None;
                tB.BackColor = cul5;
                tB.DoubleClick += new EventHandler(tB_DoubleClick);
                tB.KeyDown += new KeyEventHandler(tB_KeyDown);

                tB.ForeColor = cul4;
                tB.AutoSize = true;
                pan.Controls.Add(tB);
                pan.BringToFront();
                panelFold.Controls.Add(pan);

                Buton_stergere st = new Buton_stergere();
                st.Location = new Point(lasty4 + 175, lastx4);
                xyfol.Add(Tuple.Create(lastx4, lasty4));

                lasty4 += 200;
                if (lasty4 > 1200)
                {
                    lasty4 = 20;
                    lastx4 += 120;
                }

                int width = 200, height = 100;
                Bitmap bmp = new Bitmap(width, height);
                Random rand = new Random();
                for (int y = 0; y < height; y += height / 4)
                {
                    for (int x = 0; x < width; x += width / 8)
                    {
                        int a = rand.Next(256);
                        int r = rand.Next(256);
                        int g = rand.Next(256);
                        int b = rand.Next(256);
                        for (int k1 = y; k1 < y + height / 2 && k1 < height; k1++)
                            for (int k2 = x; k2 < x + width / 4 && k2 < width; k2++)
                                bmp.SetPixel(k2, k1, Color.FromArgb(a, r, g, b));
                    }
                }
                btn.BackgroundImage = bmp;

                lbfol.Add(btn);
                lpfol.Add(pan);
                lstfol.Add(st);
                list.Add(btn);
                ls.Add(path);
                tB.AccessibleDescription = ls[list.IndexOf(btn)];

                OleDbConnection odco = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
                OleDbCommand odcom = new OleDbCommand("Update Fisiere set Cale='" + path + "' where Cale=@cale", odco);
                odcom.Parameters.AddWithValue("@cale", save);
                odco.Open();
                odcom.ExecuteNonQuery();
                odco.Close();

                OleDbCommand odcomd = new OleDbCommand("Select Nr from Fisiere where Cale=@cale", odco);
                odcomd.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                odco.Open();
                OleDbDataAdapter da1 = new OleDbDataAdapter();
                da1.SelectCommand = odcomd;
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                odco.Close();
                int nr1 = Convert.ToInt32(dt1.Rows[0][0]);

                odcomd.CommandText = "Select Timp from Fisiere where Cale=@cale";
                odcomd.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                odco.Open();
                OleDbDataAdapter da2 = new OleDbDataAdapter();
                da2.SelectCommand = odcomd;
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                odco.Close();
                DateTime dateTime1 = Convert.ToDateTime(dt2.Rows[0][0]);
                ttip.SetToolTip(btn, "Last accessed at: " + dateTime1 + " \nNumber of clicks: " + nr1 + " \nSize: " + l + "");


                odcomd.CommandText = "Select Nume from Fisiere where Cale=@cale";
                odcomd.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                odco.Open();
                OleDbDataAdapter da3 = new OleDbDataAdapter();
                da3.SelectCommand = odcomd;
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                odco.Close();
                string str = dt3.Rows[0][0].ToString();
                tB.Text = str;


                btn.Click += (s, e1) =>
                {
                    Process process = new Process();
                    process.StartInfo.FileName = ls[list.IndexOf(btn)];
                    process.Start();
                    OleDbConnection odcon = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
                    int numar = 0;
                    odcom = new OleDbCommand("Select Nr from Fisiere where Cale like @cale", odcon);
                    odcom.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                    odcon.Open();
                    OleDbDataAdapter da = new OleDbDataAdapter();
                    da.SelectCommand = odcom;
                    DataTable dtC = new DataTable();
                    da.Fill(dtC);
                    odcon.Close();
                    numar = Convert.ToInt32(dtC.Rows[0][0]) + 1;

                    odcom.CommandText = "Update Fisiere set Nr='" + numar + "' where cale=@cale";
                    odcom.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                    odcon.Open();
                    odcom.ExecuteNonQuery();
                    odcon.Close();
                    odcom.CommandText = "Update Fisiere set Timp='" + DateTime.Now + "' where cale=@cale";
                    odcom.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                    odcon.Open();
                    odcom.ExecuteNonQuery();
                    odcon.Close();
                    ttip.SetToolTip(btn, "Last accessed at: " + DateTime.Now + " \nNumber of clicks: " + numar + " \nSize: " + l + "");
                };

                st.Click += (s, e1) =>
                {
                    OleDbConnection odcon = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
                    odcom = new OleDbCommand("Delete from Fisiere where Cale like @cale", odcon);
                    odcom.Parameters.AddWithValue("@cale", ls[list.IndexOf(btn)]);
                    odcon.Open();
                    odcom.ExecuteNonQuery();
                    odcon.Close();
                    panelFold.Controls.Remove(st);
                    panelFold.Controls.Remove(btn);
                    panelFold.Controls.Remove(pan);
                    st.Dispose();
                    btn.Dispose();
                    pan.Dispose();
                    int xc = xyfol[lbfol.IndexOf(btn)].Item1;
                    int yc = xyfol[lbfol.IndexOf(btn)].Item2;
                    for (int i = lbfol.IndexOf(btn) + 1; i < lbfol.Count; i++)
                    {
                        int xnou = xyfol[i].Item1;
                        int ynou = xyfol[i].Item2;

                        lbfol[i].Location = new Point(yc, xc);
                        lpfol[i].Location = new Point(yc, xc + 85);
                        lstfol[i].Location = new Point(yc + 175, xc);
                        xc = xnou;
                        yc = ynou;
                    }
                    lbfol.Remove(btn);
                    lpfol.Remove(pan);
                    lstfol.Remove(st);

                    lasty4 -= 200;
                    if (lasty4 < 20)
                    {
                        lasty4 = 20;
                        lastx4 -= 120;
                    }
                };

                panelFold.Controls.Add(st);
                panelFold.Controls.Add(btn);
            }
        }

        public void colorare()
        {
            Setari settings = new Setari();
            string value = File.ReadAllText(@"extras/radiobuttons.txt");
            if (value == "1")
            {
                settings.radioButton1.Checked = true;
                settings.radioButton2.Checked = false;
                cul1 = Color.FromArgb(64, 64, 64);
                cul2 = Color.FromArgb(50, 50, 50);
                cul3 = SystemColors.ControlDarkDark;
                cul4 = SystemColors.Control;
                cul5 = Color.Black;

                this.button3.BackgroundImage = Image.FromFile(@"images\plus_alb.png");
                this.button4.BackgroundImage = Image.FromFile(@"images\plus_alb.png");
                this.button5.BackgroundImage = Image.FromFile(@"images\plus_alb.png");
                this.button6.BackgroundImage = Image.FromFile(@"images\plus_alb.png");
                this.btnset.BackgroundImage = Image.FromFile(@"images\settings_alb.png");
                this.button1.BackgroundImage = Image.FromFile(@"images\close_alb.png");
                this.button2.BackgroundImage = Image.FromFile(@"images\substract_alb.png");
            }
            else
            {
                settings.radioButton1.Checked = false;
                settings.radioButton2.Checked = true;
                cul1 = Color.FromArgb(224, 224, 224);
                cul2 = Color.FromArgb(240, 240, 240);
                cul3 = SystemColors.ControlDark;
                cul4 = SystemColors.ActiveCaptionText;
                cul5 = Color.White;

                this.button3.BackgroundImage = Image.FromFile(@"images\plus_negru.png");
                this.button4.BackgroundImage = Image.FromFile(@"images\plus_negru.png");
                this.button5.BackgroundImage = Image.FromFile(@"images\plus_negru.png");
                this.button6.BackgroundImage = Image.FromFile(@"images\plus_negru.png");
                this.btnset.BackgroundImage = Image.FromFile(@"images\settings_negru.png");
                this.button1.BackgroundImage = Image.FromFile(@"images\close_negru.png");
                this.button2.BackgroundImage = Image.FromFile(@"images\substract_negru.png");
            }


            this.btnset.BackColor = cul2;
            this.button2.BackColor = cul2;
            this.btnjocuri.BackColor = cul2;
            this.btnjocuri.ForeColor = cul4;
            this.btnapp.BackColor = cul2;
            this.btndoc.BackColor = cul2;
            this.btnfold.BackColor = cul2;
            this.btnapp.ForeColor = cul3;
            this.btndoc.ForeColor = cul3;
            this.btnfold.ForeColor = cul3;
            this.panel1.BackColor = cul2;
            this.BackColor = cul2;
            this.jocuri.BackColor = cul2;
            this.app.BackColor = cul2;
            this.doc.BackColor = cul2;
            this.foldere.BackColor = cul2;
            this.panelJoc.BackColor = cul1;
            this.panelApp.BackColor = cul1;
            this.panelDoc.BackColor = cul1;
            this.panelFold.BackColor = cul1;
            this.label1.ForeColor = cul4;
            
        }

        private void Librarie_Load(object sender, EventArgs e)
        {
            customTabControl1.SelectedTab = jocuri;
            Setari settings = new Setari();
            string value = File.ReadAllText(@"extras/radiobuttons.txt");
            if (value == "1")
            {
                settings.radioButton1.Checked = true;
                settings.radioButton2.Checked = false;
            }
            else
            {
                settings.radioButton1.Checked = false;
                settings.radioButton2.Checked = true;
            }

            colorare();

            OleDbConnection odc = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
            OleDbCommand odcmd = new OleDbCommand("Select * from Fisiere", odc);
            odc.Open();
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = odcmd;
            DataTable dtC = new DataTable();
            da.Fill(dtC);
            odc.Close();

            odcmd = new OleDbCommand("Select Tab from Fisiere", odc);
            odc.Open();
            da = new OleDbDataAdapter();
            da.SelectCommand = odcmd;
            DataTable dtT = new DataTable();
            da.Fill(dtT);
            odc.Close();

            for (int i = 0; i < dtC.Rows.Count; i++)
            {
                string path = dtC.Rows[i][0].ToString();
                int tab = Convert.ToInt32(dtT.Rows[i][0]);
                switch (tab)
                {
                    case 1:
                        buton_jocuri(path);
                        break;
                    case 2:
                        buton_aplicatii(path);
                        break;
                    case 3:
                        buton_documente(path);
                        break;
                    case 4:
                        buton_foldere(path);
                        break;
                    default:
                        MessageBox.Show("Error: something went wrong.");
                        break;
                }
            }

            comboBox1.SelectedIndex = 0;
        }

        public void reload()
        {
            panelJoc.Controls.Clear();
            panelApp.Controls.Clear();
            panelDoc.Controls.Clear();
            panelFold.Controls.Clear();
            lastx1 = 20; lasty1 = 20;
            lastx2 = 20; lasty2 = 20;
            lastx3 = 20; lasty3 = 20;
            lastx4 = 20; lasty4 = 20;
            for (int i = 1; i <= count; i++)
            {
                int tab = data[i].tab;

                //butoane noi

                string path = data[i].path;
                switch (tab)
                {
                    case 1:
                        buton_jocuri(path);
                        break;
                    case 2:
                        buton_aplicatii(path);
                        break;
                    case 3:
                        buton_documente(path);
                        break;
                    case 4:
                        buton_foldere(path);
                        break;
                    default:
                        MessageBox.Show("Error: something went wrong.");
                        break;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection odcon = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
            OleDbCommand odcom = new OleDbCommand("Select * from Fisiere", odcon);
            odcon.Open();
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = odcom;
            DataTable dtC = new DataTable();
            da.Fill(dtC);
            odcon.Close();

            count = 0;
            foreach (DataRow row in dtC.Rows)
            {
                data[++count].path = row["Cale"].ToString();
                data[count].dt = Convert.ToDateTime(row["Timp"]);
                data[count].nr = Convert.ToInt32(row["Nr"]);
                data[count].tab = Convert.ToInt32(row["Tab"]);
                data[count].dim = Convert.ToInt64(row["Dimensiune"]);
                data[count].nume = row["Nume"].ToString();
            }

            if (comboBox1.SelectedIndex == 0)
            {
                //sortare Nume
                for (int i = 1; i < count; i++)
                {
                    for (int j = i + 1; j <= count; j++)
                    {
                        if (String.Compare(data[i].nume.ToLower(), data[j].nume.ToLower()) > 0)
                        {
                            rand aux = data[i];
                            data[i] = data[j];
                            data[j] = aux;
                        }
                    }
                }

                reload();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                //sortare DataModificarii
                for (int i = 1; i < count; i++)
                {
                    for (int j = i + 1; j <= count; j++)
                    {
                        if (data[i].dt < data[j].dt)
                        {
                            rand aux = data[i];
                            data[i] = data[j];
                            data[j] = aux;
                        }
                    }
                }

                reload();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                //sortare Nr
                for (int i = 1; i < count; i++)
                {
                    for (int j = i + 1; j <= count; j++)
                    {
                        if (data[i].nr < data[j].nr)
                        {
                            rand aux = data[i];
                            data[i] = data[j];
                            data[j] = aux;
                        }
                    }
                }

                //Reincarcare Forma
                reload();

            }
            else if (comboBox1.SelectedIndex == 3)
            {
                //sortare Dimensiune
                for (int i = 1; i < count; i++)
                {
                    for (int j = i + 1; j <= count; j++)
                    {
                        if (data[i].dim < data[j].dim)
                        {
                            rand aux = data[i];
                            data[i] = data[j];
                            data[j] = aux;
                        }
                    }
                }

                reload();
            }
        }


    }
}
