using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama1
{
    internal class Program
    {
        public static void UrunEkle(List<string> list1,string urunEkle)
        {
         
          list1.Add(urunEkle);
          Console.WriteLine($"{urunEkle} ürünü başarıyla eklendi...");
            
        }


        public static void CokluUrunEkle(List<string> list2)
        {
          Console.Write("Eklemek istediğiniz Ürün sayısını giriniz : ");
            
            int urunAdet=int.Parse(Console.ReadLine());
            for(int i = 0; i < urunAdet; i++)
            {
                list2.Add(Console.ReadLine().ToUpper());
            }
            Console.WriteLine("**************************");

            Console.WriteLine($"{urunAdet} adet ürün başarıyla eklendi");
            Console.WriteLine("Eklenen Ürünler");
            Console.WriteLine("****************************");
            foreach (string i in list2)
            {
                Console.WriteLine(i);
            }
        }



        public static void UrunSil(List<string> list3) {

            Console.WriteLine("Silmek İstediğiniz Ürünü Yazınız : ");
            string urunSil=Console.ReadLine().ToUpper();
            if (list3.Contains(urunSil))
            {
                list3.Remove(urunSil);
                Console.WriteLine($"{urunSil} ürününüz  başarıyla silindi");
            }
            else
            {
                Console.WriteLine("Ürün Bulunamadı...");
            }  
            
            


        }

        public static void SepetTemizle(List<string> list4)
        {
            list4.Clear();
            Console.WriteLine("Sepetiniz başarıyla temizlendi");
        }

        public static void Urunbul(List<string> list5,string urunBul) {
            int toplam = 0;
            bool kontrol = list5.Contains(urunBul);

            foreach (string item in list5)
            {
                if (item == urunBul)
                {
                    toplam++;
                }

            }
            if (kontrol == true)
            {
                
             Console.WriteLine($"{urunBul} ürününüz {toplam} tane bulundu");

            }
            else
            {
                Console.WriteLine("Aradığınız Ürün Bulunamadı");
            }
            
        
        }

        public static void UrunGoster(List<string> list6)
        {
            if (list6.Count == 0)
            {
                Console.WriteLine("*****************************************");
                Console.WriteLine("Sepetinizde Herhangi Bir Ürün Bulunamadı");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("*************Ürünler*************");
                foreach (string item in list6)
                {
                    Console.WriteLine(item);
                }
            }
            
           
            
        }





        static void Main(string[] args)
        {
            
            
            
            
            
            List<string> ürünler = new List<string>();
            while (true)
            {
                baslangıc:
                Console.Clear();
                string menu = "1-Sepete Ürün Ekle\n2-Aynı Anda Birden Çok Ürün Ekle\n3-Sepetten Ürün Sil\n4-Sepeti Temizleyin\n" +
                     "5-Sepetteki İstediğiniz Ürünü ve Adedini Bul\n6-Sepetteki Tüm Ürünleri Gör\n7-Çıkış yap";
                
                Console.WriteLine("***** E-Ticaret Sitemize Hoşgeldiniz *****");
                Console.WriteLine();
                Console.WriteLine(menu);
                Console.WriteLine();
                Console.WriteLine("*******************************************");
                Console.WriteLine("*******************************************");
                Console.WriteLine();
                Console.Write("Yapmak istediğiniz işlemi seçiniz : ");
                int secim = int.Parse(Console.ReadLine());


                if (secim == 1)
                {
                    Console.Write("Eklemek İstediğiniz Ürünü yazınız : ");
                    string urunEkle = Console.ReadLine().ToUpper();
                    UrunEkle(ürünler, urunEkle);
                    while (true)
                    {
                        Console.WriteLine("Başka işlem yapmak istermisiniz : E\tH ");
                        String evetHayır = Console.ReadLine().ToUpper();
                        if (evetHayır == "E")
                        {

                            goto baslangıc;

                        }
                        else if (evetHayır == "H")
                        {
                            goto finish;
                        }
                        else
                        {
                            Console.WriteLine("Yanlış tuşlama yaptınız");
                        }
                    }
                }
                else if (secim == 2)
                {
                    CokluUrunEkle(ürünler);
                    while (true)
                    {
                        Console.WriteLine("Başka işlem yapmak istermisiniz : E\tH ");
                        String evetHayır = Console.ReadLine().ToUpper();
                        if (evetHayır == "E")
                        {

                            goto baslangıc;

                        }
                        else if (evetHayır == "H")
                        {
                            goto finish;
                        }
                        else
                        {
                            Console.WriteLine("Yanlış tuşlama yaptınız");
                        }

                    }
                }
                else if (secim == 3)
                {
                    UrunSil(ürünler);
                    while (true)
                    {
                        Console.WriteLine("Başka işlem yapmak istermisiniz : E\tH ");
                        String evetHayır = Console.ReadLine().ToUpper();
                        if (evetHayır == "E")
                        {

                            goto baslangıc;

                        }
                        else if (evetHayır == "H")
                        {
                            goto finish;
                        }
                        else
                        {
                            Console.WriteLine("Yanlış tuşlama yaptınız");
                        }
                    }
                }
                else if (secim == 4)
                {
                    SepetTemizle(ürünler);
                    while (true)
                    {
                        Console.WriteLine("Başka işlem yapmak istermisiniz : E\tH ");
                        String evetHayır = Console.ReadLine().ToUpper();
                        if (evetHayır == "E")
                        {

                            goto baslangıc;

                        }
                        else if(evetHayır == "H")
                        {
                            goto finish;
                        }
                        else {
                            Console.WriteLine("Yanlış tuşlama yaptınız");
                        }
                    }
                }

                else if (secim == 5)
                {
                    Console.Write("Bulmak istediğiniz ürünü yazınız : ");
                    string urunBul = Console.ReadLine().ToUpper();
                    Urunbul(ürünler, urunBul);
                    while (true)
                    {
                        Console.WriteLine("Başka işlem yapmak istermisiniz : E\tH ");
                        String evetHayır = Console.ReadLine().ToUpper();
                        if (evetHayır == "E")
                        {

                            goto baslangıc;

                        }
                        else if (evetHayır == "H")
                        {
                            goto finish;
                        }
                        else
                        {
                            Console.WriteLine("Yanlış tuşlama yaptınız");
                        }
                    }

                }
                else if (secim == 6)
                {
                    
                    UrunGoster(ürünler);
                    Console.WriteLine();
                    while (true)
                    {
                        Console.WriteLine("Başka işlem yapmak istermisiniz : E\tH ");
                        String evetHayır = Console.ReadLine().ToUpper();
                        if (evetHayır == "E")
                        {

                            goto baslangıc;

                        }
                        else if (evetHayır == "H")
                        {
                            goto finish;
                        }
                        else
                        {
                            Console.WriteLine("Yanlış tuşlama yaptınız");
                        }
                    }
                }
                  else if (secim == 7)
                {
                    goto finish;
                }
                else
                {
                    Console.WriteLine("Geçersiz işlem lütfen tekrar deneyin...");
                    Console.ReadLine();
                    goto baslangıc;
                }



            }
        finish:
            Console.WriteLine("******Hoşçakalın Yine Bekleriz *******");
            Console.ReadLine();

        }
        
    }
}
