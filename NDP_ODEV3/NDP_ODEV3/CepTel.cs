
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
    class CepTel : Urun
    {
        public string DahiliHafiza { get; set; }
        public string RamKapasitesi { get; set; }
        public string PilGucu { get; set; }
        public CepTel(string Ad, string Marka, string Model, string Ozellik, int Hamfiyat, int SecilenAdet, string DahiliHafiza, string RamKapasitesi,string Pilgucu) : base(Ad, Marka, Model, Ozellik, Hamfiyat, SecilenAdet)
        {
            this.DahiliHafiza = DahiliHafiza;
            this.RamKapasitesi = RamKapasitesi;
            this.PilGucu = PilGucu;
        }
        public override double KdvUygula()
        {
            return Hamfiyat * 1.2 * SecilenAdet;
        }
    }
}
