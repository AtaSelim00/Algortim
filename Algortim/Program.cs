using System;

namespace Algortim
{
    class Program
    {
       

        static void Main(string[] args)
        {

            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd"));



            // 3) 1-dən 10-a qədər olan ədədlərin kublarının cəmini tapmaq üçün proqram yazın.
            #region cozum1

            //double sonuc = 0;
            //for (int i = 1; i <=10; i++)
            //{
            //   sonuc+= Math.Pow(i, 3);

            //}
            //Console.WriteLine(sonuc);

            #endregion
            #region cozum2
            //double toplamsonuc = 0;
            //int sayac = 1;
            //while (sayac<=10)
            //{
            //    toplamsonuc += Math.Pow(sayac,3);
            //    sayac++;

            //}
            //Console.WriteLine(toplamsonuc);
            #endregion

            // 4) Doğum ili yazılan insanın yaşını hesablayan proqram yazın.
            #region cozum1

            //Console.WriteLine("Lutfen dogum tarihini giriniz.");
            //DateTime a=DateTime.Parse(Console.ReadLine());

            //TimeSpan sonuc = DateTime.Now - a;
            //Console.WriteLine(sonuc.Days/365); 
            #endregion
            #region cozum2

            //Console.WriteLine("Lutfen dogum tarihini giriniz.");
            //DateTime a = DateTime.Parse(Console.ReadLine());

            //int sonuc = (DateTime.Now - a).Days;

            //int yas=sonuc / 365;
            //int qalan = sonuc % 365; // 8323/365=22. yeni 22 den sonra ne qeder catmirki birdenede 23 olsun.
            //                         // birdenede 365 e bolune blsin
            //Console.WriteLine(qalan);
            //Console.WriteLine($"Yas : {yas} | {yas + 1} yasiniza qalan gun sayi : {qalan}");
            #endregion

            // 5) Girilen sayinin faktoriyelini hesablayan proqram yazin.
            #region cozum1

            //Console.WriteLine("Zehmet olmasa bir eded daxil edin : ");
            //int a = int.Parse(Console.ReadLine());
            //int sonuc = 1;
            //for (int i = a; i > 0; i--)
            //{
            //    sonuc *= i;
            //}
            //Console.WriteLine($"Faktoriyal : " + sonuc);
            #endregion
            #region cozum2
            //int a = int.Parse(Console.ReadLine());
            //int sonuc = 1;
            //while (a>0)
            //{
            //    sonuc *= a;
            //    a--;
            //}

            //Console.WriteLine(sonuc);
            #endregion
            #region cozum3

            //Console.WriteLine("Zehmet olmasa sayi girin : ");
            //int say = int.Parse(Console.ReadLine());
            //int sonuc = 1;
            //string netice = "";
            //while (say > 0)
            //{
            //    sonuc *= say;
            //    if (say != 1)
            //    {
            //        netice += $"{say} X ";
            //    }
            //    else
            //    {
            //        netice += $"{say} = {sonuc}";
            //    }

            //    say--;
            //}
            //Console.WriteLine(netice);
            #endregion

            // 6) pozitif sayılarda çarpma işlemini toplama kullanarak bulan uygulamayı yazınız
            //3x4=14//3 dene 4 topla yada 4 dene 3 topla
            #region cozum1
            //Console.WriteLine("Lutfen birinci sayini girin :");
            //int say1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lutfen ikinci sayini girin :");
            //int say2 = int.Parse(Console.ReadLine());

            //int cavab = 0;
            //for (int i = 0; i < say1; i++)
            //{
            //    cavab += say2;
            //}
            //Console.WriteLine($"{say1} x {say2} = {cavab}");


            #endregion


            // 7) pozitif sayılarda bolme işlemini cikarma kullanarak bulan uygulamayı yazınız
            //7/2=3 yeni 7-2=5 / 5-2=3 / 3-2=1 / 
            #region cozum1

            //Console.WriteLine("Zehmet olmasa birinci ededi daxil edin : ");
            //int say1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Zehmet olmasa ikinci ededi daxil edin : ");
            //int say2 = int.Parse(Console.ReadLine());

            //int _say1 = say1;
            //int netice = say2;
            //int bolme = 0;
            //int kalan = 0;
            //for (int i = 0; i <_say1; i++)
            //{
            //    if (say1>=say2)
            //    {
            //        say1 = say1 - say2;
            //        bolme++;
            //    }
            //    else
            //    {
            //        kalan = say1;
            //        break;
            //    }


            //}

            //Console.WriteLine($"Cavab : {bolme} /  Qalan qaliq : {kalan}");



            #endregion


            // 8) Daxil edilmiş müsbət rəqəmin neçə rəqəm olduğunu bildirən kod yazı
            #region cozum1

            //Console.WriteLine("Zehmet olmasa ededi daxil edin : ");
            //double say = double.Parse(Console.ReadLine());

            //double _say = say;
            //int sira = 1;

            //for (int i = 0; i < say; i++)
            //{
            //    if (_say >= 10)
            //    {
            //        _say = _say / 10;
            //        sira++;
            //    }
            //    else
            //    {

            //        break;
            //    }

            //}
            //Console.WriteLine($"Eded {sira} reqemden ibaretdir.");

            #endregion

            // 9) sart. Girilen 3 (4.5 yox) reqemli ededin reqemlerinin kublarinin cemi 
            //ededin ozune beraber olub olmadigini tapn
            #region cozum1

            //int eded;

            //while (true)
            //{
            //    Console.WriteLine("3 Reqemli Eded daxil edin : ");
            //    eded = int.Parse(Console.ReadLine());
            //    int _eded = eded;
            //    int netice = 1;
            //    for (int i = 0; i < eded; i++)
            //    {
            //        if (_eded > 10)
            //        {
            //            _eded = _eded / 10;
            //            netice++;
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }

