string[] values = { null, "160519", "9432.0", "16,667",
                          "   -322   ", "+4302", "(100);", "01FA" };
foreach (var value in values)
{
    int number;

    bool success = int.TryParse(value, out number);
    if (success)
    {
        Console.WriteLine($"Converted '{value}' to {number}.");
    }
    else
    {
        Console.WriteLine($"Attempted conversion of '{value ?? "<null>"}' failed.");
    }
}
