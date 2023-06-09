using System.Text.RegularExpressions;

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

// Prompt user for input
static string getUserInput() {
    System.Console.WriteLine("Date to Convert? (Use mm/dd/yyyy, or 'exit' to quit)");
    string? input = System.Console.ReadLine();
    input = string.IsNullOrEmpty(input) ? "" : input.Trim().ToLower();

    return input;
}

for (string input = getUserInput(); !input.Equals("exit"); input = getUserInput()) {
    if (DateTime.TryParse(input, out DateTime date)) {
        printReversedDateStr(input);
    } else {
        System.Console.WriteLine("That's not a valid date, try again");
    }
}

