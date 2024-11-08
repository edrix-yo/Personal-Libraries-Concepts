using System.Security.Cryptography;






// inquiry a List
List<int> abc = new List<int>();

for (int i = 0; i < 20; i++)
{
    abc.Add(Random.Shared.Next(0, 10));
}

// start to move it into HashSet
HashSet<int> resultDistinct = new HashSet<int>();

foreach (int i in abc)
{
    resultDistinct.Add(i);
}

// to check the data, the result may not have duplicate number
Console.Write(string.Join(",", resultDistinct));


Task.Delay(1000);