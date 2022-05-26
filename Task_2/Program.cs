
int[]array={-1,2,3,4,5,-6};
for(int index=0;index<array.Length;index++) Console.Write($"{array[index]} ");
Console.WriteLine();
Console.Write("Enter your number: ");
int find = int.Parse(Console.ReadLine()??"0");
int check=0;
for(int index=0;index<array.Length;index++)
{
    if (array[index]==find)
    {
        Console.Write($"Your number is present in the array");
        check=1;
        break;
    }
}
if (check==0) Console.Write($"Your number is not present in the array");
