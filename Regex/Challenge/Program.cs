using System.Text.RegularExpressions;

string? input;
const int TIMEOUT = 1000;

static void printReversedDateStr(string dateStr) {
    try {
        string reverseInput = Regex.Replace(dateStr,
                @"(\d{1,2})/(\d{1,2})/(\d+)", "$3-$1-$2",
                RegexOptions.None, TimeSpan.FromMilliseconds(TIMEOUT));
        System.Console.WriteLine($"The reverse format is {reverseInput}");
    }
    catch (RegexMatchTimeoutException) {
        System.Console.WriteLine("Regex took too long to execute");
    };
}

do {
    // Prompt user for input
    System.Console.WriteLine("Date to Convert? (Use mm/dd/yyyy, or 'exit' to quit)");
    input = System.Console.ReadLine();
    input = string.IsNullOrEmpty(input) ? "" : input.Trim().ToLower();

    if (DateTime.TryParse(input, out DateTime date)) {
        printReversedDateStr(input);
    } else {
        System.Console.WriteLine("That's not a valid date, try again");
    }

} while (!input.Equals("exit"));

