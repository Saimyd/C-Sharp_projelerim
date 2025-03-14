//C# Consol ile Algoritma dersleri
//Algoritma Nedir ?
//Belirli bir problemi çözmek veya beirli bir görevi yerine getirmek için tasarlarnmış sonlu adımlar dizisidir

//Ders 1
//Değişkenker

/*string il;
string ilce;
int plaka;
plaka = 49;
il = "Muş";
ilce = "Bulanık";

Console.WriteLine("İliniz: "+il+"  ilçeniz : " + ilce+"  Plaka kodunuz "+plaka);
Console.Read();*/

//dikdörtken alan ve çevle hesaplama

/*int kısaKenar;
int uzunKenar;
int alan, çevre;
Console.WriteLine("Birinci kenarı giriniz: ");
kısaKenar = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("ikinci kenarı giriniz");
uzunKenar = Convert.ToInt16(Console.ReadLine());
çevre = 2 * (kısaKenar + uzunKenar);
alan = kısaKenar * uzunKenar;
Console.WriteLine("çevre: "+çevre +" alan: " +alan);
Console.Read();*/

/*
string ad, soyad, bolüm, dersim;
int sınav1, sınav2, ortalama;
Console.WriteLine("adınız:");
ad = Console.ReadLine();
Console.WriteLine("soyadınız:");
soyad = Console.ReadLine();
Console.WriteLine("Bölümünüz:");
bolüm = Console.ReadLine();
Console.WriteLine("dersiniz");
dersim = Console.ReadLine();
Console.WriteLine("vize notunuz:");
sınav1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("final notunuz");
sınav2 = Convert.ToInt32(Console.ReadLine());
ortalama = (sınav2 + sınav1) / 2;
Console.WriteLine("*****KULLANICI BİLGİLERİ*****");
Console.WriteLine("");
Console.WriteLine("Merhaba "+ad+ " " + soyad);
Console.WriteLine("HOŞ GELDİNİZ");
Console.WriteLine("bölümün"+bolüm+ " dersinden " + dersim+ " ortalmanız " +ortalama);
Console.WriteLine("");
Console.WriteLine("*****KULLANICI BİLGİLERİ*****");
Console.ReadKey();
*/

//ders2 karar yapıları

/*
string ad = "saim";

string soyad = "yarımdunya";
Console.WriteLine("adınızı girin: ");
string gad = Console.ReadLine();
Console.WriteLine("soyadınızı girin:");
string gsoyad= Console.ReadLine();

if (gad ==ad && gsoyad ==soyad)
{
    Console.WriteLine("hoş geldiniz "+ ad+ " "+soyad);
}
else
{
    Console.WriteLine("Giriş başarısız");
}*/

//kullanıcının girdiği sayı tekmi çiftmi bulma programı

/*
Console.WriteLine("Bir sayı giriniz:");
int sayi = Convert.ToInt32(Console.ReadLine());
if (sayi %2 ==0)
{
    Console.WriteLine("Girilen sayı çiftir ");
}
else
{
    Console.WriteLine("Girilen sayı tek bir sayıdır");
}
Console.Read();
*/


//Öğrencinin girdiği sinav notuna göre harf notu verme


/*
Console.WriteLine("Vize puanınız:");
int vize = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Final puanınız:");
int final = Convert.ToInt16(Console.ReadLine());

int ortalama = vize * 30 / 100 + final * 70 / 100;

if(ortalama >= 80)
{
    Console.WriteLine("ortalamanız: " + ortalama + "  harf notunuz AA");
}
else if(ortalama >=70)
{
    Console.WriteLine("ortalamanız:  " + ortalama + "  harf notunuz BB");
}
else if(ortalama >=60)
{
    Console.WriteLine("ortalamanız:  " + ortalama + " harf notunuz BC");
}
else if (ortalama >= 50)
{
    Console.WriteLine("ortalamanız:  " + ortalama + "  harf notunuz CC");
}
else if (ortalama >= 40)
{
    Console.WriteLine("ortalamanız:  " + ortalama + "  harf notunuz DC");
}
else if (ortalama >= 30)
{
    Console.WriteLine("ortalamanız:  " + ortalama + "  harf notunuz DD");
}
else 
{
    Console.WriteLine("ortalamanız:  " + ortalama + "  harf notunuz FF");
}
*/


//Basit bir hesap makinesi yapımı
/*
Console.WriteLine("Bir sayı  giriniz:");
int sayı1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ikinci sayı giriniz");
int sayı2= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Hangi işlemi yapmak istiyorsunuz ( + ,- ,* ,/):");
char işlem = Char.Parse(Console.ReadLine());
int sonuc=0;

if (işlem == '+')
{
    sonuc = sayı1 + sayı2;

}

else if (işlem == '-')
{
    sonuc = sayı1 - sayı2;
}
else if (işlem == '*')
{
    sonuc = sayı2 * sayı1;
}
else if (işlem == '/')
{
    if (sayı2 != 0)
    {
        sonuc = sayı1 / sayı2;
    }
    else
    {
        Console.WriteLine("sıfıra bölünmez");
    }
}
else
{
    Console.WriteLine("lütfen geçerli bir işlem giriniz");
}
Console.WriteLine("SONUÇ"+" "+ sonuc);*/

