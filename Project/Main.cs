using GeometryLib.Contracts;
using GeometryLib.Entities;

try
{
    List<IShape> shapes = new()
            {
                ShapeFactory.CreateCircle(5),
                ShapeFactory.CreateTriangle(3, 4, 5),
            };

    foreach (var shape in shapes)
    {
        Console.WriteLine($"Площадь фигуры: {shape.GetArea():F2}");
        
        if (shape is Triangle)
            Console.WriteLine($"Текущая фигура трегуольник. Прямоугольный ли он? Ответ: {((Triangle)shape).IsRightTriangle()}");
        
        Console.WriteLine();
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}