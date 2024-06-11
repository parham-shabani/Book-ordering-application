
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application.Query.BookQueries.GetBook
{
    public record GetBookQuery : IRequest<GetBookQueryResponse>
    {
        public int Id { get; set; }
    }
}
