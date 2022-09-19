Console.WriteLine("Введите имя пользователя: ");

string username = Console.ReadLine();

if(username.ToLower() == "dima")
{
    Console.WriteLine("You're Superman!");
}
else
{
    Console.Write ("Hello, ");
    Console.WriteLine(username);
}