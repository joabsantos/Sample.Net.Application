﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.Application.Commands.AddStudent
{
    public class AddStudentCommandHandler : IRequestHandler<AddStudentCommand>
    {
        public Task<Unit> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Unit.Value);
        }
    }
}
