Console.WriteLine("Введите первое число");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int second = Convert.ToInt32(Console.ReadLine());

if(first > second){
    Console.WriteLine($"max = {first}");
}else if(second > first){
    Console.WriteLine($"max = {second}");
}