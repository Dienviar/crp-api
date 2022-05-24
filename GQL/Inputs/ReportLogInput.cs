using crp_api.Models.Entities;

namespace crp_api.GQL.Input.ReportLog
{
    public record AddReportLog(
        string? NAME,
        string? DESCRIPTION,
        Guid? USER_ID


    );
    public record EditReportLog(
        Guid? USER_ID,
        string? NAME,
        string? DESCRIPTION,
        Guid REPORTLOG_ID
    );
}