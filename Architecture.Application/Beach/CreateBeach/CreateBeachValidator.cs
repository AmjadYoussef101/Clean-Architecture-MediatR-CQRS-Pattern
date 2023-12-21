using FluentValidation;

namespace Architecture.Application.Beach.CreateBeach;

public class CreateBeachValidator : AbstractValidator<CreateBeachRequest>
{
    public CreateBeachValidator()
    {
        RuleFor(x => x.Name).NotEmpty();
    }
}