//swich case 
/*
Console.Write("haftanın günleri 1 ile 7 arasında bir sayı giriniz  ");
int gün = int.Parse(Console.ReadLine());

switch (gün)
{
    case 1:
        Console.WriteLine("pazartesi"); break;
    case 2: Console.WriteLine("salı"); break ;
    case 3: Console.WriteLine("çarşamba"); break;
    case 4: Console.WriteLine("perşembe"); break;
    case 5: Console.WriteLine("cuma"); break;
    case 6: Console.WriteLine("cumartesi"); break;
    case 7: Console.WriteLine("pazar"); break;
    default: Console.WriteLine("lütfen geçerli bir gün giriniz");  break;

}

*/

// for dongüsü kullanımı 1 den 10 na kadar olan çift sayıları yazıp bu sayılarım toplam değerini veriyor



/*
int sıra = 1;
int toplam = 0;

for (int j = 0; j <= 10; j += 2) { 
    Console.WriteLine(sıra + ". sayı " + j);
    sıra++;
    toplam += j;  
}
Console.WriteLine("toplam sayı: " + toplam);
*/
/*
//girilen iki sayı arasındaki 3 e bolünebilen sayıların toplamı ile girilen aralıktaki 3 e bölünmeyenlerin  sayıları
//toplayan fonksiyon yapımı

Console.Write("kücük sayıyı giriniz: ");
int sayı1= Convert.ToInt16(Console.ReadLine());
Console.Write("büyük sayıyı giriniz: ");
int sayı2= Convert.ToInt16(Console.ReadLine());
int toplam = 0;
int toplam1 = 0;
int sıra = 1;
for(int a=sayı1; a<=sayı2; a++)
{
    if (a % 5 == 0)
    {
        Console.WriteLine(sıra + ". sayı " + a);
        toplam += a;
        sıra++;

    }

    else if(a % 5 != 0)
    {
        toplam1 += a;
        
    }
}
Console.WriteLine("toplam: " + toplam);
Console.WriteLine("toplam olma: " + toplam1);
*/
/*
//while ile do while farkı while sart sağlanmasa işleme girmeden bitiriyor 
//do while ise işlemi en az bir sefer yapıyor
int a = 0;
while (a<=10)
{
    
    Console.WriteLine("saim baba");
    a++;
}


int b = 0;
do
{
    Console.WriteLine(b);
    b++ ;
}
while (b<=10);
*/

//Diziler
/*
string[] hayvanlar = { "tavuk", "kaz", "hindi", "ordek" };
int j=0;

for(int i= 0; i<4; i++)
{
    Console.WriteLine("dizninin " + j +". indexi  "  + hayvanlar[i]);
    j++;
}

*/
/*
int[] sayılar = { 10, 20, 30, 40, 50, 60 };
int toplam = 0;

for (int i = 0; i < sayılar.Length; i++)
{
    if (sayılar[i] % 20 == 0 || sayılar[i] % 30 == 0)
    {
        Console.WriteLine(sayılar[i]);
        toplam += sayılar[i];
    }  
}
Console.WriteLine("bu sayıların toplamı: " + toplam);*/


/*revorse ve short metotları


string[] sehirler = { "Muş", "erzurum", "istanbul", "bursa", "ankara" };

Array.Sort(sehirler);
Array.Reverse(sehirler);
for (int i = 0; i < sehirler.Length; i++)
{
    Console.WriteLine(sehirler[i]);
}
int sıra;
sıra = Array.IndexOf(sehirler, "ankara");
Console.WriteLine(sıra);*/

// max min metotoları ornek kullanım
/*
Console.Write("lütfen bir sayı giriniz: ");
int sayı1 = Convert.ToInt32(Console.ReadLine());
Console.Write("lütfen bir sayı daha giriniz: ");
int sayı2 = Convert.ToInt32(Console.ReadLine());

int [] say= {sayı1,sayı2};

Console.WriteLine("en kücük sayı "+say.Min());
Console.WriteLine("en büyük sayı " + say.Max());

*/

// klavyeden diziye değer girme 

string[] sehir = new string[5];

for (int s = 0; s < 5; s++)
{
    Console.Write("lütfen bir şehir ismi daha giriniz: ");
    sehir[s] =Console.ReadLine();
}

Array.Sort(sehir);
for (int i = 0; i < sehir.Length; i++)
{
    Console.Write(sehir[i]+" ,");
}
