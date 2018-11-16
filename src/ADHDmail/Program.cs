﻿using ADHDmail.API;
using ADHDmail.Config;
using System;
using System.Collections.Generic;

namespace ADHDmail
{
    class Program
    {
        public static void Main(string[] args)
        {
            IEmailApi api = new GmailApi();

            var queryFilters = new List<Filter>()
            {
                new Filter(FilterOption.Unread),
                new Filter(FilterOption.LargerThan, "1"),
                new Filter(FilterOption.From, "GitHub")
            };
            var query = new GmailQuery(queryFilters);
            var unreadEmails = api.GetEmails(query);

            unreadEmails.ForEach(e =>
                Console.WriteLine($"Email ID: {e.Id} Time received: {e.TimeReceived}. " +
                $"Subject: {e.Subject} Time: {e.TimeReceived}"));

            Console.WriteLine("-----------------------");

            // True means all DateTime values were correctly parsed
            Console.WriteLine(unreadEmails.TrueForAll(e => e.TimeReceived != DateTime.MinValue));
        }
    }
}
