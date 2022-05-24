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
        public IQueryable<Report> GetReport([Service] AppDbContext context)
        {
            return context.REPORTS;
        }

        //Report Type
        [UseDbContext(typeof(AppDbContext))]
        [UseOffsetPaging]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<ReportType> GetReportType([Service] AppDbContext context)
        {
            return context.REPORTTYPES;
        }

        //Role
        [UseDbContext(typeof(AppDbContext))]
        [UseOffsetPaging]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<crp_apiRole> GetRole([Service] AppDbContext context)
        {
            return context.ROLES;
        }

    }
}