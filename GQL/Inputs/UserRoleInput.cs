namespace crp_api.GQL.Input.UserRole
{
    public record AddRoleInput(
        string? TITLE,
        string? DATE_CREATED
    );

    public record EditRoleInput(
        Guid ROLE_ID,
        string? TITLE
    );
}