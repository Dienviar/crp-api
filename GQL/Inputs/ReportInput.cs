using crp_api.Models.Entities;
using System;
using System.Collections.Generic;

namespace crp_api.GQL.Input.Reports
{
    public record AddReportInput(
        string? TITLE,
        string? BODY,
        Guid? REPORTTYPE_ID,
        List<Proof>? UPLOADED_PROOFS,
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