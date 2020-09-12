using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        Student GetById(long id);
        Student GetStudentByName(string name);
    }
}
