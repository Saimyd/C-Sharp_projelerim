
int balance = 1000;
int choice;

do

{
    Console.WriteLine();
    Console.WriteLine("Bu bir atm uygulamasıdır");
    Console.WriteLine();
    Console.WriteLine("1.bakiye görüntüle");
    Console.WriteLine("2.para çek");
    Console.WriteLine("3.Para yatır");
    Console.WriteLine("4 işlemi iptal et");
    Console.Write("Yapmak istediğiniz işlemi giriniz: ");
    choice = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    switch (choice)
    {
        case 1:
            Console.WriteLine("Mevcut Bakiye: " + balance);
            break;
        case 2:
            Console.WriteLine("Çekmek istediğiniz miktar:");
            int withdraw = Convert.ToInt32(Console.ReadLine());
            if (withdraw <= balance)
            {
                balance -= withdraw;
                Console.WriteLine("Kalan bakiyeniz: " + balance);

            }
            else
            {
                Console.WriteLine("Yetersiz bakiye");

            }
            break;
        case 3:
            Console.WriteLine("Yatırmak istediğiniz miktarı girin");
            int desposit = Convert.ToInt32(Console.ReadLine());
            balance += desposit;
            Console.WriteLine("Yeni bakiyeniz: " + balance);
            break;
        case 4:
            Console.WriteLine("Çıkış yapılıyor: ");
            break;
        default:
            Console.WriteLine("Geçersiz bir seçenek");
            break;


    }


}

while (choice != 4);

