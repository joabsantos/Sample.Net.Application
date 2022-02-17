using MediatR;
using System;

namespace CQRS.Application.Commands.AddStudent
{
    public class AddStudentCommand : IRequest
    {
        public AddStudentCommand(string fullName, DateTime birthDate, int id)
        {
            FullName = fullName;
            BirthDate = birthDate;
            Id = id;
        }

        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Id { get; set; }
    }
}
