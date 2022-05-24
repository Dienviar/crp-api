namespace crp_api.GQL.Input.ReportType
{
    public record AddReportTypeInput(
        string? NAME,
        string? DESCRIPTION,
        Guid? REPORTTYPE_ID
    );

    public record EditReportTypeInput(
        string? NAME,
        string? DESCRIPTION,
        Guid? REPORTTYPE_ID
    );
}