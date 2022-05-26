// Найти сумму чисел одномерного массива, стоящих на нечетной позициии
Console.Clear();
int[]array={1,2,3,4,5,6};
for(int i=0;i<array.Length;i++) Console.Write($"{array[i]} ");
Console.WriteLine();
int sum = 0;
for (int i=0;i<array.Length;i++)
{
    if (i%2!=0)
    {
        sum=sum+array[i];
    }
}
Console.Write($"The sum of elements with uneven positions: {sum}");
