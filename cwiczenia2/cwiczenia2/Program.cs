// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");

static double GetSrednia(int [] numbers )
{
    double result = 0.0;
    for (int i = 0; i < numbers.Length; i++)
    {
        result += numbers[i];
    }

    return result / numbers.Length;
}

int[] numbers = { 1, 2, 3, 4};
double average = GetSrednia(numbers);
Console.WriteLine(average);

static int GetMax(int[] numbersMax)
{
    int max = 0;
    for (int i = 0; i <= numbersMax.Length; i++)
    {
        if (max < i)
        {
            max = i;
        }
    }

    return max;
}

int [] numbersMax = { 1, 2, 3, 4, 5};
int result = GetMax(numbersMax);
Console.WriteLine(result);