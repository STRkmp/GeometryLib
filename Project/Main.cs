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
        Console.WriteLine($"Area: {shape.GetArea():F2}");
        
        if (shape is Triangle)
            Console.WriteLine($"Is this a right triangle? {((Triangle)shape).IsRightTriangle()}");
        
        Console.WriteLine();
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}