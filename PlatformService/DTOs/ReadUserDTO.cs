using System;

namespace PlatformService.DTOs
{
    public class ReadUserDTO
    {
        public int Id { get; set; }
        public string fullName { get; set; }
        public string email { get; set; }
        public string middleName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string phoneNumber { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public bool hasDualNationality { get; set; }
    }
}
