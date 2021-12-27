// Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел.
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом.


Console.WriteLine("Введите количество элементов в массиве:");
int n = Convert.ToInt32(Console.ReadLine());

void CreateArrayA(int[] A)
{
    Random random = new Random();
    for (int i = 0; i < A.Length; i++)
    {
        A[i] = random.Next(1, 10);
    }
}

void PrintArrayA(int[] A)
{
    for (int i = 0; i < A.Length; i++)

    {
        Console.Write($"{A[i]} ");
    }
}
void PrintArrayB(int[] A, int[] B)

{

    for (int i = 0; i < n; i++)
    {

        for (int j = 0; j < n; j++)

            if (A[i] % 2 == 0)
            {
                B[j] = A[i];

                Console.Write($"{B[j]} ");
                break;
            }

    }
}
int[] A = new int[n];
int[] B = new int[n];
CreateArrayA(A);
Console.Write("Заданный массив: ");
PrintArrayA(A);
Console.Write("\nMассив из четных элиментов: ");
PrintArrayB(A, B);