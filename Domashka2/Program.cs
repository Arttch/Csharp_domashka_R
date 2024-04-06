
 



    
        int[] myArray = { 10, 20, 30, 40, 50 }; 
 
        Console.WriteLine("Элементы массива, начиная с конца:"); 
        PrintArrayReverse(myArray, myArray.Length - 1); 
    
 
     void PrintArrayReverse(int[]  myArray, int index) 
    { 
        if (index >= 0) 
        { 
            Console.Write(myArray[index] + " "); 
            PrintArrayReverse(myArray, index - 1); 
        } 
    } 
