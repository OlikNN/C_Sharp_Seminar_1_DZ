// Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int max = 0;
Console.WriteLine("Введите числ A");
int numberA= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числ B");
int numberB= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числ C");
int numberC= Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    //Console.WriteLine("max="+numberA+);
    max=numberA; 
}
else 
{
    max=numberB; 
}
if (max > numberC)
{
    Console.WriteLine("max="+max);
}
else 
{
    Console.WriteLine("max="+numberC);
}


