Console.WriteLine("Добро подаловать!");

while (true)
{
    Console.WriteLine("\n--- МЕНЮ ---");
    Console.WriteLine("1 - Показать ФИО");
    Console.WriteLine("2 - Показать группу");
    Console.WriteLine("3 - Показать дату");
    Console.WriteLine("4 - Выход");
    Console.Write("Выберите пункт: ");

    string choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.WriteLine("ФИО: Истомин Максим Алексеевич");
    }
    else if (choice == "2")
    {
        Console.WriteLine("Группа: ИСП-243");
    }
    else if (choice == "3")
    {
        Console.WriteLine($"Дата и время: {DateTime.Now}");
    }
    else if (choice == "4")
    {
        Console.WriteLine("Завершение работы программы...пока");
        break; 
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}