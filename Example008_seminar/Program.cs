int sum = 0;
int startNumber = 1;

while (startNumber <= 15)
{
    if (startNumber % 2 == 0)
    {
        sum = sum + startNumber;
    }
    startNumber += 1;

}

Console.WriteLine(sum);