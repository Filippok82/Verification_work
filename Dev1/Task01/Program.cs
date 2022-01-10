//Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел.


Console.WriteLine("Введите количество элементов в массиве: ");
int n= Convert.ToInt32(Console.ReadLine());
int [] arrayA = new int[n];
int[] FillArray(int[] array)   // Заполнение массива 
{
 Random random = new Random();
    for(int i=0; i<array.Length; i++) 
        {
            array[i] = random.Next(1,25);
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

int[] SearchEven(int[] array)  // Поиск четных элементов в  массиве А и помещение в массив Б
{
    int n = 0;
    int j = 0;
    for(int i=0; i<array.Length;i++)
    {
        if(array[i]%2==0) 
        {
            n++;
        }
    }
    int[] arrayB = new int[n];
    for(int i=0; i<array.Length;i++)
    {
        if(array[i]%2==0) 
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
Console.Write("Массив из четных элементов:");
PrintArray(SearchEven(arrayA)); 