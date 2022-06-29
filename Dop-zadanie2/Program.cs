int a=2;
int b=1;
int l=3;
int n=4;
Console.WriteLine(2*l+(2*n-1)*a+2*(n-1)*b);         
//______________
Console.Write("расстояние между рядами= ");                   
int Rastoyanie = Convert.ToInt32( Console.ReadLine());
Console.Write("расстояние между дырочками= ");                   
int dirochka = Convert.ToInt32( Console.ReadLine());
Console.Write("Кол-во дырок в ряду= ");                   
int kol_vo_dirochik = Convert.ToInt32( Console.ReadLine());
Console.Write("Длинна свободного шнурка= ");                   
int dlina = Convert.ToInt32( Console.ReadLine());
Console.WriteLine(2*dlina+(2*kol_vo_dirochik-1)*Rastoyanie+2*(n-1)*dirochka);  