/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите число: ");
string number = Console.ReadLine() ?? "";
char middle = number[1];
Console.WriteLine(middle);


/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число: ");
string numb = Console.ReadLine() ?? "";
char midle = numb[0];
if (numb.Length > 2) {
    midle = numb[2];
    Console.WriteLine(midle);
} else {
    Console.WriteLine("Третьей цифры нет!!");
}



/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите число от 1 до 7: ");
int numberDay = Int16.Parse(Console.ReadLine() ?? "");

if (numberDay == 1) {
    Console.WriteLine("Monday");
} else if (numberDay == 2) {
    Console.WriteLine("Tusday");
} else if (numberDay == 3) {
    Console.WriteLine("Wednesday");
} else if (numberDay == 4) {
    Console.WriteLine("Thursday");
} else if (numberDay == 5) {
    Console.WriteLine("Friday");
} else if (numberDay == 6) {
    Console.WriteLine("Saturday is a day off!");
} else if (numberDay == 7) {
    Console.WriteLine("Sunday is day off!");
}