using Hafta4Kapanıs;

Console.WriteLine("Lütfen telefon üretmek için 1, Bilgisayar üretmek için 2'ye basınız.");
int userInput = Convert.ToInt32(Console.ReadLine());
while (true)
{
    //telefon özellikleri kullanıcıdan alınıyor, telefon nesnesi oluşturuluyor
        if (userInput == 1)
        {
            Console.WriteLine("Telefon ismi giriniz: ");
            string phoneName = Console.ReadLine();
            Console.WriteLine("İşletim sistemi giriniz;");
            string phoneSoftware = Console.ReadLine();
            Console.WriteLine("Seri numarası giriniz: ");
            int phoneId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Telefon aciklamasi giriniz: ");
            string phoneİnfo = Console.ReadLine();
            Console.WriteLine("TR lisansı durumunu giriniz: ");
            string phoneLicence = Console.ReadLine();
            Telefon telefon = new Telefon(phoneName, phoneId, phoneİnfo, phoneSoftware, phoneLicence);
            Console.WriteLine("Ürün başarıyla üretilmiştir.\n");
            telefon.BilgileriYazdir();
        }
        else if (userInput == 2)
        {
            Console.WriteLine("Bilgisayar ismi giriniz: ");
            string pcName = Console.ReadLine();
            Console.WriteLine("İşletim sistemi giriniz;");
            string pcSoftware = Console.ReadLine();
            Console.WriteLine("Seri numarası giriniz: ");
            int pcId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bilgisayar aciklamasi giriniz: ");
            string pcİnfo = Console.ReadLine();
            Console.WriteLine("USB Sayısını giriniz(2 veya 4): ");
            int pcUsb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bluetooth var mı ?");
            string pcBluetooth = Console.ReadLine();
            Bilgisayar bilgisayar = new Bilgisayar(pcName, pcId, pcİnfo, pcSoftware, pcUsb, pcBluetooth);
            bilgisayar.BilgileriYazdir();
        }
        else
        {
            Console.WriteLine("Yanlış giriş.");
            
        }
//tekrar nesne oluşturmak istenmiyorsa döngüyü bitiriyor
    Console.WriteLine("Başka bir nesne üretmek istiyor musunuz?(evet-hayır)");
    string userInput2 = Console.ReadLine();
    if(userInput2 == "hayır")
    {
        Console.WriteLine("İyi günler");
        break;
    }
}