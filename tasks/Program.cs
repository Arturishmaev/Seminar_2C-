// Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа.
int x = new Random().Next(10, 100);
System.Console.WriteLine($"Возьмем переменную {x}. Покажем наибольшую цифру числа.");
int maxnumber = x / 10;
int minnumber = x % 10;
if (maxnumber > minnumber)
{
    System.Console.WriteLine(maxnumber);
}
else
{
    System.Console.WriteLine(minnumber);
}

//Напишите программу ,которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
int x = new Random().Next(100, 1000);
System.Console.WriteLine($"Введем переменную {x}. Удалим вторую цифру этого числа.");
int a = x / 100;
int b = x / 10;
int c = x % 10;
System.Console.Write($"Ответ {a}");
System.Console.Write(c);*/

//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
System.Console.WriteLine("Введите первое число :");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число :");
int b = Convert.ToInt32(Console.ReadLine());
if (a % b == 0)
{
    System.Console.WriteLine($"Число {a} кратное числу {b}");
}
else
{
    System.Console.WriteLine($"Число {a} не кратно числу {b} остаток {a % b}");
}
//Напишите программу ,которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
int a = 7;
int b = 23;
System.Console.WriteLine("Введите Ваше число : ");
int num = Convert.ToInt32(Console.ReadLine());
if(num % 7 == 0 && num % 23 == 0)
{
    System.Console.WriteLine($"Число {num} кратно  числам {a} {b}");
}
else
{
    System.Console.WriteLine($"Число {num} не кратно числам {a} {b}");
}


// Программа: возрастные группы.
System.Console.WriteLine("Введите ваш возраст :");
int age = Convert.ToInt32(Console.ReadLine());

if (age <= 13)
{
    System.Console.WriteLine("Вы еще ребенок");
}
else if (age > 13 && age <= 24)
{
    System.Console.WriteLine("Вы в молодом возрасте");
}
else if (age > 24 && age <= 59)
{
    System.Console.WriteLine("Вы в зрелом возрасте");
}
else if (age > 59 && age <= 85)
{
    System.Console.WriteLine("Вы в старческом возрасте");
}
else if (age > 85 && age <= 126)
{
    System.Console.WriteLine("Вы долгожитель");
}
else  
{
    Console.WriteLine("столько еще никто не прожил");
}




