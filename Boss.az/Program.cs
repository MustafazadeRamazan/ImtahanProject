using Inspectors;
using EmployerNamespace;
using AnnouncementNamespace;
using NotificationNamespace;
using System.Text;
using WorkerNamespace;
using Boss.az.JsonServer;

Console.Title = "Boss.az";
string? whichwork = null;

//#region StartPage
//Console.OutputEncoding = Encoding.Unicode;
//Console.InputEncoding = Encoding.Unicode;

//string[] words = new string[]
//{
//"\t\t\t\t\tWelcome Boss.az application",
//"\t\t\t\t\t Created By Ramazan Mustafazade",
//"\t\t\t\t\t  Creation Date: 30.01.2022"
//};

//Console.ForegroundColor = ConsoleColor.Cyan;

//foreach (var text in words)
//{
//    for (int i = 0; i < text.Length; i++)
//    {
//        Console.Write(text[i]);
//        Thread.Sleep(20);
//    }
//    Console.Beep(5748, 100);
//    Thread.Sleep(1000);
//    Console.WriteLine();
//}
//Console.Clear();
//loading.loading();

//#endregion


UInt16 AnnouncemenetId = 1, AnnouncemenetId2 = 1;

List<Worker> workers = new List<Worker>()
{
    new Worker("ramazanmustafazade4@gmail.com","ramo",1,"Ramazan","Mustafazade","Baku","+994509835659","16","Game Developer","Ataturk Lisey","700","C#, Unity, Photoshop","Play Eat Repeat","12.01.2022/continuing","English, Azerbaijan, Russian","yes",""),
    new Worker("blackbearmecid@gmail.com", "123", 2, "Mecid", "Esgerov", "Baku", "+9940774881942", "18", "Programmer", "192", "567", "C++, Unreal", "BothDeveloper", "27.07.2020 - 01.09.2021", "Turkish", "no", "")
};

Employer emp = new(1, "admin", "Admin", "Baku", "+994703003030", 28, "Salam, ise qebullar acildi", "admin", "admin", new Announcement[]
    {
        new(AnnouncemenetId,"C# Developer","Kamil",
        "\n- Verilən texniki tapşırığa uyğun proqram təminatlarının işlənib hazırlanması" +
        "\n- Sprint üzrə verilmiş tapşırıqları vaxtında, tələblərə uyğun hazırlanması" +
        "\n- Hazırladığı tapşırıqların ilkin sınaqlarını aparmaq və işlərin keyfiyyətli təhvil verilməsi" +
        "\n- Yeni proqram təminatı hazırlanması\n- Mövcud proqram təminatlarına texniki dəstək göstərilməsi" +
        "\n- Mövcud proqram təminatlarının inkişaf etdirilməsi\n- Proqram təminatlarının test edilməsi" +
        "\n- Yeni hesabatların yazılması" +
        "\n- İş vaxtı: həftənin 5 günü, saat 09:00-dan 18:00-dək. Istirahət günləri: şənbə, bazar" +
        "\n- Əmək haqqı namizədin bilik, bacarıq və praktik iş təcrübəsinə uyğun olaraq müsahibə zamanı razılaşdırılacaq","Baku","+994707771212","20-35","1500-2000","info@dev.com",2,10)
    },
    new Notification[0]
    );

Json.JsonSerializeEmployer(emp);

StartedMenu:;
Console.CursorVisible = false;
Console.Clear();

Inspector.BossAzText();

string[] menu = new string[]
{
           "Login with Employer\n", "Login with Worker\n","Register Worker\n", "About us\n", "Exit\n"
};


int index = Inspector.SelectionControl(menu);


