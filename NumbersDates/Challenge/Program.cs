string promptInput() {
    Console.WriteLine("Which date? (or 'quit')");
    string? input = Console.ReadLine();
    input = string.IsNullOrEmpty(input) ? "" : input;
    return input;
}

void printDayDiffStr(int daysDiff) {
    switch (daysDiff) {
        case < 0:
            Console.WriteLine($"That date went by {-daysDiff} days ago");
            break;
        case > 0:
            Console.WriteLine($"That date will be in {daysDiff} days!");
            break;
        default:
            Console.WriteLine($"That date is today!");
            break;
    }
}

for (string input = promptInput(); !input.Equals("quit"); input = promptInput()) {
    if (DateTime.TryParse(input, out DateTime date)) {
        printDayDiffStr((date - DateTime.Today).Days);
    } else {
        Console.WriteLine("That doesn't seem to be a valid date");
    }
}

