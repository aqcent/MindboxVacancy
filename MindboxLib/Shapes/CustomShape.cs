using System;
using System.Collections.Generic;

namespace MindboxLib
{
    public class CustomShape : BaseShape
    {
        Func<IEnumerable<double>, double> areaExpression;
        public CustomShape(Func<IEnumerable<double>, double> areaExpression, params double[] parameters) : base(parameters.Length, parameters)
        {
            if (areaExpression == null)
                throw new ArgumentNullException(nameof(areaExpression));

            this.areaExpression = areaExpression;
        }
        public override double GetArea()
        {
            return areaExpression(Params);
        }
    }
}
