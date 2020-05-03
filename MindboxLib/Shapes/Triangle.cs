using System;
using System.Linq;

namespace MindboxLib
{
    public class Triangle : BaseShape
    {
        public Triangle(params double[] param) : base(3, param) { }

        protected override bool ShapeValidation
        {
            get
            {
                var sum = Params.Sum();

                // Следующая коллекция содержит разницу между текущей стороной и суммой оставшихся: A - [ (A+B+C) - A ] => A - (B+C)
                // и если хоть один элемент будет >= 0, то не будет выполняться условие существования треугольника (любая сторона должна быть меньше суммы оставшихся). 
                // (выражение намеренно не упрощено для наглядности)
                var diff = Params.Select(param => param - (sum - param));

                //Если все элементы удовлетворяют условию - валидация пройдена.
                return diff.All(x => x < 0);
            }
        }

        public override double GetArea()
        {
            double a = Params[0];
            double b = Params[1];
            double c = Params[2];

            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}