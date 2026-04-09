using System;

class Program
{
    static void Main()
    {
        // ===== 1. ОДНОВИМІРНИЙ МАСИВ =====
        Console.Write("Введіть розмір масиву: ");
        int n = int.Parse(Console.ReadLine());

        double[] arr = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"arr[{i}] = ");
            arr[i] = double.Parse(Console.ReadLine());
        }

        // інтервал
        Console.Write("Введіть нижню межу: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введіть верхню межу: ");
        double b = double.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            if (arr[i] >= a && arr[i] <= b)
                arr[i] = 0;
        }

        // максимум → 0
        double max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == max)
                arr[i] = 0;
        }

        Console.WriteLine("Масив після обробки:");
        foreach (var x in arr)
            Console.Write(x + " ");
        Console.WriteLine();


        // ===== 2. МАТРИЦЯ =====
        Console.Write("Введіть кількість рядків: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введіть кількість стовпців: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        // введення
        Console.WriteLine("Введіть елементи матриці:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"[{i},{j}] = ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // перестановка стовпців
        for (int j = 0; j < cols / 2; j++)
        {
            for (int i = 0; i < rows; i++)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[i, cols - j - 1];
                matrix[i, cols - j - 1] = temp;
            }
        }

        Console.WriteLine("Матриця після перестановки:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }

        // ===== 3. ПІДРАХУНОК =====
        Console.Write("Введіть число k: ");
        int k = int.Parse(Console.ReadLine());

        int[] result = new int[rows];

        for (int i = 0; i < rows; i++)
        {
            int count = 0;

            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] > k)
                    count++;
            }

            result[i] = count;
        }

        Console.WriteLine("Кількість елементів > k у кожному рядку:");
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine($"Рядок {i}: {result[i]}");
        }
    }
}
