using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.Repositories.Interfaces;

namespace WebAPI.Repositories.Implementations
{
    public class InMemoryStudentRepository : IStudentRepository
    {
        private readonly List<Student> _students;

        public InMemoryStudentRepository()
        {
            _students = new List<Student>
            {
                new Student{Id = 1, FullName="Shotrefnov", Login = "shokan75", GroupId = 0, PasswordHash = "passreford", Birthdate = DateTimeOffset.UtcNow},
                new Student{Id = 2, FullName="Shokan Uargefdkhanov", Login = "shokan75", GroupId = 0, PasswordHash = "ptrvf", Birthdate = DateTimeOffset.UtcNow},
                new Student{Id = 3, FullName="Shokan Uarflikhanov", Login = "shokan75", GroupId = 0, PasswordHash = "pafdrd", Birthdate = DateTimeOffset.UtcNow},
                new Student{Id = 4, FullName="Shokan Ualikhanov", Login = "shokan75", GroupId = 0, PasswordHash = "passiokhjd", Birthdate = DateTimeOffset.UtcNow},
                new Student{Id = 5, FullName="Shorfdan Ualikhanov", Login = "shokan75", GroupId = 0, PasswordHash = "pastrd", Birthdate = DateTimeOffset.UtcNow},
                new Student{Id = 6, FullName="ShokrfdUalikhanov", Login = "shokan75", GroupId = 0, PasswordHash = "pastrd", Birthdate = DateTimeOffset.UtcNow},

            };
        }
        public Student GetById(long id)
        {
            return _students.FirstOrDefault(student => student.Id == id);
        }

        public Student GetStudentByName(string name)
        {

            return _students.FirstOrDefault(s => s.FullName == name);
        }
    }
}
