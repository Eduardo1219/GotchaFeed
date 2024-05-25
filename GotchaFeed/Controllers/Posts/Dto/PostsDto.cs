using Domain.Post.Entity;
using FluentValidation;
using System.Text.Json.Serialization;

namespace GotchaFeed.Controllers.Posts.Dto
{
    public class PostsDto
    {
        /// <summary>
        /// User Id
        /// </summary>
        [JsonPropertyName("repostContent")]
        public Guid UserId { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }

    public class UserValidator : AbstractValidator<PostsDto>
    {
        public UserValidator()
        {
            RuleFor(x => x.Description)
                .NotNull().WithMessage("description must not be null")
                .NotEmpty().WithMessage("description must not be empty");

            RuleFor(x => x.UserId)
                .NotNull().WithMessage("user Id must not be null")
                .NotEmpty().WithMessage("user Id must not be empty");
        }
    }
}
