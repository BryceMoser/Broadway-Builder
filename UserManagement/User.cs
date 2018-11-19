﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement
{
    public class User
    {
        // Constructor
        public User(string email, string password, DateTime dob, string city, string stateProvince, string country, RoleType role)
        {
            Username = email;
            Password = password;
            DateOfBirth = dob;
            City = city;
            StateProvince = stateProvince;
            Country = country;
            Role = role;
        }

        // Defining Auto-Properties
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string Country { get; set; }
        public RoleType Role { get; set; }
    }

    public enum RoleType
    {
        GENERAL,
        THEATRE_ADMIN,
        SYS_ADMIN
    }
}
