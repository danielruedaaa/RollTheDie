namespace JocAmbDaus
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbQttJugadors = new System.Windows.Forms.GroupBox();
            this.btAcceptar = new System.Windows.Forms.Button();
            this.nudQttJugadors = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.gbInfoJugadors = new System.Windows.Forms.GroupBox();
            this.lbConfirmatJug4 = new System.Windows.Forms.Label();
            this.lbConfirmatJug3 = new System.Windows.Forms.Label();
            this.lbConfirmatJug2 = new System.Windows.Forms.Label();
            this.lbConfirmatJug1 = new System.Windows.Forms.Label();
            this.btAcceptar2 = new System.Windows.Forms.Button();
            this.btAcceptar3 = new System.Windows.Forms.Button();
            this.btAcceptar4 = new System.Windows.Forms.Button();
            this.btAcceptar1 = new System.Windows.Forms.Button();
            this.lbJug4 = new System.Windows.Forms.Label();
            this.cbColorJug4 = new System.Windows.Forms.ComboBox();
            this.lbColor4 = new System.Windows.Forms.Label();
            this.tbNickJug4 = new System.Windows.Forms.TextBox();
            this.lbNick4 = new System.Windows.Forms.Label();
            this.lbJug3 = new System.Windows.Forms.Label();
            this.cbColorJug3 = new System.Windows.Forms.ComboBox();
            this.lbColor3 = new System.Windows.Forms.Label();
            this.tbNickJug3 = new System.Windows.Forms.TextBox();
            this.lbNick3 = new System.Windows.Forms.Label();
            this.lbJug2 = new System.Windows.Forms.Label();
            this.cbColorJug2 = new System.Windows.Forms.ComboBox();
            this.lbColor2 = new System.Windows.Forms.Label();
            this.tbNickJug2 = new System.Windows.Forms.TextBox();
            this.lbNick2 = new System.Windows.Forms.Label();
            this.lbJug1 = new System.Windows.Forms.Label();
            this.cbColorJug1 = new System.Windows.Forms.ComboBox();
            this.lbColor1 = new System.Windows.Forms.Label();
            this.tbNickJug1 = new System.Windows.Forms.TextBox();
            this.lbNick1 = new System.Windows.Forms.Label();
            this.gbDaus = new System.Windows.Forms.GroupBox();
            this.lbLlancar = new System.Windows.Forms.Label();
            this.pnlDau4 = new System.Windows.Forms.Panel();
            this.pnlDau3 = new System.Windows.Forms.Panel();
            this.pnlDau2 = new System.Windows.Forms.Panel();
            this.pnlDau1 = new System.Windows.Forms.Panel();
            this.lbNicknameJug4 = new System.Windows.Forms.Label();
            this.lbNicknameJug3 = new System.Windows.Forms.Label();
            this.lbNicknameJug2 = new System.Windows.Forms.Label();
            this.lbNicknameJug1 = new System.Windows.Forms.Label();
            this.pnlTauler = new System.Windows.Forms.Panel();
            this.gbQttJugadors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQttJugadors)).BeginInit();
            this.gbInfoJugadors.SuspendLayout();
            this.gbDaus.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbQttJugadors
            // 
            this.gbQttJugadors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbQttJugadors.Controls.Add(this.btAcceptar);
            this.gbQttJugadors.Controls.Add(this.nudQttJugadors);
            this.gbQttJugadors.Controls.Add(this.label1);
            this.gbQttJugadors.Location = new System.Drawing.Point(134, 60);
            this.gbQttJugadors.Margin = new System.Windows.Forms.Padding(2);
            this.gbQttJugadors.Name = "gbQttJugadors";
            this.gbQttJugadors.Padding = new System.Windows.Forms.Padding(2);
            this.gbQttJugadors.Size = new System.Drawing.Size(1126, 742);
            this.gbQttJugadors.TabIndex = 0;
            this.gbQttJugadors.TabStop = false;
            this.gbQttJugadors.Text = "groupBox1";
            // 
            // btAcceptar
            // 
            this.btAcceptar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btAcceptar.BackColor = System.Drawing.Color.Lime;
            this.btAcceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAcceptar.Location = new System.Drawing.Point(533, 128);
            this.btAcceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btAcceptar.Name = "btAcceptar";
            this.btAcceptar.Size = new System.Drawing.Size(65, 26);
            this.btAcceptar.TabIndex = 2;
            this.btAcceptar.Text = "Acceptar";
            this.btAcceptar.UseVisualStyleBackColor = false;
            this.btAcceptar.Click += new System.EventHandler(this.btAcceptar_Click);
            // 
            // nudQttJugadors
            // 
            this.nudQttJugadors.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudQttJugadors.Location = new System.Drawing.Point(523, 85);
            this.nudQttJugadors.Margin = new System.Windows.Forms.Padding(2);
            this.nudQttJugadors.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudQttJugadors.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudQttJugadors.Name = "nudQttJugadors";
            this.nudQttJugadors.Size = new System.Drawing.Size(90, 20);
            this.nudQttJugadors.TabIndex = 1;
            this.nudQttJugadors.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Location = new System.Drawing.Point(514, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quants jugadors sou?";
            // 
            // gbInfoJugadors
            // 
            this.gbInfoJugadors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInfoJugadors.Controls.Add(this.lbConfirmatJug4);
            this.gbInfoJugadors.Controls.Add(this.lbConfirmatJug3);
            this.gbInfoJugadors.Controls.Add(this.lbConfirmatJug2);
            this.gbInfoJugadors.Controls.Add(this.lbConfirmatJug1);
            this.gbInfoJugadors.Controls.Add(this.btAcceptar2);
            this.gbInfoJugadors.Controls.Add(this.btAcceptar3);
            this.gbInfoJugadors.Controls.Add(this.btAcceptar4);
            this.gbInfoJugadors.Controls.Add(this.btAcceptar1);
            this.gbInfoJugadors.Controls.Add(this.lbJug4);
            this.gbInfoJugadors.Controls.Add(this.cbColorJug4);
            this.gbInfoJugadors.Controls.Add(this.lbColor4);
            this.gbInfoJugadors.Controls.Add(this.tbNickJug4);
            this.gbInfoJugadors.Controls.Add(this.lbNick4);
            this.gbInfoJugadors.Controls.Add(this.lbJug3);
            this.gbInfoJugadors.Controls.Add(this.cbColorJug3);
            this.gbInfoJugadors.Controls.Add(this.lbColor3);
            this.gbInfoJugadors.Controls.Add(this.tbNickJug3);
            this.gbInfoJugadors.Controls.Add(this.lbNick3);
            this.gbInfoJugadors.Controls.Add(this.lbJug2);
            this.gbInfoJugadors.Controls.Add(this.cbColorJug2);
            this.gbInfoJugadors.Controls.Add(this.lbColor2);
            this.gbInfoJugadors.Controls.Add(this.tbNickJug2);
            this.gbInfoJugadors.Controls.Add(this.lbNick2);
            this.gbInfoJugadors.Controls.Add(this.lbJug1);
            this.gbInfoJugadors.Controls.Add(this.cbColorJug1);
            this.gbInfoJugadors.Controls.Add(this.lbColor1);
            this.gbInfoJugadors.Controls.Add(this.tbNickJug1);
            this.gbInfoJugadors.Controls.Add(this.lbNick1);
            this.gbInfoJugadors.Location = new System.Drawing.Point(134, 60);
            this.gbInfoJugadors.Margin = new System.Windows.Forms.Padding(2);
            this.gbInfoJugadors.Name = "gbInfoJugadors";
            this.gbInfoJugadors.Padding = new System.Windows.Forms.Padding(2);
            this.gbInfoJugadors.Size = new System.Drawing.Size(1126, 766);
            this.gbInfoJugadors.TabIndex = 3;
            this.gbInfoJugadors.TabStop = false;
            this.gbInfoJugadors.Visible = false;
            // 
            // lbConfirmatJug4
            // 
            this.lbConfirmatJug4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbConfirmatJug4.AutoSize = true;
            this.lbConfirmatJug4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmatJug4.Location = new System.Drawing.Point(986, 738);
            this.lbConfirmatJug4.Name = "lbConfirmatJug4";
            this.lbConfirmatJug4.Size = new System.Drawing.Size(122, 20);
            this.lbConfirmatJug4.TabIndex = 27;
            this.lbConfirmatJug4.Text = "CONFIRMAT!";
            this.lbConfirmatJug4.Visible = false;
            // 
            // lbConfirmatJug3
            // 
            this.lbConfirmatJug3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbConfirmatJug3.AutoSize = true;
            this.lbConfirmatJug3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmatJug3.Location = new System.Drawing.Point(24, 738);
            this.lbConfirmatJug3.Name = "lbConfirmatJug3";
            this.lbConfirmatJug3.Size = new System.Drawing.Size(122, 20);
            this.lbConfirmatJug3.TabIndex = 26;
            this.lbConfirmatJug3.Text = "CONFIRMAT!";
            this.lbConfirmatJug3.Visible = false;
            // 
            // lbConfirmatJug2
            // 
            this.lbConfirmatJug2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbConfirmatJug2.AutoSize = true;
            this.lbConfirmatJug2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmatJug2.Location = new System.Drawing.Point(986, 110);
            this.lbConfirmatJug2.Name = "lbConfirmatJug2";
            this.lbConfirmatJug2.Size = new System.Drawing.Size(122, 20);
            this.lbConfirmatJug2.TabIndex = 25;
            this.lbConfirmatJug2.Text = "CONFIRMAT!";
            this.lbConfirmatJug2.Visible = false;
            // 
            // lbConfirmatJug1
            // 
            this.lbConfirmatJug1.AutoSize = true;
            this.lbConfirmatJug1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmatJug1.Location = new System.Drawing.Point(24, 110);
            this.lbConfirmatJug1.Name = "lbConfirmatJug1";
            this.lbConfirmatJug1.Size = new System.Drawing.Size(122, 20);
            this.lbConfirmatJug1.TabIndex = 24;
            this.lbConfirmatJug1.Text = "CONFIRMAT!";
            this.lbConfirmatJug1.Visible = false;
            // 
            // btAcceptar2
            // 
            this.btAcceptar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAcceptar2.BackColor = System.Drawing.Color.Lime;
            this.btAcceptar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAcceptar2.Location = new System.Drawing.Point(1011, 110);
            this.btAcceptar2.Name = "btAcceptar2";
            this.btAcceptar2.Size = new System.Drawing.Size(75, 23);
            this.btAcceptar2.TabIndex = 21;
            this.btAcceptar2.Text = "Acceptar";
            this.btAcceptar2.UseVisualStyleBackColor = false;
            this.btAcceptar2.Click += new System.EventHandler(this.btAcceptar2_Click);
            // 
            // btAcceptar3
            // 
            this.btAcceptar3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAcceptar3.BackColor = System.Drawing.Color.Lime;
            this.btAcceptar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAcceptar3.Location = new System.Drawing.Point(45, 738);
            this.btAcceptar3.Name = "btAcceptar3";
            this.btAcceptar3.Size = new System.Drawing.Size(75, 23);
            this.btAcceptar3.TabIndex = 22;
            this.btAcceptar3.Text = "Acceptar";
            this.btAcceptar3.UseVisualStyleBackColor = false;
            this.btAcceptar3.Visible = false;
            this.btAcceptar3.Click += new System.EventHandler(this.btAcceptar3_Click);
            // 
            // btAcceptar4
            // 
            this.btAcceptar4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAcceptar4.BackColor = System.Drawing.Color.Lime;
            this.btAcceptar4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAcceptar4.Location = new System.Drawing.Point(1011, 738);
            this.btAcceptar4.Name = "btAcceptar4";
            this.btAcceptar4.Size = new System.Drawing.Size(75, 23);
            this.btAcceptar4.TabIndex = 23;
            this.btAcceptar4.Text = "Acceptar";
            this.btAcceptar4.UseVisualStyleBackColor = false;
            this.btAcceptar4.Visible = false;
            this.btAcceptar4.Click += new System.EventHandler(this.btAcceptar4_Click);
            // 
            // btAcceptar1
            // 
            this.btAcceptar1.BackColor = System.Drawing.Color.Lime;
            this.btAcceptar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAcceptar1.Location = new System.Drawing.Point(45, 110);
            this.btAcceptar1.Name = "btAcceptar1";
            this.btAcceptar1.Size = new System.Drawing.Size(75, 23);
            this.btAcceptar1.TabIndex = 20;
            this.btAcceptar1.Text = "Acceptar";
            this.btAcceptar1.UseVisualStyleBackColor = false;
            this.btAcceptar1.Click += new System.EventHandler(this.btAcceptarJug1_Click);
            // 
            // lbJug4
            // 
            this.lbJug4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbJug4.AutoSize = true;
            this.lbJug4.Location = new System.Drawing.Point(1019, 651);
            this.lbJug4.Name = "lbJug4";
            this.lbJug4.Size = new System.Drawing.Size(54, 13);
            this.lbJug4.TabIndex = 19;
            this.lbJug4.Text = "Jugador 4";
            this.lbJug4.Visible = false;
            // 
            // cbColorJug4
            // 
            this.cbColorJug4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbColorJug4.FormattingEnabled = true;
            this.cbColorJug4.Location = new System.Drawing.Point(1042, 708);
            this.cbColorJug4.Margin = new System.Windows.Forms.Padding(2);
            this.cbColorJug4.Name = "cbColorJug4";
            this.cbColorJug4.Size = new System.Drawing.Size(77, 21);
            this.cbColorJug4.TabIndex = 18;
            this.cbColorJug4.Visible = false;
            // 
            // lbColor4
            // 
            this.lbColor4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbColor4.Location = new System.Drawing.Point(987, 711);
            this.lbColor4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbColor4.Name = "lbColor4";
            this.lbColor4.Size = new System.Drawing.Size(51, 19);
            this.lbColor4.TabIndex = 17;
            this.lbColor4.Text = "Color:";
            this.lbColor4.Visible = false;
            // 
            // tbNickJug4
            // 
            this.tbNickJug4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNickJug4.Location = new System.Drawing.Point(1043, 682);
            this.tbNickJug4.Margin = new System.Windows.Forms.Padding(2);
            this.tbNickJug4.Name = "tbNickJug4";
            this.tbNickJug4.Size = new System.Drawing.Size(76, 20);
            this.tbNickJug4.TabIndex = 16;
            this.tbNickJug4.Visible = false;
            // 
            // lbNick4
            // 
            this.lbNick4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNick4.Location = new System.Drawing.Point(963, 683);
            this.lbNick4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNick4.Name = "lbNick4";
            this.lbNick4.Size = new System.Drawing.Size(76, 19);
            this.lbNick4.TabIndex = 15;
            this.lbNick4.Text = "Nickname:";
            this.lbNick4.Visible = false;
            // 
            // lbJug3
            // 
            this.lbJug3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbJug3.AutoSize = true;
            this.lbJug3.Location = new System.Drawing.Point(57, 651);
            this.lbJug3.Name = "lbJug3";
            this.lbJug3.Size = new System.Drawing.Size(54, 13);
            this.lbJug3.TabIndex = 14;
            this.lbJug3.Text = "Jugador 3";
            this.lbJug3.Visible = false;
            // 
            // cbColorJug3
            // 
            this.cbColorJug3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbColorJug3.FormattingEnabled = true;
            this.cbColorJug3.Location = new System.Drawing.Point(80, 708);
            this.cbColorJug3.Margin = new System.Windows.Forms.Padding(2);
            this.cbColorJug3.Name = "cbColorJug3";
            this.cbColorJug3.Size = new System.Drawing.Size(77, 21);
            this.cbColorJug3.TabIndex = 13;
            this.cbColorJug3.Visible = false;
            // 
            // lbColor3
            // 
            this.lbColor3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbColor3.Location = new System.Drawing.Point(25, 711);
            this.lbColor3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbColor3.Name = "lbColor3";
            this.lbColor3.Size = new System.Drawing.Size(51, 19);
            this.lbColor3.TabIndex = 12;
            this.lbColor3.Text = "Color:";
            this.lbColor3.Visible = false;
            // 
            // tbNickJug3
            // 
            this.tbNickJug3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbNickJug3.Location = new System.Drawing.Point(81, 682);
            this.tbNickJug3.Margin = new System.Windows.Forms.Padding(2);
            this.tbNickJug3.Name = "tbNickJug3";
            this.tbNickJug3.Size = new System.Drawing.Size(76, 20);
            this.tbNickJug3.TabIndex = 11;
            this.tbNickJug3.Visible = false;
            // 
            // lbNick3
            // 
            this.lbNick3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbNick3.Location = new System.Drawing.Point(4, 682);
            this.lbNick3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNick3.Name = "lbNick3";
            this.lbNick3.Size = new System.Drawing.Size(76, 19);
            this.lbNick3.TabIndex = 10;
            this.lbNick3.Text = "Nickname:";
            this.lbNick3.Visible = false;
            // 
            // lbJug2
            // 
            this.lbJug2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbJug2.AutoSize = true;
            this.lbJug2.Location = new System.Drawing.Point(1019, 15);
            this.lbJug2.Name = "lbJug2";
            this.lbJug2.Size = new System.Drawing.Size(54, 13);
            this.lbJug2.TabIndex = 9;
            this.lbJug2.Text = "Jugador 2";
            // 
            // cbColorJug2
            // 
            this.cbColorJug2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbColorJug2.FormattingEnabled = true;
            this.cbColorJug2.Location = new System.Drawing.Point(1042, 72);
            this.cbColorJug2.Margin = new System.Windows.Forms.Padding(2);
            this.cbColorJug2.Name = "cbColorJug2";
            this.cbColorJug2.Size = new System.Drawing.Size(77, 21);
            this.cbColorJug2.TabIndex = 8;
            // 
            // lbColor2
            // 
            this.lbColor2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbColor2.Location = new System.Drawing.Point(987, 75);
            this.lbColor2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbColor2.Name = "lbColor2";
            this.lbColor2.Size = new System.Drawing.Size(51, 19);
            this.lbColor2.TabIndex = 7;
            this.lbColor2.Text = "Color:";
            // 
            // tbNickJug2
            // 
            this.tbNickJug2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNickJug2.Location = new System.Drawing.Point(1043, 46);
            this.tbNickJug2.Margin = new System.Windows.Forms.Padding(2);
            this.tbNickJug2.Name = "tbNickJug2";
            this.tbNickJug2.Size = new System.Drawing.Size(76, 20);
            this.tbNickJug2.TabIndex = 6;
            // 
            // lbNick2
            // 
            this.lbNick2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNick2.Location = new System.Drawing.Point(987, 46);
            this.lbNick2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNick2.Name = "lbNick2";
            this.lbNick2.Size = new System.Drawing.Size(76, 19);
            this.lbNick2.TabIndex = 5;
            this.lbNick2.Text = "Nickname:";
            // 
            // lbJug1
            // 
            this.lbJug1.AutoSize = true;
            this.lbJug1.Location = new System.Drawing.Point(57, 15);
            this.lbJug1.Name = "lbJug1";
            this.lbJug1.Size = new System.Drawing.Size(54, 13);
            this.lbJug1.TabIndex = 4;
            this.lbJug1.Text = "Jugador 1";
            // 
            // cbColorJug1
            // 
            this.cbColorJug1.FormattingEnabled = true;
            this.cbColorJug1.Location = new System.Drawing.Point(80, 72);
            this.cbColorJug1.Margin = new System.Windows.Forms.Padding(2);
            this.cbColorJug1.Name = "cbColorJug1";
            this.cbColorJug1.Size = new System.Drawing.Size(77, 21);
            this.cbColorJug1.TabIndex = 3;
            // 
            // lbColor1
            // 
            this.lbColor1.Location = new System.Drawing.Point(25, 75);
            this.lbColor1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbColor1.Name = "lbColor1";
            this.lbColor1.Size = new System.Drawing.Size(51, 19);
            this.lbColor1.TabIndex = 2;
            this.lbColor1.Text = "Color:";
            // 
            // tbNickJug1
            // 
            this.tbNickJug1.Location = new System.Drawing.Point(81, 46);
            this.tbNickJug1.Margin = new System.Windows.Forms.Padding(2);
            this.tbNickJug1.Name = "tbNickJug1";
            this.tbNickJug1.Size = new System.Drawing.Size(76, 20);
            this.tbNickJug1.TabIndex = 1;
            // 
            // lbNick1
            // 
            this.lbNick1.Location = new System.Drawing.Point(25, 46);
            this.lbNick1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNick1.Name = "lbNick1";
            this.lbNick1.Size = new System.Drawing.Size(76, 19);
            this.lbNick1.TabIndex = 0;
            this.lbNick1.Text = "Nickname:";
            // 
            // gbDaus
            // 
            this.gbDaus.Controls.Add(this.lbLlancar);
            this.gbDaus.Controls.Add(this.pnlDau4);
            this.gbDaus.Controls.Add(this.pnlDau3);
            this.gbDaus.Controls.Add(this.pnlDau2);
            this.gbDaus.Controls.Add(this.pnlDau1);
            this.gbDaus.Controls.Add(this.lbNicknameJug4);
            this.gbDaus.Controls.Add(this.lbNicknameJug3);
            this.gbDaus.Controls.Add(this.lbNicknameJug2);
            this.gbDaus.Controls.Add(this.lbNicknameJug1);
            this.gbDaus.Location = new System.Drawing.Point(0, 12);
            this.gbDaus.Name = "gbDaus";
            this.gbDaus.Size = new System.Drawing.Size(495, 369);
            this.gbDaus.TabIndex = 5;
            this.gbDaus.TabStop = false;
            this.gbDaus.Text = "groupBox1";
            this.gbDaus.Visible = false;
            // 
            // lbLlancar
            // 
            this.lbLlancar.AutoSize = true;
            this.lbLlancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLlancar.Location = new System.Drawing.Point(65, 331);
            this.lbLlancar.Name = "lbLlancar";
            this.lbLlancar.Size = new System.Drawing.Size(374, 20);
            this.lbLlancar.TabIndex = 10;
            this.lbLlancar.Text = "TIREU ELS DAUS PER DECIDIR L\'ORDRE";
            // 
            // pnlDau4
            // 
            this.pnlDau4.BackColor = System.Drawing.SystemColors.Info;
            this.pnlDau4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDau4.Location = new System.Drawing.Point(91, 249);
            this.pnlDau4.Name = "pnlDau4";
            this.pnlDau4.Size = new System.Drawing.Size(60, 60);
            this.pnlDau4.TabIndex = 9;
            this.pnlDau4.Click += new System.EventHandler(this.pnlDau4_Click);
            this.pnlDau4.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDau4_Paint);
            // 
            // pnlDau3
            // 
            this.pnlDau3.BackColor = System.Drawing.SystemColors.Info;
            this.pnlDau3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDau3.Location = new System.Drawing.Point(91, 176);
            this.pnlDau3.Name = "pnlDau3";
            this.pnlDau3.Size = new System.Drawing.Size(60, 60);
            this.pnlDau3.TabIndex = 8;
            this.pnlDau3.Click += new System.EventHandler(this.pnlDau3_Click);
            this.pnlDau3.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDau3_Paint);
            // 
            // pnlDau2
            // 
            this.pnlDau2.BackColor = System.Drawing.SystemColors.Info;
            this.pnlDau2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDau2.Location = new System.Drawing.Point(91, 100);
            this.pnlDau2.Name = "pnlDau2";
            this.pnlDau2.Size = new System.Drawing.Size(60, 60);
            this.pnlDau2.TabIndex = 7;
            this.pnlDau2.Click += new System.EventHandler(this.pnlDau2_Click);
            this.pnlDau2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDau2_Paint);
            // 
            // pnlDau1
            // 
            this.pnlDau1.BackColor = System.Drawing.SystemColors.Info;
            this.pnlDau1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDau1.Location = new System.Drawing.Point(91, 19);
            this.pnlDau1.Name = "pnlDau1";
            this.pnlDau1.Size = new System.Drawing.Size(60, 60);
            this.pnlDau1.TabIndex = 6;
            this.pnlDau1.Click += new System.EventHandler(this.pnlDau1_Click);
            this.pnlDau1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDau1_Paint);
            // 
            // lbNicknameJug4
            // 
            this.lbNicknameJug4.AutoSize = true;
            this.lbNicknameJug4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNicknameJug4.Location = new System.Drawing.Point(19, 249);
            this.lbNicknameJug4.Name = "lbNicknameJug4";
            this.lbNicknameJug4.Size = new System.Drawing.Size(41, 13);
            this.lbNicknameJug4.TabIndex = 3;
            this.lbNicknameJug4.Text = "label4";
            // 
            // lbNicknameJug3
            // 
            this.lbNicknameJug3.AutoSize = true;
            this.lbNicknameJug3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNicknameJug3.Location = new System.Drawing.Point(19, 176);
            this.lbNicknameJug3.Name = "lbNicknameJug3";
            this.lbNicknameJug3.Size = new System.Drawing.Size(41, 13);
            this.lbNicknameJug3.TabIndex = 2;
            this.lbNicknameJug3.Text = "label3";
            // 
            // lbNicknameJug2
            // 
            this.lbNicknameJug2.AutoSize = true;
            this.lbNicknameJug2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNicknameJug2.Location = new System.Drawing.Point(19, 100);
            this.lbNicknameJug2.Name = "lbNicknameJug2";
            this.lbNicknameJug2.Size = new System.Drawing.Size(41, 13);
            this.lbNicknameJug2.TabIndex = 1;
            this.lbNicknameJug2.Text = "label2";
            // 
            // lbNicknameJug1
            // 
            this.lbNicknameJug1.AutoSize = true;
            this.lbNicknameJug1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNicknameJug1.Location = new System.Drawing.Point(19, 30);
            this.lbNicknameJug1.Name = "lbNicknameJug1";
            this.lbNicknameJug1.Size = new System.Drawing.Size(41, 13);
            this.lbNicknameJug1.TabIndex = 0;
            this.lbNicknameJug1.Text = "label2";
            // 
            // pnlTauler
            // 
            this.pnlTauler.Location = new System.Drawing.Point(514, 31);
            this.pnlTauler.Name = "pnlTauler";
            this.pnlTauler.Size = new System.Drawing.Size(780, 633);
            this.pnlTauler.TabIndex = 6;
            this.pnlTauler.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 872);
            this.ControlBox = false;
            this.Controls.Add(this.pnlTauler);
            this.Controls.Add(this.gbDaus);
            this.Controls.Add(this.gbInfoJugadors);
            this.Controls.Add(this.gbQttJugadors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.gbQttJugadors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudQttJugadors)).EndInit();
            this.gbInfoJugadors.ResumeLayout(false);
            this.gbInfoJugadors.PerformLayout();
            this.gbDaus.ResumeLayout(false);
            this.gbDaus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbQttJugadors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudQttJugadors;
        private System.Windows.Forms.Button btAcceptar;
        private System.Windows.Forms.GroupBox gbInfoJugadors;
        private System.Windows.Forms.Label lbNick1;
        private System.Windows.Forms.TextBox tbNickJug1;
        private System.Windows.Forms.ComboBox cbColorJug1;
        private System.Windows.Forms.Label lbColor1;
        private System.Windows.Forms.Label lbJug2;
        private System.Windows.Forms.ComboBox cbColorJug2;
        private System.Windows.Forms.Label lbColor2;
        private System.Windows.Forms.TextBox tbNickJug2;
        private System.Windows.Forms.Label lbNick2;
        private System.Windows.Forms.Label lbJug1;
        private System.Windows.Forms.Label lbJug4;
        private System.Windows.Forms.ComboBox cbColorJug4;
        private System.Windows.Forms.Label lbColor4;
        private System.Windows.Forms.TextBox tbNickJug4;
        private System.Windows.Forms.Label lbNick4;
        private System.Windows.Forms.Label lbJug3;
        private System.Windows.Forms.ComboBox cbColorJug3;
        private System.Windows.Forms.Label lbColor3;
        private System.Windows.Forms.TextBox tbNickJug3;
        private System.Windows.Forms.Label lbNick3;
        private System.Windows.Forms.Button btAcceptar1;
        private System.Windows.Forms.Button btAcceptar2;
        private System.Windows.Forms.Button btAcceptar3;
        private System.Windows.Forms.Button btAcceptar4;
        private System.Windows.Forms.Label lbConfirmatJug1;
        private System.Windows.Forms.Label lbConfirmatJug4;
        private System.Windows.Forms.Label lbConfirmatJug3;
        private System.Windows.Forms.Label lbConfirmatJug2;
        private System.Windows.Forms.GroupBox gbDaus;
        private System.Windows.Forms.Label lbNicknameJug2;
        private System.Windows.Forms.Label lbNicknameJug1;
        private System.Windows.Forms.Label lbNicknameJug4;
        private System.Windows.Forms.Label lbNicknameJug3;
        public System.Windows.Forms.Panel pnlDau3;
        public System.Windows.Forms.Panel pnlDau2;
        public System.Windows.Forms.Panel pnlDau1;
        public System.Windows.Forms.Panel pnlDau4;
        private System.Windows.Forms.Label lbLlancar;
        private System.Windows.Forms.Panel pnlTauler;
    }
}

