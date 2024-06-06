using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class Program{
    private static void Main(string[] args)
    {
        string message = "This--is--ex-amp-le--da-ta";
        message = message.Replace("--", " ");
        message = message.Replace("-", "");
        Console.Write(message);
    }

    private string GetDebuggerDisplay()
    {
#pragma warning disable CS8603 // Possible null reference return.
        return ToString();
#pragma warning restore CS8603 // Possible null reference return.
    }
}