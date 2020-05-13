namespace Program
{
    partial class LaporanNeraca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CBHartaNS = new System.Windows.Forms.ComboBox();
            this.NeracaSaldo = new System.Windows.Forms.Label();
            this.IsiHartaNS = new System.Windows.Forms.TextBox();
            this.HartaNS = new System.Windows.Forms.Label();
            this.UtangNS = new System.Windows.Forms.Label();
            this.PendapatanNS = new System.Windows.Forms.Label();
            this.Judul = new System.Windows.Forms.Label();
            this.CBUtangModalNS = new System.Windows.Forms.ComboBox();
            this.CBPendapatanBebanNS = new System.Windows.Forms.ComboBox();
            this.IsiUtangModalNS = new System.Windows.Forms.TextBox();
            this.IsiPendapatanBebanNS = new System.Windows.Forms.TextBox();
            this.BHartaNS = new System.Windows.Forms.Button();
            this.BUtangModalNS = new System.Windows.Forms.Button();
            this.BPendapatanBebanNS = new System.Windows.Forms.Button();
            this.IsiHartaJP = new System.Windows.Forms.TextBox();
            this.IsiUtangModalJP = new System.Windows.Forms.TextBox();
            this.CheckNS = new System.Windows.Forms.Button();
            this.JurnalPenyesuaian = new System.Windows.Forms.Label();
            this.CheckJP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBHartaJP = new System.Windows.Forms.ComboBox();
            this.CBUtangModalJP = new System.Windows.Forms.ComboBox();
            this.CBPendapatanBebanJP = new System.Windows.Forms.ComboBox();
            this.BDHarta = new System.Windows.Forms.Button();
            this.IsiPendapatanBebanJP = new System.Windows.Forms.TextBox();
            this.BDUtangModal = new System.Windows.Forms.Button();
            this.BDPendapatanBeban = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ResetNS = new System.Windows.Forms.Button();
            this.BKHarta = new System.Windows.Forms.Button();
            this.BKUtangModal = new System.Windows.Forms.Button();
            this.BKPendapatanBeban = new System.Windows.Forms.Button();
            this.Hasil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CBHartaNS
            // 
            this.CBHartaNS.FormattingEnabled = true;
            this.CBHartaNS.Items.AddRange(new object[] {
            "111  Kas",
            "112  Piutang usaha",
            "113  Perlengkapan",
            "114  Surat berharga",
            "115  Iklan dibayar dimuka",
            "116  Sewa dibayar dimuka",
            "122  Peralatan",
            "124  Gedung",
            "131  Investasi dalam saham",
            "132  Investasi dalam obligasi",
            "141  Goodwill",
            "142  Hak paten",
            "198  Penyusutan harta",
            "199  Harta lain-lain"});
            this.CBHartaNS.Location = new System.Drawing.Point(255, 150);
            this.CBHartaNS.Name = "CBHartaNS";
            this.CBHartaNS.Size = new System.Drawing.Size(272, 28);
            this.CBHartaNS.TabIndex = 0;
            this.CBHartaNS.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NeracaSaldo
            // 
            this.NeracaSaldo.AutoSize = true;
            this.NeracaSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NeracaSaldo.Location = new System.Drawing.Point(60, 90);
            this.NeracaSaldo.Name = "NeracaSaldo";
            this.NeracaSaldo.Size = new System.Drawing.Size(131, 25);
            this.NeracaSaldo.TabIndex = 1;
            this.NeracaSaldo.Text = "Neraca Saldo";
            this.NeracaSaldo.Click += new System.EventHandler(this.NeracaSaldo_Click);
            // 
            // IsiHartaNS
            // 
            this.IsiHartaNS.AutoCompleteCustomSource.AddRange(new string[] {
            "111  Kas",
            "112  Piutang usaha",
            "113  Perlengkapan",
            "114  Surat berharga",
            "115  Iklan dibayar dimuka",
            "116  Sewa dibayar dimuka",
            "122  Peralatan",
            "124  Gedung",
            "131  Investasi dalam saham",
            "132  Investasi dalam obligasi",
            "141  Goodwill",
            "142  Hak paten",
            "199  Harta lain-lain"});
            this.IsiHartaNS.Location = new System.Drawing.Point(555, 150);
            this.IsiHartaNS.Name = "IsiHartaNS";
            this.IsiHartaNS.Size = new System.Drawing.Size(120, 26);
            this.IsiHartaNS.TabIndex = 2;
            this.IsiHartaNS.TextChanged += new System.EventHandler(this.IsiNS_TextChanged);
            this.IsiHartaNS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsiHartaNS_KeyPress);
            // 
            // HartaNS
            // 
            this.HartaNS.AutoSize = true;
            this.HartaNS.Location = new System.Drawing.Point(60, 155);
            this.HartaNS.Name = "HartaNS";
            this.HartaNS.Size = new System.Drawing.Size(49, 20);
            this.HartaNS.TabIndex = 3;
            this.HartaNS.Text = "Harta";
            // 
            // UtangNS
            // 
            this.UtangNS.AutoSize = true;
            this.UtangNS.Location = new System.Drawing.Point(60, 190);
            this.UtangNS.Name = "UtangNS";
            this.UtangNS.Size = new System.Drawing.Size(131, 20);
            this.UtangNS.TabIndex = 4;
            this.UtangNS.Text = "Utang dan Modal";
            this.UtangNS.Click += new System.EventHandler(this.UtangNS_Click);
            // 
            // PendapatanNS
            // 
            this.PendapatanNS.AutoSize = true;
            this.PendapatanNS.Location = new System.Drawing.Point(60, 225);
            this.PendapatanNS.Name = "PendapatanNS";
            this.PendapatanNS.Size = new System.Drawing.Size(178, 20);
            this.PendapatanNS.TabIndex = 6;
            this.PendapatanNS.Text = "Pendapatan dan Beban";
            // 
            // Judul
            // 
            this.Judul.AutoSize = true;
            this.Judul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Judul.Location = new System.Drawing.Point(729, 9);
            this.Judul.Name = "Judul";
            this.Judul.Size = new System.Drawing.Size(461, 37);
            this.Judul.TabIndex = 7;
            this.Judul.Text = "Neraca Lajur Perusahaan Jasa";
            // 
            // CBUtangModalNS
            // 
            this.CBUtangModalNS.FormattingEnabled = true;
            this.CBUtangModalNS.Items.AddRange(new object[] {
            "211  Utang usaha",
            "215  Asuransi diterima dimuka",
            "216  Sewa diterima dimuka",
            "219  Utang jangka pendek lain-lain",
            "221  Utang obligasi",
            "222  Utang hipotik",
            "311  Modal pemilik",
            "312  Prive pemilik"});
            this.CBUtangModalNS.Location = new System.Drawing.Point(255, 185);
            this.CBUtangModalNS.Name = "CBUtangModalNS";
            this.CBUtangModalNS.Size = new System.Drawing.Size(272, 28);
            this.CBUtangModalNS.TabIndex = 8;
            this.CBUtangModalNS.SelectedIndexChanged += new System.EventHandler(this.CBUtangNS_SelectedIndexChanged);
            // 
            // CBPendapatanBebanNS
            // 
            this.CBPendapatanBebanNS.FormattingEnabled = true;
            this.CBPendapatanBebanNS.Items.AddRange(new object[] {
            "411  Pendapatan usaha",
            "412  Pendapatan lain-lain",
            "511  Beban gaji",
            "512  Beban air, listrik, dan telepon",
            "513  Beban pajak",
            "514  Beban bunga",
            "515  Beban lain-lain"});
            this.CBPendapatanBebanNS.Location = new System.Drawing.Point(255, 220);
            this.CBPendapatanBebanNS.Name = "CBPendapatanBebanNS";
            this.CBPendapatanBebanNS.Size = new System.Drawing.Size(272, 28);
            this.CBPendapatanBebanNS.TabIndex = 10;
            // 
            // IsiUtangModalNS
            // 
            this.IsiUtangModalNS.AutoCompleteCustomSource.AddRange(new string[] {
            "211  Utang usaha",
            "215  Asuransi diterima dimuka",
            "216  Sewa diterima dimuka",
            "219  Utang jangka pendek lain-lain",
            "221  Utang obligasi",
            "222  Utang hipotik"});
            this.IsiUtangModalNS.Location = new System.Drawing.Point(555, 185);
            this.IsiUtangModalNS.Name = "IsiUtangModalNS";
            this.IsiUtangModalNS.Size = new System.Drawing.Size(120, 26);
            this.IsiUtangModalNS.TabIndex = 13;
            this.IsiUtangModalNS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsiUtangModalNS_KeyPress);
            // 
            // IsiPendapatanBebanNS
            // 
            this.IsiPendapatanBebanNS.AutoCompleteCustomSource.AddRange(new string[] {
            "411  Pendapatan usaha",
            "412  Pendapatan lain-lain"});
            this.IsiPendapatanBebanNS.Location = new System.Drawing.Point(555, 220);
            this.IsiPendapatanBebanNS.Name = "IsiPendapatanBebanNS";
            this.IsiPendapatanBebanNS.Size = new System.Drawing.Size(120, 26);
            this.IsiPendapatanBebanNS.TabIndex = 15;
            this.IsiPendapatanBebanNS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsiPendapatanBebanNS_KeyPress);
            // 
            // BHartaNS
            // 
            this.BHartaNS.Location = new System.Drawing.Point(705, 150);
            this.BHartaNS.Name = "BHartaNS";
            this.BHartaNS.Size = new System.Drawing.Size(75, 30);
            this.BHartaNS.TabIndex = 17;
            this.BHartaNS.Text = "Insert";
            this.BHartaNS.UseVisualStyleBackColor = true;
            this.BHartaNS.Click += new System.EventHandler(this.BHartaNS_Click);
            // 
            // BUtangModalNS
            // 
            this.BUtangModalNS.Location = new System.Drawing.Point(705, 185);
            this.BUtangModalNS.Name = "BUtangModalNS";
            this.BUtangModalNS.Size = new System.Drawing.Size(75, 30);
            this.BUtangModalNS.TabIndex = 18;
            this.BUtangModalNS.Text = "Insert";
            this.BUtangModalNS.UseVisualStyleBackColor = true;
            this.BUtangModalNS.Click += new System.EventHandler(this.BUtangNS_Click);
            // 
            // BPendapatanBebanNS
            // 
            this.BPendapatanBebanNS.Location = new System.Drawing.Point(705, 220);
            this.BPendapatanBebanNS.Name = "BPendapatanBebanNS";
            this.BPendapatanBebanNS.Size = new System.Drawing.Size(75, 30);
            this.BPendapatanBebanNS.TabIndex = 20;
            this.BPendapatanBebanNS.Text = "Insert";
            this.BPendapatanBebanNS.UseVisualStyleBackColor = true;
            this.BPendapatanBebanNS.Click += new System.EventHandler(this.BPendapatanNS_Click);
            // 
            // IsiHartaJP
            // 
            this.IsiHartaJP.AutoCompleteCustomSource.AddRange(new string[] {
            "111  Kas",
            "112  Piutang usaha",
            "113  Perlengkapan",
            "114  Surat berharga",
            "115  Iklan dibayar dimuka",
            "116  Sewa dibayar dimuka",
            "122  Peralatan",
            "124  Gedung",
            "131  Investasi dalam saham",
            "132  Investasi dalam obligasi",
            "141  Goodwill",
            "142  Hak paten",
            "199  Harta lain-lain"});
            this.IsiHartaJP.Location = new System.Drawing.Point(1495, 150);
            this.IsiHartaJP.Name = "IsiHartaJP";
            this.IsiHartaJP.Size = new System.Drawing.Size(120, 26);
            this.IsiHartaJP.TabIndex = 22;
            this.IsiHartaJP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.IsiHartaJP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // IsiUtangModalJP
            // 
            this.IsiUtangModalJP.AutoCompleteCustomSource.AddRange(new string[] {
            "111  Kas",
            "112  Piutang usaha",
            "113  Perlengkapan",
            "114  Surat berharga",
            "115  Iklan dibayar dimuka",
            "116  Sewa dibayar dimuka",
            "122  Peralatan",
            "124  Gedung",
            "131  Investasi dalam saham",
            "132  Investasi dalam obligasi",
            "141  Goodwill",
            "142  Hak paten",
            "199  Harta lain-lain"});
            this.IsiUtangModalJP.Location = new System.Drawing.Point(1495, 185);
            this.IsiUtangModalJP.Name = "IsiUtangModalJP";
            this.IsiUtangModalJP.Size = new System.Drawing.Size(120, 26);
            this.IsiUtangModalJP.TabIndex = 23;
            this.IsiUtangModalJP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // CheckNS
            // 
            this.CheckNS.Location = new System.Drawing.Point(255, 90);
            this.CheckNS.Name = "CheckNS";
            this.CheckNS.Size = new System.Drawing.Size(75, 30);
            this.CheckNS.TabIndex = 24;
            this.CheckNS.Text = "Check";
            this.CheckNS.UseVisualStyleBackColor = true;
            this.CheckNS.Click += new System.EventHandler(this.CheckNS_Click);
            // 
            // JurnalPenyesuaian
            // 
            this.JurnalPenyesuaian.AutoSize = true;
            this.JurnalPenyesuaian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JurnalPenyesuaian.Location = new System.Drawing.Point(950, 90);
            this.JurnalPenyesuaian.Name = "JurnalPenyesuaian";
            this.JurnalPenyesuaian.Size = new System.Drawing.Size(185, 25);
            this.JurnalPenyesuaian.TabIndex = 25;
            this.JurnalPenyesuaian.Text = "Jurnal Penyesuaian";
            // 
            // CheckJP
            // 
            this.CheckJP.Location = new System.Drawing.Point(1145, 90);
            this.CheckJP.Name = "CheckJP";
            this.CheckJP.Size = new System.Drawing.Size(75, 30);
            this.CheckJP.TabIndex = 26;
            this.CheckJP.Text = "Check";
            this.CheckJP.UseVisualStyleBackColor = true;
            this.CheckJP.Click += new System.EventHandler(this.CheckJP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(950, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Harta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(950, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Utang dan Modal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(950, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Pendapatan dan Beban";
            // 
            // CBHartaJP
            // 
            this.CBHartaJP.FormattingEnabled = true;
            this.CBHartaJP.Items.AddRange(new object[] {
            "111  Kas",
            "112  Piutang usaha",
            "113  Perlengkapan",
            "114  Surat berharga",
            "115  Iklan dibayar dimuka",
            "116  Sewa dibayar dimuka",
            "122  Peralatan",
            "124  Gedung",
            "131  Investasi dalam saham",
            "132  Investasi dalam obligasi",
            "141  Goodwill",
            "142  Hak paten",
            "198  Penyusutan harta",
            "199  Harta lain-lain",
            "113.1  Akumulasi penyusutan perlengkapan",
            "122.1  Akumulasi penyusutan peralatan",
            "124.1  Akumulasi penyusutan gedung"});
            this.CBHartaJP.Location = new System.Drawing.Point(1145, 150);
            this.CBHartaJP.Name = "CBHartaJP";
            this.CBHartaJP.Size = new System.Drawing.Size(322, 28);
            this.CBHartaJP.TabIndex = 31;
            // 
            // CBUtangModalJP
            // 
            this.CBUtangModalJP.FormattingEnabled = true;
            this.CBUtangModalJP.Items.AddRange(new object[] {
            "202  Utang gaji",
            "203  Utang pajak",
            "211  Utang usaha",
            "215  Asuransi diterima dimuka",
            "216  Sewa diterima dimuka",
            "219  Utang jangka pendek lain-lain",
            "221  Utang obligasi",
            "222  Utang hipotik",
            "311  Modal pemilik",
            "312  Prive pemilik"});
            this.CBUtangModalJP.Location = new System.Drawing.Point(1145, 185);
            this.CBUtangModalJP.Name = "CBUtangModalJP";
            this.CBUtangModalJP.Size = new System.Drawing.Size(322, 28);
            this.CBUtangModalJP.TabIndex = 32;
            // 
            // CBPendapatanBebanJP
            // 
            this.CBPendapatanBebanJP.FormattingEnabled = true;
            this.CBPendapatanBebanJP.Items.AddRange(new object[] {
            "411  Pendapatan usaha",
            "412  Pendapatan lain-lain",
            "502  Beban perlengkapan",
            "503  Beban peralatan",
            "504  Beban penyusutan perlengkapan",
            "505  Beban penyusutan peralatan",
            "506  Beban sewa",
            "511  Beban gaji",
            "512  Beban air, listrik, dan telepon",
            "513  Beban pajak",
            "514  Beban bunga",
            "515  Beban lain-lain",
            "631  Pajak penghasilan"});
            this.CBPendapatanBebanJP.Location = new System.Drawing.Point(1145, 220);
            this.CBPendapatanBebanJP.Name = "CBPendapatanBebanJP";
            this.CBPendapatanBebanJP.Size = new System.Drawing.Size(322, 28);
            this.CBPendapatanBebanJP.TabIndex = 33;
            // 
            // BDHarta
            // 
            this.BDHarta.Location = new System.Drawing.Point(1645, 150);
            this.BDHarta.Name = "BDHarta";
            this.BDHarta.Size = new System.Drawing.Size(75, 30);
            this.BDHarta.TabIndex = 34;
            this.BDHarta.Text = "Debit";
            this.BDHarta.UseVisualStyleBackColor = true;
            this.BDHarta.Click += new System.EventHandler(this.button1_Click);
            // 
            // IsiPendapatanBebanJP
            // 
            this.IsiPendapatanBebanJP.AutoCompleteCustomSource.AddRange(new string[] {
            "111  Kas",
            "112  Piutang usaha",
            "113  Perlengkapan",
            "114  Surat berharga",
            "115  Iklan dibayar dimuka",
            "116  Sewa dibayar dimuka",
            "122  Peralatan",
            "124  Gedung",
            "131  Investasi dalam saham",
            "132  Investasi dalam obligasi",
            "141  Goodwill",
            "142  Hak paten",
            "199  Harta lain-lain"});
            this.IsiPendapatanBebanJP.Location = new System.Drawing.Point(1495, 220);
            this.IsiPendapatanBebanJP.Name = "IsiPendapatanBebanJP";
            this.IsiPendapatanBebanJP.Size = new System.Drawing.Size(120, 26);
            this.IsiPendapatanBebanJP.TabIndex = 35;
            this.IsiPendapatanBebanJP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // BDUtangModal
            // 
            this.BDUtangModal.Location = new System.Drawing.Point(1645, 185);
            this.BDUtangModal.Name = "BDUtangModal";
            this.BDUtangModal.Size = new System.Drawing.Size(75, 30);
            this.BDUtangModal.TabIndex = 36;
            this.BDUtangModal.Text = "Debit";
            this.BDUtangModal.UseVisualStyleBackColor = true;
            this.BDUtangModal.Click += new System.EventHandler(this.BDUtangModal_Click);
            // 
            // BDPendapatanBeban
            // 
            this.BDPendapatanBeban.Location = new System.Drawing.Point(1645, 220);
            this.BDPendapatanBeban.Name = "BDPendapatanBeban";
            this.BDPendapatanBeban.Size = new System.Drawing.Size(75, 30);
            this.BDPendapatanBeban.TabIndex = 37;
            this.BDPendapatanBeban.Text = "Debit";
            this.BDPendapatanBeban.UseVisualStyleBackColor = true;
            this.BDPendapatanBeban.Click += new System.EventHandler(this.BDPendapatanBeban_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 312);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1800, 681);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // ResetNS
            // 
            this.ResetNS.Location = new System.Drawing.Point(850, 275);
            this.ResetNS.Name = "ResetNS";
            this.ResetNS.Size = new System.Drawing.Size(75, 30);
            this.ResetNS.TabIndex = 41;
            this.ResetNS.Text = "Delete";
            this.ResetNS.UseVisualStyleBackColor = true;
            this.ResetNS.Click += new System.EventHandler(this.ResetNS_Click);
            // 
            // BKHarta
            // 
            this.BKHarta.Location = new System.Drawing.Point(1745, 150);
            this.BKHarta.Name = "BKHarta";
            this.BKHarta.Size = new System.Drawing.Size(75, 30);
            this.BKHarta.TabIndex = 42;
            this.BKHarta.Text = "Kredit";
            this.BKHarta.UseVisualStyleBackColor = true;
            this.BKHarta.Click += new System.EventHandler(this.BKHarta_Click);
            // 
            // BKUtangModal
            // 
            this.BKUtangModal.Location = new System.Drawing.Point(1745, 185);
            this.BKUtangModal.Name = "BKUtangModal";
            this.BKUtangModal.Size = new System.Drawing.Size(75, 30);
            this.BKUtangModal.TabIndex = 43;
            this.BKUtangModal.Text = "Kredit";
            this.BKUtangModal.UseVisualStyleBackColor = true;
            this.BKUtangModal.Click += new System.EventHandler(this.BKUtangModal_Click);
            // 
            // BKPendapatanBeban
            // 
            this.BKPendapatanBeban.Location = new System.Drawing.Point(1745, 220);
            this.BKPendapatanBeban.Name = "BKPendapatanBeban";
            this.BKPendapatanBeban.Size = new System.Drawing.Size(75, 30);
            this.BKPendapatanBeban.TabIndex = 44;
            this.BKPendapatanBeban.Text = "Kredit";
            this.BKPendapatanBeban.UseVisualStyleBackColor = true;
            this.BKPendapatanBeban.Click += new System.EventHandler(this.BKPendapatanBeban_Click);
            // 
            // Hasil
            // 
            this.Hasil.Location = new System.Drawing.Point(995, 275);
            this.Hasil.Name = "Hasil";
            this.Hasil.Size = new System.Drawing.Size(75, 30);
            this.Hasil.TabIndex = 45;
            this.Hasil.Text = "Hasil";
            this.Hasil.UseVisualStyleBackColor = true;
            this.Hasil.Click += new System.EventHandler(this.Hasil_Click);
            // 
            // LaporanNeraca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.Hasil);
            this.Controls.Add(this.BKPendapatanBeban);
            this.Controls.Add(this.BKUtangModal);
            this.Controls.Add(this.BKHarta);
            this.Controls.Add(this.ResetNS);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BDPendapatanBeban);
            this.Controls.Add(this.BDUtangModal);
            this.Controls.Add(this.IsiPendapatanBebanJP);
            this.Controls.Add(this.BDHarta);
            this.Controls.Add(this.CBPendapatanBebanJP);
            this.Controls.Add(this.CBUtangModalJP);
            this.Controls.Add(this.CBHartaJP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckJP);
            this.Controls.Add(this.JurnalPenyesuaian);
            this.Controls.Add(this.CheckNS);
            this.Controls.Add(this.IsiUtangModalJP);
            this.Controls.Add(this.IsiHartaJP);
            this.Controls.Add(this.BPendapatanBebanNS);
            this.Controls.Add(this.BUtangModalNS);
            this.Controls.Add(this.BHartaNS);
            this.Controls.Add(this.IsiPendapatanBebanNS);
            this.Controls.Add(this.IsiUtangModalNS);
            this.Controls.Add(this.CBPendapatanBebanNS);
            this.Controls.Add(this.CBUtangModalNS);
            this.Controls.Add(this.Judul);
            this.Controls.Add(this.PendapatanNS);
            this.Controls.Add(this.UtangNS);
            this.Controls.Add(this.HartaNS);
            this.Controls.Add(this.IsiHartaNS);
            this.Controls.Add(this.NeracaSaldo);
            this.Controls.Add(this.CBHartaNS);
            this.Name = "LaporanNeraca";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.aaaaaaaa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NeracaSaldo;
        private System.Windows.Forms.TextBox IsiHartaNS;
        private System.Windows.Forms.Label HartaNS;
        private System.Windows.Forms.Label UtangNS;
        private System.Windows.Forms.Label PendapatanNS;
        private System.Windows.Forms.Label Judul;
        private System.Windows.Forms.ComboBox CBUtangModalNS;
        private System.Windows.Forms.ComboBox CBPendapatanBebanNS;
        private System.Windows.Forms.TextBox IsiUtangModalNS;
        private System.Windows.Forms.TextBox IsiPendapatanBebanNS;
        private System.Windows.Forms.ComboBox CBHartaNS;
        private System.Windows.Forms.Button BHartaNS;
        private System.Windows.Forms.Button BUtangModalNS;
        private System.Windows.Forms.Button BPendapatanBebanNS;
        private System.Windows.Forms.TextBox IsiHartaJP;
        private System.Windows.Forms.TextBox IsiUtangModalJP;
        private System.Windows.Forms.Button CheckNS;
        private System.Windows.Forms.Label JurnalPenyesuaian;
        private System.Windows.Forms.Button CheckJP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBHartaJP;
        private System.Windows.Forms.ComboBox CBUtangModalJP;
        private System.Windows.Forms.ComboBox CBPendapatanBebanJP;
        private System.Windows.Forms.Button BDHarta;
        private System.Windows.Forms.TextBox IsiPendapatanBebanJP;
        private System.Windows.Forms.Button BDUtangModal;
        private System.Windows.Forms.Button BDPendapatanBeban;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ResetNS;
        private System.Windows.Forms.Button BKHarta;
        private System.Windows.Forms.Button BKUtangModal;
        private System.Windows.Forms.Button BKPendapatanBeban;
        private System.Windows.Forms.Button Hasil;
    }
}

