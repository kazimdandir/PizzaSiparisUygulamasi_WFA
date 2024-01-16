using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoTechWFAPizzaSiparisUygulamasi07012024
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        string kullaniciAdi = "kazimdandir";
        string sifre = "12345";
        FiyatTanimEkrani fiyatTanimEkrani = new FiyatTanimEkrani();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txt_kullaniciAdi.Text == kullaniciAdi && txt_sifre.Text == sifre)
            {
                MessageBox.Show("Giriş Başarılı :)");
                this.Hide();
                fiyatTanimEkrani.Show();
            }
            else
            {
                txt_kullaniciAdi.Clear();
                txt_sifre.Clear();
                MessageBox.Show("Kullanıcı adı veya şifre hatalıdır. Tekrar deneyiniz.");
            }
        }
    }
}
