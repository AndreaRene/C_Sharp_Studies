
//instantiate jagged array of user input
string[][] userEnteredValues = new string[][]
{
            new string[] { "1", "2", "3"},
            new string[] { "1", "two", "3"},
            new string[] { "0", "1", "2"}
};

//instanciate overallStatusMessage as an empty string
string overallStatusMessage = "";

//assigning value of overall status to be the return value of the Workflow1 method using the jagged array
overallStatusMessage = Workflow1(userEnteredValues);

//good stuff happened
if (overallStatusMessage == "operating procedure complete")
{
    Console.WriteLine("'Workflow1' completed successfully.");
}

//bad stuff happened
else
{
    Console.WriteLine("An error occurred during 'Workflow1'.");
    Console.WriteLine(overallStatusMessage);
}

//instantiate method Workflow1 expecting a jagged array to be passed in
static string Workflow1(string[][] userEnteredValues)
{
    //instatiate local strings
    string operationStatusMessage = "good";
    string processStatusMessage = "";

//for each array in the provided jagged array
    foreach (string[] userEntries in userEnteredValues)
    {
        processStatusMessage = Process1(userEntries);

        if (processStatusMessage == "process complete")
        {
            Console.WriteLine("'Process1' completed successfully.");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("'Process1' encountered an issue, process aborted.");
            Console.WriteLine(processStatusMessage);
            Console.WriteLine();
            operationStatusMessage = processStatusMessage;
        }
    }

    if (operationStatusMessage == "good")
    {
        operationStatusMessage = "operating procedure complete";
    }

    return operationStatusMessage;
}

static string Process1(String[] userEntries)
{
    string processStatus = "clean";
    string returnMessage = "";
    int valueEntered;

    foreach (string userValue in userEntries)
    {
        bool integerFormat = int.TryParse(userValue, out valueEntered);

        if (integerFormat == true)
        {
            if (valueEntered != 0)
            {
                checked
                {
                    int calculatedValue = 4 / valueEntered;
                }
            }
            else
            {
                returnMessage = "Invalid data. User input values must be non-zero values.";
                processStatus = "error";
            }
        }
        else
        {
            returnMessage = "Invalid data. User input values must be valid integers.";
            processStatus = "error";
        }
    }

    if (processStatus == "clean")
    {
        returnMessage = "process complete";
    }

    return returnMessage;
}