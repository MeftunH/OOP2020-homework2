
/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:3
**				ÖĞRENCİ ADI............:MAFTUN HASHIMLI
**				ÖĞRENCİ NUMARASI.......:G181210554
**                         DERSİN ALINDIĞI GRUP...:2C
****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_ODEV3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        //Sepet nesnesi olusturuldu
        Sepet sepet = new Sepet();

      

        private void Form1_Load(object sender, EventArgs e)
        {
       
            //baslangic stoklari atanadi
            lbltelevizyonstok.Text = sepet.urunbasangicliste[0].StokAdedi.ToString();
            lblbuzdolabistok.Text = sepet.urunbasangicliste[1].StokAdedi.ToString();
            lbllaptopstok.Text = sepet.urunbasangicliste[2].StokAdedi.ToString();
            lbltelefonstok.Text = sepet.urunbasangicliste[3].StokAdedi.ToString();
            lbltlvzynfiyat.Text = sepet.urunbasangicliste[0].Hamfiyat.ToString();
            lblbzdlbifiyat.Text = sepet.urunbasangicliste[1].Hamfiyat.ToString();
            lbllaptopfiyat.Text = sepet.urunbasangicliste[2].Hamfiyat.ToString();
            lbltelefonfiyat.Text = sepet.urunbasangicliste[3].Hamfiyat.ToString();
            
        }
           
        private void btnsepeteekle_Click(object sender, EventArgs e)
        {
            //eger alinmaya calisilan deger,stokdan fazlaysa alinmamasi saglandi
            if (lstadet.Items.Count > 0 || lstkvlifiyat.Items.Count > 0 || lstUrun.Items.Count > 0)
            {
                MessageBox.Show("Lutfen once sepeti bosaltiniz");
            }
            
            else
            {//ekleme kontrolleri yapildi

                sepet.urunbasangicliste[0].SecilenAdet = (int)nmrctv.Value;
                sepet.urunbasangicliste[1].SecilenAdet = (int)nmrcbzdlbi.Value;
                sepet.urunbasangicliste[2].SecilenAdet = (int)nmrclaptop.Value;
                sepet.urunbasangicliste[3].SecilenAdet = (int)nmrctelefon.Value;

                if (sepet.urunbasangicliste[0].SecilenAdet > sepet.urunbasangicliste[0].StokAdedi)
                {
                    MessageBox.Show("Lutfen stok miktarindan daha fazla urun almaya calismayin");
                }
                else
                {
                    if ((int)nmrctv.Value > 0)
                    {
                        sepet.SepeteUrunEkle(sepet.ledtv);

                        if (sepet.urunliste.Count > 0)
                        {
                            if (sepet.urunliste.Contains(sepet.ledtv))
                            {
                                sepet.urunliste[0].SecilenAdet = (int)nmrctv.Value;
                                lstadet.Items.Add(sepet.urunliste[0].SecilenAdet);
                                lstUrun.Items.Add(sepet.urunliste[0].Ad);
                                lstkvlifiyat.Items.Add(sepet.Kdvlifiyat(sepet.urunliste[0]));
                                lbltelevizyonstok.Text = sepet.urunliste[0].StokAdedi.ToString();

                            }

                        }

                    }
                }
                if (sepet.urunbasangicliste[1].SecilenAdet > sepet.urunbasangicliste[1].StokAdedi)
                {
                    MessageBox.Show("Lutfen stok miktarindan daha fazla urun almaya calismayin");
                }
                else
                {
                    if ((int)nmrcbzdlbi.Value > 0)
                    {
                        sepet.SepeteUrunEkle(sepet.buzdolabi);
                        if (sepet.urunliste.Count >= 2)
                        {
                            if (sepet.urunliste.Contains(sepet.buzdolabi))
                            {
                                sepet.urunliste[1].SecilenAdet = (int)nmrcbzdlbi.Value;
                                lstadet.Items.Add(sepet.urunliste[1].SecilenAdet);
                                lstUrun.Items.Add(sepet.urunliste[1].Ad);
                                lstkvlifiyat.Items.Add(sepet.Kdvlifiyat(sepet.urunliste[1]));
                                lblbuzdolabistok.Text = sepet.urunliste[1].StokAdedi.ToString();
                            }

                        }
                        if (sepet.urunliste.Count < 2)
                        {
                            if (sepet.urunliste.Contains(sepet.buzdolabi))
                            {
                                sepet.urunliste[0].SecilenAdet = (int)nmrcbzdlbi.Value;
                                lstadet.Items.Add(sepet.urunliste[0].SecilenAdet);
                                lstUrun.Items.Add(sepet.urunliste[0].Ad);
                                lstkvlifiyat.Items.Add(sepet.Kdvlifiyat(sepet.urunliste[0]));
                                lblbuzdolabistok.Text = sepet.urunliste[0].StokAdedi.ToString();
                            }
                        }

                    }
                }
                if (sepet.urunbasangicliste[2].SecilenAdet > sepet.urunbasangicliste[2].StokAdedi)
                {
                    MessageBox.Show("Lutfen stok miktarindan daha fazla urun almaya calismayin");
                }
                else
                {
                    if ((int)nmrclaptop.Value > 0)
                    {

                        sepet.SepeteUrunEkle(sepet.laptop);
                        if (sepet.urunliste.Count < 2)
                        {
                            if (sepet.urunliste.Contains(sepet.laptop))
                            {
                                sepet.urunliste[0].SecilenAdet = (int)nmrclaptop.Value;
                                lstadet.Items.Add(sepet.urunliste[0].SecilenAdet);
                                lstUrun.Items.Add(sepet.urunliste[0].Ad);
                                lstkvlifiyat.Items.Add(sepet.Kdvlifiyat(sepet.urunliste[0]));
                                lbllaptopstok.Text = sepet.urunliste[0].StokAdedi.ToString();
                            }
                        }

                        if (sepet.urunliste.Count == 2)
                        {
                            if (sepet.urunliste.Contains(sepet.laptop))
                            {
                                if (sepet.urunliste.Contains(sepet.ledtv) || sepet.urunliste.Contains(sepet.laptop))
                                {
                                    sepet.urunliste[1].SecilenAdet = (int)nmrclaptop.Value;
                                    lstadet.Items.Add(sepet.urunliste[1].SecilenAdet);
                                    lstUrun.Items.Add(sepet.urunliste[1].Ad);
                                    lstkvlifiyat.Items.Add(sepet.Kdvlifiyat(sepet.urunliste[1]));
                                    lbllaptopstok.Text = sepet.urunliste[1].StokAdedi.ToString();
                                }
                                else
                                {
                                    sepet.urunliste[0].SecilenAdet = (int)nmrclaptop.Value;
                                    lstadet.Items.Add(sepet.urunliste[0].SecilenAdet);
                                    lstUrun.Items.Add(sepet.urunliste[0].Ad);
                                    lstkvlifiyat.Items.Add(sepet.Kdvlifiyat(sepet.urunliste[0]));
                                    lbllaptopstok.Text = sepet.urunliste[0].StokAdedi.ToString();
                                }
                            }

                        }
                        if (sepet.urunliste.Count > 2 && sepet.urunliste.Contains(sepet.laptop))
                        {
                            sepet.urunliste[2].SecilenAdet = (int)nmrclaptop.Value;
                            lstadet.Items.Add(sepet.urunliste[2].SecilenAdet);
                            lstUrun.Items.Add(sepet.urunliste[2].Ad);
                            lstkvlifiyat.Items.Add(sepet.Kdvlifiyat(sepet.urunliste[2]));
                            lbllaptopstok.Text = sepet.urunliste[2].StokAdedi.ToString();
                        }

                    }
                }
                if (sepet.urunbasangicliste[3].SecilenAdet > sepet.urunbasangicliste[3].StokAdedi)
                {
                    MessageBox.Show("Lutfen stok miktarindan daha fazla urun almaya calismayin");
                }
                else
                {

                    if ((int)nmrctelefon.Value > 0)
                    {
                        sepet.SepeteUrunEkle(sepet.ceptel);
                        if (sepet.urunliste.Contains(sepet.ceptel))
                        {
                            if (sepet.urunliste.Count < 2)
                            {
                                sepet.urunliste[0].SecilenAdet = (int)nmrctelefon.Value;
                                lstadet.Items.Add(sepet.urunliste[0].SecilenAdet);
                                lstUrun.Items.Add(sepet.urunliste[0].Ad);
                                lstkvlifiyat.Items.Add(sepet.Kdvlifiyat(sepet.urunliste[0]));
                                lbltelefonstok.Text = sepet.urunliste[0].StokAdedi.ToString();

                            }
                            if (sepet.urunliste.Count == 2)
                            {
                                sepet.urunliste[1].SecilenAdet = (int)nmrctelefon.Value;
                                lstadet.Items.Add(sepet.urunliste[1].SecilenAdet);
                                lstUrun.Items.Add(sepet.urunliste[1].Ad);
                                lstkvlifiyat.Items.Add(sepet.Kdvlifiyat(sepet.urunliste[1]));
                                lbltelefonstok.Text = sepet.urunliste[1].StokAdedi.ToString();

                            }
                            if (sepet.urunliste.Count == 3)
                            {
                                sepet.urunliste[2].SecilenAdet = (int)nmrctelefon.Value;
                                lstadet.Items.Add(sepet.urunliste[2].SecilenAdet);
                                lstUrun.Items.Add(sepet.urunliste[2].Ad);
                                lstkvlifiyat.Items.Add(sepet.Kdvlifiyat(sepet.urunliste[2]));
                                lbltelefonstok.Text = sepet.urunliste[2].StokAdedi.ToString();

                            }
                            if (sepet.urunliste.Count == 4)
                            {
                                sepet.urunliste[3].SecilenAdet = (int)nmrctelefon.Value;
                                lstadet.Items.Add(sepet.urunliste[3].SecilenAdet);
                                lstUrun.Items.Add(sepet.urunliste[3].Ad);
                                lstkvlifiyat.Items.Add(sepet.Kdvlifiyat(sepet.urunliste[3]));
                                lbltelefonstok.Text = sepet.urunliste[3].StokAdedi.ToString();

                            }
                        }

                    }
                }
        }
            //kdvlitoplamdeger yazildi
            lblkdvlifyat.Text = sepet.kdvlitoplamfiyat(sepet.urunliste).ToString();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnsepetitemizle_Click(object sender, EventArgs e)
        {
            //silme islemleri yapildi
            lstadet.Items.Clear();
            lstUrun.Items.Clear();
            lstkvlifiyat.Items.Clear();
            lblkdvlifyat.Text = "";           
            sepet.SepetiTemizle();
            lbltelevizyonstok.Text = sepet.urunbasangicliste[0].StokAdedi.ToString();
            lblbuzdolabistok.Text = sepet.urunbasangicliste[1].StokAdedi.ToString();
            lbllaptopstok.Text = sepet.urunbasangicliste[2].StokAdedi.ToString();
            lbltelefonstok.Text = sepet.urunbasangicliste[3].StokAdedi.ToString();
        }
    }
}
