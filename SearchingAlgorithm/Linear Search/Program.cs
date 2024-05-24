//Linear Searching Algorithm
//First type
Console.WriteLine("Linear algorithm in C# 1 :");
int[] number = { 10, 20, 30, 40 };

for (int i = 0; i < number.Length; i++)
{
    if (number[i] == 30)
    {
        Console.WriteLine("Number found at " + " " + i);
        break;
    }
    else
    {
        Console.WriteLine("Number not found at " + " " + i);
    }
}

//Second type
Console.WriteLine("----------------------------------------");
Console.WriteLine("Linear algorithm in C# 2 :");
int[] number1 = { 10, 20, 30, 40 };

var output = Array.IndexOf(number1, 50);

if (output != -1)
{
    Console.WriteLine("Number Found" + " " + output);

}
Console.WriteLine("Number not found");

//Third type
Console.WriteLine("----------------------------------------");
Console.WriteLine("Linear algorithm in C# 3 :");

int sizeofArray;
int[] number3;
int findValue;
Console.WriteLine("Input your array size: ");
sizeofArray = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your array value: ");
number3 = new int[sizeofArray];
for (int i = 0; i < sizeofArray; i++)
{
    number3[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(" ");

foreach (int numbers in number3)
{
    Console.WriteLine("Array value: " + numbers);
}
Console.WriteLine(" ");
Console.WriteLine("Enter your find value: ");
findValue = Convert.ToInt32(Console.ReadLine());

//Forloop
for (int i = 0; i < number3.Length; i++)
{
    if (number3[i] == findValue)
    {
        Console.WriteLine("Number found at " + "" + i);
        break;
    }
    Console.WriteLine("Number not found at " + "" + i);
}

//While Loop
int j = 0;
while (j < number3.Length)
{
    if (number3[j] == findValue)
    {
        Console.WriteLine(findValue + " found at " + "" + j);
        return;
    }
    j++;
}
Console.WriteLine(findValue + " not found!");

//Do while loop
int k = 0;
do
{
    if (number3[k] == findValue)
    {
        Console.WriteLine(findValue + " found at " + "" + k);
        return;
    }
    Console.WriteLine(findValue + " not found at " + "" + k);
    k++;
}
while (k < number3.Length);