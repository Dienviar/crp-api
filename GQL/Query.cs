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
        //reportlog
        [UseDbContext(typeof(AppDbContext))]
        [UseOffsetPaging]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
         public IQueryable<ReportLog> GetReportLog([Service] AppDbContext context) 
        {
            return context.REPORTLOGS;
        }
        //reportstat
        [UseDbContext(typeof(AppDbContext))]
        [UseOffsetPaging]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
         public IQueryable<ReportStatus> GetReportStatus([Service] AppDbContext context) 
        {
            return context.REPORTSTATUSES;
        }
         
    }
}