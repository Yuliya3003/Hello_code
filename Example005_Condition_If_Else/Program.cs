Console.WriteLine("Введите имя");
string username = Console.ReadLine();
if (username.ToLower() == "маша") {
    Console.Write("Ура, это же Маша!");
} else {
    Console.WriteLine("Привет, " + username + "!");
}
