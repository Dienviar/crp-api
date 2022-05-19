namespace crp_api.GQL.Input.Users
{
    public record AddUserInput(
        string? FNAME,
        string? LNAME,
        string? EMAIL
    );
    public record EditUserInput(
        Guid USER_ID,
        string? FNAME,
        string? LNAME,
        string? EMAIL
    );

}