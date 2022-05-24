using crp_api.Data;
using crp_api.GQL.Input.Users;
<<<<<<< HEAD
using crp_api.GQL.Input.ReportLog;
using crp_api.GQL.Input.ReportStatus;
=======
using crp_api.GQL.Input.ReportType;
using crp_api.GQL.Input.UserRole;
>>>>>>> master
using crp_api.Models.Entities;

using System.Net;

namespace crp_api.GQL.Mutations
{
    public partial class Mutation
    {
        [UseDbContext(typeof(AppDbContext))]
        public async Task<Response> AddUserAsync(
            AddUserInput input, [Service] AppDbContext context,
            CancellationToken cancellationToken
        )
        {
            var transaction = await context.Database.BeginTransactionAsync(cancellationToken);

            var appUser = new Guid();
            try
            {
                var user = new crp_api.Models.Entities.User
                {
                    FNAME = input.FNAME,
                    LNAME = input.LNAME,
                    EMAIL = input.EMAIL
                };

                context.USERS.Add(user);

                await context.SaveSessionChangesAsync(cancellationToken, appUser);

                await transaction.CommitAsync(cancellationToken);

                return new Response
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    ResponseMessage = "User Successfully Created",
                    ResponseLabel = "User Successfully Created"
                };
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync(cancellationToken);

                return null;
            }
        }

        [UseDbContext(typeof(AppDbContext))]
        public async Task<Response> EditUserAsync(
            EditUserInput edit, [Service] AppDbContext context,
            CancellationToken cancellationToken
        )
        {
            var transaction = await context.Database.BeginTransactionAsync(cancellationToken);

            var appUser = new Guid();
            try
            {
                var user = await context.FindAsync<User>(edit.USER_ID);

                if (edit.FNAME != null)
                    user.FNAME = edit.FNAME;

                if (edit.LNAME != null)
                    user.LNAME = edit.LNAME;

                if (edit.EMAIL != null)
                    user.EMAIL = edit.EMAIL;

                context.USERS.Update(user);
                await context.SaveSessionChangesAsync(cancellationToken, appUser);

                await transaction.CommitAsync(cancellationToken);

                return new Response
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    ResponseMessage = "User Successfully Created",
                    ResponseLabel = "User Successfully Created"
                };
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync(cancellationToken);

                return null;
            }
        }

        //Report Type
        [UseDbContext(typeof(AppDbContext))]
        public async Task<Response> AddReportTypeAsync(
             AddReportTypeInput input, [Service] AppDbContext context,
             CancellationToken cancellationToken
         )
        {
            var transaction = await context.Database.BeginTransactionAsync(cancellationToken);

            var appUser = new Guid();
            try
            {
                var report = new crp_api.Models.Entities.ReportType
                {
                    NAME = input.NAME,
                    DESCRIPTION = input.DESCRIPTION
                    // CREATED_BY = input.CREATED_BY,
                };

                context.REPORTTYPES.Add(report);

                await context.SaveSessionChangesAsync(cancellationToken, appUser);

                await transaction.CommitAsync(cancellationToken);

                return new Response
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    ResponseMessage = "User Successfully Created",
                    ResponseLabel = "User Successfully Created"
                };
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync(cancellationToken);

                return null;
            }
        }

        [UseDbContext(typeof(AppDbContext))]
        public async Task<Response> EditReportTypeAsync(
            EditReportTypeInput edit, [Service] AppDbContext context,
            CancellationToken cancellationToken
        )
        {
            var transaction = await context.Database.BeginTransactionAsync(cancellationToken);

            var appUser = new Guid();
            try
            {
                var report = await context.FindAsync<ReportType>(edit.REPORTTYPE_ID);

                if (edit.NAME != null)
                    report.NAME = edit.NAME;

                if (edit.DESCRIPTION != null)
                    report.DESCRIPTION = edit.DESCRIPTION;

                context.REPORTTYPES.Update(report);
                await context.SaveSessionChangesAsync(cancellationToken, appUser);

                await transaction.CommitAsync(cancellationToken);

                return new Response
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    ResponseMessage = "User Successfully Created",
                    ResponseLabel = "User Successfully Created"
                };
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync(cancellationToken);

                return null;
            }
        }

        //Role
        [UseDbContext(typeof(AppDbContext))]
        public async Task<Response> AddRoleAsync(
                     AddRoleInput input, [Service] AppDbContext context,
                     CancellationToken cancellationToken
                 )
        {
            var transaction = await context.Database.BeginTransactionAsync(cancellationToken);

            var appUser = new Guid();
            try
            {
                var role = new crp_api.Models.Entities.crp_apiRole
                {
                    TITLE = input.TITLE,

                };

                context.ROLES.Add(role);

                await context.SaveSessionChangesAsync(cancellationToken, appUser);

                await transaction.CommitAsync(cancellationToken);

                return new Response
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    ResponseMessage = "User Successfully Created",
                    ResponseLabel = "User Successfully Created"
                };
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync(cancellationToken);

                return null;
            }
        }

        [UseDbContext(typeof(AppDbContext))]
        public async Task<Response> EditRoleAsync(
            EditRoleInput edit, [Service] AppDbContext context,
            CancellationToken cancellationToken
        )
        {
            var transaction = await context.Database.BeginTransactionAsync(cancellationToken);

            var appUser = new Guid();
            try
            {
                var role = await context.FindAsync<crp_apiRole>(edit.ROLE_ID);

                if (edit.TITLE != null)
                    role.TITLE = edit.TITLE;

                // if (edit.DATE_CREATED != null)
                //     role.DATE_CREATED = edit.DATE_CREATED;

                context.ROLES.Update(role);
                await context.SaveSessionChangesAsync(cancellationToken, appUser);

                await transaction.CommitAsync(cancellationToken);

                return new Response
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    ResponseMessage = "User Successfully Created",
                    ResponseLabel = "User Successfully Created"
                };
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync(cancellationToken);

                return null;
            }
        }
