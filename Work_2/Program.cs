
//Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


int Prompt(string length) 
{
    System.Console.Write (length);

    return int.Parse(Console.ReadLine());
}

void PrintArray(int [,] array) 
{    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,7:F0}", array[i, j]);;           
        }
        Console.WriteLine();
    }
    
}
void FillArray(int [,] matr)
{  
    Random random = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j]=random.Next(-10, 10);
        }
    }
    
}

void NumberArray(int x, int y ,int [,] matr)
{
if(x > matr.GetLength(0)-1 || y > matr.GetLength(1)-1 )
    {
        Console.Write("Такого элемента нет");
    }
else if(x < 0 || y < 0 )
    {
        Console.Write("Вы ввели отрицательное число");
    }
        
    
else  Console.WriteLine($"Искомое число в массиве -> {matr[x,y]}");
}
int m = Prompt("Введите кол-во строк - > ");
int n = Prompt("Введите кол-во столбцов > ");
int [,] matrix = new int[m,n ];
FillArray(matrix);
PrintArray(matrix);
int  x = Prompt("Введите число x - > ");
int  y = Prompt("Введите число y - > ");
NumberArray(x,y, matrix);