using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mäng_Kontrolltöö
{
    internal class Peaklass                                                                     //создаём класс "Peaklass" с расширением "internal"
    {
                                                                                                
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








    }
}
