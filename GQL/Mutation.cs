using crp_api.Data;
using crp_api.GQL.Input.Users;
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
            catch(Exception e)
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

                if (edit.FNAME!=null)
                user.FNAME = edit.FNAME;

                 if (edit.LNAME!=null)
                user.LNAME = edit.LNAME;

                 if (edit.EMAIL!=null)
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
            catch(Exception e)
            {
                await transaction.RollbackAsync(cancellationToken);

                return null;
            }
        }
    }
}