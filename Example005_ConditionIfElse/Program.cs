Console.Write("Введите имя пользователя: ");
string usrename = Console.ReadLine();
if(usrename.ToLower() == "маша")
{
    Console.WriteLine("Ура, этоже МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(usrename);
}