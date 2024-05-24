//Binary Search 
//Static 
int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
int item = 5;
int left, right, middle;

left = 0;
right = 6;


while (left <= right)
{
    middle = (left + right) / 2;

    if (numbers[middle] == item)
    {
        Console.WriteLine("Item found at " + middle);
        return;
    }
    else if (numbers[middle] < item)
    {
        left = middle + 1;
    }
    else
    {
        right = middle - 1;
    }
}
Console.WriteLine("Item not found.");

//Dynamic
int sizeofArray;
int[] number1;
int findNumber;
int left1, right1, middle1;
int loopCount = 0;

Console.WriteLine("Enter your size of array ");
sizeofArray = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Here is array of number: ");
number1 = new int[sizeofArray];

for (int i = 0; i < sizeofArray; i++)
{
    number1[i] = i;
    Console.Write(number1[i] + " ");
}
left1 = Convert.ToInt32(number1[0]);
right1 = Convert.ToInt32(number1.Length - 1);

Console.WriteLine("left value : " + left1);
Console.WriteLine("right value : " + right1);

Console.WriteLine("Enter your searching number: ");
findNumber = Convert.ToInt32(Console.ReadLine());

while (left1 <= right1)
{
    loopCount++;
    middle1 = (left1 + right1) / 2;

    if (number1[middle1] == findNumber)
    {
        Console.WriteLine("Number found at" + " " + number1[middle1]);
        Console.WriteLine("Loop Count" + " " + loopCount);

        return;
    }
    else if (number1[middle1] < findNumber)
    {
        left1 = middle1 + 1;
    }
    else
    {
        right1 = middle1 - 1;
    }
}
Console.WriteLine(findNumber + " not found.");
Console.WriteLine("Loop Count" + " " + loopCount);