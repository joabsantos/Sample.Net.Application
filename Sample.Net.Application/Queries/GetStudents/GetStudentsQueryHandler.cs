using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Sample.Net.Application.Queries.GetStudents
{
    public class GetStudentsQueryHandler : IRequestHandler<GetStudentsQuery, List<GetStudentsViewModel>>
    {
        public Task<List<GetStudentsViewModel>> Handle(GetStudentsQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new List<GetStudentsViewModel>()
            {
                new GetStudentsViewModel
                {
                    FullName = "Test"
                }
            });
        }
    }
}
