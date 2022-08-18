using System;
using System.Collections.Generic;

namespace PlatformService.Models
{
    public class User
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string email { get; set; }
        public string middleName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string phoneNumber { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public bool hasDualNationality { get; set; }
        public string selfie { get; set; }
        public string nationalIdfront { get; set; }
        public string nationalIdback { get; set; }
        public string profileImage { get; set; }
        public string utilityBill { get; set; }
    }
}
