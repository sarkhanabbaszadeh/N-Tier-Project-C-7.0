using Microsoft.AspNetCore.Identity;

namespace N_Tier_Project.Models
{
    public class CustomIdentityValidator : IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = "Şifrə ən az 6 hərfdən ibarət olmalıdır!"
            };
        }

        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",
                Description = "Şifrədə ən azı bir hərf böyük olmalıdır! (A-Z)"
            };
        }

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresLower",
                Description = "Şifrədə ən azı bir hərf kiçik olmalıdır! (a-z)"
            };
        }

        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Şifrədə ən azı bir rəqəm olmalıdır! (0-9)"
            };
        }
    }
}
