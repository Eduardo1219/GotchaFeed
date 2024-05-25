using FluentValidation;
using System.Text.Json.Serialization;

namespace GotchaFeed.Controllers.Repost.Dto
{
    public class RepostPostDto
    {
        /// <summary>
        /// Post Id
        /// </summary>
        [JsonPropertyName("repostContent")]
        public Guid PostId { get; set; }
        
        /// <summary>
        /// User Id
        /// </summary>
        [JsonPropertyName("repostContent")]
        public Guid UserId { get; set; }
        
        /// <summary>
        /// Repost Date
        /// </summary>
        [JsonPropertyName("repostContent")]
        public DateTime RepostDate { get; set; }

        /// <summary>
        /// Repost Content
        /// </summary>
        [JsonPropertyName("repostContent")]
        public string RepostContent { get; set; }
    }

    public class UserValidator : AbstractValidator<RepostPostDto>
    {
        public UserValidator()
        {
            RuleFor(x => x.RepostContent)
                .NotNull().WithMessage("repostContent must not be null")
                .NotEmpty().WithMessage("repostContent must not be empty");

            RuleFor(x => x.PostId)
                .NotNull().WithMessage("post Id must not be null")
                .NotEmpty().WithMessage("post Id must not be empty");

            RuleFor(x => x.UserId)
                .NotNull().WithMessage("user Id must not be null")
                .NotEmpty().WithMessage("user Id must not be empty");

            RuleFor(x => x.RepostDate)
                .NotNull().WithMessage("repost date must not be null")
                .NotEmpty().WithMessage("repost date must not be empty");
        }
    }
}
