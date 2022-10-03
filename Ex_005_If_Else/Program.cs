Console.WriteLine("What is your name?");
string username = Console.ReadLine();
if(username.ToLower() == "masha")
{
    Console.WriteLine("Hurrah! Congratulations! This is Masha!");
}
else
{
    Console.Write("Hello, ");
    Console.Write(username);
    Console.WriteLine("!");
}