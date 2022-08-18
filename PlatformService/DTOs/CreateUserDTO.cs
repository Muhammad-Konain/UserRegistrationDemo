using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace PlatformService.DTOs
{
    public class CreateUserDTO
    {
        public string fullName { get; set; }
        public string email { get; set; }
        public string middleName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string phoneNumber { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public bool hasDualNationality { get; set; }
        public IFormFile selfie { get; set; }
        public IFormFile nationalIdFront { get; set; }
        public IFormFile nationalIdBack { get; set; }
        public IFormFile profileImage { get; set; }
        public IFormFile utilityBill { get; set; }
    }
}
