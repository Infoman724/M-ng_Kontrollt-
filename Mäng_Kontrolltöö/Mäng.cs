using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mäng_Kontrolltöö
{
    internal class Mäng : IComparable<Tegelane>
    {
        Tegelane[] tegelane;                              //4.0 tehtud p.s обьявили массив типа "Tegelane" с именем "tegelane"
        public Mäng(Tegelane[] tegelane)//
        {
            this.tegelane = tegelane;
        }

        public List<Tegelane> SuurimaEsemeteArvuga()      //4.1 tehtud p.s функция нахождения персонажа с самым большим колво предметов
        {
            List<Tegelane> voitjad = new List<Tegelane>();//создали список "voitjad" типа "Tegelane"
            Tegelane sorted = tegelane[0];                //создали массив "sorted" типа "Tegelane" и обьявили его количество элементов на данном этапе 0
            foreach (Tegelane t in tegelane)              //за каждый обьект(t) типа "Tegelane" в массиве "tegelane" 
            {
                int num = sorted.CompareTo(t);            //мы обьявили переменную "num" и приравняли ее к "sorted"(массив) типа "Tegelane" и сравниваем с обьектом "t"
                if (num < 0)                              //если переменная "num" меньше нуля
                {
                    sorted = t;                           //приравниваем наш массив(sorted) к обьекту "t"
                    voitjad.Clear();                      //и чистим список "voitjad" типа "Tegelane"
                }
                if (num == 0) voitjad.Add(t);             //проверяем если переменная "num" равна нулю то в список(voitjad) добавляем обьект "t"
            }
            voitjad.Add(sorted);                          //добавляем то чему стал равен наш массив(sorted) в список(voitjad)
            return voitjad;                               //и возвращаем его значение
        }
        public Tegelane suurimaPunktideArvuga()           //4.2 tehtud p.s функция нахождения персонажа с самым большим колво очков
        {
            int parim = 0;
            Tegelane voitja = tegelane[0];
            foreach (var t in tegelane)
            {
                int arv = t.punktideArv();
                if (arv > parim)
                {
                    parim = arv;
                    voitja = t;
                }
            }
            return voitja;
        }



    }















    //-------------------------------------------------ПОДВАЛ ИДЕЙ---------------------------------------
    //попытка сделать задание 4.2 до того как на уроке показали правильный вариант{
    /*public int CompareTo(Tegelane? tegelane)//нам нужно сравнить количество предметов которое имеет один герой(список предметов привязанный к нему)
        {// и количество предметов другого героя и вывести героя я большим количеством предметов проблема в том !!!!как сравнить список одного героя с списком другого!!! если на данном этапе мы не можем им добавить предметы
            if (this.tegelane.Count > tegelane.Esemed.Count)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        Tegelane suurimaesemeteArvuga() 
        {
            return;
        }

        }
        */
}
