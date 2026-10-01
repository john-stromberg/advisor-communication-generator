using AdvisorCommunicationGenerator.Api.Domain;

namespace AdvisorCommunicationGenerator.Api.Application.Contracts;

public interface ICommunicationService
{
    CommunicationResult Generate(CommunicationRequest request);
}