            //    if (netice != 3)
            //    {
            //        Console.WriteLine("");
            //        Console.WriteLine("Eded 3 reqemli deyil");
            //        Console.WriteLine("");


            //    }
            //    else
            //    {
            //        break;
            //    }


            //}

            //int reqem3;
            //int reqem2;
            //int reqem1;
            //double reqem1kub;
            //double reqem2kub;
            //double reqem3kub;
            //double kubcem;

            //    reqem1 = eded / 100;
            //    reqem3 = eded % 10;
            //    reqem2 = eded / 10;
            //    reqem2 = reqem2 % 10;

            //    reqem1kub = Math.Pow(reqem1, 3);
            //    reqem2kub = Math.Pow(reqem2, 3);
            //    reqem3kub = Math.Pow(reqem3, 3);
            //    kubcem = reqem1kub + reqem2kub + reqem3kub;


            //    if (kubcem == eded)
            //    {
            //        Console.WriteLine("Ededin Kub Cemi Ozune Beraberdir");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Beraber Deyil");
            //    }

            #endregion
            #region cozum2

            //var num = int.Parse(Console.ReadLine());
            //if (num.ToString().Length == 3)
            //{
            //    var toString = num.ToString();


            //    var total = 0;
            //    foreach (var item in toString)
            //    {

            //        var oneDigit = item - '0';
            //        total += oneDigit * oneDigit * oneDigit;

            //    }
            //    Console.WriteLine(total);

            //}
            #endregion

            // 10) Tam ədədlər massivini nəzərə alaraq, cüt ədədlər olan bütün dəyərləri cəmləmək üçün
            // C# metodu yazın
            #region cozum1

            //int[] mas = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 2 };
            ////var _mas = mas;
            //int sum = 0;

            //for (int i = 0; i < mas.Length; i++)
            //{
            //    if (mas[i] % 2 == 0)
            //    {
            //        sum += mas[i];
            //    }
            //}
            //Console.WriteLine(sum); ;


            #endregion

            // 11) Massivin elementlərini azalan ardıcıllıqla necə sıralaya bilərik.
            #region cozum1

            //sort alqoritmlerine bax

            //int[] mas = new int[] {1,6,5,9,3,4,7,15 };
            //Array.Sort(mas);
            //foreach (var item in mas)
            //{
            //    Console.Write($"{ item},");


            //}



            #endregion
            #region cozum2

            //int[] mas = new int[] { -52, -64, -83, 12, 6, 45, -74, 0 };
            //int temp;
            //for (int i = 0; i < mas.Length; i++)
            //{

            //    for (int j = 1; j < mas.Length; j++)
            //    {
            //        if (mas[j - 1] < mas[j])
            //        {
            //            temp = mas[j - 1];
            //            mas[j - 1] = mas[j];
            //            mas[j] = temp;
            //        }
            //    }
            //}

            //foreach (var item in mas)
            //{
            //    Console.Write(item + " ");
            //}


            #endregion

