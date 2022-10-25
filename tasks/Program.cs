// // Задача 39: Напишите программу, которая перевернёт одномерный массив 
// // (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// void Zadacha39()
// {
//     int size = 10;
//     int[] numbers = new int[size];
//     FillArray(numbers, -10, 10);
//     PrintArray(numbers);
//     ReverceArray(numbers);

// }


// void ReverceArray(int[] numbers)
// {
//     int size = numbers.Length;
//     int maxIndex = size - 1;

//     for (int i = 0; i < size / 2; i++)
//     {
//         // int temp = numbers[i];
//         // numbers[i]= numbers[maxIndex-i];
//         // numbers[maxIndex-i]=temp;
//         (numbers[i], numbers[maxIndex - i]) = (numbers[maxIndex - i], numbers[i]);
//     }
//     PrintArray(numbers);

// }


// void FillArray(int[] numbers,
//                    int minValue = 0,
//                    int maxValue = 9)
// {
//     maxValue++;
//     int size = numbers.Length;
//     Random random = new Random();
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = random.Next(minValue, maxValue);
//     }
// }
// void PrintArray(int[] numbers)

// {
//     int size = numbers.Length;
//     Console.WriteLine("Вывод массива");

//     for (int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");

//     }
//     Console.WriteLine();
// }
// Zadacha39();


// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник со сторонами такой длины.

// void Zadacha40()
// {
//     Console.WriteLine("Введите первое число:");
//     int a = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите второе число:");
//     int b = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите третье число:");
//     int c = Convert.ToInt32(Console.ReadLine());

//     if (a + b > c && a + c > b && b + c > a)
//     { 
//         Console.WriteLine("Треугольник существует");
//     }
// else
// {
//     Console.WriteLine("Треугольник не существует:");
// }
// }

// Zadacha40();

//  Задача 42: Напишите программу,
//  которая будет преобразовывать десятичное число в двоичное.

// void Zadacha42()
// {
//     int number = 43;
//     string result= "  ";

//     while (number > 0)
//     {
//        result = number%2 + result;
//         number /=2;
//     }
//     Console.WriteLine(result);
// }

// Zadacha42();

// void  Zadacha422()
// {
//     int number=43;
//     string result = Convert.ToString(number, 2);
//     Console.WriteLine(result);

// }
// Zadacha422();

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.

// void Zadacha44()

// {
//     int a = 0;
//     int b = 1;
//     Console.WriteLine("Введите число N :");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int[] numbers = new int[size];
//     numbers[0] = a;
//     numbers[1] = b;
//     for (int i = 2; i < size; i++)
//     {
//         numbers[i] = numbers[i - 2] + numbers[i - 1];
//     }
//     PrintArray(numbers);
// }

// void PrintArray(int[] numbers)

// {
//     int size = numbers.Length;
//     Console.WriteLine("Вывод массива");

//     for (int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");

//     }
//     Console.WriteLine();
// }

// Zadacha44();

// Задача 45: Напишите программу, которая будет создавать 
// копию заданного массива с помощью поэлементного копирования

void Zadacha45()

{
    int size = 10;
    int[] numbers = new int[size];
    int[] other = new int[size];
    FillArray(numbers);
    PrintArray (numbers);

    for (int i = 0; i < size; i++)
    {
        other[i] = numbers[i];
    }
    Console.WriteLine();
    PrintArray (other);
       
}
    void FillArray(int[] numbers)

    {

        int size = numbers.Length;
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(0, 10);
        }
    }
    void PrintArray(int[] numbers)

{
    int size = numbers.Length;
    Console.WriteLine("Вывод массива");

    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");

    }
    Console.WriteLine();
}

Zadacha45();