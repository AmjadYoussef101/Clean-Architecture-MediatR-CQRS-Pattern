using MediatR;

namespace Architecture.Application.Beach.CreateBeach;

public class CreateBeachRequest : IRequest<int>
{
    public string Name { get; set; } = string.Empty;
    public string Place { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
}

