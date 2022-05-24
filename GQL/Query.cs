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
<<<<<<< HEAD
        public IQueryable<User> GetUsers([Service] AppDbContext context) 
=======

        public IQueryable<User> GetUsers([Service] AppDbContext context)
>>>>>>> master
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
<<<<<<< HEAD
        //reportlog
=======

        //Report Type
>>>>>>> master
        [UseDbContext(typeof(AppDbContext))]
        [UseOffsetPaging]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
<<<<<<< HEAD
         public IQueryable<ReportLog> GetReportLog([Service] AppDbContext context) 
        {
            return context.REPORTLOGS;
        }
        //reportstat
=======
        public IQueryable<ReportType> GetReportType([Service] AppDbContext context)
        {
            return context.REPORTTYPES;
        }

        //Role
>>>>>>> master
        [UseDbContext(typeof(AppDbContext))]
        [UseOffsetPaging]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
<<<<<<< HEAD
         public IQueryable<ReportStatus> GetReportStatus([Service] AppDbContext context) 
        {
            return context.REPORTSTATUSES;
        }
         
=======
        public IQueryable<crp_apiRole> GetRole([Service] AppDbContext context)
        {
            return context.ROLES;
        }

>>>>>>> master
    }
}