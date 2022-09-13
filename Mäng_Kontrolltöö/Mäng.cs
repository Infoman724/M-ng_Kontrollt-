using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mäng_Kontrolltöö
{
    internal class Mäng : IComparable<Tegelane>
    {
        Tegelane[] tegelane;//4.0 tehtud
        public Mäng(Tegelane[] tegelane)
        {
            this.tegelane = tegelane;//4.1 tehtud
        }

        public int CompareTo(Tegelane? tegelane)//нам нужно сравнить количество предметов которое имеет один герой(список предметов привязанный к нему)
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





}
