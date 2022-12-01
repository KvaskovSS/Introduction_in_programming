Console.WriteLine("Введите первое число");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int second = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int third = Convert.ToInt32(Console.ReadLine());

if(first > second && first > third)
{
    Console.WriteLine($"{first} наибольшее число");
}else if(second > first && second > third){
    Console.WriteLine($"{second} наибольшее число");
}else if(third > first && third > second)
{
    Console.WriteLine($"{third} наибольшее число");
}