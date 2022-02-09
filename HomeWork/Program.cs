

/* Задать номер четверти, показать диапазоны для возможных координат */
/* 
using static System.Console;

Write("Задайте номер четверти - ");
string a = ReadLine();
string x = "I";
string b = "II";
string c = "III";
string d = "IV";
WriteLine(Number(a, x, b, c, d));
string Number(string a, string x, string b, string c, string d)


{
    if(a == x)
    return $"Значение для данной четверти - (x>0; y>0)";

    else if (a == b)
    return $"Значение для данной четверти - (x<0; y>0)";

    else if (a == c)
    return $"Значение для данной четверти - (x<0; y<0)";

    else if(a == d)
    return $"Значение для данной четверти - (x>0; y<0)";

    
    
    else return $"Неверное значение. Введите римские заглавные буквы в диапазоне [I;IV]";
 }

 */

/*  Найти расстояние между точками в пространстве 2D/3D */
/* using static System.Console;
Console.Clear();
 
 Write("Введите координаты для x1: ");
 double x1 = double.Parse(ReadLine());
 Write("Введите координаты для x2: ");
 double x2 = double.Parse(ReadLine());
 Write("Введите координаты для y1: ");
 double y1 = double.Parse(ReadLine());
 Write("Введите координаты для y2: ");
 double y2 = double.Parse(ReadLine());

 WriteLine(Distance(x1, x2, y1, y2));

 string Distance (double x1, double x2, double y1, double y2)

 {
     double D = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));
     return $"Расстояние между точками = {D}";
 }
 */

 using static System.Console;
Console.Clear();
 
 Write("Введите координаты для x1: ");
 double x1 = double.Parse(ReadLine());
 Write("Введите координаты для x2: ");
 double x2 = double.Parse(ReadLine());
 Write("Введите координаты для y1: ");
 double y1 = double.Parse(ReadLine());
 Write("Введите координаты для y2: ");
 double y2 = double.Parse(ReadLine());
  Write("Введите координаты для z1: ");
 double z1 = double.Parse(ReadLine());
 Write("Введите координаты для z2: ");
 double z2 = double.Parse(ReadLine());

 WriteLine(Distance(x1, x2, y1, y2, z1, z2));

 string Distance (double x1, double x2, double y1, double y2, double z1, double z2)

 {
     double D = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
     return $"Расстояние между точками = {D}";
 }

/*  Показать таблицу квадратов чисел от 1 до N 

using static System.Console;

Write("Введите граничащее значение - ");

int count = int.Parse(ReadLine());
for(int i = 1; i < count; i++)
{
    WriteLine($"Квадрат числа {i} = {Math.Pow(i,3)}"); 
} 
*/







/* Показать последнюю цифру трёхзначного числа */


/* int a = 564;
int b = (a/10) % 10;
Console.WriteLine(b); */

/* Удалить вторую цифру трёхзначного числа.
int  a = int.Parse(Console.ReadLine());

int b = a/100;
int c = b%10;
int f = a%10;
int d = c*10+f;



Console.WriteLine(c);
Console.WriteLine(f);
Console.WriteLine(d); */


/* Дано число обозначающее день недели. Выяснить является номер дня недели выходным
 */
/* Random rand = new Random();
int a = rand.Next(1,8);

Console.WriteLine(Get_2(a)); 

string Get_2(int a)
{
    Console.WriteLine(a);

    if(a ==6) return $"{a} - день недели, Суббота";
    
    else if(a ==7)
    
    return $"{a} - день недели, Воскресенье";

    else 
    
    return "Рабочие дни";
    
} */

/* 
Random rand = new Random();
int a = rand.Next(1,8);

Console.WriteLine(Get_2(a)); 

string Get_2(int a)
{
    Console.WriteLine(a);
    bool f = a ==6;
    bool f_2 = a ==7;

    if(f ^ f_2) 
    return "Выходные дни";
    else
    return "Будни";
    

}
 */