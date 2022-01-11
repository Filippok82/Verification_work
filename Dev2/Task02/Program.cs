//  Написать программу, которая из имеющегося массива целых чисел формирует массив из чисел, больших 8.

int [] arrayA = new int[20];
int[] FillArray(int[] array)   // Заполнение массива 
{
 Random random = new Random();
    for(int i=0; i<array.Length; i++) 
        {
            array[i] = random.Next(-25,25);
        } 
    return array;
}

void PrintArray(int[] array)  // Распечатка массива
{
    for(int i=0; i<array.Length; i++) 
    {
            Console.Write($" {array[i],4}");
        
    }  
    Console.WriteLine();
}

int[] SearchElement(int[] array)  // Поиск элементов больше 8 в  массиве А и помещение в массив Б
{
    int n = 0;
    int j = 0;
    for(int i=0; i<array.Length;i++)
    {
        if(array[i]>8) 
        {
            n++;
        }
    }
    int[] arrayB = new int[n];
    for(int i=0; i<array.Length;i++)
    {
        if(array[i]>8) 
        {
            arrayB[j] = array[i];      
   
            j++;
        }
    }
    
    return arrayB; 
}

FillArray(arrayA);
Console.Write("Первоначальный массив:");
PrintArray(arrayA);
Console.Write("Массив из элементов, больше 8:");
PrintArray(SearchElement(arrayA)); 