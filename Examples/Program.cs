Console.Clear();
//Пример 1:
string[,] table = new string[2, 5];
// table[0, 0] table[0, 1] table[0, 2] table[0, 3] table[0, 4]
// table[1, 0] table[1, 1] table[1, 2] table[1, 3] table[1, 4]
table[1, 2] = "Слово";
// for (int rows = 0; rows < 2; rows++) {
//     for (int columns = 0; columns < 5; columns++) {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
//}

// Пример 2:
/*
int[,] matrix = new int[3, 4];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine(); // для разделения строк принудительно
}
Console.WriteLine();
// Аналог:
int[,] matrix2 = new int[3, 4];
for (int i = 0; i < matrix2.GetLength(0); i++)
{  // matrix.GetLength(0) - количество строк
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {  // matrix.GetLength(1) - количество столбцов
        Console.Write($"{matrix2[i, j]} ");
    }
    Console.WriteLine(); // для разделения строк принудительно
}
Console.WriteLine();
*/
// Пример3: 
/*
void GetRandomMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine(); // для разделения строк принудительно
    }
}
int[,] matrix3 = new int[4, 5];
int[,] matrix4 = new int[2, 3];
GetRandomMatrix(matrix3);
Console.WriteLine();
GetRandomMatrix(matrix4);
*/
// Пример 4:
/*
int[,] pic = new int[,] {
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
    {0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,},
    {0,0,0,0,0,0,0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0,},
    {0,0,0,0,0,0,0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0,},
    {0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,},
    {0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,},
    {0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,},
    {0,0,0,0,0,0,0,1,1,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,},
    {0,0,1,1,1,1,1,0,0,0,0,1,1,1,1,1,1,1,1,1,1,0,0,0,0,},
    {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,},
    {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,},
    {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0,},
    {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,},
    {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,},
    {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0,},
    {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,},
    {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,},
    {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0,0,},
    {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,},
    {0,0,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,},
    {0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
};

void PrintImage(int[,] image) {
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i,j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine(); // для разделения строк принудительно
    }
}
PrintImage(pic);

void FillImage(int row, int col) {
    if (pic[row, col] == 0) {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col );
        FillImage(row, col + 1);
        
    }
}

FillImage(13, 13);
PrintImage(pic);
*/
// Рекурсия - функция которая вызывает сама себя.

// Пример 5: Факториал
/*
double Factorial(int n) {
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"Факториал {i} = {Factorial(i)}");
}
*/

// Пример 6: Фибоначи - следующее число задается предыдущими двумя

// f(1) = 1
// f(2) = 1
// f(3) = f(n-1) + f(n-2)

double Fibonacci (int n){
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2); 
}
for (int i = 1; i < 10; i++)
{
    Console.WriteLine($"{i} = {Fibonacci(i)}");
}