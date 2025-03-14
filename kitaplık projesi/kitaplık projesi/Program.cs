using System.Diagnostics;
using System.IO;


namespace kitaplik
{
    class program
    {
        static void Main(string[] args)

        {
            int bakiye = 0;
            string secim;
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("**                                        **                                    **");
            Console.WriteLine("**    Türkçe Kitaplar Kategorisi          **   Yabancı Kitaplar Kategorisi      **");
            Console.WriteLine("**                                        **                                    **");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("**    1-Çalı Kuşu : Reşat Nuri            **   7-Tuna Kılavuzu : Jules Verne    **");
            Console.WriteLine("**                                        **                                    **");
            Console.WriteLine("**    2-Yaban : Yakup Kadri               **   8-Bir Kuzey Macerası:Jak London  **");
            Console.WriteLine("**                                        **                                    **");
            Console.WriteLine("**    3-Sinekli Bakkal : Halide Edip      **   9-Altıncı Koğuş : Anton Çehov    **");
            Console.WriteLine("**                                        **                                    **");
            Console.WriteLine("**    4-Tehlileli Oyunlar :Oğuz Atay      **   10-Kumarbaz :Dostoyevski         **");
            Console.WriteLine("**                                        **                                    **");
            Console.WriteLine("**    5-İçimizdeki Biz : Doğan Cüceloğlu  **   11-Yabancı :Stephen King         **");
            Console.WriteLine("**                                        **                                    **");
            Console.WriteLine("**    6-Kuyucaklı Yusuf : S. Ali          **   12-Vişne Bahçesi: Anton Çehov    **");
            Console.WriteLine("**                                        **                                    **");
            Console.WriteLine("**********************************************************************************");

            Console.WriteLine("*****İşlemler Menüsü*****");
            Console.WriteLine();
            Console.WriteLine("1-Fiyat Sorgulama        ");
            Console.WriteLine("2-Yeni Okur Kaydı        ");
            Console.WriteLine("3-Günün Kitabi           ");
            Console.WriteLine("4-Kitap Arşivi           ");
            Console.WriteLine("5-Yeni Kitap Satın Al    ");
            Console.WriteLine("6-Oyun                   ");
            Console.WriteLine();
            Console.Write    ("Yapmak istediğiniz işlem ");

            char islem;
            islem =Convert.ToChar(Console.ReadLine());
                
            if (islem == '1')
            {
                Console.WriteLine();
                Console.WriteLine("Fiyatını öğrenmek istediğiniz kitabin numarasını giriniz: ");
               
                string numara;
                numara = Console.ReadLine();
                switch (numara)
                {
                    case "1" : Console.WriteLine("Çalı Kuşu:         10TL"); break;
                    case "2" : Console.WriteLine("Yaban:             11TL"); break;
                    case "3" : Console.WriteLine("Sinekli Bakkal:    12TL"); break;
                    case "4" : Console.WriteLine("Tehlikeli Oyunlar: 13TL"); break;
                    case "5" : Console.WriteLine("İçimizdeki Biz:    14TL"); break;
                    case "6" : Console.WriteLine("Kuyucaklı Yusuf:   15TL"); break;
                    case "7" : Console.WriteLine("Tuna Kılavuzu:     16TL"); break;
                    case "8" : Console.WriteLine("Bir Kuzey Macerası:17TL"); break;
                    case "9" : Console.WriteLine("Altıncı Koğuş:     18TL"); break;
                    case "10": Console.WriteLine("Kumarbaz:          19TL"); break;
                    case "11": Console.WriteLine("Yabancı:           20TL"); break;
                    case "12": Console.WriteLine("Vişne Bahçesi:     21TL"); break;

                    default:Console.WriteLine("Lütfen geçerli bir işlem giriniz "); break;
                }
            }
            if (islem == '2')
            {
                Console.WriteLine ("***** Yeni Okur Kaydı");
                Console.WriteLine();
                string ad, soyad, üniverste;
                Console.Write("Adınız: " );
                ad = Console.ReadLine();
                Console.Write("Soyadınız: ");
                soyad = Console.ReadLine();
                Console.Write("Üniversteniz: ");
                üniverste = Console.ReadLine();

                string dosya = "C:\\Users\\saim4\\source\\repos\\kitaplık projesi\\Kullanıcı_Kayıt.txt";
                StreamWriter sv = new StreamWriter(dosya);
                sv.WriteLine("Adınız: " + ad);
                sv.WriteLine("Soyadınız: " +soyad);
                sv.WriteLine("Üniversiteniz: " + üniverste);
                sv.Close();


            }
            if (islem == '3')
            {
                Console.WriteLine();
                Console.WriteLine("**************************************************");
                Console.WriteLine();
                Console.WriteLine("************ Bugünün kitabı Çalı Kuşu *********** ");
                Console.WriteLine();
                Console.WriteLine("**************************************************");
            }
            if (islem == '4')
            {
                Console.WriteLine();
                Console.WriteLine("**************************************************");
                Console.WriteLine();
                FileStream fs = new FileStream("C:\\Users\\saim4\\source\\repos\\kitaplık projesi\\kitaplar.txt", FileMode.Open,FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string metin = sr.ReadLine();
                while (metin != null) 
                {
                    Console.WriteLine(metin);
                    metin = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
                Console.WriteLine();
                Console.WriteLine("**************************************************");
            }
            if (islem == '5')
            {
                for(int i = 0; i <= 100; i++)
                {
                    Console.WriteLine("********  Kitap Satış  ********");
                    Console.Write("Alacağınız kitabın numarası:");
                    secim = Console.ReadLine();

                    if (secim == "1")
                    {
                        bakiye += 10;
                    }
                    else if (secim == "2")
                    {
                        bakiye += 11;
                    }
                    else if (secim == "3") { bakiye += 12; }
                    else if (secim == "4") { bakiye += 13; }
                    else if (secim == "5") { bakiye += 14; }
                    else if (secim == "6") { bakiye += 15; }
                    else if (secim == "7") { bakiye += 16; }
                    else if (secim == "8") { bakiye += 17; }
                    else if (secim == "9") { bakiye += 18; }
                    else if (secim == "10") { bakiye += 19; }
                    else if (secim == "11") { bakiye += 20; }
                    else if (secim == "12") { bakiye += 21; }
                    else

                    Console.WriteLine("Böyle Bir kitap numarası yok");
                    Console.WriteLine();
                    Console.WriteLine("Başka kitap almak istermisiniz ?");
                    string cevap = Console.ReadLine();
                    if (cevap == "h" || cevap == "H" || cevap == "hayır" || cevap == "Hayır") break;

                }
                Console.WriteLine("Toplam tutar " + bakiye);
            }
            if (islem == '6')
            {
                Console.WriteLine();
                int tahmin = 0;
                Random rn = new Random();
                int sayi = rn.Next(1, 10);
                
                while (sayi > tahmin)
                {
                    Console.Write("Bir sayı giriniz: ");
                    tahmin = Convert.ToInt32(Console.ReadLine());

                    if (sayi > tahmin) { Console.WriteLine("Daha büyük sayı giriniz"); }
                    if (sayi < tahmin) { Console.WriteLine("Daha küçük sayı giriniz"); }
                    if (sayi == tahmin)
                    { Console.WriteLine("Doğru sonucu buldunuz Tebrikler"); break; }
                }
            }
            
        }
    }
}
