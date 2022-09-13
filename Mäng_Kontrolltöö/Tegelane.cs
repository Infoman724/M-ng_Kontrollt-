using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mäng_Kontrolltöö 
{
    internal class Tegelane : IÜksus
    {
        private string nimi;//3.1 tehtud
        private List<Ese> eses;
        
        private int punktideArw;//p.s не обяз
        private string info;//p.s не обяз

        public Tegelane(string nimi)//3.2 tehtud
        {
            this.nimi = nimi;
        }





        public string Info()
        {
            Console.WriteLine(info);
            return info;
        }

        public int punktideArv()//3.4 tehtud??? p.s за каждый элемент(asi) в списке(Ese) прибавить к сумме(sum) элемент(asi)
        {
            int  sum = 0;
            foreach (Ese asi in eses)
            {
                sum += asi.punktideArv();//без преписки .punktideArv(); выдавало ошибку о невозможности использовать оперант += к Ese и int пока разбирался наткнулся случайно на этот вариант
            }

            Console.WriteLine(punktideArw + " punktid");
            return punktideArw;
        }

        public void liseEse(Ese asi) //3.3 tehtud p.s new version посмотрел в инете как правильно добавлять элемент
        { 
            eses.Add(asi); 
        }



    }
}


//-----------------------------------ПОДВАЛ ИДЕЙ-----------------------------

//public string lisaEse(string newEse) { void add(Ese newEse); return eses; } p.s lisaEse old version