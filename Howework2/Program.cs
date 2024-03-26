Console.Write("Введите номер задания: ");
string str = Console.ReadLine();

if (str == "1")
{
    Console.Write("Введите значение первого числа: ");
    double operand1 = double.Parse(Console.ReadLine());
    Console.Write("Введите значение второго числа: ");
    double operand2 = double.Parse(Console.ReadLine());
    Console.Write("Выберите действия над числами: ");
    string sign = Console.ReadLine();
    switch (sign)
    {
        case ("+"):
            Console.WriteLine("Сумма двух чисел = " + (operand1 + operand2));
            break;
        case ("-"):
            Console.WriteLine("Разность двух чисел = " + (operand1 - operand2));
            break;
        case ("*"):
            Console.WriteLine("Умножение двух чисел = " + (operand1 * operand2));
            break;
        case ("/"):
            if (operand2 != 0)
                Console.WriteLine("Сумма двух чисел = " + (operand1 / operand2));
            else Console.WriteLine("Деление на ноль невозможно. Математическая ошибка!");
            break;
        default:
            Console.WriteLine("Такую операцию мы не предусмотрели.");
            break;
    }
}

else if (str == "2")
{
    Console.WriteLine("Введите число: ");
    int number = int.Parse(Console.ReadLine());
    if (number >= 0 && number <= 14) Console.WriteLine("Число, введенное пользователем попадает в диапазон чисел от 0 до 14");
    else if (number >= 15 && number <= 35) Console.WriteLine("Число, введенное пользователем попадает в диапазон чисел от 15 до 35");
    else if (number >= 36 && number < 50) Console.WriteLine("Число, введенное пользователем попадает в диапазон чисел от 36 до 50");
    else if (number > 50 && number <= 100) Console.WriteLine("Число, введенное пользователем попадает в диапазон чисел от 50 до 100");
    else Console.WriteLine("Число, введенное пользователем не попадает ни в один промежуток!");
}

else if (str == "3")
{

    Console.WriteLine("Наш переводчик довольно маленький, но мы можем попробовать. Введите слово на русском, а мы переведем. ");
    string word = Console.ReadLine();
    switch (word)
    {
        case ("Снежно")://snowy
            Console.WriteLine("Snowy");
            break;
        case ("Пасмурно")://cloudy
            Console.WriteLine("cloudy");
            break;
        case ("Солнечно"): //sunny
            Console.WriteLine("sunny");
            break;
        case ("Дождливо"): //rainy
            Console.WriteLine("rainy");
            break;
        case ("Жарко"): //hot
            Console.WriteLine("hot");
            break;
        case ("Душно"): //stuffy
            Console.WriteLine("stuffy");
            break;
        case ("Теплая")://warm
            Console.WriteLine("warm");
            break;
        case ("Холодная"): //cold
            Console.WriteLine("cold");
            break;
        case ("Влажно")://wet
            Console.WriteLine("wet");
            break;
        default:
            Console.WriteLine("Упс, такое мы не знаем, но скоро добавим перевод!");
            break;
    }

}

else if (str == "4")
{
    Console.WriteLine("Введите число: ");
    int number = int.Parse(Console.ReadLine());
    Console.WriteLine("По первому варианту решения задачи: ");
    if (number % 2 == 0) Console.WriteLine("Число является четным!");
    else Console.WriteLine("Число является нечетным!");

    Console.WriteLine("По второму варианту решения задачи: ");
    if (number % 2 == 1) Console.WriteLine("Число является нечетным!");
    else Console.WriteLine("Число является четным!");

}
else
{ Console.WriteLine("А такого задания не было! :) "); }
