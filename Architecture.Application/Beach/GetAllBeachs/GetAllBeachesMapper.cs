using AutoMapper;

namespace Architecture.Application.Beach.GetAllBeachs;

public class GetAllBeachesMapper : Profile
{
    public GetAllBeachesMapper()
    {
        CreateMap<Architecture.Domain.Entities.Beach, GetAllBeachesResponse>();
    }
}
