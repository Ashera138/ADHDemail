﻿namespace ADHDmail.Email
{
    /// <summary>
    /// Represents a standard email.
    /// </summary>
    public class Email : Message
    {
        /// <summary>
        /// A description of the topic of the message.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// The sender's email address.
        /// </summary>
        public string SendersEmail { get; set; }
    }
}
