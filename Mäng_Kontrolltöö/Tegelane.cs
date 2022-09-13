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

        public int punktideArv()
        {
            Console.WriteLine(punktideArw + " punktid");
            return punktideArw;
        }

        public void add(Ese asi) //3.3 tehtud
        { 
            eses.Add(asi); 
        }



    }
}


//-----------------------------------ПОДВАЛ ИДЕЙ-----------------------------

//public string lisaEse(string newEse) { void add(Ese newEse); return eses; } p.s lisaEse old version