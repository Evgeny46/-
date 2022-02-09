


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

/* Выдает ошибку, не понимаю в чем дело?
Random rand = new Random();
int a = rand.Next(1,8);

Console.WriteLine(Get_2(a)); 

string Get_2(int a)
{
    Console.WriteLine(a);
    bool f = a ==6;
    bool f_2 = a ==7;

    if(f ^ f_2) 
    return ("Выходные дни").ToString();
    

}
 */