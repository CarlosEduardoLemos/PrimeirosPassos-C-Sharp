// Console.WriteLine("hello Word!");


internal class Hello
{
    private static void Main(string[] args)
    {
        if (args is not null)
        {
            Console.Write("Hello World!");

            Console.Write("Congratulations!");
            Console.Write(" ");
            Console.Write("You wrote your first lines of code.");
        }
        else
        {
            throw new ArgumentNullException(nameof(args));
        }
    }
}
