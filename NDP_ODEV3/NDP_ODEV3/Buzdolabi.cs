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
    class Buzdolabi : Urun
    {
        public int IcHacim { get; set; }
        public string EnerjiSinifi { get; set; }
        public Buzdolabi(string Ad, string Marka, string Model, string Ozellik, int Hamfiyat, int SecilenAdet, int IcHacim, string EnerjiSinifi) : base(Ad, Marka, Model, Ozellik, Hamfiyat, SecilenAdet)
        {
            this.IcHacim = IcHacim;
            this.EnerjiSinifi = EnerjiSinifi;
            StokAdedi = StokAdedi;
        }
        public override double KdvUygula()
        {
            return Hamfiyat * 1.05 * SecilenAdet;
        }
    }
}
