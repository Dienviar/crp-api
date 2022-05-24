using crp_api.Data;
using crp_api.GQL.Input.Users;
using crp_api.GQL.Input.Reports;
using crp_api.GQL.Input.Proofs;
using crp_api.Models.Entities;
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

        [UseDbContext(typeof(AppDbContext))]
        public async Task<Response> AddReport(
             AddReportInput input, [Service] AppDbContext context,
             CancellationToken cancellationToken
         )
        {
            var transaction = await context.Database.BeginTransactionAsync(cancellationToken);

            var appUser = new Guid();
            try
            {
                var report = new crp_api.Models.Entities.Report
                {
                    TITLE = input.TITLE,
                    BODY = input.BODY,
                    REPORTTYPE_ID = input.REPORTTYPE_ID,
                    UPLOADED_PROOFS = input.UPLOADED_PROOFS,
                    USER_ID = input.USER_ID
                };

                context.REPORTS.Add(report);

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
        public async Task<Response> AddProof(
        AddProof input, [Service] AppDbContext context,
        CancellationToken cancellationToken
        )
        {
            var transaction = await context.Database.BeginTransactionAsync(cancellationToken);

            var appUser = new Guid();
            try
            {
                var proof = new crp_api.Models.Entities.Proof
                {
                    NAME = input.NAME,
                    URL = input.URL,
                    REMARKS = input.REMARKS,
                    REPORT_ID = input.REPORT_ID
                };

                context.PROOF.Add(proof);

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
        public async Task<Response> EditProof(
        EditProof edit, [Service] AppDbContext context,
        CancellationToken cancellationToken
        )
        {
            var transaction = await context.Database.BeginTransactionAsync(cancellationToken);

            var appUser = new Guid();
            try
            {
                var proof = await context.FindAsync<Proof>(edit.PROOF_ID);

                if (edit.NAME != null)
                    proof.NAME = edit.NAME;

                if (edit.URL != null)
                    proof.URL = edit.URL;

                if (edit.REMARKS != null)
                    proof.REMARKS = edit.REMARKS;

                context.PROOF.Update(proof);
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
    }
}