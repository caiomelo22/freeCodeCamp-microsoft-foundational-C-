
int whichProjectToRun = 2;

if (whichProjectToRun == 1)
{
    string? valueTyped;
    int valueConverted;
    bool converted;

    do {
        Console.WriteLine("Please, type a number from 5 to 10:");

        valueTyped = Console.ReadLine();

        converted = int.TryParse(valueTyped, out valueConverted);
        
    } while (!converted || valueConverted < 5 || valueConverted > 10);

    Console.WriteLine($"Value of {valueTyped} accepted!");
}
else if (whichProjectToRun == 2)
{
    bool userInputValid = false;
    do
    {
        Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

        string? userInput = Console.ReadLine();
        string userInputConverted = "";

        if (userInput != null)
        {
            userInputConverted = userInput.Trim().ToLower();
        }

        if (userInputConverted == "administrator" || userInputConverted == "manager" || userInputConverted == "user")
        {
            userInputValid = true;
            Console.WriteLine($"Your input value ({userInputConverted}) has been accepted.");
            continue;
        }

        Console.Write($"The role name that you entered, \"{userInput}\" is not valid.");
    } while (!userInputValid);
}
else if (whichProjectToRun == 3)
{
    string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

    foreach(string myString in myStrings)
    {
        int stringStart = 0;
        int periodLocation;

        do
        {
            string stringToPrint;
            int stringLength;
            
            periodLocation = myString.IndexOf(".", stringStart);

            if (periodLocation != -1)
            {
                stringLength = periodLocation - stringStart;
                stringStart = periodLocation + 1;
            }
            else
            {
                stringLength = myString.Length - stringStart;
            }

            stringToPrint = myString.Substring(stringStart, stringLength).TrimStart();
            Console.WriteLine(stringToPrint);

        } while (periodLocation != -1);
    }
}