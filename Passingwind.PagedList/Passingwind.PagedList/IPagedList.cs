using System;
using System.Collections.Generic;

namespace Passingwind.PagedList
{
    public interface IPagedList
    {
        int PageSize { get; set; }

        int PageNumber { get; set; }

        int TotalPage { get; }

        int TotalCount { get; }
    }

    public interface IPagedList<T> : IList<T>, IPagedList
    {
        IPagedList<T2> ReplaceTo<T2>(Func<T, T2> func); 
    }
}
