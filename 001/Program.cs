// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Console.Write("Введите количество строк m: "); 
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] array = new double[m,n];
// double [,] temp = new double[m,n];

// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// //PrintArray(temp);

// for (int i = 0; i < m; i++)
// {
//     for(int j = 0; j < n; j++)
//     {
//         temp[i,j] = array[i,j];
//         temp[0,j]=array [m-1,j];
//         temp[m-1,j]=array[0,j];
//         Console.Write(temp[i,j]  +  " ");
        
//     }
//     Console.WriteLine();
// }
// //МЕТОД ПЕЧАТИ МАССИВА
// void PrintArray(double[,] matr) 
// {
//     for (int rows = 0; rows < matr.GetLength(0); rows++)
//     {
//         for (int columns = 0; columns < matr.GetLength(1); columns++)
//         {
//             Console.Write($" {matr[rows, columns]} ");   
//         }
//         Console.WriteLine();
//     }
// }
// // МЕТОД ЗАПОЛНЕНИЯ МАССИВА
// void FillArray(double[,] matr) 
// {
//     for (int rows = 0; rows < matr.GetLength(0); rows++)
//     {
//         for (int columns = 0; columns < matr.GetLength(1); columns++)
//         {
//             matr[rows,columns] = new Random().Next(1,11); 
//         }
//         Console.WriteLine();
//     }
// }


// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.Write("Введите количество строк m: "); 
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m,n];

FillArray(array);
PrintArray(array);
Console.WriteLine();

double [,] newArray = GetMirrorArray(array);
PrintArray(newArray);


double[,] GetMirrorArray(double[,] array)
{
    double[,] newArray = new double[array.GetLength(1), array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            newArray[j, i] = array[i, j];

    return newArray;
}



//МЕТОД ПЕЧАТИ МАССИВА
void PrintArray(double[,] matr) 
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($" {matr[rows, columns]} ");   
        }
        Console.WriteLine();
    }
}
// МЕТОД ЗАПОЛНЕНИЯ МАССИВА
void FillArray(double[,] matr) 
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            matr[rows,columns] = new Random().Next(1,11); 
        }
        Console.WriteLine();
    }
}





