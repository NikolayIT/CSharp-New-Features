// Before C# 10: Action<string> write = (string s) => Console.WriteLine(s);
var write = (string s) => Console.WriteLine(s);

// Before C# 10: Func<string, int> parse = (string s) => int.Parse(s);
var parse = (string s) => int.Parse(s);

write("test");