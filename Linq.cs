using System.Threading;

using System.Linq;

List<string> names = new List<string> { "John", "Jane", "Doe" };
var groups = names.GroupBy(x => x.Length);

foreach (var group in groups)
{
    Console.WriteLine($"Names with {group.Key} characters:");
    foreach (string name in group)
    {
        Console.WriteLine(name);
    }
}



//List<string> names = new List<string> { "John", "Jane", "Doe" };
List<int> ages = new List<int> { 30, 25, 35 };

var nameAgePairs = names.Join(ages, name => names.IndexOf(name), age => ages.IndexOf(age), (name, age) => new { Name = name, Age = age });
foreach (var pair in nameAgePairs)
{
    Console.WriteLine($"{pair.Name}: {pair.Age}");
}
