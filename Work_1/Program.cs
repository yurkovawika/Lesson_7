///Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int Prompt(string length) 
{
    System.Console.Write (length);

    return int.Parse(Console.ReadLine());
}

void PrintArray(double [,] array) 
{    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ( j%10 == 0 ||i%10 == 0 )
            {
                Console.Write("{0,6:F1}", array[i, j]);;
            }
            else
            {
                Console.Write("{0,6:F1}", array[i, j]);
            }
            
        }
        Console.WriteLine();
    }
    
}
void FillArray(double [,] matr)

{  
    Random random = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j]=random.Next(-10, 10) + random.NextDouble();
        }
    }
    
}
int m = Prompt("Введите кол-во строк - > ");
int n = Prompt("Введите кол-во столбцов - > ");
double [,] matrix = new double [m,n];
FillArray(matrix);
PrintArray(matrix);
