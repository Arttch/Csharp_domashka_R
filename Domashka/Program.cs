
 
 
    
    {
        Console.Write("Введите значение M: "); 
        int.TryParse(Console.ReadLine(), out int M);
 
        Console.Write("Введите значение N: "); 
        int.TryParse(Console.ReadLine(), out int N);
    
        PrintNaturalNumbers(M, N); 
    }
 
    static void PrintNaturalNumbers(int current, int N)
    {
        if (current <= N) 
        { 
            Console.Write(current + " "); 
            PrintNaturalNumbers(current + 1, N); 
        } 
    }
