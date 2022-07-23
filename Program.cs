/*
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // В итоге получается вот такой массив:
        // 7 4 2 1
        // 9 5 3 2
        // 8 4 4 2
internal class Program
{
    private static void Main(string[] args)
    {
        
        
        int [,] GetArray(int m, int n, int min, int max)
        {
            int [,] result = new int [m,n];
            for (int i = 0; i <m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result [i,j] = new Random().Next(min, max+1);
                }
            }
        return result;
        }
        void PrintArray(int [,] inArray)
        {
            for (int i = 0; i < inArray.GetLength(0); i++)
            {
                for (int j = 0; j < inArray.GetLength(1); j++)
                {
                    Console.Write($"\t {inArray[i,j]} ");
                }
            Console.WriteLine();
            }

        }
        void SortArray(int [,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int t = j+1; t < array.GetLength(1); t++)
                    {
                        if (array[i,t]>array[i,j])
                        {
                            int temp = array[i,j];
                            array[i,j] = array[i,t];
                            array[i,t] = temp;
                        }
                    }
                }
            }
        }
        Console.Clear();
        Console.Write("Введите количество строк массива: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество стобцов массива: ");
        int colomns = Convert.ToInt32(Console.ReadLine());
        int [,] array = GetArray(rows,colomns,0,10);
        PrintArray(array);
        SortArray(array);
        Console.WriteLine();
        PrintArray(array);
    }
}
*/
/*
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка
internal class Program
{
    private static void Main(string[] args)
    {
        int [,] GetArray(int m, int n, int min, int max)
        {
            int [,] result = new int [m,n];
            for (int i = 0; i <m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result [i,j] = new Random().Next(min, max+1);
                }
            }
        return result;
        }
        void PrintArray(int [,] inArray)
        {
            for (int i = 0; i < inArray.GetLength(0); i++)
            {
                for (int j = 0; j < inArray.GetLength(1); j++)
                {
                    Console.Write($"\t {inArray[i,j]} ");
                }
            Console.WriteLine();
            }

        }
        int GetRowNumber(int [,] array)
        {
            int row = 0;
            int minsum = 0;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                minsum = minsum + array[0,i];
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum = sum + array[i,j];
                }
            
                if (minsum> sum)
                {
                    minsum = sum;
                    row = i;
                }

            }

        return row;
        }
        Console.Clear();
        Console.Write("Введите количество строк массива: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество стобцов массива: ");
        int colomns = Convert.ToInt32(Console.ReadLine());
        int [,] array = GetArray(rows,colomns,0,10);
        PrintArray(array);
        Console.WriteLine($"Строка с наименьшей суммой - {GetRowNumber(array)+1}");//Для визуального вывода
        // добавим 1, индексы строки и столбцов в массиве начинаюся с нуля. 
        Console.WriteLine();
    }
}
*/
// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

/*
internal class Program
{
    private static void Main(string[] args)
    {
        
        
        int [,,] GetArray(int[] sizes, int min, int max)
        {
            int [,,] result = new int [sizes[0], sizes[1], sizes[2]];
            for (int i = 0; i <result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    int k = 0;
                    while (k < result.GetLength(2) )
                    {
                        int element = new Random().Next(min, max+1);
                        if (FindElement(result, element)) continue;
                        {
                            result [i,j,k] = element;
                            k++;
                        }
                    }
                }
                
            }
        return result;
        }
        void PrintArray(int [,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                               
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
                    }
                Console.WriteLine();  
                }
            Console.WriteLine();
            }

        }
        bool FindElement(int [,,] array, int el)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        if (array[i,j,k]==el) return true;
                        {
                            
                        }
                    }
                }
            }
        return false;
        }

        Console.Clear();
        Console.Write("Введите размеры массива через пробел: ");
        string[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        int [,,] array = GetArray(new int [] {Convert.ToInt32(nums[0]), Convert.ToInt32(nums[1]), Convert.ToInt32(nums[2])}, 10, 99);
        PrintArray(array);
        
    }
}
*/

// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

void PrintArray(int [,] inArray)
        {
            for (int i = 0; i < inArray.GetLength(0); i++)
            {
                for (int j = 0; j < inArray.GetLength(1); j++)
                {
                    Console.Write($"\t {inArray[i,j]} ");
                }
            Console.WriteLine();
            }
        }

int [,] GetArray (int size)
{
int [,] result = new int [size, size];
int i = 0; 
int j = 0;
int rowE = size - 1;
int columnE = size - 1;
int rowS = 0; 
int columnS = 0;
bool left = true;
bool top = true;
int count = 0;
while (count < size*size)
{
    count++;
    result [i,j] = count;
    // шагаем вправо
    if (left && top)
    {
        if (j == columnE)
        {
            rowS++;
            top = true;
            left =false;
            i++;
            continue;
        }
        else
        {
            j++; continue;
        }
    }
    // шагаем вниз
    if (!left && top)
    {
        if (i == rowE)
        {
            columnE --;
            top = false;
            left = false;
            j--;
            continue;
        }
        else
        {
            i++;
            continue;
        }
    }
    // шагаем влево
    if (!left == !top)
    {
        if (j == columnS )
        {
            rowE --;
            top = false;
            left = true;
            i--;
            continue;
        }
        else
        {
            j--;
            continue;
        }
    }
    // шагаем вверх
    if (left && !top)
    {
        if (i == rowS)
        {
            columnS++;
            top = true;
            left = true;
            j++;
            continue;
        }
        else
        {
            i--;
            continue;
        }
    }
}
return result;
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int s = Convert.ToInt32(Console.ReadLine());
int [,] arr = GetArray(s);
PrintArray(arr);