if (index == 0)
{
    Console.Clear();

LoginEmp:;
    Console.ForegroundColor = ConsoleColor.Yellow;

    Console.WriteLine("\t\t\t" + @" _                        _               _____                         ");
    Console.WriteLine("\t\t\t" + @"| |                      (_)             |  __ \                        ");
    Console.WriteLine("\t\t\t" + @"| |        ___     __ _   _   _ __       | |__) |   __ _    __ _    ___ ");
    Console.WriteLine("\t\t\t" + @"| |       / _ \   / _` | | | | '_ \      |  ___/   / _` |  / _` |  / _ \");
    Console.WriteLine("\t\t\t" + @"| |____  | (_) | | (_| | | | | | | |     | |      | (_| | | (_| | |  __/");
    Console.WriteLine("\t\t\t" + @"|______|  \___/   \__, | |_| |_| |_|     |_|       \__,_|  \__, |  \___|");
    Console.WriteLine("\t\t\t" + @"                   __/ |                                    __/ |       ");
    Console.WriteLine("\t\t\t" + @"                  |___/                                    |___/        ");

    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.CursorVisible = true;
    Console.Write("\n\n\n\t\t\u25ba Enter Email: ");
    string? email = Console.ReadLine();

    if (email == emp.Email)
    {
    LoginEmpPassword:;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        string password = Inspector.PasswordGenerator("\t\t\u25ba Enter Password: ", email);

        if (password == emp.Password)
        {
        EmpMenu:;
            Console.Clear();
            Console.CursorVisible = false;
            Inspector.BossAzText();
            int NotificationCount = emp.Notifications.Length;

            int secim = Inspector.SelectionControl(
                new string[] { $"Notification ({NotificationCount})\n", "Add New Announcement\n", "Log Out\n" }
            );

            if (secim == 0)
            {
                Console.Clear();

                if (emp.Notifications.Length == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Beep();
                    Console.WriteLine("\n\n\n\t\t\t\t\t N O  A N Y  N O T I F I C A T I O N");
                    Thread.Sleep(2000);

                    goto EmpMenu;
                }

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("\t\t\t" + @" _   _           _     _    __   _                  _     _                 ");
                Console.WriteLine("\t\t\t" + @"| \ | |         | |   (_)  / _| (_)                | |   (_)                ");
                Console.WriteLine("\t\t\t" + @"|  \| |   ___   | |_   _  | |_   _    ___    __ _  | |_   _    ___    _ __  ");
                Console.WriteLine("\t\t\t" + @"| . ` |  / _ \  | __| | | |  _| | |  / __|  / _` | | __| | |  / _ \  | '_ \ ");
                Console.WriteLine("\t\t\t" + @"| |\  | | (_) | | |_  | | | |   | | | (__  | (_| | | |_  | | | (_) | | | | |");
                Console.WriteLine("\t\t\t" + @"|_| \_|  \___/   \__| |_| |_|   |_|  \___|  \__,_|  \__| |_|  \___/  |_| |_|" + "\n");

                AnnouncemenetId2 = 1;
                emp.ShowAllNotifications();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"\n\n1) Delete All Notification\n2) Accept or Reject Worker\n3) Go Back\nChoose: ");
                string? choose = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Yellow;

                if (choose == "1")
                {
                    NotificationCount = 0;
                    emp.DeleteAllNotifications();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Beep();
                    Console.WriteLine("\n\n\n\t\t\t All Notification Deleted!");
                    Thread.Sleep(2000);

                    goto EmpMenu;
                }

                else if (choose == "2")
                {
                    Console.Clear();
                    Console.Write("Write user gmail or name to look him CV: ");
                    string? gmail = Console.ReadLine();

#pragma warning disable CS0162 // Unreachable code detected
                    for (int i = 0; i < workers.Count; i++)
#pragma warning restore CS0162 // Unreachable code detected
                    {
                        if (gmail == workers[i].Email || gmail == workers[i].Name)
                        {
                        acceptorreject:;
                            Console.Clear();
                            Console.Beep();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Json.JsonDeserializeWorker(workers, i);

                            Console.Write($"If you want to accept {workers[i].Name} worker to your job, please write \"accept\" \nif you dont want to accept {workers[i].Name} worker to your job, please write \"reject\"\n\nWrite: ");
                            string? answer = Console.ReadLine();

                            if (answer == "accept")
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.Beep();
                                Console.WriteLine($"\n\n\n\t\t\t Congurations! You accepted {workers[i].Name} worker to your job");
                                workers[i].WorkerNotification = $"Hello {workers[i].Name} !\nYou accepted {whichwork} work from {emp.Name}.";

                                Thread.Sleep(2000);

                                goto EmpMenu;
                            }

                            else if (answer == "reject")
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Beep();
                                Console.WriteLine($"\n\n\n\t\t\t You rejected {workers[i].Name} worker");
                                Thread.Sleep(2000);

                                goto EmpMenu;
                            }

                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Beep();
                            Console.WriteLine($"\n\n\n\t\t\t Wrong Input");
                            Thread.Sleep(2000);

                            goto acceptorreject;
                        }
                    }

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Beep();
                    Console.WriteLine("\n\n\n\t\t\t This gmail or name was not found!");
                    Thread.Sleep(2000);

                    goto EmpMenu;
                }

                else
                {
                    goto EmpMenu;
                }
            }

            else if (secim == 1)
            {
                Console.Clear();
                Inspector.NewWorkText();

                Console.CursorVisible = true;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\n\t\t\u25ba Enter Job Name: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                string? JobName = Console.ReadLine();

                Console.Clear();
                Inspector.NewWorkText();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\n\t\t\u25ba Enter About The Job: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                string? AboutTheJob = Console.ReadLine();

                Console.Clear();
                Inspector.NewWorkText();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\n\t\t\u25ba Enter Age for the Job: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                string? AgeJob = Console.ReadLine();

                Console.Clear();
                Inspector.NewWorkText();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\n\t\t\u25ba Enter Salary for the Job: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                string? SalaryJob = Console.ReadLine();

                emp.AddAnnouncement(new Announcement(AnnouncemenetId2++, JobName, emp.Name, AboutTheJob, emp.City, emp.Phone, AgeJob, SalaryJob, emp.Email, 0, 0));

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.Beep();
                Console.WriteLine("\n\n\n\t\t\t A N N O U N C E M E N T    S U C C E S F U L L Y   A D D E D");
                Thread.Sleep(2000);
                Console.CursorVisible = false;

                goto EmpMenu;
            }

            else
                goto StartedMenu;
        }

        else
        {
            Loading.WrongPassword();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"\n\n\n\t\t\u25ba Enter Email: {email}");

            goto LoginEmpPassword;
        }
    }

    else
    {
        Loading.WrongEmail();
        goto LoginEmp;
    }

}

