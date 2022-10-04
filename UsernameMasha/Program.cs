Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Hello you Masha");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}