namespace AdvisorCommunicationGenerator.Api.Domain;

public sealed class CommunicationRequest
{
    public string ClientName { get; set; } = string.Empty;
    public string AdvisorName { get; set; } = string.Empty;
    public string Tone { get; set; } = "Balanced"; // Reassuring, Balanced, Direct
    public string PeriodLabel { get; set; } = "this quarter";
    public decimal PortfolioChangePercent { get; set; }
    public decimal BenchmarkChangePercent { get; set; }
    public string MarketSummary { get; set; } = string.Empty;
    public string ActionContext { get; set; } = string.Empty;
}

public sealed class CommunicationResult
{
    public string Subject { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;
    public List<string> ComplianceNotes { get; set; } = [];
}