else if (index == 1)
{
    Console.Clear();

LoginWorker:;
    Console.ForegroundColor = ConsoleColor.Yellow;

    Console.WriteLine("\t\t\t" + @" _                        _               _____                         ");
    Console.WriteLine("\t\t\t" + @"| |                      (_)             |  __ \                        ");
    Console.WriteLine("\t\t\t" + @"| |        ___     __ _   _   _ __       | |__) |   __ _    __ _    ___ ");
    Console.WriteLine("\t\t\t" + @"| |       / _ \   / _` | | | | '_ \      |  ___/   / _` |  / _` |  / _ \");
    Console.WriteLine("\t\t\t" + @"| |____  | (_) | | (_| | | | | | | |     | |      | (_| | | (_| | |  __/");
    Console.WriteLine("\t\t\t" + @"|______|  \___/   \__, | |_| |_| |_|     |_|       \__,_|  \__, |  \___|");
    Console.WriteLine("\t\t\t" + @"                   __/ |                                    __/ |       ");
    Console.WriteLine("\t\t\t" + @"                  |___/                                    |___/        ");

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.CursorVisible = true;
    int WorkerIndex = 0;

    Console.Write("\n\n\n\t\t\u25ba Enter Email: ");
    string? email = Console.ReadLine();

    bool check = false;

    for (int i = 0; i < workers.Count; i++)
    {
        if (email == workers[i].Email)
        {
            check = true;
            break;
        }
        WorkerIndex++;
    }

    if (!check)
    {
        Loading.WrongEmail();
        goto LoginWorker;
    }

LoginWorkerPassword:;
    Console.ForegroundColor = ConsoleColor.Cyan;
    check = false;
    string password = Inspector.PasswordGenerator("\t\t\u25ba Enter Password: ", email);

    for (int i = 0; i < workers.Count; i++)
    {
        if (password == workers[i].Password && workers[i].Id == workers[WorkerIndex].Id)
        {
            check = true;
            break;
        }
    }

    if (!check)
    {
        Loading.WrongPassword();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\n\n\n\t\t\u25ba Enter Email: {email}");

        goto LoginWorkerPassword;
    }

    Console.CursorVisible = false;

WorkerMenu:;
    Console.Clear();
    Console.CursorVisible = false;

    Inspector.BossAzText();

    int choice = Inspector.SelectionControl(new string[] { "Your Profile\n", "Show Announcement\n", $"Notification\n", "Back\n" });

    if (choice == 0)
    {
        for (int i = 0; i < workers.Count; i++)
        {
            if (email == workers[i].Email)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Json.JsonDeserializeWorker(workers, i);
            }
        }

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.CursorVisible = false;

        Console.WriteLine("\n\nTap to ESC button to go back");
        var key = Console.ReadKey();

        if (key.Key == ConsoleKey.Escape)
        {
#pragma warning disable CA1416 // Validate platform compatibility
            Console.Beep(1000, 100);
#pragma warning restore CA1416 // Validate platform compatibility
            Loading.loading();

            goto WorkerMenu;
        }
    }

    else if (choice == 1)
    {
        bool IOA = false, IsAccepted = false;
        int IndexOfAnnouncement = 0;

    ShowAnnouncement:;
        Console.Clear();

        if (IndexOfAnnouncement == emp.Announcement.Length)
        {
            IndexOfAnnouncement = 0;
        }

        menu = new string[] { "\n\t Accept / Reject", "\n\t Next Announcement", "\n\t Filter" };

        void ShowPostContent()
        {
            Console.WriteLine("Job Name: " + emp.Announcement[IndexOfAnnouncement].JobsName);
            Console.WriteLine("From: " + emp.Announcement[IndexOfAnnouncement].YourName);
            Console.WriteLine("About Job: " + emp.Announcement[IndexOfAnnouncement].AboutJob);
            Console.WriteLine("City: " + emp.Announcement[IndexOfAnnouncement].City);
            Console.WriteLine("Phone Number: " + emp.Announcement[IndexOfAnnouncement].Phone);
            Console.WriteLine("Age: " + emp.Announcement[IndexOfAnnouncement].AgeForJob);
            Console.WriteLine("Salary: " + emp.Announcement[IndexOfAnnouncement].Salary);
            Console.WriteLine("Email: " + emp.Announcement[IndexOfAnnouncement].Email);
            Console.WriteLine("Time: " + emp.Announcement[IndexOfAnnouncement].CreationDatetime);
        }

        emp.Announcement[IndexOfAnnouncement].ShowPost();
        ShowPostContent();
        Console.CursorVisible = false;

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write($"{menu[0]}");
        Console.ResetColor();

        for (int i = 1; i < menu.Length; i++)
        {
            Console.Write($"{menu[i]}");
        }

        index = 0;

        while (true)
        {
            var key = Console.ReadKey();

            if (key.Key == ConsoleKey.Escape)
            {
                if (IOA == true)
                {
                    Console.Beep(1000, 100);
                    goto WorkerMenu;
                }

                else
                {
                    Console.Beep(1000, 100);
                    emp.Announcement[IndexOfAnnouncement].ViewCount++;
                    whichwork = emp.Announcement[IndexOfAnnouncement].JobsName;
                    emp.AddNotification(new(AnnouncemenetId2++, "The Announcement viewed", whichwork, workers[WorkerIndex].Name));
                    goto WorkerMenu;
                }
            }

            else if (key.Key == ConsoleKey.Enter)
            {
#pragma warning disable CA1416 // Validate platform compatibility
                Console.Beep(1000, 100);
#pragma warning restore CA1416 // Validate platform compatibility
                break;
            }

            else if (key.Key == ConsoleKey.DownArrow)
            {
                if (index + 1 == menu.Length)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    emp.Announcement[IndexOfAnnouncement].ShowPost();
                    ShowPostContent();
                    Console.ResetColor();
                    index = 0;

                    for (int i = 0; i < menu.Length; i++)
                    {
                        if (i == index)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write($"{menu[i]}");
                            Console.ResetColor();
                            continue;
                        }
                        Console.Write($"{menu[i]}");
                    }

                    Thread.Sleep(60);
                    continue;
                }

                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    emp.Announcement[IndexOfAnnouncement].ShowPost();
                    ShowPostContent();
                    Console.ResetColor();
                    index++;

                    for (int i = 0; i < menu.Length; i++)
                    {
                        if (i == index)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write($"{menu[i]}");
                            Console.ResetColor();
                            continue;
                        }
                        Console.Write($"{menu[i]}");
                    }

                    Thread.Sleep(60);
                }
            }

            else if (key.Key == ConsoleKey.UpArrow)
            {
                if (index - 1 < 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    emp.Announcement[IndexOfAnnouncement].ShowPost();
                    ShowPostContent();
                    Console.ResetColor();
                    index = menu.Length - 1;

                    for (int i = 0; i < menu.Length; i++)
                    {
                        if (i == index)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write($"{menu[i]}");
                            Console.ResetColor();
                            continue;
                        }
                        Console.Write($"{menu[i]}");
                    }

                    Thread.Sleep(60);
                    continue;
                }

                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    emp.Announcement[IndexOfAnnouncement].ShowPost();
                    ShowPostContent();
                    Console.ResetColor();
                    index--;

                    for (int i = 0; i < menu.Length; i++)
                    {
                        if (i == index)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write($"{menu[i]}");
                            Console.ResetColor();
                            continue;
                        }
                        Console.Write($"{menu[i]}");
                    }

                    Thread.Sleep(60);
                }
            }

            else
                continue;
        }

        if (index == 0)
        {
            if (IsAccepted)
            {
                Console.Beep(1000, 100);
                IsAccepted = false;
                emp.Announcement[IndexOfAnnouncement].Acception--;
                whichwork = emp.Announcement[IndexOfAnnouncement].JobsName;
                emp.AddNotification(new(AnnouncemenetId2++, "The Announcement Rejected", whichwork, workers[WorkerIndex].Name));
                goto ShowAnnouncement;
            }

            else
            {
                Console.Beep(1000, 100);
                IsAccepted = true;
                emp.Announcement[IndexOfAnnouncement].Acception++;
                whichwork = emp.Announcement[IndexOfAnnouncement].JobsName;
                emp.AddNotification(new(AnnouncemenetId2++, "The Announcement Accepted", whichwork, workers[WorkerIndex].Name));
                goto ShowAnnouncement;
            }
        }

        else if (index == 1)
        {
            Console.Beep(1000, 100);
            emp.Announcement[IndexOfAnnouncement].ViewCount++;

            if (IOA == false)
            {
                whichwork = emp.Announcement[IndexOfAnnouncement].JobsName;
                emp.AddNotification(new(AnnouncemenetId2++, "The Announcement viewed", whichwork, workers[WorkerIndex].Name));
            }

            IndexOfAnnouncement++;
            IOA = true;
            IsAccepted = false;
            goto ShowAnnouncement;
        }

        else
        {
            Console.Clear();
            Inspector.BossAzText();
            Console.CursorVisible = true;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("\n\n\t\t\u25ba Enter Job Name: ");
            string? namejob = Console.ReadLine();

            Console.Write("\t\t\u25ba Enter City: ");
            string? cityjob = Console.ReadLine();

            Console.Write("\t\t\u25ba Enter Salary: ");
            string? salaryjob = Console.ReadLine();

            Console.Write("\t\t\u25ba Enter Age: ");
            string? agejob = Console.ReadLine();

            Console.CursorVisible = true;

            Console.Clear();
            Loading.loading();

            for (int i = 0; i < emp.Announcement.Length; i++)
            {
                if (namejob == emp.Announcement[i].JobsName && cityjob == emp.Announcement[i].City && salaryjob == emp.Announcement[i].Salary && agejob == emp.Announcement[i].AgeForJob)
                {
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\n\n\t\t\t\t\t J O B  F I N D E D");
                    Thread.Sleep(2000);
                    Console.Clear();

                    IndexOfAnnouncement = i;
                    goto ShowAnnouncement;
                }
            }
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\n\n\t\t\t\t\t J O B  N O T  F I N D E D");
            Thread.Sleep(2000);
            goto ShowAnnouncement;

        }

    }

    else if (choice == 2)
    {
        Console.Clear();

        for (int i = 0; i < workers.Count; i++)
        {
            if (email == workers[i].Email)
            {
                if (workers[i].WorkerNotification == null)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Beep();
                    Console.WriteLine("\n\n\n\t\t\t N O  A N Y  N O T I F I C A T I O N");
                    Thread.Sleep(2000);

                    goto WorkerMenu;
                }
                break;
            }
        }

        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("\t\t\t" + @" _   _           _     _    __   _                  _     _                 ");
        Console.WriteLine("\t\t\t" + @"| \ | |         | |   (_)  / _| (_)                | |   (_)                ");
        Console.WriteLine("\t\t\t" + @"|  \| |   ___   | |_   _  | |_   _    ___    __ _  | |_   _    ___    _ __  ");
        Console.WriteLine("\t\t\t" + @"| . ` |  / _ \  | __| | | |  _| | |  / __|  / _` | | __| | |  / _ \  | '_ \ ");
        Console.WriteLine("\t\t\t" + @"| |\  | | (_) | | |_  | | | |   | | | (__  | (_| | | |_  | | | (_) | | | | |");
        Console.WriteLine("\t\t\t" + @"|_| \_|  \___/   \__| |_| |_|   |_|  \___|  \__,_|  \__| |_|  \___/  |_| |_|" + "\n");

        for (int i = 0; i < workers.Count; i++)
        {
            if (email == workers[i].Email)
            {
                workers[i].NotificationWorker();
            }
        }

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n\nTap to ESC button to go back\n");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.ReadKey();

        goto WorkerMenu;
    }

    else
        goto StartedMenu;
}

