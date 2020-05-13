using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Program
{
    public partial class LaporanNeraca : Form
    {
        DataTable input1 = new DataTable();
        class data
        {
            private double Kas, PiutangUsaha, Perlengkapan, SuratBerharga, IklanDibayarDimuka, SewaDibayarDimuka, Peralatan, Gedung;
            private double InvestasiDalamSaham, InvestasiDalamObligasi, Goodwill, HakPaten, HartaLainLain, PenyusutanHarta;
            private double UtangUsaha, UtangJangkaPendekLainLain, AsuransiDiterimaDimuka, SewaDiterimaDimuka;
            private double UtangObligasi, UtangHipotik, ModalPemilik, PrivePemilik, UtangGaji, UtangPajak;
            private double PendapatanUsaha, PendapatanLainLain, PajakPenghasilan;
            private double BebanGaji, BebanAirListrikTelepon, BebanPajak, BebanBunga, BebanLainLain;
            private double AkumulasiPenyusutanPerlengkapan, AkumulasiPenyusutanPeralatan, AkumulasiPenyusutanGedung;
            private double BebanPerlengkapan, BebanPeralatan, BebanPenyusutanPerlengkapan, BebanPenyusutanPeralatan, BebanSewa;
            public void setPenyusutanHarta(double val)
            {
                this.PenyusutanHarta = val;
            }
            public double getPenyusutanHarta()
            {
                return PenyusutanHarta;
            }
            public void setBebanSewa(double val)
            {
                this.BebanSewa = val;
            }
            public double getBebanSewa()
            {
                return BebanSewa;
            }
            public void setBebanPenyusutanPeralatan(double val)
            {
                this.BebanPenyusutanPeralatan = val;
            }
            public double getBebanPenyusutanPeralatan()
            {
                return BebanPenyusutanPeralatan;
            }
            public void setBebanPenyusutanPerlengkapan(double val)
            {
                this.BebanPenyusutanPerlengkapan = val;
            }
            public double getBebanPenyusutanPerlengkapan()
            {
                return BebanPenyusutanPerlengkapan;
            }
            public void setBebanPeralatan(double val)
            {
                this.BebanPeralatan = val;
            }
            public double getBebanPeralatan()
            {
                return BebanPeralatan;
            }
            public void setBebanPerlengkapan(double val)
            {
                this.BebanPerlengkapan = val;
            }
            public double getBebanPerlengkapan()
            {
                return BebanPerlengkapan;
            }
            public void setPajakPenghasilan(double val)
            {
                this.PajakPenghasilan = val;
            }
            public double getPajakPenghasilan()
            {
                return PajakPenghasilan;
            }
            public void setUtangPajak(double val)
            {
                this.UtangPajak = val;
            }
            public double getUtangPajak()
            {
                return UtangPajak;
            }
            public void setUtangGaji(double val)
            {
                this.UtangGaji = val;
            }
            public double getUtangGaji()
            {
                return UtangGaji;
            }
            public void setAkumulasiPenyusutanGedung(double val)
            {
                this.AkumulasiPenyusutanGedung = val;
            }
            public double getAkumulasiPenyusutanGedung()
            {
                return AkumulasiPenyusutanGedung;
            }
            public void setAkumulasiPenyusutanPeralatan(double val)
            {
                this.AkumulasiPenyusutanPeralatan = val;
            }
            public double getAkumulasiPenyusutanPeralatan()
            {
                return AkumulasiPenyusutanPeralatan;
            }
            public void setAkumulasiPenyusutanPerlengkapan(double val)
            {
                this.AkumulasiPenyusutanPerlengkapan = val;
            }
            public double getAkumulasiPenyusutanPerlengkapan()
            {
                return AkumulasiPenyusutanPerlengkapan;
            }
            public void setKas(double val)
            {
                this.Kas = val;
            }
            public double getKas()
            {
                return Kas;
            }
            public void setPiutangUsaha(double val)
            {
                this.PiutangUsaha = val;
            }
            public double getPiutangUsaha()
            {
                return PiutangUsaha;
            }
            public void setPerlengkapan(double val)
            {
                this.Perlengkapan = val;
            }
            public double getPerlengkapan()
            {
                return Perlengkapan;
            }
            public void setSuratBerharga(double val)
            {
                this.SuratBerharga = val;
            }
            public double getSuratBerharga()
            {
                return SuratBerharga;
            }
            public void setIklanDibayarDimuka(double val)
            {
                this.IklanDibayarDimuka = val;
            }
            public double getIklanDibayarDimuka()
            {
                return IklanDibayarDimuka;
            }
            public void setSewaDibayarDimuka(double val)
            {
                this.SewaDibayarDimuka = val;
            }
            public double getSewaDibayarDimuka()
            {
                return SewaDibayarDimuka;
            }
            public void setPeralatan(double val)
            {
                this.Peralatan = val;
            }
            public double getPeralatan()
            {
                return Peralatan;
            }
            public void setGedung(double val)
            {
                this.Gedung = val;
            }
            public double getGedung()
            {
                return Gedung;
            }
            public void setInvestasiDalamSaham(double val)
            {
                this.InvestasiDalamSaham = val;
            }
            public double getInvestasiDalamSaham()
            {
                return InvestasiDalamSaham;
            }
            public void setInvestasiDalamObligasi(double val)
            {
                this.InvestasiDalamObligasi = val;
            }
            public double getInvestasiDalamObligasi()
            {
                return InvestasiDalamObligasi;
            }
            public void setGoodwill(double val)
            {
                this.Goodwill = val;
            }
            public double getGoodwill()
            {
                return Goodwill;
            }
            public void setHakPaten(double val)
            {
                this.HakPaten = val;
            }
            public double getHakPaten()
            {
                return HakPaten;
            }
            public void setHartaLainLain(double val)
            {
                this.HartaLainLain = val;
            }
            public double getHartaLainLain()
            {
                return HartaLainLain;
            }
            public void setUtangUsaha(double val)
            {
                this.UtangUsaha = val;
            }
            public double getUtangUsaha()
            {
                return UtangUsaha;
            }
            public void setUtangJangkaPendekLainLain(double val)
            {
                this.UtangJangkaPendekLainLain = val;
            }
            public double getUtangJangkaPendekLainLain()
            {
                return UtangJangkaPendekLainLain;
            }
            public void setAsuransiDiterimaDimuka(double val)
            {
                this.AsuransiDiterimaDimuka = val;
            }
            public double getAsuransiDiterimaDimuka()
            {
                return AsuransiDiterimaDimuka;
            }
            public void setSewaDiterimaDimuka(double val)
            {
                this.SewaDiterimaDimuka = val;
            }
            public double getSewaDiterimaDimuka()
            {
                return SewaDiterimaDimuka;
            }
            public void setUtangObligasi(double val)
            {
                this.UtangObligasi = val;
            }
            public double getUtangObligasi()
            {
                return UtangObligasi;
            }
            public void setUtangHipotik(double val)
            {
                this.UtangHipotik = val;
            }
            public double getUtangHipotik()
            {
                return UtangHipotik;
            }
            public void setModalPemilik(double val)
            {
                this.ModalPemilik = val;
            }
            public double getModalPemilik()
            {
                return ModalPemilik;
            }
            public void setPrivePemilik(double val)
            {
                this.PrivePemilik = val;
            }
            public double getPrivePemilik()
            {
                return PrivePemilik;
            }
            public void setPendapatanUsaha(double val)
            {
                this.PendapatanUsaha = val;
            }
            public double getPendapatanUsaha()
            {
                return PendapatanUsaha;
            }
            public void setPendapatanLainLain(double val)
            {
                this.PendapatanLainLain = val;
            }
            public double getPendapatanLainLain()
            {
                return PendapatanLainLain;
            }
            public void setBebanGaji(double val)
            {
                this.BebanGaji = val;
            }
            public double getBebanGaji()
            {
                return BebanGaji;
            }
            public void setBebanAirListrikTelepon(double val)
            {
                this.BebanAirListrikTelepon = val;
            }
            public double getBebanAirListrikTelepon()
            {
                return BebanAirListrikTelepon;
            }
            public void setBebanPajak(double val)
            {
                this.BebanPajak = val;
            }
            public double getBebanPajak()
            {
                return BebanPajak;
            }
            public void setBebanBunga(double val)
            {
                this.BebanBunga = val;
            }
            public double getBebanBunga()
            {
                return BebanBunga;
            }
            public void setBebanLainLain(double val)
            {
                this.BebanLainLain = val;
            }
            public double getBebanLainLain()
            {
                return BebanLainLain;
            }
        }
        public void BPendapatanNS_Click(object sender, EventArgs e)
        {
            data pendapatan = new data();
            data beban = new data();
            if (CBPendapatanBebanNS.SelectedItem == "411  Pendapatan usaha")
            {
                pendapatan.setPendapatanUsaha(double.Parse(this.IsiPendapatanBebanNS.Text));
                input1.Rows.Add(CBPendapatanBebanNS.Text, "0", IsiPendapatanBebanNS.Text, "0", "0", "0", IsiPendapatanBebanNS.Text, "0", IsiPendapatanBebanNS.Text, "0", "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBPendapatanBebanNS.SelectedItem == "412  Pendapatan lain-lain")
            {
                pendapatan.setPendapatanLainLain(double.Parse(this.IsiPendapatanBebanNS.Text));
                input1.Rows.Add(CBPendapatanBebanNS.Text, "0", IsiPendapatanBebanNS.Text, "0", "0", "0", IsiPendapatanBebanNS.Text, "0", IsiPendapatanBebanNS.Text, "0", "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBPendapatanBebanNS.SelectedItem == "511  Beban gaji")
            {
                beban.setBebanGaji(double.Parse(this.IsiPendapatanBebanNS.Text));
                input1.Rows.Add(CBPendapatanBebanNS.Text, IsiPendapatanBebanNS.Text, "0", "0", "0", IsiPendapatanBebanNS.Text, "0", IsiPendapatanBebanNS.Text, "0", "0", "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBPendapatanBebanNS.SelectedItem == "512  Beban air, listrik, dan telepon")
            {
                beban.setBebanAirListrikTelepon(double.Parse(this.IsiPendapatanBebanNS.Text));
                input1.Rows.Add(CBPendapatanBebanNS.Text, IsiPendapatanBebanNS.Text, "0", "0", "0", IsiPendapatanBebanNS.Text, "0", IsiPendapatanBebanNS.Text, "0", "0", "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBPendapatanBebanNS.SelectedItem == "513  Beban pajak")
            {
                beban.setBebanPajak(double.Parse(this.IsiPendapatanBebanNS.Text));
                input1.Rows.Add(CBPendapatanBebanNS.Text, IsiPendapatanBebanNS.Text, "0", "0", "0", IsiPendapatanBebanNS.Text, "0", IsiPendapatanBebanNS.Text, "0", "0", "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBPendapatanBebanNS.SelectedItem == "514  Beban bunga")
            {
                beban.setBebanBunga(double.Parse(this.IsiPendapatanBebanNS.Text));
                input1.Rows.Add(CBPendapatanBebanNS.Text, IsiPendapatanBebanNS.Text, "0", "0", "0", IsiPendapatanBebanNS.Text, "0", IsiPendapatanBebanNS.Text, "0", "0", "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBPendapatanBebanNS.SelectedItem == "515  Beban lain-lain")
            {
                beban.setBebanLainLain(double.Parse(this.IsiPendapatanBebanNS.Text));
                input1.Rows.Add(CBPendapatanBebanNS.Text, IsiPendapatanBebanNS.Text, "0", "0", "0", IsiPendapatanBebanNS.Text, "0", IsiPendapatanBebanNS.Text, "0", "0", "0");
                this.dataGridView1.DataSource = input1;
            }
            IsiPendapatanBebanNS.Clear();
        }
        public void BModalNS_Click(object sender, EventArgs e)
        {
            
        }
        public void BBebanNS_Click(object sender, EventArgs e)
        {
            
        }
        public void CheckNS_Click(object sender, EventArgs e)
        {
            input1.Rows.Add();
            this.dataGridView1.DataSource = input1;
            dataGridView1[0, dataGridView1.Rows.Count - 2].Value = "TOTAL (Neraca Saldo)";
            dataGridView1[0, dataGridView1.Rows.Count - 2].Style.ForeColor = Color.Blue;
            double totalNSd = 0;
            for (int i = 0; i < dataGridView1.RowCount - 2; i++)
            {
                var value = dataGridView1.Rows[i].Cells[1].Value;
                if (value != DBNull.Value)
                {
                    totalNSd += Convert.ToDouble(value);
                }
            }
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Value = totalNSd.ToString();
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Style.ForeColor = Color.Blue;
            double totalNSk = 0;
            for (int i = 0; i < dataGridView1.RowCount - 2; i++)
            {
                var value = dataGridView1.Rows[i].Cells[2].Value;
                if (value != DBNull.Value)
                {
                    totalNSk += Convert.ToDouble(value);
                }
            }
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[2].Value = totalNSk.ToString();
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[2].Style.ForeColor = Color.Blue;
        }
        private void CheckJP_Click(object sender, EventArgs e)
        {
            input1.Rows.Add();
            this.dataGridView1.DataSource = input1;
            dataGridView1[0, dataGridView1.Rows.Count - 2].Value = "TOTAL";
            dataGridView1[0, dataGridView1.Rows.Count - 2].Style.ForeColor = Color.Blue;
            double totalJPd = 0;
            for (int i = 0; i < dataGridView1.RowCount - 2; i++)
            {
                var value = dataGridView1.Rows[i].Cells[3].Value;
                if (value != DBNull.Value)
                {
                    totalJPd += Convert.ToDouble(value);
                }
            }
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[3].Value = totalJPd.ToString();
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[3].Style.ForeColor = Color.Blue;
            double totalJPk = 0;
            for (int i = 0; i < dataGridView1.RowCount - 2; i++)
            {
                var value = dataGridView1.Rows[i].Cells[4].Value;
                if (value != DBNull.Value)
                {
                    totalJPk += Convert.ToDouble(value);
                }
            }
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[4].Value = totalJPk.ToString();
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[4].Style.ForeColor = Color.Blue;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void aaaaaaaa_Load(object sender, EventArgs e)
        {
            input1.Columns.AddRange(new DataColumn[11]
            {
                new DataColumn("Nama Akun", typeof(string)),
                new DataColumn("Neraca Saldo (Debit)", typeof(double)),
                new DataColumn("Neraca Saldo (Kredit)", typeof(double)),
                new DataColumn("Jurnal Penyesuaian (Debit)", typeof(double)),
                new DataColumn("Jurnal Penyesuaian (Kredit)", typeof(double)),
                new DataColumn("Neraca Saldo Disesuaikan (Debit)", typeof(double)),
                new DataColumn("Neraca Saldo Disesuaikan (Kredit)", typeof(double)),
                new DataColumn("Laba Rugi (Debit)", typeof(double)),
                new DataColumn("Laba Rugi (Kredit)", typeof(double)),
                new DataColumn("Laporan Neraca (Debit)", typeof(double)),
                new DataColumn("Laporan Neraca (Kredit)", typeof(double))
            });
        }
        private void IsiModalNS_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void BUtangNS_Click(object sender, EventArgs e)
        {
            data utang = new data();
            data modal = new data();
            if (CBUtangModalNS.SelectedItem == "211  Utang usaha")
            {
                utang.setUtangUsaha(double.Parse(this.IsiUtangModalNS.Text));
                input1.Rows.Add(CBUtangModalNS.Text, "0", IsiUtangModalNS.Text, "0", "0", "0", IsiUtangModalNS.Text, "0", "0", "0", IsiUtangModalNS.Text);
                this.dataGridView1.DataSource = input1;
            }
            else if (CBUtangModalNS.SelectedItem == "215  Asuransi diterima dimuka")
            {
                utang.setAsuransiDiterimaDimuka(double.Parse(this.IsiUtangModalNS.Text));
                input1.Rows.Add(CBUtangModalNS.Text, "0", IsiUtangModalNS.Text, "0", "0", "0", IsiUtangModalNS.Text, "0", "0", "0", IsiUtangModalNS.Text);
                this.dataGridView1.DataSource = input1;
            }
            else if (CBUtangModalNS.SelectedItem == "216  Sewa diterima dimuka")
            {
                utang.setSewaDiterimaDimuka(double.Parse(this.IsiUtangModalNS.Text));
                input1.Rows.Add(CBUtangModalNS.Text, "0", IsiUtangModalNS.Text, "0", "0", "0", IsiUtangModalNS.Text, "0", "0", "0", IsiUtangModalNS.Text);
                this.dataGridView1.DataSource = input1;
            }
            else if (CBUtangModalNS.SelectedItem == "219  Utang jangka pendek lain-lain")
            {
                utang.setUtangJangkaPendekLainLain(double.Parse(this.IsiUtangModalNS.Text));
                input1.Rows.Add(CBUtangModalNS.Text, "0", IsiUtangModalNS.Text, "0", "0", "0", IsiUtangModalNS.Text, "0", "0", "0", IsiUtangModalNS.Text);
                this.dataGridView1.DataSource = input1;
            }
            else if (CBUtangModalNS.SelectedItem == "221  Utang obligasi")
            {
                utang.setUtangObligasi(double.Parse(this.IsiUtangModalNS.Text));
                input1.Rows.Add(CBUtangModalNS.Text, "0", IsiUtangModalNS.Text, "0", "0", "0", IsiUtangModalNS.Text, "0", "0", "0", IsiUtangModalNS.Text);
                this.dataGridView1.DataSource = input1;
            }
            else if (CBUtangModalNS.SelectedItem == "222  Utang hipotik")
            {
                utang.setUtangHipotik(double.Parse(this.IsiUtangModalNS.Text));
                input1.Rows.Add(CBUtangModalNS.Text, "0", IsiUtangModalNS.Text, "0", "0", "0", IsiUtangModalNS.Text, "0", "0", "0", IsiUtangModalNS.Text);
                this.dataGridView1.DataSource = input1;
            }
            else if (CBUtangModalNS.SelectedItem == "311  Modal pemilik")
            {
                modal.setModalPemilik(double.Parse(this.IsiUtangModalNS.Text));
                input1.Rows.Add(CBUtangModalNS.Text, "0", IsiUtangModalNS.Text, "0", "0", "0", IsiUtangModalNS.Text, "0", "0", "0", IsiUtangModalNS.Text);
                this.dataGridView1.DataSource = input1;
            }
            else if (CBUtangModalNS.SelectedItem == "312  Prive pemilik")
            {
                modal.setPrivePemilik(double.Parse(this.IsiUtangModalNS.Text));
                input1.Rows.Add(CBUtangModalNS.Text, IsiUtangModalNS.Text, "0", "0", "0", IsiUtangModalNS.Text, "0", "0", "0", IsiUtangModalNS.Text, "0");
                this.dataGridView1.DataSource = input1;
            }
            IsiUtangModalNS.Clear();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }
        public void BHartaNS_Click(object sender, EventArgs e)
        {
            data harta = new data();
            if (CBHartaNS.SelectedItem == "111  Kas")
            {
                harta.setKas(double.Parse(this.IsiHartaNS.Text));
                input1.Rows.Add(CBHartaNS.Text, IsiHartaNS.Text, "0", "0", "0", IsiHartaNS.Text, "0", "0", "0", IsiHartaNS.Text, "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBHartaNS.SelectedItem == "112  Piutang usaha")
            {
                harta.setPiutangUsaha(double.Parse(this.IsiHartaNS.Text));
                input1.Rows.Add(CBHartaNS.Text, IsiHartaNS.Text, "0", "0", "0", IsiHartaNS.Text, "0", "0", "0", IsiHartaNS.Text, "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBHartaNS.SelectedItem == "113  Perlengkapan")
            {
                harta.setPerlengkapan(double.Parse(this.IsiHartaNS.Text));
                input1.Rows.Add(CBHartaNS.Text, IsiHartaNS.Text, "0", "0", "0", IsiHartaNS.Text, "0", "0", "0", IsiHartaNS.Text, "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBHartaNS.SelectedItem == "114  Surat Berharga")
            {
                harta.setSuratBerharga(double.Parse(this.IsiHartaNS.Text));
                input1.Rows.Add(CBHartaNS.Text, IsiHartaNS.Text, "0", "0", "0", IsiHartaNS.Text, "0", "0", "0", IsiHartaNS.Text, "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBHartaNS.SelectedItem == "115  Iklan dibayar dimuka")
            {
                harta.setIklanDibayarDimuka(double.Parse(this.IsiHartaNS.Text));
                input1.Rows.Add(CBHartaNS.Text, IsiHartaNS.Text, "0", "0", "0", IsiHartaNS.Text, "0", "0", "0", IsiHartaNS.Text, "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBHartaNS.SelectedItem == "116  Sewa dibayar dimuka")
            {
                harta.setSewaDibayarDimuka(double.Parse(this.IsiHartaNS.Text));
                input1.Rows.Add(CBHartaNS.Text, IsiHartaNS.Text, "0", "0", "0", IsiHartaNS.Text, "0", "0", "0", IsiHartaNS.Text, "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBHartaNS.SelectedItem == "122  Peralatan")
            {
                harta.setPeralatan(double.Parse(this.IsiHartaNS.Text));
                input1.Rows.Add(CBHartaNS.Text, IsiHartaNS.Text, "0", "0", "0", IsiHartaNS.Text, "0", "0", "0", IsiHartaNS.Text, "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBHartaNS.SelectedItem == "124  Gedung")
            {
                harta.setGedung(double.Parse(this.IsiHartaNS.Text));
                input1.Rows.Add(CBHartaNS.Text, IsiHartaNS.Text, "0", "0", "0", IsiHartaNS.Text, "0", "0", "0", IsiHartaNS.Text, "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBHartaNS.SelectedItem == "131  Investasi dalam saham")
            {
                harta.setInvestasiDalamSaham(double.Parse(this.IsiHartaNS.Text));
                input1.Rows.Add(CBHartaNS.Text, IsiHartaNS.Text, "0", "0", "0", IsiHartaNS.Text, "0", "0", "0", IsiHartaNS.Text, "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBHartaNS.SelectedItem == "132  Investasi dalam obligasi")
            {
                harta.setInvestasiDalamObligasi(double.Parse(this.IsiHartaNS.Text));
                input1.Rows.Add(CBHartaNS.Text, IsiHartaNS.Text, "0", "0", "0", IsiHartaNS.Text, "0", "0", "0", IsiHartaNS.Text, "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBHartaNS.SelectedItem == "141  Goodwill")
            {
                harta.setGoodwill(double.Parse(this.IsiHartaNS.Text));
                input1.Rows.Add(CBHartaNS.Text, IsiHartaNS.Text, "0", "0", "0", IsiHartaNS.Text, "0", "0", "0", IsiHartaNS.Text, "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBHartaNS.SelectedItem == "142  Hak paten")
            {
                harta.setHakPaten(double.Parse(this.IsiHartaNS.Text));
                input1.Rows.Add(CBHartaNS.Text, IsiHartaNS.Text, "0", "0", "0", IsiHartaNS.Text, "0", "0", "0", IsiHartaNS.Text, "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBHartaNS.SelectedItem == "199  Harta lain-lain")
            {
                harta.setHartaLainLain(double.Parse(this.IsiHartaNS.Text));
                input1.Rows.Add(CBHartaNS.Text, IsiHartaNS.Text, "0", "0", "0", IsiHartaNS.Text, "0", "0", "0", IsiHartaNS.Text, "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBHartaNS.SelectedItem == "199  Penyusutan harta")
            {
                harta.setPenyusutanHarta(double.Parse(this.IsiHartaNS.Text));
                input1.Rows.Add(CBHartaNS.Text, "0", IsiHartaNS.Text, "0", "0", "0", IsiHartaNS.Text, "0", "0", "0", IsiHartaNS.Text);
                this.dataGridView1.DataSource = input1;
            }
            IsiHartaNS.Clear();
        }
        private object Tabel(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        private void CBUtangNS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void UtangNS_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public LaporanNeraca()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void NeracaSaldo_Click(object sender, EventArgs e)
        {

        }
        private void IsiNS_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void IsiHartaNS_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
        private void IsiUtangModalNS_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
        private void IsiPendapatanBebanNS_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
        public void SaveNS_Click(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            data hartaDJP = new data();
            if (CBHartaNS.SelectedItem == "111  Kas")
            {
                hartaDJP.setKas(double.Parse(this.IsiHartaJP.Text));
            }
            else if (CBHartaNS.SelectedItem == "112  Piutang usaha")
            {
                hartaDJP.setPiutangUsaha(double.Parse(this.IsiHartaJP.Text));
            }
            else if (CBHartaNS.SelectedItem == "113  Perlengkapan")
            {
                hartaDJP.setPerlengkapan(double.Parse(this.IsiHartaJP.Text));
            }
            else if (CBHartaNS.SelectedItem == "114  Surat Berharga")
            {
                hartaDJP.setSuratBerharga(double.Parse(this.IsiHartaJP.Text));
            }
            else if (CBHartaNS.SelectedItem == "115  Iklan dibayar dimuka")
            {
                hartaDJP.setIklanDibayarDimuka(double.Parse(this.IsiHartaJP.Text));
            }
            else if (CBHartaNS.SelectedItem == "116  Sewa dibayar dimuka")
            {
                hartaDJP.setSewaDibayarDimuka(double.Parse(this.IsiHartaJP.Text));
            }
            else if (CBHartaNS.SelectedItem == "122  Peralatan")
            {
                hartaDJP.setPeralatan(double.Parse(this.IsiHartaJP.Text));
            }
            else if (CBHartaNS.SelectedItem == "124  Gedung")
            {
                hartaDJP.setGedung(double.Parse(this.IsiHartaJP.Text));
            }
            else if (CBHartaNS.SelectedItem == "131  Investasi dalam saham")
            {
                hartaDJP.setInvestasiDalamSaham(double.Parse(this.IsiHartaJP.Text));
            }
            else if (CBHartaNS.SelectedItem == "132  Investasi dalam obligasi")
            {
                hartaDJP.setInvestasiDalamObligasi(double.Parse(this.IsiHartaJP.Text));
            }
            else if (CBHartaNS.SelectedItem == "141  Goodwill")
            {
                hartaDJP.setGoodwill(double.Parse(this.IsiHartaJP.Text));
            }
            else if (CBHartaNS.SelectedItem == "142  Hak paten")
            {
                hartaDJP.setHakPaten(double.Parse(this.IsiHartaJP.Text));
            }
            else if (CBHartaNS.SelectedItem == "198  Penyusutan harta")
            {
                hartaDJP.setPenyusutanHarta(double.Parse(this.IsiHartaJP.Text));
            }
            else if (CBHartaNS.SelectedItem == "199  Harta lain-lain")
            {
                hartaDJP.setHartaLainLain(double.Parse(this.IsiHartaJP.Text));
            }
            else if (CBHartaNS.SelectedItem == "113.1  Akumulasi penyusutan perlengkapan")
            {
                hartaDJP.setAkumulasiPenyusutanPerlengkapan(double.Parse(this.IsiHartaJP.Text));
            }
            else if (CBHartaNS.SelectedItem == "122.1  Akumulasi penyusutan peralatan")
            {
                hartaDJP.setAkumulasiPenyusutanPeralatan(double.Parse(this.IsiHartaJP.Text));
            }
            else if (CBHartaNS.SelectedItem == "124.1  Akumulasi penyusutan gedung")
            {
                hartaDJP.setAkumulasiPenyusutanGedung(double.Parse(this.IsiHartaJP.Text));
            }
            input1.Rows.Add(CBHartaJP.Text, "0", "0", IsiHartaJP.Text, "0", IsiHartaJP.Text, "0", "0", "0", IsiHartaJP.Text, "0");
            this.dataGridView1.DataSource = input1;
            IsiHartaJP.Clear();
        }
        private void BKHarta_Click(object sender, EventArgs e)
        {
            data hartaKJP = new data();
            if (CBHartaNS.SelectedItem == "111  Kas")
            {
                hartaKJP.setKas(double.Parse(this.IsiHartaJP.Text));
            }
            else if (CBHartaNS.SelectedItem == "112  Piutang usaha")
            {
                hartaKJP.setPiutangUsaha(double.Parse(this.IsiHartaJP.Text));
            }
            else if (CBHartaNS.SelectedItem == "113  Perlengkapan")
            {
                hartaKJP.setPerlengkapan(double.Parse(this.IsiHartaJP.Text));
            }
            else if (CBHartaNS.SelectedItem == "114  Surat Berharga")
            {
                hartaKJP.setSuratBerharga(double.Parse(this.IsiHartaJP.Text));
            }
            else if (CBHartaNS.SelectedItem == "115  Iklan dibayar dimuka")
            {
                hartaKJP.setIklanDibayarDimuka(double.Parse(this.IsiHartaJP.Text));
            }
            else if (CBHartaNS.SelectedItem == "116  Sewa dibayar dimuka")
            {
                hartaKJP.setSewaDibayarDimuka(double.Parse(this.IsiHartaJP.Text));
            }
            else if (CBHartaNS.SelectedItem == "122  Peralatan")
            {
                hartaKJP.setPeralatan(double.Parse(this.IsiHartaJP.Text));
            }
            else if (CBHartaNS.SelectedItem == "124  Gedung")
            {
                hartaKJP.setGedung(double.Parse(this.IsiHartaJP.Text));
            }
            else if (CBHartaNS.SelectedItem == "131  Investasi dalam saham")
            {
                hartaKJP.setInvestasiDalamSaham(double.Parse(this.IsiHartaJP.Text));
            }
            else if (CBHartaNS.SelectedItem == "132  Investasi dalam obligasi")
            {
                hartaKJP.setInvestasiDalamObligasi(double.Parse(this.IsiHartaJP.Text));
            }
            else if (CBHartaNS.SelectedItem == "141  Goodwill")
            {
                hartaKJP.setGoodwill(double.Parse(this.IsiHartaJP.Text));
            }
            else if (CBHartaNS.SelectedItem == "142  Hak paten")
            {
                hartaKJP.setHakPaten(double.Parse(this.IsiHartaJP.Text));
            }
            else if (CBHartaNS.SelectedItem == "198  Penyusutan harta")
            {
                hartaKJP.setPenyusutanHarta(double.Parse(this.IsiHartaJP.Text));
            }
            else if (CBHartaNS.SelectedItem == "199  Harta lain-lain")
            {
                hartaKJP.setHartaLainLain(double.Parse(this.IsiHartaJP.Text));
            }
            else if (CBHartaNS.SelectedItem == "113.1  Akumulasi penyusutan perlengkapan")
            {
                hartaKJP.setAkumulasiPenyusutanPerlengkapan(double.Parse(this.IsiHartaJP.Text));
            }
            else if (CBHartaNS.SelectedItem == "122.1  Akumulasi penyusutan peralatan")
            {
                hartaKJP.setAkumulasiPenyusutanPeralatan(double.Parse(this.IsiHartaJP.Text));
            }
            else if (CBHartaNS.SelectedItem == "124.1  Akumulasi penyusutan gedung")
            {
                hartaKJP.setAkumulasiPenyusutanGedung(double.Parse(this.IsiHartaJP.Text));
            }
            input1.Rows.Add(CBHartaJP.Text, "0", "0", "0", IsiHartaJP.Text, "0", IsiHartaJP.Text, "0", "0", "0", IsiHartaJP.Text);
            this.dataGridView1.DataSource = input1;
            IsiHartaJP.Clear();
        }
        private void BDUtangModal_Click(object sender, EventArgs e)
        {
            data utangDJP = new data();
            data modalDJP = new data();
            if (CBUtangModalJP.SelectedItem == "211  Utang usaha")
            {
                utangDJP.setUtangUsaha(double.Parse(this.IsiUtangModalJP.Text));
                input1.Rows.Add(CBUtangModalJP.Text, "0", "0", IsiUtangModalJP.Text, "0", IsiUtangModalJP.Text, "0", "0", "0", IsiUtangModalJP.Text, "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBUtangModalJP.SelectedItem == "215  Asuransi diterima dimuka")
            {
                utangDJP.setAsuransiDiterimaDimuka(double.Parse(this.IsiUtangModalJP.Text));
                input1.Rows.Add(CBUtangModalJP.Text, "0", "0", IsiUtangModalJP.Text, "0", IsiUtangModalJP.Text, "0", "0", "0", IsiUtangModalJP.Text, "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBUtangModalJP.SelectedItem == "216  Sewa diterima dimuka")
            {
                utangDJP.setSewaDiterimaDimuka(double.Parse(this.IsiUtangModalJP.Text));
                input1.Rows.Add(CBUtangModalJP.Text, "0", "0", IsiUtangModalJP.Text, "0", IsiUtangModalJP.Text, "0", "0", "0", IsiUtangModalJP.Text, "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBUtangModalJP.SelectedItem == "219  Utang jangka pendek lain-lain")
            {
                utangDJP.setUtangJangkaPendekLainLain(double.Parse(this.IsiUtangModalJP.Text));
                input1.Rows.Add(CBUtangModalJP.Text, "0", "0", IsiUtangModalJP.Text, "0", IsiUtangModalJP.Text, "0", "0", "0", IsiUtangModalJP.Text, "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBUtangModalJP.SelectedItem == "221  Utang obligasi")
            {
                utangDJP.setUtangObligasi(double.Parse(this.IsiUtangModalJP.Text));
                input1.Rows.Add(CBUtangModalJP.Text, "0", "0", IsiUtangModalJP.Text, "0", IsiUtangModalJP.Text, "0", "0", "0", IsiUtangModalJP.Text, "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBUtangModalJP.SelectedItem == "222  Utang hipotik")
            {
                utangDJP.setUtangHipotik(double.Parse(this.IsiUtangModalJP.Text));
                input1.Rows.Add(CBUtangModalJP.Text, "0", "0", IsiUtangModalJP.Text, "0", IsiUtangModalJP.Text, "0", "0", "0", IsiUtangModalJP.Text, "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBUtangModalJP.SelectedItem == "202  Utang gaji")
            {
                utangDJP.setUtangGaji(double.Parse(this.IsiUtangModalJP.Text));
                input1.Rows.Add(CBUtangModalJP.Text, "0", "0", IsiUtangModalJP.Text, "0", IsiUtangModalJP.Text, "0", "0", "0", IsiUtangModalJP.Text, "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBUtangModalJP.SelectedItem == "203  Utang pajak")
            {
                utangDJP.setUtangPajak(double.Parse(this.IsiUtangModalJP.Text));
                input1.Rows.Add(CBUtangModalJP.Text, "0", "0", IsiUtangModalJP.Text, "0", IsiUtangModalJP.Text, "0", "0", "0", IsiUtangModalJP.Text, "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBUtangModalJP.SelectedItem == "311  Modal pemilik")
            {
                modalDJP.setModalPemilik(double.Parse(this.IsiUtangModalJP.Text));
                input1.Rows.Add(CBUtangModalJP.Text, "0", "0", IsiUtangModalJP.Text, "0", IsiUtangModalJP.Text, "0", "0", "0", IsiUtangModalJP.Text, "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBUtangModalJP.SelectedItem == "312  Prive pemilik")
            {
                modalDJP.setPrivePemilik(double.Parse(this.IsiUtangModalJP.Text));
                input1.Rows.Add(CBUtangModalJP.Text, "0", "0", IsiUtangModalJP.Text, "0", IsiUtangModalJP.Text, "0", "0", "0", IsiUtangModalJP.Text, "0");
                this.dataGridView1.DataSource = input1;
            }
            IsiUtangModalJP.Clear();
        }
        private void BKUtangModal_Click(object sender, EventArgs e)
        {
            data utangKJP = new data();
            data modalKJP = new data();
            if (CBUtangModalJP.SelectedItem == "211  Utang usaha")
            {
                utangKJP.setUtangUsaha(double.Parse(this.IsiUtangModalJP.Text));
                input1.Rows.Add(CBUtangModalJP.Text, "0", "0", "0", IsiUtangModalJP.Text, "0", IsiUtangModalJP.Text, "0", "0", "0", IsiUtangModalJP.Text);
                this.dataGridView1.DataSource = input1;
            }
            else if (CBUtangModalJP.SelectedItem == "215  Asuransi diterima dimuka")
            {
                utangKJP.setAsuransiDiterimaDimuka(double.Parse(this.IsiUtangModalJP.Text));
                input1.Rows.Add(CBUtangModalJP.Text, "0", "0", "0", IsiUtangModalJP.Text, "0", IsiUtangModalJP.Text, "0", "0", "0", IsiUtangModalJP.Text);
                this.dataGridView1.DataSource = input1;
            }
            else if (CBUtangModalJP.SelectedItem == "216  Sewa diterima dimuka")
            {
                utangKJP.setSewaDiterimaDimuka(double.Parse(this.IsiUtangModalJP.Text));
                input1.Rows.Add(CBUtangModalJP.Text, "0", "0", "0", IsiUtangModalJP.Text, "0", IsiUtangModalJP.Text, "0", "0", "0", IsiUtangModalJP.Text);
                this.dataGridView1.DataSource = input1;
            }
            else if (CBUtangModalJP.SelectedItem == "219  Utang jangka pendek lain-lain")
            {
                utangKJP.setUtangJangkaPendekLainLain(double.Parse(this.IsiUtangModalJP.Text));
                input1.Rows.Add(CBUtangModalJP.Text, "0", "0", "0", IsiUtangModalJP.Text, "0", IsiUtangModalJP.Text, "0", "0", "0", IsiUtangModalJP.Text);
                this.dataGridView1.DataSource = input1;
            }
            else if (CBUtangModalJP.SelectedItem == "221  Utang obligasi")
            {
                utangKJP.setUtangObligasi(double.Parse(this.IsiUtangModalJP.Text));
                input1.Rows.Add(CBUtangModalJP.Text, "0", "0", "0", IsiUtangModalJP.Text, "0", IsiUtangModalJP.Text, "0", "0", "0", IsiUtangModalJP.Text);
                this.dataGridView1.DataSource = input1;
            }
            else if (CBUtangModalJP.SelectedItem == "222  Utang hipotik")
            {
                utangKJP.setUtangHipotik(double.Parse(this.IsiUtangModalJP.Text));
                input1.Rows.Add(CBUtangModalJP.Text, "0", "0", "0", IsiUtangModalJP.Text, "0", IsiUtangModalJP.Text, "0", "0", "0", IsiUtangModalJP.Text);
                this.dataGridView1.DataSource = input1;
            }
            else if (CBUtangModalJP.SelectedItem == "202  Utang gaji")
            {
                utangKJP.setUtangGaji(double.Parse(this.IsiUtangModalJP.Text));
                input1.Rows.Add(CBUtangModalJP.Text, "0", "0", "0", IsiUtangModalJP.Text, "0", IsiUtangModalJP.Text, "0", "0", "0", IsiUtangModalJP.Text);
                this.dataGridView1.DataSource = input1;
            }
            else if (CBUtangModalJP.SelectedItem == "203  Utang pajak")
            {
                utangKJP.setUtangPajak(double.Parse(this.IsiUtangModalJP.Text));
                input1.Rows.Add(CBUtangModalJP.Text, "0", "0", "0", IsiUtangModalJP.Text, "0", IsiUtangModalJP.Text, "0", "0", "0", IsiUtangModalJP.Text);
                this.dataGridView1.DataSource = input1;
            }           else if (CBUtangModalJP.SelectedItem == "311  Modal pemilik")
            {
                modalKJP.setModalPemilik(double.Parse(this.IsiUtangModalJP.Text));
                input1.Rows.Add(CBUtangModalJP.Text, "0", "0", "0", IsiUtangModalJP.Text, "0", IsiUtangModalJP.Text, "0", "0", "0", IsiUtangModalJP.Text);
                this.dataGridView1.DataSource = input1;
            }
            else if (CBUtangModalJP.SelectedItem == "312  Prive pemilik")
            {
                modalKJP.setPrivePemilik(double.Parse(this.IsiUtangModalJP.Text));
                input1.Rows.Add(CBUtangModalJP.Text, "0", "0", "0", IsiUtangModalJP.Text, "0", IsiUtangModalJP.Text, "0", "0", "0", IsiUtangModalJP.Text);
                this.dataGridView1.DataSource = input1;
            }
            IsiUtangModalJP.Clear();
        }
        private void BDPendapatanBeban_Click(object sender, EventArgs e)
        {
            data pendapatanDJP = new data();
            data bebanDJP = new data();
            if (CBPendapatanBebanJP.SelectedItem == "411  Pendapatan usaha")
            {
                pendapatanDJP.setPendapatanUsaha(double.Parse(this.IsiPendapatanBebanJP.Text));
                input1.Rows.Add(CBPendapatanBebanJP.Text, "0", "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", "0", "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBPendapatanBebanJP.SelectedItem == "412  Pendapatan lain-lain")
            {
                pendapatanDJP.setPendapatanLainLain(double.Parse(this.IsiPendapatanBebanJP.Text));
                input1.Rows.Add(CBPendapatanBebanJP.Text, "0", "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", "0", "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBPendapatanBebanJP.SelectedItem == "511  Beban gaji")
            {
                bebanDJP.setBebanGaji(double.Parse(this.IsiPendapatanBebanJP.Text));
                input1.Rows.Add(CBPendapatanBebanJP.Text, "0", "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", "0", "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBPendapatanBebanJP.SelectedItem == "512  Beban air, listrik, dan telepon")
            {
                bebanDJP.setBebanAirListrikTelepon(double.Parse(this.IsiPendapatanBebanJP.Text));
                input1.Rows.Add(CBPendapatanBebanJP.Text, "0", "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", "0", "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBPendapatanBebanJP.SelectedItem == "513  Beban pajak")
            {
                bebanDJP.setBebanPajak(double.Parse(this.IsiPendapatanBebanJP.Text));
                input1.Rows.Add(CBPendapatanBebanJP.Text, "0", "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", "0", "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBPendapatanBebanJP.SelectedItem == "514  Beban bunga")
            {
                bebanDJP.setBebanBunga(double.Parse(this.IsiPendapatanBebanJP.Text));
                input1.Rows.Add(CBPendapatanBebanJP.Text, "0", "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", "0", "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBPendapatanBebanJP.SelectedItem == "515  Beban lain-lain")
            {
                bebanDJP.setBebanLainLain(double.Parse(this.IsiPendapatanBebanJP.Text));
                input1.Rows.Add(CBPendapatanBebanJP.Text, "0", "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", "0", "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBPendapatanBebanJP.SelectedItem == "502  Beban perlengkapan")
            {
                bebanDJP.setBebanPerlengkapan(double.Parse(this.IsiPendapatanBebanJP.Text));
                input1.Rows.Add(CBPendapatanBebanJP.Text, "0", "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", "0", "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBPendapatanBebanJP.SelectedItem == "503  Beban peralatan")
            {
                bebanDJP.setBebanPeralatan(double.Parse(this.IsiPendapatanBebanJP.Text));
                input1.Rows.Add(CBPendapatanBebanJP.Text, "0", "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", "0", "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBPendapatanBebanJP.SelectedItem == "504  Beban penyusutan perlengkapan")
            {
                bebanDJP.setBebanPenyusutanPerlengkapan(double.Parse(this.IsiPendapatanBebanJP.Text));
                input1.Rows.Add(CBPendapatanBebanJP.Text, "0", "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", "0", "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBPendapatanBebanJP.SelectedItem == "505  Beban penyusutan peralatan")
            {
                bebanDJP.setBebanPenyusutanPeralatan(double.Parse(this.IsiPendapatanBebanJP.Text));
                input1.Rows.Add(CBPendapatanBebanJP.Text, "0", "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", "0", "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBPendapatanBebanJP.SelectedItem == "506  Beban sewa")
            {
                bebanDJP.setBebanSewa(double.Parse(this.IsiPendapatanBebanJP.Text));
                input1.Rows.Add(CBPendapatanBebanJP.Text, "0", "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", "0", "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBPendapatanBebanJP.SelectedItem == "631  Pajak penghasilan")
            {
                bebanDJP.setPajakPenghasilan(double.Parse(this.IsiPendapatanBebanJP.Text));
                input1.Rows.Add(CBPendapatanBebanJP.Text, "0", "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", "0", "0");
                this.dataGridView1.DataSource = input1;
            }
            IsiPendapatanBebanJP.Clear();
        }
        private void BKPendapatanBeban_Click(object sender, EventArgs e)
        {
            data pendapatanKJP = new data();
            data bebanKJP = new data();
            if (CBPendapatanBebanJP.SelectedItem == "411  Pendapatan usaha")
            {
                pendapatanKJP.setPendapatanUsaha(double.Parse(this.IsiPendapatanBebanJP.Text));
                input1.Rows.Add(CBPendapatanBebanJP.Text, "0", "0", "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBPendapatanBebanJP.SelectedItem == "412  Pendapatan lain-lain")
            {
                pendapatanKJP.setPendapatanLainLain(double.Parse(this.IsiPendapatanBebanJP.Text));
                input1.Rows.Add(CBPendapatanBebanJP.Text, "0", "0", "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBPendapatanBebanJP.SelectedItem == "511  Beban gaji")
            {
                bebanKJP.setBebanGaji(double.Parse(this.IsiPendapatanBebanJP.Text));
                input1.Rows.Add(CBPendapatanBebanJP.Text, "0", "0", "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBPendapatanBebanJP.SelectedItem == "512  Beban air, listrik, dan telepon")
            {
                bebanKJP.setBebanAirListrikTelepon(double.Parse(this.IsiPendapatanBebanJP.Text));
                input1.Rows.Add(CBPendapatanBebanJP.Text, "0", "0", "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBPendapatanBebanJP.SelectedItem == "513  Beban pajak")
            {
                bebanKJP.setBebanPajak(double.Parse(this.IsiPendapatanBebanJP.Text));
                input1.Rows.Add(CBPendapatanBebanJP.Text, "0", "0", "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBPendapatanBebanJP.SelectedItem == "514  Beban bunga")
            {
                bebanKJP.setBebanBunga(double.Parse(this.IsiPendapatanBebanJP.Text));
                input1.Rows.Add(CBPendapatanBebanJP.Text, "0", "0", "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBPendapatanBebanJP.SelectedItem == "515  Beban lain-lain")
            {
                bebanKJP.setBebanLainLain(double.Parse(this.IsiPendapatanBebanJP.Text));
                input1.Rows.Add(CBPendapatanBebanJP.Text, "0", "0", "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBPendapatanBebanJP.SelectedItem == "502  Beban perlengkapan")
            {
                bebanKJP.setBebanPerlengkapan(double.Parse(this.IsiPendapatanBebanJP.Text));
                input1.Rows.Add(CBPendapatanBebanJP.Text, "0", "0", "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBPendapatanBebanJP.SelectedItem == "503  Beban peralatan")
            {
                bebanKJP.setBebanPeralatan(double.Parse(this.IsiPendapatanBebanJP.Text));
                input1.Rows.Add(CBPendapatanBebanJP.Text, "0", "0", "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBPendapatanBebanJP.SelectedItem == "504  Beban penyusutan perlengkapan")
            {
                bebanKJP.setBebanPenyusutanPerlengkapan(double.Parse(this.IsiPendapatanBebanJP.Text));
                input1.Rows.Add(CBPendapatanBebanJP.Text, "0", "0", "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBPendapatanBebanJP.SelectedItem == "505  Beban penyusutan peralatan")
            {
                bebanKJP.setBebanPenyusutanPeralatan(double.Parse(this.IsiPendapatanBebanJP.Text));
                input1.Rows.Add(CBPendapatanBebanJP.Text, "0", "0", "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBPendapatanBebanJP.SelectedItem == "506  Beban sewa")
            {
                bebanKJP.setBebanSewa(double.Parse(this.IsiPendapatanBebanJP.Text));
                input1.Rows.Add(CBPendapatanBebanJP.Text, "0", "0", "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", "0");
                this.dataGridView1.DataSource = input1;
            }
            else if (CBPendapatanBebanJP.SelectedItem == "631  Pajak penghasilan")
            {
                bebanKJP.setPajakPenghasilan(double.Parse(this.IsiPendapatanBebanJP.Text));
                input1.Rows.Add(CBPendapatanBebanJP.Text, "0", "0", "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", IsiPendapatanBebanJP.Text, "0", "0");
                this.dataGridView1.DataSource = input1;
            }
            IsiPendapatanBebanJP.Clear();
        }

        private void ResetNS_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            
        }

        public void Hasil_Click(object sender, EventArgs e)
        {
            double totalNSDd = 0;
            for (int i = 0; i < dataGridView1.RowCount - 2; i++)
            {
                var value = dataGridView1.Rows[i].Cells[5].Value;
                if (value != DBNull.Value)
                {
                    totalNSDd += Convert.ToDouble(value);
                }
            }
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[5].Value = totalNSDd.ToString();
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[5].Style.ForeColor = Color.Blue;
            double totalNSDk = 0;
            for (int i = 0; i < dataGridView1.RowCount - 2; i++)
            {
                var value = dataGridView1.Rows[i].Cells[6].Value;
                if (value != DBNull.Value)
                {
                    totalNSDk += Convert.ToDouble(value);
                }
            }
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[6].Value = totalNSDk.ToString();
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[6].Style.ForeColor = Color.Blue;
            double totalLRd = 0;
            for (int i = 0; i < dataGridView1.RowCount - 2; i++)
            {
                var value = dataGridView1.Rows[i].Cells[7].Value;
                if (value != DBNull.Value)
                {
                    totalLRd += Convert.ToDouble(value);
                }
            }
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[7].Value = totalLRd.ToString();
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[7].Style.ForeColor = Color.Blue;
            double totalLRk = 0;
            for (int i = 0; i < dataGridView1.RowCount - 2; i++)
            {
                var value = dataGridView1.Rows[i].Cells[8].Value;
                if (value != DBNull.Value)
                {
                    totalLRk += Convert.ToDouble(value);
                }
            }
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[8].Value = totalLRk.ToString();
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[8].Style.ForeColor = Color.Blue;
            double totalLNd = 0;
            for (int i = 0; i < dataGridView1.RowCount - 2; i++)
            {
                var value = dataGridView1.Rows[i].Cells[9].Value;
                if (value != DBNull.Value)
                {
                    totalLNd += Convert.ToDouble(value);
                }
            }
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[9].Value = totalLNd.ToString();
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[9].Style.ForeColor = Color.Blue;
            double totalLNk = 0;
            for (int i = 0; i < dataGridView1.RowCount - 2; i++)
            {
                var value = dataGridView1.Rows[i].Cells[10].Value;
                if (value != DBNull.Value)
                {
                    totalLNk += Convert.ToDouble(value);
                }
            }
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[10].Value = totalLNk.ToString();
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[10].Style.ForeColor = Color.Blue;
            dataGridView1[0, dataGridView1.Rows.Count - 1].Value = "LABA / RUGI";
            double LR;
            if (totalLRd <= totalLRk)
            {
                LR = totalLRk - totalLRd;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[7].Value = LR.ToString();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[7].Style.ForeColor = Color.Green;
            }
            else if (totalLRk < totalLRd)
            {
                LR = totalLRd - totalLRk;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[8].Value = LR.ToString();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[8].Style.ForeColor = Color.Red;
            }
            double LN;
            if (totalLNd < totalLNk)
            {
                LN = totalLNk - totalLNd;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[9].Value = LN.ToString();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[9].Style.ForeColor = Color.Red;
            }
            else if (totalLNk <= totalLNd)
            {
                LN = totalLNd - totalLNk;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[10].Value = LN.ToString();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[10].Style.ForeColor = Color.Green;
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}