// Написать программу, которая из имеющегося массива целых чисел формирует массив из чисел, больших 8.
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 




void CreateArrayA(int[] A)
{
    Random random = new Random();
    for (int i = 0; i < A.Length; i++)
    {
        A[i] = random.Next(1, 25);
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

    for (int i = 0; i < A.Length; i++)
    {

        for (int j = 0; j < B.Length; j++)
        {
            int m=8;
            if (A[i] > m)
            {
                B[j] = A[i];

                Console.Write($"{B[j]} ");
                break;
            }
        }
    }
}

int[] A = new int[10];
int[] B = new int[10];
CreateArrayA(A);
Console.Write("Заданный массив: ");
PrintArrayA(A);
Console.Write("\nMассив из элементов, больше 8: ");
PrintArrayB(A, B);