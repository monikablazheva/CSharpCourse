using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    [SerializableAttribute]
    public class Message
    {
        public string ID { get; private set; }

        public string Title { get; private set; }

        public string Text { get; private set; }

        public User Sender { get; private set; }

        public User Receiver { get; private set; }

        private Message()
        {
            
        }

        public Message(string title, string text, User sender)
        {
            this.ID = Guid.NewGuid().ToString();
            this.Title = title;
            this.Text = text;
            this.Sender = sender;
        }

        public Message(string title, string text, User sender, User receiver)
            : this(title, text, sender)
        {
            this.Receiver = receiver;
        }

    }
}
