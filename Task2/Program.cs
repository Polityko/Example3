double x1;
Console.WriteLine("Введите координаты точки x1: ");
x1 = Convert.ToDouble(Console.ReadLine());

double x2;
Console.WriteLine("Введите координаты точки x2: ");
x2 = Convert.ToDouble(Console.ReadLine());

double y1;
Console.WriteLine("Введите координаты точки y1: ");
y1 = Convert.ToDouble(Console.ReadLine());

double y2;
Console.WriteLine("Введите координаты точки y2: ");
y2 = Convert.ToDouble(Console.ReadLine());

double z1;
Console.WriteLine("Введите координаты точки z1: ");
z1 = Convert.ToDouble(Console.ReadLine());

double z2;
Console.WriteLine("Введите координаты точки z2: ");
z2 = Convert.ToDouble(Console.ReadLine());

double Distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между двумя точками в пространстве: {Distance}");
Console.ReadKey();

