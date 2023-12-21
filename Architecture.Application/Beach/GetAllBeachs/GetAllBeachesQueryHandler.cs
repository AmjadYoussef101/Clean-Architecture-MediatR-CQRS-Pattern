using Architecture.Application.Context;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Architecture.Application.Beach.GetAllBeachs;

public class GetAllBeachesQueryHandler : IRequestHandler<GetAllBeachesRequest, List<GetAllBeachesResponse>>
{
    private readonly IAppDbContext _appDbContext;
    private readonly IMapper _mapper;
    public GetAllBeachesQueryHandler(IAppDbContext appDbContext, IMapper mapper)
    {
        _appDbContext = appDbContext;
        _mapper = mapper;
    }
    public Task<List<GetAllBeachesResponse>> Handle(GetAllBeachesRequest request, CancellationToken cancellationToken)
    {
        return _appDbContext.Beaches.ProjectTo<GetAllBeachesResponse>(_mapper.ConfigurationProvider).ToListAsync();
    }
}
