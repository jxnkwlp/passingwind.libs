using System.Collections.Generic;
using System.Linq;

namespace Passingwind.PagedList
{
	/// <summary>
	///  pagedlist extensions
	/// </summary>
	public static class PagedListExtensions
	{
		/// <summary>
		///  convent list to paged list
		/// </summary> 
		public static IPagedList<T> ToPagedList<T>(this IEnumerable<T> list, int pageNumber, int pageSize)
		{
			var result = new PagedList<T>();
			result.LoadSource(list, pageNumber, pageSize);
			return result;
		}

		/// <summary>
		///  convent list to paged list
		/// </summary> 
		public static IPagedList<T> ToPagedList<T>(this IEnumerable<T> list, int pageNumber, int pageSize, int totalCount)
		{
			var result = new PagedList<T>();
			result.LoadSource(list, pageNumber, pageSize, totalCount);
			return result;
		}

		/// <summary>
		///  convent list to paged list
		/// </summary> 
		public static IPagedList<T> ToPagedList<T>(this IList<T> list, int pageNumber, int pageSize)
		{
			var result = new PagedList<T>();
			result.LoadSource(list, pageNumber, pageSize);
			return result;
		}

		/// <summary>
		///  convent list to paged list
		/// </summary> 
		public static IPagedList<T> ToPagedList<T>(this IList<T> list, int pageNumber, int pageSize, int totalCount)
		{
			var result = new PagedList<T>();
			result.LoadSource(list, pageNumber, pageSize, totalCount);
			return result;
		}

		/// <summary>
		///  convent list to paged list
		/// </summary> 
		public static IPagedList<T> ToPagedList<T>(this IQueryable<T> list, int pageNumber, int pageSize)
		{
			var result = new PagedList<T>();
			result.LoadSource(list, pageNumber, pageSize);
			return result;
		}

		/// <summary>
		///  convent list to paged list
		/// </summary> 
		public static IPagedList<T> ToPagedList<T>(this IOrderedQueryable<T> list, int pageNumber, int pageSize)
		{
			var result = new PagedList<T>();
			result.LoadSource(list, pageNumber, pageSize);
			return result;
		}
	}
}
