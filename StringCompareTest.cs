using System;
using System.Linq;
using System.Collections.Generic;

class Hello {
    public static void Main() {
        var x = "A";

        var strings = new List<string> {"a", "B", "C"};
        if (strings.Contains(x, StringComparer.OrdinalIgnoreCase)) {
            Console.WriteLine("hello");
        }
    }
}