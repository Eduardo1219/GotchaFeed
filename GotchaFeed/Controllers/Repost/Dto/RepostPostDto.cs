using FluentValidation;
using System.Text.Json.Serialization;

namespace GotchaFeed.Controllers.Repost.Dto
{
    public class RepostPostDto
    {
        /// <summary>
        /// Gotcha Id
        /// </summary>
        [JsonPropertyName("gotchaId")]
        public Guid GotchaId { get; set; }
        
        /// <summary>
        /// User Id
        /// </summary>
        [JsonPropertyName("userId")]
        public Guid UserId { get; set; }

        /// <summary>
        /// Repost Content
        /// </summary>
        [JsonPropertyName("repostContent")]
        public string RepostContent { get; set; }
    }

    public class RepostValidator : AbstractValidator<RepostPostDto>
    {
        public RepostValidator()
        {
            RuleFor(x => x.RepostContent)
                .NotNull().WithMessage("repostContent must not be null")
                .NotEmpty().WithMessage("repostContent must not be empty")
                .MaximumLength(777).WithMessage("repostContent should not be more than 777 characters");

            RuleFor(x => x.GotchaId)
                .NotNull().WithMessage("post Id must not be null")
                .NotEmpty().WithMessage("post Id must not be empty");

            RuleFor(x => x.UserId)
                .NotNull().WithMessage("user Id must not be null")
                .NotEmpty().WithMessage("user Id must not be empty");
        }
    }
}