            // 12) üçüncüdən istifadə etmədən iki ədəd dəyişəninin qiymətlərini dəyişdirmək üçün kod yazın.
            // bu mümkün
            // deyilsə, sübut edin
            #region cozum1
            //int a = 5;
            //int b = 3 ;
            //int c = a;
            // a = b;
            //b = c;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            #endregion
            #region cozum1

            //int a = 5;
            //int b = 3;
            //a = a + b; //a-8
            //b = a - b; //b-5
            //a = a - b; // a-3

            //Console.WriteLine(a);
            //Console.WriteLine( b);

            #endregion

            // 13) Massiv
            // də ən çox rast gəlinən tam ədədi tapan istənilən dildə kod parçasını yazın.
            #region cozum1

            //int[] mas = new[] { 5, 6, 2, 8, 5, 9, 4, 5 };

            //int counmax = 0;
            //int eded = 0;
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    int count = 0;
            //    for (int j = 0; j < mas.Length; j++)
            //    {
            //        if (mas[i] == mas[j])
            //        {
            //            count++;
            //        }
            //    }
            //    if (counmax<count)
            //    {
            //        counmax = count;
            //        eded = mas[i];

            //    }


            //}
            //Console.WriteLine(counmax);
            //Console.WriteLine(eded);

            #endregion
            #region cozum2

            //int[] mas = new int[] {1,2,3,2,4,5,2,6,2 };

            //int countmax = 0;
            //int eded = 0;
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    int count = 0;

            //    for (int j = 0; j < mas.Length; j++)
            //    {
            //        if (mas[i]==mas[j])
            //        {
            //            count++;
            //        }
            //    }
            //    if (countmax<count)
            //    {
            //        countmax = count;
            //        eded = mas[i];

            //    }
            //}
            //Console.WriteLine($"En Cox {eded} ededi {countmax} defe tekrarlanib ");
            #endregion

            // 14) FizzBuzz-ın tətbiqi 1-dən 100-ə qədər rəqəmlərin çapını nəzərdə tutur.
            // Əgər rəqəmlər 3-ün qatıdırsa, Fizz çap olunur. Əgər onlar 5-in qatıdırsa,
            // Buzz çap edilir və əgər onlar 3 və 5-in qatlarıdırsa, FizzBuzz çap olunur.
            #region cozum1

            //int a = int.Parse(Console.ReadLine());
            //if (a%15==0)
            //{
            //    Console.WriteLine("FizzBuzz");
            //}
            //else if (a%5==0)
            //{
            //    Console.WriteLine("Buzz");
            //}
            //else if (a%3==0)
            //{
            //    Console.WriteLine("Fizz");
            //}
            #endregion

            // 15) əlavə massiv yaratmadan massivi necə geri qaytarmaq olar
            #region cozum1

            //int[] mas = new int[] {1,2,3,4,5,6,7,8,9 };
            //Array.Reverse(mas);

            //foreach (var item in mas)
            //{

            //    Console.Write($"{item},");
            //}
            #endregion

            // 16) yalnız bir döngədən istifadə edərək massivdə ikinci ən böyük tam ədədi necə tapmaq olar
            #region cozum1

            //int[] mas = new int[] {4,5,9,2,7,8 };
            //int maxsecond = 0;
            //int maxtwo = 0;
            //for (int i = 0; i < mas.Length; i++)
            //{

            //    if (mas[i]>maxsecond)
            //    {
            //        maxsecond = mas[i];
            //    }
            //}

            //for (int i = 0; i < mas.Length; i++)
            //{
            //    if (mas[i]>maxtwo && mas[i]<maxsecond)
            //    {
            //        maxtwo = mas[i];
            //    }
            //}

            //Console.WriteLine($"En Boyuk birinci eded {maxsecond}, En boyuk ikinci eded {maxtwo}");
            #endregion
            #region cozum2

            //int[] mas = new int[] {4,5,6,7,1,3,9,8,2 };
            //int maxfind = mas[0];
            //int maxsecond = 0;
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    if (mas[i]>maxfind)
            //    {
            //        maxsecond = maxfind;
            //        maxfind = mas[i];

            //    }
            //    else if (mas[i]>maxsecond)
            //    {
            //        maxsecond = mas[i];
            //    }
            //}

            //Console.WriteLine(maxsecond);
            #endregion

            // 17) Bubble sort pratic code artan/azalan siralama
            #region cozum1

