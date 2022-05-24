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

    // public record AddReportTypeInput(
    //     string? NAME,
    //     string? DESCRIPTION,
    //     Guid? REPORTTYPE_ID
    // );

    // public record EditReportTypeInput(
    //     string? NAME,
    //     string? DESCRIPTION,
    //     string? UPDATED_BY,
    //     Guid? REPORTTYPE_ID
    // );


}