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
    int num = new Random().Next(100, 999);
    array[i] = num;
  }
  return array;
}

int GetEvenNumbersQuantityFromArray(int[] incomingArray)
{
  int incomingArrayLength = incomingArray.Length;
  int count = 0;

  for (int i = 0; i < incomingArrayLength; i++)
  {
    if (incomingArray[i] % 2 == 0) count++;
  }
  return count;
}

Console.Write("Введите длину массива ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
arrayLength = Math.Abs(arrayLength);

int[] generatedArray = GenerateArray(arrayLength);
PrintArray(generatedArray, "Сгенерированный массив");
int evenNumbersQuantity = GetEvenNumbersQuantityFromArray(generatedArray);
Console.Write($"Количество четных чисел = {evenNumbersQuantity}");