using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnnouncementNamespace;
using NotificationNamespace;
using WorkerNamespace;
using Boss.az.JsonServer;

namespace EmployerNamespace
{

    public class Employer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public string Vacancies { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Announcement[] Announcement { get; set; }
        public Notification[] Notifications { get; set; }

        public Employer(int id, string name, string surName, string city, string phone, int age, string vacancies, string email, string password, Announcement[] announcement, Notification[] notifications)
        {
            Id = id;
            Name = name;
            SurName = surName;
            City = city;
            Phone = phone;
            Age = age;
            Vacancies = vacancies;
            Email = email;
            Password = password;
            Announcement = announcement;
            Notifications = notifications;
        }

        public void AddNotification(Notification notification)
        {
            Notification[] newNotifications = new Notification[Notifications.Length + 1];

            for (int i = 0; i < Notifications.Length; i++)
            {
                newNotifications[i] = Notifications[i];
            }

            newNotifications[Notifications.Length] = notification;
            Notifications = newNotifications;
        }

        public void DeleteNotification(Notification notification)
        {
            Notification[] n = new Notification[Notifications.Length - 1];

            for (int i = 0, j = 0; i < Notifications.Length; i++)
            {
                if (Notifications[i] == notification)
                {
                    continue;
                }
                n[j++] = Notifications[i];
            }

            Notifications = n;
        }

        public void DeleteAllNotifications()
        {
            Notifications = new Notification[0];
        }

        public void ShowAllNotifications()
        {
            foreach (Notification notification in Notifications)
            {
                Console.WriteLine(notification);
            }
        }

        public void AddAnnouncement(Announcement announcement)
        {
            Announcement[] newAnnouncement = new Announcement[Announcement.Length + 1];

            for (int i = 0; i < Announcement.Length; i++)
            {
                newAnnouncement[i] = Announcement[i];
            }

            newAnnouncement[Announcement.Length] = announcement;
            Announcement = newAnnouncement;
            Json.JsonSerializeAnnouncement(announcement);
        }
    }
}