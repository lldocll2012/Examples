Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();
if(username.ToLower() == "настя")
{
    Console.WriteLine("Привет, любимая, я так по тебе соскучился!!!!");
}
else
{
    Console.Write("А, это ты. Привет, ");
    Console.WriteLine(username);
}