namespace crp_api.GQL.Input.Proofs
{
    public record AddProof(
        string? NAME,
        string? URL,
        string? REMARKS,
        Guid? REPORT_ID
    );

    public record EditProof(
        Guid? PROOF_ID,
        string? NAME,
        string? URL,
        string? REMARKS
    );
}