else if (index == 2)
{
    Worker newworker = new();

    Console.ForegroundColor = ConsoleColor.Yellow;

    Console.WriteLine("\t\t" + @"  _____                   _         _                     _____                         ");
    Console.WriteLine("\t\t" + @" |  __ \                 (_)       | |                   |  __ \                        ");
    Console.WriteLine("\t\t" + @" | |__) |   ___    __ _   _   ___  | |_    ___   _ __    | |__) |   __ _    __ _    ___ ");
    Console.WriteLine("\t\t" + @" |  _  /   / _ \  / _` | | | / __| | __|  / _ \ | '__|   |  ___/   / _` |  / _` |  / _ \");
    Console.WriteLine("\t\t" + @" | | \ \  |  __/ | (_| | | | \__ \ | |_  |  __/ | |      | |      | (_| | | (_| | |  __/");
    Console.WriteLine("\t\t" + @" |_|  \_\  \___|  \__, | |_| |___/  \__|  \___| |_|      |_|       \__,_|  \__, |  \___|");
    Console.WriteLine("\t\t" + @"                   __/ |                                                    __/ |       ");
    Console.WriteLine("\t\t" + @"                  |___/                                                    |___/        ");

    Console.Write("\n\n\t\t\u25ba Enter your email: ");
    newworker.Email = Console.ReadLine();
    Console.Write("\t\t\u25ba Enter your password: ");
    newworker.Password = Console.ReadLine();
    Console.Write("\t\t\u25ba Enter your Name: ");
    newworker.Name = Console.ReadLine();
    Console.Write("\t\t\u25ba Enter your Surname: ");
    newworker.Surname = Console.ReadLine();
    Console.Write("\t\t\u25ba Enter your City: ");
    newworker.City = Console.ReadLine();
    Console.Write("\t\t\u25ba Enter your Phone Number: ");
    newworker.PhoneNumber = Console.ReadLine();
    Console.Write("\t\t\u25ba Enter your Age: ");
    newworker.Age = Console.ReadLine();
    Console.Write("\t\t\u25ba Enter your Specialty: ");
    newworker.Specialty = Console.ReadLine();
    Console.Write("\t\t\u25ba Enter your School: ");
    newworker.School = Console.ReadLine();
    Console.Write("\t\t\u25ba Enter your University Score: ");
    newworker.UniJoinScore = Console.ReadLine();
    Console.Write("\t\t\u25ba Enter your Skills: ");
    newworker.Skills = Console.ReadLine();
    Console.Write("\t\t\u25ba Enter your Companies: ");
    newworker.Companies = Console.ReadLine();
    Console.Write("\t\t\u25ba Enter your work started and end: ");
    newworker.WorkStartEnd = Console.ReadLine();
    Console.Write("\t\t\u25ba Which language do you know?: ");
    newworker.Language = Console.ReadLine();
    Console.Write("\t\t\u25ba You have Diploma? ");
    newworker.Diploma = Console.ReadLine();
    newworker.Id = workers.Count + 1;

    workers.Add(newworker);
    Json.JsonSerializeWorker(workers);

    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Beep();
    Console.WriteLine("\n\n\n\t\t\t\t\t You Registered successfully");
    Thread.Sleep(2000);

    goto StartedMenu;
}

else if (index == 3)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("                                         About Us                                         ");

    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("About the project:");
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("Boss.Az is an online platform for accurate and fast job or employee search, which can benefit all participants of the labor market.The project provides users with a wide range of job postings and CV database.\n");
    Console.WriteLine("The project was launched in 2008 and is currently one of the leading online resources in the Azerbaijani labor market.\n");
    Console.WriteLine("Boss.Az is not an employment company.The aim of the project is to create an intermediary and prompt communication between the employer and the potential employee.\n");

    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Posting ads:\n");
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("Boss.Az - allows users to place job postings and CVs on the site.Each user can place a job advertisement and a CV for free during the month.\n");

    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Contact us:");
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("We do our best to develop and improve the project and are ready to listen to your views and suggestions.To contact us, you can write to the e-mail address boss@boss.az or call(012) 599 - 08 - 03.");

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("\n\nTap to ESC button to go back");
    Console.ForegroundColor = ConsoleColor.Yellow;

    var key = Console.ReadKey();

    if (key.Key == ConsoleKey.Escape)
    {
        Console.Beep(1000, 100);
        Console.Clear();

        goto StartedMenu;
    }
}

else
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Clear();
    Console.WriteLine("\t\t\t\t\t Thanks for visiting us! :D");
    Environment.Exit(0);
}