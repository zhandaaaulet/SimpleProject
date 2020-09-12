using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Models
{
    
    public class Student
    {
        public long Id { get; set; }
        public string Login { get; set; }
        public string FullName { get; set; }
        public string PasswordHash { get; set; }
        public long GroupId { get; set; }
        public DateTimeOffset Birthdate { get; set; }

    }
}
