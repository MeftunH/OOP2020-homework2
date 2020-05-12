
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
     class LedTv :Urun
    {
      
      public  string EkranBoyutu { get; set; }
      public string EkranCozunurlugu { get; set; } 
        public LedTv(string Ad, string Marka, string Model, string Ozellik, int Hamfiyat, int SecilenAdet,string EkranBoyutu,string EkranCozunurlugu) : base(Ad,Marka,Model,Ozellik,Hamfiyat,SecilenAdet)
        {
          // Urun u=new Urun(string Ad, string Marka, string Model, string Ozellik, int Hamfiyat, int SecilenAdet)
            this.EkranBoyutu = EkranBoyutu;
            this.EkranCozunurlugu = EkranCozunurlugu;
            StokAdedi= StokAdedi;
        }
        public override double KdvUygula()
        {
            return Hamfiyat * 1.18 * SecilenAdet;
        }
    }
}
