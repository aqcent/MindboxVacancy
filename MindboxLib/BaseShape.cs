using System;
using System.Linq;

namespace MindboxLib
{
    public abstract class BaseShape
    {
        public double[] Params { get; private set; }

        protected BaseShape(int numOfParams, params double[] parameters)
        {
            if (parameters.Length == 0)
                throw new ArgumentNullException();

            if (parameters == null)
                throw new NullReferenceException();

            if (numOfParams != parameters.Length)
                throw new ArgumentException($"Invalid number of arguments for {GetType()}");

            if (!parameters.All(p => p > 0))
                throw new ArgumentException("Any parameter should be greater than zero.");

            Params = parameters;

            if (!ShapeValidation)
                throw new ArgumentException($"{GetType()} with these parameters cannot exist.");           
        }

        protected virtual bool ShapeValidation { get => true; }

        /// <summary>
        /// Возвращает площадь фигуры
        /// </summary>        
        public abstract double GetArea();
    }
}
