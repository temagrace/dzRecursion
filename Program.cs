// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


// void oneToN(int n, int m)
// {
//     if (n <= m)
//     {
//         Console.Write(n + " ");
//         oneToN(n + 1, m);      
//     }
// }
// oneToN(5, 10);



// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1


// void printTurnArray( int [] array, int i)
// {
    
//     if(i >= 0)
//     {
//         Console.Write(array[i] + " ");
//         printTurnArray(array, i - 1);
//     }
// }
// int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
// int i = 10;
// printTurnArray(array, i);

// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29

ulong Ackermann(ulong m, ulong n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }

   
        ulong n = 2;
        ulong m = 4;
        ulong result = Ackermann(m, n);
        Console.WriteLine("A({0}, {1}) = {2}", n, m, result);
   

