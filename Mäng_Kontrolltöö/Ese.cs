using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mäng_Kontrolltöö
{
    public class Ese : IÜksus
    {
       private int punktideArw;
       private string info;




        

        public Ese(string info,int punktideArv)//2.2 tehtud??? p.s написано реальизовать конструктор с двумя параметрами с помомощью 
        {//которых можно указать имя количество очков не уверен что нужно было делать так но раз уж работаем с интерфейсам(чем то новым) то глупые ошибки приемлимы?
            this.info = info;
            this.punktideArw = punktideArv;
        }
        //2.1 tehtud p.s написано сделать их приватными но выдает ошибку поэтому пока публичный.
        public string Info()
        {
            Console.WriteLine(info);
            return info;//2.4 tehtud
        }
        
        public int punktideArv()
        {
            Console.WriteLine(punktideArw+" punktid");
            return punktideArw;//2.3 tehtud
        }



    }
}

//-----------------------------------ПОДВАЛ ИДЕЙ-----------------------------
//2.2 this.info = info;
    //this.punktideArv(); изначально было указано так после уточнения в 11:20 решил вернуться к вариантам которые мы использовали до этого