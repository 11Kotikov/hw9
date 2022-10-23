//Задача (1) 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void palindrome(int x)
{
    int digit1=x%10; // 12321 = 1
    int digit2=(x%100)/10; // 12321=21=2
    int digit3=(x/1000)%10; // 12321=12=2
    int digit4=x/10000; //12321=1

    if (x<10000 | x>99999) System.Console.WriteLine("please try again and input only a 5-digit number"); 
    else
    {
        if ((digit1==digit4)&(digit2==digit3)) System.Console.WriteLine($"You typed '{x}' and it's the palindrome");
        else System.Console.WriteLine($"You typed '{x}' and it's not the palindrome");  
    }

}
System.Console.WriteLine("Input only a 5-digit number");
int num = Convert.ToInt32(Console.ReadLine());

palindrome(num);
*/
// Задача (2) 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double DistanceBetweenTwoDots (int xa, int xb, int ya, int yb, int za, int zb)
{
    double ab = Math.Sqrt(((xb-xa)*(xb-xa)) + ((yb-ya)*(yb-ya)) + ((zb-za)*(zb-za)));
    return ab;
}

System.Console.WriteLine("Input coordinate xa: ");
int n1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input coordinate xb: ");
int n2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input coordinate ya: ");
int n3 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input coordinate yb: ");
int n4 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input coordinate za: ");
int n5 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input coordinate zb: ");
int n6 = Convert.ToInt32(Console.ReadLine());

double result = DistanceBetweenTwoDots (n1,n2,n3,n4,n5,n6);

System.Console.WriteLine($"The distance between two dots in 3D space is {result}");