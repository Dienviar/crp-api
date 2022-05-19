namespace crp_api.GQL.Input.Reports
{
    public record AddReportInput(
        string? TITLE,
        string? BODY,
        string? URL,
        Guid? REPORTTYPE_ID,
        Guid? USER_ID
    );
    public record EditReportInput(
        Guid REPORT_ID,
        string? TITLE,
        string? BODY,
        string? URL,
        Guid? REPORTSTATUS_ID
    );

}