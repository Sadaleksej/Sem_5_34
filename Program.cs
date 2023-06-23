// See https://aka.ms/new-console-template for more information
Console.Clear();
int[] arrr = new int[30];
FilArray(arrr);
PrintArray(arrr);
Console.WriteLine();
Console.WriteLine($"Количество нечетных: {NumbersEven(arrr)}");

void FilArray(int[] ar)
{
    for (int i = 0; i < ar.Length; i++) ar[i] = new Random().Next(100, 999);
}

void PrintArray(int[] ar)
{
    for (int i = 0; i < ar.Length; i++) Console.Write(ar[i] + " ");
}
int NumbersEven(int[] ar)
{
    int num = 0;
  foreach (int el in ar) 
    {
    if(el % 2 == 0) num++ ;
    }
return num;
}


