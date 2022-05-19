using crp_api.Data;
using crp_api.Models.Entities;

namespace crp_api.GQL.Queries
{
    public partial class Query
    {
        [UseDbContext(typeof(AppDbContext))]
        [UseOffsetPaging]
        [UseProjection]
        [UseFiltering]
        [UseSorting]

        public IQueryable<User> GetUsers([Service] AppDbContext context)
        {
            return context.USERS;
        }


        [UseDbContext(typeof(AppDbContext))]
        [UseOffsetPaging]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Report> GetReports([Service] AppDbContext context)
        {
            return context.REPORTS;
        }
    }
}