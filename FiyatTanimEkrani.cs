using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InfoTechWFAPizzaSiparisUygulamasi07012024
{
    public partial class FiyatTanimEkrani : Form
    {
        public FiyatTanimEkrani()
        {
            InitializeComponent();
        }

        public void FiyatTanimEkrani_Load(object sender, EventArgs e)
        {

        }

        private void btn_sipariseGec_Click(object sender, EventArgs e)
        {
            this.Hide();
            SiparisEkraniAc();
        }

        void SiparisEkraniAc()
        {
            Fiyatlar fiyatlar = new Fiyatlar();

            try
            {
                fiyatlar._kucukBoy = Convert.ToDouble(txt_kucukBoy.Text);
                fiyatlar._ortaBoy = Convert.ToDouble(txt_ortaBoy.Text);
                fiyatlar._buyukBoy = Convert.ToDouble(txt_buyukBoy.Text);
                fiyatlar._sucuk = Convert.ToDouble(txt_sucuk.Text);
                fiyatlar._kasar = Convert.ToDouble(txt_kasar.Text);
                fiyatlar._sosis = Convert.ToDouble(txt_sosis.Text);
                fiyatlar._mozarella = Convert.ToDouble(txt_mozarella.Text);
                fiyatlar._mantar = Convert.ToDouble(txt_mantar.Text);
                fiyatlar._sebze = Convert.ToDouble(txt_sebze.Text);
                fiyatlar._kola = Convert.ToDouble(txt_kola.Text);
                fiyatlar._fanta = Convert.ToDouble(txt_fanta.Text);
                fiyatlar._icetea = Convert.ToDouble(txt_icetea.Text);
                fiyatlar._ayran = Convert.ToDouble(txt_ayran.Text);
                fiyatlar._sprite = Convert.ToDouble(txt_sprite.Text);
                fiyatlar._su = Convert.ToDouble(txt_su.Text);
                fiyatlar._kolaLt = Convert.ToDouble(txt_kolaLt.Text);
                fiyatlar._fantaLt = Convert.ToDouble(txt_fantaLt.Text);
                fiyatlar._ayranLt = Convert.ToDouble(txt_ayranLt.Text);

                SiparisEkrani siparisEkrani = new SiparisEkrani();
                siparisEkrani.SiparisHesapla(fiyatlar._kucukBoy, fiyatlar._ortaBoy, fiyatlar._buyukBoy, fiyatlar._sucuk, fiyatlar._kasar, fiyatlar._sosis, fiyatlar._mozarella, fiyatlar._mantar, fiyatlar._sebze, fiyatlar._kola, fiyatlar._fanta, fiyatlar._icetea, fiyatlar._ayran, fiyatlar._sprite, fiyatlar._su, fiyatlar._kolaLt, fiyatlar._fantaLt, fiyatlar._ayranLt);
                siparisEkrani.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
