using System.Collections;

ArrayList ints = new ArrayList { 2, 3, 4, 5 };
int sum = 0;
foreach (object number in ints)
{
	sum += (int)number;
}

ArrayList strings = new ArrayList { "a", "b", "c" };

ArrayList variousItems = new ArrayList { 1, false, "abc", new DateTime() };
object[] objects = new object[] { 1, false, "abc", new DateTime() };

