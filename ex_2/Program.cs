void PrintArray(int[] array, string message)
{
  string printable = string.Join(", ", array);
  Console.WriteLine($"{message}: [{printable}]");
}

int[] GenerateArray(int arrayLength)
{
  int[] array = new int[arrayLength];
  for (int i = 0; i < arrayLength; i++)
  {
    int num = new Random().Next(0, 100);
    array[i] = num;
  }
  return array;
}

int GetSumOddIndexValFromArray(int[] incomingArray)
{
  int incomingArrayLength = incomingArray.Length;
  int sum = 0;

  for (int i = 0; i < incomingArrayLength; i++)
  {
    if (i % 2 != 0) sum = sum + incomingArray[i];
  }
  return sum;
}

Console.Write("Введите длину массива ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
arrayLength = Math.Abs(arrayLength);

int[] generatedArray = GenerateArray(arrayLength);
PrintArray(generatedArray, "Сгенерированный массив");
int sum = GetSumOddIndexValFromArray(generatedArray);
Console.Write($"Сумма нечетных элементов = {sum}");
