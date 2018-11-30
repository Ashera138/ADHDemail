﻿namespace ADHDmail.Config
{
    /// <summary>
    /// Represents the config file for Gmail's OAuth credentials.
    /// <para>This file should be encrypted to secure the user's credentials.
    /// </para>
    /// </summary>
    public class GmailOAuthCredentials : ConfigFile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GmailOAuthCredentials"/> class.
        /// </summary>
        public GmailOAuthCredentials(string fileName = "GmailOAuth.json")
        {
            FullPath = GetFullPath(fileName);
        }
    }
}
