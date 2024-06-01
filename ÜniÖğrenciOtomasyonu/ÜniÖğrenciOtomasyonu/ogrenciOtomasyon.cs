using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÜniÖğrenciOtomasyonu
{
    public partial class ogrenciOtomasyon : Form
    {
        public static string[] erkekIsimler = { "Abidin", "Adnan", "Affan", "Agah", "Ahi", "Ahmed", "Alican", "Alişan", "Alişir", "Alpaslan", "Alper", "Alperen", "Altemur", "Amir", "Ammar", "Arda", "Aşkın", "Ata", "Atalay", "Ataullah", "Avşar", "Aykan", "Aykut", "Aytekin", "Ayvaz", "Babacan", "Baha", "Bahadır", "Barın", "Battal", "Batu", "Bedir", "Behcet", "Behlül", "Behnan", "Behram", "Behzat", "Bekir", "Bektaş", "Bera", "Berkan", "Berkin", "Beşer", "Beşir", "Bilal", "Bilgehan", "Bişr", "Buğra", "Burak", "Burhan", "Bülent", "Cafer", "Cabir", "Can", "Candar", "Caner", "Canib", "Cantekin", "Carullah", "Celal", "Çelebi", "Cem", "Cemal", "Cemaleddin", "Cemali", "Cenab", "Cengiz", "Cerrah", "Cevat", "Cevdet", "Cevheri", "Cezmi", "Cihad", "Cihangir", "Civan", "Cihanşah", "Cübeyr", "Cüneyt", "Dahi", "Dai", "Dana", "Daniş", "Daver", "Derviş", "Dilhan", "Dilaver", "Doğan", "Dülger", "Ecehan" };
        public static string[] kizIsimler = { "Abendam", "Açela", "Açelya", "Açılay", "Adel", "Adelya", "Adile", "Afitap", "Afra", "Ağça", "Ahenk", "Ahlem", "Alisa", "Almila", "Alvina", "Amelya", "Amara", "Andaç", "Anar", "Anise", "Anita", "Anka", "Alpike", "Altın", "Arın", "Arya", "Asuela", "Aslım", "Ayren", "Aykal", "Aysar", "Ayşıl", "Bade", "Bağdagül", "Balın", "Bediz", "Bedran", "Behrem", "Belçim", "Belma", "Beltun", "Belemir", "Belinda", "Benice", "Benli", "Berceste", "Berçin", "Berinay", "Berran", "Berre", "Berva", "Besra", "Çağıl", "Cangül", "Cannur", "Cansel", "Cansın", "Canel", "Ceren", "Ceyda", "Cilvenaz", "Ceylinaz", "Ceylin", "Ceyla", "Ceylan", "Çağla", "Çeşminaz", "Çıgıl", "Çiçek", "Çilay", "Çiler", "Çimen", "Çise", "Çişem", "Çisil", "Damla", "Defne", "Demet", "Deniz", "Derya", "Destan", "Deste", "Didem", "Dilan", "Dilara", "Dilay", "Diler", "Dilhan", "Dilek", "Dilruba" };
        public static string[] soyAdlar = { "ERYILMAZ", "DEMİR", "AYDIN", "OCAK", "BÖLÜK", "ÖZMEN", "ÖZTÜRKERİ", "EKEN", "AKGÜL", "SARICA DAROL", "CANSEVER", "AKIN", "GÜZEL", "ÖZER ÇELİK", "ÇAKIR", "AKSUN", "BALAL", "BAYAM", "ŞAİR", "ÜNLÜ", "YUMURTAŞ", "AYKAN", "ALPSAN GÖKMEN", "CANATAN", "MUMCUOĞLU", "TAŞKIRAN", "HATİPOĞLU", "AKYOL", "SUCAK", "YILDIZ", "AKPINAR", "GÖKSEL", "KARSLI", "ÖZGÜROL", "ACAR", "KALEM", "ŞAHİN", "DÖKMECİ", "GÖRMELİ", "ÖZATEŞ", "SERVET", "TOPRAK", "SÜNER", "SARIKAYA", "SULUOVA", "SERBEST", "EFE", "ATBİNİCİ", "KIYAK", "ÇELİK", "ÖZ", "TEPE", "ÖZÜAK", "ÖNCEL", "CANBAZ", "AL", "GÜRER", "GÜNGÖR", "GÖNCÜ", "ÖZDAMAR", "KARATOPRAK", "ÇAVDAR", "SÖZEN", "GÖKÇEK", "KARAKAYA", "ÇEPNİ", "ERSOY", "ÇAĞLAR", "ÖZALP", "EVRENOS", "BAYRAKTAROĞLU", "USLUSOY", "SARI", "ATALAY", "TOPKARA", "BEKTAŞ", "TENEKECİ", "ÇAĞIL", "MERTOL", "TAŞ", "HIDIROĞLU", "ŞEN GÖKÇEİMAM", "KARAHAN", "ÖNAL MUSALAR", "DEMİREL", "YACI", "IŞIKLI", "KILIÇ", "ÜLGEN", "KÜÇÜKGÖNCÜ", "SU KURT", "KOÇAR", "BALOĞLU", "DUMAN", "ASLAN", "SARICANBAZ", "SERT", "ALTUN", "YILMAZ GELEBEK", "ÖZAN SANHAL", "BAKAN", "KARAKAN", "GÖRKEM", "CILIZ BASHEER", "KARACAN", "TEN", "ATLANOĞLU", "ÖZTÜRK", "TOPALOĞLU", "SOYDAN", "TÜRKAY", "MENTEŞ", "PINARBAŞILI", "ONAY", "CERİT", "ÜNAL", "YILDIZ", "İMAMOĞLU", "ÖZDEMİR AKDUR", "YANMAZ", "BÜBER", "AKKAYA", "TAŞMALI", "BULAKÇI", "BAYRAM", "AYDIN", "GERGER", "YEŞİLKAYA", "DÖNMEZ", "YILMABAŞAR", "DİKİCİ", "ARİFOĞLU", "FİDAN", "SAKARYA", "ÖZEN", "ONAN", "AKHUN", "KIR", "ŞAHİN", "SU DUR", "YAZICI", "GÜRDEMİR", "ALTINSOY", "KALYONCU UÇAR", "ŞAŞMAZ", "GÜLCAN", "KURT GÜNEY", "ÖZTÜRK", "ULUTAŞ", "ALTUNA", "GÜREL", "KARAKUŞ", "KILIÇ", "ÖZKIRIŞ", "KAYA", "YILMAZ", "İNCİ KENAR", "DEMİR", "AKBAŞ ÖNCEL", "EREN", "BİCAN", "AYDIN", "ÖZDOĞAN KAVZOĞLU", "ATEŞ BUDAK", "KÖKSAL", "SARGIN", "AKKOYUNLU", "ŞİMŞEK", "ÖZTÜRK", "KAYHAN", "TEZER", "KARACAN", "ÇAKIR", "UYSAL", "GÜRAKAN", "DOKUMACIOĞLU", "KIRHAN" };
        public static string[] bolumler = { "Makine Mühendisliği", "İşletme", "Bilgisayar Mühendisliği", "Hukuk", "Mimarlık", "Psikoloji" };



   

        public ogrenciOtomasyon()
        {
            InitializeComponent();
        }

        public void DatagridviewSetting(DataGridView dataGridView)
        {
     
        }



        static void YazdirRastgeleOgrenci()
        {
            Random random = new Random();
            using (StreamWriter writer = new StreamWriter("ogrenciler.txt"))
            {
                List<ogrenci> ogrenciler = new List<ogrenci>();

                for (int i = 0; i < 10000; i++)
                {
                    ogrenci ogrenci = new ogrenci();
                    ogrenci.Cinsiyet = random.Next(2) == 0 ? "Erkek" : "Kız";
                    ogrenci.Ad = ogrenci.Cinsiyet == "Erkek" ? erkekIsimler[random.Next(erkekIsimler.Length)] : kizIsimler[random.Next(kizIsimler.Length)];
                    ogrenci.SoyAd = soyAdlar[random.Next(soyAdlar.Length)];
                    ogrenci.Bolum = bolumler[random.Next(bolumler.Length)];
                    ogrenci.Sinif = random.Next(1, 5); 
                    ogrenci.Gano = (float)Math.Round(random.NextDouble() * 4, 3);
                    ogrenci.OgrenciNo = 216040000 + i;

                    ogrenciler.Add(ogrenci);
                }

                // Bölüm sırasını belirle
                var siraliOgrenciler = ogrenciler.OrderBy(o => o.Bolum).ThenBy(o => o.Gano).ToList();

                int siradakiBolumSira = 1;
                string oncekiBolum = string.Empty;

                foreach (var ogrenci in siraliOgrenciler)
                {
                    if (ogrenci.Bolum != oncekiBolum)
                    {
                        siradakiBolumSira = 1;
                        oncekiBolum = ogrenci.Bolum;
                    }

                    ogrenci.BolumSira = siradakiBolumSira;
                    siradakiBolumSira++;
                }

                // Sınıf sırasını belirle (her bölüm için ayrı ayrı)
                foreach (var bolum in bolumler)
                {
                    var bolumdekiOgrenciler = siraliOgrenciler.Where(o => o.Bolum == bolum).ToList();

                    foreach (var sinif in Enumerable.Range(1, 4))
                    {
                        var siniftakiOgrenciler = bolumdekiOgrenciler.Where(o => o.Sinif == sinif).ToList();

                        for (int i = 0; i < siniftakiOgrenciler.Count; i++)
                        {
                            siniftakiOgrenciler[i].SinifSira = i + 1;
                        }
                    }
                }

                // Dosyaya yaz
                foreach (var ogrenci in siraliOgrenciler)
                {
                    writer.WriteLine($"{ogrenci.Ad} / {ogrenci.SoyAd} / {ogrenci.OgrenciNo} / {ogrenci.Gano} / {ogrenci.Bolum} / {ogrenci.Sinif} / {ogrenci.Cinsiyet} / {ogrenci.BolumSira} / {ogrenci.SinifSira}");
                }
            }
        }

        public static void DosyaOku(DataGridView dataGridView)
        {


            List<ogrenci> ogrenciler = new List<ogrenci>();

            using (StreamReader reader = new StreamReader("ogrenciler.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split('/');
                    ogrenci ogrenci = new ogrenci
                    {
                        Ad = values[0].Trim(),
                        SoyAd = values[1].Trim(),
                        OgrenciNo = int.Parse(values[2].Trim()),
                        Gano = float.Parse(values[3].Trim(), CultureInfo.InvariantCulture),
                        Bolum = values[4].Trim(),
                        Sinif = int.Parse(values[5].Trim()),
                        Cinsiyet = values[6].Trim(),
                        BolumSira = int.Parse(values[7].Trim()),
                        SinifSira = int.Parse(values[8].Trim())
                    };

                    ogrenciler.Add(ogrenci);
                }
            }

            // Datagrideekle
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("Ad", "Ad");
            dataGridView.Columns.Add("SoyAd", "SoyAd");
            dataGridView.Columns.Add("OgrenciNo", "OgrenciNo");
            dataGridView.Columns.Add("Gano", "Gano");
            dataGridView.Columns.Add("Bolum", "Bolum");
            dataGridView.Columns.Add("Sinif", "Sinif");
            dataGridView.Columns.Add("Cinsiyet", "Cinsiyet");
            dataGridView.Columns.Add("BolumSira", "BolumSira");
            dataGridView.Columns.Add("SinifSira", "SinifSira");
            dataGridView.Rows.Clear();
            foreach (var ogrenci in ogrenciler)
            {
                dataGridView.Rows.Add(ogrenci.Ad, ogrenci.SoyAd, ogrenci.OgrenciNo, ogrenci.Gano, ogrenci.Bolum, ogrenci.Sinif, ogrenci.Cinsiyet, ogrenci.BolumSira, ogrenci.SinifSira);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            YazdirRastgeleOgrenci();           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DosyaOku(dataGridView1);
            /*
            dataGridView1.ColumnCount = 9; // Toplam 9 sütun
            dataGridView1.Columns[0].Name = "Ad";
            dataGridView1.Columns[1].Name = "Soyad";
            dataGridView1.Columns[2].Name = "Öğrenci No";
            dataGridView1.Columns[3].Name = "Gano";
            dataGridView1.Columns[4].Name = "Bölüm";
            dataGridView1.Columns[5].Name = "Sınıf";
            dataGridView1.Columns[6].Name = "Cinsiyet";
            dataGridView1.Columns[7].Name = "Bölüm Sıra";
            dataGridView1.Columns[8].Name = "Sınıf Sıra";

            // Öğrenci verilerini dosyadan oku
            List<ogrenci> ogrenciler = new List<ogrenci>();

            using (StreamReader reader = new StreamReader("ogrenciler.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split('/');

                    ogrenci ogrenci = new ogrenci
                    {
                        Ad = values[0].Trim(),
                        SoyAd = values[1].Trim(),
                        OgrenciNo = int.Parse(values[2].Trim()),
                        Gano = float.Parse(values[3].Trim(), CultureInfo.InvariantCulture),
                        Bolum = values[4].Trim(),
                        Sinif = values[5].Trim(),
                        Cinsiyet = values[6].Trim(),
                        BolumSira = int.Parse(values[7].Trim()),
                        SinifSira = int.Parse(values[8].Trim())
                    };

                    ogrenciler.Add(ogrenci);
                }
            
            }

            // DataGridView'e öğrenci verilerini ekleyin
            foreach (var ogrenci in ogrenciler)
            {
                dataGridView1.Rows.Add(ogrenci.Ad, ogrenci.SoyAd, ogrenci.OgrenciNo, ogrenci.Gano, ogrenci.Bolum, ogrenci.Sinif, ogrenci.Cinsiyet, ogrenci.BolumSira, ogrenci.SinifSira);
            }
            */

        }
    }
}

