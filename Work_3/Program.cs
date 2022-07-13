//Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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
            Console.Write ($"|{array[i,j]} ");
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
            matr[i,j]=random.Next(1, 10);
        }
    }
}

void Average (double [,] matr)
{

    int j = 0;
for (j =0 ;j < matr.GetLength(1); j++)
{
    double sum = 0;
    int i =  0;
    for(i = 0; i < matr.GetLength(0); i++)
        {
        sum = matr[i,j]+sum;
        
        }
Console.Write($"Среднее арифметическое {j+1}-ого столбца = ");        
Console.WriteLine("{0,2:F2}",sum/matr.GetLength(0));
}    
}
int m = Prompt("Введите количество строк - > ");
int n = Prompt("Введите количество столбцов - > ");
double [,] matrix = new double[m,n];
FillArray(matrix);
PrintArray(matrix);
Average(matrix);