            //int[] mas = new int[] {5,12,3,7,11 };
            //int temp ;
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    for (int j = 1; j < mas.Length; j++)
            //    {
            //        if (mas[j - 1] > mas[j])
            //        {
            //            temp = mas[j - 1];
            //            mas[j - 1] = mas[j];
            //            mas[j] = temp;
            //        }

            //    }
            //}
            //foreach (var item in mas)
            //{
            //    Console.Write(item+ " ");
            //}
            #endregion
            #region cozum2

            //int[] mas = new int[] { -52, -64, -83, 12, 6, 45, -74, 0 };
            //int temp;
            //for (int i = 0; i < mas.Length; i++)
            //{

            //    for (int j = 1; j < mas.Length; j++)
            //    {
            //        if (mas[j - 1] < mas[j])
            //        {
            //            temp = mas[j - 1];
            //            mas[j - 1] = mas[j];
            //            mas[j] = temp;
            //        }
            //    }
            //}

            //foreach (var item in mas)
            //{
            //    Console.Write(item + " ");
            //}


            #endregion

            // 18) Selection Sort pratice code 
            #region cozum1

            //int[] array = new int[] {5,48,21,3,66,752,1};

            //    for (int i = 0; i < array.Length - 1; i++)
            //    {
            //        for (int j = i; j < array.Length; j++)
            //        {
            //            if (array[j] < array[i])
            //            {
            //                int temp = array[j];
            //                array[j] = array[i];
            //                array[i] = temp;
            //            }
            //    }
            //}

            //foreach (var item in array)
            //{
            //    Console.Write(item+ " ");
            //}

            #endregion
            #region cozum2

            //int[] mas = new int[] {5,3,21, 25,1 };
            //int temp;
            //for (int i = 0; i < mas.Length; i++)
            //{

            //    for (int j = i; j < mas.Length; j++)
            //    {
            //        if (mas[j] <mas[i])
            //        {
            //            temp = mas[j];
            //            mas[j] = mas[i];
            //            mas[i] = temp;
            //        }

            //    }
            //}
            //foreach (var item in mas)
            //{
            //    Console.Write(item+ " ");
            //}

            #endregion

            // 19) Insertion Sort pratice code
            #region cozum1

            //int[] array = new int[] {5,3,21,25,1 };

            //    for (int i = 1; i < array.Length; i++)
            //    {
            //        int currentValue = array[i];
            //        int previousIndex = i - 1;
            //        while (previousIndex >= 0 && currentValue < array[previousIndex])
            //        {
            //            array[previousIndex + 1] = array[previousIndex];
            //            previousIndex = previousIndex - 1;
            //        }
            //        array[previousIndex + 1] = currentValue;
            //    }

            #endregion

            //20) MASSİVİN ELEMENTLERİNİN CEMİ
            #region cozum1

            //int[] mas = new int[] { 1, 2, 3 };
            //int sum = 0;

            //for (int i = 0; i < mas.Length; i++)
            //{

            //    sum += mas[i];

            //}

            //Console.WriteLine(sum);

            #endregion


            //21) example 1
            #region cozum1
            //Console.WriteLine("Ededi Daxil edin...");
            //int sum = 0;
            //int eded = int.Parse(Console.ReadLine());
            //int eded2 = int.Parse(Console.ReadLine());
            //if (eded==eded2)
            //{
            //    sum = (eded + eded2) * 3;
            //}
            //else
            //{
            //    sum=eded + eded2;
            //}
            //Console.WriteLine(sum);
            #endregion


            //22) example 2
            #region cozum1

            ////N və 51 arasındakı mütləq fərqi əldə etmək üçün C# Sharp proqramını yazın.
            ////Əgər n 51-dən böyükdürsə, mütləq fərqi üçqat qaytarın.

            //Console.WriteLine("Ededi daxil edin...");
            //int eded = int.Parse(Console.ReadLine());
            //int ferq = 0;
            //if (eded>51)
            //{
            //    ferq = (eded - 51) * 3;
            //}
            //else
            //{
            //    ferq = eded - 51;
            //}
            //Console.WriteLine(Math.Abs(ferq));

            #endregion

            //23) example 3
            #region cozum1

            //Verilmiş iki tam ədədi yoxlamaq üçün C# Sharp proqramını yazın
            //və onlardan biri 30 və ya cəmi 30 olarsa, doğru qaytarın.

            Console.WriteLine("eded daxil edin...");
            int eded1 = int.Parse(Console.ReadLine());
            int eded2 = int.Parse(Console.ReadLine());

            if (eded1==30 || eded2==30 )
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            #endregion
        }

    }
}

