int x1 = Coordinate("x", "A");                           //Координаты А на оси х(длинна)
int y1 = Coordinate("y", "A");                           //Координаты А на оси y(высота)
int z1 = Coordinate("z", "A");                           //Координаты А на оси z(Плоскость)
int x2 = Coordinate("x", "B");                           //Координаты B на оси х(длинна)
int y2 = Coordinate("y", "B");                           //Координаты B на оси y(высота)
int z2 = Coordinate("z", "B");                           //Координаты B на оси y(высота)

int Coordinate(string coorName, string pointName)        //coorName=X/Y/Z       pointName=A/B (это все строки)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");//Просим ввести координаты
    return Convert.ToInt16(Console.ReadLine());                         //Значения переводим в число
}

double Decision(double x1, double x2,                         //Т.к не изветно , что это за числа будут выбираю тип с плавающей точкой в большом диапозоне 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) +                   //возвращаем квадратный коречь числа ((x2-x1)^2)+
                   Math.Pow((y2-y1), 2) +                   //возвращаем квадратный коречь числа ((y2-xy)^2)+
                   Math.Pow((z2-z1), 2));                   //возвращаем квадратный коречь числа ((z2-xz)^2)
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 ); //Возвращаем решения округленное до 2 чисел после запятой

Console.WriteLine($"Длина отрезка  {segmentLength}");