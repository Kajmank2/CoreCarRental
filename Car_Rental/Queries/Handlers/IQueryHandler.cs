using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental.Queries.Handlers
{
    public interface IQueryHandler<TQuery, Tresult> where TQuery: IQuery
    {
        Tresult Execute(TQuery query);
    }
}
