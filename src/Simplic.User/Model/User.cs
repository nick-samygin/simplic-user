﻿using System;

namespace Simplic.User
{
    /// <summary>
    /// Represents the user data base table
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the Id
        /// </summary>
        public int Ident { get; set; }

        /// <summary>
        /// Gets or sets the user name, max length: 100
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the password, max length: 100
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets if the user is an active directory user
        /// </summary>
        public bool IsADUser { get; set; }

        /// <summary>
        /// Gets or sets if the user is active
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the first name of the user
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the user
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the email of the user
        /// </summary>
        public string EMail { get; set; }

        /// <summary>
        /// Gets or sets if the user should be kept logged in
        /// </summary>
        public bool KeepLoggedIn { get; set; }

        /// <summary>
        /// Gets or sets the current ApiKey
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets or sets the current LanguageID
        /// </summary>
        public int LanguageID { get; set; }

        /// <summary>
        /// Gets or sets the user that is substituting this user
        /// </summary>
        public int? SubstituteUserId { get; set; }

        /// <summary>
        /// Gets or sets whether the substitution is active
        /// </summary>
        public bool SubstitutionIsActive { get; set; }

        /// <summary>
        /// Gets or sets the substitution start date
        /// </summary>
        public DateTime? SubstitutionStart { get; set; }

        /// <summary>
        /// Gets or sets the substitution end date
        /// </summary>
        public DateTime? SubstitutionEnd { get; set; }

        /// <summary>
        /// Gets or sets the user phone number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the user description
        /// </summary>
        public string Description { get; set; }
    }
}
