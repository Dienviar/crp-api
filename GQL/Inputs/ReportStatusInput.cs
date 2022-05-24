using crp_api.Models.Entities;
namespace crp_api.GQL.Input.ReportStatus
{
    public record AddReportStatus(
        string? NAME,
        string? DESCRIPTION
       
    );
    public record EditReportStatus(
        string? NAME,
        string? DESCRIPTION,
        Guid REPORTSTATUS_ID
        
    );
}