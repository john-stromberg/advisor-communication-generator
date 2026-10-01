using AdvisorCommunicationGenerator.Api.Application.Contracts;
using AdvisorCommunicationGenerator.Api.Domain;

namespace AdvisorCommunicationGenerator.Api.Application.Services;

public sealed class CommunicationService : ICommunicationService
{
    public CommunicationResult Generate(CommunicationRequest request)
    {
        var toneIntro = request.Tone switch
        {
            "Reassuring" => "I wanted to share a calm update on your portfolio progress",
            "Direct" => "Here is a direct summary of your portfolio update",
            _ => "I wanted to provide a balanced update on your portfolio"
        };

        var performanceLine =
            $"Over {request.PeriodLabel}, your portfolio changed {request.PortfolioChangePercent:+0.0;-0.0;0.0}% compared with {request.BenchmarkChangePercent:+0.0;-0.0;0.0}% for the reference benchmark.";

        var actionLine = string.IsNullOrWhiteSpace(request.ActionContext)
            ? "At our next review, we can confirm whether any allocation or cashflow adjustments are appropriate for your plan objectives."
            : request.ActionContext.Trim();

        var body =
$"Hi {request.ClientName},\n\n" +
$"{toneIntro}.\n\n" +
$"{performanceLine}\n" +
$"Market context: {request.MarketSummary.Trim()}\n\n" +
$"{actionLine}\n\n" +
"As always, this update is informational and not a recommendation to buy or sell any specific security.\n\n" +
$"Best,\n{request.AdvisorName}";

        return new CommunicationResult
        {
            Subject = $"Portfolio Update - {request.PeriodLabel}",
            Body = body,
            ComplianceNotes =
            [
                "Includes informational-only disclaimer.",
                "Avoids promises or guaranteed outcomes.",
                "Uses benchmark-relative language for context."
            ]
        };
    }
}
