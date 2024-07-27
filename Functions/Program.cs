Console.WriteLine(ReturnHelloTo("Adam"));
Console.WriteLine(GetPI());
SayHello();
SayHelloTo("Adam");


// _ = CountDown(12);
Console.WriteLine(CountDown(12));
PrintNames("John", "Jones", "Joseph", "Jacob", "Job", "Jesus");


#region Part 1
string ReturnHelloTo(string name)
{
    return $"Hello {name}";
}


void SayHello()
{
    Console.WriteLine("Hello");
}

void SayHelloTo(string name)
{
    Console.WriteLine($"Hello {name}");
}

double GetPI()
{
    return 3.141592653589793;
}
#endregion

#region Part 2

void PrintNames(params string[] names)
{
    string namesConcatenated = string.Join(", ", names);
    Console.WriteLine(namesConcatenated);
}

string CountDown(int num, string joined = "")
{
    if (num == 1)
        return joined + num;
    return CountDown(num - 1, $"{joined + num} ");
}
#endregion
