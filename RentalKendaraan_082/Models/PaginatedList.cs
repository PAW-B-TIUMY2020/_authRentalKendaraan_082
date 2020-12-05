using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalKendaraan_082.Models
{
    public class PaginatedList<T> : List<T>
    {
        public int PageIndex { get; private set; }
        public int TotalPage { get; private set; }
        
        public PaginatedList (List<T> items,int count, int pageindex, int pageSize)
        {
            PageIndex = pageindex;
            TotalPage = (int)Math.Ceiling(count / (double)pageSize);

            this.AddRange(items);
        }

        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageIndex < TotalPage);
            }
        }

        public static async Task<PaginatedList<T>> CreateAsync(IQueryable<T> source, int pageIndex , int Pagesize)
        {
            var count = await source.CountAsync();
            var items = await source.Skip((pageIndex - 1) * Pagesize).Take(Pagesize).ToListAsync();
            return new PaginatedList<T>(items, count, pageIndex, Pagesize);
        }
    }
}
