using Inspectors;
using EmployerNamespace;
using AnnouncementNamespace;
using NotificationNamespace;
using System.Text;
using WorkerNamespace;
using Newtonsoft.Json;

namespace Boss.az.JsonServer
{
    public class Json
    {
        public static void JsonSerializeWorker(List<Worker> workers)
        {
            var str = JsonConvert.SerializeObject(workers, Formatting.Indented);
            Console.WriteLine(str);
            File.WriteAllText("worker.json", str);
        }

        public static void JsonSerializeEmployer(Employer employers)
        {
            var str = JsonConvert.SerializeObject(employers, Formatting.Indented);
            Console.WriteLine(str);
            File.WriteAllText("employer.json", str);
        }

        public static void JsonDeserializeWorker(List<Worker> workers, int id)
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            workers = null;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

            var jsonStr = File.ReadAllText("worker.json");

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            workers = JsonConvert.DeserializeObject<List<Worker>>(jsonStr);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            Console.WriteLine(workers[id]);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }

        public static void JsonSerializeAnnouncement(Announcement announcements)
        {
            var str = JsonConvert.SerializeObject(announcements, Formatting.Indented);
            Console.WriteLine(str);
            File.WriteAllText("announcements.json", str);
        }
        public static void JsonDeserializeAnnouncement(Announcement announcements)
        {
            announcements = null;

            var jsonStr = File.ReadAllText("announcements.json");

            announcements = JsonConvert.DeserializeObject<Announcement>(jsonStr);

            Console.WriteLine(announcements);
        }
    }
}
