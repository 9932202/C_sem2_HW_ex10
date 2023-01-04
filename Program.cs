/* Задача 10: Напишите программу, которая принимает
 на вход трёхзначное число и на выходе показывает 
 вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */
Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 100 || number > 999){
    Console.WriteLine($"Число {number} не является трехзначным");
} // Проверка на трехзначность 

int Divite(int number){
    int result = number / 10;
    return result;
}

int SecondNamber(int number){
    int result = number % 10;
    return result;
}

int div = Divite(number);
int result = SecondNamber(div);

Console.WriteLine($"вторая цифра числа: {result}");
