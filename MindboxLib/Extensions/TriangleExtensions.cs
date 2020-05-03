using System.Linq;

namespace MindboxLib
{
    public static class TriangleExtensions
    {
        /// <summary>
        /// Возвращает TRUE, если треугольник прямоугольный
        /// </summary>
        public static bool IsRight(this Triangle t)
        {
            //Получаем отсортированный массив квадратов сторон
            var orderedSides = t.Params.OrderBy(side => side)
                .Select(side => side * side)
                .ToArray();

            //Сравниваем квадрат потенциальной гипотенузы с суммой квадратов потенциальных катетов
            return orderedSides[2] == orderedSides[1] + orderedSides[0];
        }
    }
}
