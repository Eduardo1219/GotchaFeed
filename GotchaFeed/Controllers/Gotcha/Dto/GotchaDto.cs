using FluentValidation;
using System.Text.Json.Serialization;

namespace GotchaFeed.Controllers.Gotcha.Dto
{
    public class GotchaDto
    {
        /// <summary>
        /// User Id
        /// </summary>
        [JsonPropertyName("userId")]
        public Guid UserId { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }

    public class GotchaValidator : AbstractValidator<GotchaDto>
    {
        public GotchaValidator()
        {
            RuleFor(x => x.Description)
                .NotNull().WithMessage("content must not be null")
                .NotEmpty().WithMessage("content must not be empty")
                .MaximumLength(777).WithMessage("content should not be more than 777 characters");

            RuleFor(x => x.UserId)
                .NotNull().WithMessage("user Id must not be null")
                .NotEmpty().WithMessage("user Id must not be empty");
        }
    }
}
