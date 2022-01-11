using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_SvoyTip
{
    // варианты градусов
    public enum DegreeTip {C, F, Ra, K};

    public class Degree
    {
        private double value;
        private DegreeTip tip;

        public Degree(double value, DegreeTip tip) // значение,  тип
        {
            this.value = value;
            this.tip = tip;
        }

    // сложение
        public static Degree operator +(Degree instance, double number)
        {
            var newValue = instance.value + number;
            var degree = new Degree(newValue, instance.tip);
            return degree;
        }
        public static Degree operator +(double number, Degree instance)
        {
            return instance + number;
        }
    // сложение двух величин
        public static Degree operator +(Degree instance1, Degree instance2)
        {
            return instance1 + instance2.Vyvod(instance1.tip).value;
        }

    // вычитание
        public static Degree operator -(Degree instance, double number)
        {
            var newValue = instance.value - number;
            var degree = new Degree(newValue, instance.tip);
            return degree;
        }
        public static Degree operator -(double number, Degree instance)
        {
            return instance - number;
        }
    // вычитание двух величин
        public static Degree operator -(Degree instance1, Degree instance2)
        {
            return instance1 - instance2.Vyvod(instance1.tip).value;
        }
        
    // умножение
        public static Degree operator *(Degree instance, double number)
        {
            var newValue = instance.value * number;
            var degree = new Degree(newValue, instance.tip);
            return degree;
        }
        public static Degree operator *(double number, Degree instance)
        {
            return instance * number;
        }

    //сравнение
        
    //вывод значения в любом типе
        public Degree Vyvod(DegreeTip newTip)
       {
            var newValue = this.value;
            // если текущий тип Цельсий переводить в другие градусы
            if (this.tip == DegreeTip.C)
            {
                switch (newTip)
                {
                    //конвертируем в градусы Цельсия
                    case DegreeTip.C:
                        newValue = this.value;
                        break;
                    //в градусы Фаренгейта
                    case DegreeTip.F:
                        newValue = this.value * 1.8 + 32;
                        break;
                    //в градусы Ранкина
                    case DegreeTip.Ra:
                        newValue = this.value * 1.8 + 491.67;
                        break;
                    //в Кельвины
                    case DegreeTip.K:
                        newValue = this.value + 273.15;
                        break;
                }
            }
            else if (newTip == DegreeTip.C) // перевод других градусов в Цельсий
            {
                switch(this.tip)
                {
                    case DegreeTip.C:
                        newValue = this.value;
                        break;
                    case DegreeTip.F:
                        newValue = (this.value - 32) * 5 / 9;
                        break;
                    case DegreeTip.Ra:
                        newValue = (this.value - 491.67) * 5 / 9;
                        break;
                    case DegreeTip.K:
                        newValue = this.value - 273.15;
                        break;
                }
            }
            else
            {
                newValue = this.Vyvod(DegreeTip.C).Vyvod(newTip).value;
            }
            return new Degree(newValue, newTip);
       }
       
        public string Sort() //вывод значений
        {
            return String.Format("{0} {1}", this.value, this.tip);
        }
    }
}
