using crp_api.Data;
using crp_api.GQL.Input.Users;
using crp_api.GQL.Payload.Users;

namespace crp_api.GQL.Mutations
{
    public partial class Mutation
    {
        [UseDbContext(typeof(AppDbContext))]
        public async Task<UserPayload> AddUserAsync(
            AddUserInput input, [Service] AppDbContext context,
            CancellationToken cancellationToken
        )
        {
            var appUser = new Guid();
            try
            {
                var user = new crp_api.Models.Entities.User
                {
                    FNAME = input.FNAME,
                    LNAME = input.LNAME,
                    EMAIL = input.EMAIL,
                    USER_ID = appUser
                };

                context.USERS.Add(user);
                await context.SaveSessionChangesAsync(cancellationToken, appUser);
                return new UserPayload(user);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}