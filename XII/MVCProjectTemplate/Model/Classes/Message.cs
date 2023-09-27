using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Classes
{
    public class Message
    {
        [Key]
        [MaxLength(40, ErrorMessage = "Max length is 40!")]
        public string Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Title { get; set; }

        [Required]
        [StringLength(maximumLength: 5000, ErrorMessage = "Maximum length of 5000 reached!", MinimumLength = 1)]
        public string Text { get; set; }

        [Display(Name = "Sender")]
        [ForeignKey("Sender")]
        public string SenderId { get; set; }

        [Display(Name = "Sender")]
        [ForeignKey("Receiver")]
        public string ReceiverId { get; set; }

        public User Sender { get; set; }

        public User Receiver { get; set; }

        public Message()
        {

        }

        public Message(string title, string text, string senderId)
        {
            this.Id ??= Guid.NewGuid().ToString();
            this.Title = title;
            this.Text = text;
            this.SenderId = senderId;
            this.Receiver = null;
        }

        public Message(string title, string text, string senderId, string receiverId) :
            this(title, text, senderId)
        {
            this.ReceiverId = receiverId;
        }

        // Not used constructors!
        public Message(string id, string title, string text, User sender)
        {
            this.Id = id;
            this.Title = title;
            this.Text = text;
            this.Sender = sender;
            this.SenderId = sender.Id;
            this.Receiver = null;
        }

        public Message(string id, string title, string text, User sender, User receiver)
            : this(id, title, text, sender)
        {
            this.Receiver = receiver;
            this.ReceiverId = receiver.Id;
        }

        public override string ToString()
        {
            return $"{Id} {Title} {Text} {Sender}";
        }
    }
}
