using AutoMapper;

namespace Architecture.Application.Beach.CreateBeach;

public class CreateBeachMapper : Profile
{
    public CreateBeachMapper()
    {
        CreateMap<CreateBeachRequest, Domain.Entities.Beach>();
    }
}
