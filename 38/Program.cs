Console.WriteLine("Enter the length of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] number = new double[size];
FillArrayRandomNumbers(number);
Console.WriteLine("This is array: ");
PrintArray(number);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int a = 0; a < number.Length; a++)
{
    if (number[a] > max)
        {
            max = number[a];
        }
    if (number[a] < min)
        {
            min = number[a];
        }
}

Console.WriteLine($"Total {number.Length} numbers. maximum = {max}, minimum = {min}");
Console.WriteLine($"Difference between maximum and minimum = {max - min}");

void FillArrayRandomNumbers(double[] number)
{
    for(int i = 0; i < number.Length; i++)
        {
            number[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] number)
{
    Console.Write("[ ");
    for(int i = 0; i < number.Length; i++)
        {
            Console.Write(number[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
