// Before C# 10: Action<string> write = (string s) => Console.WriteLine(s);
var write = (string s) => Console.WriteLine(s);
write("test");

// Before C# 10: Func<string, int> parse = (string s) => int.Parse(s);
var parse = (string s) => int.Parse(s); // Func<string, int>

// Compile error: The delegate type could not be inferred.
// var parse2 = s => int.Parse(s);

// Lambdas can be assigned to a weaker type
object objParse = (string s) => int.Parse(s);   
Delegate delegateParse = (string s) => int.Parse(s);

// Before C# 10: Func<double, double> trigonometricFunction = Math.Sin;
var trigonometricFunction = Math.Sin;

// Specifiyng explicit return type on a lambda expression
var value = object (bool b) => b ? 1 : "two"; // Func<bool, object>

// Attributes on lambdas
var square = [Author("Niki")] (int x) => x * x;
