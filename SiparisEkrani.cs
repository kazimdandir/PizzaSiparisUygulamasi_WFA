using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace InfoTechWFAPizzaSiparisUygulamasi07012024
{
    public partial class SiparisEkrani : Form
    {
        #region Stringler
        string kucukBoyPizza = "Küçük";
        string ortaBoyPizza = "Orta";
        string buyukBoyPizza = "Büyük";

        string cola330 = "Cola(330ml)";
        string fanta330 = "Fanta(330ml)";
        string icetea = "Ice Tea(330ml)";
        string ayran330 = "Ayran(330ml)";
        string sprite = "Sprite(330ml)";
        string su = "Su(500ml)";
        string cola1Lt = "Cola(1lt)";
        string fanta1Lt = "Fanta(1lt)";
        string ayran1Lt = "Ayran(1lt)";
        #endregion

        #region Fiyatlar
        double _kucukBoyFiyat = 0;
        double _ortaBoyFiyat = 0;
        double _buyukBoyFiyat = 0;
        double _sucukFiyat = 0;
        double _kasarFiyat = 0;
        double _sosisFiyat = 0;
        double _mozarellaFiyat = 0;
        double _mantarFiyat = 0;
        double _sebzeFiyat = 0;
        double _colaFiyat = 0;
        double _fantaFiyat = 0;
        double _iceteaFiyat = 0;
        double _ayranFiyat = 0;
        double _spriteFiyat = 0;
        double _suFiyat = 0;
        double _colaLtFiyat = 0;
        double _fantaLtFiyat = 0;
        double _ayranLtFiyat = 0;
        #endregion

        Fiyatlar _fiyatlar = new Fiyatlar();

        double ucret = 0;

        public SiparisEkrani()
        {
            InitializeComponent();
        }

        public void SiparisHesapla(double kucukBoy, double ortaBoy, double buyukBoy, double sucuk, double kasar, double sosis, double mozarella, double mantar, double sebze, double cola, double fanta, double icetea, double ayran, double sprite, double su, double colaLt, double fantaLt, double ayranLt)
        {
            _kucukBoyFiyat = kucukBoy;
            _ortaBoyFiyat = ortaBoy;
            _buyukBoyFiyat = buyukBoy;
            _sucukFiyat = su;
            _kasarFiyat = kasar;
            _sosisFiyat = sosis;
            _mozarellaFiyat = mozarella;
            _mantarFiyat = mantar;
            _sebzeFiyat = sebze;
            _colaFiyat = cola;
            _fantaFiyat = fanta;
            _iceteaFiyat = icetea;
            _ayranFiyat = ayran;
            _spriteFiyat = sprite;
            _suFiyat = su;
            _colaLtFiyat = colaLt;
            _fantaLtFiyat = fantaLt;
            _ayranLtFiyat = ayranLt;

        }

        private void SiparisEkrani_Load(object sender, EventArgs e)
        {
            cmbBox_pizzaBoy.Items.Add(kucukBoyPizza);
            cmbBox_pizzaBoy.Items.Add(ortaBoyPizza);
            cmbBox_pizzaBoy.Items.Add(buyukBoyPizza);

            cmbBox_icecek.Items.Add(cola330);
            cmbBox_icecek.Items.Add(fanta330);
            cmbBox_icecek.Items.Add(icetea);
            cmbBox_icecek.Items.Add(ayran330);
            cmbBox_icecek.Items.Add(sprite);
            cmbBox_icecek.Items.Add(su);
            cmbBox_icecek.Items.Add(cola1Lt);
            cmbBox_icecek.Items.Add(fanta1Lt);
            cmbBox_icecek.Items.Add(ayran1Lt);
        }

        private void btn_sipAl_Click(object sender, EventArgs e)
        {
            lb_adSoyad.Items.Add(txt_adSoyad.Text);
            lb_telefon.Items.Add(mtb_telefon.Text);
            lb_adres.Items.Add(rtb_adres.Text);
            lb_pizzaBoyAdet.Items.Add(nUpD_pizzaAdet.Text + " adet " + cmbBox_pizzaBoy.Text);
            lb_icecekAdet.Items.Add(nUpD_icecekAdet.Text + " adet " + cmbBox_icecek.Text);

            string extra = "";

            if (cheBox_sucuk.Checked == true)
                extra += cheBox_sucuk.Text + ", ";
            if (cheBox_kasar.Checked == true)
                extra += cheBox_kasar.Text + ", ";
            if (cheBox_sosis.Checked == true)
                extra += cheBox_sosis.Text + ", ";
            if (cheBox_mozarella.Checked == true)
                extra += cheBox_mozarella.Text + ", ";
            if (cheBox_mantar.Checked == true)
                extra += cheBox_mantar.Text + ", ";
            if (cheBox_sebze.Checked == true)
                extra += cheBox_sebze.Text + ", ";

            lb_ekstra.Items.Add(extra);

            var pizzaUcreti = PizzaSecim();
            var icecekUcreti = IcecekSecim();
            var ekstraUcreti = EkstraSecim();
            var toplamUcret = pizzaUcreti + icecekUcreti + ekstraUcreti;

            lb_ucret.Items.Add(toplamUcret);
        }

        double PizzaSecim()
        {
            double _ucret = 0;

            if (cmbBox_pizzaBoy.Text == kucukBoyPizza)
                _ucret += _kucukBoyFiyat * int.Parse(nUpD_pizzaAdet.Text);
            else if (cmbBox_pizzaBoy.Text == ortaBoyPizza)
                _ucret += _ortaBoyFiyat * int.Parse(nUpD_pizzaAdet.Text);
            else if (cmbBox_pizzaBoy.Text == buyukBoyPizza)
                _ucret += _buyukBoyFiyat * int.Parse(nUpD_pizzaAdet.Text);

            return _ucret;
        }

        double IcecekSecim()
        {
            double _ucret = 0;

            if (cmbBox_icecek.Text == cola330)
                _ucret += _colaFiyat * int.Parse(nUpD_icecekAdet.Text);
            else if (cmbBox_icecek.Text == fanta330)
                _ucret += _fantaFiyat * int.Parse(nUpD_icecekAdet.Text);
            else if (cmbBox_icecek.Text == icetea)
                _ucret += _iceteaFiyat * int.Parse(nUpD_icecekAdet.Text);
            else if (cmbBox_icecek.Text == ayran330)
                _ucret += _ayranFiyat * int.Parse(nUpD_icecekAdet.Text);
            else if (cmbBox_icecek.Text == sprite)
                _ucret += _spriteFiyat * int.Parse(nUpD_icecekAdet.Text);
            else if (cmbBox_icecek.Text == su)
                _ucret += _suFiyat * int.Parse(nUpD_icecekAdet.Text);
            else if (cmbBox_icecek.Text == cola1Lt)
                _ucret += _colaLtFiyat * int.Parse(nUpD_icecekAdet.Text);
            else if (cmbBox_icecek.Text == fanta1Lt)
                _ucret += _fantaLtFiyat * int.Parse(nUpD_icecekAdet.Text);
            else if (cmbBox_icecek.Text == ayran1Lt)
                _ucret += _ayranLtFiyat * int.Parse(nUpD_icecekAdet.Text);

            return _ucret;
        }

        double EkstraSecim()
        {
            double _ucret = 0;

            if (cheBox_sucuk.Checked == true)
                _ucret += _sucukFiyat * int.Parse(nUpD_pizzaAdet.Text);
            if (cheBox_kasar.Checked == true)
                _ucret += _kasarFiyat * int.Parse(nUpD_pizzaAdet.Text);
            if (cheBox_sosis.Checked == true)
                _ucret += _sosisFiyat * int.Parse(nUpD_pizzaAdet.Text);
            if (cheBox_mozarella.Checked == true)
                _ucret += _mozarellaFiyat * int.Parse(nUpD_pizzaAdet.Text);
            if (cheBox_mantar.Checked == true)
                _ucret += _mantarFiyat * int.Parse(nUpD_pizzaAdet.Text);
            if (cheBox_sebze.Checked == true)
                _ucret += _sebzeFiyat * int.Parse(nUpD_pizzaAdet.Text);

            return _ucret;
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_adSoyad.Clear();
            mtb_telefon.Clear();
            cmbBox_pizzaBoy.Text = "";
            cmbBox_icecek.Text = "";
            rtb_adres.Clear();
            nUpD_pizzaAdet.Value = 1;
            nUpD_icecekAdet.Value = 1;
            cheBox_sucuk.Checked = false;
            cheBox_kasar.Checked = false;
            cheBox_sosis.Checked = false;
            cheBox_mozarella.Checked = false;
            cheBox_mantar.Checked = false;
            cheBox_sebze.Checked = false;
        }

        private void btn_sipTemizle_Click(object sender, EventArgs e)
        {
            lb_adSoyad.Items.Clear();
            lb_telefon.Items.Clear();
            lb_adres.Items.Clear();
            lb_pizzaBoyAdet.Items.Clear();
            lb_ekstra.Items.Clear();
            lb_icecekAdet.Items.Clear();
            lb_ucret.Items.Clear();
        }
    }
}

