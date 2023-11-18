// See https://aka.ms/new-console-template for more information
using System.Reflection;
using UtilityConsoleApp;

string utilsToShow = string.Empty;
var basicUtilType = typeof(IUtility);
var utilities =
    AppDomain.CurrentDomain.GetAssemblies()
    .SelectMany(ass => ass.GetTypes())
    .Where(type => type.IsClass && basicUtilType.IsAssignableFrom(type))
    //تا اینجا فقط تایپ هارا گرفتیم، حال برای آن ها یک نمونه میسازیم
    .Select(type => (IUtility)Activator.CreateInstance(type))
    .ToList();

for (int i = 0; i < utilities.Count; i++)
{
    var name = utilities.Select(x => x.Name).ToArray();
    utilsToShow =  string.Concat(utilsToShow, string.Concat(name[i], "  "));
}

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Please Enter Your Utilily Name : {utilsToShow} " );


var enteredUtilName = string.Concat(Console.ReadLine()?.ToLower().Where(c => !char.IsWhiteSpace(c)));
var util = utilities.SingleOrDefault(x => x.Name.ToLower() == enteredUtilName);

if (util is null)
{
    Console.ForegroundColor = ConsoleColor.Red;
    throw new Exception("Utility Not Found");
}

try
{
    util.ExecuteContext();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Utility Excuted Successfully");
}
catch (Exception e)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Utility Excution Fails");
    throw new Exception($"message: {e.Message}   innerException: {e.InnerException}");
}
