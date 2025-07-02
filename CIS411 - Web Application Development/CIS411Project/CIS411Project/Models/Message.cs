using System.ComponentModel.DataAnnotations;

namespace CIS411Project.Models
{
    public class Message
    { //class for messages

        [Key]
        public int MessageID { get; set; }
        public DateTime MessageTime { get; set; }
        public string MessageSender { get; set; }
        public string MessageReceiver { get; set; }
        public string MessageContent { get; set; }

    }
}
