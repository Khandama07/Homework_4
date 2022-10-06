void PrintArray(double[] array, string message)
{
  string printable = string.Join(", ", array);
  Console.WriteLine($"{message}: [{printable}]");
}

double[] GenerateArray(int arrayLength)
{
  double[] array = new double[arrayLength];
  for (int i = 0; i < arrayLength; i++)
  {
    double num = Math.Round((new Random().NextDouble() * 100), 2);
    array[i] = num;
  }
  return array;
}

double GetMaxAndMinValSumFromArray(double[] incomingArray)
{
  double max = incomingArray[0];
  double min = incomingArray[0];

  for (int i = 0; i < incomingArray.Length; i++)
  {
    if (max < incomingArray[i]) max = incomingArray[i];
    if (min > incomingArray[i]) min = incomingArray[i];
  }
  return Math.Round(max - min, 2);
}


Console.Write("Введите длину массива ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
arrayLength = Math.Abs(arrayLength);

double[] generatedArray = GenerateArray(arrayLength);
PrintArray(generatedArray, "Сгенерированный массив");
double sum = GetMaxAndMinValSumFromArray(generatedArray);
Console.Write($"Разность между максимальным и минимальным элементом массива = {sum}");
