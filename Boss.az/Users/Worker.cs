using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WorkerNamespace
{
    public class Worker
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? City { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Age { get; set; }
        public string? Specialty { get; set; }
        public string? School { get; set; }
        public string? UniJoinScore { get; set; }
        public string? Skills { get; set; }
        public string? Companies { get; set; }
        public string? WorkStartEnd { get; set; }
        public string? Language { get; set; }
        public string? Diploma { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? WorkerNotification { get; set; }

        public Worker()
        {

        }

        public Worker(string? email, string? password, int id, string? name, string? surname, string? city, string? phoneNumber, string? age, string? specialty, string? school, string? uniJoinScore, string? skills, string? companies, string? workStartEnd, string? language, string? diploma, string? Workernotification)
        {
            Email = email;
            Password = password;
            Id = id;
            Name = name;
            Surname = surname;
            City = city;
            PhoneNumber = phoneNumber;
            Age = age;
            Specialty = specialty;
            School = school;
            UniJoinScore = uniJoinScore;
            Skills = skills;
            Companies = companies;
            WorkStartEnd = workStartEnd;
            Language = language;
            Diploma = diploma;
            WorkerNotification = Workernotification;
        }

        public void NotificationWorker()
        {
            Console.WriteLine(WorkerNotification);
        }

        public override string ToString() => $"----------------------Worker Profile----------------------\nId:{Id}\nName: {Name}\nSurname: {Surname}\nCity: {City}\nPhoneNumber: {PhoneNumber}\nAge: {Age}\nSpecialty: {Specialty}\nSchool: {School}\nUniJoinScore: {UniJoinScore}\nSkills: {Skills}\nCompanies: {Companies}\nWork Started Ended: {WorkStartEnd}\nLanguage: {Language}\nDiploma: {Diploma}\n--------------------------------------------------";
    }

}