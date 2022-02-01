using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnouncementNamespace
{
    public class Announcement
    {
        public UInt16 Id { get; set; }
        public string? JobsName { get; set; }
        public string? YourName { get; set; }
        public string? AboutJob { get; set; }
        public string? City { get; set; }
        public string? Phone { get; set; }
        public string? AgeForJob { get; set; }
        public string? Salary { get; set; }
        public string? Email { get; set; }
        public DateTime CreationDatetime { get; set; }
        public UInt16 Acception { get; set; }
        public uint ViewCount { get; set; }


        public Announcement(UInt16 id, string? jobsName, string? yourName, string? aboutJob, string? city, string? phone, string? ageForJob, string? salary, string? email, UInt16 acception, uint viewCount)
        {
            Id = id;
            JobsName = jobsName;
            YourName = yourName;
            AboutJob = aboutJob;
            City = city;
            Phone = phone;
            AgeForJob = ageForJob;
            Salary = salary;
            Email = email;
            CreationDatetime = DateTime.Now;
            Acception = acception;
            ViewCount = viewCount;
        }


        public void ShowPost()
        {
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\t\t\t\t"+@" _   _                  __          __           _    ");
            Console.WriteLine("\t\t\t\t"+@"| \ | |                 \ \        / /          | |   ");
            Console.WriteLine("\t\t\t\t"+@"|  \| |  ___ __      __  \ \  /\  / /___   _ __ | | __");
            Console.WriteLine("\t\t\t\t"+@"| . ` | / _ \\ \ /\ / /   \ \/  \/ // _ \ | '__|| |/ /");
            Console.WriteLine("\t\t\t\t"+@"| |\  ||  __/ \ V  V /     \  /\  /| (_) || |   |   < ");
            Console.WriteLine("\t\t\t\t"+@"|_| \_| \___|  \_/\_/       \/  \/  \___/ |_|   |_|\_\");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n\nPost accepted from {Acception} user");
            Console.WriteLine($"Views: {ViewCount}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
        }

        public override string ToString() =>
            $"Id: {Id}\nJobsName: {JobsName}\nYourName: {YourName}\nAboutJob: {AboutJob}\nCity: {City}\nPhone: {Phone}\nAgeForJob: {AgeForJob}\nSalary: {Salary}\nContact Email: {Email}\nCreation DateTime: {CreationDatetime.ToShortDateString()}\n" +
            $"Job Accepted from: {Acception} users  |  Views: {ViewCount}";
    }

}