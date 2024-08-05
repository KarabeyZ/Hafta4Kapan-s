using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4Kapanıs
{
    //abstract class oluşturulup altında abstract method tanımlandı
    public abstract class BaseMakine
    {
        //field
        protected string _name { get; set; }
        protected int _serialNumber { get; set; }
        protected string _information { get; set; }
        protected string _software { get; set; }
        protected DateTime _dateTime { get; set; }

        // property
        public BaseMakine(string name, int serialNumber, string information, string software)
        {
            _name = name;
            _serialNumber = serialNumber;
            _information = information;
            _software = software;
        }
        public virtual void BilgileriYazdir()
        {
            Console.WriteLine($"Üretim tarihi: {DateTime.Now}, Seri numarası: {_serialNumber}, İsmi: {_name}, Açıklaması: {_information},İşletim sistemi {_software}");
        }
        public abstract void UrunAdiGetir();
    }
    //bilgisayar class'ı BaseMakine class'ından miras aldı
    public class Bilgisayar : BaseMakine
    {
        //usb sayısı kontrol
        protected int _usbNumber;
        public int UsbNumber
        {
            get
            {
                return _usbNumber;
            }
            set
            {
                if (value == 2 || value == 4)
                {
                    _usbNumber = value;
                }
                else
                {
                    Console.WriteLine("Bluetooth değeri olarak yanlış bir değer girdiniz, 2 veya 4 girebilirsiniz.");
                    _usbNumber = -1;
                }
            }
        }
        protected string _bluetooth { get; set; }
        //bilgisayar class'ına özel olan usb ve bluetooth propertyleri
        public Bilgisayar (string name, int serialNumber, string information, string software, int usbNumber, string bluetooth) :base(name, serialNumber, information, software)
        {
            UsbNumber = usbNumber;
            _bluetooth = bluetooth;
        }
        public override void BilgileriYazdir()
        {
            Console.WriteLine("Bilgisayar nesnesi üretildi.");
            Console.WriteLine($"Üretim tarihi: {DateTime.Now}, Seri numarası: {_serialNumber}, İsmi: {_name}, Açıklaması: {_information},İşletim sistemi {_software},USB Sayısı: {_usbNumber}, Bluetooth var mı : {_bluetooth}");
        }
        //override ile ezip yeni içerik yazdırıyoruz
        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Bilgisayarınızın adı ---> {_name}");
        }
    }
    public class Telefon : BaseMakine
    {
        protected string _licence { get; set; }
        public Telefon(string name, int serialNumber, string information, string software, string licence) : base(name, serialNumber, information, software)
        {
           _licence = licence;
        }
        public override void BilgileriYazdir()
        {
            Console.WriteLine("Telefon nesnesi üretildi.");
            Console.WriteLine($"Üretim tarihi: {DateTime.Now}, Seri numarası: {_serialNumber}, İsmi: {_name}, Açıklaması: {_information},İşletim sistemi {_software},TR lisans: {_licence}");
        }
        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Telefonunuzun adı ---> {_name}");
        }
    }

}
