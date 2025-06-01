using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace klavye_hiz_testi
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

            
        
            Random random_word = new Random();
            string[] kelimeler = new string[]
            {
               "elma", "armut", "masa", "sandalye", "kalem", "defter", "kitap", "telefon", "bilgisayar", "kedi",
                "köpek", "güneş", "ay", "yıldız", "araba", "yol", "deniz", "dağ", "orman", "çiçek",
                "fare", "ekran", "priz", "kablo", "duvar", "pencere", "kapı", "halı", "perde", "şemsiye",
                "eldiven", "ayakkabı", "mont", "tişört", "pantolon", "saat", "bileklik", "cüzdan", "çanta", "gözlük",
                "bardak", "tabak", "çatal", "kaşık", "tava", "tencere", "dolap", "masaüstü", "televizyon", "müzik",
                "radyo", "oyun", "kamera", "hoparlör", "kulaklık", "mikrofon", "şehir", "köy", "kasaba", "mahalle",
                "yolcu", "otobüs", "minibüs", "taksi", "tren", "uçak", "gemi", "liman", "istasyon", "havaalanı",
                "göl", "nehir", "şelale", "ova", "çöl", "çayır", "dere", "bataklık", "çamur", "kum",
                "kaya", "mağara", "buz", "kar", "rüzgar", "yağmur", "fırtına", "yıldırım", "sis", "don",
                "sabah", "öğle", "akşam", "gece", "yarın", "bugün", "dün", "hafta", "ay", "yıl",
                "ocak", "şubat", "mart", "nisan", "mayıs", "haziran", "temmuz", "ağustos", "eylül", "ekim",
                "kasım", "aralık", "öğretmen", "öğrenci", "doktor", "hemşire", "mühendis", "polis", "asker", "şoför",
               "çiftçi", "terzi", "kasap", "fırıncı", "bakkal", "aşçı", "tezgahtar", "bekçi", "müdür", "yazar",
                "sanatçı", "müzisyen", "oyuncu", "yönetmen", "şair", "gazeteci", "fotoğrafçı", "ressam", "dansçı", "mimar",
                "bilim", "teknoloji", "tarih", "coğrafya", "matematik", "fizik", "kimya", "biyoloji", "edebiyat", "felsefe",
                "ahlak", "inanç", "kültür", "gelenek", "töre", "millet", "devlet", "bayrak", "marş", "vatan",
                "anayasa", "yasa", "hak", "özgürlük", "barış", "savaş", "adalet", "eşitlik", "oy", "seçim",
                "başkan", "bakan", "meclis", "mahkeme", "hakim", "avukat", "savcı", "polislik", "komutan", "askerlik",
                "üniversite", "lise", "ortaokul", "ilkokul", "okul", "ders", "sınav", "kitaplık", "kütüphane", "tahta",
               "kalemlik", "çöp", "masaüstü", "çanta", "klasör", "proje", "sunum", "ödev", "not", "karne",
                "tatil", "gezmek", "dinlenmek", "uyumak", "koşmak", "yüzmek", "uçmak", "yürümek", "gülmek", "ağlamak",
                    "bağırmak", "fısıldamak", "konuşmak", "yazmak", "çizmek", "silmek", "boyamak", "kesmek", "yapıştırmak", "açmak",
                "kapatmak", "yakmak", "söndürmek", "taşımak", "koymak", "almak", "getirmek", "götürmek", "bakmak", "görmek",
               "duymak", "tatmak", "koklamak", "düşünmek", "anlamak", "bilmek", "unutmak", "hatırlamak", "sevmek", "nefret",
               "beğenmek", "istemek", "arzulamak", "özlemek", "korkmak", "çekinmek", "sabretmek", "beklemek", "umut", "hayal",
                "gerçek", "yalan", "doğru", "yanlış", "çözüm", "problem", "soru", "cevap", "sebep", "sonuç",
                "neden", "amaç", "hedef", "yol", "başarı", "başarısızlık", "çaba", "emek", "gayret", "kararlılık",
                "sevgi", "saygı", "hoşgörü", "yardım", "paylaşım", "cömertlik", "nezaket", "dürüstlük", "cesaret", "sabır",
                "hırs", "kıskançlık", "öfke", "sevinç", "mutluluk", "üzüntü", "şaşkınlık", "korku", "panik", "endişe",
                "yorgunluk", "açlık", "susuzluk", "hastalık", "sağlık", "ilaç", "tedavi", "doktorluk", "ambulans", "hastane",
                "klinik", "muayene", "aşı", "serum", "kan", "damar", "kalp", "beyin", "akciğer", "karaciğer",
                "mide", "bağırsak", "kemik", "kas", "sinir", "deri", "göz", "kulak", "burun", "ağız",
                "diş", "dil", "saç", "tırnak", "el", "ayak", "bacak", "kol", "omuz", "sırt",
                "bel", "boyun", "vücut", "ten", "renk", "koku", "ses", "ışık", "gölge", "hareket",
                "durmak", "oturmak", "yatmak", "ayakta", "koşu", "egzersiz", "spor", "futbol", "basketbol", "voleybol",
                "tenis", "yüzme", "kayak", "güreş", "okçuluk", "binicilik", "atletizm", "boks", "satranç", "bilardo",
                "gitar", "piyano", "keman", "davul", "flüt", "klarnet", "müzikçi", "beste", "şarkı", "türkü",
                "halk", "sanat", "şiir", "roman", "hikaye", "masal", "fıkra", "bilmeceler", "tekerleme", "tarihçe"  };
        int dogru = 0;
        int yanlis = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            Yeni_kelime_getir();
        }

        private void Yeni_kelime_getir()
        {
            string rastgele_kelime = kelimeler[random_word.Next(kelimeler.Length)];
            label1.Text = rastgele_kelime.ToString();
        }

        

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            
            
            if (e.KeyCode == Keys.Space)
            {
                string kullaniciKelime = richTextBox1.Text.Trim();
                string hedef_kelime = label1.Text.Trim();


                if (!string.IsNullOrEmpty(hedef_kelime))
                {
                    if (kullaniciKelime == hedef_kelime)
                    {
                        dogru += 1;
                        label_dogru.Text = dogru.ToString();
                    }


                    else
                    {
                        yanlis += 1;
                        label_yanlis.Text = yanlis.ToString();
                    }
                }   


                richTextBox1.Clear();
                Yeni_kelime_getir();


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button_basla_Click(object sender, EventArgs e)
        {
            dogru = 0;
            yanlis = 0;
            label_dogru.Text = "0";
            label_yanlis.Text = "0";
            richTextBox1.Text = "";
            Yeni_kelime_getir();
            richTextBox1.Enabled = true;
            richTextBox1.Focus();
            button_basla.Enabled = false;
            button2.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox1.Enabled=false;
            button2.Enabled = false;
            button_basla.Enabled=true;
            
        }
    }
}
