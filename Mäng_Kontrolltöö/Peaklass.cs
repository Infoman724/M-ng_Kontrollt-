using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mäng_Kontrolltöö
{
    internal class Peaklass                                                                     //5.1 tehtud фунция для считывания данных из файла

                                                                                                //создаём класс "Peaklass" с расширением "internal"
    {
        public static Random rnd = new Random();                                                //переменная "rnd" типа "Random" для возможности использоавть функции случайности
        public static List<Ese> LoeEsemed()                                                     //создаём функцию "LoeEsemed" типа "Ese" который является списком
        {
            List<Ese> ReadEsed = new List<Ese>();                                               //создаём переменную "ReadEsed" типа "Ese" которая является списком и создаём этот список
            using (StreamReader Sr = new StreamReader(@"../../../Esemed.txt"))                  //используя встроеную возможность "StreamReader" создаём переменную "Sr" и создаём новый обьект типа "StreamReader" попутно указывая путь до нашего файла с исходными данными
            {   
                while (!Sr.EndOfStream)                                                         //И пока "Sr" не в конце строки
                {
                    string[] rida = Sr.ReadLine().Split(";");                                   //создаём массив "rida" типа "string" равный переменной "Sr" использующей функцию "ReadLine" с разделителем ";"
                    Ese ese = new Ese(rida[0].ToString(), Int32.Parse(rida[1]));                //создаём обьект "ese" типа "Ese" и конвертируем первый элемент массива "rida" в "string" а второй элемент в "int"
                    ReadEsed.Add(ese);                                                          //и добавляем в список "ReadEsed" элемент/ы "ese"
                }
            }
            return ReadEsed;                                                                    //и возвращаем список "ReadEsed"
        }

        static string SaadaNimed()                                                              //4.2 tehtud
                                                                                                //функция "SaadaNimed()" содержит в себе массив имён длинною в 5 элементов и возвращающий их в случайном порядке учитывая их длинну
        {
            string[] names = { "Vlad", "Ilja", "Konstantin", "Radomir", "Miroslav" };
            return names[rnd.Next(names.Length)];
        }

        public static void Shuffle<T>(IList<T> list)                                            //5.4 tehtud 
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        static Tegelane[] liisaEse(Tegelane[] characters)                                       //5.3
        {
            List<Ese> itemList = LoeEsemed();
            if (itemList.Count <= 0) throw new ArgumentOutOfRangeException();
            foreach (Tegelane x in characters)
            {
                Shuffle(itemList);
                int amount = rnd.Next(2, 10);
                for (int i = 0; i < amount; i++)
                {
                    x.liseEse(itemList[i]);
                }
            }
            return characters;
        }



                                                                                                //5.3 tehtud фунция для добавления персонажа из имен имеющихся в функции "getNames()"
        static Tegelane[] LisaTegelane(int CharAmount)                                           //создаём ститеческую функцию "addTegelane()" типа "Tegelane" с необходимыми аргументами в виде "CharAmount" типа "int"
        {
            if (CharAmount < 4) throw new Exception();                                          //если количество указаных символов в "аргументе" было меньше 4 выкилываем новое исключение
            Tegelane[] mängijad = new Tegelane[CharAmount];                                     //создаём массив "mängijad" типа "Tegelane" с привязкой к "CharAmount"
            for (int i = 0; i < CharAmount; i++)                                                //если "i" меньше "CharAmount" к "i" прибавляем "i" и
            {                                                                                   
                Tegelane mängija = new Tegelane(SaadaNimed());                                  //создаём переменную "" типа "" и приравниваем к функции "SaadaNimed" типа "Tegelane"
                mängijad[i] = mängija;                                                          //и приравниваем массив "mängijad" с учётом значения "i" к переменной "mängija"
            }

            return liisaEse(mängijad);                                                          //и возвращаем фунцию "liisaEse" с параметром в виде нашего массива "mängijad"
        }


                                                                                                //
        static public void Uus_mang(int kogus)
        {
            Tegelane[] chactr = LisaTegelane(5);
            Mäng mang = new Mäng(chactr);
            foreach (Tegelane x in mang.SuurimaEsemeteArvuga())
            {
                Console.WriteLine(x.Info());
            }
            Tegelane voitja = mang.suurimaPunktideArvuga();
            Console.WriteLine(voitja.Info());
            Console.WriteLine("Mängijal olid need esemed:");
            voitja.väljastaEsemed();

        }


    }
}
