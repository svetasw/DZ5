Console.WriteLine("Enter the length of the array:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
RandomNumbers(numbers);
Console.WriteLine("This is array: ");
PrintArray(numbers);

void RandomNumbers(int[] numbers)
{
    for(int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}


int count = 0;

for (int x = 0; x < numbers.Length; x++)
{
if (numbers[x] % 2 == 0)
count++;
}
Console.WriteLine($"from {numbers.Length} numbers, {count} even");


void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
