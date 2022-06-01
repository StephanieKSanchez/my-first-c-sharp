// See https://aka.ms/new-console-template for more information
string stranger = "Another";
int one = 1;

Console.WriteLine($"Hello, {stranger} {one}");

Console.WriteLine(stranger.IndexOf("A"));

int a = 10, b = 20, c = 40;

int sum = a + b + c;

double d = 5.0, e = 2.0;

double div = d / e;
int max = int.MaxValue;
int maxIsh = max + 3;

Console.WriteLine($"The sum is {sum}");
Console.WriteLine($"What is 5/2?: {div}");
Console.WriteLine($"What is the maxish {maxIsh}");

Console.WriteLine("----------- Array -----------");

var firstArr = new int[5] {-69, 46, 10, 1, 100} ;
// int[] arr2 = new int[4]
// int[] arr2 = new int[] {1,2,3,4} -- This line and one above are the same.
firstArr[1] = 20;

for (var i = 0; i < firstArr.Length; i++)
{
    Console.WriteLine($"The value at {i} is {firstArr[i]}");
}

foreach (var el in firstArr)
{
    Console.WriteLine($"The value is {el}");
}

Console.WriteLine("------------ List ------------");

List<int> list = new List<int>();