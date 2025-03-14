Console.WriteLine();
Console.Write("Doğum Tarihini giriniz: ");
int dogumyılı = Convert.ToInt32(Console.ReadLine());
int yaş = DateTime.Now.Year - dogumyılı;


if(yaş>= 18)
{
    Console.WriteLine("Ehliyet alabilirsiniz");
}
else
{
    yaş = 18 - yaş;
    Console.WriteLine("Ehliyet Alamanıza Kalan süre: " + yaş);
}

TimeSpan kaçündür_yaşıyorum;
DateTime dogumTarihi , bugün;
int güne;
bugün = DateTime.Today;
dogumTarihi = Convert.ToDateTime(Console.ReadLine());
kaçündür_yaşıyorum = bugün - dogumTarihi;
güne = kaçündür_yaşıyorum.Days;
Console.WriteLine("kaç gün " + güne);
