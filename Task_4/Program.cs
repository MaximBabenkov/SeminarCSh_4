// В массиве вещественных чисел найти разницу 
// между максимальным и минимальным элементами
Console.Clear();
double[]array={1.8f,-8,3.65f,4.21f,9.87f,6.05f};
for(int i=0;i<array.Length;i++) Console.Write($"{Math.Round(array[i],2)}  ");
Console.WriteLine();
int min=0;
int max=0;
for(int i=0;i<array.Length;i++)
{
    if (array[i]<array[min]) min=i;
    else if (array[i]>array[max]) max=i;
}
Console.WriteLine($"The diffirence between maximal and minimal elements: ");
 Console.Write(Math.Round((array[max]-array[min]),2));
