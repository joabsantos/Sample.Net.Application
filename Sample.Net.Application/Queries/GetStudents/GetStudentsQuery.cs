using MediatR;
using System.Collections.Generic;

namespace Sample.Net.Application.Queries.GetStudents
{
    public class GetStudentsQuery : IRequest<List<GetStudentsViewModel>>
    {

    }
}
