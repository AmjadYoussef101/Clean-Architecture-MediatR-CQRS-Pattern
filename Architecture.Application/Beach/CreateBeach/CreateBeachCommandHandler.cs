using Architecture.Application.Context;
using AutoMapper;
using MediatR;

namespace Architecture.Application.Beach.CreateBeach;

public class CreateBeachCommandHandler : IRequestHandler<CreateBeachRequest, int>
{
    private readonly IAppDbContext _appDbContext;
    private readonly IMapper _mapper;
    public CreateBeachCommandHandler(IAppDbContext appDbContext, IMapper mapper)
    {
        _appDbContext = appDbContext;
        _mapper = mapper;
    }
    public async Task<int> Handle(CreateBeachRequest request, CancellationToken cancellationToken)
    {
        var newBeach = _mapper.Map<Domain.Entities.Beach>(request);
        _appDbContext.Beaches.Add(newBeach);
        await _appDbContext.SaveToDbAsync();
        return newBeach.Id;
    }
}
