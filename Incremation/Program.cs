//int value = 0;     // value is now 0.
//value = value + 5; // value is now 5.
//value += 5;        // value is now 10.

int values = 0;     // value is now 0.
values = values + 1; // value is now 1.
values++;           // value is now 2.

int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);