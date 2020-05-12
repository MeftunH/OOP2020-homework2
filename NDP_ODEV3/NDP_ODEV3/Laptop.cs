
/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**	
**				ÖDEV NUMARASI..........:3
**				ÖĞRENCİ ADI............:MAFTUN HASHIMLI
**				ÖĞRENCİ NUMARASI.......:G181210554
**                         DERSİN ALINDIĞI GRUP...:2C
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_ODEV3
{
    class Laptop : Urun
    {
        public string EkranBoyutu { get; set; }
        public string EkranCozunurluk { get; set; }
        public string DahiliHafiza { get; set; }
        public string ramKapasitesi { get; set; }
        public string Pilgucu { get; set; }
        public Laptop(string Ad, string Marka, string Model, string Ozellik, int Hamfiyat, int SecilenAdet, string EkranBoyutu, string EkranCozunurluk, string DahiliHafiza, string ramKapasitesi, string Pilgucu) : base(Ad, Marka, Model, Ozellik, Hamfiyat, SecilenAdet)
        {
            this.EkranBoyutu = EkranBoyutu;
            this.EkranCozunurluk = EkranCozunurluk;
            this.DahiliHafiza = DahiliHafiza;
            this.ramKapasitesi = ramKapasitesi;
            this.Pilgucu = Pilgucu;
        }
        public override double KdvUygula()
        {
            return Hamfiyat * 1.15 * SecilenAdet;
        }
    }
}
