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