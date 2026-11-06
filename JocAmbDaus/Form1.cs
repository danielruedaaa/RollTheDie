using JocAmbDaus.CLASSES;
using JocAmbDaus.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocAmbDaus
{
    public partial class Form1 : Form
    {
        int qttJugadors = 0, jugadorsConfirmats = 0;
        List<Color> llColors = new List<Color>() {Color.Blue, Color.Green, Color.Yellow, Color.Red };
        ClJugador jugador1, jugador2, jugador3, jugador4;
        List<ClJugador> jugadors = new List<ClJugador>();
        List<ClDau> daus = new List<ClDau>();

        //DAUS 
        ClDau dau1, dau2, dau3, dau4;
        ClTauler tauler;
        Random rnd = new Random();
        int num1 = 1, num2 = 1, num3 = 1, num4 = 1;

        const int MAX_TIRADA = 15;
        const int MIN_TIRADA = 8;

        List<int> ordreJugadors = new List<int>();
        Dictionary<int, int> resultats = new Dictionary<int, int>();
        List<int> empatats = new List<int>();

        System.Windows.Forms.Timer tm1 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer tm2 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer tm3 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer tm4 = new System.Windows.Forms.Timer();

        int contador1, contador2, contador3, contador4;
        int tirada1, tirada2, tirada3, tirada4;
        int valor1, valor2, valor3, valor4;

        bool faseDesempat = false;
        bool animant = false;

    

        int jugadorActual = 0;
        bool jocActiu = false;
        System.Windows.Forms.Timer tmrTorn = new System.Windows.Forms.Timer();
        Dictionary<ClFitxa, int> posicions = new Dictionary<ClFitxa, int>();

  
        int CASSELLES_TOTALS = 100;

        private bool esClar = false;
        private Panel pnlCap;
        private Label lblCap;
        private Button btnTema;
        private Button btnMin;
        private Button btnTancar;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            CrearCapcalera();
            AplicarTema();
        }

        private void CrearCapcalera()
        {
            if (pnlCap != null) return;

            pnlCap = new Panel();
            pnlCap.Height = 52;
            pnlCap.Dock = DockStyle.Top;
            pnlCap.Padding = new Padding(12, 0, 8, 0);
            this.Controls.Add(pnlCap);
            pnlCap.BringToFront();

            lblCap = new Label();
            lblCap.AutoSize = false;
            lblCap.Dock = DockStyle.Fill;
            lblCap.TextAlign = ContentAlignment.MiddleLeft;
            pnlCap.Controls.Add(lblCap);

            FlowLayoutPanel accions = new FlowLayoutPanel();
            accions.Dock = DockStyle.Right;
            accions.Width = 150;
            accions.FlowDirection = FlowDirection.RightToLeft;
            accions.WrapContents = false;
            accions.Padding = new Padding(0, 9, 0, 0);
            pnlCap.Controls.Add(accions);

            btnTancar = new Button(); btnTancar.Text = "✕"; btnTancar.Width = 40; btnTancar.Height = 32;
            btnMin = new Button(); btnMin.Text = "—"; btnMin.Width = 40; btnMin.Height = 32;
            btnTema = new Button(); btnTema.Width = 44; btnTema.Height = 32;

            foreach (var b in new[] { btnTancar, btnMin, btnTema })
            {
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.Cursor = Cursors.Hand;
                b.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                accions.Controls.Add(b);
            }

            btnTancar.Click += (s, e) => this.Close();
            btnMin.Click += (s, e) => this.WindowState = FormWindowState.Minimized;
            btnTema.Click += (s, e) => { esClar = !esClar; AplicarTema(); };

            // Arrastrar ventana sin bordes desde la cabecera
            bool arrossegant = false;
            Point inici = Point.Empty;
            pnlCap.MouseDown += (s, e) => { if (e.Button == MouseButtons.Left) { arrossegant = true; inici = e.Location; } };
            pnlCap.MouseMove += (s, e) =>
            {
                if (arrossegant && this.WindowState != FormWindowState.Maximized)
                    this.Location = new Point(this.Location.X + e.X - inici.X, this.Location.Y + e.Y - inici.Y);
            };
            pnlCap.MouseUp += (s, e) => arrossegant = false;
            lblCap.MouseDown += (s, e) => { if (e.Button == MouseButtons.Left) { arrossegant = true; inici = new Point(lblCap.Left + e.X, e.Y); } };
            lblCap.MouseMove += (s, e) =>
            {
                if (arrossegant && this.WindowState != FormWindowState.Maximized)
                    this.Location = new Point(this.Location.X + e.X + lblCap.Left - inici.X, this.Location.Y + e.Y - inici.Y);
            };
            lblCap.MouseUp += (s, e) => arrossegant = false;
        }

        private static void ArrodonirBoto(Button b, int radi)
        {
            if (b == null || b.Width == 0) return;
            try
            {
                var path = new System.Drawing.Drawing2D.GraphicsPath();
                int d = radi * 2;
                path.AddArc(0, 0, d, d, 180, 90);
                path.AddArc(b.Width - d - 1, 0, d, d, 270, 90);
                path.AddArc(b.Width - d - 1, b.Height - d - 1, d, d, 0, 90);
                path.AddArc(0, b.Height - d - 1, d, d, 90, 90);
                path.CloseFigure();
                if (b.Region != null) b.Region.Dispose();
                b.Region = new Region(path);
            }
            catch { }
        }

        private void AplicarTema()
        {
            Color fons, targeta, cap, text, textSuau, verd, groc;
            if (esClar)
            {
                fons = Color.FromArgb(240, 242, 245);
                targeta = Color.White;
                cap = Color.White;
                text = Color.FromArgb(25, 25, 35);
                textSuau = Color.FromArgb(90, 90, 110);
                verd = Color.FromArgb(0, 170, 70);
                groc = Color.FromArgb(150, 100, 0);
            }
            else
            {
                fons = Color.FromArgb(30, 30, 46);
                targeta = Color.FromArgb(38, 38, 58);
                cap = Color.FromArgb(20, 20, 34);
                text = Color.White;
                textSuau = Color.FromArgb(170, 170, 190);
                verd = Color.FromArgb(0, 200, 83);
                groc = Color.FromArgb(255, 214, 10);
            }
            Font fontBase = new Font("Segoe UI", 9F, FontStyle.Regular);
            Font fontTitol = new Font("Segoe UI", 12F, FontStyle.Bold);

            this.BackColor = fons;
            this.ForeColor = text;
            this.Font = fontBase;

            if (pnlCap != null)
            {
                pnlCap.BackColor = cap;
                pnlCap.BringToFront();
                lblCap.Text = esClar ? "  🎲 JOC AMB DAUS  ·  mode clar" : "  🎲 JOC AMB DAUS  ·  2-4 jugadors · 100 caselles";
                lblCap.ForeColor = text;
                lblCap.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                btnTema.Text = esClar ? "☀️" : "🌙";
                foreach (var b in new[] { btnTema, btnMin, btnTancar })
                {
                    b.BackColor = cap;
                    b.ForeColor = text;
                    b.FlatAppearance.MouseOverBackColor = esClar ? Color.FromArgb(225, 228, 235) : Color.FromArgb(55, 55, 80);
                    ArrodonirBoto(b, 8);
                }
                btnTancar.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 60, 60);
            }

            GroupBox[] grups = { gbQttJugadors, gbInfoJugadors, gbDaus };
            foreach (var gb in grups)
            {
                if (gb == null) continue;
                gb.BackColor = targeta;
                gb.ForeColor = text;
                gb.Font = fontTitol;
                gb.Text = string.Empty;
            }

            Button[] botons = { btAcceptar, btAcceptar1, btAcceptar2, btAcceptar3, btAcceptar4 };
            foreach (var b in botons)
            {
                if (b == null) continue;
                b.BackColor = verd;
                b.ForeColor = Color.White;
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                b.Cursor = Cursors.Hand;
                b.UseVisualStyleBackColor = false;
                ArrodonirBoto(b, 10);
                b.Resize += (s, e) => ArrodonirBoto((Button)s, 10);
            }

            Label[] etiquetes = { label1, lbJug1, lbJug2, lbJug3, lbJug4, lbNick1, lbNick2, lbNick3, lbNick4, lbColor1, lbColor2, lbColor3, lbColor4, lbNicknameJug1, lbNicknameJug2, lbNicknameJug3, lbNicknameJug4 };
            foreach (var l in etiquetes)
            {
                if (l == null) continue;
                l.ForeColor = text;
                l.Font = fontBase;
                l.BackColor = Color.Transparent;
            }
            // Nicks en partida destacan un poco más
            foreach (var l in new[] { lbNicknameJug1, lbNicknameJug2, lbNicknameJug3, lbNicknameJug4 })
                if (l != null) l.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            lbLlancar.ForeColor = groc;
            lbLlancar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbLlancar.BackColor = Color.Transparent;

            Label[] conf = { lbConfirmatJug1, lbConfirmatJug2, lbConfirmatJug3, lbConfirmatJug4 };
            foreach (var l in conf)
            {
                if (l == null) continue;
                l.ForeColor = esClar ? Color.FromArgb(0, 150, 60) : Color.FromArgb(0, 230, 118);
                l.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                l.BackColor = Color.Transparent;
            }

            Panel[] daus = { pnlDau1, pnlDau2, pnlDau3, pnlDau4 };
            foreach (var p in daus)
            {
                if (p == null) continue;
                p.BorderStyle = BorderStyle.FixedSingle;
                p.Cursor = Cursors.Hand;
            }

            pnlTauler.BackColor = targeta;
            pnlTauler.BorderStyle = BorderStyle.FixedSingle;

            // Desplazar contenido bajo la cabecera (form sin bordes)
            int topBase = 52;
            if (gbQttJugadors.Top < topBase) gbQttJugadors.Top = topBase + 8;
            if (gbInfoJugadors.Top < topBase) gbInfoJugadors.Top = topBase + 8;

            nudQttJugadors.BackColor = Color.White;
            nudQttJugadors.ForeColor = Color.Black;
            nudQttJugadors.Font = new Font("Segoe UI", 11F, FontStyle.Bold);

            if (tauler != null)
            {
                tauler.TemaClar = esClar;
                tauler.Refrescar();
            }
            this.Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btAcceptar_Click(object sender, EventArgs e)
        {
            gbQttJugadors.Visible = false;
            qttJugadors = (int)nudQttJugadors.Value;

            gbInfoJugadors.Visible = true;

            for (int i = 1; i <= qttJugadors; i++)
            {
                switch (i)
                {
                    case 1:
                        cbColorJug1.DataSource = llColors;
                        cbColorJug1.DisplayMember = "Name";
                        break;

                    case 2:
                        cbColorJug2.DataSource = llColors;
                        cbColorJug2.DisplayMember = "Name";
                        break;

                    case 3:
                        cbColorJug3.DataSource = llColors;
                        cbColorJug3.DisplayMember = "Name";
                        lbJug3.Visible = true; lbNick3.Visible = true; lbColor3.Visible = true; tbNickJug3.Visible = true; cbColorJug3.Visible = true; btAcceptar3.Visible = true;
                        break;

                    case 4:
                        cbColorJug4.DataSource = llColors;
                        cbColorJug4.DisplayMember = "Name";
                        lbJug4.Visible = true; lbNick4.Visible = true; lbColor4.Visible = true; tbNickJug4.Visible = true; cbColorJug4.Visible = true; btAcceptar4.Visible = true;
                        break;

                }
            }

        }

        private void btAcceptarJug1_Click(object sender, EventArgs e) => ConfirmarJugador(1);
        private void btAcceptar2_Click(object sender, EventArgs e) => ConfirmarJugador(2);
        private void btAcceptar3_Click(object sender, EventArgs e) => ConfirmarJugador(3);
        private void btAcceptar4_Click(object sender, EventArgs e) => ConfirmarJugador(4);

        private void ConfirmarJugador(int num)
        {
            TextBox tbNick; ComboBox cbColor; Button btAcc; Label lbConf;
            Label lbNick, lbColor; Panel pnlDau;

            switch (num)
            {
                case 1: tbNick = tbNickJug1; cbColor = cbColorJug1; btAcc = btAcceptar1; lbConf = lbConfirmatJug1; lbNick = lbNick1; lbColor = lbColor1; pnlDau = pnlDau1; break;
                case 2: tbNick = tbNickJug2; cbColor = cbColorJug2; btAcc = btAcceptar2; lbConf = lbConfirmatJug2; lbNick = lbNick2; lbColor = lbColor2; pnlDau = pnlDau2; break;
                case 3: tbNick = tbNickJug3; cbColor = cbColorJug3; btAcc = btAcceptar3; lbConf = lbConfirmatJug3; lbNick = lbNick3; lbColor = lbColor3; pnlDau = pnlDau3; break;
                case 4: tbNick = tbNickJug4; cbColor = cbColorJug4; btAcc = btAcceptar4; lbConf = lbConfirmatJug4; lbNick = lbNick4; lbColor = lbColor4; pnlDau = pnlDau4; break;
                default: return;
            }

            if (string.IsNullOrWhiteSpace(tbNick.Text))
            {
                MessageBox.Show("Jugador " + num + ", et falta el nickname", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbColor.SelectedItem == null)
            {
                MessageBox.Show("Jugador " + num + ", tria un color", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClJugador jugador = new ClJugador(tbNick.Text.Trim(), (Color)cbColor.SelectedItem, num);
            switch (num)
            {
                case 1: jugador1 = jugador; dau1 = new ClDau(pnlDau1, 1); break;
                case 2: jugador2 = jugador; dau2 = new ClDau(pnlDau2, 1); break;
                case 3: jugador3 = jugador; dau3 = new ClDau(pnlDau3, 1); break;
                case 4: jugador4 = jugador; dau4 = new ClDau(pnlDau4, 1); break;
            }

            llColors.RemoveAt(cbColor.SelectedIndex);
            refreshComboBoxes(num);
            jugadorsConfirmats++;
            btAcc.Visible = false;
            lbConf.Visible = true;
            cbColor.Visible = false;
            lbColor.Visible = false;
            lbNick.Visible = false;
            tbNick.Visible = false;
            jugadors.Add(jugador);

            pnlDau.Refresh();
            revisarJugadorsConfirmats();
        }

        private void CrearFitxesJugador(ClJugador jugador, Panel pnlDau)
        {
            int mida = 20;
            int separacio = 5;
            // pnlDau.Right/Top están en coords de gbDaus, así que las
            // fichas deben colgar de gbDaus (no del Form) para quedar
            // a la altura del dado.
            int x = pnlDau.Right + 10;
            int y = pnlDau.Top + (pnlDau.Height / 2) - (mida / 2);

            for (int i = 0; i < jugador.Fitxes.Count; i++)
            {
                int posX = x + i * (mida + separacio);
                int posY = y;

                jugador.Fitxes[i].CrearVisual(gbDaus, posX, posY);
            }
        }




        private void refreshComboBoxes(int i)
        {
            switch (i) 
            {
                case 1:
                    cbColorJug2.DataSource = null; cbColorJug2.DataSource = llColors; cbColorJug2.DisplayMember = "Name";
                    cbColorJug3.DataSource = null; cbColorJug3.DataSource = llColors; cbColorJug3.DisplayMember = "Name";
                    cbColorJug4.DataSource = null; cbColorJug4.DataSource = llColors; cbColorJug4.DisplayMember = "Name";
                    break;

                case 2:
                    cbColorJug1.DataSource = null; cbColorJug1.DataSource = llColors; cbColorJug1.DisplayMember = "Name";
                    cbColorJug3.DataSource = null; cbColorJug3.DataSource = llColors; cbColorJug3.DisplayMember = "Name";
                    cbColorJug4.DataSource = null; cbColorJug4.DataSource = llColors; cbColorJug4.DisplayMember = "Name";
                    break;

                case 3:
                    cbColorJug2.DataSource = null; cbColorJug2.DataSource = llColors; cbColorJug2.DisplayMember = "Name";
                    cbColorJug1.DataSource = null; cbColorJug1.DataSource = llColors; cbColorJug1.DisplayMember = "Name";
                    cbColorJug4.DataSource = null; cbColorJug4.DataSource = llColors; cbColorJug4.DisplayMember = "Name";
                    break;

                case 4:
                    cbColorJug2.DataSource = null; cbColorJug2.DataSource = llColors; cbColorJug2.DisplayMember = "Name";
                    cbColorJug3.DataSource = null; cbColorJug3.DataSource = llColors; cbColorJug3.DisplayMember = "Name";
                    cbColorJug1.DataSource = null; cbColorJug1.DataSource = llColors; cbColorJug1.DisplayMember = "Name";
                    break;
            }
        }

        private void revisarJugadorsConfirmats()
        {
            if (jugadorsConfirmats == qttJugadors)
            {
                MessageBox.Show("Tots els jugadors han estat confirmats!", "Informació", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbInfoJugadors.Visible = false;
                gbDaus.Visible = true;

                switch (jugadorsConfirmats)
                {
                    case 2:
                        lbNicknameJug1.Text = jugador1.nick; pnlDau1.BackColor = jugador1.color;
                        lbNicknameJug2.Text = jugador2.nick; pnlDau2.BackColor = jugador2.color;
                        lbNicknameJug3.Visible = false; lbNicknameJug4.Visible = false; pnlDau3.Visible = false; pnlDau4.Visible = false;
                        CrearFitxesJugador(jugador1, pnlDau1); CrearFitxesJugador(jugador2, pnlDau2);
                        break;
                    case 3:
                        lbNicknameJug1.Text = jugador1.nick; pnlDau1.BackColor = jugador1.color;
                        lbNicknameJug2.Text = jugador2.nick; pnlDau2.BackColor = jugador2.color;
                        lbNicknameJug3.Text = jugador3.nick; pnlDau3.BackColor = jugador3.color;
                        lbNicknameJug4.Visible = false; pnlDau4.Visible = false;
                        CrearFitxesJugador(jugador1, pnlDau1); CrearFitxesJugador(jugador2, pnlDau2); CrearFitxesJugador(jugador3, pnlDau3);
                        break;
                    case 4:
                        lbNicknameJug1.Text = jugador1.nick; pnlDau1.BackColor = jugador1.color;
                        lbNicknameJug2.Text = jugador2.nick; pnlDau2.BackColor = jugador2.color;
                        lbNicknameJug3.Text = jugador3.nick; pnlDau3.BackColor = jugador3.color;
                        lbNicknameJug4.Text = jugador4.nick; pnlDau4.BackColor = jugador4.color;
                        CrearFitxesJugador(jugador1, pnlDau1); CrearFitxesJugador(jugador2, pnlDau2); CrearFitxesJugador(jugador3, pnlDau3); CrearFitxesJugador(jugador4, pnlDau4);
                        break;
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dau1 = new ClDau(pnlDau1, 1);
            dau2 = new ClDau(pnlDau2, 1);
            dau3 = new ClDau(pnlDau3, 1);
            dau4 = new ClDau(pnlDau4, 1);

            tm1.Interval = tm2.Interval = tm3.Interval = tm4.Interval = 100;
            tm1.Tick += tm1_Tick;
            tm2.Tick += tm2_Tick;
            tm3.Tick += tm3_Tick;
            tm4.Tick += tm4_Tick;

            tauler = new ClTauler(pnlTauler);
            tauler.TemaClar = esClar;

            pnlTauler.Width = 700;
            pnlTauler.Height = 700;
            pnlTauler.Left = (this.ClientSize.Width - pnlTauler.Width) / 2;
            pnlTauler.Top = 52 + 8;
            gbDaus.Top = 52 + 8;
        }

        private void pnlDau1_Click(object sender, EventArgs e) => TirarDau(1);
        private void pnlDau2_Click(object sender, EventArgs e) => TirarDau(2);
        private void pnlDau3_Click(object sender, EventArgs e) => TirarDau(3);
        private void pnlDau4_Click(object sender, EventArgs e) => TirarDau(4);

        private void TirarDau(int jugador)
        {
            if (animant) return; 
            if (!faseDesempat && resultats.ContainsKey(jugador)) return; 
            if (faseDesempat && !empatats.Contains(jugador)) return;

            animant = true;

            int tirada = rnd.Next(MIN_TIRADA, MAX_TIRADA);

            switch (jugador)
            {
                case 1:
                    contador1 = 0;
                    tirada1 = tirada;
                    tm1.Start();
                    break;
                case 2:
                    contador2 = 0;
                    tirada2 = tirada;
                    tm2.Start();
                    break;
                case 3:
                    contador3 = 0;
                    tirada3 = tirada;
                    tm3.Start();
                    break;
                case 4:
                    contador4 = 0;
                    tirada4 = tirada;
                    tm4.Start();
                    break;
            }
        }



        private void tm1_Tick(object sender, EventArgs e)
        {
            valor1 = rnd.Next(1, 7);
            PintarDau(1, valor1);
            contador1++;

            if (contador1 >= tirada1)
            {
                tm1.Stop();
                resultats[1] = valor1;
                animant = false;
                ComprovarSiAcaben();
            }
        }

        private void tm2_Tick(object sender, EventArgs e)
        {
            valor2 = rnd.Next(1, 7);
            PintarDau(2, valor2);
            contador2++;

            if (contador2 >= tirada2)
            {
                tm2.Stop();
                resultats[2] = valor2;
                animant = false;
                ComprovarSiAcaben();
            }
        }

        private void tm3_Tick(object sender, EventArgs e)
        {
            valor3 = rnd.Next(1, 7);
            PintarDau(3, valor3);
            contador3++;

            if (contador3 >= tirada3)
            {
                tm3.Stop();
                resultats[3] = valor3;
                animant = false;
                ComprovarSiAcaben();
            }
        }

        private void tm4_Tick(object sender, EventArgs e)
        {
            valor4 = rnd.Next(1, 7);
            PintarDau(4, valor4);
            contador4++;

            if (contador4 >= tirada4)
            {
                tm4.Stop();
                resultats[4] = valor4;
                animant = false;
                ComprovarSiAcaben();
            }
        }

        private void ComprovarSiAcaben()
        {
            if (!faseDesempat && resultats.Count < qttJugadors) return;
            if (faseDesempat && resultats.Count < empatats.Count) return;

            int max = resultats.Values.Max();
            var nousEmpatats = resultats.Where(x => x.Value == max).Select(x => x.Key).ToList();

            if (nousEmpatats.Count > 1)
            {
                faseDesempat = true;
                empatats = nousEmpatats;

                foreach (int j in empatats)
                    resultats.Remove(j);

                lbLlancar.Text = "🎲 EMPAT entre: " + string.Join(", ", empatats.Select(x => AgafarNomJugador(x))) + ". Torneu a tirar!";
                MessageBox.Show("EMPAT! Torneu a tirar només els empatats!", "Empat detectat", MessageBoxButtons.OK, MessageBoxIcon.Information);

                pnlDau1.Enabled = empatats.Contains(1);
                pnlDau2.Enabled = empatats.Contains(2);
                pnlDau3.Enabled = empatats.Contains(3);
                pnlDau4.Enabled = empatats.Contains(4);

                return;
            }

            faseDesempat = false;

            int guanyador = nousEmpatats[0];
            if (!resultats.ContainsKey(guanyador))
                resultats[guanyador] = max;

            ordreJugadors = resultats
                .OrderByDescending(x => x.Value)
                .Select(x => x.Key)
                .ToList();

            MostrarOrdenFinal();

            pnlDau1.Enabled = pnlDau2.Enabled = pnlDau3.Enabled = pnlDau4.Enabled = false;

            jugadors = new List<ClJugador>();
            daus.Clear();

            foreach (int id in ordreJugadors)
            {
                switch (id)
                {
                    case 1: jugadors.Add(jugador1); daus.Add(dau1); break;
                    case 2: jugadors.Add(jugador2); daus.Add(dau2); break;
                    case 3: jugadors.Add(jugador3); daus.Add(dau3); break;
                    case 4: jugadors.Add(jugador4); daus.Add(dau4); break;
                }
            }

            _ = IniciarJocAmbRetard();
        }

        private async System.Threading.Tasks.Task IniciarJocAmbRetard()
        {
            await System.Threading.Tasks.Task.Delay(1000);
            iniciarJoc();
        }



        private void iniciarJoc()
        {
            posicions.Clear();
            foreach (var j in jugadors)
                foreach (var f in j.Fitxes)
                    posicions[f] = -1;

            jugadorActual = 0;
            jocActiu = true;

            tmrTorn.Interval = 1500; 
            tmrTorn.Tick -= TmrTorn_Tick;
            tmrTorn.Tick += TmrTorn_Tick;
            tmrTorn.Start();

            lbLlancar.Text = $"Comença {jugadors[jugadorActual].nick}";
        }


        private async void TmrTorn_Tick(object sender, EventArgs e)
        {
            if (!jocActiu) return;

            tmrTorn.Stop();

            ClJugador jugador = jugadors[jugadorActual];
            int id = jugador.id;

            int valor = rnd.Next(1, 7);
            PintarDau(id, valor);

            lbLlancar.Text = $"{jugador.nick} ha tret un {valor}";
            await System.Threading.Tasks.Task.Delay(500);

            bool haMogut = MoureFitxa(jugador, valor);

            if (jugador.Fitxes.All(f => f.ALaMeta))
            {
                FinalJoc(jugador);
                return;
            }

            jugadorActual++;
            if (jugadorActual >= jugadors.Count)
                jugadorActual = 0;

            lbLlancar.Text = $"Torn de {jugadors[jugadorActual].nick}";
            if (jocActiu) tmrTorn.Start();
        }


        private bool MoureFitxa(ClJugador jugador, int tirada)
        {
            ClFitxa fitxa = jugador.Fitxes.FirstOrDefault(f => !f.ALaMeta);
            if (fitxa == null) return false;

            int posActual = posicions[fitxa];
            int novaPos = posActual + tirada;

            if (novaPos >= CASSELLES_TOTALS)
            {
                fitxa.ALaMeta = true;
                fitxa.MoureALaMeta();
                posicions[fitxa] = -1;

                int sobres = novaPos - (CASSELLES_TOTALS - 1);

                if (sobres > 0)
                {
                    ClFitxa novaFitxa = jugador.Fitxes.FirstOrDefault(f => !f.ALaMeta);
                    if (novaFitxa != null)
                    {
                        posActual = posicions[novaFitxa];
                        novaPos = posActual + sobres;

                        if (novaPos < CASSELLES_TOTALS)
                        {
                            if (CasellaOcupada(novaPos))
                            {
                                lbLlancar.Text = $"{jugador.nick} no pot moure, casella ocupada!";
                                return false;
                            }
                            posicions[novaFitxa] = novaPos;
                            novaFitxa.MoureA(novaPos, tauler);
                        }
                        else
                        {
                            novaFitxa.ALaMeta = true;
                            novaFitxa.MoureALaMeta();
                            posicions[novaFitxa] = -1;
                        }
                    }
                }
                return true;
            }

            if (CasellaOcupada(novaPos))
            {
                lbLlancar.Text = $"{jugador.nick} no pot moure, casella ocupada!";
                return false;
            }

            posicions[fitxa] = novaPos;
            fitxa.MoureA(novaPos, tauler);
            return true;
        }



        private void MostrarOrdenFinal()
        {
            string text = "ORDRE DE TORN:\n\n";
            int pos = 1;
            foreach (int j in ordreJugadors)
            {
                text += $"{pos}. {AgafarNomJugador(j)} (ha tret un {resultats[j]})\n";
                pos++;
            }

            MessageBox.Show(text, "Assignació del torn");

            lbLlancar.Text = "Comença " + AgafarNomJugador(ordreJugadors[0]) + "!";
            pnlTauler.Visible = true;
            tauler.Refrescar();

            resultats.Clear();
            empatats.Clear();
            faseDesempat = false;
        }

        private string AgafarNomJugador(int num)
        {
            if (num == 1 && jugador1 != null) return jugador1.nick;
            if (num == 2 && jugador2 != null) return jugador2.nick;
            if (num == 3 && jugador3 != null) return jugador3.nick;
            if (num == 4 && jugador4 != null) return jugador4.nick;
            return "Jugador " + num;
        }

        private void PintarDau(int j, int valor)
        {
            switch (j)
            {
                case 1: num1 = valor; pnlDau1.Invalidate(); break;
                case 2: num2 = valor; pnlDau2.Invalidate(); break;
                case 3: num3 = valor; pnlDau3.Invalidate(); break;
                case 4: num4 = valor; pnlDau4.Invalidate(); break;
            }
        }

        private bool CasellaOcupada(int pos)
        {
            foreach (int v in posicions.Values)
                if (v == pos && v >= 0) return true;
            return false;
        }

        private async void FinalJoc(ClJugador guanyador)
        {
            jocActiu = false;
            tmrTorn.Stop();

            pnlTauler.BackColor = guanyador.color;
            lbLlancar.Text = $"🏆 {guanyador.nick} ha guanyat la partida!";
            pnlTauler.Refresh();

            await System.Threading.Tasks.Task.Delay(800);

            try
            {
                WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
                player.URL = Path.Combine(Application.StartupPath, "Resources", "goodresult-82807.mp3");
                player.controls.play();
            }
            catch
            {
                MessageBox.Show($"{guanyador.nick} ha guanyat!", "Fi del joc", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            MessageBox.Show($"Enhorabona {guanyador.nick}!", "Guanyador 🏆", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        private void pnlDau1_Paint(object sender, PaintEventArgs e) => dau1.pintar(e, num1);
        private void pnlDau2_Paint(object sender, PaintEventArgs e) => dau2.pintar(e, num2);
        private void pnlDau3_Paint(object sender, PaintEventArgs e) { if (qttJugadors >= 3) dau3.pintar(e, num3); }
        private void pnlDau4_Paint(object sender, PaintEventArgs e) { if (qttJugadors == 4) dau4.pintar(e, num4); }

    }
}
