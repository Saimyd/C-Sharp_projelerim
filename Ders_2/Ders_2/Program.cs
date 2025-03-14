//geriye değer döndürmeyen (void) fonksiyonlar
/*namespace geriye_değer_döndürmeyen_metotalar
{
    class program
    {
        public static void yazdır()
        {
            Console.WriteLine("yazdır fonksiyonu çalıştı");
        }

        public static void parametreli(string b)
        {
            Console.WriteLine("parametreli fonksiyon çalıştı");
        }
        public static void paremetredışarı(string parametre)
        {
            Console.Write("-----------------");
            Console.WriteLine("                -");
            Console.WriteLine("-               -");
            Console.WriteLine("----- "+parametre+" -----");
            Console.WriteLine("-               -");
            Console.Write("-----------------");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("lütfen kelimeyi girin örneğim saim");
            string kelime = Console.ReadLine();



            yazdır();
            parametreli("saim");
            paremetredışarı(kelime);
        }
    }
}
*/
//geriye değer döndüren fonksiyonlar
namespace geriye_değe_döndüren_metotlar
{
    class program
    {

        public static int topla()
        {
            int sayı1, sayı2, sonuc;
            sayı1 = 30;
            sayı2 = 20;
            sonuc = sayı1 + sayı2;
            return sonuc;
        }


        public static int geleni_topla(int say_1, int say_2)
        {
            int sonuc;
            sonuc= say_1 + say_2;
            return sonuc;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(topla());

            int s1, s2;
            Console.Write("1. Sayıyı giriniz:");
            s1= Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı giriniz:");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Toplam: "+ geleni_topla(s1, s2));
            


        }

    }


}