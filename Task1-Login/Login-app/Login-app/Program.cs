
using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;


IAccount account = new Account();
//var result = account.Login("test@code.edu.az", "test12345", 2);
//Console.WriteLine(result);



Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Emaili daxil edin");
Console.ResetColor();
string email = Console.ReadLine();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Password daxil edin");
Console.ResetColor();
string password = Console.ReadLine();


Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Roles daxil edin");
Console.ResetColor();
int roles = int.Parse(Console.ReadLine());



Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(account.Login(email,password,roles));
Console.ResetColor();

