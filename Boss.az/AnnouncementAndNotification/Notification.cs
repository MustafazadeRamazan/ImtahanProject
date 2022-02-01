using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationNamespace
{
    public sealed class Notification
    {
        public int Id { get; set; }

        public string Message { get; set; }

        public string? Work { get; set; }

        public DateTime DateTime { get; set; }

        public string? FromUser { get; set; }
 
        public Notification(int id, string message, string? work, string? fromUser)
        {
            Id = id;
            Message = message;
            Work = work;
            DateTime = DateTime.Now;
            FromUser = fromUser;
        }

        public override string ToString() =>
            $"Line: {Id}  |  Message: {Message} | Work: {Work}  |  DateTime: {DateTime}  |  From: \"{FromUser}\" user.\n";
    }


}