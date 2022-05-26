// Написать программу замены элементов массива на противоположные
int[]array={-1,2,-3,4,5,-6};
for(int index=0;index<array.Length;index++) Console.Write($"{array[index]} ");
Console.WriteLine();   
for(int i=0;i<array.Length;i++) Console.Write($"{array[i]*(-1)} ");
