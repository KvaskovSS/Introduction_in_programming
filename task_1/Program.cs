//Task 1
// Console.WriteLine("Введите первое число");
// int first = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int second = Convert.ToInt32(Console.ReadLine());

// if(first > second){
//     Console.WriteLine($"max = {first} а min = {second}");
// }else if(second > first){
//     Console.WriteLine($"max = {second} а min = {first}");
// }

// //Task 2

// Console.WriteLine("Введите первое число");
// int first = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int second = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число");
// int third = Convert.ToInt32(Console.ReadLine());

// if(first > second && first > third)
// {
//     Console.WriteLine($"{first} наибольшее число");
// }else if(second > first && second > third){
//     Console.WriteLine($"{second} наибольшее число");
// }else if(third > first && third > second)
// {
//     Console.WriteLine($"{third} наибольшее число");
// }

// //Task 3
// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number % 2 == 0){
//     Console.WriteLine("Да(четное)");
// }else{
//     Console.WriteLine("Нет");
// }

//Task 4

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= number; i++){
    if(i % 2 == 0){
        Console.Write($"{i} ");
    }
}