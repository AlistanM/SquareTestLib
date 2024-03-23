using SquareTestLib;

Console.WriteLine("Введите: \n1 - окружность\n2 - треугольник");

var n = int.Parse(Console.ReadLine());

var factory = new SquarableFactory();
ISquarable fig;

switch (n)
{
    case 1:
        Console.WriteLine("Введите радиус окружности");
        fig = factory.CreateCircle(double.Parse(Console.ReadLine()));
        break;
    case 2:
        Console.WriteLine("Введите стороны треугольника через пробел");
        var sides = Console.ReadLine().Split().Select(double.Parse).ToList();
        fig = factory.CreateTriangle(sides[0], sides[1], sides[2]);
        break;
    default:
        Console.WriteLine("Вы не ввели число или оно не верно");
        return;
}

Console.WriteLine($"Площадь вашей фигуры: {fig.GetSquare()}");