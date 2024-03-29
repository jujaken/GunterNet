﻿namespace GunterNet.Models.Users
{
    public class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public User Sender { get; set; }
        public User Recipient { get; set; }
        public string SenderId { get; internal set; }
        public string RecipientId { get; internal set; }
    }
}