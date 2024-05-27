using FluentValidation;
using System.Text.Json.Serialization;

namespace GotchaFeed.Controllers.Users.Dto
{
    public class UserPostDto
    {
        /// <summary>
        /// User email
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// User name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// User lastname
        /// </summary>
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// User nickname
        /// </summary>
        [JsonPropertyName("nickName")]
        public string NickName { get; set; }

        /// <summary>
        /// User birthdate
        /// </summary>
        [JsonPropertyName("birthDate")]
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// User status
        /// </summary>
        [JsonPropertyName("active")]
        public bool Active { get; set; }

        /// <summary>
        /// User nickname
        /// </summary>
        [JsonPropertyName("imgBase64")]
        public string ImgBase64 { get; set; }
    }

    public class UserValidator : AbstractValidator<UserPostDto>
    {
        public UserValidator()
        {
            RuleFor(x => x.Email)
                .NotNull().WithMessage("email must not be null")
                .NotEmpty().WithMessage("email must not be empty")
                .EmailAddress().WithMessage("email is not valid");

            RuleFor(x => x.Name)
                .NotNull().WithMessage("name must not be null")
                .NotEmpty().WithMessage("name must not be empty");

            RuleFor(x => x.LastName)
                .NotNull().WithMessage("lastName must not be null")
                .NotEmpty().WithMessage("lastName must not be empty");

            RuleFor(x => x.NickName)
                .NotNull().WithMessage("nickname must not be null")
                .NotEmpty().WithMessage("nickname must not be empty");

            RuleFor(x => x.ImgBase64)
                .NotNull().WithMessage("ImgBase64 must not be null")
                .NotEmpty().WithMessage("ImgBase64 must not be empty");

            RuleFor(x => x.BirthDate)
                .NotNull().WithMessage("birthDate must not be null");

            RuleFor(x => x.Active)
                .NotNull().WithMessage("status must not be null");
        }
    }
}
