//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
int Prompt(string message)
    {   
    System.Console.WriteLine(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
    };
int N = Prompt("Введите число");
int i = 1;
while (i<=N)
{
    if (i%2==0)
    {
        Console.WriteLine(i);
    }
    i++;
}
