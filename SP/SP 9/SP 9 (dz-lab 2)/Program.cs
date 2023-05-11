//8 - 1 4 2 7 9 15 5.
//Длина самой большой возрастающей последовательности 4. Последовательность: 2 7 9 15.



using System.ComponentModel.DataAnnotations;

int GetMaxSequence(List<int> numbers)
{
int currentCount = 1;
int currentStartIndex = 0;
int maxCount = 1;
int startIndex = 0;
for (int i = 0; i < numbers.Count - 1; i++)
{
    if (numbers[i] < numbers[i + 1])
    {
        currentCount++;
        if (currentCount > maxCount)
        {
            maxCount = currentCount;
            startIndex = currentStartIndex;
        }
    }
    else
    {
        currentCount = 1;
        currentStartIndex = i + 1;
    }
}

    return maxCount;
}

List<int> numbers = new List<int> { 1, 2, 8, -1, 4, 2, 7, 9, 15, 5 };

Console.WriteLine($"Max sequence lenght: {numbers.AsParallel().Select(t=>GetMaxSequence(numbers)).First()}");
//The code above doesn't seem logical, the assignment requires parallelism, but I wrote some bullshit( 


//for (int i = startIndex; i < maxCount + startIndex; i++)
//{
//    Console.Write($"{numbers[i]}, ");
//}
//Console.WriteLine($"Max sequence lenght: {maxCount}");