void PrintArraiy(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "; ");
    }
}

Console.WriteLine("Введите количество значений, которое хотите проверить : ");
int size = Convert.ToInt32(Console.ReadLine());

string[] inputArray = new string[size];

for(int i = 0; i < inputArray.Length; i++)
{
    Console.WriteLine($"Введите значение № {i+1}: ");
    inputArray[i] =  Console.ReadLine()!;

    if (inputArray[i] == null)
    {
        inputArray[i] = "";
    }
}

int count = 0;

for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Length <= 3)
    {
        count++;
    }
}

string[] outputArray = new string[count];

for (int i = 0; i < outputArray.Length; i++)
{
    if (inputArray[i].Length <= 3)
    {
        outputArray[i] = inputArray[i];
    }
}

PrintArraiy(inputArray);
Console.Write(" -> ");
PrintArraiy(outputArray);