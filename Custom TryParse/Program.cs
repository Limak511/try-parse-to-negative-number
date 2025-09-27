namespace Custom_TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? userInputNumber = string.Empty;
            List<string> outputs = new List<string>();
            while (true)
            {
                Console.Clear();
                int negativeNumber = 0;
                string defaultValue = "0";
                Console.Write("Pass Negative Number: ");
                userInputNumber = Console.ReadLine();
                Console.Clear();
                if (userInputNumber == "exit")
                {
                    break;
                }
                if (userInputNumber == "history")
                {
                    foreach (var output in outputs)
                    {
                        Console.WriteLine(output);
                    }
                    Console.ReadKey();
                    continue;
                }
                bool canParse = TryParseToNegativeInt(userInputNumber ?? defaultValue, out negativeNumber);
                string consoleOutput = $"User Input: {userInputNumber} | Can Parse: {canParse} | Negative Int: {negativeNumber}";
                outputs.Add(consoleOutput);
                Console.WriteLine(consoleOutput);
                Console.ReadKey();
            }
        }

        static bool TryParseToNegativeInt(string str, out int negativeNumber)
        {
            str = str.Trim();
            int strInt = 0;
            bool canParse = false;
            try
            {
                strInt = int.Parse(str);
                if (strInt < 0)
                {
                    negativeNumber = strInt;
                    canParse = true;
                }
                else
                {
                    negativeNumber = 0;
                }
            }
            catch (Exception e)
            {
                negativeNumber = 0;
                Console.WriteLine(e.Message);
            }

            return canParse;
        }
    }
}
