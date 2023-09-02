static void Main()
{
    int n;

    Console.WriteLine("Введите длину массива");
    n = Console.Read();

    if (n < 0 && n == 0) 
        Console.WriteLine("Длина массива неверна, попробуй другую цифру");

    int[] jagged = new int[n];

    // Во внешнем цикле выполняется проход по всем вложенным массивам.
    for (int i = 0; i < jagged.Length; ++i)
    {
        // Во внутреннем цикле выполняется обращение к каждому элементу вложенного массива.
        for (int j = 0; j < jagged[i].Length; ++j)
        {
            Console.Write("{0} ", jagged[i][j]);
        }
        Console.Write("\n");
    }


    // Delay.
    Console.ReadKey();
}