<<<<<<< HEAD
        //REPORTLOG
        [UseDbContext(typeof(AppDbContext))]
        public async Task<Response> AddReportLogAsync(
            AddReportLog input, [Service] AppDbContext context,
            CancellationToken cancellationToken
        )
        {
            var transaction = await context.Database.BeginTransactionAsync(cancellationToken);

            var appUser = new Guid();
            try
            {
                var reportlog = new crp_api.Models.Entities.ReportLog 
                {
                    NAME = input.NAME,
                    DESCRIPTION = input.DESCRIPTION,
               
                };

                context.REPORTLOGS.Add(reportlog);

                await context.SaveSessionChangesAsync(cancellationToken, appUser);

                await transaction.CommitAsync(cancellationToken);

                return new Response
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    ResponseMessage = "User Successfully Created",
                    ResponseLabel = "User Successfully Created"
                };
            }
            catch(Exception e)
            {
                await transaction.RollbackAsync(cancellationToken);

                return null;
            }
        }
        //reportlog edit
         [UseDbContext(typeof(AppDbContext))]
        public async Task<Response> EditReportLogAsync(
            EditReportLog edit, [Service] AppDbContext context,
            CancellationToken cancellationToken
        )
        {
            var transaction = await context.Database.BeginTransactionAsync(cancellationToken);

            var appUser = new Guid();
            try
            {
                var reportlog = await context.FindAsync<ReportLog>(edit.REPORTLOG_ID);

                if (edit.NAME!=null)
                reportlog.NAME = edit.NAME;

                 if (edit.DESCRIPTION!=null)
                reportlog.DESCRIPTION = edit.DESCRIPTION;


                context.REPORTLOGS.Update(reportlog);
                await context.SaveSessionChangesAsync(cancellationToken, appUser);

                await transaction.CommitAsync(cancellationToken);

                return new Response
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    ResponseMessage = "User Successfully Created",
                    ResponseLabel = "User Successfully Created"
                };
            }
            catch(Exception e)
            {
                await transaction.RollbackAsync(cancellationToken);

                return null;
            }
        }
         //REPORTSTATUS
        [UseDbContext(typeof(AppDbContext))]
        public async Task<Response> AddReportStatusAsync(
            AddReportStatus input, [Service] AppDbContext context,
            CancellationToken cancellationToken
        )
        {
            var transaction = await context.Database.BeginTransactionAsync(cancellationToken);

            var appUser = new Guid();
            try
            {
                var reportstat = new crp_api.Models.Entities.ReportStatus 
                {
                    NAME = input.NAME,
                    DESCRIPTION = input.DESCRIPTION,
               
                };

                context.REPORTSTATUSES.Add(reportstat);

                await context.SaveSessionChangesAsync(cancellationToken, appUser);

                await transaction.CommitAsync(cancellationToken);

                return new Response
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    ResponseMessage = "User Successfully Created",
                    ResponseLabel = "User Successfully Created"
                };
            }
            catch(Exception e)
            {
                await transaction.RollbackAsync(cancellationToken);

                return null;
            }
        }
         //reportlog edit
        [UseDbContext(typeof(AppDbContext))]
        public async Task<Response> EditReportStatusAsync(
            EditReportStatus edit, [Service] AppDbContext context,
            CancellationToken cancellationToken
        )
        {
            var transaction = await context.Database.BeginTransactionAsync(cancellationToken);

            var appUser = new Guid();
            try
            {
                var reportstat = await context.FindAsync<ReportStatus>(edit.REPORTSTATUS_ID);

                if (edit.NAME!=null)
                reportstat.NAME = edit.NAME;

                 if (edit.DESCRIPTION!=null)
                reportstat.DESCRIPTION = edit.DESCRIPTION;


                context.REPORTSTATUSES.Update(reportstat);
                await context.SaveSessionChangesAsync(cancellationToken, appUser);

                await transaction.CommitAsync(cancellationToken);

                return new Response
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    ResponseMessage = "User Successfully Created",
                    ResponseLabel = "User Successfully Created"
                };
            }
            catch(Exception e)
            {
                await transaction.RollbackAsync(cancellationToken);

                return null;
            }
=======



>>>>>>> master
    }
        }
    }

    