int[,] create_array(int row, int column)
{
int[,] array = new int[row,column];
Random random = new Random();
for(int i=0;i<row;i++)
{
    for(int j=0;j<column;j++)
    {
        
        array[i,j] = random.Next(1,10);
    }
}
return array;
}

void print_array(int[,] array)
{
for(int i=0;i<array.GetLength(0);i++)
{
    for(int j=0;j<array.GetLength(1);j++)
    {
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}
}

int[,] exponentiation(int[,] array_exp)
{
    for(int i=0;i<array_exp.GetLength(0);i++)
    {
        for(int j=0;j<array_exp.GetLength(1);j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
            array_exp[i,j] = array_exp[i,j] * array_exp[i,j];
        }
    }
    return array_exp;
}
Console.WriteLine("Введите число строк двумерного массива: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов двумерного массива: ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = create_array(m,n);
print_array(array);
Console.WriteLine();
int[,] array_exp = exponentiation(array);
print_array(array_exp);



