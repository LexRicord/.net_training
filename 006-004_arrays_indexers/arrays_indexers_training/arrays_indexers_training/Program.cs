using arrays_indexers_training;

class Program
{
    static void Main()
    {
        task2();
        Console.WriteLine("\n\n");
        task3();
        Console.WriteLine("\n\n");
        task4();
        Console.ReadKey();
    }
    static void task2()
    {
        Console.WriteLine("Введите длину массива");
        var n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Длина массива неверна, попробуй другую цифру");
            Console.ReadKey();
            Environment.Exit(0);
        }
        else
        {
            int[] array = new int[n];
            Random random = new Random();
            // Во внешнем цикле выполняется проход по всем вложенным массивам.
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = random.Next(1, 100);
            }
            Console.Write("{");
            array.ToList().ForEach(i => Console.Write(i.ToString() + ", "));
            Console.Write("}\n");

            Console.WriteLine("Max number from the array:");
            Console.WriteLine(array.Max(i => i));
            Console.WriteLine("Min number from the array:");
            Console.WriteLine(array.Min(i => i));
            Console.WriteLine("Sum of all array values:");
            Console.WriteLine(array.Sum(i => i));
            Console.WriteLine("Average from the array:");
            Console.WriteLine(array.Average(i => i));

            Console.WriteLine("All odd from the array:");
            foreach (var value in array)
            {
                if (value % 2 == 1)
                    Console.WriteLine(value.ToString());
            }
        }
    }
    static void task3()
    {
        Console.WriteLine("Enter the number of rows");
        var rowNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of columns");
        var columnNumber = int.Parse(Console.ReadLine());

        if (rowNumber <= 0 || columnNumber <= 0)
        {
            Console.WriteLine("Матрица не может быть создана, неверное значение rows или columns");
            Console.ReadKey();
            Environment.Exit(0);
        }
        else
        {
            MyMatrix matrix = new MyMatrix(rowNumber, columnNumber);
            Console.WriteLine("Исходная матрица:");
            matrix.print();

            matrix.fillMatrix(matrix.getRows(), matrix.getCols());

            Console.WriteLine("\nМатрица после установки значений:");
            matrix.print();

            Console.WriteLine("\nПодматрицы разных порядков:");
            for (int order = 1; order <= Math.Min(matrix.getRows(), matrix.getCols()); order++)
            {
                MyMatrix submatrix = matrix.getSubmatrix(0, 0, order, order);
                Console.WriteLine($"Подматрица {order}x{order}:");
                submatrix.print();
            }

            matrix.resize(5, 5);
            Console.WriteLine("\nМатрица после изменения размеров:");
            matrix.print();
        }
    }
    static void task4()
    {
        Store store = new Store(3);
        store.addArticle(new Article("Товар 1", "Магазин A", 100), 0);
        store.addArticle(new Article("Товар 2", "Магазин B", 150), 1);
        store.addArticle(new Article("Товар 3", "Магазин C", 200), 2);

        Console.WriteLine("Введите номер товара для отображения информации:");
        int index = int.Parse(Console.ReadLine());

        Console.WriteLine("\nИнформация о товаре по номеру:");
        store.displayArticleByIndex(index);

        Console.WriteLine("\nВведите название товара для отображения информации:");
        string productName = Console.ReadLine();

        Console.WriteLine("\nИнформация о товаре по названию:");
        store.displayArticleByName(productName);
    }
}