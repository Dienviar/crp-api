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

    // public record AddRoleInput(
    //     string? TITLE,
    //     string? DATE_CREATED
    // );

    // public record EditRoleInput(
    //     Guid ROLE_ID,
    //     string? TITLE,
    //     // string? DATE_CREATED,
    //     string? DATE_UPDATED
    // );
}