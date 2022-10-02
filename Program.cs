namespace Algoritma_odev1
{
    internal class Soru1 
    {
        public static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            // Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
           
           System.Console.WriteLine("Bir sayı giriniz:");
           int n = int.Parse(Console.ReadLine());
           System.Console.WriteLine("{0} adet pozitif sayı giriniz:", n);
           int [] pozitifsayilar = new int [n];

           for (int i = 0; i < pozitifsayilar.Length; i++)
           {
            System.Console.Write("{0}. sayıyı girin:" , i+1);
            pozitifsayilar[i] = int.Parse(Console.ReadLine());
           }
           for (int j = 0; j < n; j++)
           {
             if (pozitifsayilar[j] %2==0)
             {
                System.Console.WriteLine(pozitifsayilar[j]);
             }
           }    
        }
    }

    internal class Soru2 
    {
        //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
        // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
        //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

        public static void Main1 (string [] args)
        {
            System.Console.Write("1. Sayıyı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            System.Console.Write("2. Sayıyı giriniz: ");
            int m = int.Parse(Console.ReadLine());
            System.Console.WriteLine("{0} adet pozitif sayı giriniz: ", n);
            int [] dizi = new int [n];
                for (int i = 0; i < dizi.Length; i++)
                {
                   System.Console.Write("{0}. sayıyı giriniz :", i+1);
                   dizi [i] = int.Parse(Console.ReadLine()) ;
                }
                for (int j = 0; j < dizi.Length; j++)
                {
                    if (dizi[j]==m)
                    {
                        System.Console.WriteLine(m);
                    }
                    else if (dizi[j] %m==0)
                    {
                       System.Console.WriteLine(dizi[j]);
                    }
                }
            
        }


    } 

    internal class Soru3
   {
     // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
   //Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
   //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
    
        public static void Main2 (string [] args)
        {
            System.Console.WriteLine("Lütfen bir sayı giriniz : ");
            int n = int.Parse (Console.ReadLine());
            System.Console.WriteLine("Lütfen {0} adet kelime giriniz: ", n);
            string [] kelimeler = new string [n];

                for (int i = 0; i < n; i++)
                {
                    System.Console.WriteLine("{0}. kelimeyi giriniz:  ", i+1);
                    kelimeler [i] = Console.ReadLine();
                }

            Array.Reverse(kelimeler);
            System.Console.WriteLine("girdiğiniz kelimeler tersten şu şekildedir");
                
                foreach (var item in kelimeler)
                {
                System.Console.WriteLine(item);    
                }
        }
    }

    internal class Soru4
    {
    //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
    // Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
        public static void Main3 (string[] args)
        {
            System.Console.WriteLine("bir cümle yazınız: ");
            string cumle = Console.ReadLine();
             string[] kelimeler= cumle.Split(' ');
           Console.WriteLine("Kelime Sayisi : {0}",kelimeler.Count());
           Console.WriteLine("Harf Sayisi : {0}", cumle.Count());
        }
    }   
}