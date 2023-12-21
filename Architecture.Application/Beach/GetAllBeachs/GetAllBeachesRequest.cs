using MediatR;

namespace Architecture.Application.Beach.GetAllBeachs;

public class GetAllBeachesRequest : IRequest<List<GetAllBeachesResponse>>
{
}
