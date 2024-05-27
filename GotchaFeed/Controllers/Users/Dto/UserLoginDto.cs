using FluentValidation;
using System.Text.Json.Serialization;

namespace GotchaFeed.Controllers.Users.Dto
{
    public class UserLoginDto
    {
        /// <summary>
        /// User nickname
        /// </summary>
        [JsonPropertyName("nickName")]
        public string NickName { get; set; }
    }

    public class UserLoginValidato : AbstractValidator<UserLoginDto>
    {
        public UserLoginValidato()
        {
            RuleFor(x => x.NickName)
                .NotNull().WithMessage("NickName must not be null")
                .NotEmpty().WithMessage("NickName must not be empty");
        }
    }
}
