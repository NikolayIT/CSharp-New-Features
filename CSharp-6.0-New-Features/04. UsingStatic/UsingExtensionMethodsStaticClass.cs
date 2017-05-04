using System.Collections.Generic;
using System.Linq.Enumerable;

public class UsingExtensionMethodsStaticClass
{
    public IEnumerable<int> GetOddNumbersBetween(int min, int max)
    {
        var range = Range(min, max); // Static method System.Linq.Enumerable.Range

        var odd = Where(range, i => i % 2 == 1);

        // The following line will not compile (Where method could not be found)
        // var even = odd.Where(i => i % 2 == 0);
        // If we add "using System.Linq;" the above line will be compiled successfully

        return odd;
    }
}
