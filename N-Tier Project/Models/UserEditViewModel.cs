using System.ComponentModel.DataAnnotations;

namespace N_Tier_Project.Models
{
    public class UserEditViewModel
    {
        [Required(ErrorMessage= "Zəhmət olmasa adınızı daxil edin")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Zəhmət olmasa soyadınızı daxil edin")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Zəhmət olmasa cinsiyətinizi seçin")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Zəhmət olmasa e-poçta daxil edin")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Zəhmət olmasa şifrə daxil edin")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Zəhmət olmasa şifrənizi təkrar daxil edin")]
        [Compare("Password",ErrorMessage = "Zəhmət olmasa şifrələrin eyni olduğundan əmin olun")]
        public string ConfirmPassword { get; set; }
    }
}
