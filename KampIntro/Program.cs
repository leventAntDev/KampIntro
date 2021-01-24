using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
           // type safety - tip güvenliği
           // Do not repaet yourself - Kendini tekrarlama
            
            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGrisYapmisMi = true;

            if (sistemeGrisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı Ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
        }
    }
}
