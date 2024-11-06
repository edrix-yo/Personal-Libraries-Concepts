
Dictionary<(int, int), List<int>> abc = new Dictionary<(int, int), List<int>>();

string[] testString = { "1 2 5", "1 3 4", "1 2 7" };

var n = 0;
var m = 0;
var t = 0;

foreach (var test in testString)
{
    n = int.Parse(test.Split()[0]);
    m = int.Parse(test.Split()[1]);
    t = int.Parse(test.Split()[2]);

    if (abc.ContainsKey((n, m)))
    {
        abc[(n, m)].Add(t);
    }
    else
    {
        abc.Add((n, m), new List<int> { t });
    }
}

foreach (var testDict in abc)
{
    Console.WriteLine("key" + testDict.Key);
    foreach (var lsData in testDict.Value)
    {
        Console.WriteLine("valueDict : " + lsData);
    }
}
