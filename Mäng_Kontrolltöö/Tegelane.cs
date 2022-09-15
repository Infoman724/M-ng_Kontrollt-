using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mäng_Kontrolltöö 
{
    internal class Tegelane : IComparable<Tegelane>      //3.1 tehtud
    {                                                    
        private string nimi;                             //обявили переменную   "nimi" типа "string"     
        private List<Ese> Esemed;                        //создали приватный список "Esemed" типа "Ese"
                                                         
                                                         
        private int punktideArw;                         //обявили приватную переменную "punktideArw" типа "int"
                                                         
                                                         //3.2 tehtud
        public Tegelane(string nimi)                     //создали конструктор который поможет в определении имени "героя"
        {                                                
            this.nimi = nimi;                            
        }                                                
                                                         
                                                         
                                                         
                                                         
                                                         
        public string Info()                             //3.5 tehtud 
        {                                                
            Console.WriteLine(nimi);                     
            Console.WriteLine(punktideArv());            
            Console.WriteLine(Esemed.Count);             
            return nimi;                                 //pinktideArv,Esemed p.s их тоже нунжо вернуть но пока выдает ошибку 
        }                                                
                                                         
                                                         
        public int punktideArv()                         //3.4 tehtud  
        {                                                
            int  sum = 0;                                
            foreach (Ese asi in Esemed)                  //за каждый элемент(asi) типа(Ese) в списке "Esemed"
            {                                            
                sum += asi.punktideArv();                //к переменной "sum" прибавить элемент "asi" с использованной функцией punktideArv???
                                                         //p.s без преписки .punktideArv(); выдавало ошибку о невозможности использовать оперант += к Ese и int пока разбирался наткнулся случайно на этот вариант
            }

            Console.WriteLine(punktideArw + " punktid"); //и выводим на экран колво очков с их последующим возвратом
            return punktideArw;                         
        }

        public void liseEse(Ese asi)                     //3.3 tehtud
                                                         //p.s new version посмотрел в инете как правильно добавлять элемент в список
        { 
            Esemed.Add(asi); 
        }

        public void väljastaEsemed()                     //3.6 tehtud
        {
            foreach (Ese asi in Esemed)                  //за каждый элемент "asi" типа "Ese" в списке "Esemed"
            {
                Console.WriteLine(asi);                  //в новую строку написать элемент "asi"(предмет)
            }
        }
                                                         //3.7 tehtud 
        public int CompareTo(Tegelane other)             //создаём сравнение типа "int" в котором сравниваем тип "Tegelane" с "other"(тем что укажет пользователь)
        {
            if (this.Esemed.Count > other.Esemed.Count)  //если количество элементов этого списка(посчитанно функцией Count) больше чем количество элементов списка укзанаго пользователем то---> 
            {
                return 1;                                //возвращаем еденицу 
            }
            else                                         //по иному
            {
                return -1;                               //возвращаем -1
            }
        }
    }
}


//-----------------------------------ПОДВАЛ ИДЕЙ-----------------------------

//public string lisaEse(string newEse) { void add(Ese newEse); return eses; } p.s lisaEse old version