using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Создание стека для хранения чисел
        Stack<int> numberStack = new Stack<int>();

        // Добавление чисел в стек
        numberStack.Push(3);
        numberStack.Push(1);
        numberStack.Push(2);
        numberStack.Push(5);
        numberStack.Push(4);
        numberStack.Push(6);
        numberStack.Push(7);
        numberStack.Push(2);
        numberStack.Push(8);
        numberStack.Push(3);
        numberStack.Push(9);

        // Создание временного стека для хранения четных чисел
        Stack<int> evenStack = new Stack<int>();

        // Создание временного стека для хранения нечетных чисел
        Stack<int> oddStack = new Stack<int>();

        // Разделение чисел на четные и нечетные и помещение их в соответствующие стеки
        while (numberStack.Count > 0)
        {
            int number = numberStack.Pop();
            if (number % 2 == 0)
            {
                evenStack.Push(number);
            }
            else
            {
                oddStack.Push(number);
            }
        }

        // Вывод всех четных чисел, а затем всех нечетных чисел
        Console.WriteLine("Четные и нечетные числа:");
        while (evenStack.Count > 0)
        {
            Console.Write(evenStack.Pop());
        }
        while (oddStack.Count > 0)
        {
            Console.Write(oddStack.Pop());
        }
    }
}






