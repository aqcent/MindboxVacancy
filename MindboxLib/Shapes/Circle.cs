using System;
using System.Linq;

namespace MindboxLib
{
    public class Circle : BaseShape
    {
        public Circle(params double[] param) : base(1, param) { }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Params.First(), 2);
        }
    }
}
