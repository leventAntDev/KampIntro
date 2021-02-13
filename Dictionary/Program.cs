using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> Ogrenci = new Dictionary<int, string>();
            //Ogrenci.Add(134, "Tolga Demirer");
            //Ogrenci.Add(158, "Ümit Özkan");
            //Ogrenci.Add(115, "Kadir Aydemir");
            //Ogrenci.Add(174, "Cemal Çiftçi");
            //Console.Write("Öğrenci No Giriniz:");
            //int No = int.Parse(Console.ReadLine());

            //try
            //{
            //    Console.WriteLine(Ogrenci[No]);
            //}
            //catch
            //{
            //    Console.WriteLine("Öğrenci Bulunamadı.");
            //}

            MyDictionary<int, string> Ogrenci = new MyDictionary<int, string>();
            int No;
            string Adi;

            bool select = true;
            while (select)
            {
                Console.Write("Öğrenci No Giriniz:");
                No = int.Parse(Console.ReadLine());
                Console.Write("Öğrenci Adını Giriniz:");
                Adi = Console.ReadLine();
                Ogrenci.Add(No, Adi);
                Console.WriteLine("Kayıt Başarılı.");
                string a = "H";
                Console.Write("Yeni Kayıt girmek istiyormusunuz.(E/H)");
                a = Console.ReadLine();
                if (a == "E")
                {
                    select = true;
                }
                else
                {
                    select = false;
                    Ogrenci.Items();
                }
            }
        }
    }
}
