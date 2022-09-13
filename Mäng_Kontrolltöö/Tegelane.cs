using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mäng_Kontrolltöö 
{
    internal class Tegelane : IComparable<Tegelane>
    {
        private string nimi;//3.1 tehtud
        private List<Ese> Esemed;

       
        private int punktideArw;//p.s не обяз
        

        public Tegelane(string nimi)//3.2 tehtud
        {
            this.nimi = nimi;
        }





        public string Info()//3.5 tehtud 
        {
            Console.WriteLine(nimi);
            Console.WriteLine(punktideArv());
            Console.WriteLine(Esemed.Count);
            return nimi;//pinktideArv,Esemed p.s их тоже нунжо вернуть но пока выдает ошибку 
        }    


        public int punktideArv()//3.4 tehtud p.s за каждый элемент(asi) в списке(Ese) прибавить к сумме(sum) элемент(asi)
        {
            int  sum = 0;
            foreach (Ese asi in Esemed)
            {
                sum += asi.punktideArv();//без преписки .punktideArv(); выдавало ошибку о невозможности использовать оперант += к Ese и int пока разбирался наткнулся случайно на этот вариант
            }

            Console.WriteLine(punktideArw + " punktid");
            return punktideArw;
        }

        public void liseEse(Ese asi) //3.3 tehtud p.s new version посмотрел в инете как правильно добавлять элемент только один черт пока выкидывает исключение
        { 
            Esemed.Add(asi); 
        }

        public void väljastaEsemed()//3.6 tehtud
        {
            foreach (Ese asi in Esemed)
            {
                Console.WriteLine(asi);
            }
        }

        public int CompareTo(Tegelane other)//3.7 tehtud?? 
        {
            if (this.Esemed.Count > other.Esemed.Count)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}


//-----------------------------------ПОДВАЛ ИДЕЙ-----------------------------

//public string lisaEse(string newEse) { void add(Ese newEse); return eses; } p.s lisaEse old version